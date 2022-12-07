namespace HVNC
{
	// Token: 0x02000015 RID: 21
	public partial class FrmBuilder : global::System.Windows.Forms.Form
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002420 File Offset: 0x00000620
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007110 File Offset: 0x00005310
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HVNC.FrmBuilder));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label24 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.txtPORT = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.BuildBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.txtIP = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.textBox2 = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.EnableStartUpBox = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.txtPORT.BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Location = new global::System.Drawing.Point(61, 80);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(48, 13);
			this.label1.TabIndex = 151;
			this.label1.Text = "IP/DNS ";
			this.label24.AutoSize = true;
			this.label24.BackColor = global::System.Drawing.Color.Transparent;
			this.label24.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label24.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label24.Location = new global::System.Drawing.Point(61, 172);
			this.label24.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(50, 16);
			this.label24.TabIndex = 149;
			this.label24.Text = "Startup";
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Location = new global::System.Drawing.Point(361, 174);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(58, 13);
			this.label7.TabIndex = 139;
			this.label7.Text = "File name :";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(484, 31);
			this.siticoneGradientPanel4.TabIndex = 165;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(484, 34);
			this.panel1.TabIndex = 164;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(457, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 146;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.label18.AutoSize = true;
			this.label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label18.Location = new global::System.Drawing.Point(34, 8);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(107, 20);
			this.label18.TabIndex = 2;
			this.label18.Text = "Builder HVNC";
			this.txtPORT.BackColor = global::System.Drawing.Color.Transparent;
			this.txtPORT.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtPORT.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPORT.DisabledState.Parent = this.txtPORT;
			this.txtPORT.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtPORT.FocusedState.Parent = this.txtPORT;
			this.txtPORT.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPORT.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.txtPORT.Location = new global::System.Drawing.Point(319, 96);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.txtPORT;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2 = this.txtPORT;
			int[] array2 = new int[4];
			array2[0] = 1024;
			siticoneNumericUpDown2.Minimum = new decimal(array2);
			this.txtPORT.Name = "txtPORT";
			this.txtPORT.ShadowDecoration.Parent = this.txtPORT;
			this.txtPORT.Size = new global::System.Drawing.Size(100, 26);
			this.txtPORT.TabIndex = 166;
			this.txtPORT.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtPORT.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown3 = this.txtPORT;
			int[] array3 = new int[4];
			array3[0] = 4448;
			siticoneNumericUpDown3.Value = new decimal(array3);
			this.BuildBtn.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.BuildBtn.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.BuildBtn.BorderRadius = 1;
			this.BuildBtn.BorderThickness = 1;
			this.BuildBtn.CheckedState.Parent = this.BuildBtn;
			this.BuildBtn.CustomImages.Parent = this.BuildBtn;
			this.BuildBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BuildBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BuildBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BuildBtn.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BuildBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BuildBtn.DisabledState.Parent = this.BuildBtn;
			this.BuildBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.BuildBtn.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BuildBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BuildBtn.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BuildBtn.HoverState.Parent = this.BuildBtn;
			this.BuildBtn.Location = new global::System.Drawing.Point(38, 251);
			this.BuildBtn.Name = "BuildBtn";
			this.BuildBtn.ShadowDecoration.Parent = this.BuildBtn;
			this.BuildBtn.Size = new global::System.Drawing.Size(406, 30);
			this.BuildBtn.TabIndex = 167;
			this.BuildBtn.Text = "Build HVNC";
			this.BuildBtn.Click += new global::System.EventHandler(this.button1_Click);
			this.txtIP.Animated = true;
			this.txtIP.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtIP.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtIP.DefaultText = "";
			this.txtIP.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtIP.DisabledState.Parent = this.txtIP;
			this.txtIP.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtIP.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtIP.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtIP.FocusedState.Parent = this.txtIP;
			this.txtIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtIP.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtIP.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtIP.HoverState.Parent = this.txtIP;
			this.txtIP.Location = new global::System.Drawing.Point(64, 96);
			this.txtIP.Name = "txtIP";
			this.txtIP.PasswordChar = '\0';
			this.txtIP.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtIP.PlaceholderText = "";
			this.txtIP.SelectedText = "";
			this.txtIP.ShadowDecoration.Parent = this.txtIP;
			this.txtIP.Size = new global::System.Drawing.Size(249, 26);
			this.txtIP.TabIndex = 168;
			this.txtIP.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.Animated = true;
			this.textBox2.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textBox2.DefaultText = "";
			this.textBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox2.DisabledState.Parent = this.textBox2;
			this.textBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox2.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox2.FocusedState.Parent = this.textBox2;
			this.textBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textBox2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.textBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox2.HoverState.Parent = this.textBox2;
			this.textBox2.Location = new global::System.Drawing.Point(64, 197);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '\0';
			this.textBox2.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.textBox2.PlaceholderText = "";
			this.textBox2.SelectedText = "";
			this.textBox2.ShadowDecoration.Parent = this.textBox2;
			this.textBox2.Size = new global::System.Drawing.Size(355, 26);
			this.textBox2.TabIndex = 168;
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.EnableStartUpBox.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.EnableStartUpBox.CheckedState.BorderRadius = 2;
			this.EnableStartUpBox.CheckedState.BorderThickness = 1;
			this.EnableStartUpBox.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.EnableStartUpBox.CheckedState.Parent = this.EnableStartUpBox;
			this.EnableStartUpBox.Location = new global::System.Drawing.Point(64, 141);
			this.EnableStartUpBox.Name = "EnableStartUpBox";
			this.EnableStartUpBox.ShadowDecoration.Parent = this.EnableStartUpBox;
			this.EnableStartUpBox.Size = new global::System.Drawing.Size(25, 25);
			this.EnableStartUpBox.TabIndex = 169;
			this.EnableStartUpBox.Text = "siticoneCustomCheckBox1";
			this.EnableStartUpBox.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.EnableStartUpBox.UncheckedState.BorderRadius = 2;
			this.EnableStartUpBox.UncheckedState.BorderThickness = 0;
			this.EnableStartUpBox.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.EnableStartUpBox.UncheckedState.Parent = this.EnableStartUpBox;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(484, 302);
			base.Controls.Add(this.EnableStartUpBox);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.txtIP);
			base.Controls.Add(this.BuildBtn);
			base.Controls.Add(this.txtPORT);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label24);
			this.ForeColor = global::System.Drawing.Color.GhostWhite;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FrmBuilder";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HVNC Builder";
			base.Load += new global::System.EventHandler(this.FrmBuilder_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.txtPORT.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003D RID: 61
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000041 RID: 65
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000043 RID: 67
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000046 RID: 70
		private global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtPORT;

		// Token: 0x04000047 RID: 71
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BuildBtn;

		// Token: 0x04000048 RID: 72
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox2;

		// Token: 0x04000049 RID: 73
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtIP;

		// Token: 0x0400004A RID: 74
		private global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox EnableStartUpBox;

		// Token: 0x0400004B RID: 75
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x0400004C RID: 76
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
