namespace Server.Forms
{
	// Token: 0x02000093 RID: 147
	public partial class FormNetstat : global::System.Windows.Forms.Form
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00004607 File Offset: 0x00002807
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00030A34 File Offset: 0x0002EC34
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormNetstat));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.lv_id = new global::System.Windows.Forms.ColumnHeader();
			this.lv_localAddr = new global::System.Windows.Forms.ColumnHeader();
			this.lv_remoteAddr = new global::System.Windows.Forms.ColumnHeader();
			this.lv_state = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.killToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
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
				this.lv_id,
				this.lv_localAddr,
				this.lv_remoteAddr,
				this.lv_state
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
			this.listView1.Size = new global::System.Drawing.Size(736, 549);
			this.listView1.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 165;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.lv_id.Text = "ID";
			this.lv_id.Width = 92;
			this.lv_localAddr.Text = "LocalAddress";
			this.lv_localAddr.Width = 161;
			this.lv_remoteAddr.Text = "RemoteAddress";
			this.lv_remoteAddr.Width = 177;
			this.lv_state.Text = "State";
			this.lv_state.Width = 110;
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.killToolStripMenuItem,
				this.refreshToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(181, 70);
			this.killToolStripMenuItem.Name = "killToolStripMenuItem";
			this.killToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.killToolStripMenuItem.Text = "Kill";
			this.killToolStripMenuItem.Click += new global::System.EventHandler(this.killToolStripMenuItem_Click);
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new global::System.EventHandler(this.refreshToolStripMenuItem_Click);
			this.timer1.Interval = 1000;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(144, 20);
			this.label1.TabIndex = 130;
			this.label1.Text = "Networks Statistics";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(736, 31);
			this.siticoneGradientPanel4.TabIndex = 166;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(736, 34);
			this.panel1.TabIndex = 167;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(709, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(736, 614);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormNetstat";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Netstat";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormNetstat_FormClosed);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000365 RID: 869
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000366 RID: 870
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000367 RID: 871
		private global::System.Windows.Forms.ColumnHeader lv_id;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.ColumnHeader lv_localAddr;

		// Token: 0x04000369 RID: 873
		private global::System.Windows.Forms.ColumnHeader lv_remoteAddr;

		// Token: 0x0400036A RID: 874
		private global::System.Windows.Forms.ColumnHeader lv_state;

		// Token: 0x0400036B RID: 875
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400036C RID: 876
		private global::System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;

		// Token: 0x0400036D RID: 877
		private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

		// Token: 0x0400036E RID: 878
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400036F RID: 879
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000370 RID: 880
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000371 RID: 881
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000372 RID: 882
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000373 RID: 883
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000374 RID: 884
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
