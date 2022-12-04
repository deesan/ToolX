namespace ToolX.NotePad
{
    partial class Find_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Form));
            this.BasePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.HeaderPaenl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblFormName = new Guna.UI.WinForms.GunaLabel();
            this.ClosePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.DirectionGBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DownrBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.UpRBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.CasesensitiveChbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.FindBtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtFindText = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLocal1 = new Guna.UI.WinForms.GunaLabel();
            this.HeaderPanelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Mainelips = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.formNameDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BasePanel.SuspendLayout();
            this.HeaderPaenl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.DirectionGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.Transparent;
            this.BasePanel.BorderColor = System.Drawing.Color.White;
            this.BasePanel.BorderRadius = 2;
            this.BasePanel.BorderThickness = 2;
            this.BasePanel.Controls.Add(this.HeaderPaenl);
            this.BasePanel.Controls.Add(this.DirectionGBox);
            this.BasePanel.Controls.Add(this.CasesensitiveChbox);
            this.BasePanel.Controls.Add(this.FindBtn);
            this.BasePanel.Controls.Add(this.txtFindText);
            this.BasePanel.Controls.Add(this.lblLocal1);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.BasePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.BasePanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.ShadowDecoration.Parent = this.BasePanel;
            this.BasePanel.Size = new System.Drawing.Size(430, 148);
            this.BasePanel.TabIndex = 0;
            // 
            // HeaderPaenl
            // 
            this.HeaderPaenl.BorderColor = System.Drawing.Color.White;
            this.HeaderPaenl.BorderRadius = 2;
            this.HeaderPaenl.BorderThickness = 1;
            this.HeaderPaenl.Controls.Add(this.lblFormName);
            this.HeaderPaenl.Controls.Add(this.ClosePic);
            this.HeaderPaenl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.HeaderPaenl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.HeaderPaenl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.HeaderPaenl.Location = new System.Drawing.Point(2, 2);
            this.HeaderPaenl.Name = "HeaderPaenl";
            this.HeaderPaenl.ShadowDecoration.Parent = this.HeaderPaenl;
            this.HeaderPaenl.Size = new System.Drawing.Size(426, 30);
            this.HeaderPaenl.TabIndex = 12;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.BackColor = System.Drawing.Color.Transparent;
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(5, 4);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(43, 21);
            this.lblFormName.TabIndex = 1;
            this.lblFormName.Text = "Find";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClosePic
            // 
            this.ClosePic.BackColor = System.Drawing.Color.Transparent;
            this.ClosePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(397, 2);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ClosePic.ShadowDecoration.Parent = this.ClosePic;
            this.ClosePic.Size = new System.Drawing.Size(26, 26);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 0;
            this.ClosePic.TabStop = false;
            this.ClosePic.UseTransparentBackground = true;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // DirectionGBox
            // 
            this.DirectionGBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.DirectionGBox.BorderRadius = 1;
            this.DirectionGBox.Controls.Add(this.DownrBtn);
            this.DirectionGBox.Controls.Add(this.UpRBtn);
            this.DirectionGBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.DirectionGBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.DirectionGBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.DirectionGBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DirectionGBox.ForeColor = System.Drawing.Color.White;
            this.DirectionGBox.Location = new System.Drawing.Point(175, 80);
            this.DirectionGBox.Name = "DirectionGBox";
            this.DirectionGBox.ShadowDecoration.Parent = this.DirectionGBox;
            this.DirectionGBox.Size = new System.Drawing.Size(230, 55);
            this.DirectionGBox.TabIndex = 17;
            this.DirectionGBox.Text = "Direction";
            this.DirectionGBox.TextOffset = new System.Drawing.Point(0, -10);
            this.DirectionGBox.Visible = false;
            // 
            // DownrBtn
            // 
            this.DownrBtn.Animated = true;
            this.DownrBtn.AutoSize = true;
            this.DownrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.DownrBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(190)))));
            this.DownrBtn.CheckedState.BorderThickness = 0;
            this.DownrBtn.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.DownrBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DownrBtn.CheckedState.InnerOffset = -4;
            this.DownrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownrBtn.ForeColor = System.Drawing.Color.White;
            this.DownrBtn.Location = new System.Drawing.Point(111, 25);
            this.DownrBtn.Name = "DownrBtn";
            this.DownrBtn.Size = new System.Drawing.Size(66, 24);
            this.DownrBtn.TabIndex = 1;
            this.DownrBtn.TabStop = true;
            this.DownrBtn.Text = "Down";
            this.DownrBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DownrBtn.UncheckedState.BorderThickness = 2;
            this.DownrBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DownrBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.DownrBtn.UseVisualStyleBackColor = false;
            // 
            // UpRBtn
            // 
            this.UpRBtn.Animated = true;
            this.UpRBtn.AutoSize = true;
            this.UpRBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.UpRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(190)))));
            this.UpRBtn.CheckedState.BorderThickness = 0;
            this.UpRBtn.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.UpRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.UpRBtn.CheckedState.InnerOffset = -4;
            this.UpRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpRBtn.ForeColor = System.Drawing.Color.White;
            this.UpRBtn.Location = new System.Drawing.Point(41, 25);
            this.UpRBtn.Name = "UpRBtn";
            this.UpRBtn.Size = new System.Drawing.Size(46, 24);
            this.UpRBtn.TabIndex = 1;
            this.UpRBtn.TabStop = true;
            this.UpRBtn.Text = "Up";
            this.UpRBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.UpRBtn.UncheckedState.BorderThickness = 2;
            this.UpRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.UpRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.UpRBtn.UseVisualStyleBackColor = false;
            // 
            // CasesensitiveChbox
            // 
            this.CasesensitiveChbox.AutoSize = true;
            this.CasesensitiveChbox.BackColor = System.Drawing.Color.Transparent;
            this.CasesensitiveChbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(190)))));
            this.CasesensitiveChbox.CheckedState.BorderRadius = 2;
            this.CasesensitiveChbox.CheckedState.BorderThickness = 0;
            this.CasesensitiveChbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(190)))));
            this.CasesensitiveChbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CasesensitiveChbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CasesensitiveChbox.ForeColor = System.Drawing.Color.White;
            this.CasesensitiveChbox.Location = new System.Drawing.Point(28, 96);
            this.CasesensitiveChbox.Name = "CasesensitiveChbox";
            this.CasesensitiveChbox.Size = new System.Drawing.Size(119, 24);
            this.CasesensitiveChbox.TabIndex = 16;
            this.CasesensitiveChbox.Text = "Case sensitive";
            this.CasesensitiveChbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CasesensitiveChbox.UncheckedState.BorderRadius = 2;
            this.CasesensitiveChbox.UncheckedState.BorderThickness = 0;
            this.CasesensitiveChbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CasesensitiveChbox.UseVisualStyleBackColor = false;
            this.CasesensitiveChbox.Visible = false;
            // 
            // FindBtn
            // 
            this.FindBtn.Animated = true;
            this.FindBtn.BackColor = System.Drawing.Color.Transparent;
            this.FindBtn.BorderColor = System.Drawing.Color.White;
            this.FindBtn.BorderRadius = 1;
            this.FindBtn.BorderThickness = 1;
            this.FindBtn.CheckedState.Parent = this.FindBtn;
            this.FindBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindBtn.CustomImages.Parent = this.FindBtn;
            this.FindBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FindBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.FindBtn.ForeColor = System.Drawing.Color.Black;
            this.FindBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.FindBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.FindBtn.HoverState.Parent = this.FindBtn;
            this.FindBtn.Location = new System.Drawing.Point(303, 41);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.ShadowDecoration.Parent = this.FindBtn;
            this.FindBtn.Size = new System.Drawing.Size(119, 26);
            this.FindBtn.TabIndex = 15;
            this.FindBtn.Text = "Find";
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // txtFindText
            // 
            this.txtFindText.Animated = true;
            this.txtFindText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.txtFindText.BorderRadius = 2;
            this.txtFindText.BorderThickness = 2;
            this.txtFindText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindText.DefaultText = "";
            this.txtFindText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindText.DisabledState.Parent = this.txtFindText;
            this.txtFindText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFindText.FocusedState.BorderColor = System.Drawing.Color.Lime;
            this.txtFindText.FocusedState.Parent = this.txtFindText;
            this.txtFindText.ForeColor = System.Drawing.Color.White;
            this.txtFindText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindText.HoverState.Parent = this.txtFindText;
            this.txtFindText.Location = new System.Drawing.Point(87, 43);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.PasswordChar = '\0';
            this.txtFindText.PlaceholderText = "";
            this.txtFindText.SelectedText = "";
            this.txtFindText.ShadowDecoration.Parent = this.txtFindText;
            this.txtFindText.Size = new System.Drawing.Size(210, 22);
            this.txtFindText.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtFindText.TabIndex = 14;
            // 
            // lblLocal1
            // 
            this.lblLocal1.AutoSize = true;
            this.lblLocal1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal1.ForeColor = System.Drawing.Color.White;
            this.lblLocal1.Location = new System.Drawing.Point(7, 42);
            this.lblLocal1.Name = "lblLocal1";
            this.lblLocal1.Size = new System.Drawing.Size(76, 20);
            this.lblLocal1.TabIndex = 13;
            this.lblLocal1.Text = "Find what:";
            // 
            // HeaderPanelDrag
            // 
            this.HeaderPanelDrag.TargetControl = this.HeaderPaenl;
            // 
            // Mainelips
            // 
            this.Mainelips.BorderRadius = 2;
            this.Mainelips.TargetControl = this;
            // 
            // formNameDrag
            // 
            this.formNameDrag.TargetControl = this.lblFormName;
            // 
            // Find_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 148);
            this.Controls.Add(this.BasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find_Form";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            this.HeaderPaenl.ResumeLayout(false);
            this.HeaderPaenl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.DirectionGBox.ResumeLayout(false);
            this.DirectionGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel BasePanel;
        private Guna.UI2.WinForms.Guna2GradientPanel HeaderPaenl;
        private Guna.UI.WinForms.GunaLabel lblFormName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ClosePic;
        private Guna.UI2.WinForms.Guna2GroupBox DirectionGBox;
        private Guna.UI2.WinForms.Guna2RadioButton DownrBtn;
        private Guna.UI2.WinForms.Guna2RadioButton UpRBtn;
        private Guna.UI2.WinForms.Guna2CheckBox CasesensitiveChbox;
        private Guna.UI2.WinForms.Guna2Button FindBtn;
        private Guna.UI2.WinForms.Guna2TextBox txtFindText;
        private Guna.UI.WinForms.GunaLabel lblLocal1;
        private Guna.UI2.WinForms.Guna2DragControl HeaderPanelDrag;
        private Guna.UI2.WinForms.Guna2Elipse Mainelips;
        private Guna.UI2.WinForms.Guna2DragControl formNameDrag;

    }
}