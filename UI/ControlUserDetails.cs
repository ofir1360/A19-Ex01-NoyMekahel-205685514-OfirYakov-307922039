using System;
using System.Windows.Forms;

namespace UI
{
	public partial class ControlUserDetails : UserControl
	{
		public ControlUserDetails()
		{
			InitializeComponent();
		}

		internal void ShowUserInfo()
		{
			try
			{
				dataManagerBindingSource.DataSource = DataManagerWrapper.DataManager;
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}
	}
}