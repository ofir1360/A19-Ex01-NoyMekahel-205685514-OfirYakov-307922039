using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class ControlRidePage : UserControl, ILogoutable, IBackable
	{
		private string m_RideFromLocationName;

		public ControlRidePage()
		{
			InitializeComponent();
			createLocationsList();
		}

		private void createLocationsList()
		{
			try
			{
				ICollection<string> locationsCollection = DataManagerWrapper.DataManager.GetSortedFriendsLocation();

				foreach (string currentLocation in locationsCollection)
				{
					listBoxLocations.Items.Add(currentLocation);
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch your friends location data.");
			}
		}

		private void listBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ListBox).SelectedItem != null)
			{
				m_RideFromLocationName = (sender as ListBox).SelectedItem.ToString();

				try
				{
					handlePageAfterStartPointSelected();
					DataManagerWrapper.DataManager.InitializeRide(m_RideFromLocationName);
					FormMap map = new FormMap();
					map.ShowLocationOnMap(m_RideFromLocationName);
					map.ShowDialog();
				}
				catch (Exception ex)
				{
					FormFacebookApp.ShowFacebookError(ex.Message);
				}
			}
		}

		private void buttonEvent_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManagerWrapper.DataManager.GetEvents().Count > 0)
				{
					ICollection<string> allEventsNames = DataManagerWrapper.DataManager.GetEventsNames();

					foreach (string currEventName in allEventsNames)
					{
						comboBoxEvents.Items.Add(currEventName);
					}

					comboBoxEvents.Enabled = true;
				}
				else
				{
					FormFacebookApp.ShowFacebookError("There are no events you go to.");
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch your events data.");
			}
		}

		private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.GetFriendsFromChosenEvent((sender as ComboBox).SelectedItem.ToString());
				controlFilter.FillFriendsResultOnDataTable(allFriendsFromStartPoint);
				controlFilter.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		private void buttonWork_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManagerWrapper.DataManager.GetWorkExperiences() != null)
				{
					ICollection<string> allWorkPlacesNames = DataManagerWrapper.DataManager.GetWorkPlacesNames();

					foreach (string currWorkPlaceName in allWorkPlacesNames)
					{
						comboBoxWork.Items.Add(currWorkPlaceName);
					}

					comboBoxWork.Enabled = true;
				}
				else
				{
					FormFacebookApp.ShowFacebookError("There are no places where you work.");
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch your work experiences data.");
			}
		}

		private void comboBoxWork_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.GetFriendsFromWork((sender as ComboBox).SelectedItem.ToString());
				controlFilter.FillFriendsResultOnDataTable(allFriendsFromStartPoint);
				controlFilter.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		private void buttonAcademicInstitution_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManagerWrapper.DataManager.GetEducations() != null)
				{
					ICollection<string> allAcademicInstitutionsNames = DataManagerWrapper.DataManager.GetAcademicInstitutionsNames();

					foreach (string currAcademicInstitution in allAcademicInstitutionsNames)
					{
						comboBoxAcademic.Items.Add(currAcademicInstitution);
					}

					comboBoxAcademic.Enabled = true;
				}
				else
				{
					FormFacebookApp.ShowFacebookError("There are no academic institutions where you study.");
				}
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError("Couldn't fetch your academic institutions data.");
			}
		}

		private void comboBoxAcademic_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ICollection<User> allFriendsFromStartPoint = DataManagerWrapper.DataManager.Ride.GetFriendsFromAcademicInstitution((sender as ComboBox).SelectedItem.ToString());
				controlFilter.FillFriendsResultOnDataTable(allFriendsFromStartPoint);
				controlFilter.Visible = true;
			}
			catch (Exception)
			{
				FormFacebookApp.ShowFacebookError();
			}
		}

		private void handlePageAfterStartPointSelected()
		{
			buttonAcademicInstitution.Enabled = true;
			buttonEvent.Enabled = true;
			buttonWork.Enabled = true;
		}

		public void AddLogoutButton(Button i_buttonLogout)
		{
			Controls.Add(i_buttonLogout);
		}

		public void AddBackButton(Button i_buttonBack)
		{
			Controls.Add(i_buttonBack);
		}
	}
}