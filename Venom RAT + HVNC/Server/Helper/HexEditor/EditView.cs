using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Helper.HexEditor
{
	// Token: 0x02000066 RID: 102
	public class EditView : IKeyMouseEventHandler
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00003D44 File Offset: 0x00001F44
		public EditView(HexEditor editor)
		{
			this._editor = editor;
			this._hexView = new HexViewHandler(editor);
			this._stringView = new StringViewHandler(editor);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003D6B File Offset: 0x00001F6B
		public void OnKeyPress(KeyPressEventArgs e)
		{
			if (this.InHexView(this._editor.CaretPosX))
			{
				this._hexView.OnKeyPress(e);
				return;
			}
			this._stringView.OnKeyPress(e);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003D99 File Offset: 0x00001F99
		public void OnKeyDown(KeyEventArgs e)
		{
			if (this.InHexView(this._editor.CaretPosX))
			{
				this._hexView.OnKeyDown(e);
				return;
			}
			this._stringView.OnKeyDown(e);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000024F0 File Offset: 0x000006F0
		public void OnKeyUp(KeyEventArgs e)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0002277C File Offset: 0x0002097C
		public void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.InHexView(e.X))
				{
					this._hexView.OnMouseDown(e.X, e.Y);
					return;
				}
				this._stringView.OnMouseDown(e.X, e.Y);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000227D4 File Offset: 0x000209D4
		public void OnMouseDragged(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.InHexView(e.X))
				{
					this._hexView.OnMouseDragged(e.X, e.Y);
					return;
				}
				this._stringView.OnMouseDragged(e.X, e.Y);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000024F0 File Offset: 0x000006F0
		public void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public void OnMouseDoubleClick(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.InHexView(e.X))
				{
					this._hexView.OnMouseDoubleClick();
					return;
				}
				this._stringView.OnMouseDoubleClick();
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003DFB File Offset: 0x00001FFB
		public void OnGotFocus(EventArgs e)
		{
			if (this.InHexView(this._editor.CaretPosX))
			{
				this._hexView.Focus();
				return;
			}
			this._stringView.Focus();
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00003E27 File Offset: 0x00002027
		public void SetLowerCase()
		{
			this._hexView.SetLowerCase();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003E34 File Offset: 0x00002034
		public void SetUpperCase()
		{
			this._hexView.SetUpperCase();
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003E41 File Offset: 0x00002041
		public void Update(int startPositionX, Rectangle area)
		{
			this._hexView.Update(startPositionX, area);
			this._stringView.Update(this._hexView.MaxWidth, area);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0002282C File Offset: 0x00020A2C
		public void Paint(Graphics g, int startIndex, int endIndex)
		{
			int num = 0;
			while (num + startIndex < endIndex)
			{
				this._hexView.Paint(g, num, startIndex);
				this._stringView.Paint(g, num, startIndex);
				num++;
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003E67 File Offset: 0x00002067
		private bool InHexView(int x)
		{
			return x < this._hexView.MaxWidth + this._editor.EntityMargin - 2;
		}

		// Token: 0x0400029A RID: 666
		private HexViewHandler _hexView;

		// Token: 0x0400029B RID: 667
		private StringViewHandler _stringView;

		// Token: 0x0400029C RID: 668
		private HexEditor _editor;
	}
}
