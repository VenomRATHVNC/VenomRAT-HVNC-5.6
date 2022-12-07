using System;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x02000054 RID: 84
	public class RegistryTreeView : TreeView
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x000036F4 File Offset: 0x000018F4
		public RegistryTreeView()
		{
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}
	}
}
