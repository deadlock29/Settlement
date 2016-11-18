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
                string msg = "Please input text.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, caption, buttons, icon);
                return;
            }

            try
            {
                string sOutputList = "(";
                string quoteStr = "'";
                string formatString1 = ",";

                // This will remove the listed separators from input text
                string sSource = input_richTextBox1.Text.Trim();
                string[] sSeparators = { "\n", "/", " ", "\r", "\t", "," };
                string[] words = sSource.Split(sSeparators, StringSplitOptions.RemoveEmptyEntries);

                // For loop of text arrays
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
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Helper_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(736, 466);
            this.MaximumSize = new Size(736, 466);
            this.CenterToScreen();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_richTextBox1.SelectionLength > 0)
                input_richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_richTextBox1.SelectionLength > 0)
                input_richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                input_richTextBox1.Paste();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_richTextBox1.CanUndo)
            {
                input_richTextBox1.Undo();
                input_richTextBox1.ClearUndo();
            }
        }
    }
}
