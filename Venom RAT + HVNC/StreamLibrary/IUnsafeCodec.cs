using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using StreamLibrary.src;

namespace StreamLibrary
{
	// Token: 0x02000005 RID: 5
	public abstract class IUnsafeCodec
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		// (set) Token: 0x0600000D RID: 13
		public abstract ulong CachedSize { get; internal set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020F0 File Offset: 0x000002F0
		private protected object ImageProcessLock { protected get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020F9 File Offset: 0x000002F9
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002101 File Offset: 0x00000301
		public int ImageQuality
		{
			get
			{
				return this._imageQuality;
			}
			set
			{
				this._imageQuality = value;
				this.jpgCompression = new JpgCompression(value);
				this.lzwCompression = new LzwCompression(value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000012 RID: 18
		// (remove) Token: 0x06000013 RID: 19
		public abstract event IVideoCodec.VideoDebugScanningDelegate onCodeDebugScan;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000014 RID: 20
		// (remove) Token: 0x06000015 RID: 21
		public abstract event IVideoCodec.VideoDebugScanningDelegate onDecodeDebugScan;

		// Token: 0x06000016 RID: 22 RVA: 0x00002122 File Offset: 0x00000322
		public IUnsafeCodec(int ImageQuality = 100)
		{
			this.ImageQuality = ImageQuality;
			this.ImageProcessLock = new object();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000017 RID: 23
		public abstract int BufferCount { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000018 RID: 24
		public abstract CodecOption CodecOptions { get; }

		// Token: 0x06000019 RID: 25
		public abstract void CodeImage(IntPtr Scan0, Rectangle ScanArea, Size ImageSize, PixelFormat Format, Stream outStream);

		// Token: 0x0600001A RID: 26
		public abstract Bitmap DecodeData(Stream inStream);

		// Token: 0x0600001B RID: 27
		public abstract Bitmap DecodeData(IntPtr CodecBuffer, uint Length);

		// Token: 0x04000009 RID: 9
		protected JpgCompression jpgCompression;

		// Token: 0x0400000A RID: 10
		protected LzwCompression lzwCompression;

		// Token: 0x0400000C RID: 12
		private int _imageQuality;
	}
}
