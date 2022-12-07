using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Server.Connection;

namespace Server
{
	// Token: 0x02000031 RID: 49
	public static class Settings
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002CEB File Offset: 0x00000EEB
		public static long SentValue { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002CF3 File Offset: 0x00000EF3
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002CFA File Offset: 0x00000EFA
		public static long ReceivedValue { get; set; }

		// Token: 0x040001B2 RID: 434
		public static List<string> Blocked = new List<string>();

		// Token: 0x040001B3 RID: 435
		public static object LockBlocked = new object();

		// Token: 0x040001B6 RID: 438
		public static object LockReceivedSendValue = new object();

		// Token: 0x040001B7 RID: 439
		public static string CertificatePath = Application.StartupPath + "\\ServerCertificate.p12";

		// Token: 0x040001B8 RID: 440
		public static X509Certificate2 ServerCertificate;

		// Token: 0x040001B9 RID: 441
		public static readonly string Version = "Venom RAT + HVNC  5.0.5";

		// Token: 0x040001BA RID: 442
		public static object LockListviewClients = new object();

		// Token: 0x040001BB RID: 443
		public static object LockListviewLogs = new object();

		// Token: 0x040001BC RID: 444
		public static object LockListviewThumb = new object();

		// Token: 0x040001BD RID: 445
		public static bool ReportWindow = false;

		// Token: 0x040001BE RID: 446
		public static List<Clients> ReportWindowClients = new List<Clients>();

		// Token: 0x040001BF RID: 447
		public static object LockReportWindowClients = new object();
	}
}
