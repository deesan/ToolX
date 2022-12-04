using System;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace ToolX.Components
{
    public partial class MinMaxPictureBoxX : PictureBox
    {
        #region variables
        public Color color = Color.White;

        public enum CustomFormState
        {
            Normal,
            Maximize
        }

        CustomFormState _customFormState;

        #endregion

        public CustomFormState CFormState
        {
            get { return _customFormState; }
            set { _customFormState = value; Invalidate(); }
        }

        public MinMaxPictureBoxX()
        {
            this.Size = new System.Drawing.Size(50, 50);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            switch (_customFormState)
            {
                case CustomFormState.Normal:
                    //pe.Graphics.DrawImage(ToolX.Properties.Resources.maximize_window_Resize_48px, 0,0);
                    break;
                case CustomFormState.Maximize:
                    //pe.Graphics.DrawImage(ToolX.Properties.Resources.restore_window_Resize_48px, 0, 0);
                    break;
            }
        }
    }
}
