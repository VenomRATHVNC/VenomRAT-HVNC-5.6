using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Server.Properties
{
	// Token: 0x02000034 RID: 52
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Resources
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x000021E7 File Offset: 0x000003E7
		internal Resources()
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002E01 File Offset: 0x00001001
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Server.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002E2D File Offset: 0x0000102D
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002E34 File Offset: 0x00001034
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002E3C File Offset: 0x0000103C
		public static byte[] _7z
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("_7z", Resources.resourceCulture);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002E57 File Offset: 0x00001057
		public static byte[] _7z1
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("_7z1", Resources.resourceCulture);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002E72 File Offset: 0x00001072
		public static byte[] donut
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("donut", Resources.resourceCulture);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002E8D File Offset: 0x0000108D
		public static byte[] ip2region
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("ip2region", Resources.resourceCulture);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002EA8 File Offset: 0x000010A8
		public static byte[] Keylogger
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("Keylogger", Resources.resourceCulture);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00002EC3 File Offset: 0x000010C3
		public static UnmanagedMemoryStream offline
		{
			get
			{
				return Resources.ResourceManager.GetStream("offline", Resources.resourceCulture);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002ED9 File Offset: 0x000010D9
		public static UnmanagedMemoryStream online
		{
			get
			{
				return Resources.ResourceManager.GetStream("online", Resources.resourceCulture);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00002EEF File Offset: 0x000010EF
		public static string ShellcodeLoader
		{
			get
			{
				return Resources.ResourceManager.GetString("ShellcodeLoader", Resources.resourceCulture);
			}
		}

		// Token: 0x040001CF RID: 463
		private static ResourceManager resourceMan;

		// Token: 0x040001D0 RID: 464
		private static CultureInfo resourceCulture;
	}
}
