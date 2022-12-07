namespace Server.Forms
{
	// Token: 0x020000AA RID: 170
	public partial class FormWebcam : global::System.Windows.Forms.Form
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x00004D8A File Offset: 0x00002F8A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000471B4 File Offset: 0x000453B4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormWebcam));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timerSave = new global::System.Windows.Forms.Timer(this.components);
			this.labelWait = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.comboBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneComboBox();
			this.numericUpDown1 = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.button1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.btnSave = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneResizeBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.siticoneGradientPanel4.SuspendLayout();
			this.numericUpDown1.BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.pictureBox1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 87);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(703, 378);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 165;
			this.pictureBox1.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label2.Location = new global::System.Drawing.Point(2, 7);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(75, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "WebCam";
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label1.Location = new global::System.Drawing.Point(243, 6);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(30, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "FPS:";
			this.timer1.Interval = 1000;
			this.timerSave.Interval = 1000;
			this.labelWait.AutoSize = true;
			this.labelWait.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.labelWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelWait.ForeColor = global::System.Drawing.Color.White;
			this.labelWait.Location = new global::System.Drawing.Point(286, 263);
			this.labelWait.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWait.Name = "labelWait";
			this.labelWait.Size = new global::System.Drawing.Size(101, 20);
			this.labelWait.TabIndex = 166;
			this.labelWait.Text = "Please wait...";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.comboBox1);
			this.siticoneGradientPanel4.Controls.Add(this.numericUpDown1);
			this.siticoneGradientPanel4.Controls.Add(this.button1);
			this.siticoneGradientPanel4.Controls.Add(this.btnSave);
			this.siticoneGradientPanel4.Controls.Add(this.label1);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(703, 53);
			this.siticoneGradientPanel4.TabIndex = 168;
			this.comboBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.comboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBox1.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.comboBox1.BorderRadius = 1;
			this.comboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.comboBox1.FocusedColor = global::System.Drawing.Color.Transparent;
			this.comboBox1.FocusedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.comboBox1.FocusedState.Parent = this.comboBox1;
			this.comboBox1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.comboBox1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.comboBox1.HoverState.Parent = this.comboBox1;
			this.comboBox1.ItemHeight = 30;
			this.comboBox1.ItemsAppearance.Parent = this.comboBox1;
			this.comboBox1.Location = new global::System.Drawing.Point(352, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.ShadowDecoration.Color = global::System.Drawing.Color.Transparent;
			this.comboBox1.ShadowDecoration.Parent = this.comboBox1;
			this.comboBox1.Size = new global::System.Drawing.Size(116, 36);
			this.comboBox1.TabIndex = 160;
			this.numericUpDown1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.numericUpDown1.BackColor = global::System.Drawing.Color.Transparent;
			this.numericUpDown1.BorderColor = global::System.Drawing.Color.Transparent;
			this.numericUpDown1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.numericUpDown1.DisabledState.Parent = this.numericUpDown1;
			this.numericUpDown1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.numericUpDown1.FocusedState.Parent = this.numericUpDown1;
			this.numericUpDown1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.numericUpDown1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.numericUpDown1.Location = new global::System.Drawing.Point(246, 20);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ShadowDecoration.Parent = this.numericUpDown1;
			this.numericUpDown1.Size = new global::System.Drawing.Size(100, 22);
			this.numericUpDown1.TabIndex = 133;
			this.numericUpDown1.UpDownButtonFillColor = global::System.Drawing.Color.Transparent;
			this.numericUpDown1.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 50;
			siticoneNumericUpDown2.Value = new decimal(array2);
			this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.button1.Animated = true;
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.button1.BorderRadius = 1;
			this.button1.BorderThickness = 2;
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
			this.button1.Location = new global::System.Drawing.Point(99, 6);
			this.button1.Name = "button1";
			this.button1.ShadowDecoration.Parent = this.button1;
			this.button1.Size = new global::System.Drawing.Size(124, 36);
			this.button1.TabIndex = 132;
			this.button1.Text = "Start/Stop CAM";
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.btnSave.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnSave.Animated = true;
			this.btnSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSave.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.btnSave.BorderRadius = 1;
			this.btnSave.BorderThickness = 2;
			this.btnSave.CheckedState.Parent = this.btnSave;
			this.btnSave.CustomImages.Parent = this.btnSave;
			this.btnSave.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnSave.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnSave.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnSave.DisabledState.Parent = this.btnSave;
			this.btnSave.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSave.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnSave.HoverState.Parent = this.btnSave;
			this.btnSave.Location = new global::System.Drawing.Point(491, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.ShadowDecoration.Parent = this.btnSave;
			this.btnSave.Size = new global::System.Drawing.Size(109, 36);
			this.btnSave.TabIndex = 132;
			this.btnSave.Text = "Screen";
			this.btnSave.Click += new global::System.EventHandler(this.BtnSave_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(703, 34);
			this.panel1.TabIndex = 169;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(676, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneResizeBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneResizeBox1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.siticoneResizeBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneResizeBox1.ForeColor = global::System.Drawing.Color.Black;
			this.siticoneResizeBox1.Location = new global::System.Drawing.Point(683, 445);
			this.siticoneResizeBox1.Name = "siticoneResizeBox1";
			this.siticoneResizeBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneResizeBox1.TabIndex = 171;
			this.siticoneResizeBox1.TargetControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(703, 465);
			base.Controls.Add(this.siticoneResizeBox1);
			base.Controls.Add(this.labelWait);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormWebcam";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remote Camera";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormWebcam_FormClosed);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.siticoneGradientPanel4.PerformLayout();
			this.numericUpDown1.EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004E7 RID: 1255
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004E8 RID: 1256
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004E9 RID: 1257
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004EA RID: 1258
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004EB RID: 1259
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x040004EC RID: 1260
		private global::System.Windows.Forms.Timer timerSave;

		// Token: 0x040004ED RID: 1261
		public global::System.Windows.Forms.Label labelWait;

		// Token: 0x040004EE RID: 1262
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040004EF RID: 1263
		public global::Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox1;

		// Token: 0x040004F0 RID: 1264
		public global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numericUpDown1;

		// Token: 0x040004F1 RID: 1265
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button1;

		// Token: 0x040004F2 RID: 1266
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnSave;

		// Token: 0x040004F3 RID: 1267
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004F4 RID: 1268
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040004F5 RID: 1269
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040004F6 RID: 1270
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040004F7 RID: 1271
		private global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox siticoneResizeBox1;
	}
}
