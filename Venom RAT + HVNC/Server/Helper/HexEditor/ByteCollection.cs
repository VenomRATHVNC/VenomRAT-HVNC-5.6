using System;
using System.Collections.Generic;

namespace Server.Helper.HexEditor
{
	// Token: 0x02000064 RID: 100
	public class ByteCollection
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00003B42 File Offset: 0x00001D42
		public int Length
		{
			get
			{
				return this._bytes.Count;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003B4F File Offset: 0x00001D4F
		public ByteCollection()
		{
			this._bytes = new List<byte>();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003B62 File Offset: 0x00001D62
		public ByteCollection(byte[] bytes)
		{
			this._bytes = new List<byte>(bytes);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003B76 File Offset: 0x00001D76
		public void Add(byte item)
		{
			this._bytes.Add(item);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003B84 File Offset: 0x00001D84
		public void Insert(int index, byte item)
		{
			this._bytes.Insert(index, item);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003B93 File Offset: 0x00001D93
		public void Remove(byte item)
		{
			this._bytes.Remove(item);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00003BA2 File Offset: 0x00001DA2
		public void RemoveAt(int index)
		{
			this._bytes.RemoveAt(index);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public void RemoveRange(int startIndex, int count)
		{
			this._bytes.RemoveRange(startIndex, count);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003BBF File Offset: 0x00001DBF
		public byte GetAt(int index)
		{
			return this._bytes[index];
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003BCD File Offset: 0x00001DCD
		public void SetAt(int index, byte item)
		{
			this._bytes[index] = item;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003BDC File Offset: 0x00001DDC
		public char GetCharAt(int index)
		{
			return Convert.ToChar(this._bytes[index]);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003BEF File Offset: 0x00001DEF
		public byte[] ToArray()
		{
			return this._bytes.ToArray();
		}

		// Token: 0x04000291 RID: 657
		private List<byte> _bytes;
	}
}
