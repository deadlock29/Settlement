select * from owners


DECLARE @NoOfDaysPrior 			AS Int 
DECLARE @CheckDateToUse			AS VARCHAR(50) 

SET @NoOfDaysPrior 		    = 15 
SET @CheckDateToUse			= 'ForwardDate' --InvoiceDueDate, InvoiceCreateDate, ForwardDate, ExecutionDate, InPaymentNew

IF OBJECT_ID('tempdb..#t_FBInfo') IS NOT NULL DROP TABLE #t_FBInfo
SELECT         
 		outFRGHT_BL.FB_ID,      
		outFRGHT_BL.INV_ID, 
		INVOICE_EXT.InvNId,     
		PAYR_DTL.BAT_ID,      
		outFRGHT_BL.BAT_KEY,      
		'Approve'   AS Action_Code,      
		outFRGHT_BL.FB_APP_AMT  AS PAYMT_REQ_APP_AMT,      
		CAST(NULL  AS [VARCHAR](20)) AS ACT_REASON,      
		CAST(NULL  AS [VARCHAR](20)) AS ACT_REASON_DESC,      
		outFRGHT_BL.OWNER_KEY,      
		outFRGHT_BL.VEND_LABL,      
		VENDOR_REMIT.PAYMT_TYPE,      
		outFRGHT_BL.FB_APP_AMT,
		PAYR_DTL.RCRD_CREAT_DTM,  
		ISNULL(PAYR_DTL.PAYMT_REQ_CURRENCY_QUAL,'USD') AS CURRENCYCODE,
		CASE WHEN @CheckDateToUse = 'InvoiceDueDate' THEN DATEADD(dd, DATEDIFF(dd, 0, CAST(ISNUll(dbo.outINVOICE.INV_DUE_DTM,GetDate()) as datetime)), 0)
			WHEN @CheckDateToUse = 'InvoiceCreateDate' THEN DATEADD(dd, DATEDIFF(dd, 0, CAST(ISNUll(dbo.outINVOICE.INV_CREAT_DTM,GetDate()) as datetime)), 0)
			WHEN @CheckDateToUse = 'ForwardDate' THEN DATEADD(dd, DATEDIFF(dd, 0, CAST(ISNUll(dbo.PAYR_DTL.[%T003],GetDate()) as datetime)), 0)
			WHEN @CheckDateToUse = 'ExecutionDate' THEN DATEADD(dd, DATEDIFF(dd, 0, GetDate()), 0)
			WHEN @CheckDateToUse = 'InPaymentNew' THEN DATEADD(dd, DATEDIFF(dd, 0, CAST(ISNUll(dbo.PAYR_DTL.RCRD_CREAT_DTM,GetDate()) as datetime)), 0)
		END AS PaymentDate
      into #t_FBInfo
	FROM  dbo.outFRGHT_BL WITH (NOLOCK)      
         
	INNER JOIN dbo.PAYR_DTL WITH (NOLOCK)       
 		ON outFRGHT_BL.FB_ID=PAYR_DTL.FB_ID      
     
	INNER JOIN dbo.outINVOICE WITH (NOLOCK)      
 		ON PAYR_DTL.INV_ID=outINVOICE.INV_ID		     
     
    INNER JOIN dbo.INVOICE_EXT WITH (NOLOCK)
    	ON outINVOICE.INV_ID=INVOICE_EXT.INV_ID
            
	INNER JOIN  dbo.VENDOR_REMIT WITH (NOLOCK)      
  		ON PAYR_DTL.OWNER_KEY = VENDOR_REMIT.OWNER_KEY       
  		AND outFRGHT_BL.VEND_LABL = VENDOR_REMIT.VEND_LABL       
  		AND PAYR_DTL.PAYMT_REQ_CURRENCY_QUAL = VENDOR_REMIT.CURRENCY_QUAL       
        
	WHERE    
	    dbo.outFRGHT_BL.FB_ID LIKE 'FBLL0001220%'     
       	AND (outFRGHT_BL.FB_STAT='Denied' or outFRGHT_BL.FB_STAT='Open')      
 		AND PAYR_DTL.RCRD_CREAT_DTM<=DATEADD(dd, @NoOfDaysPrior, GETDATE())      
 		AND PAYR_DTL.FUNDS_APP_TEMP_ID IS NULL
		--AND outFRGHT_BL.INV_ID = 'INVC0001010000022550003'

select * from #t_FBInfo

DECLARE @BusinessFlow  			AS [nvarchar](100)
DECLARE @ExecPath	   			AS [nvarchar](100)
SET @BusinessFlow  			= 'Quintiles'
SET @ExecPath	   			= 'PrePay'

IF OBJECT_ID('tempdb..#t_Multiclient') IS NOT NULL DROP TABLE #t_Multiclient        
	    
	CREATE TABLE #t_Multiclient(        
		[FB_ID]   [varchar](23)  NOT NULL,        
	) ON [PRIMARY]
	   
	INSERT INTO #t_Multiclient -- BILLS TO BE EXCLUDED FROM THE AUTO-CLOSE PROCESS    
		SELECT 
			F.FB_ID  
		FROM  #t_FBInfo AS F        
		INNER JOIN BNorm.FbNormFactLayer AS flow WITH(NOLOCK)     
			ON flow.FB_ID=F.FB_ID
		INNER JOIN PAYR_DTL AS P WITH(NOLOCK)     
			ON P.FB_ID=F.FB_ID		
		WHERE 		
			NOT flow.BusinessFlow LIKE '%' + ISNULL(@BusinessFlow,'') + '%'     
			OR NOT flow.ExecPath LIKE '%' + ISNULL(@ExecPath,'') + '%' 
			OR (P.FWRD_KEY IS NULL AND P.FUNDS_REQ_KEY IS NULL)
			OR ((NOT P.FWRD_KEY IS NULL OR NOT P.FUNDS_REQ_KEY IS NULL) AND P.fb_due_dtm >= getdate())  

select * from #t_Multiclient

DELETE FROM #t_FBInfo      
FROM #t_FBInfo  AS F        
INNER JOIN #t_Multiclient as V    
	ON F.FB_ID = V.FB_ID

select distinct inv_id from #t_FBInfo
--===============================================================================================================================================
/*
Quintiles.AMR.US		Visibility_1
Quintiles.AMR.US|EAI	PrePay_2
Quintiles.APAC.JP		Visibility_1
Quintiles.APAC.SG		Visibility_1
Quintiles.EMEA.BG		Visibility_1
Quintiles.EMEA.GB		Visibility_1
Quintiles.EMEA.GB|EAI	PrePay_1
*/