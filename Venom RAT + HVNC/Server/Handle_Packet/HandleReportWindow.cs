using System;
using System.Drawing;
using Server.Connection;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x02000089 RID: 137
	public class HandleReportWindow
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x000288A8 File Offset: 0x00026AA8
		public HandleReportWindow(Clients client, string title)
		{
			new HandleLogs().Addmsg(string.Concat(new string[]
			{
				"Client ",
				client.Ip,
				" opened [",
				title,
				"]"
			}), Color.Gainsboro);
			if (Settings.Default.Notification)
			{
				Program.form1.notifyIcon1.BalloonTipText = string.Concat(new string[]
				{
					"Client ",
					client.Ip,
					" opened [",
					title,
					"]"
				});
				Program.form1.notifyIcon1.ShowBalloonTip(100);
			}
		}
	}
}
