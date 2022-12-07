using System;
using System.Runtime.InteropServices;

namespace StreamLibrary.src
{
	// Token: 0x0200000D RID: 13
	public class NativeMethods
	{
		// Token: 0x0600004F RID: 79
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int memcmp(byte* ptr1, byte* ptr2, uint count);

		// Token: 0x06000050 RID: 80
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int memcmp(IntPtr ptr1, IntPtr ptr2, uint count);

		// Token: 0x06000051 RID: 81
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int memcpy(IntPtr dst, IntPtr src, uint count);

		// Token: 0x06000052 RID: 82
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int memcpy(void* dst, void* src, uint count);
	}
}
