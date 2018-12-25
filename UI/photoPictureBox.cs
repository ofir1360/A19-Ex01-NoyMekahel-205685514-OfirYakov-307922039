using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	internal class PhotoPictureBox : PictureBox 
	{
		public Photo Photo { get; private set; }

		public PhotoPictureBox(Photo i_Photo)
		{
			Photo = i_Photo;
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			FormPhotoInfo photoInfo = new FormPhotoInfo(Photo);
			photoInfo.ShowDialog();
		}

		protected override void OnMouseHover(EventArgs e)
		{
			base.OnMouseHover(e);
			this.Cursor = Cursors.Hand;
			this.BorderStyle = BorderStyle.Fixed3D;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.Cursor = Cursors.Default;
			this.BorderStyle = BorderStyle.None;
		}
	}
}
