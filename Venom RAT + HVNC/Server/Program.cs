using System;
using System.Windows.Forms;
using Server.Forms;

namespace Server
{
	// Token: 0x0200002F RID: 47
	internal static class Program
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00002C52 File Offset: 0x00000E52
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			new FormLogin().ShowDialog();
			Program.form1 = new FormMain();
			Application.Run(Program.form1);
		}

		// Token: 0x0400019E RID: 414
		public static FormMain form1;
	}
}
