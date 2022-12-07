using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x02000037 RID: 55
	public class MsgPackEnum : IEnumerator
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00003231 File Offset: 0x00001431
		public MsgPackEnum(List<MsgPack> obj)
		{
			this.children = obj;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00003247 File Offset: 0x00001447
		object IEnumerator.Current
		{
			get
			{
				return this.children[this.position];
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000325A File Offset: 0x0000145A
		bool IEnumerator.MoveNext()
		{
			this.position++;
			return this.position < this.children.Count;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000327D File Offset: 0x0000147D
		void IEnumerator.Reset()
		{
			this.position = -1;
		}

		// Token: 0x040001D3 RID: 467
		private List<MsgPack> children;

		// Token: 0x040001D4 RID: 468
		private int position = -1;
	}
}
