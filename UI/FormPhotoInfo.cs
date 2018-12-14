using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class FormPhotoInfo : Form
	{
		public FormPhotoInfo(PhotoPictureBox i_photo)
		{
			InitializeComponent();
			initPhotoInfo(i_photo);
		}

		private void initPhotoInfo(PhotoPictureBox i_photo)
		{
			pictureBoxPhoto.Image = i_photo.Image;
			pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
			labelLikes.Text = string.Format("Your photo liked by {0} people", i_photo.Photo.LikedBy.Count);

			foreach (Comment comment in i_photo.Photo.Comments)
			{
				listBoxComments.Items.Add(comment.Message);
			}
		}
	}
}