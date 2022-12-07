using System;
using System.Windows.Forms;

namespace Server.Helper.HexEditor
{
	// Token: 0x0200006A RID: 106
	public interface IKeyMouseEventHandler
	{
		// Token: 0x060003E4 RID: 996
		void OnKeyPress(KeyPressEventArgs e);

		// Token: 0x060003E5 RID: 997
		void OnKeyDown(KeyEventArgs e);

		// Token: 0x060003E6 RID: 998
		void OnKeyUp(KeyEventArgs e);

		// Token: 0x060003E7 RID: 999
		void OnMouseDown(MouseEventArgs e);

		// Token: 0x060003E8 RID: 1000
		void OnMouseDragged(MouseEventArgs e);

		// Token: 0x060003E9 RID: 1001
		void OnMouseUp(MouseEventArgs e);

		// Token: 0x060003EA RID: 1002
		void OnMouseDoubleClick(MouseEventArgs e);

		// Token: 0x060003EB RID: 1003
		void OnGotFocus(EventArgs e);
	}
}
