using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace UI
{
	public partial class ControlAlbum : UserControl
	{
		public ControlAlbum()
		{
			InitializeComponent();
		}

		private void showUserAlbums()
		{
			try
			{
				FacebookObjectCollection<Album> allAlbums = DataManagerWrapper.DataManager.GetAlbums();

				foreach (Album currentAlbum in allAlbums)
				{
					addSingleAlbum(currentAlbum);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		private void albumPictureBox_Click(object sender, EventArgs e)
		{
			AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;

			labelAlbumsName.Text = albumPictureBox.Album.Name;
			Controls.Remove(flowLayoutPanelUserAlbums);
			Controls.Add(flowLayoutPanelUserAlbumsPhotos);

			foreach (Photo currentPhoto in albumPictureBox.Album.Photos)
			{
				addSinglePhoto(currentPhoto);
			}

			buttonAlbums.Enabled = true;
			buttonAlbums.Text = "Back to albums";
		}

		private void addSingleAlbum(Album i_Album)
		{
			AlbumPictureBox albumToAdd = new AlbumPictureBox()
			{
				Album = i_Album,
				Size = new Size(140, 90),
				SizeMode = PictureBoxSizeMode.StretchImage
			};

			albumToAdd.LoadAsync(i_Album.PictureSmallURL);
			flowLayoutPanelUserAlbums.Controls.Add(albumToAdd);
			albumToAdd.MouseHover += albumPictureBox_MouseHover;
			albumToAdd.MouseLeave += albumPictureBox_MouseLeave;
			albumToAdd.Click += albumPictureBox_Click;
		}

		private void addSinglePhoto(Photo i_Photo)
		{
			PhotoPictureBox photoToAdd = new PhotoPictureBox()
			{
				Photo = i_Photo,
				Size = new Size(95, 80),
				SizeMode = PictureBoxSizeMode.StretchImage
			};

			photoToAdd.LoadAsync(i_Photo.PictureNormalURL);
			flowLayoutPanelUserAlbumsPhotos.Controls.Add(photoToAdd);
			photoToAdd.Click += photoPictureBox_Click;
			photoToAdd.MouseHover += photoPictureBox_MouseHover;
			photoToAdd.MouseLeave += photoPictureBox_MouseLeave;
		}

		private void photoPictureBox_MouseLeave(object sender, EventArgs e)
		{
			PhotoPictureBox photoPictureBox = sender as PhotoPictureBox;
			photoPictureBox.Cursor = Cursors.Default;
			photoPictureBox.BorderStyle = BorderStyle.None;
		}

		private void photoPictureBox_MouseHover(object sender, EventArgs e)
		{
			PhotoPictureBox photoPictureBox = sender as PhotoPictureBox;
			photoPictureBox.Cursor = Cursors.Hand;
			photoPictureBox.BorderStyle = BorderStyle.Fixed3D;
		}

		private void photoPictureBox_Click(object sender, EventArgs e)
		{
			PhotoPictureBox photo = sender as PhotoPictureBox;
			FormPhotoInfo	photoInfo = new FormPhotoInfo(photo);
			photoInfo.ShowDialog();
		}

		private void albumPictureBox_MouseLeave(object sender, EventArgs e)
		{
			AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
			albumPictureBox.BorderStyle = BorderStyle.None;
			albumPictureBox.Cursor = Cursors.Default;
			albumPictureBox.Invalidate();
		}

		private void albumPictureBox_MouseHover(object sender, EventArgs e)
		{
			AlbumPictureBox albumPictureBox = sender as AlbumPictureBox;
			albumPictureBox.BorderStyle = BorderStyle.Fixed3D;
			albumPictureBox.Cursor = Cursors.Hand;

			using (Graphics G = Graphics.FromHwnd(albumPictureBox.Handle))
			{
				SizeF	textSize = G.MeasureString(albumPictureBox.Album.Name, Font);
				PointF	locationToDraw = new PointF()
				{
					X = (albumPictureBox.Width / 2) - (textSize.Width / 2),
					Y = (albumPictureBox.Height / 2) - (textSize.Height / 2)
				};
				G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
				G.DrawString(albumPictureBox.Album.Name, new Font(Font, FontStyle.Bold), Brushes.White, locationToDraw);
			}
		}

		private void buttonAlbums_Click(object sender, EventArgs e)
		{
			buttonAlbums.Enabled = false;
			buttonAlbums.Text = "Albums";
			flowLayoutPanelUserAlbums.Controls.Clear();
			flowLayoutPanelUserAlbums.Visible = true;
			labelAlbumsName.Text = string.Empty;
			flowLayoutPanelUserAlbumsPhotos.Controls.Clear();
			showUserAlbums();
			Controls.Remove(flowLayoutPanelUserAlbumsPhotos);
			Controls.Add(flowLayoutPanelUserAlbums);
		}
	}
}