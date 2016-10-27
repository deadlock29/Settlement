using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PostingQueueMonitoring_V2
{
    public partial class OpenICSMonitoring : Form
    {
        public OpenICSMonitoring()
        {
            InitializeComponent();
        }

        private void load_Button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=icsprodsql.traxtech.com;Initial Catalog=Issue Control Sheets;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand("usp_OpenICSMonitoring", conn);
            string sqlStringQuery = "select * from [dbo].[tbl_OpenICSInformation] order by Customer";

            SqlDataAdapter dataadapterOpenICS = new SqlDataAdapter(sqlStringQuery, conn);
            DataSet dsOpenICS = new DataSet();

            try 
            {
                conn.Open(); 
                    cmd.ExecuteNonQuery();
                    dataadapterOpenICS.Fill(dsOpenICS, "OpenICS_Table");
                conn.Close();

                load_dataGridView1.DataSource = dsOpenICS;
                load_dataGridView1.DataMember = "OpenICS_Table";
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
