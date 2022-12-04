using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolX.NotePad
{
    public partial class GoTo_Form : Form
    {
        RichTextBox richText;
        public GoTo_Form(RichTextBox R)
        {
            InitializeComponent();
            richText = R;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoTo_Form_Load(object sender, EventArgs e)
        {
            int lines = richText.Lines.Length;
            lblLocal1.Text = "Enter Line Number (1-" + lines.ToString() + ") :";

            int sel = richText.GetLineFromCharIndex(richText.SelectionStart);
            txtGoLine.Text = sel.ToString();
        }

        private void txtGoLine_TextChanged(object sender, EventArgs e)
        {
            int sel;
            RichTextBox rtb = new RichTextBox();
            rtb.Text = richText.Text;
            int lines = rtb.Lines.Length;

            if (txtGoLine.Text == "")
            {
                GoBtn.Enabled = false;
            }
            else if (!int.TryParse(txtGoLine.Text, out sel))
            {
                GoBtn.Enabled = false;
            }
            else if (Int32.Parse(txtGoLine.Text) > rtb.Lines.Length)
            {
                GoBtn.Enabled = false;
            }
            else if (txtGoLine.Text == "0")
            {
                GoBtn.Enabled = false;
            }
            else
            {
                GoBtn.Enabled = true;
            }
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            int line = Int32.Parse(txtGoLine.Text);
            richText.SelectionStart = richText.GetFirstCharIndexFromLine(line - 1);
            richText.ScrollToCaret();
            this.Close();
        }

    }
}
