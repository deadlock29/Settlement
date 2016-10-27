namespace PostingQueueMonitoring_V2
{
    partial class Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.output_richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // input_richTextBox1
            // 
            this.input_richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.input_richTextBox1.Name = "input_richTextBox1";
            this.input_richTextBox1.Size = new System.Drawing.Size(270, 379);
            this.input_richTextBox1.TabIndex = 0;
            this.input_richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.output_richTextBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(426, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // output_richTextBox2
            // 
            this.output_richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_richTextBox2.Location = new System.Drawing.Point(6, 19);
            this.output_richTextBox2.Name = "output_richTextBox2";
            this.output_richTextBox2.Size = new System.Drawing.Size(270, 379);
            this.output_richTextBox2.TabIndex = 3;
            this.output_richTextBox2.Text = "";
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(720, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Helper";
            this.Text = "SELECT_IN_HELPER";
            this.Resize += new System.EventHandler(this.Helper_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox input_richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox output_richTextBox2;


    }
}