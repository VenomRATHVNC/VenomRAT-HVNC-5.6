namespace Server.Forms
{
	// Token: 0x020000A2 RID: 162
	public partial class FormKeylogger : global::System.Windows.Forms.Form
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00004A18 File Offset: 0x00002C18
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00041BF0 File Offset: 0x0003FDF0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormKeylogger));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneGradientPanel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.siticoneResizeBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox();
			this.toolStripTextBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.toolStripLabel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.toolStripButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.panel1.SuspendLayout();
			this.siticoneGradientPanel1.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Interval = 1000;
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 65);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(774, 366);
			this.richTextBox1.TabIndex = 166;
			this.richTextBox1.Text = "";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(2, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(163, 18);
			this.label1.TabIndex = 131;
			this.label1.Text = "Venom RAT KeyLogger";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(774, 31);
			this.siticoneGradientPanel4.TabIndex = 167;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(774, 34);
			this.panel1.TabIndex = 168;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(747, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneGradientPanel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripButton1);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripLabel1);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripTextBox1);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneResizeBox1);
			this.siticoneGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Location = new global::System.Drawing.Point(0, 431);
			this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
			this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
			this.siticoneGradientPanel1.Size = new global::System.Drawing.Size(774, 28);
			this.siticoneGradientPanel1.TabIndex = 169;
			this.siticoneResizeBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneResizeBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneResizeBox1.FillColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneResizeBox1.ForeColor = global::System.Drawing.Color.Black;
			this.siticoneResizeBox1.Location = new global::System.Drawing.Point(750, 6);
			this.siticoneResizeBox1.Name = "siticoneResizeBox1";
			this.siticoneResizeBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneResizeBox1.TabIndex = 1;
			this.toolStripTextBox1.Animated = true;
			this.toolStripTextBox1.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.toolStripTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.toolStripTextBox1.DefaultText = "";
			this.toolStripTextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.toolStripTextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.toolStripTextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.toolStripTextBox1.DisabledState.Parent = this.toolStripTextBox1;
			this.toolStripTextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.toolStripTextBox1.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.toolStripTextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.toolStripTextBox1.FocusedState.Parent = this.toolStripTextBox1;
			this.toolStripTextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.toolStripTextBox1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripTextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.toolStripTextBox1.HoverState.Parent = this.toolStripTextBox1;
			this.toolStripTextBox1.Location = new global::System.Drawing.Point(73, 0);
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.PasswordChar = '\0';
			this.toolStripTextBox1.PlaceholderForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripTextBox1.PlaceholderText = "...";
			this.toolStripTextBox1.SelectedText = "";
			this.toolStripTextBox1.ShadowDecoration.Parent = this.toolStripTextBox1;
			this.toolStripTextBox1.Size = new global::System.Drawing.Size(99, 28);
			this.toolStripTextBox1.TabIndex = 135;
			this.toolStripTextBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyDown);
			this.toolStripLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripLabel1.BorderColor = global::System.Drawing.Color.Transparent;
			this.toolStripLabel1.BorderRadius = 1;
			this.toolStripLabel1.BorderThickness = 1;
			this.toolStripLabel1.CheckedState.Parent = this.toolStripLabel1;
			this.toolStripLabel1.CustomImages.Parent = this.toolStripLabel1;
			this.toolStripLabel1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.toolStripLabel1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.toolStripLabel1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.toolStripLabel1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.toolStripLabel1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.toolStripLabel1.DisabledState.Parent = this.toolStripLabel1;
			this.toolStripLabel1.FillColor = global::System.Drawing.Color.Transparent;
			this.toolStripLabel1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.toolStripLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.toolStripLabel1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripLabel1.HoverState.Parent = this.toolStripLabel1;
			this.toolStripLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.ShadowDecoration.Parent = this.toolStripLabel1;
			this.toolStripLabel1.Size = new global::System.Drawing.Size(73, 28);
			this.toolStripLabel1.TabIndex = 136;
			this.toolStripLabel1.Text = "Search";
			this.toolStripButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripButton1.BorderColor = global::System.Drawing.Color.Transparent;
			this.toolStripButton1.BorderRadius = 1;
			this.toolStripButton1.BorderThickness = 1;
			this.toolStripButton1.CheckedState.Parent = this.toolStripButton1;
			this.toolStripButton1.CustomImages.Parent = this.toolStripButton1;
			this.toolStripButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.toolStripButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.toolStripButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.toolStripButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.toolStripButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.toolStripButton1.DisabledState.Parent = this.toolStripButton1;
			this.toolStripButton1.FillColor = global::System.Drawing.Color.Transparent;
			this.toolStripButton1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.toolStripButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.toolStripButton1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripButton1.HoverState.Parent = this.toolStripButton1;
			this.toolStripButton1.Location = new global::System.Drawing.Point(172, 0);
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.ShadowDecoration.Parent = this.toolStripButton1;
			this.toolStripButton1.Size = new global::System.Drawing.Size(73, 28);
			this.toolStripButton1.TabIndex = 136;
			this.toolStripButton1.Text = "Save";
			this.toolStripButton1.Click += new global::System.EventHandler(this.ToolStripButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(774, 459);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneGradientPanel1);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormKeylogger";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Keylogger";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Keylogger_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.siticoneGradientPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400046D RID: 1133
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400046E RID: 1134
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400046F RID: 1135
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000470 RID: 1136
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000471 RID: 1137
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000472 RID: 1138
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000473 RID: 1139
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000474 RID: 1140
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000475 RID: 1141
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000476 RID: 1142
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;

		// Token: 0x04000477 RID: 1143
		private global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox siticoneResizeBox1;

		// Token: 0x04000478 RID: 1144
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox toolStripTextBox1;

		// Token: 0x04000479 RID: 1145
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton toolStripButton1;

		// Token: 0x0400047A RID: 1146
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton toolStripLabel1;
	}
}
