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

            string[] myText = new string[] {input_richTextBox1.Text};
            foreach (string element in myText)
            {
                output_richTextBox2.Text = element;
                System.Console.WriteLine(output_richTextBox2.Text);
                /*var textValues = input_richTextBox1.Text.Split('\n').Select(txt => $"'{txt}'");
                var textValues = input_richTextBox1.Text.Split('\n').Select(myText => $"'{txt}'");
                var concatValues = string.Join(",", textValues);
                output_richTextBox2.Text = concatValues;
                System.Console.WriteLine();*/
            }
            System.Console.WriteLine();
            //output_richTextBox2.Rtf = input_richTextBox1.Rtf;
        }

        private void Helper_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(736, 466);
            this.MaximumSize = new Size(736, 466);
        }
    }
}
