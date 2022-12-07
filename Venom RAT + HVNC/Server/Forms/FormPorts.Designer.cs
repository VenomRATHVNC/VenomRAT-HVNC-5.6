namespace Server.Forms
{
	// Token: 0x020000A3 RID: 163
	public partial class FormPorts : global::System.Windows.Forms.Form
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x00004A72 File Offset: 0x00002C72
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00042A54 File Offset: 0x00040C54
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormPorts));
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.button1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.textPorts = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.textPorts.BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(217, 18);
			this.label1.TabIndex = 129;
			this.label1.Text = "Cracked by Alkaisa";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(716, 31);
			this.siticoneGradientPanel4.TabIndex = 166;
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
			this.button1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.button1.HoverState.Parent = this.button1;
			this.button1.Location = new global::System.Drawing.Point(185, 217);
			this.button1.Name = "button1";
			this.button1.ShadowDecoration.Parent = this.button1;
			this.button1.Size = new global::System.Drawing.Size(233, 30);
			this.button1.TabIndex = 165;
			this.button1.Text = "Welcome";
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textPorts.BackColor = global::System.Drawing.Color.Transparent;
			this.textPorts.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textPorts.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textPorts.DisabledState.Parent = this.textPorts;
			this.textPorts.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.textPorts.FocusedState.Parent = this.textPorts;
			this.textPorts.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textPorts.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.textPorts.Location = new global::System.Drawing.Point(424, 217);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.textPorts;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2 = this.textPorts;
			int[] array2 = new int[4];
			array2[0] = 1024;
			siticoneNumericUpDown2.Minimum = new decimal(array2);
			this.textPorts.Name = "textPorts";
			this.textPorts.ShadowDecoration.Parent = this.textPorts;
			this.textPorts.Size = new global::System.Drawing.Size(100, 30);
			this.textPorts.TabIndex = 164;
			this.textPorts.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textPorts.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown3 = this.textPorts;
			int[] array3 = new int[4];
			array3[0] = 4449;
			siticoneNumericUpDown3.Value = new decimal(array3);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(716, 34);
			this.panel1.TabIndex = 167;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(689, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(88, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(531, 85);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 168;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(716, 298);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.textPorts);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormPorts";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listen ports";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.PortsFrm_FormClosed);
			base.Load += new global::System.EventHandler(this.PortsFrm_Load);
			this.textPorts.EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400047C RID: 1148
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400047D RID: 1149
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400047E RID: 1150
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x0400047F RID: 1151
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button1;

		// Token: 0x04000480 RID: 1152
		private global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown textPorts;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000482 RID: 1154
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000483 RID: 1155
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000484 RID: 1156
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000485 RID: 1157
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
