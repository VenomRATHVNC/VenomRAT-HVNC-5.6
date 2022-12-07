using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server.Algorithm;

namespace Server.MessagePack
{
	// Token: 0x02000039 RID: 57
	public class MsgPack : IEnumerable
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00003300 File Offset: 0x00001500
		private void SetName(string value)
		{
			this.name = value;
			this.lowerName = this.name.ToLower();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001EE84 File Offset: 0x0001D084
		private void Clear()
		{
			for (int i = 0; i < this.children.Count; i++)
			{
				this.children[i].Clear();
			}
			this.children.Clear();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
		private MsgPack InnerAdd()
		{
			MsgPack msgPack = new MsgPack();
			msgPack.parent = this;
			this.children.Add(msgPack);
			return msgPack;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001EEEC File Offset: 0x0001D0EC
		private int IndexOf(string name)
		{
			int num = -1;
			int result = -1;
			string text = name.ToLower();
			foreach (MsgPack msgPack in this.children)
			{
				num++;
				if (text.Equals(msgPack.lowerName))
				{
					result = num;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001EF5C File Offset: 0x0001D15C
		public MsgPack FindObject(string name)
		{
			int num = this.IndexOf(name);
			if (num == -1)
			{
				return null;
			}
			return this.children[num];
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000331A File Offset: 0x0000151A
		private MsgPack InnerAddMapChild()
		{
			if (this.valueType != MsgPackType.Map)
			{
				this.Clear();
				this.valueType = MsgPackType.Map;
			}
			return this.InnerAdd();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00003338 File Offset: 0x00001538
		private MsgPack InnerAddArrayChild()
		{
			if (this.valueType != MsgPackType.Array)
			{
				this.Clear();
				this.valueType = MsgPackType.Array;
			}
			return this.InnerAdd();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003356 File Offset: 0x00001556
		public MsgPack AddArrayChild()
		{
			return this.InnerAddArrayChild();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001EF84 File Offset: 0x0001D184
		private void WriteMap(Stream ms)
		{
			int count = this.children.Count;
			if (count <= 15)
			{
				byte value = 128 + (byte)count;
				ms.WriteByte(value);
			}
			else if (count <= 65535)
			{
				byte value = 222;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)count));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				byte value = 223;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(count));
				ms.Write(array, 0, array.Length);
			}
			for (int i = 0; i < count; i++)
			{
				WriteTools.WriteString(ms, this.children[i].name);
				this.children[i].Encode2Stream(ms);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001F040 File Offset: 0x0001D240
		private void WirteArray(Stream ms)
		{
			int count = this.children.Count;
			if (count <= 15)
			{
				byte value = 144 + (byte)count;
				ms.WriteByte(value);
			}
			else if (count <= 65535)
			{
				byte value = 220;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)count));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				byte value = 221;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(count));
				ms.Write(array, 0, array.Length);
			}
			for (int i = 0; i < count; i++)
			{
				this.children[i].Encode2Stream(ms);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000335E File Offset: 0x0000155E
		public void SetAsInteger(long value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.Integer;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00003373 File Offset: 0x00001573
		public void SetAsUInt64(ulong value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.UInt64;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001F0E4 File Offset: 0x0001D2E4
		public ulong GetAsUInt64()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return ulong.Parse(this.innerValue.ToString().Trim());
			case MsgPackType.Integer:
				return Convert.ToUInt64((long)this.innerValue);
			case MsgPackType.UInt64:
				return (ulong)this.innerValue;
			case MsgPackType.Float:
				return Convert.ToUInt64((double)this.innerValue);
			case MsgPackType.Single:
				return Convert.ToUInt64((float)this.innerValue);
			case MsgPackType.DateTime:
				return Convert.ToUInt64((DateTime)this.innerValue);
			}
			return 0UL;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001F188 File Offset: 0x0001D388
		public long GetAsInteger()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return long.Parse(this.innerValue.ToString().Trim());
			case MsgPackType.Integer:
				return (long)this.innerValue;
			case MsgPackType.UInt64:
				return Convert.ToInt64((long)this.innerValue);
			case MsgPackType.Float:
				return Convert.ToInt64((double)this.innerValue);
			case MsgPackType.Single:
				return Convert.ToInt64((float)this.innerValue);
			case MsgPackType.DateTime:
				return Convert.ToInt64((DateTime)this.innerValue);
			}
			return 0L;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001F22C File Offset: 0x0001D42C
		public double GetAsFloat()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return double.Parse((string)this.innerValue);
			case MsgPackType.Integer:
				return Convert.ToDouble((long)this.innerValue);
			case MsgPackType.Float:
				return (double)this.innerValue;
			case MsgPackType.Single:
				return (double)((float)this.innerValue);
			case MsgPackType.DateTime:
				return (double)Convert.ToInt64((DateTime)this.innerValue);
			}
			return 0.0;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003388 File Offset: 0x00001588
		public void SetAsBytes(byte[] value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.Binary;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		public byte[] GetAsBytes()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return BytesTools.GetUtf8Bytes(this.innerValue.ToString());
			case MsgPackType.Integer:
				return BitConverter.GetBytes((long)this.innerValue);
			case MsgPackType.Float:
				return BitConverter.GetBytes((double)this.innerValue);
			case MsgPackType.Single:
				return BitConverter.GetBytes((float)this.innerValue);
			case MsgPackType.DateTime:
				return BitConverter.GetBytes(((DateTime)this.innerValue).ToBinary());
			case MsgPackType.Binary:
				return (byte[])this.innerValue;
			}
			return new byte[0];
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003399 File Offset: 0x00001599
		public void Add(string key, string value)
		{
			MsgPack msgPack = this.InnerAddArrayChild();
			msgPack.name = key;
			msgPack.SetAsString(value);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000033AE File Offset: 0x000015AE
		public void Add(string key, int value)
		{
			MsgPack msgPack = this.InnerAddArrayChild();
			msgPack.name = key;
			msgPack.SetAsInteger((long)value);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001F36C File Offset: 0x0001D56C
		public Task<bool> LoadFileAsBytes(string fileName)
		{
			MsgPack.<LoadFileAsBytes>d__26 <LoadFileAsBytes>d__;
			<LoadFileAsBytes>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<LoadFileAsBytes>d__.<>4__this = this;
			<LoadFileAsBytes>d__.fileName = fileName;
			<LoadFileAsBytes>d__.<>1__state = -1;
			<LoadFileAsBytes>d__.<>t__builder.Start<MsgPack.<LoadFileAsBytes>d__26>(ref <LoadFileAsBytes>d__);
			return <LoadFileAsBytes>d__.<>t__builder.Task;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		public Task<bool> SaveBytesToFile(string fileName)
		{
			MsgPack.<SaveBytesToFile>d__27 <SaveBytesToFile>d__;
			<SaveBytesToFile>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SaveBytesToFile>d__.<>4__this = this;
			<SaveBytesToFile>d__.fileName = fileName;
			<SaveBytesToFile>d__.<>1__state = -1;
			<SaveBytesToFile>d__.<>t__builder.Start<MsgPack.<SaveBytesToFile>d__27>(ref <SaveBytesToFile>d__);
			return <SaveBytesToFile>d__.<>t__builder.Task;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001F404 File Offset: 0x0001D604
		public MsgPack ForcePathObject(string path)
		{
			MsgPack msgPack = this;
			string[] array = path.Trim().Split(new char[]
			{
				'.',
				'/',
				'\\'
			});
			if (array.Length == 0)
			{
				return null;
			}
			string text;
			if (array.Length > 1)
			{
				for (int i = 0; i < array.Length - 1; i++)
				{
					text = array[i];
					MsgPack msgPack2 = msgPack.FindObject(text);
					if (msgPack2 == null)
					{
						msgPack = msgPack.InnerAddMapChild();
						msgPack.SetName(text);
					}
					else
					{
						msgPack = msgPack2;
					}
				}
			}
			text = array[array.Length - 1];
			int num = msgPack.IndexOf(text);
			if (num > -1)
			{
				return msgPack.children[num];
			}
			msgPack = msgPack.InnerAddMapChild();
			msgPack.SetName(text);
			return msgPack;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000033C4 File Offset: 0x000015C4
		public void SetAsNull()
		{
			this.Clear();
			this.innerValue = null;
			this.valueType = MsgPackType.Null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000033DA File Offset: 0x000015DA
		public void SetAsString(string value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.String;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000033EA File Offset: 0x000015EA
		public string GetAsString()
		{
			if (this.innerValue == null)
			{
				return "";
			}
			return this.innerValue.ToString();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00003405 File Offset: 0x00001605
		public void SetAsBoolean(bool bVal)
		{
			this.valueType = MsgPackType.Boolean;
			this.innerValue = bVal;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000341A File Offset: 0x0000161A
		public void SetAsSingle(float fVal)
		{
			this.valueType = MsgPackType.Single;
			this.innerValue = fVal;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00003430 File Offset: 0x00001630
		public void SetAsFloat(double fVal)
		{
			this.valueType = MsgPackType.Float;
			this.innerValue = fVal;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		public void DecodeFromBytes(byte[] bytes)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bytes = Zip.Decompress(bytes);
				memoryStream.Write(bytes, 0, bytes.Length);
				memoryStream.Position = 0L;
				this.DecodeFromStream(memoryStream);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		public void DecodeFromFile(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			this.DecodeFromStream(fileStream);
			fileStream.Dispose();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001F520 File Offset: 0x0001D720
		public void DecodeFromStream(Stream ms)
		{
			byte b = (byte)ms.ReadByte();
			if (b <= 127)
			{
				this.SetAsInteger((long)((ulong)b));
				return;
			}
			if (b >= 128 && b <= 143)
			{
				this.Clear();
				this.valueType = MsgPackType.Map;
				int num = (int)(b - 128);
				for (int i = 0; i < num; i++)
				{
					MsgPack msgPack = this.InnerAdd();
					msgPack.SetName(ReadTools.ReadString(ms));
					msgPack.DecodeFromStream(ms);
				}
				return;
			}
			if (b >= 144 && b <= 159)
			{
				this.Clear();
				this.valueType = MsgPackType.Array;
				int num = (int)(b - 144);
				for (int i = 0; i < num; i++)
				{
					this.InnerAdd().DecodeFromStream(ms);
				}
				return;
			}
			if (b >= 160 && b <= 191)
			{
				int num = (int)(b - 160);
				this.SetAsString(ReadTools.ReadString(ms, num));
				return;
			}
			if (b >= 224 && b <= 255)
			{
				this.SetAsInteger((long)((sbyte)b));
				return;
			}
			if (b == 192)
			{
				this.SetAsNull();
				return;
			}
			if (b == 193)
			{
				throw new Exception("(never used) type $c1");
			}
			if (b == 194)
			{
				this.SetAsBoolean(false);
				return;
			}
			if (b == 195)
			{
				this.SetAsBoolean(true);
				return;
			}
			if (b == 196)
			{
				int num = ms.ReadByte();
				byte[] array = new byte[num];
				ms.Read(array, 0, num);
				this.SetAsBytes(array);
				return;
			}
			if (b == 197)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				int num = (int)BitConverter.ToUInt16(array, 0);
				array = new byte[num];
				ms.Read(array, 0, num);
				this.SetAsBytes(array);
				return;
			}
			if (b == 198)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				int num = BitConverter.ToInt32(array, 0);
				array = new byte[num];
				ms.Read(array, 0, num);
				this.SetAsBytes(array);
				return;
			}
			if (b == 199 || b == 200 || b == 201)
			{
				throw new Exception("(ext8,ext16,ex32) type $c7,$c8,$c9");
			}
			if (b == 202)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				this.SetAsSingle(BitConverter.ToSingle(array, 0));
				return;
			}
			if (b == 203)
			{
				byte[] array = new byte[8];
				ms.Read(array, 0, 8);
				array = BytesTools.SwapBytes(array);
				this.SetAsFloat(BitConverter.ToDouble(array, 0));
				return;
			}
			if (b == 204)
			{
				b = (byte)ms.ReadByte();
				this.SetAsInteger((long)((ulong)b));
				return;
			}
			if (b == 205)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				this.SetAsInteger((long)((ulong)BitConverter.ToUInt16(array, 0)));
				return;
			}
			if (b == 206)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				this.SetAsInteger((long)((ulong)BitConverter.ToUInt32(array, 0)));
				return;
			}
			if (b == 207)
			{
				byte[] array = new byte[8];
				ms.Read(array, 0, 8);
				array = BytesTools.SwapBytes(array);
				this.SetAsUInt64(BitConverter.ToUInt64(array, 0));
				return;
			}
			if (b == 220)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				int num = (int)BitConverter.ToInt16(array, 0);
				this.Clear();
				this.valueType = MsgPackType.Array;
				for (int i = 0; i < num; i++)
				{
					this.InnerAdd().DecodeFromStream(ms);
				}
				return;
			}
			if (b == 221)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				int num = (int)BitConverter.ToInt16(array, 0);
				this.Clear();
				this.valueType = MsgPackType.Array;
				for (int i = 0; i < num; i++)
				{
					this.InnerAdd().DecodeFromStream(ms);
				}
				return;
			}
			if (b == 217)
			{
				this.SetAsString(ReadTools.ReadString(b, ms));
				return;
			}
			if (b == 222)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				int num = (int)BitConverter.ToInt16(array, 0);
				this.Clear();
				this.valueType = MsgPackType.Map;
				for (int i = 0; i < num; i++)
				{
					MsgPack msgPack2 = this.InnerAdd();
					msgPack2.SetName(ReadTools.ReadString(ms));
					msgPack2.DecodeFromStream(ms);
				}
				return;
			}
			if (b == 222)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				int num = (int)BitConverter.ToInt16(array, 0);
				this.Clear();
				this.valueType = MsgPackType.Map;
				for (int i = 0; i < num; i++)
				{
					MsgPack msgPack3 = this.InnerAdd();
					msgPack3.SetName(ReadTools.ReadString(ms));
					msgPack3.DecodeFromStream(ms);
				}
				return;
			}
			if (b == 223)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				int num = BitConverter.ToInt32(array, 0);
				this.Clear();
				this.valueType = MsgPackType.Map;
				for (int i = 0; i < num; i++)
				{
					MsgPack msgPack4 = this.InnerAdd();
					msgPack4.SetName(ReadTools.ReadString(ms));
					msgPack4.DecodeFromStream(ms);
				}
				return;
			}
			if (b == 218)
			{
				this.SetAsString(ReadTools.ReadString(b, ms));
				return;
			}
			if (b == 219)
			{
				this.SetAsString(ReadTools.ReadString(b, ms));
				return;
			}
			if (b == 208)
			{
				this.SetAsInteger((long)((sbyte)ms.ReadByte()));
				return;
			}
			if (b == 209)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				this.SetAsInteger((long)BitConverter.ToInt16(array, 0));
				return;
			}
			if (b == 210)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				this.SetAsInteger((long)BitConverter.ToInt32(array, 0));
				return;
			}
			if (b == 211)
			{
				byte[] array = new byte[8];
				ms.Read(array, 0, 8);
				array = BytesTools.SwapBytes(array);
				this.SetAsInteger(BitConverter.ToInt64(array, 0));
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001FAB0 File Offset: 0x0001DCB0
		public byte[] Encode2Bytes()
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				this.Encode2Stream(memoryStream);
				byte[] array = new byte[memoryStream.Length];
				memoryStream.Position = 0L;
				memoryStream.Read(array, 0, (int)memoryStream.Length);
				result = Zip.Compress(array);
			}
			return result;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001FB14 File Offset: 0x0001DD14
		public void Encode2Stream(Stream ms)
		{
			switch (this.valueType)
			{
			case MsgPackType.Unknown:
			case MsgPackType.Null:
				WriteTools.WriteNull(ms);
				return;
			case MsgPackType.Map:
				this.WriteMap(ms);
				return;
			case MsgPackType.Array:
				this.WirteArray(ms);
				return;
			case MsgPackType.String:
				WriteTools.WriteString(ms, (string)this.innerValue);
				return;
			case MsgPackType.Integer:
				WriteTools.WriteInteger(ms, (long)this.innerValue);
				return;
			case MsgPackType.UInt64:
				WriteTools.WriteUInt64(ms, (ulong)this.innerValue);
				return;
			case MsgPackType.Boolean:
				WriteTools.WriteBoolean(ms, (bool)this.innerValue);
				return;
			case MsgPackType.Float:
				WriteTools.WriteFloat(ms, (double)this.innerValue);
				return;
			case MsgPackType.Single:
				WriteTools.WriteFloat(ms, (double)((float)this.innerValue));
				return;
			case MsgPackType.DateTime:
				WriteTools.WriteInteger(ms, this.GetAsInteger());
				return;
			case MsgPackType.Binary:
				WriteTools.WriteBinary(ms, (byte[])this.innerValue);
				return;
			default:
				WriteTools.WriteNull(ms);
				return;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00003445 File Offset: 0x00001645
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000344D File Offset: 0x0000164D
		public string AsString
		{
			get
			{
				return this.GetAsString();
			}
			set
			{
				this.SetAsString(value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00003456 File Offset: 0x00001656
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000345E File Offset: 0x0000165E
		public long AsInteger
		{
			get
			{
				return this.GetAsInteger();
			}
			set
			{
				this.SetAsInteger(value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00003467 File Offset: 0x00001667
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000346F File Offset: 0x0000166F
		public double AsFloat
		{
			get
			{
				return this.GetAsFloat();
			}
			set
			{
				this.SetAsFloat(value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		public MsgPackArray AsArray
		{
			get
			{
				lock (this)
				{
					if (this.refAsArray == null)
					{
						this.refAsArray = new MsgPackArray(this, this.children);
					}
				}
				return this.refAsArray;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00003478 File Offset: 0x00001678
		public MsgPackType ValueType
		{
			get
			{
				return this.valueType;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003480 File Offset: 0x00001680
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new MsgPackEnum(this.children);
		}

		// Token: 0x040001D7 RID: 471
		private string name;

		// Token: 0x040001D8 RID: 472
		private string lowerName;

		// Token: 0x040001D9 RID: 473
		private object innerValue;

		// Token: 0x040001DA RID: 474
		private MsgPackType valueType;

		// Token: 0x040001DB RID: 475
		private MsgPack parent;

		// Token: 0x040001DC RID: 476
		private List<MsgPack> children = new List<MsgPack>();

		// Token: 0x040001DD RID: 477
		private MsgPackArray refAsArray;
	}
}
