﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

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
				foreach (Album currentAlbum in DataManagerWrapper.DataManager.Albums)
				{
					addSingleAlbum(currentAlbum);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		private void addSingleAlbum(Album i_Album)
		{
			PictureBox albumToAdd = new PictureBox()
			{
				Size = new Size(140, 90),
				SizeMode = PictureBoxSizeMode.StretchImage
			};

			albumToAdd.LoadAsync(i_Album.PictureSmallURL);
			flowLayoutPanelUserAlbums.Controls.Add(albumToAdd);
			albumToAdd.MouseHover += (sender, e) => albumPictureBox_MouseHover(sender, i_Album);
			albumToAdd.MouseLeave += albumPictureBox_MouseLeave;
			albumToAdd.Click += (sender, e) => albumPictureBox_Click(i_Album);
		}

		private void albumPictureBox_Click(Album i_Album)
		{
			labelAlbumsName.Text = i_Album.Name;
			Controls.Remove(flowLayoutPanelUserAlbums);
			Controls.Add(flowLayoutPanelUserAlbumsPhotos);

			foreach (Photo currentPhoto in i_Album.Photos)
			{
				addSinglePhoto(currentPhoto);
			}

			buttonAlbums.Enabled = true;
			buttonAlbums.Text = "Back to albums";
		}

		private void albumPictureBox_MouseLeave(object sender, EventArgs e)
		{
			PictureBox albumPictureBox = sender as PictureBox;
			albumPictureBox.BorderStyle = BorderStyle.None;
			albumPictureBox.Cursor = Cursors.Default;
			albumPictureBox.Invalidate();
		}

		private void albumPictureBox_MouseHover(object sender, Album i_Album)
		{
			PictureBox albumPictureBox = sender as PictureBox;
			albumPictureBox.BorderStyle = BorderStyle.Fixed3D;
			albumPictureBox.Cursor = Cursors.Hand;

			using (Graphics G = Graphics.FromHwnd(albumPictureBox.Handle))
			{
				SizeF textSize = G.MeasureString(i_Album.Name, Font);
				PointF locationToDraw = new PointF()
				{
					X = (albumPictureBox.Width / 2) - (textSize.Width / 2),
					Y = (albumPictureBox.Height / 2) - (textSize.Height / 2)
				};
				G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
				G.DrawString(i_Album.Name, new Font(Font, FontStyle.Bold), Brushes.White, locationToDraw);
			}
		}

		private void addSinglePhoto(Photo i_Photo)
		{
			Control photoToAdd = new PhotoPictureBox(i_Photo)
			{
				Size = new Size(95, 80),
				SizeMode = PictureBoxSizeMode.StretchImage
			};

			flowLayoutPanelUserAlbumsPhotos.Controls.Add(photoToAdd);
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