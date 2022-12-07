using System;
using System.Threading;

namespace HVNC.Utils
{
	// Token: 0x02000022 RID: 34
	public class Utils
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000024F0 File Offset: 0x000006F0
		public static void SendLogs(string logcontent)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000029EE File Offset: 0x00000BEE
		public static void xTLOG(string message)
		{
			new Thread(delegate()
			{
				Utils.SendLogs(message);
			}).Start();
		}
	}
}
