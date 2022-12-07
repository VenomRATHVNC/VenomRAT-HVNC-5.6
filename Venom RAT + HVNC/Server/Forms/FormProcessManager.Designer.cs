namespace Server.Forms
{
	// Token: 0x020000A4 RID: 164
	public partial class FormProcessManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x00004AE6 File Offset: 0x00002CE6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0004341C File Offset: 0x0004161C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormProcessManager));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.lv_name = new global::System.Windows.Forms.ColumnHeader();
			this.lv_id = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.killToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.lv_name,
				this.lv_id
			});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.Enabled = false;
			this.listView1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(0, 65);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(647, 501);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 165;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.lv_name.Text = "Name";
			this.lv_name.Width = 283;
			this.lv_id.Text = "ID";
			this.lv_id.Width = 81;
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.killToolStripMenuItem,
				this.refreshToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(114, 48);
			this.killToolStripMenuItem.Name = "killToolStripMenuItem";
			this.killToolStripMenuItem.Size = new global::System.Drawing.Size(113, 22);
			this.killToolStripMenuItem.Text = "Kill";
			this.killToolStripMenuItem.Click += new global::System.EventHandler(this.killToolStripMenuItem_Click);
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new global::System.Drawing.Size(113, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new global::System.EventHandler(this.refreshToolStripMenuItem_Click);
			this.imageList1.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.timer1.Interval = 1000;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(133, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Process Manager";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(647, 31);
			this.siticoneGradientPanel4.TabIndex = 166;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(647, 34);
			this.panel1.TabIndex = 167;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(620, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(647, 566);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormProcessManager";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Process Manager";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormProcessManager_FormClosed);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000489 RID: 1161
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400048A RID: 1162
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400048B RID: 1163
		private global::System.Windows.Forms.ColumnHeader lv_name;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.ColumnHeader lv_id;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;

		// Token: 0x0400048F RID: 1167
		private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

		// Token: 0x04000490 RID: 1168
		public global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x04000491 RID: 1169
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000492 RID: 1170
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000493 RID: 1171
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000494 RID: 1172
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000495 RID: 1173
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000496 RID: 1174
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000497 RID: 1175
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
