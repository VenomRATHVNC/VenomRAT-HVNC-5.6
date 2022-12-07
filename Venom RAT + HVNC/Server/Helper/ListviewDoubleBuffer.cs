using System;
using System.Reflection;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x0200004B RID: 75
	public static class ListviewDoubleBuffer
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00003638 File Offset: 0x00001838
		public static void Enable(ListView listView)
		{
			typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(listView, true, null);
		}
	}
}
