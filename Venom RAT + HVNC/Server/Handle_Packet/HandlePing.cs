using System;
using System.Drawing;
using System.Threading;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000087 RID: 135
	public class HandlePing
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x0002841C File Offset: 0x0002661C
		public void Ping(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").SetAsString("Po_ng");
				ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.SubItems[Program.form1.lv_act.Index].Text = unpack_msgpack.ForcePathObject("Message").AsString;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000284D8 File Offset: 0x000266D8
		public void Po_ng(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.SubItems[Program.form1.lv_ping.Index].Text = unpack_msgpack.ForcePathObject("Message").AsInteger.ToString() + " MS";
						if (unpack_msgpack.ForcePathObject("Message").AsInteger > 600L)
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Red;
						}
						else if (unpack_msgpack.ForcePathObject("Message").AsInteger > 300L)
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Orange;
						}
						else
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Green;
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
