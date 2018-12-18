namespace UI
{
	public partial class ControlCollagePage
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
			this.groupBoxPhotosChooser = new System.Windows.Forms.GroupBox();
			this.radioButtonAlbumsPhotos = new System.Windows.Forms.RadioButton();
			this.radioButtonSharedPhotos = new System.Windows.Forms.RadioButton();
			this.radioButtonAllPhotos = new System.Windows.Forms.RadioButton();
			this.checkedListBoxFilter = new System.Windows.Forms.CheckedListBox();
			this.checkedListBoxPhotos = new System.Windows.Forms.CheckedListBox();
			this.buttonSelectPhotos = new System.Windows.Forms.Button();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.buttonSeeCollage = new System.Windows.Forms.Button();
			this.buttonCollageFrame = new System.Windows.Forms.Button();
			this.groupBoxPhotosChooser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxPhotosChooser
			// 
			this.groupBoxPhotosChooser.Controls.Add(this.radioButtonAlbumsPhotos);
			this.groupBoxPhotosChooser.Controls.Add(this.radioButtonSharedPhotos);
			this.groupBoxPhotosChooser.Controls.Add(this.radioButtonAllPhotos);
			this.groupBoxPhotosChooser.Enabled = false;
			this.groupBoxPhotosChooser.Location = new System.Drawing.Point(27, 65);
			this.groupBoxPhotosChooser.Name = "groupBoxPhotosChooser";
			this.groupBoxPhotosChooser.Size = new System.Drawing.Size(123, 100);
			this.groupBoxPhotosChooser.TabIndex = 0;
			this.groupBoxPhotosChooser.TabStop = false;
			this.groupBoxPhotosChooser.Text = "Choose An Option:";
			// 
			// radioButtonAlbumsPhotos
			// 
			this.radioButtonAlbumsPhotos.AutoSize = true;
			this.radioButtonAlbumsPhotos.Location = new System.Drawing.Point(7, 75);
			this.radioButtonAlbumsPhotos.Name = "radioButtonAlbumsPhotos";
			this.radioButtonAlbumsPhotos.Size = new System.Drawing.Size(97, 17);
			this.radioButtonAlbumsPhotos.TabIndex = 2;
			this.radioButtonAlbumsPhotos.Text = "Album\'s Photos";
			this.radioButtonAlbumsPhotos.UseVisualStyleBackColor = true;
			this.radioButtonAlbumsPhotos.CheckedChanged += new System.EventHandler(this.radioButtonAlbumsPhotos_CheckedChanged);
			// 
			// radioButtonSharedPhotos
			// 
			this.radioButtonSharedPhotos.AutoSize = true;
			this.radioButtonSharedPhotos.Location = new System.Drawing.Point(7, 52);
			this.radioButtonSharedPhotos.Name = "radioButtonSharedPhotos";
			this.radioButtonSharedPhotos.Size = new System.Drawing.Size(95, 17);
			this.radioButtonSharedPhotos.TabIndex = 1;
			this.radioButtonSharedPhotos.Text = "Shared Photos";
			this.radioButtonSharedPhotos.UseVisualStyleBackColor = true;
			this.radioButtonSharedPhotos.CheckedChanged += new System.EventHandler(this.radioButtonSharedPhotos_CheckedChanged);
			// 
			// radioButtonAllPhotos
			// 
			this.radioButtonAllPhotos.AutoSize = true;
			this.radioButtonAllPhotos.Checked = true;
			this.radioButtonAllPhotos.Location = new System.Drawing.Point(7, 29);
			this.radioButtonAllPhotos.Name = "radioButtonAllPhotos";
			this.radioButtonAllPhotos.Size = new System.Drawing.Size(72, 17);
			this.radioButtonAllPhotos.TabIndex = 0;
			this.radioButtonAllPhotos.TabStop = true;
			this.radioButtonAllPhotos.Text = "All Photos";
			this.radioButtonAllPhotos.UseVisualStyleBackColor = true;
			this.radioButtonAllPhotos.CheckedChanged += new System.EventHandler(this.radioButtonAllPhotos_CheckedChanged);
			// 
			// checkedListBoxFilter
			// 
			this.checkedListBoxFilter.FormattingEnabled = true;
			this.checkedListBoxFilter.HorizontalScrollbar = true;
			this.checkedListBoxFilter.Location = new System.Drawing.Point(175, 67);
			this.checkedListBoxFilter.Name = "checkedListBoxFilter";
			this.checkedListBoxFilter.Size = new System.Drawing.Size(143, 94);
			this.checkedListBoxFilter.TabIndex = 1;
			this.checkedListBoxFilter.Visible = false;
			this.checkedListBoxFilter.Click += new System.EventHandler(this.checkedListBox_Click);
			this.checkedListBoxFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			// 
			// checkedListBoxPhotos
			// 
			this.checkedListBoxPhotos.FormattingEnabled = true;
			this.checkedListBoxPhotos.HorizontalScrollbar = true;
			this.checkedListBoxPhotos.Location = new System.Drawing.Point(16, 183);
			this.checkedListBoxPhotos.Name = "checkedListBoxPhotos";
			this.checkedListBoxPhotos.Size = new System.Drawing.Size(147, 349);
			this.checkedListBoxPhotos.TabIndex = 4;
			this.checkedListBoxPhotos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.photosCheckedListBox_ItemCheck);
			this.checkedListBoxPhotos.Click += new System.EventHandler(this.checkedListBox_Click);
			this.checkedListBoxPhotos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseClick);
			this.checkedListBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosChecked_SelectedIndexChanged);
			// 
			// buttonSelectPhotos
			// 
			this.buttonSelectPhotos.BackColor = System.Drawing.Color.Transparent;
			this.buttonSelectPhotos.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonSelectPhotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSelectPhotos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSelectPhotos.Enabled = false;
			this.buttonSelectPhotos.FlatAppearance.BorderSize = 0;
			this.buttonSelectPhotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSelectPhotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSelectPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelectPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSelectPhotos.Location = new System.Drawing.Point(340, 142);
			this.buttonSelectPhotos.Name = "buttonSelectPhotos";
			this.buttonSelectPhotos.Size = new System.Drawing.Size(145, 23);
			this.buttonSelectPhotos.TabIndex = 57;
			this.buttonSelectPhotos.Text = "Select Photos";
			this.buttonSelectPhotos.UseVisualStyleBackColor = false;
			this.buttonSelectPhotos.Click += new System.EventHandler(this.buttonSelectPhotos_Click);
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Location = new System.Drawing.Point(188, 183);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(404, 357);
			this.pictureBoxImage.TabIndex = 7;
			this.pictureBoxImage.TabStop = false;
			this.pictureBoxImage.Visible = false;
			// 
			// buttonSeeCollage
			// 
			this.buttonSeeCollage.BackColor = System.Drawing.Color.Transparent;
			this.buttonSeeCollage.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonSeeCollage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSeeCollage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSeeCollage.Enabled = false;
			this.buttonSeeCollage.FlatAppearance.BorderSize = 0;
			this.buttonSeeCollage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSeeCollage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSeeCollage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSeeCollage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSeeCollage.Location = new System.Drawing.Point(484, 557);
			this.buttonSeeCollage.Name = "buttonSeeCollage";
			this.buttonSeeCollage.Size = new System.Drawing.Size(108, 23);
			this.buttonSeeCollage.TabIndex = 58;
			this.buttonSeeCollage.Text = "See Collage";
			this.buttonSeeCollage.UseVisualStyleBackColor = false;
			this.buttonSeeCollage.Click += new System.EventHandler(this.buttonSeeCollage_Click);
			// 
			// buttonCollageFrame
			// 
			this.buttonCollageFrame.BackColor = System.Drawing.Color.Transparent;
			this.buttonCollageFrame.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonCollageFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonCollageFrame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCollageFrame.FlatAppearance.BorderSize = 0;
			this.buttonCollageFrame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonCollageFrame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonCollageFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCollageFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonCollageFrame.Location = new System.Drawing.Point(16, 25);
			this.buttonCollageFrame.Name = "buttonCollageFrame";
			this.buttonCollageFrame.Size = new System.Drawing.Size(145, 23);
			this.buttonCollageFrame.TabIndex = 61;
			this.buttonCollageFrame.Text = "Choose Collage Frame";
			this.buttonCollageFrame.UseVisualStyleBackColor = false;
			this.buttonCollageFrame.Click += new System.EventHandler(this.buttonCollageFrame_Click);
			// 
			// ControlCollagePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.buttonCollageFrame);
			this.Controls.Add(this.buttonSeeCollage);
			this.Controls.Add(this.buttonSelectPhotos);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.checkedListBoxPhotos);
			this.Controls.Add(this.checkedListBoxFilter);
			this.Controls.Add(this.groupBoxPhotosChooser);
			this.Name = "ControlCollagePage";
			this.Size = new System.Drawing.Size(662, 628);
			this.groupBoxPhotosChooser.ResumeLayout(false);
			this.groupBoxPhotosChooser.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxPhotosChooser;
		private System.Windows.Forms.RadioButton radioButtonAlbumsPhotos;
		private System.Windows.Forms.RadioButton radioButtonSharedPhotos;
		private System.Windows.Forms.RadioButton radioButtonAllPhotos;
		private System.Windows.Forms.CheckedListBox checkedListBoxFilter;
		private System.Windows.Forms.CheckedListBox checkedListBoxPhotos;
		private System.Windows.Forms.Button buttonSelectPhotos;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Button buttonSeeCollage;
		private System.Windows.Forms.Button buttonCollageFrame;
	}
}