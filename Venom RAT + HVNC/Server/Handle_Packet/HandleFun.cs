using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000070 RID: 112
	public class HandleFun
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x000259A4 File Offset: 0x00023BA4
		public void Fun(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormFun formFun = (FormFun)Application.OpenForms["fun:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
				if (formFun != null && formFun.Client == null)
				{
					formFun.Client = client;
					formFun.timer1.Enabled = true;
				}
			}
			catch
			{
			}
		}
	}
}
