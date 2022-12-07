using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Server.Connection;
using Server.Helper;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000AB RID: 171
	public partial class FormRegistryEditor : Form
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00004DBB File Offset: 0x00002FBB
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00004DC3 File Offset: 0x00002FC3
		public FormMain F { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00004DCC File Offset: 0x00002FCC
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004DD4 File Offset: 0x00002FD4
		internal Clients Client { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00004DDD File Offset: 0x00002FDD
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004DE5 File Offset: 0x00002FE5
		internal Clients ParentClient { get; set; }

		// Token: 0x0600056C RID: 1388 RVA: 0x00004DEE File Offset: 0x00002FEE
		public FormRegistryEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004DFC File Offset: 0x00002FFC
		private void FrmRegistryEditor_Load(object sender, EventArgs e)
		{
			if (!this.ParentClient.Admin)
			{
				MessageBox.Show("The client software is not running as administrator and therefore some functionality like Update, Create, Open and Delete may not work properly!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00048110 File Offset: 0x00046310
		private void AddRootKey(RegistrySeeker.RegSeekerMatch match)
		{
			TreeNode treeNode = this.CreateNode(match.Key, match.Key, match.Data);
			treeNode.Nodes.Add(new TreeNode());
			this.tvRegistryDirectory.Nodes.Add(treeNode);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0004815C File Offset: 0x0004635C
		private TreeNode AddKeyToTree(TreeNode parent, RegistrySeeker.RegSeekerMatch subKey)
		{
			TreeNode treeNode = this.CreateNode(subKey.Key, subKey.Key, subKey.Data);
			parent.Nodes.Add(treeNode);
			if (subKey.HasSubKeys)
			{
				treeNode.Nodes.Add(new TreeNode());
			}
			return treeNode;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004E1E File Offset: 0x0000301E
		private TreeNode CreateNode(string key, string text, object tag)
		{
			return new TreeNode
			{
				Text = text,
				Name = key,
				Tag = tag
			};
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000481AC File Offset: 0x000463AC
		public void AddKeys(string rootKey, RegistrySeeker.RegSeekerMatch[] matches)
		{
			if (string.IsNullOrEmpty(rootKey))
			{
				this.tvRegistryDirectory.BeginUpdate();
				foreach (RegistrySeeker.RegSeekerMatch match in matches)
				{
					this.AddRootKey(match);
				}
				this.tvRegistryDirectory.SelectedNode = this.tvRegistryDirectory.Nodes[0];
				this.tvRegistryDirectory.EndUpdate();
				return;
			}
			TreeNode treeNode = this.GetTreeNode(rootKey);
			if (treeNode != null)
			{
				this.tvRegistryDirectory.BeginUpdate();
				foreach (RegistrySeeker.RegSeekerMatch subKey in matches)
				{
					this.AddKeyToTree(treeNode, subKey);
				}
				treeNode.Expand();
				this.tvRegistryDirectory.EndUpdate();
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00048258 File Offset: 0x00046458
		public void CreateNewKey(string rootKey, RegistrySeeker.RegSeekerMatch match)
		{
			TreeNode treeNode = this.GetTreeNode(rootKey);
			TreeNode treeNode2 = this.AddKeyToTree(treeNode, match);
			treeNode2.EnsureVisible();
			this.tvRegistryDirectory.SelectedNode = treeNode2;
			treeNode2.Expand();
			this.tvRegistryDirectory.LabelEdit = true;
			treeNode2.BeginEdit();
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000482A0 File Offset: 0x000464A0
		public void DeleteKey(string rootKey, string subKey)
		{
			TreeNode treeNode = this.GetTreeNode(rootKey);
			if (treeNode.Nodes.ContainsKey(subKey))
			{
				treeNode.Nodes.RemoveByKey(subKey);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000482D0 File Offset: 0x000464D0
		public void RenameKey(string rootKey, string oldName, string newName)
		{
			TreeNode treeNode = this.GetTreeNode(rootKey);
			if (treeNode.Nodes.ContainsKey(oldName))
			{
				treeNode.Nodes[oldName].Text = newName;
				treeNode.Nodes[oldName].Name = newName;
				this.tvRegistryDirectory.SelectedNode = treeNode.Nodes[newName];
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00048330 File Offset: 0x00046530
		private TreeNode GetTreeNode(string path)
		{
			string[] array = path.Split(new char[]
			{
				'\\'
			});
			TreeNode treeNode = this.tvRegistryDirectory.Nodes[array[0]];
			if (treeNode == null)
			{
				return null;
			}
			for (int i = 1; i < array.Length; i++)
			{
				treeNode = treeNode.Nodes[array[i]];
				if (treeNode == null)
				{
					return null;
				}
			}
			return treeNode;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0004838C File Offset: 0x0004658C
		public void CreateValue(string keyPath, RegistrySeeker.RegValueData value)
		{
			TreeNode treeNode = this.GetTreeNode(keyPath);
			if (treeNode != null)
			{
				List<RegistrySeeker.RegValueData> list = ((RegistrySeeker.RegValueData[])treeNode.Tag).ToList<RegistrySeeker.RegValueData>();
				list.Add(value);
				treeNode.Tag = list.ToArray();
				if (this.tvRegistryDirectory.SelectedNode == treeNode)
				{
					RegistryValueLstItem registryValueLstItem = new RegistryValueLstItem(value);
					this.lstRegistryValues.Items.Add(registryValueLstItem);
					this.lstRegistryValues.SelectedIndices.Clear();
					registryValueLstItem.Selected = true;
					this.lstRegistryValues.LabelEdit = true;
					registryValueLstItem.BeginEdit();
				}
				this.tvRegistryDirectory.SelectedNode = treeNode;
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00048428 File Offset: 0x00046628
		public void DeleteValue(string keyPath, string valueName)
		{
			TreeNode treeNode = this.GetTreeNode(keyPath);
			if (treeNode != null)
			{
				if (!RegValueHelper.IsDefaultValue(valueName))
				{
					treeNode.Tag = (from value in (RegistrySeeker.RegValueData[])treeNode.Tag
					where value.Name != valueName
					select value).ToArray<RegistrySeeker.RegValueData>();
					if (this.tvRegistryDirectory.SelectedNode == treeNode)
					{
						this.lstRegistryValues.Items.RemoveByKey(valueName);
					}
				}
				else
				{
					RegistrySeeker.RegValueData regValueData = ((RegistrySeeker.RegValueData[])treeNode.Tag).First((RegistrySeeker.RegValueData item) => item.Name == valueName);
					if (this.tvRegistryDirectory.SelectedNode == treeNode)
					{
						RegistryValueLstItem registryValueLstItem = this.lstRegistryValues.Items.Cast<RegistryValueLstItem>().SingleOrDefault((RegistryValueLstItem item) => item.Name == valueName);
						if (registryValueLstItem != null)
						{
							registryValueLstItem.Data = regValueData.Kind.RegistryTypeToString(null);
						}
					}
				}
				this.tvRegistryDirectory.SelectedNode = treeNode;
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00048518 File Offset: 0x00046718
		public void RenameValue(string keyPath, string oldName, string newName)
		{
			TreeNode treeNode = this.GetTreeNode(keyPath);
			if (treeNode != null)
			{
				((RegistrySeeker.RegValueData[])treeNode.Tag).First((RegistrySeeker.RegValueData item) => item.Name == oldName).Name = newName;
				if (this.tvRegistryDirectory.SelectedNode == treeNode)
				{
					RegistryValueLstItem registryValueLstItem = this.lstRegistryValues.Items.Cast<RegistryValueLstItem>().SingleOrDefault((RegistryValueLstItem item) => item.Name == oldName);
					if (registryValueLstItem != null)
					{
						registryValueLstItem.RegName = newName;
					}
				}
				this.tvRegistryDirectory.SelectedNode = treeNode;
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000485A8 File Offset: 0x000467A8
		public void ChangeValue(string keyPath, RegistrySeeker.RegValueData value)
		{
			TreeNode treeNode = this.GetTreeNode(keyPath);
			if (treeNode != null)
			{
				RegistrySeeker.RegValueData dest = ((RegistrySeeker.RegValueData[])treeNode.Tag).First((RegistrySeeker.RegValueData item) => item.Name == value.Name);
				this.ChangeRegistryValue(value, dest);
				if (this.tvRegistryDirectory.SelectedNode == treeNode)
				{
					RegistryValueLstItem registryValueLstItem = this.lstRegistryValues.Items.Cast<RegistryValueLstItem>().SingleOrDefault((RegistryValueLstItem item) => item.Name == value.Name);
					if (registryValueLstItem != null)
					{
						registryValueLstItem.Data = RegValueHelper.RegistryValueToString(value);
					}
				}
				this.tvRegistryDirectory.SelectedNode = treeNode;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00004E3A File Offset: 0x0000303A
		private void ChangeRegistryValue(RegistrySeeker.RegValueData source, RegistrySeeker.RegValueData dest)
		{
			if (source.Kind != dest.Kind)
			{
				return;
			}
			dest.Data = source.Data;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00048648 File Offset: 0x00046848
		private void UpdateLstRegistryValues(TreeNode node)
		{
			this.selectedStripStatusLabel.Text = node.FullPath;
			RegistrySeeker.RegValueData[] values = (RegistrySeeker.RegValueData[])node.Tag;
			this.PopulateLstRegistryValues(values);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0004867C File Offset: 0x0004687C
		private void PopulateLstRegistryValues(RegistrySeeker.RegValueData[] values)
		{
			this.lstRegistryValues.BeginUpdate();
			this.lstRegistryValues.Items.Clear();
			values = (from value in values
			orderby value.Name
			select value).ToArray<RegistrySeeker.RegValueData>();
			RegistrySeeker.RegValueData[] array = values;
			for (int i = 0; i < array.Length; i++)
			{
				RegistryValueLstItem value2 = new RegistryValueLstItem(array[i]);
				this.lstRegistryValues.Items.Add(value2);
			}
			this.lstRegistryValues.EndUpdate();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00048708 File Offset: 0x00046908
		private void tvRegistryDirectory_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			if (e.Label == null)
			{
				this.tvRegistryDirectory.LabelEdit = false;
				return;
			}
			e.CancelEdit = true;
			if (e.Label.Length <= 0)
			{
				MessageBox.Show("Invalid label. \nThe label cannot be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Node.BeginEdit();
				return;
			}
			if (e.Node.Parent.Nodes.ContainsKey(e.Label))
			{
				MessageBox.Show("Invalid label. \nA node with that label already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Node.BeginEdit();
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
			msgPack.ForcePathObject("Command").AsString = "RenameRegistryKey";
			msgPack.ForcePathObject("OldKeyName").AsString = e.Node.Name;
			msgPack.ForcePathObject("NewKeyName").AsString = e.Label;
			msgPack.ForcePathObject("ParentPath").AsString = e.Node.Parent.FullPath;
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			this.tvRegistryDirectory.LabelEdit = false;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0004884C File Offset: 0x00046A4C
		private void tvRegistryDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			TreeNode node = e.Node;
			if (string.IsNullOrEmpty(node.FirstNode.Name))
			{
				this.tvRegistryDirectory.SuspendLayout();
				node.Nodes.Clear();
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "LoadRegistryKey";
				msgPack.ForcePathObject("RootKeyName").AsString = node.FullPath;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				Thread.Sleep(500);
				this.tvRegistryDirectory.ResumeLayout();
				e.Cancel = true;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0004890C File Offset: 0x00046B0C
		private void tvRegistryDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.tvRegistryDirectory.SelectedNode = e.Node;
				Point position = new Point(e.X, e.Y);
				this.CreateTreeViewMenuStrip();
				this.tv_ContextMenuStrip.Show(this.tvRegistryDirectory, position);
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00004E57 File Offset: 0x00003057
		private void tvRegistryDirectory_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			this.UpdateLstRegistryValues(e.Node);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00004E65 File Offset: 0x00003065
		private void tvRegistryDirectory_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && this.GetDeleteState())
			{
				this.deleteRegistryKey_Click(this, e);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00048964 File Offset: 0x00046B64
		private void CreateEditToolStrip()
		{
			this.modifyToolStripMenuItem1.Visible = (this.modifyBinaryDataToolStripMenuItem1.Visible = (this.modifyNewtoolStripSeparator.Visible = this.lstRegistryValues.Focused));
			this.modifyToolStripMenuItem1.Enabled = (this.modifyBinaryDataToolStripMenuItem1.Enabled = (this.lstRegistryValues.SelectedItems.Count == 1));
			this.renameToolStripMenuItem2.Enabled = this.GetRenameState();
			this.deleteToolStripMenuItem2.Enabled = this.GetDeleteState();
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004E81 File Offset: 0x00003081
		private void CreateTreeViewMenuStrip()
		{
			this.renameToolStripMenuItem.Enabled = (this.tvRegistryDirectory.SelectedNode.Parent != null);
			this.deleteToolStripMenuItem.Enabled = (this.tvRegistryDirectory.SelectedNode.Parent != null);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000489F4 File Offset: 0x00046BF4
		private void CreateListViewMenuStrip()
		{
			this.modifyToolStripMenuItem.Enabled = (this.modifyBinaryDataToolStripMenuItem.Enabled = (this.lstRegistryValues.SelectedItems.Count == 1));
			this.renameToolStripMenuItem1.Enabled = (this.lstRegistryValues.SelectedItems.Count == 1 && !RegValueHelper.IsDefaultValue(this.lstRegistryValues.SelectedItems[0].Name));
			this.deleteToolStripMenuItem1.Enabled = (this.tvRegistryDirectory.SelectedNode != null && this.lstRegistryValues.SelectedItems.Count > 0);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00004EBF File Offset: 0x000030BF
		private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			this.CreateEditToolStrip();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000044EB File Offset: 0x000026EB
		private void menuStripExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00004EC7 File Offset: 0x000030C7
		private void menuStripDelete_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.Focused)
			{
				this.deleteRegistryKey_Click(this, e);
				return;
			}
			if (this.lstRegistryValues.Focused)
			{
				this.deleteRegistryValue_Click(this, e);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00004EF4 File Offset: 0x000030F4
		private void menuStripRename_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.Focused)
			{
				this.renameRegistryKey_Click(this, e);
				return;
			}
			if (this.lstRegistryValues.Focused)
			{
				this.renameRegistryValue_Click(this, e);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00048A9C File Offset: 0x00046C9C
		private void lstRegistryKeys_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Point position = new Point(e.X, e.Y);
				if (this.lstRegistryValues.GetItemAt(position.X, position.Y) == null)
				{
					this.lst_ContextMenuStrip.Show(this.lstRegistryValues, position);
					return;
				}
				this.CreateListViewMenuStrip();
				this.selectedItem_ContextMenuStrip.Show(this.lstRegistryValues, position);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00048B10 File Offset: 0x00046D10
		private void lstRegistryKeys_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			if (e.Label == null || this.tvRegistryDirectory.SelectedNode == null)
			{
				this.lstRegistryValues.LabelEdit = false;
				return;
			}
			e.CancelEdit = true;
			int item = e.Item;
			if (e.Label.Length <= 0)
			{
				MessageBox.Show("Invalid label. \nThe label cannot be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.lstRegistryValues.Items[item].BeginEdit();
				return;
			}
			if (this.lstRegistryValues.Items.ContainsKey(e.Label))
			{
				MessageBox.Show("Invalid label. \nA node with that label already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.lstRegistryValues.Items[item].BeginEdit();
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
			msgPack.ForcePathObject("Command").AsString = "RenameRegistryValue";
			msgPack.ForcePathObject("OldValueName").AsString = this.lstRegistryValues.Items[item].Name;
			msgPack.ForcePathObject("NewValueName").AsString = e.Label;
			msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			this.lstRegistryValues.LabelEdit = false;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00004F21 File Offset: 0x00003121
		private void lstRegistryKeys_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && this.GetDeleteState())
			{
				this.deleteRegistryValue_Click(this, e);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00048C88 File Offset: 0x00046E88
		private void createNewRegistryKey_Click(object sender, EventArgs e)
		{
			if (!this.tvRegistryDirectory.SelectedNode.IsExpanded && this.tvRegistryDirectory.SelectedNode.Nodes.Count > 0)
			{
				this.tvRegistryDirectory.AfterExpand += this.createRegistryKey_AfterExpand;
				this.tvRegistryDirectory.SelectedNode.Expand();
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
			msgPack.ForcePathObject("Command").AsString = "CreateRegistryKey";
			msgPack.ForcePathObject("ParentPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00048D54 File Offset: 0x00046F54
		private void deleteRegistryKey_Click(object sender, EventArgs e)
		{
			string text = "Are you sure you want to permanently delete this key and all of its subkeys?";
			string caption = "Confirm Key Delete";
			if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				string fullPath = this.tvRegistryDirectory.SelectedNode.Parent.FullPath;
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "DeleteRegistryKey";
				msgPack.ForcePathObject("KeyName").AsString = this.tvRegistryDirectory.SelectedNode.Name;
				msgPack.ForcePathObject("ParentPath").AsString = fullPath;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004F3D File Offset: 0x0000313D
		private void renameRegistryKey_Click(object sender, EventArgs e)
		{
			this.tvRegistryDirectory.LabelEdit = true;
			this.tvRegistryDirectory.SelectedNode.BeginEdit();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00048E10 File Offset: 0x00047010
		private void createStringRegistryValue_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.SelectedNode != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
				msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
				msgPack.ForcePathObject("Kindstring").AsString = "1";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00048EB0 File Offset: 0x000470B0
		private void createBinaryRegistryValue_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.SelectedNode != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
				msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
				msgPack.ForcePathObject("Kindstring").AsString = "3";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00048F50 File Offset: 0x00047150
		private void createDwordRegistryValue_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.SelectedNode != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
				msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
				msgPack.ForcePathObject("Kindstring").AsString = "4";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00048FF0 File Offset: 0x000471F0
		private void createQwordRegistryValue_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.SelectedNode != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
				msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
				msgPack.ForcePathObject("Kindstring").AsString = "11";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00049090 File Offset: 0x00047290
		private void createMultiStringRegistryValue_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.SelectedNode != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
				msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
				msgPack.ForcePathObject("Kindstring").AsString = "7";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00049130 File Offset: 0x00047330
		private void createExpandStringRegistryValue_Click(object sender, EventArgs e)
		{
			if (this.tvRegistryDirectory.SelectedNode != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
				msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
				msgPack.ForcePathObject("Kindstring").AsString = "2";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000491D0 File Offset: 0x000473D0
		private void deleteRegistryValue_Click(object sender, EventArgs e)
		{
			string text = "Deleting certain registry values could cause system instability. Are you sure you want to permanently delete " + ((this.lstRegistryValues.SelectedItems.Count == 1) ? "this value?" : "these values?");
			string caption = "Confirm Value Delete";
			if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				foreach (object obj in this.lstRegistryValues.SelectedItems)
				{
					if (obj.GetType() == typeof(RegistryValueLstItem))
					{
						RegistryValueLstItem registryValueLstItem = (RegistryValueLstItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
						msgPack.ForcePathObject("Command").AsString = "DeleteRegistryValue";
						msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
						msgPack.ForcePathObject("ValueName").AsString = registryValueLstItem.RegName;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00004F5B File Offset: 0x0000315B
		private void renameRegistryValue_Click(object sender, EventArgs e)
		{
			this.lstRegistryValues.LabelEdit = true;
			this.lstRegistryValues.SelectedItems[0].BeginEdit();
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00004F7F File Offset: 0x0000317F
		private void modifyRegistryValue_Click(object sender, EventArgs e)
		{
			this.CreateEditForm(false);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00004F88 File Offset: 0x00003188
		private void modifyBinaryDataRegistryValue_Click(object sender, EventArgs e)
		{
			this.CreateEditForm(true);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00004F91 File Offset: 0x00003191
		private void createRegistryKey_AfterExpand(object sender, TreeViewEventArgs e)
		{
			if (e.Node == this.tvRegistryDirectory.SelectedNode)
			{
				this.createNewRegistryKey_Click(this, e);
				this.tvRegistryDirectory.AfterExpand -= this.createRegistryKey_AfterExpand;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00049314 File Offset: 0x00047514
		private bool GetDeleteState()
		{
			if (this.lstRegistryValues.Focused)
			{
				return this.lstRegistryValues.SelectedItems.Count > 0;
			}
			return this.tvRegistryDirectory.Focused && this.tvRegistryDirectory.SelectedNode != null && this.tvRegistryDirectory.SelectedNode.Parent != null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00049374 File Offset: 0x00047574
		private bool GetRenameState()
		{
			if (this.lstRegistryValues.Focused)
			{
				return this.lstRegistryValues.SelectedItems.Count == 1 && !RegValueHelper.IsDefaultValue(this.lstRegistryValues.SelectedItems[0].Name);
			}
			return this.tvRegistryDirectory.Focused && this.tvRegistryDirectory.SelectedNode != null && this.tvRegistryDirectory.SelectedNode.Parent != null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000493F4 File Offset: 0x000475F4
		private Form GetEditForm(RegistrySeeker.RegValueData value, RegistryValueKind valueKind)
		{
			switch (valueKind)
			{
			case RegistryValueKind.String:
			case RegistryValueKind.ExpandString:
				return new FormRegValueEditString(value);
			case RegistryValueKind.Binary:
				return new FormRegValueEditBinary(value);
			case RegistryValueKind.DWord:
			case RegistryValueKind.QWord:
				return new FormRegValueEditWord(value);
			case RegistryValueKind.MultiString:
				return new FormRegValueEditMultiString(value);
			}
			return null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00049454 File Offset: 0x00047654
		private void CreateEditForm(bool isBinary)
		{
			string fullPath = this.tvRegistryDirectory.SelectedNode.FullPath;
			string name = this.lstRegistryValues.SelectedItems[0].Name;
			RegistrySeeker.RegValueData regValueData = ((RegistrySeeker.RegValueData[])this.tvRegistryDirectory.SelectedNode.Tag).ToList<RegistrySeeker.RegValueData>().Find((RegistrySeeker.RegValueData item) => item.Name == name);
			RegistryValueKind valueKind = isBinary ? RegistryValueKind.Binary : regValueData.Kind;
			using (Form editForm = this.GetEditForm(regValueData, valueKind))
			{
				if (editForm.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
					msgPack.ForcePathObject("Command").AsString = "ChangeRegistryValue";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0004954C File Offset: 0x0004774C
		public void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.ParentClient.TcpClient.Connected || !this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00004FC5 File Offset: 0x000031C5
		private void FormRegistryEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Clients client = this.Client;
				if (client == null)
				{
					return;
				}
				client.Disconnected();
			});
		}
	}
}
