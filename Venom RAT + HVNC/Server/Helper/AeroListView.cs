using System;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x0200004C RID: 76
	internal class AeroListView : ListView
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0000365D File Offset: 0x0000185D
		public static int MakeWin32Long(short wLow, short wHigh)
		{
			return (int)wLow << 16 | (int)wHigh;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00003665 File Offset: 0x00001865
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000366D File Offset: 0x0000186D
		private ListViewColumnSorter LvwColumnSorter { get; set; }

		// Token: 0x060002AC RID: 684 RVA: 0x00020ABC File Offset: 0x0001ECBC
		public AeroListView()
		{
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.LvwColumnSorter = new ListViewColumnSorter();
			base.ListViewItemSorter = this.LvwColumnSorter;
			base.View = View.Details;
			base.FullRowSelect = true;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00020B14 File Offset: 0x0001ED14
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
			{
				NativeMethods.SetWindowTheme(base.Handle, "explorer", null);
			}
			if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 5)
			{
				NativeMethods.SendMessage(base.Handle, 295U, this._removeDots, IntPtr.Zero);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00020B94 File Offset: 0x0001ED94
		protected override void OnColumnClick(ColumnClickEventArgs e)
		{
			base.OnColumnClick(e);
			if (e.Column == this.LvwColumnSorter.SortColumn)
			{
				this.LvwColumnSorter.Order = ((this.LvwColumnSorter.Order == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending);
			}
			else
			{
				this.LvwColumnSorter.SortColumn = e.Column;
				this.LvwColumnSorter.Order = SortOrder.Ascending;
			}
			if (!base.VirtualMode)
			{
				base.Sort();
			}
		}

		// Token: 0x04000222 RID: 546
		private const uint WM_CHANGEUISTATE = 295U;

		// Token: 0x04000223 RID: 547
		private const short UIS_SET = 1;

		// Token: 0x04000224 RID: 548
		private const short UISF_HIDEFOCUS = 1;

		// Token: 0x04000225 RID: 549
		private readonly IntPtr _removeDots = new IntPtr(AeroListView.MakeWin32Long(1, 1));
	}
}
