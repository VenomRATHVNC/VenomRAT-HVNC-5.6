using System;

namespace Server.MessagePack
{
	// Token: 0x0200003C RID: 60
	public enum MsgPackType
	{
		// Token: 0x040001ED RID: 493
		Unknown,
		// Token: 0x040001EE RID: 494
		Null,
		// Token: 0x040001EF RID: 495
		Map,
		// Token: 0x040001F0 RID: 496
		Array,
		// Token: 0x040001F1 RID: 497
		String,
		// Token: 0x040001F2 RID: 498
		Integer,
		// Token: 0x040001F3 RID: 499
		UInt64,
		// Token: 0x040001F4 RID: 500
		Boolean,
		// Token: 0x040001F5 RID: 501
		Float,
		// Token: 0x040001F6 RID: 502
		Single,
		// Token: 0x040001F7 RID: 503
		DateTime,
		// Token: 0x040001F8 RID: 504
		Binary
	}
}
