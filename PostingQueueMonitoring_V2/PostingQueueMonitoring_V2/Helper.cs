using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PostingQueueMonitoring_V2
{
    public partial class Helper : Form
    {
        public Helper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if (String.IsNullOrEmpty(input_richTextBox1.Text.Trim()))
            {
                MessageBox.Show("Please input text...");
                return;
            }

            try
            {
                string sOutputList = "(";
                string quoteStr = "'";
                string formatString1 = ",";

                string sSource = input_richTextBox1.Text.Trim();
                string[] sSeparators = { "\n", ".", "/", " ", "\r", "\t" };
                string[] words = sSource.Split(sSeparators, StringSplitOptions.RemoveEmptyEntries);

                for (var i = 0; i < words.Length; i++)
                {
                    if (words[i].Trim().Length > 0)
                    {
                        var lineValue = words[i];
                        sOutputList += quoteStr + lineValue + quoteStr + formatString1 + "\n";
                    }
                }
                output_richTextBox2.Text = sOutputList.Substring(0, sOutputList.Length - 2);

                if (output_richTextBox2.Text.Length > 0)
                {
                    output_richTextBox2.Text = output_richTextBox2.Text + ")";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Helper_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(736, 466);
            this.MaximumSize = new Size(736, 466);
            this.CenterToScreen();
        }
    }
}
