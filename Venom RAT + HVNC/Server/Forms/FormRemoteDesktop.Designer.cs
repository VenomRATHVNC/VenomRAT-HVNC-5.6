namespace Server.Forms
{
	// Token: 0x020000A7 RID: 167
	public partial class FormRemoteDesktop : global::System.Windows.Forms.Form
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00004C2B File Offset: 0x00002E2B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000447A0 File Offset: 0x000429A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRemoteDesktop));
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label7 = new global::System.Windows.Forms.Label();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.btnKeyboard = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.numericUpDown2 = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.btnMouse = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.label4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.button1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.numericUpDown1 = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.labelWait = new global::System.Windows.Forms.Label();
			this.timerSave = new global::System.Windows.Forms.Timer(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneResizeBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox();
			this.panel1.SuspendLayout();
			this.siticoneGradientPanel4.SuspendLayout();
			this.numericUpDown2.BeginInit();
			this.numericUpDown1.BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(1011, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1038, 36);
			this.panel1.TabIndex = 169;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label7.Location = new global::System.Drawing.Point(3, 6);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(130, 20);
			this.label7.TabIndex = 20;
			this.label7.Text = "Remote Desktop";
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.btnKeyboard);
			this.siticoneGradientPanel4.Controls.Add(this.btnMouse);
			this.siticoneGradientPanel4.Controls.Add(this.button1);
			this.siticoneGradientPanel4.Controls.Add(this.numericUpDown1);
			this.siticoneGradientPanel4.Controls.Add(this.label1);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 36);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(1038, 35);
			this.siticoneGradientPanel4.TabIndex = 168;
			this.btnKeyboard.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnKeyboard.Animated = true;
			this.btnKeyboard.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnKeyboard.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnKeyboard.BorderRadius = 1;
			this.btnKeyboard.BorderThickness = 1;
			this.btnKeyboard.CheckedState.Parent = this.btnKeyboard;
			this.btnKeyboard.CustomImages.Parent = this.btnKeyboard;
			this.btnKeyboard.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnKeyboard.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnKeyboard.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnKeyboard.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnKeyboard.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnKeyboard.DisabledState.Parent = this.btnKeyboard;
			this.btnKeyboard.FillColor = global::System.Drawing.Color.Transparent;
			this.btnKeyboard.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnKeyboard.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnKeyboard.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnKeyboard.HoverState.Parent = this.btnKeyboard;
			this.btnKeyboard.Location = new global::System.Drawing.Point(879, 3);
			this.btnKeyboard.Name = "btnKeyboard";
			this.btnKeyboard.ShadowDecoration.Parent = this.btnKeyboard;
			this.btnKeyboard.Size = new global::System.Drawing.Size(147, 28);
			this.btnKeyboard.TabIndex = 146;
			this.btnKeyboard.Text = "Start/Stop Keyboard";
			this.btnKeyboard.Click += new global::System.EventHandler(this.btnKeyboard_Click);
			this.numericUpDown2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numericUpDown2.BackColor = global::System.Drawing.Color.Transparent;
			this.numericUpDown2.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numericUpDown2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.numericUpDown2.DisabledState.Parent = this.numericUpDown2;
			this.numericUpDown2.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.numericUpDown2.FocusedState.Parent = this.numericUpDown2;
			this.numericUpDown2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.numericUpDown2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.numericUpDown2.Location = new global::System.Drawing.Point(487, 114);
			this.numericUpDown2.Maximum = new decimal(new int[4]);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.ShadowDecoration.Parent = this.numericUpDown2;
			this.numericUpDown2.Size = new global::System.Drawing.Size(100, 28);
			this.numericUpDown2.TabIndex = 133;
			this.numericUpDown2.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numericUpDown2.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			this.numericUpDown2.Visible = false;
			this.btnMouse.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMouse.Animated = true;
			this.btnMouse.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnMouse.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnMouse.BorderRadius = 1;
			this.btnMouse.BorderThickness = 1;
			this.btnMouse.CheckedState.Parent = this.btnMouse;
			this.btnMouse.CustomImages.Parent = this.btnMouse;
			this.btnMouse.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMouse.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMouse.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnMouse.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnMouse.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMouse.DisabledState.Parent = this.btnMouse;
			this.btnMouse.FillColor = global::System.Drawing.Color.Transparent;
			this.btnMouse.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnMouse.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMouse.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnMouse.HoverState.Parent = this.btnMouse;
			this.btnMouse.Location = new global::System.Drawing.Point(730, 3);
			this.btnMouse.Name = "btnMouse";
			this.btnMouse.ShadowDecoration.Parent = this.btnMouse;
			this.btnMouse.Size = new global::System.Drawing.Size(126, 28);
			this.btnMouse.TabIndex = 146;
			this.btnMouse.Text = "Start/Stop Mouse";
			this.btnMouse.Click += new global::System.EventHandler(this.Button3_Click);
			this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label4.Animated = true;
			this.label4.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.label4.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.label4.BorderRadius = 1;
			this.label4.BorderThickness = 1;
			this.label4.CheckedState.Parent = this.label4;
			this.label4.CustomImages.Parent = this.label4;
			this.label4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.label4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.label4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.label4.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.label4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.label4.DisabledState.Parent = this.label4;
			this.label4.FillColor = global::System.Drawing.Color.Transparent;
			this.label4.FillColor2 = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.label4.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label4.HoverState.Parent = this.label4;
			this.label4.Location = new global::System.Drawing.Point(593, 114);
			this.label4.Name = "label4";
			this.label4.ShadowDecoration.Parent = this.label4;
			this.label4.Size = new global::System.Drawing.Size(125, 28);
			this.label4.TabIndex = 146;
			this.label4.Text = "Start/Stop Capture";
			this.label4.Visible = false;
			this.label4.Click += new global::System.EventHandler(this.BtnSave_Click);
			this.button1.Animated = true;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.button1.BorderRadius = 1;
			this.button1.BorderThickness = 1;
			this.button1.CheckedState.Parent = this.button1;
			this.button1.CustomImages.Parent = this.button1;
			this.button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.button1.DisabledState.Parent = this.button1;
			this.button1.FillColor = global::System.Drawing.Color.Transparent;
			this.button1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.button1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.button1.HoverState.Parent = this.button1;
			this.button1.Location = new global::System.Drawing.Point(12, 3);
			this.button1.Name = "button1";
			this.button1.ShadowDecoration.Parent = this.button1;
			this.button1.Size = new global::System.Drawing.Size(109, 28);
			this.button1.TabIndex = 132;
			this.button1.Text = "Start/Stop";
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.numericUpDown1.BackColor = global::System.Drawing.Color.Transparent;
			this.numericUpDown1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numericUpDown1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.numericUpDown1.DisabledState.Parent = this.numericUpDown1;
			this.numericUpDown1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.numericUpDown1.FocusedState.Parent = this.numericUpDown1;
			this.numericUpDown1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.numericUpDown1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.numericUpDown1.Location = new global::System.Drawing.Point(256, 3);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ShadowDecoration.Parent = this.numericUpDown1;
			this.numericUpDown1.Size = new global::System.Drawing.Size(100, 28);
			this.numericUpDown1.TabIndex = 133;
			this.numericUpDown1.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numericUpDown1.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 30;
			siticoneNumericUpDown2.Value = new decimal(array2);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label1.Location = new global::System.Drawing.Point(202, 10);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(49, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Quality";
			this.labelWait.AutoSize = true;
			this.labelWait.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.labelWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.labelWait.ForeColor = global::System.Drawing.Color.White;
			this.labelWait.Location = new global::System.Drawing.Point(456, 340);
			this.labelWait.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWait.Name = "labelWait";
			this.labelWait.Size = new global::System.Drawing.Size(53, 20);
			this.labelWait.TabIndex = 166;
			this.labelWait.Text = "Wait...";
			this.timerSave.Interval = 1500;
			this.timer1.Interval = 2000;
			this.pictureBox1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 71);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(1038, 581);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 165;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.FormRemoteDesktop_Load);
			this.pictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
			this.siticoneResizeBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneResizeBox1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.siticoneResizeBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneResizeBox1.ForeColor = global::System.Drawing.Color.Black;
			this.siticoneResizeBox1.Location = new global::System.Drawing.Point(1015, 632);
			this.siticoneResizeBox1.Name = "siticoneResizeBox1";
			this.siticoneResizeBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneResizeBox1.TabIndex = 170;
			this.siticoneResizeBox1.TargetControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ControlDarkDark;
			base.ClientSize = new global::System.Drawing.Size(1038, 652);
			base.Controls.Add(this.siticoneResizeBox1);
			base.Controls.Add(this.labelWait);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.numericUpDown2);
			base.Controls.Add(this.label4);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			this.MinimumSize = new global::System.Drawing.Size(442, 300);
			base.Name = "FormRemoteDesktop";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remote Desktop";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormRemoteDesktop_FormClosed);
			base.Load += new global::System.EventHandler(this.FormRemoteDesktop_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.FormRemoteDesktop_KeyDown);
			base.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.FormRemoteDesktop_KeyUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.siticoneGradientPanel4.PerformLayout();
			this.numericUpDown2.EndInit();
			this.numericUpDown1.EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004AC RID: 1196
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004AD RID: 1197
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040004AE RID: 1198
		public global::System.Windows.Forms.Label labelWait;

		// Token: 0x040004AF RID: 1199
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004B0 RID: 1200
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040004B1 RID: 1201
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnKeyboard;

		// Token: 0x040004B2 RID: 1202
		public global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numericUpDown2;

		// Token: 0x040004B3 RID: 1203
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnMouse;

		// Token: 0x040004B4 RID: 1204
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton label4;

		// Token: 0x040004B5 RID: 1205
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button1;

		// Token: 0x040004B6 RID: 1206
		public global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numericUpDown1;

		// Token: 0x040004B7 RID: 1207
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004B8 RID: 1208
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004B9 RID: 1209
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040004BA RID: 1210
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040004BB RID: 1211
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040004BC RID: 1212
		private global::System.Windows.Forms.Timer timerSave;

		// Token: 0x040004BD RID: 1213
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x040004BE RID: 1214
		private global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox siticoneResizeBox1;
	}
}
