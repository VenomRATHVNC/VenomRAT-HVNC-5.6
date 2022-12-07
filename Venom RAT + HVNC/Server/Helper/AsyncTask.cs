using System;
using System.Collections.Generic;

namespace Server.Helper
{
	// Token: 0x0200003F RID: 63
	public class AsyncTask
	{
		// Token: 0x06000281 RID: 641 RVA: 0x0000352F File Offset: 0x0000172F
		public AsyncTask(byte[] _msgPack, string _id, bool _admin)
		{
			this.msgPack = _msgPack;
			this.id = _id;
			this.admin = _admin;
			this.doneClient = new List<string>();
		}

		// Token: 0x040001F9 RID: 505
		public byte[] msgPack;

		// Token: 0x040001FA RID: 506
		public string id;

		// Token: 0x040001FB RID: 507
		public bool admin;

		// Token: 0x040001FC RID: 508
		public List<string> doneClient;
	}
}
