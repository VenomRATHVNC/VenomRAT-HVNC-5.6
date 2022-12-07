namespace Server.Forms
{
	// Token: 0x020000A1 RID: 161
	public partial class FormFileSearcher : global::System.Windows.Forms.Form
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x0000497F File Offset: 0x00002B7F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00040D74 File Offset: 0x0003EF74
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFileSearcher));
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.txtExtnsions = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnOk = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.numericUpDown1 = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label4 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.panel2.SuspendLayout();
			this.numericUpDown1.BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.panel2.Controls.Add(this.txtExtnsions);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnOk);
			this.panel2.Controls.Add(this.numericUpDown1);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(0, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(361, 175);
			this.panel2.TabIndex = 165;
			this.txtExtnsions.Animated = true;
			this.txtExtnsions.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtExtnsions.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtExtnsions.DefaultText = "";
			this.txtExtnsions.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtExtnsions.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtExtnsions.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExtnsions.DisabledState.Parent = this.txtExtnsions;
			this.txtExtnsions.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExtnsions.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtExtnsions.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtExtnsions.FocusedState.Parent = this.txtExtnsions;
			this.txtExtnsions.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtExtnsions.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.txtExtnsions.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtExtnsions.HoverState.Parent = this.txtExtnsions;
			this.txtExtnsions.Location = new global::System.Drawing.Point(41, 49);
			this.txtExtnsions.Name = "txtExtnsions";
			this.txtExtnsions.PasswordChar = '\0';
			this.txtExtnsions.PlaceholderForeColor = global::System.Drawing.Color.Gainsboro;
			this.txtExtnsions.PlaceholderText = ".txt .pdf .doc";
			this.txtExtnsions.SelectedText = "";
			this.txtExtnsions.ShadowDecoration.Parent = this.txtExtnsions;
			this.txtExtnsions.Size = new global::System.Drawing.Size(279, 28);
			this.txtExtnsions.TabIndex = 134;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7f);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(146, 108);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(23, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "MB";
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(38, 33);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type:";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(38, 82);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(51, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max size:";
			this.btnOk.Animated = true;
			this.btnOk.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnOk.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnOk.BorderRadius = 1;
			this.btnOk.BorderThickness = 1;
			this.btnOk.CheckedState.Parent = this.btnOk;
			this.btnOk.CustomImages.Parent = this.btnOk;
			this.btnOk.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnOk.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnOk.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnOk.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnOk.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnOk.DisabledState.Parent = this.btnOk;
			this.btnOk.FillColor = global::System.Drawing.Color.Transparent;
			this.btnOk.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnOk.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnOk.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnOk.HoverState.Parent = this.btnOk;
			this.btnOk.Location = new global::System.Drawing.Point(214, 98);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShadowDecoration.Parent = this.btnOk;
			this.btnOk.Size = new global::System.Drawing.Size(106, 26);
			this.btnOk.TabIndex = 133;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.numericUpDown1.BackColor = global::System.Drawing.Color.Transparent;
			this.numericUpDown1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numericUpDown1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.numericUpDown1.DisabledState.Parent = this.numericUpDown1;
			this.numericUpDown1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.numericUpDown1.FocusedState.Parent = this.numericUpDown1;
			this.numericUpDown1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.numericUpDown1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.numericUpDown1.Location = new global::System.Drawing.Point(41, 98);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ShadowDecoration.Parent = this.numericUpDown1;
			this.numericUpDown1.Size = new global::System.Drawing.Size(100, 26);
			this.numericUpDown1.TabIndex = 132;
			this.numericUpDown1.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numericUpDown1.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(2, 6);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(103, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "File Searcher";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(361, 31);
			this.siticoneGradientPanel4.TabIndex = 166;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(361, 34);
			this.panel1.TabIndex = 167;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(334, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(361, 240);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormFileSearcher";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "File Searcher";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.numericUpDown1.EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400045A RID: 1114
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400045B RID: 1115
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400045C RID: 1116
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtExtnsions;

		// Token: 0x0400045D RID: 1117
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400045E RID: 1118
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400045F RID: 1119
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000460 RID: 1120
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnOk;

		// Token: 0x04000461 RID: 1121
		public global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numericUpDown1;

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000463 RID: 1123
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000464 RID: 1124
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000465 RID: 1125
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000466 RID: 1126
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000467 RID: 1127
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000468 RID: 1128
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
