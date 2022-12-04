using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToolX.Components.CustomMenuStrip
{
    internal class CustomMenuStripColorTable : ProfessionalColorTable
    {
        
        public override Color MenuStripGradientBegin
        {
            get { return Properties.Settings.Default.MenuStripGradientBegin; }
        }

        public override Color MenuStripGradientEnd
        {
            get { return Properties.Settings.Default.MenuStripGradientEnd; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Properties.Settings.Default.MenuItemPressedGradientBegin; }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Properties.Settings.Default.MenuItemPressedGradientMiddle; }
        }

       public override Color MenuItemPressedGradientEnd
        {
            get { return Properties.Settings.Default.MenuItemPressedGradientEnd; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Properties.Settings.Default.MenuItemSelectedGradientBegin; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Properties.Settings.Default.MenuItemSelectedGradientEnd; }
        }

        public override Color MenuItemSelected
        {
            get { return Properties.Settings.Default.MenuItemSelected; }
        }

        public override Color MenuBorder
        {
            get { return Properties.Settings.Default.MenuBorder; }
        }

        public override Color MenuItemBorder
        {
            get { return Properties.Settings.Default.MenuItemBorder; }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return Properties.Settings.Default.ImageMarginGradientBegin; }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return Properties.Settings.Default.ImageMarginGradientMiddle; }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return Properties.Settings.Default.ImageMarginGradientEnd; }
        }
    }
}
