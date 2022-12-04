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
    public partial class Find_Form : Form
    {
        RichTextBox richtext;
        public Find_Form(RichTextBox R)
        {
            InitializeComponent();
            richtext = R;
        }

        public static void Find(RichTextBox rtb, String word, Color color)
        {
            if (word == "")
            {
                return;
            }

            int s_start = rtb.SelectionStart, startIndex = 0, index;
            while((index = rtb.Text.IndexOf(word, startIndex)) != -1)
            {
                rtb.Select(index, word.Length);
                rtb.SelectionColor = color;
                startIndex = index + word.Length;
            }
            rtb.SelectionStart = s_start;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = Color.Black;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            Find(richtext, txtFindText.Text, Color.Gray);
        }
    }
}
