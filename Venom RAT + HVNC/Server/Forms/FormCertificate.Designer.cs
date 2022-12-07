namespace Server.Forms
{
	// Token: 0x0200009C RID: 156
	public partial class FormCertificate : global::System.Windows.Forms.Form
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x00004870 File Offset: 0x00002A70
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0003CD08 File Offset: 0x0003AF08
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormCertificate));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.button1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.textBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label1.Location = new global::System.Drawing.Point(77, 105);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(81, 16);
			this.label1.TabIndex = 160;
			this.label1.Text = "Sever name";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 6);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(243, 18);
			this.label2.TabIndex = 129;
			this.label2.Text = "Venom Remote Administration Tool";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(594, 31);
			this.siticoneGradientPanel4.TabIndex = 162;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(594, 34);
			this.panel1.TabIndex = 161;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(567, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
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
			this.button1.Location = new global::System.Drawing.Point(409, 124);
			this.button1.Name = "button1";
			this.button1.ShadowDecoration.Parent = this.button1;
			this.button1.Size = new global::System.Drawing.Size(108, 30);
			this.button1.TabIndex = 164;
			this.button1.Text = "Save";
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.textBox1.Animated = true;
			this.textBox1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textBox1.DefaultText = "VenomRAT Server";
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
			this.textBox1.Location = new global::System.Drawing.Point(80, 124);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '\0';
			this.textBox1.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.textBox1.PlaceholderText = "";
			this.textBox1.SelectedText = "";
			this.textBox1.SelectionStart = 15;
			this.textBox1.ShadowDecoration.Parent = this.textBox1;
			this.textBox1.Size = new global::System.Drawing.Size(296, 30);
			this.textBox1.TabIndex = 163;
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(594, 232);
			base.ControlBox = false;
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormCertificate";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Certificate";
			base.Load += new global::System.EventHandler(this.FormCertificate_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400040A RID: 1034
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400040C RID: 1036
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400040D RID: 1037
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x0400040E RID: 1038
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400040F RID: 1039
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000410 RID: 1040
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button1;

		// Token: 0x04000411 RID: 1041
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox1;

		// Token: 0x04000412 RID: 1042
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000413 RID: 1043
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
