using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;
using System.Threading;

namespace UI
{
	public partial class FormFacebookApp : Form
	{
		private ControlHomePage		controlHomePage;
		private ControlRidePage		controlRidePage;
		private ControlCollagePage	controlCollagePage;
		private AppSettings			m_AppSettings;

		public FormFacebookApp()
		{
			InitializeComponent();
			controlHomePage = new ControlHomePage();
		}

		protected override void OnShown(EventArgs e)
		{
			try
			{
				m_AppSettings = AppSettings.Instance;
				if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
				{
					new Thread(AutomaticConnection).Start();
				}
				else
				{
					initManualLoginOption();
				}
			}
			catch (Exception)
			{
			}
			base.OnShown(e);
		}

		private void AutomaticConnection()
		{
			initializeUserPreferences();
			DataManagerWrapper.SetDataManager(this, FacebookConnection.Connect(m_AppSettings.LastAccessToken));
			showHomePage();
		}

		private void manualConnection()
		{
			DataManagerWrapper.SetDataManager(this, FacebookConnection.Login());
			showHomePage();
		}

		private void initializeUserPreferences()
		{
			this.Invoke(new Action(()=> Location = m_AppSettings.Location));
			checkBoxRememberUser.Invoke(new Action(() => checkBoxRememberUser.Checked = m_AppSettings.RememberUser));
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			try
			{
				//new Thread(manualConnection).Start();
				manualConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			m_AppSettings.Location = this.Location;
			m_AppSettings.RememberUser = checkBoxRememberUser.Checked ? true : false;
			try
			{
				m_AppSettings.SaveToFile();
			}
			catch (Exception)
			{
			}

			base.OnClosing(e);
		}

		private void showHomePage()
		{
			this.Invoke(new Action(() => invokeHomePage()));
		}

		private void invokeHomePage()
		{
			BackgroundImage = global::UI.Properties.Resources.facebook_widescreen_navy_background_image;
			panelMain.Controls.Clear();
			panelMain.Controls.Add(this.controlHomePage);
			controlHomePage.AddLogoutButton(buttonLogout);
			controlHomePage.ButtonFindARide_AddClickedListener(new EventHandler(buttonFindARide_Click));
			controlHomePage.ButtonCreateCollage_AddClickedListener(new EventHandler(buttonCreateCollage_Click));
			controlHomePage.FetchUserInfo();
		}

		private void buttonCreateCollage_Click(object sender, EventArgs e)
		{
			controlCollagePage = new ControlCollagePage();

			controlCollagePage.AddLogoutButton(buttonLogout);
			controlCollagePage.AddBackButton(buttonBack);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(controlCollagePage);
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			this.BackgroundImage = global::UI.Properties.Resources.faccebook_background;
			//new Thread(FacebookConnection.Logout).Start();
			FacebookConnection.Logout();
			panelMain.Controls.Clear();
			panelMain.Controls.Add(buttonLogin);
			checkBoxRememberUser.Checked = false;
			panelMain.Controls.Add(checkBoxRememberUser);
			initManualLoginOption();
		}

		private void initManualLoginOption()
		{
			checkBoxRememberUser.Visible = true;
			buttonLogin.Enabled = true;
			buttonLogin.Text = "Login";
		}

		private void buttonFindARide_Click(object sender, EventArgs e)
		{
			controlRidePage = new ControlRidePage();

			controlRidePage.AddLogoutButton(buttonLogout);
			controlRidePage.AddBackButton(buttonBack);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(controlRidePage);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			controlHomePage.AddLogoutButton(buttonLogout);
			panelMain.Controls.Clear();
			controlHomePage.ShowUserFriends();
			panelMain.Controls.Add(controlHomePage);
		}

		internal static void ShowFacebookError(string i_ErrorMessage = "An error has occured. Couldn't retrieve the requested information from facebook")
		{
		    MessageBox.Show(i_ErrorMessage);
		}
	}
}
