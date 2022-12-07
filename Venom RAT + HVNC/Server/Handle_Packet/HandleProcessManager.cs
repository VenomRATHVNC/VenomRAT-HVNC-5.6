using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200008F RID: 143
	public class HandleProcessManager
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x000297AC File Offset: 0x000279AC
		public void GetProcess(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormProcessManager formProcessManager = (FormProcessManager)Application.OpenForms["processManager:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
				if (formProcessManager != null)
				{
					if (formProcessManager.Client == null)
					{
						formProcessManager.Client = client;
						formProcessManager.listView1.Enabled = true;
						formProcessManager.timer1.Enabled = true;
					}
					formProcessManager.listView1.Items.Clear();
					formProcessManager.imageList1.Images.Clear();
					string[] array = unpack_msgpack.ForcePathObject("Message").AsString.Split(new string[]
					{
						"-=>"
					}, StringSplitOptions.None);
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].Length > 0)
						{
							ListViewItem listViewItem = new ListViewItem
							{
								Text = Path.GetFileName(array[i])
							};
							listViewItem.SubItems.Add(array[i + 1]);
							listViewItem.ToolTipText = array[i];
							Image image = Image.FromStream(new MemoryStream(Convert.FromBase64String(array[i + 2])));
							formProcessManager.imageList1.Images.Add(array[i + 1], image);
							listViewItem.ImageKey = array[i + 1];
							formProcessManager.listView1.Items.Add(listViewItem);
						}
						i += 2;
					}
				}
			}
			catch
			{
			}
		}
	}
}
