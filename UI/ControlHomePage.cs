using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class ControlHomePage : UserControl, ILogoutable
	{
		public ControlHomePage()
		{
			InitializeComponent();
		}

		internal void ButtonFindARide_AddClickedListener(EventHandler i_EventHandler)
		{
			this.buttonFindARide.Click += i_EventHandler;
		}

		internal void FetchUserInfo()
		{
			try
			{
				controlUserDetails.ShowUserInfo();
				ShowUserFriends();
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		internal void ShowUserFriends()
		{
			try
			{
				FacebookObjectCollection<User> allFriends = DataManagerWrapper.DataManager.GetFriends();
				int counter = 0;

				bindingSourceFriendsGrid.DataSource = allFriends;

				foreach (User currentUser in allFriends)
				{
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell()
					{
						Value = currentUser.Location.Name
					};
					dataGridViewFriends.Rows[counter].Cells[locationColumn.Index] = cell;
					counter++;
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		public void AddLogoutButton(Button i_ButtonLogout)
		{
			Controls.Add(i_ButtonLogout);
		}

		private void buttonLikedPages_Click(object sender, EventArgs e)
		{
			showUserLikedPages();
		}

		private void showUserLikedPages()
		{
			try
			{
				FacebookObjectCollection<Page>	allLikedPages = DataManagerWrapper.DataManager.GetUserLikedPages();
				ImageList						allPagesImage = getAllPagesImage(allLikedPages);
				listViewLikedPages.SmallImageList = allPagesImage;

				foreach (Page currentPage in allLikedPages)
				{
					ListViewItem item = new ListViewItem() { ImageIndex = 0 };
					item.SubItems.Add(currentPage.Name);
					item.SubItems.Add(currentPage.LikesCount.ToString());
					listViewLikedPages.Items.Add(item);
				}

				buttonLikedPages.Enabled = false;
				listViewLikedPages.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("FaceBook error! Couldn't fetch liked pages data");
			}
		}

		private ImageList getAllPagesImage(FacebookObjectCollection<Page> i_AllLikedPages)
		{
			ImageList allPagesImage = new ImageList();

			foreach (Page currentPage in i_AllLikedPages)
			{
				allPagesImage.Images.Add(currentPage.ImageSmall);
			}

			return allPagesImage;
		}

		private void buttonPosts_Click(object sender, EventArgs e)
		{
			showUserPosts();
		}

		private void showUserPosts()
		{
			try
			{
				FacebookObjectCollection<Post> allPosts = DataManagerWrapper.DataManager.GetUserPosts();

				foreach (Post currentPost in allPosts)
				{
					if (currentPost.Message != null)
					{
						ListViewItem item = new ListViewItem() { Text = currentPost.CreatedTime.ToString() };
						item.SubItems.Add(currentPost.Message);
						listViewPosts.Items.Add(item);
					}
				}

				listViewPosts.Columns[messagesColumn.Index].Width = -1;
				buttonPosts.Enabled = false;
				listViewPosts.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("FaceBook error! Couldn't fetch posts data");
			}
		}

		internal void ButtonCreateCollage_AddClickedListener(EventHandler i_EventHandler)
		{
			this.buttonCreateCollage.Click += i_EventHandler;
		}
	}
}