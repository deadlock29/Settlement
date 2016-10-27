namespace PostingQueueMonitoring_V2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.environment_comboBox1 = new System.Windows.Forms.ComboBox();
            this.production_radioButton1 = new System.Windows.Forms.RadioButton();
            this.test_radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.all_radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.helper_button3 = new System.Windows.Forms.Button();
            this.ics_button3 = new System.Windows.Forms.Button();
            this.textBox3_DNS = new System.Windows.Forms.TextBox();
            this.textBox4_DB = new System.Windows.Forms.TextBox();
            this.label1_GUID = new System.Windows.Forms.Label();
            this.label2_DNS = new System.Windows.Forms.Label();
            this.label3_DB = new System.Windows.Forms.Label();
            this.textBox2_GUID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // environment_comboBox1
            // 
            this.environment_comboBox1.FormattingEnabled = true;
            this.environment_comboBox1.Location = new System.Drawing.Point(12, 74);
            this.environment_comboBox1.Name = "environment_comboBox1";
            this.environment_comboBox1.Size = new System.Drawing.Size(249, 21);
            this.environment_comboBox1.TabIndex = 0;
            this.environment_comboBox1.SelectedIndexChanged += new System.EventHandler(this.environment_comboBox1_SelectedIndexChanged);
            // 
            // production_radioButton1
            // 
            this.production_radioButton1.AutoSize = true;
            this.production_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.production_radioButton1.Location = new System.Drawing.Point(16, 28);
            this.production_radioButton1.Name = "production_radioButton1";
            this.production_radioButton1.Size = new System.Drawing.Size(90, 20);
            this.production_radioButton1.TabIndex = 1;
            this.production_radioButton1.TabStop = true;
            this.production_radioButton1.Text = "Production";
            this.production_radioButton1.UseVisualStyleBackColor = true;
            this.production_radioButton1.CheckedChanged += new System.EventHandler(this.production_radioButton1_CheckedChanged);
            // 
            // test_radioButton2
            // 
            this.test_radioButton2.AutoSize = true;
            this.test_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_radioButton2.Location = new System.Drawing.Point(112, 28);
            this.test_radioButton2.Name = "test_radioButton2";
            this.test_radioButton2.Size = new System.Drawing.Size(53, 20);
            this.test_radioButton2.TabIndex = 2;
            this.test_radioButton2.TabStop = true;
            this.test_radioButton2.Text = "Test";
            this.test_radioButton2.UseVisualStyleBackColor = true;
            this.test_radioButton2.CheckedChanged += new System.EventHandler(this.test_radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.all_radioButton1);
            this.groupBox1.Controls.Add(this.production_radioButton1);
            this.groupBox1.Controls.Add(this.test_radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENVIRONMENT";
            // 
            // all_radioButton1
            // 
            this.all_radioButton1.AutoSize = true;
            this.all_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_radioButton1.Location = new System.Drawing.Point(180, 28);
            this.all_radioButton1.Name = "all_radioButton1";
            this.all_radioButton1.Size = new System.Drawing.Size(41, 20);
            this.all_radioButton1.TabIndex = 3;
            this.all_radioButton1.TabStop = true;
            this.all_radioButton1.Text = "All";
            this.all_radioButton1.UseVisualStyleBackColor = true;
            this.all_radioButton1.CheckedChanged += new System.EventHandler(this.all_radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 470);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(460, 165);
            this.dataGridView2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(831, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 192);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STATUS";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1291, 504);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "POSTING QUEUE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "ENTRY EXECUTING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox4.Location = new System.Drawing.Point(1062, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 45);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FUNC_MEMO SEARCH";
            // 
            // helper_button3
            // 
            this.helper_button3.Location = new System.Drawing.Point(204, 215);
            this.helper_button3.Name = "helper_button3";
            this.helper_button3.Size = new System.Drawing.Size(143, 45);
            this.helper_button3.TabIndex = 12;
            this.helper_button3.Text = "HELPER";
            this.helper_button3.UseVisualStyleBackColor = true;
            this.helper_button3.Click += new System.EventHandler(this.helper_button3_Click);
            // 
            // ics_button3
            // 
            this.ics_button3.Location = new System.Drawing.Point(353, 215);
            this.ics_button3.Name = "ics_button3";
            this.ics_button3.Size = new System.Drawing.Size(143, 45);
            this.ics_button3.TabIndex = 13;
            this.ics_button3.Text = "OPEN ICS";
            this.ics_button3.UseVisualStyleBackColor = true;
            this.ics_button3.Click += new System.EventHandler(this.ics_button3_Click);
            // 
            // textBox3_DNS
            // 
            this.textBox3_DNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3_DNS.Location = new System.Drawing.Point(547, 47);
            this.textBox3_DNS.Name = "textBox3_DNS";
            this.textBox3_DNS.Size = new System.Drawing.Size(278, 20);
            this.textBox3_DNS.TabIndex = 15;
            // 
            // textBox4_DB
            // 
            this.textBox4_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4_DB.Location = new System.Drawing.Point(547, 73);
            this.textBox4_DB.Name = "textBox4_DB";
            this.textBox4_DB.Size = new System.Drawing.Size(278, 20);
            this.textBox4_DB.TabIndex = 16;
            // 
            // label1_GUID
            // 
            this.label1_GUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_GUID.AutoSize = true;
            this.label1_GUID.Location = new System.Drawing.Point(505, 25);
            this.label1_GUID.Name = "label1_GUID";
            this.label1_GUID.Size = new System.Drawing.Size(37, 13);
            this.label1_GUID.TabIndex = 17;
            this.label1_GUID.Text = "GUID:";
            // 
            // label2_DNS
            // 
            this.label2_DNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2_DNS.AutoSize = true;
            this.label2_DNS.Location = new System.Drawing.Point(509, 51);
            this.label2_DNS.Name = "label2_DNS";
            this.label2_DNS.Size = new System.Drawing.Size(33, 13);
            this.label2_DNS.TabIndex = 18;
            this.label2_DNS.Text = "DNS:";
            // 
            // label3_DB
            // 
            this.label3_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_DB.AutoSize = true;
            this.label3_DB.Location = new System.Drawing.Point(517, 77);
            this.label3_DB.Name = "label3_DB";
            this.label3_DB.Size = new System.Drawing.Size(25, 13);
            this.label3_DB.TabIndex = 19;
            this.label3_DB.Text = "DB:";
            // 
            // textBox2_GUID
            // 
            this.textBox2_GUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_GUID.Location = new System.Drawing.Point(547, 22);
            this.textBox2_GUID.Name = "textBox2_GUID";
            this.textBox2_GUID.Size = new System.Drawing.Size(278, 20);
            this.textBox2_GUID.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1315, 782);
            this.Controls.Add(this.textBox2_GUID);
            this.Controls.Add(this.label3_DB);
            this.Controls.Add(this.label2_DNS);
            this.Controls.Add(this.label1_GUID);
            this.Controls.Add(this.textBox4_DB);
            this.Controls.Add(this.textBox3_DNS);
            this.Controls.Add(this.ics_button3);
            this.Controls.Add(this.helper_button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.environment_comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Posting Queue Monitoring";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox environment_comboBox1;
        private System.Windows.Forms.RadioButton production_radioButton1;
        private System.Windows.Forms.RadioButton test_radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton all_radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button helper_button3;
        private System.Windows.Forms.Button ics_button3;
        private System.Windows.Forms.TextBox textBox3_DNS;
        private System.Windows.Forms.TextBox textBox4_DB;
        private System.Windows.Forms.Label label1_GUID;
        private System.Windows.Forms.Label label2_DNS;
        private System.Windows.Forms.Label label3_DB;
        private System.Windows.Forms.TextBox textBox2_GUID;
    }
}

