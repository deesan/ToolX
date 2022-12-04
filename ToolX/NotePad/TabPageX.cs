using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ToolX.NotePad
{
    public class TabPageX : TabPage
    {
        public NotePadMain NPMain;
        public MyRichTextBox _myRichTextBoxX = new MyRichTextBox();

        public TabPageX(NotePad.NotePadMain nm)
        {
            NPMain = nm;
            this._myRichTextBoxX.Dock = DockStyle.Fill;

            this._myRichTextBoxX.richTextBox1.Text = "";
            _myRichTextBoxX.richTextBox1.Font = new System.Drawing.Font("Monospaced", 10, FontStyle.Regular);
            this._myRichTextBoxX.richTextBox1.Select();

            _myRichTextBoxX.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
            _myRichTextBoxX.richTextBox1.SelectionChanged += new EventHandler(this.richTextBox1_SelectionChanged);

            _myRichTextBoxX.richTextBox1.LinkClicked += new LinkClickedEventHandler(this.richTextBox1_LinkClicked);

            this.Controls.Add(_myRichTextBoxX);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = this.Text;
            if (str.Contains("*"))
            { }
            else
            {
                this.Text = str + "*";
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int sel = _myRichTextBoxX.richTextBox1.SelectionStart;
            int line = _myRichTextBoxX.richTextBox1.GetLineFromCharIndex(sel) + 1;
            int col = sel - _myRichTextBoxX.richTextBox1.GetFirstCharIndexFromLine(line - 1) + 1;

            NPMain.LineToolStripLabel.Text = "Line : " + line.ToString();
            NPMain.ColumnToolStripLabel.Text = "Col : " + col.ToString();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
