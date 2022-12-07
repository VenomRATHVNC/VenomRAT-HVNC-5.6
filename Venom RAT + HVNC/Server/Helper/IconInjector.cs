using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Server.Helper
{
	// Token: 0x02000043 RID: 67
	public static class IconInjector
	{
		// Token: 0x06000297 RID: 663 RVA: 0x000035D3 File Offset: 0x000017D3
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			IconInjector.InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00020704 File Offset: 0x0001E904
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconInjector.IconFile iconFile = IconInjector.IconFile.FromFile(iconFileName);
			IntPtr hUpdate = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(14L), new IntPtr((long)((ulong)iconGroupID)), 0, array, array.Length);
			for (int i = 0; i <= iconFile.ImageCount - 1; i++)
			{
				byte[] array2 = iconFile.ImageData(i);
				IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(3L), new IntPtr((long)((ulong)iconBaseID + (ulong)((long)i))), 0, array2, array2.Length);
			}
			IconInjector.NativeMethods.EndUpdateResource(hUpdate, false);
		}

		// Token: 0x02000044 RID: 68
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x06000299 RID: 665
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x0600029A RID: 666
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x0600029B RID: 667
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
		}

		// Token: 0x02000045 RID: 69
		private struct ICONDIR
		{
			// Token: 0x040001FE RID: 510
			public ushort Reserved;

			// Token: 0x040001FF RID: 511
			public ushort Type;

			// Token: 0x04000200 RID: 512
			public ushort Count;
		}

		// Token: 0x02000046 RID: 70
		private struct ICONDIRENTRY
		{
			// Token: 0x04000201 RID: 513
			public byte Width;

			// Token: 0x04000202 RID: 514
			public byte Height;

			// Token: 0x04000203 RID: 515
			public byte ColorCount;

			// Token: 0x04000204 RID: 516
			public byte Reserved;

			// Token: 0x04000205 RID: 517
			public ushort Planes;

			// Token: 0x04000206 RID: 518
			public ushort BitCount;

			// Token: 0x04000207 RID: 519
			public int BytesInRes;

			// Token: 0x04000208 RID: 520
			public int ImageOffset;
		}

		// Token: 0x02000047 RID: 71
		private struct BITMAPINFOHEADER
		{
			// Token: 0x04000209 RID: 521
			public uint Size;

			// Token: 0x0400020A RID: 522
			public int Width;

			// Token: 0x0400020B RID: 523
			public int Height;

			// Token: 0x0400020C RID: 524
			public ushort Planes;

			// Token: 0x0400020D RID: 525
			public ushort BitCount;

			// Token: 0x0400020E RID: 526
			public uint Compression;

			// Token: 0x0400020F RID: 527
			public uint SizeImage;

			// Token: 0x04000210 RID: 528
			public int XPelsPerMeter;

			// Token: 0x04000211 RID: 529
			public int YPelsPerMeter;

			// Token: 0x04000212 RID: 530
			public uint ClrUsed;

			// Token: 0x04000213 RID: 531
			public uint ClrImportant;
		}

		// Token: 0x02000048 RID: 72
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x04000214 RID: 532
			public byte Width;

			// Token: 0x04000215 RID: 533
			public byte Height;

			// Token: 0x04000216 RID: 534
			public byte ColorCount;

			// Token: 0x04000217 RID: 535
			public byte Reserved;

			// Token: 0x04000218 RID: 536
			public ushort Planes;

			// Token: 0x04000219 RID: 537
			public ushort BitCount;

			// Token: 0x0400021A RID: 538
			public int BytesInRes;

			// Token: 0x0400021B RID: 539
			public ushort ID;
		}

		// Token: 0x02000049 RID: 73
		private class IconFile
		{
			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600029D RID: 669 RVA: 0x000035DE File Offset: 0x000017DE
			public int ImageCount
			{
				get
				{
					return (int)this.iconDir.Count;
				}
			}

			// Token: 0x0600029E RID: 670 RVA: 0x000035EB File Offset: 0x000017EB
			public byte[] ImageData(int index)
			{
				return this.iconImage[index];
			}

			// Token: 0x0600029F RID: 671 RVA: 0x00020788 File Offset: 0x0001E988
			public static IconInjector.IconFile FromFile(string filename)
			{
				IconInjector.IconFile iconFile = new IconInjector.IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (IconInjector.ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(IconInjector.ICONDIR));
				iconFile.iconEntry = new IconInjector.ICONDIRENTRY[(int)iconFile.iconDir.Count];
				iconFile.iconImage = new byte[(int)iconFile.iconDir.Count][];
				int num = Marshal.SizeOf<IconInjector.ICONDIR>(iconFile.iconDir);
				Type typeFromHandle = typeof(IconInjector.ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				for (int i = 0; i <= (int)(iconFile.iconDir.Count - 1); i++)
				{
					IconInjector.ICONDIRENTRY icondirentry = (IconInjector.ICONDIRENTRY)Marshal.PtrToStructure(new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num), typeFromHandle);
					iconFile.iconEntry[i] = icondirentry;
					iconFile.iconImage[i] = new byte[icondirentry.BytesInRes];
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[i], 0, icondirentry.BytesInRes);
					num += num2;
				}
				gchandle.Free();
				return iconFile;
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x000208AC File Offset: 0x0001EAAC
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				byte[] array = new byte[Marshal.SizeOf(typeof(IconInjector.ICONDIR)) + Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY)) * this.ImageCount];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr<IconInjector.ICONDIR>(this.iconDir, gchandle.AddrOfPinnedObject(), false);
				int num = Marshal.SizeOf<IconInjector.ICONDIR>(this.iconDir);
				for (int i = 0; i <= this.ImageCount - 1; i++)
				{
					IconInjector.GRPICONDIRENTRY structure = default(IconInjector.GRPICONDIRENTRY);
					IconInjector.BITMAPINFOHEADER bitmapinfoheader = default(IconInjector.BITMAPINFOHEADER);
					GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
					Marshal.Copy(this.ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(IconInjector.BITMAPINFOHEADER)));
					gchandle2.Free();
					structure.Width = this.iconEntry[i].Width;
					structure.Height = this.iconEntry[i].Height;
					structure.ColorCount = this.iconEntry[i].ColorCount;
					structure.Reserved = this.iconEntry[i].Reserved;
					structure.Planes = bitmapinfoheader.Planes;
					structure.BitCount = bitmapinfoheader.BitCount;
					structure.BytesInRes = this.iconEntry[i].BytesInRes;
					structure.ID = Convert.ToUInt16((long)((ulong)iconBaseID + (ulong)((long)i)));
					Marshal.StructureToPtr<IconInjector.GRPICONDIRENTRY>(structure, new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num), false);
					num += Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY));
				}
				gchandle.Free();
				return array;
			}

			// Token: 0x0400021C RID: 540
			private IconInjector.ICONDIR iconDir;

			// Token: 0x0400021D RID: 541
			private IconInjector.ICONDIRENTRY[] iconEntry;

			// Token: 0x0400021E RID: 542
			private byte[][] iconImage;
		}
	}
}
