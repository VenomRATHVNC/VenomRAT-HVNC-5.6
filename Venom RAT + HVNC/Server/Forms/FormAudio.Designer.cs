namespace Server.Forms
{
	// Token: 0x02000099 RID: 153
	public partial class FormAudio : global::System.Windows.Forms.Form
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00004750 File Offset: 0x00002950
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000343DC File Offset: 0x000325DC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormAudio));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.btnStartStopRecord = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.textBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label1.Location = new global::System.Drawing.Point(43, 101);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(47, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "seconds";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(76, 18);
			this.label3.TabIndex = 129;
			this.label3.Text = "Recording";
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel2.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.panel2.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel2.Location = new global::System.Drawing.Point(0, 34);
			this.panel2.Name = "panel2";
			this.panel2.ShadowDecoration.Parent = this.panel2;
			this.panel2.Size = new global::System.Drawing.Size(530, 31);
			this.panel2.TabIndex = 167;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(530, 34);
			this.panel1.TabIndex = 166;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(503, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.btnStartStopRecord.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnStartStopRecord.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnStartStopRecord.BorderRadius = 1;
			this.btnStartStopRecord.BorderThickness = 1;
			this.btnStartStopRecord.CheckedState.Parent = this.btnStartStopRecord;
			this.btnStartStopRecord.CustomImages.Parent = this.btnStartStopRecord;
			this.btnStartStopRecord.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnStartStopRecord.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnStartStopRecord.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnStartStopRecord.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnStartStopRecord.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnStartStopRecord.DisabledState.Parent = this.btnStartStopRecord;
			this.btnStartStopRecord.FillColor = global::System.Drawing.Color.Transparent;
			this.btnStartStopRecord.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnStartStopRecord.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnStartStopRecord.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.btnStartStopRecord.HoverState.Parent = this.btnStartStopRecord;
			this.btnStartStopRecord.Location = new global::System.Drawing.Point(358, 117);
			this.btnStartStopRecord.Name = "btnStartStopRecord";
			this.btnStartStopRecord.ShadowDecoration.Parent = this.btnStartStopRecord;
			this.btnStartStopRecord.Size = new global::System.Drawing.Size(108, 30);
			this.btnStartStopRecord.TabIndex = 169;
			this.btnStartStopRecord.Text = "Recording";
			this.btnStartStopRecord.Click += new global::System.EventHandler(this.btnStartStopRecord_Click);
			this.textBox1.Animated = true;
			this.textBox1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textBox1.DefaultText = "15";
			this.textBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.DisabledState.Parent = this.textBox1;
			this.textBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.FocusedState.Parent = this.textBox1;
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textBox1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.textBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.HoverState.Parent = this.textBox1;
			this.textBox1.Location = new global::System.Drawing.Point(46, 117);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '\0';
			this.textBox1.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.textBox1.PlaceholderText = "";
			this.textBox1.SelectedText = "";
			this.textBox1.SelectionStart = 2;
			this.textBox1.ShadowDecoration.Parent = this.textBox1;
			this.textBox1.Size = new global::System.Drawing.Size(296, 30);
			this.textBox1.TabIndex = 168;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(530, 224);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.btnStartStopRecord);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(530, 224);
			this.MinimumSize = new global::System.Drawing.Size(530, 224);
			base.Name = "FormAudio";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audio Recorder";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003B1 RID: 945
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003B2 RID: 946
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040003B3 RID: 947
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003B4 RID: 948
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel panel2;

		// Token: 0x040003B5 RID: 949
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040003B6 RID: 950
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040003B7 RID: 951
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnStartStopRecord;

		// Token: 0x040003B8 RID: 952
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040003B9 RID: 953
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040003BA RID: 954
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox1;

		// Token: 0x040003BB RID: 955
		public global::System.Windows.Forms.Label label1;
	}
}
