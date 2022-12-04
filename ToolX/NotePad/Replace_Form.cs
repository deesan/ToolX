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
    public partial class Replace_Form : Form
    {
        RichTextBox richtext;
        public Replace_Form(RichTextBox R)
        {
            InitializeComponent();
            richtext = R;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
