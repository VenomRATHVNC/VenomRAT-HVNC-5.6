using System;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x02000038 RID: 56
	public class MsgPackArray
	{
		// Token: 0x0600023E RID: 574 RVA: 0x00003286 File Offset: 0x00001486
		public MsgPackArray(MsgPack msgpackObj, List<MsgPack> listObj)
		{
			this.owner = msgpackObj;
			this.children = listObj;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000329C File Offset: 0x0000149C
		public MsgPack Add()
		{
			return this.owner.AddArrayChild();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000032A9 File Offset: 0x000014A9
		public MsgPack Add(string value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.AsString = value;
			return msgPack;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000032BD File Offset: 0x000014BD
		public MsgPack Add(long value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsInteger(value);
			return msgPack;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000032D1 File Offset: 0x000014D1
		public MsgPack Add(double value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsFloat(value);
			return msgPack;
		}

		// Token: 0x17000065 RID: 101
		public MsgPack this[int index]
		{
			get
			{
				return this.children[index];
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000244 RID: 580 RVA: 0x000032F3 File Offset: 0x000014F3
		public int Length
		{
			get
			{
				return this.children.Count;
			}
		}

		// Token: 0x040001D5 RID: 469
		private List<MsgPack> children;

		// Token: 0x040001D6 RID: 470
		private MsgPack owner;
	}
}
