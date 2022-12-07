using System;
using System.Collections;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x0200004A RID: 74
	public class ListViewColumnSorter : IComparer
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x000035F5 File Offset: 0x000017F5
		public ListViewColumnSorter()
		{
			this.ColumnToSort = 0;
			this.OrderOfSort = SortOrder.None;
			this.ObjectCompare = new CaseInsensitiveComparer();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00020A50 File Offset: 0x0001EC50
		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = this.ObjectCompare.Compare(listViewItem.SubItems[this.ColumnToSort].Text, listViewItem2.SubItems[this.ColumnToSort].Text);
			if (this.OrderOfSort == SortOrder.Ascending)
			{
				return num;
			}
			if (this.OrderOfSort == SortOrder.Descending)
			{
				return -num;
			}
			return 0;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000361F File Offset: 0x0000181F
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003616 File Offset: 0x00001816
		public int SortColumn
		{
			get
			{
				return this.ColumnToSort;
			}
			set
			{
				this.ColumnToSort = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00003630 File Offset: 0x00001830
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003627 File Offset: 0x00001827
		public SortOrder Order
		{
			get
			{
				return this.OrderOfSort;
			}
			set
			{
				this.OrderOfSort = value;
			}
		}

		// Token: 0x0400021F RID: 543
		private int ColumnToSort;

		// Token: 0x04000220 RID: 544
		private SortOrder OrderOfSort;

		// Token: 0x04000221 RID: 545
		private CaseInsensitiveComparer ObjectCompare;
	}
}
