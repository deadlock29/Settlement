namespace PostingQueueMonitoring_V2
{
    partial class OpenICSMonitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenICSMonitoring));
            this.load_Button = new System.Windows.Forms.Button();
            this.load_dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.load_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // load_Button
            // 
            this.load_Button.Location = new System.Drawing.Point(12, 12);
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(149, 40);
            this.load_Button.TabIndex = 0;
            this.load_Button.Text = "LOAD";
            this.load_Button.UseVisualStyleBackColor = true;
            this.load_Button.Click += new System.EventHandler(this.load_Button_Click);
            // 
            // load_dataGridView1
            // 
            this.load_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.load_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.load_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.load_dataGridView1.Name = "load_dataGridView1";
            this.load_dataGridView1.Size = new System.Drawing.Size(991, 246);
            this.load_dataGridView1.TabIndex = 1;
            // 
            // OpenICSMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1015, 316);
            this.Controls.Add(this.load_dataGridView1);
            this.Controls.Add(this.load_Button);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenICSMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenICSMonitoring";
            ((System.ComponentModel.ISupportInitialize)(this.load_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_Button;
        private System.Windows.Forms.DataGridView load_dataGridView1;
    }
}