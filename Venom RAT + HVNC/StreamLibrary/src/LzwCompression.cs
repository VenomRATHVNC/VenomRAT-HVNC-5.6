using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace StreamLibrary.src
{
	// Token: 0x0200000C RID: 12
	public class LzwCompression
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00005E4C File Offset: 0x0000404C
		public LzwCompression(int Quality)
		{
			this.parameter = new EncoderParameter(Encoder.Quality, (long)Quality);
			this.encoderInfo = this.GetEncoderInfo("image/jpeg");
			this.encoderParams = new EncoderParameters(2);
			this.encoderParams.Param[0] = this.parameter;
			this.encoderParams.Param[1] = new EncoderParameter(Encoder.Compression, 2L);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005EBC File Offset: 0x000040BC
		public byte[] Compress(Bitmap bmp, byte[] AdditionInfo = null)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				if (AdditionInfo != null)
				{
					memoryStream.Write(AdditionInfo, 0, AdditionInfo.Length);
				}
				bmp.Save(memoryStream, this.encoderInfo, this.encoderParams);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021C4 File Offset: 0x000003C4
		public void Compress(Bitmap bmp, Stream stream, byte[] AdditionInfo = null)
		{
			if (AdditionInfo != null)
			{
				stream.Write(AdditionInfo, 0, AdditionInfo.Length);
			}
			bmp.Save(stream, this.encoderInfo, this.encoderParams);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005F14 File Offset: 0x00004114
		private ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			for (int i = 0; i < imageEncoders.Length; i++)
			{
				if (imageEncoders[i].MimeType == mimeType)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x0400001C RID: 28
		private EncoderParameter parameter;

		// Token: 0x0400001D RID: 29
		private ImageCodecInfo encoderInfo;

		// Token: 0x0400001E RID: 30
		private EncoderParameters encoderParams;
	}
}
