using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Helper.HexEditor
{
	// Token: 0x0200006B RID: 107
	public class StringViewHandler
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000042B2 File Offset: 0x000024B2
		public int MaxWidth
		{
			get
			{
				return this._recStringView.X + this._recStringView.Width;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000042CB File Offset: 0x000024CB
		public StringViewHandler(HexEditor editor)
		{
			this._editor = editor;
			this._stringFormat = new StringFormat(StringFormat.GenericTypographic);
			this._stringFormat.Alignment = StringAlignment.Center;
			this._stringFormat.LineAlignment = StringAlignment.Center;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00004302 File Offset: 0x00002502
		public void OnKeyPress(KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar))
			{
				this.HandleUserInput(e.KeyChar);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00024A24 File Offset: 0x00022C24
		public void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
			{
				if (this._editor.SelectionLength > 0)
				{
					this.HandleUserRemove();
					int caretIndex = this._editor.CaretIndex;
					Point caretLocation = this.GetCaretLocation(caretIndex);
					this._editor.SetCaretStart(caretIndex, caretLocation);
					return;
				}
				if (this._editor.CaretIndex < this._editor.LastVisibleByte && e.KeyCode == Keys.Delete)
				{
					this._editor.RemoveByteAt(this._editor.CaretIndex);
					Point caretLocation2 = this.GetCaretLocation(this._editor.CaretIndex);
					this._editor.SetCaretStart(this._editor.CaretIndex, caretLocation2);
					return;
				}
				if (this._editor.CaretIndex > 0 && e.KeyCode == Keys.Back)
				{
					int index = this._editor.CaretIndex - 1;
					this._editor.RemoveByteAt(index);
					Point caretLocation3 = this.GetCaretLocation(index);
					this._editor.SetCaretStart(index, caretLocation3);
					return;
				}
			}
			else if (e.KeyCode == Keys.Up && this._editor.CaretIndex - this._editor.BytesPerLine >= 0)
			{
				int num = this._editor.CaretIndex - this._editor.BytesPerLine;
				if (num % this._editor.BytesPerLine != 0 || this._editor.CaretPosX < this._recStringView.X + this._recStringView.Width)
				{
					this.HandleArrowKeys(num, e.Shift);
					return;
				}
				Point location = new Point(this._editor.CaretPosX, this._editor.CaretPosY - this._recStringView.Height);
				if (num == 0)
				{
					location = new Point(this._editor.CaretPosX, this._editor.CaretPosY);
					num = this._editor.BytesPerLine;
				}
				if (e.Shift)
				{
					this._editor.SetCaretEnd(num, location);
					return;
				}
				this._editor.SetCaretStart(num, location);
				return;
			}
			else if (e.KeyCode == Keys.Down && (this._editor.CaretIndex - 1) / this._editor.BytesPerLine < this._editor.HexTableLength / this._editor.BytesPerLine)
			{
				int num2 = this._editor.CaretIndex + this._editor.BytesPerLine;
				if (num2 > this._editor.HexTableLength)
				{
					num2 = this._editor.HexTableLength;
					this.HandleArrowKeys(num2, e.Shift);
					return;
				}
				Point location2 = new Point(this._editor.CaretPosX, this._editor.CaretPosY + this._recStringView.Height);
				if (e.Shift)
				{
					this._editor.SetCaretEnd(num2, location2);
					return;
				}
				this._editor.SetCaretStart(num2, location2);
				return;
			}
			else
			{
				if (e.KeyCode == Keys.Left && this._editor.CaretIndex - 1 >= 0)
				{
					int index2 = this._editor.CaretIndex - 1;
					this.HandleArrowKeys(index2, e.Shift);
					return;
				}
				if (e.KeyCode == Keys.Right && this._editor.CaretIndex + 1 <= this._editor.LastVisibleByte)
				{
					int index3 = this._editor.CaretIndex + 1;
					this.HandleArrowKeys(index3, e.Shift);
				}
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00024D88 File Offset: 0x00022F88
		public void HandleArrowKeys(int index, bool isShiftDown)
		{
			Point caretLocation = this.GetCaretLocation(index);
			if (isShiftDown)
			{
				this._editor.SetCaretEnd(index, caretLocation);
				return;
			}
			this._editor.SetCaretStart(index, caretLocation);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00024DBC File Offset: 0x00022FBC
		public void OnMouseDown(int x, int y)
		{
			int num = (x - this._recStringView.X) / (int)this._editor.CharSize.Width;
			int num2 = (y - this._recStringView.Y) / this._recStringView.Height;
			num = ((num > this._editor.BytesPerLine) ? this._editor.BytesPerLine : num);
			num = ((num < 0) ? 0 : num);
			num2 = ((num2 > this._editor.MaxBytesV) ? this._editor.MaxBytesV : num2);
			num2 = ((num2 < 0) ? 0 : num2);
			if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine <= num2)
			{
				if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine <= num)
				{
					num = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine;
				}
				num2 = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine;
			}
			int index = Math.Min(this._editor.LastVisibleByte, this._editor.FirstVisibleByte + num + num2 * this._editor.BytesPerLine);
			int x2 = num * (int)this._editor.CharSize.Width + this._recStringView.X;
			int y2 = num2 * this._recStringView.Height + this._recStringView.Y;
			this._editor.SetCaretStart(index, new Point(x2, y2));
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00024F68 File Offset: 0x00023168
		public void OnMouseDragged(int x, int y)
		{
			int num = (x - this._recStringView.X) / (int)this._editor.CharSize.Width;
			int num2 = (y - this._recStringView.Y) / this._recStringView.Height;
			num = ((num > this._editor.BytesPerLine) ? this._editor.BytesPerLine : num);
			num = ((num < 0) ? 0 : num);
			num2 = ((num2 > this._editor.MaxBytesV) ? this._editor.MaxBytesV : num2);
			if (this._editor.FirstVisibleByte > 0)
			{
				num2 = ((num2 < 0) ? -1 : num2);
			}
			else
			{
				num2 = ((num2 < 0) ? 0 : num2);
			}
			if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine <= num2)
			{
				if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine <= num)
				{
					num = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine;
				}
				num2 = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine;
			}
			int index = Math.Min(this._editor.LastVisibleByte, this._editor.FirstVisibleByte + num + num2 * this._editor.BytesPerLine);
			int x2 = num * (int)this._editor.CharSize.Width + this._recStringView.X;
			int y2 = num2 * this._recStringView.Height + this._recStringView.Y;
			this._editor.SetCaretEnd(index, new Point(x2, y2));
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0002512C File Offset: 0x0002332C
		public void OnMouseDoubleClick()
		{
			if (this._editor.CaretIndex < this._editor.LastVisibleByte)
			{
				int index = this._editor.CaretIndex + 1;
				Point caretLocation = this.GetCaretLocation(index);
				this._editor.SetCaretEnd(index, caretLocation);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00025174 File Offset: 0x00023374
		public void Focus()
		{
			int caretIndex = this._editor.CaretIndex;
			Point caretLocation = this.GetCaretLocation(caretIndex);
			this._editor.SetCaretStart(caretIndex, caretLocation);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000251A4 File Offset: 0x000233A4
		public void Update(int startPositionX, Rectangle area)
		{
			this._recStringView = new Rectangle(startPositionX, area.Y, (int)(this._editor.CharSize.Width * (float)this._editor.BytesPerLine), (int)this._editor.CharSize.Height - 2);
			this._recStringView.X = this._recStringView.X + this._editor.EntityMargin;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00025218 File Offset: 0x00023418
		public void Paint(Graphics g, int index, int startIndex)
		{
			Point byteColumnAndRow = this.GetByteColumnAndRow(index);
			if (this._editor.IsSelected(index + startIndex))
			{
				this.PaintByteAsSelected(g, byteColumnAndRow, index + startIndex);
				return;
			}
			this.PaintByte(g, byteColumnAndRow, index + startIndex);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00025254 File Offset: 0x00023454
		private void PaintByteAsSelected(Graphics g, Point point, int index)
		{
			SolidBrush brush = new SolidBrush(this._editor.SelectionBackColor);
			SolidBrush brush2 = new SolidBrush(this._editor.SelectionForeColor);
			RectangleF bound = this.GetBound(point);
			char byteAsChar = this._editor.GetByteAsChar(index);
			string s = char.IsControl(byteAsChar) ? "." : byteAsChar.ToString();
			g.FillRectangle(brush, bound);
			g.DrawString(s, this._editor.Font, brush2, bound, this._stringFormat);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000252D4 File Offset: 0x000234D4
		private void PaintByte(Graphics g, Point point, int index)
		{
			SolidBrush brush = new SolidBrush(this._editor.ForeColor);
			RectangleF bound = this.GetBound(point);
			char byteAsChar = this._editor.GetByteAsChar(index);
			string s = char.IsControl(byteAsChar) ? "." : byteAsChar.ToString();
			g.DrawString(s, this._editor.Font, brush, bound, this._stringFormat);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00025338 File Offset: 0x00023538
		private Point GetCaretLocation(int index)
		{
			int x = this._recStringView.X + (int)this._editor.CharSize.Width * (index % this._editor.BytesPerLine);
			int y = this._recStringView.Y + this._recStringView.Height * ((index - (this._editor.FirstVisibleByte + index % this._editor.BytesPerLine)) / this._editor.BytesPerLine);
			return new Point(x, y);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000253BC File Offset: 0x000235BC
		private void HandleUserRemove()
		{
			int selectionStart = this._editor.SelectionStart;
			Point caretLocation = this.GetCaretLocation(selectionStart);
			this._editor.RemoveSelectedBytes();
			this._editor.SetCaretStart(selectionStart, caretLocation);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000253F8 File Offset: 0x000235F8
		private void HandleUserInput(char key)
		{
			if (!this._editor.CaretFocused)
			{
				return;
			}
			this.HandleUserRemove();
			byte item = Convert.ToByte(key);
			if (this._editor.HexTableLength <= 0)
			{
				this._editor.AppendByte(item);
			}
			else
			{
				this._editor.InsertByte(this._editor.CaretIndex, item);
			}
			int index = this._editor.CaretIndex + 1;
			Point caretLocation = this.GetCaretLocation(index);
			this._editor.SetCaretStart(index, caretLocation);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00025478 File Offset: 0x00023678
		private Point GetByteColumnAndRow(int index)
		{
			int x = index % this._editor.BytesPerLine;
			int y = index / this._editor.BytesPerLine;
			return new Point(x, y);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000254A8 File Offset: 0x000236A8
		private RectangleF GetBound(Point point)
		{
			return new RectangleF((float)(this._recStringView.X + point.X * (int)this._editor.CharSize.Width), (float)(this._recStringView.Y + point.Y * this._recStringView.Height), this._editor.CharSize.Width, (float)this._recStringView.Height);
		}

		// Token: 0x040002CD RID: 717
		private Rectangle _recStringView;

		// Token: 0x040002CE RID: 718
		private StringFormat _stringFormat;

		// Token: 0x040002CF RID: 719
		private HexEditor _editor;
	}
}
