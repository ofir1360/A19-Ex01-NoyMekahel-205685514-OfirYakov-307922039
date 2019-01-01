using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class ControlRidePage : UserControl, ILogoutable, IBackable
	{
		private string m_RideFromLocationName;

		public ControlRidePage()
		{
			InitializeComponent();
		}

		internal void CreateLocationsList()
		{
			try
			{
				ICollection<string> locationsCollection = DataManagerWrapper.DataManager.SortedFriendsLocations;

				foreach (string currentLocation in locationsCollection)
				{
					listBoxLocations.Invoke(new Action(() => listBoxLocations.Items.Add(currentLocation)));
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

				handlePageAfterStartPointSelected();
				new Thread(initializeRide).Start();
				FormMap map = new FormMap();
				map.ShowLocationOnMap(m_RideFromLocationName);
				map.ShowDialog();
			}
		}

		private void initializeRide()
		{
			try
			{
				DataManagerWrapper.DataManager.InitializeRide(m_RideFromLocationName);
			}
			catch (Exception ex)
			{
				FormFacebookApp.ShowFacebookError(ex.Message);
			}
		}

		private void buttonEvent_Click(object sender, EventArgs e)
		{
			new Thread(fetchEvents).Start();
		}

		private void fetchEvents()
		{
			try
			{
				ICollection<Event> allEvents = DataManagerWrapper.DataManager.Events;

				if (allEvents.Count > 0)
				{
					comboBoxEvents.Invoke(new Action(() => comboBoxEvents.DisplayMember = "Name"));
					foreach (Event currentEvent in allEvents)
					{
						comboBoxEvents.Invoke(new Action(() => comboBoxEvents.Items.Add(currentEvent)));
					}

					comboBoxEvents.Invoke(new Action(() => comboBoxEvents.Enabled = true));
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
			new Thread(fetchWorkPlaces).Start();
		}

		private void fetchWorkPlaces()
		{
			try
			{
				ICollection<WorkExperience> allWorkPlaces = DataManagerWrapper.DataManager.WorkPlaces;

				if (allWorkPlaces.Count > 0)
				{
					comboBoxWork.Invoke(new Action(() => comboBoxWork.DisplayMember = "Name"));
					foreach (WorkExperience currWorkPlace in allWorkPlaces)
					{
						comboBoxWork.Invoke(new Action(() => comboBoxWork.Items.Add(currWorkPlace)));
					}

					comboBoxWork.Invoke(new Action(() => comboBoxWork.Enabled = true));
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
			new Thread(fetchEducations).Start();
		}

		private void fetchEducations()
		{
			try
			{
				Education[] education = DataManagerWrapper.DataManager.Educations;
				if (education != null)
				{
					comboBoxAcademic.Invoke(new Action(() => comboBoxAcademic.DisplayMember = "School.Name"));
					foreach (Education currAcademicInstitution in education)
					{
						comboBoxAcademic.Invoke(new Action(() => comboBoxAcademic.Items.Add(currAcademicInstitution)));
					}

					comboBoxAcademic.Invoke(new Action(() => comboBoxAcademic.Enabled = true));
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