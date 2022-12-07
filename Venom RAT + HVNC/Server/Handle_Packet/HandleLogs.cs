using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Handle_Packet
{
	// Token: 0x02000085 RID: 133
	public class HandleLogs
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x000282F0 File Offset: 0x000264F0
		public void Addmsg(string Msg, Color color)
		{
			try
			{
				ListViewItem LV = new ListViewItem();
				LV.Text = DateTime.Now.ToLongTimeString();
				LV.SubItems.Add(Msg);
				LV.ForeColor = color;
				if (Program.form1.InvokeRequired)
				{
					Program.form1.Invoke(new MethodInvoker(delegate()
					{
						object lockListviewLogs2 = Settings.LockListviewLogs;
						lock (lockListviewLogs2)
						{
							Program.form1.listView2.Items.Insert(0, LV);
						}
					}));
				}
				else
				{
					object lockListviewLogs = Settings.LockListviewLogs;
					lock (lockListviewLogs)
					{
						Program.form1.listView2.Items.Insert(0, LV);
					}
				}
			}
			catch
			{
			}
		}
	}
}
