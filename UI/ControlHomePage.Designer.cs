using System.Drawing;

namespace UI
{
	public partial class ControlHomePage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.labelFriensList = new System.Windows.Forms.Label();
			this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageSmall = new System.Windows.Forms.DataGridViewImageColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.listViewPosts = new System.Windows.Forms.ListView();
			this.postDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.messagesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewLikedPages = new System.Windows.Forms.ListView();
			this.ImageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pageNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.likesCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bindingSourcePosts = new System.Windows.Forms.BindingSource(this.components);
			this.buttonCreateCollage = new System.Windows.Forms.Button();
			this.buttonPosts = new System.Windows.Forms.Button();
			this.buttonLikedPages = new System.Windows.Forms.Button();
			this.buttonFindARide = new System.Windows.Forms.Button();
			this.controlUserAlbums = new UI.ControlAlbum();
			this.controlUserDetails = new UI.ControlUserDetails();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePosts)).BeginInit();
			this.SuspendLayout();
			// 
			// labelFriensList
			// 
			this.labelFriensList.AutoSize = true;
			this.labelFriensList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.labelFriensList.Location = new System.Drawing.Point(11, 428);
			this.labelFriensList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelFriensList.Name = "labelFriensList";
			this.labelFriensList.Size = new System.Drawing.Size(176, 32);
			this.labelFriensList.TabIndex = 11;
			this.labelFriensList.Text = "Your friends:";
			// 
			// dataGridViewFriends
			// 
			this.dataGridViewFriends.AllowUserToAddRows = false;
			this.dataGridViewFriends.AllowUserToDeleteRows = false;
			this.dataGridViewFriends.AllowUserToResizeRows = false;
			this.dataGridViewFriends.AutoGenerateColumns = false;
			this.dataGridViewFriends.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewFriends.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGridViewFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.FirstName,
			this.LastName,
			this.ImageSmall,
			this.birthdayDataGridViewTextBoxColumn,
			this.aboutDataGridViewTextBoxColumn,
			this.emailDataGridViewTextBoxColumn,
			this.locationColumn});
			this.dataGridViewFriends.DataSource = this.bindingSourceFriendsGrid;
			this.dataGridViewFriends.Location = new System.Drawing.Point(2, 464);
			this.dataGridViewFriends.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewFriends.Name = "dataGridViewFriends";
			this.dataGridViewFriends.ReadOnly = true;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewFriends.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridViewFriends.RowTemplate.Height = 28;
			this.dataGridViewFriends.Size = new System.Drawing.Size(626, 164);
			this.dataGridViewFriends.TabIndex = 10;
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FirstName.DefaultCellStyle = dataGridViewCellStyle9;
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.LastName.DefaultCellStyle = dataGridViewCellStyle10;
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// ImageSmall
			// 
			this.ImageSmall.DataPropertyName = "ImageSmall";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.NullValue = null;
			this.ImageSmall.DefaultCellStyle = dataGridViewCellStyle11;
			this.ImageSmall.HeaderText = "Image";
			this.ImageSmall.Name = "ImageSmall";
			this.ImageSmall.ReadOnly = true;
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.birthdayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// aboutDataGridViewTextBoxColumn
			// 
			this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.aboutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
			this.aboutDataGridViewTextBoxColumn.HeaderText = "About";
			this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
			this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// locationColumn
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.locationColumn.DefaultCellStyle = dataGridViewCellStyle15;
			this.locationColumn.HeaderText = "Location";
			this.locationColumn.Name = "locationColumn";
			this.locationColumn.ReadOnly = true;
			// 
			// bindingSourceFriendsGrid
			// 
			this.bindingSourceFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// listViewPosts
			// 
			this.listViewPosts.BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			this.listViewPosts.BackgroundImageTiled = true;
			this.listViewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.postDateColumn,
			this.messagesColumn});
			this.listViewPosts.Location = new System.Drawing.Point(264, 328);
			this.listViewPosts.Name = "listViewPosts";
			this.listViewPosts.Size = new System.Drawing.Size(363, 131);
			this.listViewPosts.TabIndex = 19;
			this.listViewPosts.UseCompatibleStateImageBehavior = false;
			this.listViewPosts.View = System.Windows.Forms.View.Details;
			this.listViewPosts.Visible = false;
			// 
			// postDateColumn
			// 
			this.postDateColumn.Text = "Date";
			this.postDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.postDateColumn.Width = 106;
			// 
			// messagesColumn
			// 
			this.messagesColumn.Text = "Message";
			this.messagesColumn.Width = 211;
			// 
			// listViewLikedPages
			// 
			this.listViewLikedPages.BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			this.listViewLikedPages.BackgroundImageTiled = true;
			this.listViewLikedPages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.ImageColumnHeader,
			this.pageNameColumnHeader,
			this.likesCountColumnHeader});
			this.listViewLikedPages.Location = new System.Drawing.Point(3, 328);
			this.listViewLikedPages.Name = "listViewLikedPages";
			this.listViewLikedPages.Size = new System.Drawing.Size(254, 97);
			this.listViewLikedPages.TabIndex = 18;
			this.listViewLikedPages.UseCompatibleStateImageBehavior = false;
			this.listViewLikedPages.View = System.Windows.Forms.View.Details;
			this.listViewLikedPages.Visible = false;
			// 
			// ImageColumnHeader
			// 
			this.ImageColumnHeader.Text = "Page Image";
			this.ImageColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ImageColumnHeader.Width = 77;
			// 
			// pageNameColumnHeader
			// 
			this.pageNameColumnHeader.Text = "Page Name";
			this.pageNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.pageNameColumnHeader.Width = 78;
			// 
			// likesCountColumnHeader
			// 
			this.likesCountColumnHeader.Text = "Likes";
			this.likesCountColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonCreateCollage
			// 
			this.buttonCreateCollage.BackColor = System.Drawing.Color.Transparent;
			this.buttonCreateCollage.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonCreateCollage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonCreateCollage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCreateCollage.FlatAppearance.BorderSize = 0;
			this.buttonCreateCollage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonCreateCollage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonCreateCollage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateCollage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonCreateCollage.Location = new System.Drawing.Point(286, 15);
			this.buttonCreateCollage.Name = "buttonCreateCollage";
			this.buttonCreateCollage.Size = new System.Drawing.Size(101, 23);
			this.buttonCreateCollage.TabIndex = 59;
			this.buttonCreateCollage.Text = "Create Collage";
			this.buttonCreateCollage.UseVisualStyleBackColor = false;
			// 
			// buttonPosts
			// 
			this.buttonPosts.BackColor = System.Drawing.Color.Transparent;
			this.buttonPosts.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonPosts.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPosts.FlatAppearance.BorderSize = 0;
			this.buttonPosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonPosts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonPosts.Location = new System.Drawing.Point(264, 299);
			this.buttonPosts.Name = "buttonPosts";
			this.buttonPosts.Size = new System.Drawing.Size(96, 23);
			this.buttonPosts.TabIndex = 60;
			this.buttonPosts.Text = "Posts";
			this.buttonPosts.UseVisualStyleBackColor = false;
			this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
			// 
			// buttonLikedPages
			// 
			this.buttonLikedPages.BackColor = System.Drawing.Color.Transparent;
			this.buttonLikedPages.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonLikedPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonLikedPages.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLikedPages.FlatAppearance.BorderSize = 0;
			this.buttonLikedPages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonLikedPages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonLikedPages.Location = new System.Drawing.Point(3, 299);
			this.buttonLikedPages.Name = "buttonLikedPages";
			this.buttonLikedPages.Size = new System.Drawing.Size(96, 23);
			this.buttonLikedPages.TabIndex = 61;
			this.buttonLikedPages.Text = "Liked Pages";
			this.buttonLikedPages.UseVisualStyleBackColor = false;
			this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
			// 
			// buttonFindARide
			// 
			this.buttonFindARide.BackColor = System.Drawing.Color.Transparent;
			this.buttonFindARide.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonFindARide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonFindARide.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonFindARide.FlatAppearance.BorderSize = 0;
			this.buttonFindARide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonFindARide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonFindARide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFindARide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonFindARide.Location = new System.Drawing.Point(393, 15);
			this.buttonFindARide.Name = "buttonFindARide";
			this.buttonFindARide.Size = new System.Drawing.Size(96, 23);
			this.buttonFindARide.TabIndex = 62;
			this.buttonFindARide.Text = "Find A Ride";
			this.buttonFindARide.UseVisualStyleBackColor = false;
			// 
			// controlUserAlbums
			// 
			this.controlUserAlbums.Location = new System.Drawing.Point(264, 46);
			this.controlUserAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.controlUserAlbums.Name = "controlUserAlbums";
			this.controlUserAlbums.Size = new System.Drawing.Size(362, 245);
			this.controlUserAlbums.TabIndex = 63;
			// 
			// controlUserDetails
			// 
			this.controlUserDetails.BackColor = System.Drawing.Color.Transparent;
			this.controlUserDetails.Location = new System.Drawing.Point(26, 29);
			this.controlUserDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.controlUserDetails.Name = "controlUserDetails";
			this.controlUserDetails.Size = new System.Drawing.Size(231, 240);
			this.controlUserDetails.TabIndex = 12;
			// 
			// ControlHomePage
			// 
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.controlUserAlbums);
			this.Controls.Add(this.buttonFindARide);
			this.Controls.Add(this.buttonLikedPages);
			this.Controls.Add(this.buttonPosts);
			this.Controls.Add(this.buttonCreateCollage);
			this.Controls.Add(this.listViewPosts);
			this.Controls.Add(this.listViewLikedPages);
			this.Controls.Add(this.controlUserDetails);
			this.Controls.Add(this.labelFriensList);
			this.Controls.Add(this.dataGridViewFriends);
			this.Name = "ControlHomePage";
			this.Size = new System.Drawing.Size(630, 637);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePosts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label labelFriensList;
		private System.Windows.Forms.DataGridView dataGridViewFriends;
		private System.Windows.Forms.BindingSource bindingSourceFriendsGrid;
		#endregion

		private ControlUserDetails controlUserDetails;
		private System.Windows.Forms.ColumnHeader pageNameColumnHeader;
		private System.Windows.Forms.ColumnHeader likesCountColumnHeader;
		private System.Windows.Forms.ColumnHeader ImageColumnHeader;
		private System.Windows.Forms.ListView listViewLikedPages;
		private System.Windows.Forms.ListView listViewPosts;
		private System.Windows.Forms.ColumnHeader postDateColumn;
		private System.Windows.Forms.BindingSource bindingSourcePosts;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewImageColumn ImageSmall;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.ColumnHeader messagesColumn;
		private System.Windows.Forms.Button buttonCreateCollage;
		private System.Windows.Forms.Button buttonPosts;
		private System.Windows.Forms.Button buttonLikedPages;
		private System.Windows.Forms.Button buttonFindARide;
		private ControlAlbum controlUserAlbums;
	}
}