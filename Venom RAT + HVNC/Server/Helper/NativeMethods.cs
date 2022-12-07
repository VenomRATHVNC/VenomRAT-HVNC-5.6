using System;
using System.Runtime.InteropServices;

namespace Server.Helper
{
	// Token: 0x0200004F RID: 79
	public static class NativeMethods
	{
		// Token: 0x060002B9 RID: 697
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060002BA RID: 698
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
		internal static extern IntPtr SendMessageListViewItem(IntPtr hWnd, uint msg, IntPtr wParam, ref NativeMethods.LVITEM lParam);

		// Token: 0x060002BB RID: 699
		[DllImport("user32.dll")]
		internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);

		// Token: 0x060002BC RID: 700
		[DllImport("user32.dll")]
		internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x060002BD RID: 701
		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
		internal static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

		// Token: 0x02000050 RID: 80
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct LVITEM
		{
			// Token: 0x04000232 RID: 562
			public uint mask;

			// Token: 0x04000233 RID: 563
			public int iItem;

			// Token: 0x04000234 RID: 564
			public int iSubItem;

			// Token: 0x04000235 RID: 565
			public int state;

			// Token: 0x04000236 RID: 566
			public int stateMask;

			// Token: 0x04000237 RID: 567
			[MarshalAs(UnmanagedType.LPTStr)]
			public string pszText;

			// Token: 0x04000238 RID: 568
			public int cchTextMax;

			// Token: 0x04000239 RID: 569
			public int iImage;

			// Token: 0x0400023A RID: 570
			public IntPtr lParam;

			// Token: 0x0400023B RID: 571
			public int iIndent;

			// Token: 0x0400023C RID: 572
			public int iGroupId;

			// Token: 0x0400023D RID: 573
			public uint cColumns;

			// Token: 0x0400023E RID: 574
			public IntPtr puColumns;

			// Token: 0x0400023F RID: 575
			public IntPtr piColFmt;

			// Token: 0x04000240 RID: 576
			public int iGroup;
		}
	}
}
