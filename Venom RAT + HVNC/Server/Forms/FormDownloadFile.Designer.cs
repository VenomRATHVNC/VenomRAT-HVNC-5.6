namespace Server.Forms
{
	// Token: 0x020000A8 RID: 168
	public partial class FormDownloadFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00004C8C File Offset: 0x00002E8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00045EEC File Offset: 0x000440EC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormDownloadFile));
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.labelfile = new global::System.Windows.Forms.Label();
			this.labelsize = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(8, 115);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 13);
			this.label1.TabIndex = 159;
			this.label1.Text = "Downloaad:";
			this.timer1.Interval = 10000;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(442, 31);
			this.siticoneGradientPanel4.TabIndex = 164;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(442, 34);
			this.panel1.TabIndex = 163;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(415, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 6);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(83, 18);
			this.label2.TabIndex = 129;
			this.label2.Text = "Downloads";
			this.labelfile.AutoSize = true;
			this.labelfile.Location = new global::System.Drawing.Point(69, 81);
			this.labelfile.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelfile.Name = "labelfile";
			this.labelfile.Size = new global::System.Drawing.Size(13, 13);
			this.labelfile.TabIndex = 160;
			this.labelfile.Text = "..";
			this.labelsize.AutoSize = true;
			this.labelsize.Location = new global::System.Drawing.Point(69, 115);
			this.labelsize.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelsize.Name = "labelsize";
			this.labelsize.Size = new global::System.Drawing.Size(13, 13);
			this.labelsize.TabIndex = 161;
			this.labelsize.Text = "..";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(8, 81);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(26, 13);
			this.label3.TabIndex = 162;
			this.label3.Text = "File:";
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(442, 167);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.labelfile);
			base.Controls.Add(this.labelsize);
			base.Controls.Add(this.label3);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormDownloadFile";
			this.Text = "Download";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.SocketDownload_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004C7 RID: 1223
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004C8 RID: 1224
		public global::System.Windows.Forms.Label label1;

		// Token: 0x040004C9 RID: 1225
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x040004CA RID: 1226
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040004CB RID: 1227
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004CC RID: 1228
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040004CD RID: 1229
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004CE RID: 1230
		public global::System.Windows.Forms.Label labelfile;

		// Token: 0x040004CF RID: 1231
		public global::System.Windows.Forms.Label labelsize;

		// Token: 0x040004D0 RID: 1232
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040004D1 RID: 1233
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040004D2 RID: 1234
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
