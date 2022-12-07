using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x0200004D RID: 77
	public static class Methods
	{
		// Token: 0x060002AF RID: 687 RVA: 0x00020C08 File Offset: 0x0001EE08
		public static string BytesToString(long byteCount)
		{
			string[] array = new string[]
			{
				"B",
				"KB",
				"MB",
				"GB",
				"TB",
				"PB",
				"EB"
			};
			if (byteCount == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log((double)num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, (double)num2), 1);
			return ((double)Math.Sign(byteCount) * num3).ToString() + array[num2];
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		public static Task FadeIn(Form o, int interval = 80)
		{
			Methods.<FadeIn>d__2 <FadeIn>d__;
			<FadeIn>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FadeIn>d__.o = o;
			<FadeIn>d__.interval = interval;
			<FadeIn>d__.<>1__state = -1;
			<FadeIn>d__.<>t__builder.Start<Methods.<FadeIn>d__2>(ref <FadeIn>d__);
			return <FadeIn>d__.<>t__builder.Task;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00020D04 File Offset: 0x0001EF04
		public static double DiffSeconds(DateTime startTime, DateTime endTime)
		{
			TimeSpan timeSpan = new TimeSpan(endTime.Ticks - startTime.Ticks);
			return Math.Abs(timeSpan.TotalSeconds);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00020D34 File Offset: 0x0001EF34
		public static string GetRandomString(int length)
		{
			StringBuilder stringBuilder = new StringBuilder(length);
			for (int i = 0; i < length; i++)
			{
				stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[Methods.Random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000365D File Offset: 0x0000185D
		public static int MakeWin32Long(short wLow, short wHigh)
		{
			return (int)wLow << 16 | (int)wHigh;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00020D80 File Offset: 0x0001EF80
		public static void SetItemState(IntPtr handle, int itemIndex, int mask, int value)
		{
			NativeMethods.LVITEM lvitem = new NativeMethods.LVITEM
			{
				stateMask = mask,
				state = value
			};
			NativeMethods.SendMessageListViewItem(handle, 4139U, new IntPtr(itemIndex), ref lvitem);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003676 File Offset: 0x00001876
		public static void ScrollToBottom(IntPtr handle)
		{
			NativeMethods.SendMessage(handle, 277U, Methods.SB_PAGEBOTTOM, IntPtr.Zero);
		}

		// Token: 0x04000227 RID: 551
		private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		// Token: 0x04000228 RID: 552
		public static Random Random = new Random();

		// Token: 0x04000229 RID: 553
		private const int LVM_FIRST = 4096;

		// Token: 0x0400022A RID: 554
		private const int LVM_SETITEMSTATE = 4139;

		// Token: 0x0400022B RID: 555
		private const int WM_VSCROLL = 277;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr SB_PAGEBOTTOM = new IntPtr(7);
	}
}
