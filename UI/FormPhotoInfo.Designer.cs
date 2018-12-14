namespace UI
{
	public partial class FormPhotoInfo
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelLikes = new System.Windows.Forms.Label();
			this.listBoxComments = new System.Windows.Forms.ListBox();
			this.pictureBoxLikes = new System.Windows.Forms.PictureBox();
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.pictureBoxComments = new System.Windows.Forms.PictureBox();
			this.labelComments = new System.Windows.Forms.Label();
			this.pictureBoxComments2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments2)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLikes
			// 
			this.labelLikes.AutoSize = true;
			this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.labelLikes.Location = new System.Drawing.Point(68, 371);
			this.labelLikes.Name = "labelLikes";
			this.labelLikes.Size = new System.Drawing.Size(30, 25);
			this.labelLikes.TabIndex = 2;
			this.labelLikes.Text = "...";
			// 
			// listBoxComments
			// 
			this.listBoxComments.FormattingEnabled = true;
			this.listBoxComments.HorizontalScrollbar = true;
			this.listBoxComments.ItemHeight = 20;
			this.listBoxComments.Location = new System.Drawing.Point(24, 460);
			this.listBoxComments.Name = "listBoxComments";
			this.listBoxComments.Size = new System.Drawing.Size(470, 144);
			this.listBoxComments.TabIndex = 4;
			// 
			// pictureBoxLikes
			// 
			this.pictureBoxLikes.Image = global::UI.Properties.Resources.like_picture;
			this.pictureBoxLikes.InitialImage = null;
			this.pictureBoxLikes.Location = new System.Drawing.Point(24, 368);
			this.pictureBoxLikes.Name = "pictureBoxLikes";
			this.pictureBoxLikes.Size = new System.Drawing.Size(38, 29);
			this.pictureBoxLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLikes.TabIndex = 3;
			this.pictureBoxLikes.TabStop = false;
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.Location = new System.Drawing.Point(24, 25);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(471, 343);
			this.pictureBoxPhoto.TabIndex = 1;
			this.pictureBoxPhoto.TabStop = false;
			// 
			// pictureBoxComments
			// 
			this.pictureBoxComments.Image = global::UI.Properties.Resources.comments_picture;
			this.pictureBoxComments.InitialImage = null;
			this.pictureBoxComments.Location = new System.Drawing.Point(24, 414);
			this.pictureBoxComments.Name = "pictureBoxComments";
			this.pictureBoxComments.Size = new System.Drawing.Size(46, 40);
			this.pictureBoxComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxComments.TabIndex = 5;
			this.pictureBoxComments.TabStop = false;
			// 
			// labelComments
			// 
			this.labelComments.AutoSize = true;
			this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.labelComments.Location = new System.Drawing.Point(76, 429);
			this.labelComments.Name = "labelComments";
			this.labelComments.Size = new System.Drawing.Size(122, 25);
			this.labelComments.TabIndex = 6;
			this.labelComments.Text = "Comments:";
			// 
			// pictureBoxComments2
			// 
			this.pictureBoxComments2.Image = global::UI.Properties.Resources.comments_picture;
			this.pictureBoxComments2.InitialImage = null;
			this.pictureBoxComments2.Location = new System.Drawing.Point(209, 414);
			this.pictureBoxComments2.Name = "pictureBoxComments2";
			this.pictureBoxComments2.Size = new System.Drawing.Size(46, 40);
			this.pictureBoxComments2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxComments2.TabIndex = 7;
			this.pictureBoxComments2.TabStop = false;
			// 
			// FormPhotoInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 625);
			this.Controls.Add(this.pictureBoxComments2);
			this.Controls.Add(this.labelComments);
			this.Controls.Add(this.pictureBoxComments);
			this.Controls.Add(this.listBoxComments);
			this.Controls.Add(this.pictureBoxLikes);
			this.Controls.Add(this.labelLikes);
			this.Controls.Add(this.pictureBoxPhoto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPhotoInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PhotoInfo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPhoto;
		private System.Windows.Forms.Label labelLikes;
		private System.Windows.Forms.PictureBox pictureBoxLikes;
		private System.Windows.Forms.ListBox listBoxComments;
		private System.Windows.Forms.PictureBox pictureBoxComments;
		private System.Windows.Forms.Label labelComments;
		private System.Windows.Forms.PictureBox pictureBoxComments2;
	}
}