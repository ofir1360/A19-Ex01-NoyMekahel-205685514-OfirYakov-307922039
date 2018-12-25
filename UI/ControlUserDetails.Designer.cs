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
			System.Windows.Forms.Label LastNameLabel;
			System.Windows.Forms.Label FirstNameLabel;
			System.Windows.Forms.Label EmailLabel;
			System.Windows.Forms.Label DaysTillBirthdayLabel;
			System.Windows.Forms.Label BirthdayLabel;
			this.BirthdayLabel1 = new System.Windows.Forms.Label();
			this.DaysTillBirthdayLabel1 = new System.Windows.Forms.Label();
			this.EmailLabel1 = new System.Windows.Forms.Label();
			this.FirstNameLabel1 = new System.Windows.Forms.Label();
			this.LastNameLabel1 = new System.Windows.Forms.Label();
			this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
			this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
			this.dataManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			LastNameLabel = new System.Windows.Forms.Label();
			FirstNameLabel = new System.Windows.Forms.Label();
			EmailLabel = new System.Windows.Forms.Label();
			DaysTillBirthdayLabel = new System.Windows.Forms.Label();
			BirthdayLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataManagerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// BirthdayLabel1
			// 
			this.BirthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "Birthday", true));
			this.BirthdayLabel1.Location = new System.Drawing.Point(131, 198);
			this.BirthdayLabel1.Name = "BirthdayLabel1";
			this.BirthdayLabel1.Size = new System.Drawing.Size(91, 23);
			this.BirthdayLabel1.TabIndex = 36;
			this.BirthdayLabel1.Text = "label1";
			// 
			// DaysTillBirthdayLabel1
			// 
			this.DaysTillBirthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "DaysTillBirthday", true));
			this.DaysTillBirthdayLabel1.Location = new System.Drawing.Point(131, 221);
			this.DaysTillBirthdayLabel1.Name = "DaysTillBirthdayLabel1";
			this.DaysTillBirthdayLabel1.Size = new System.Drawing.Size(91, 23);
			this.DaysTillBirthdayLabel1.TabIndex = 38;
			this.DaysTillBirthdayLabel1.Text = "label1";
			// 
			// EmailLabel1
			// 
			this.EmailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "Email", true));
			this.EmailLabel1.Location = new System.Drawing.Point(131, 174);
			this.EmailLabel1.Name = "EmailLabel1";
			this.EmailLabel1.Size = new System.Drawing.Size(91, 23);
			this.EmailLabel1.TabIndex = 40;
			this.EmailLabel1.Text = "label1";
			// 
			// FirstNameLabel1
			// 
			this.FirstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "FirstName", true));
			this.FirstNameLabel1.Location = new System.Drawing.Point(131, 129);
			this.FirstNameLabel1.Name = "FirstNameLabel1";
			this.FirstNameLabel1.Size = new System.Drawing.Size(91, 23);
			this.FirstNameLabel1.TabIndex = 42;
			this.FirstNameLabel1.Text = "label1";
			// 
			// LastNameLabel1
			// 
			this.LastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataManagerBindingSource, "LastName", true));
			this.LastNameLabel1.Location = new System.Drawing.Point(131, 151);
			this.LastNameLabel1.Name = "LastNameLabel1";
			this.LastNameLabel1.Size = new System.Drawing.Size(91, 21);
			this.LastNameLabel1.TabIndex = 46;
			this.LastNameLabel1.Text = "label1";
			// 
			// pictureBoxUserProfile
			// 
			this.pictureBoxUserProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dataManagerBindingSource, "ImageNormal", true));
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
			// LastNameLabel
			// 
			LastNameLabel.AutoSize = true;
			LastNameLabel.Location = new System.Drawing.Point(14, 151);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new System.Drawing.Size(61, 13);
			LastNameLabel.TabIndex = 45;
			LastNameLabel.Text = "Last Name:";
			// 
			// FirstNameLabel
			// 
			FirstNameLabel.AutoSize = true;
			FirstNameLabel.Location = new System.Drawing.Point(14, 129);
			FirstNameLabel.Name = "FirstNameLabel";
			FirstNameLabel.Size = new System.Drawing.Size(60, 13);
			FirstNameLabel.TabIndex = 41;
			FirstNameLabel.Text = "First Name:";
			// 
			// EmailLabel
			// 
			EmailLabel.AutoSize = true;
			EmailLabel.Location = new System.Drawing.Point(14, 174);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new System.Drawing.Size(35, 13);
			EmailLabel.TabIndex = 39;
			EmailLabel.Text = "Email:";
			// 
			// DaysTillBirthdayLabel
			// 
			DaysTillBirthdayLabel.AutoSize = true;
			DaysTillBirthdayLabel.Location = new System.Drawing.Point(14, 221);
			DaysTillBirthdayLabel.Name = "DaysTillBirthdayLabel";
			DaysTillBirthdayLabel.Size = new System.Drawing.Size(91, 13);
			DaysTillBirthdayLabel.TabIndex = 37;
			DaysTillBirthdayLabel.Text = "Days Till Birthday:";
			// 
			// BirthdayLabel
			// 
			BirthdayLabel.AutoSize = true;
			BirthdayLabel.Location = new System.Drawing.Point(14, 198);
			BirthdayLabel.Name = "BirthdayLabel";
			BirthdayLabel.Size = new System.Drawing.Size(48, 13);
			BirthdayLabel.TabIndex = 35;
			BirthdayLabel.Text = "Birthday:";
			// 
			// dataManagerBindingSource
			// 
			this.dataManagerBindingSource.DataSource = typeof(Model.DataManagerFacade);
			// 
			// ControlUserDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(BirthdayLabel);
			this.Controls.Add(this.BirthdayLabel1);
			this.Controls.Add(DaysTillBirthdayLabel);
			this.Controls.Add(this.DaysTillBirthdayLabel1);
			this.Controls.Add(EmailLabel);
			this.Controls.Add(this.EmailLabel1);
			this.Controls.Add(FirstNameLabel);
			this.Controls.Add(this.FirstNameLabel1);
			this.Controls.Add(this.pictureBoxUserProfile);
			this.Controls.Add(LastNameLabel);
			this.Controls.Add(this.LastNameLabel1);
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
		private System.Windows.Forms.Label BirthdayLabel1;
		private System.Windows.Forms.Label DaysTillBirthdayLabel1;
		private System.Windows.Forms.Label EmailLabel1;
		private System.Windows.Forms.Label FirstNameLabel1;
		private System.Windows.Forms.PictureBox pictureBoxUserProfile;
		private System.Windows.Forms.Label LastNameLabel1;
	}
}