using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using static Model.CollageData;
using Model;

namespace UI
{
	public partial class ControlCollagePage : UserControl, ILogoutable, IBackable
	{
		private FacebookObjectCollection<Photo> m_FilteredPhotosCollection;
		private FacebookObjectCollection<Image> m_SelectedImagesCollection = new FacebookObjectCollection<Image>();
		private eFrameCollage					m_FrameUserChoice;
		private ICollection<CollageBase>		m_AllCollagesCollection;

		public ControlCollagePage()
		{
			InitializeComponent();
		}

		public void AddBackButton(Button i_buttonBack)
		{
			Controls.Add(i_buttonBack);
		}

		private void radioButtonSharedPhotos_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSharedPhotos.Checked == true)
			{
				createFriendsCheckListBox();
				checkedListBoxFilter.Visible = true;
			}
		}

		private void radioButtonAlbumsPhotos_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonAlbumsPhotos.Checked == true)
			{
				createAlbumsCheckListBox();
				checkedListBoxFilter.Visible = true;
			}
		}

		private void radioButtonAllPhotos_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonAllPhotos.Checked == true)
			{
				checkedListBoxFilter.Visible = false;
			}
		}

		private void createFriendsCheckListBox()
		{
			try
			{
				checkedListBoxFilter.Items.Clear();
				ICollection<User> friendsCollection = DataManagerWrapper.DataManager.GetFriends();
				checkedListBoxFilter.DisplayMember = "Name";

				foreach (User friend in friendsCollection)
				{
					checkedListBoxFilter.Items.Add(friend);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch your friends names data.");
			}
		}

		private void createAlbumsCheckListBox()
		{
			try
			{
				checkedListBoxFilter.Items.Clear();
				ICollection<Album> albumsCollection = DataManagerWrapper.DataManager.GetAlbums();
				checkedListBoxFilter.DisplayMember = "Name";

				foreach (Album album in albumsCollection)
				{
					checkedListBoxFilter.Items.Add(album);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch your albums names data.");
			}
		}

		private void buttonSelectPhotos_Click(object sender, EventArgs e)
		{
			checkedListBoxPhotos.Items.Clear();
			if (radioButtonAllPhotos.Checked == true)
			{
				setAllPhotosOnListBox();
			}
			else if (radioButtonSharedPhotos.Checked == true)
			{
				if (checkedListBoxFilter.CheckedItems.Count == 0)
				{
					MessageBox.Show("Error! You didn't selected any friends.");
				}
				else
				{
					setSharedPhotosOnListBox();
				}
			}
			else
			{
				if (checkedListBoxFilter.CheckedItems.Count == 0)
				{
					MessageBox.Show("Error! You didn't selected any album.");
				}
				else
				{
					setSelectedAlbumsPhotosOnListBox();
				}
			}

			checkedListBoxPhotos.Visible = true;
			pictureBoxImage.Visible = true;
		}

		private void setSelectedAlbumsPhotosOnListBox()
		{
			try
			{
				ICollection<string> selectedAlbums = checkedListBoxFilter.CheckedItems.Cast<string>().ToList();
				m_FilteredPhotosCollection = DataManagerWrapper.DataManager.GetAlbumsPhotos(selectedAlbums);
				populateCheckedListBoxPhotos();
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch albums photos data.");
			}
		}

		private void populateCheckedListBoxPhotos()
		{
			int photoCounter = 1;

			foreach (Photo photo in m_FilteredPhotosCollection)
			{
				checkedListBoxPhotos.Items.Add(string.Format("Picture {0}", photoCounter));
				photoCounter++;
			}
		}

		private void setSharedPhotosOnListBox()
		{
			try
			{
				ICollection<string> selectedFriends = checkedListBoxFilter.CheckedItems.Cast<string>().ToList();
				m_FilteredPhotosCollection = DataManagerWrapper.DataManager.GetSharedFriendsPhotos(selectedFriends);
				populateCheckedListBoxPhotos();
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch friends shared photos data.");
			}
		}

		private void setAllPhotosOnListBox()
		{
			try
			{
				FacebookObjectCollection<Album> allAlbums = DataManagerWrapper.DataManager.GetAlbums();

				m_FilteredPhotosCollection = new FacebookObjectCollection<Photo>();
				int nodeCouner = 0;
				foreach (Album album in allAlbums)
				{
					int photoCounter = 1;
					foreach (Photo photo in album.Photos)
					{
						checkedListBoxPhotos.Items.Add(string.Format("{0} - Picture {1}", album.Name, photoCounter));
						m_FilteredPhotosCollection.Add(photo);
						photoCounter++;
					}

					nodeCouner++;
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch albums data.");
			}
		}

		private void listBoxPhotosChecked_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (checkedListBoxPhotos.SelectedItem != null)
			{
				pictureBoxImage.LoadAsync(m_FilteredPhotosCollection[checkedListBoxPhotos.SelectedIndex].PictureNormalURL);
				pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;

				if (checkedListBoxPhotos.CheckedItems.Count > 0)
				{
					buttonSeeCollage.Enabled = true;
				}
			}
		}

		public void AddLogoutButton(Button i_ButtonLogout)
		{
			Controls.Add(i_ButtonLogout);
		}

		private void checkedListBox_Click(object sender, EventArgs e)
		{
			changeItemCheckedStatus(sender as CheckedListBox);
		}

		private void checkedListBox_MouseClick(object sender, MouseEventArgs e)
		{
			changeItemCheckedStatus(sender as CheckedListBox);
		}

		private void changeItemCheckedStatus(CheckedListBox i_CheckedListBox)
		{
			if (i_CheckedListBox.SelectedItem != null)
			{
				i_CheckedListBox.SetItemCheckState(
					i_CheckedListBox.SelectedIndex,
				i_CheckedListBox.GetItemCheckState(i_CheckedListBox.SelectedIndex) == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
			}
		}

		private bool checkIfUserSelectedTheCorrectImagesQuantity()
		{
			const int k_UserChoiceOffset = 3;

			return m_SelectedImagesCollection.Count == (int)(m_FrameUserChoice + k_UserChoiceOffset);
		}

		private void photosCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (checkedListBoxPhotos.GetItemChecked(checkedListBoxPhotos.SelectedIndex))
			{
				m_SelectedImagesCollection.Remove(
					m_FilteredPhotosCollection[checkedListBoxPhotos.SelectedIndex].ImageNormal);
			}
			else
			{
				m_SelectedImagesCollection.Add(
					m_FilteredPhotosCollection[checkedListBoxPhotos.SelectedIndex].ImageNormal);
			}
		}

		private void buttonCollageFrame_Click(object sender, EventArgs e)
		{
			m_AllCollagesCollection = CollagesFactory.CreateAllCollages();
			FormCollageFrameOptions collageForm = new FormCollageFrameOptions(m_AllCollagesCollection);
			collageForm.FormClosing += formCollage_FormClosing;
			collageForm.ShowDialog();
		}

		private void formCollage_FormClosing(object sender, FormClosingEventArgs e)
		{
			m_FrameUserChoice = (sender as FormCollageFrameOptions).GetUserChoice();
			groupBoxPhotosChooser.Enabled = true;
			buttonSelectPhotos.Enabled = true;
		}

		private void buttonSeeCollage_Click(object sender, EventArgs e)
		{
			if (checkIfUserSelectedTheCorrectImagesQuantity())
			{
				try
				{
					m_AllCollagesCollection.ElementAt((int)m_FrameUserChoice).CreateCollage(m_SelectedImagesCollection);
					FormCollageView collageViewForm = new FormCollageView(m_AllCollagesCollection.ElementAt((int)m_FrameUserChoice));
					collageViewForm.ShowDialog();
				}
				catch (Exception ex)
				{
					FormFacebookApp.ShowFacebookError(ex.Message);
				}
			}
			else
			{
				FormFacebookApp.ShowFacebookError("Error! There is a mismatch between your frame choice to the number of images you selected.");
			}
		}
	}
}