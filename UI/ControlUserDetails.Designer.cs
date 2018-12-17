namespace UI
{
	public partial class ControlUserDetails
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
			System.Windows.Forms.Label getLastNameLabel;
			System.Windows.Forms.Label getFirstNameLabel;
			System.Windows.Forms.Label getEmailLabel;
			System.Windows.Forms.Label getDaysTillBirthdayLabel;
			System.Windows.Forms.Label getBirthdayLabel;
			this.getBirthdayLabel1 = new System.Windows.Forms.Label();
			this.getDaysTillBirthdayLabel1 = new System.Windows.Forms.Label();
			this.getEmailLabel1 = new System.Windows.Forms.Label();
			this.getFirstNameLabel1 = new System.Windows.Forms.Label();
			this.getLastNameLabel1 = new System.Windows.Forms.Label();
			this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
			this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
			this.dataManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			getLastNameLabel = new System.Windows.Forms.Label();
			getFirstNameLabel = new System.Windows.Forms.Label();
			getEmailLabel = new System.Windows.Forms.Label();
			getDaysTillBirthdayLabel = new System.Windows.Forms.Label();
			getBirthdayLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// getBirthdayLabel1
			// 
			this.getBirthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "GetBirthday", true));
			this.getBirthdayLabel1.Location = new System.Drawing.Point(131, 198);
			this.getBirthdayLabel1.Name = "getBirthdayLabel1";
			this.getBirthdayLabel1.Size = new System.Drawing.Size(91, 23);
			this.getBirthdayLabel1.TabIndex = 36;
			this.getBirthdayLabel1.Text = "label1";
			// 
			// getDaysTillBirthdayLabel1
			// 
			this.getDaysTillBirthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "GetDaysTillBirthday", true));
			this.getDaysTillBirthdayLabel1.Location = new System.Drawing.Point(131, 221);
			this.getDaysTillBirthdayLabel1.Name = "getDaysTillBirthdayLabel1";
			this.getDaysTillBirthdayLabel1.Size = new System.Drawing.Size(91, 23);
			this.getDaysTillBirthdayLabel1.TabIndex = 38;
			this.getDaysTillBirthdayLabel1.Text = "label1";
			// 
			// getEmailLabel1
			// 
			this.getEmailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "GetEmail", true));
			this.getEmailLabel1.Location = new System.Drawing.Point(131, 174);
			this.getEmailLabel1.Name = "getEmailLabel1";
			this.getEmailLabel1.Size = new System.Drawing.Size(91, 23);
			this.getEmailLabel1.TabIndex = 40;
			this.getEmailLabel1.Text = "label1";
			// 
			// getFirstNameLabel1
			// 
			this.getFirstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "GetFirstName", true));
			this.getFirstNameLabel1.Location = new System.Drawing.Point(131, 129);
			this.getFirstNameLabel1.Name = "getFirstNameLabel1";
			this.getFirstNameLabel1.Size = new System.Drawing.Size(91, 23);
			this.getFirstNameLabel1.TabIndex = 42;
			this.getFirstNameLabel1.Text = "label1";
			// 
			// getLastNameLabel1
			// 
			this.getLastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "GetLastName", true));
			this.getLastNameLabel1.Location = new System.Drawing.Point(131, 151);
			this.getLastNameLabel1.Name = "getLastNameLabel1";
			this.getLastNameLabel1.Size = new System.Drawing.Size(91, 21);
			this.getLastNameLabel1.TabIndex = 46;
			this.getLastNameLabel1.Text = "label1";
			// 
			// pictureBoxUserProfile
			// 
			this.pictureBoxUserProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dataManagerBindingSource, "GetImageNormal", true));
			this.pictureBoxUserProfile.Location = new System.Drawing.Point(26, 22);
			this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
			this.pictureBoxUserProfile.Size = new System.Drawing.Size(81, 88);
			this.pictureBoxUserProfile.TabIndex = 44;
			this.pictureBoxUserProfile.TabStop = false;
			// 
			// pictureBoxFrame
			// 
			this.pictureBoxFrame.BackgroundImage = global::UI.Properties.Resources.glitter_frame;
			this.pictureBoxFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxFrame.Location = new System.Drawing.Point(17, 15);
			this.pictureBoxFrame.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxFrame.Name = "pictureBoxFrame";
			this.pictureBoxFrame.Size = new System.Drawing.Size(100, 103);
			this.pictureBoxFrame.TabIndex = 33;
			this.pictureBoxFrame.TabStop = false;
			// 
			// getLastNameLabel
			// 
			getLastNameLabel.AutoSize = true;
			getLastNameLabel.Location = new System.Drawing.Point(14, 151);
			getLastNameLabel.Name = "getLastNameLabel";
			getLastNameLabel.Size = new System.Drawing.Size(61, 13);
			getLastNameLabel.TabIndex = 45;
			getLastNameLabel.Text = "Last Name:";
			// 
			// getFirstNameLabel
			// 
			getFirstNameLabel.AutoSize = true;
			getFirstNameLabel.Location = new System.Drawing.Point(14, 129);
			getFirstNameLabel.Name = "getFirstNameLabel";
			getFirstNameLabel.Size = new System.Drawing.Size(60, 13);
			getFirstNameLabel.TabIndex = 41;
			getFirstNameLabel.Text = "First Name:";
			// 
			// getEmailLabel
			// 
			getEmailLabel.AutoSize = true;
			getEmailLabel.Location = new System.Drawing.Point(14, 174);
			getEmailLabel.Name = "getEmailLabel";
			getEmailLabel.Size = new System.Drawing.Size(35, 13);
			getEmailLabel.TabIndex = 39;
			getEmailLabel.Text = "Email:";
			// 
			// getDaysTillBirthdayLabel
			// 
			getDaysTillBirthdayLabel.AutoSize = true;
			getDaysTillBirthdayLabel.Location = new System.Drawing.Point(14, 221);
			getDaysTillBirthdayLabel.Name = "getDaysTillBirthdayLabel";
			getDaysTillBirthdayLabel.Size = new System.Drawing.Size(91, 13);
			getDaysTillBirthdayLabel.TabIndex = 37;
			getDaysTillBirthdayLabel.Text = "Days Till Birthday:";
			// 
			// getBirthdayLabel
			// 
			getBirthdayLabel.AutoSize = true;
			getBirthdayLabel.Location = new System.Drawing.Point(14, 198);
			getBirthdayLabel.Name = "getBirthdayLabel";
			getBirthdayLabel.Size = new System.Drawing.Size(48, 13);
			getBirthdayLabel.TabIndex = 35;
			getBirthdayLabel.Text = "Birthday:";
			// 
			// dataManagerBindingSource
			// 
			this.dataManagerBindingSource.DataSource = typeof(Model.DataManager);
			// 
			// ControlUserDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(getBirthdayLabel);
			this.Controls.Add(this.getBirthdayLabel1);
			this.Controls.Add(getDaysTillBirthdayLabel);
			this.Controls.Add(this.getDaysTillBirthdayLabel1);
			this.Controls.Add(getEmailLabel);
			this.Controls.Add(this.getEmailLabel1);
			this.Controls.Add(getFirstNameLabel);
			this.Controls.Add(this.getFirstNameLabel1);
			this.Controls.Add(this.pictureBoxUserProfile);
			this.Controls.Add(getLastNameLabel);
			this.Controls.Add(this.getLastNameLabel1);
			this.Controls.Add(this.pictureBoxFrame);
			this.Name = "ControlUserDetails";
			this.Size = new System.Drawing.Size(225, 240);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBoxFrame;
		private System.Windows.Forms.BindingSource dataManagerBindingSource;
		private System.Windows.Forms.Label getBirthdayLabel1;
		private System.Windows.Forms.Label getDaysTillBirthdayLabel1;
		private System.Windows.Forms.Label getEmailLabel1;
		private System.Windows.Forms.Label getFirstNameLabel1;
		private System.Windows.Forms.PictureBox pictureBoxUserProfile;
		private System.Windows.Forms.Label getLastNameLabel1;
	}
}