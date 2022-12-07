using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000072 RID: 114
	public class HandleInformation
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x00025B10 File Offset: 0x00023D10
		public void AddToInformationList(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + unpack_msgpack.ForcePathObject("ID").AsString + "\\Information");
				string text2 = text + "\\Information.txt";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllText(text2, unpack_msgpack.ForcePathObject("InforMation").AsString);
				Process.Start("explorer.exe", text2);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
