using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class FormPhotoInfo : Form
	{
		public FormPhotoInfo(Photo i_photo)
		{
			InitializeComponent();
			initPhotoInfo(i_photo);
		}

		private void initPhotoInfo(Photo i_photo)
		{
			pictureBoxPhoto.Image = i_photo.ImageNormal;
			pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
			labelLikes.Text = string.Format("Your photo liked by {0} people", i_photo.LikedBy.Count);

			foreach (Comment comment in i_photo.Comments)
			{
				listBoxComments.Items.Add(comment.Message);
			}
		}
	}
}