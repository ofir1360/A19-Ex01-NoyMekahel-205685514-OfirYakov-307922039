﻿using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

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
			new Thread(controlUserDetails.ShowUserInfo).Start();
			new Thread(ShowUserFriends).Start();
		}

		internal void ShowUserFriends()
		{
			try
			{
				FacebookObjectCollection<User> allFriends = DataManagerWrapper.DataManager.Friends;
				int counter = 0;

				this.Invoke(new Action(() => bindingSourceFriendsGrid.DataSource = allFriends));
			
				foreach (User currentUser in allFriends)
				{
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell()
					{
						Value = currentUser.Location.Name
					};
					dataGridViewFriends.Invoke(new Action(
						() => dataGridViewFriends.Rows[counter].Cells[locationColumn.Index] = cell));
					counter++;
				}
			}
			catch (Exception ex)
			{
				FormFacebookApp.ShowFacebookError(ex.Message);
			}
		}

		public void AddLogoutButton(Button i_ButtonLogout)
		{
			Controls.Add(i_ButtonLogout);
		}

		private void buttonLikedPages_Click(object sender, EventArgs e)
		{
			new Thread(showUserLikedPages).Start();
		}

		private void showUserLikedPages()
		{
			try
			{
				FacebookObjectCollection<Page> allLikedPages = DataManagerWrapper.DataManager.UserLikedPages;
				getAllPagesImage(allLikedPages);

				foreach (Page currentPage in allLikedPages)
				{
					ListViewItem item = new ListViewItem() { ImageIndex = 0 };
					item.SubItems.Add(currentPage.Name);
					item.SubItems.Add(currentPage.LikesCount.ToString());
					listViewLikedPages.Invoke(new Action(() => listViewLikedPages.Items.Add(item)));
				}

				buttonLikedPages.Invoke(new Action(() => buttonLikedPages.Enabled = false));
				listViewLikedPages.Invoke(new Action(() => listViewLikedPages.Visible = true));
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("FaceBook error! Couldn't fetch liked pages data");
			}
		}

		private void getAllPagesImage(FacebookObjectCollection<Page> i_AllLikedPages)
		{
			ImageList allPagesImage = new ImageList();

			foreach (Page currentPage in i_AllLikedPages)
			{
				allPagesImage.Images.Add(currentPage.ImageSmall);
			}

			listViewLikedPages.Invoke(new Action(() => listViewLikedPages.SmallImageList = allPagesImage));
		}

		private void buttonPosts_Click(object sender, EventArgs e)
		{
			new Thread(showUserPosts).Start();
		}

		private void showUserPosts()
		{
			try
			{
				FacebookObjectCollection<Post> allPosts = DataManagerWrapper.DataManager.UserPosts;

				foreach (Post currentPost in allPosts)
				{
					if (currentPost.Message != null)
					{
						ListViewItem item = new ListViewItem() { Text = currentPost.CreatedTime.ToString() };
						item.SubItems.Add(currentPost.Message);
						listViewPosts.Invoke(new Action(() => listViewPosts.Items.Add(item)));

					}
				}

				listViewPosts.Invoke(new Action(() => listViewPosts.Columns[messagesColumn.Index].Width = -1));
				buttonPosts.Invoke(new Action(() => buttonPosts.Enabled = false));
				listViewPosts.Invoke(new Action(() => listViewPosts.Visible = true));
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