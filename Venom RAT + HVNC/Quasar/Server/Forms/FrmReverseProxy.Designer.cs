namespace Quasar.Server.Forms
{
	// Token: 0x02000024 RID: 36
	public partial class FrmReverseProxy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00002ACA File Offset: 0x00000CCA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00010F7C File Offset: 0x0000F17C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Quasar.Server.Forms.FrmReverseProxy));
			this.btnStart = new global::System.Windows.Forms.Button();
			this.lblLocalServerPort = new global::System.Windows.Forms.Label();
			this.nudServerPort = new global::System.Windows.Forms.NumericUpDown();
			this.tabCtrl = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.columnHeader6 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.killConnectionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.lblProxyInfo = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblLoadBalance = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.nudServerPort).BeginInit();
			this.tabCtrl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			base.SuspendLayout();
			this.btnStart.Location = new global::System.Drawing.Point(243, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(114, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start Listening";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.lblLocalServerPort.AutoSize = true;
			this.lblLocalServerPort.Location = new global::System.Drawing.Point(22, 17);
			this.lblLocalServerPort.Name = "lblLocalServerPort";
			this.lblLocalServerPort.Size = new global::System.Drawing.Size(91, 13);
			this.lblLocalServerPort.TabIndex = 1;
			this.lblLocalServerPort.Text = "Local Server Port";
			this.nudServerPort.Location = new global::System.Drawing.Point(117, 15);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudServerPort;
			int[] array = new int[4];
			array[0] = 65534;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudServerPort;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.nudServerPort.Name = "nudServerPort";
			this.nudServerPort.Size = new global::System.Drawing.Size(120, 22);
			this.nudServerPort.TabIndex = 2;
			this.nudServerPort.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudServerPort;
			int[] array3 = new int[4];
			array3[0] = 3128;
			numericUpDown3.Value = new decimal(array3);
			this.nudServerPort.ValueChanged += new global::System.EventHandler(this.nudServerPort_ValueChanged);
			this.tabCtrl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabCtrl.Controls.Add(this.tabPage1);
			this.tabCtrl.Location = new global::System.Drawing.Point(26, 115);
			this.tabCtrl.Name = "tabCtrl";
			this.tabCtrl.SelectedIndex = 0;
			this.tabCtrl.Size = new global::System.Drawing.Size(736, 274);
			this.tabCtrl.TabIndex = 3;
			this.tabPage1.Controls.Add(this.lstConnections);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(728, 248);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Open Connections";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.lstConnections.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader6,
				this.columnHeader7,
				this.columnHeader1,
				this.columnHeader2,
				this.columnHeader3,
				this.columnHeader4,
				this.columnHeader5
			});
			this.lstConnections.ContextMenuStrip = this.contextMenuStrip;
			this.lstConnections.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstConnections.FullRowSelect = true;
			this.lstConnections.GridLines = true;
			this.lstConnections.HideSelection = false;
			this.lstConnections.Location = new global::System.Drawing.Point(3, 3);
			this.lstConnections.Name = "lstConnections";
			this.lstConnections.Size = new global::System.Drawing.Size(722, 242);
			this.lstConnections.TabIndex = 0;
			this.lstConnections.UseCompatibleStateImageBehavior = false;
			this.lstConnections.View = global::System.Windows.Forms.View.Details;
			this.lstConnections.VirtualMode = true;
			this.lstConnections.RetrieveVirtualItem += new global::System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvConnections_RetrieveVirtualItem);
			this.columnHeader6.Text = "Client IP";
			this.columnHeader6.Width = 106;
			this.columnHeader7.Text = "Client Country";
			this.columnHeader7.Width = 106;
			this.columnHeader1.Text = "Target Server";
			this.columnHeader1.Width = 135;
			this.columnHeader2.Text = "Target Port";
			this.columnHeader2.Width = 68;
			this.columnHeader3.Text = "Total Received";
			this.columnHeader3.Width = 105;
			this.columnHeader4.Text = "Total Sent";
			this.columnHeader4.Width = 95;
			this.columnHeader5.Text = "Proxy Type";
			this.columnHeader5.Width = 90;
			this.contextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.killConnectionToolStripMenuItem
			});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new global::System.Drawing.Size(156, 26);
			this.killConnectionToolStripMenuItem.Name = "killConnectionToolStripMenuItem";
			this.killConnectionToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.killConnectionToolStripMenuItem.Text = "Kill Connection";
			this.killConnectionToolStripMenuItem.Click += new global::System.EventHandler(this.killConnectionToolStripMenuItem_Click);
			this.btnStop.Enabled = false;
			this.btnStop.Location = new global::System.Drawing.Point(363, 12);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(114, 23);
			this.btnStop.TabIndex = 4;
			this.btnStop.Text = "Stop Listening";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.lblProxyInfo.AutoSize = true;
			this.lblProxyInfo.Location = new global::System.Drawing.Point(23, 51);
			this.lblProxyInfo.Name = "lblProxyInfo";
			this.lblProxyInfo.Size = new global::System.Drawing.Size(312, 13);
			this.lblProxyInfo.TabIndex = 5;
			this.lblProxyInfo.Text = "Connect to this SOCKS5 Proxy: 127.0.0.1:3128 (no user/pass)";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(23, 67);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(404, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "All the DNS Queries will be executed at the remote client to reduce DNS Leaks";
			this.lblLoadBalance.AutoSize = true;
			this.lblLoadBalance.Location = new global::System.Drawing.Point(23, 84);
			this.lblLoadBalance.Name = "lblLoadBalance";
			this.lblLoadBalance.Size = new global::System.Drawing.Size(104, 13);
			this.lblLoadBalance.TabIndex = 7;
			this.lblLoadBalance.Text = "[Load Balance Info]";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.ClientSize = new global::System.Drawing.Size(777, 402);
			base.Controls.Add(this.lblLoadBalance);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.lblProxyInfo);
			base.Controls.Add(this.btnStop);
			base.Controls.Add(this.tabCtrl);
			base.Controls.Add(this.nudServerPort);
			base.Controls.Add(this.lblLocalServerPort);
			base.Controls.Add(this.btnStart);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FrmReverseProxy";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reverse Proxy []";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmReverseProxy_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmReverseProxy_Load);
			((global::System.ComponentModel.ISupportInitialize)this.nudServerPort).EndInit();
			this.tabCtrl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.contextMenuStrip.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000DC RID: 220
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label lblLocalServerPort;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.NumericUpDown nudServerPort;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.TabControl tabCtrl;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040000E2 RID: 226
		private global::Server.Helper.AeroListView lstConnections;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.ColumnHeader columnHeader5;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label lblProxyInfo;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.ToolStripMenuItem killConnectionToolStripMenuItem;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.ColumnHeader columnHeader6;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.ColumnHeader columnHeader7;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Label lblLoadBalance;
	}
}
