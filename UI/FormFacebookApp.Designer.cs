using System;

namespace UI
{
	public partial class FormFacebookApp
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
			this.buttonLogout = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonLogout
			// 
			this.buttonLogout.BackgroundImage = global::UI.Properties.Resources.logout_button;
			this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLogout.FlatAppearance.BorderSize = 0;
			this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogout.Location = new System.Drawing.Point(510, 15);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(78, 23);
			this.buttonLogout.TabIndex = 7;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.BackgroundImage = global::UI.Properties.Resources.back_button2;
			this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBack.FlatAppearance.BorderSize = 0;
			this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Location = new System.Drawing.Point(13, 595);
			this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 22);
			this.buttonBack.TabIndex = 30;
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.Color.Transparent;
			this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMain.Controls.Add(this.buttonLogin);
			this.panelMain.Controls.Add(this.checkBoxRememberUser);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(632, 630);
			this.panelMain.TabIndex = 0;
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.MediumBlue;
			this.buttonLogin.Enabled = false;
			this.buttonLogin.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
			this.buttonLogin.ForeColor = System.Drawing.Color.White;
			this.buttonLogin.Location = new System.Drawing.Point(247, 382);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(145, 45);
			this.buttonLogin.TabIndex = 8;
			this.buttonLogin.Text = "Connecting...";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// checkBoxRememberUser
			// 
			this.checkBoxRememberUser.AutoSize = true;
			this.checkBoxRememberUser.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
			this.checkBoxRememberUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.checkBoxRememberUser.Location = new System.Drawing.Point(272, 432);
			this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxRememberUser.Name = "checkBoxRememberUser";
			this.checkBoxRememberUser.Size = new System.Drawing.Size(97, 19);
			this.checkBoxRememberUser.TabIndex = 23;
			this.checkBoxRememberUser.Text = "Remember Me";
			this.checkBoxRememberUser.UseVisualStyleBackColor = true;
			this.checkBoxRememberUser.Visible = false;
			// 
			// FormFacebookApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImage = global::UI.Properties.Resources.faccebook_background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(632, 630);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormFacebookApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FacebookApp";
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.CheckBox checkBoxRememberUser;
	}
}