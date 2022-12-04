using System;
using System.Drawing;
using System.Windows.Forms;


namespace ToolX.Components.CustomStatusStrip
{
    internal class CustomStatusStripColorTable : ProfessionalColorTable
    {
       
        public override Color StatusStripGradientBegin
        {
            get { return Properties.Settings.Default.StatusStripGradientBegin; }
        }

        public override Color StatusStripGradientEnd
        {
            get { return Properties.Settings.Default.StatusStripGradientEnd; }
        }
    }
}
