using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class ControlFilter : UserControl
	{
		public ControlFilter()
		{
			InitializeComponent();
		}

		private void checkBoxGender_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxGender.Checked)
			{
				groupBoxGender.Visible = true;
				buttonFilter.Enabled = true;
			}
			else
			{
				groupBoxGender.Visible = false;
				if (checkBoxAge.Checked == false)
				{
					buttonFilter.Enabled = false;
				}
			}
		}

		private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAge.Checked)
			{
				groupBoxAge.Visible = true;
				buttonFilter.Enabled = true;
			}
			else
			{
				groupBoxAge.Visible = false;

				if (checkBoxGender.Checked == false)
				{
					buttonFilter.Enabled = false;
				}
			}
		}

		private void buttonFilter_Click(object sender, EventArgs e)
		{
			if (checkBoxGender.Checked)
			{
				RadioButton genderPreferenceRadioButton = groupBoxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(FilterFactory.GetFilter(FilterFactory.eFilter.GENDER, genderPreferenceRadioButton.Text));
			}

			if (checkBoxAge.Checked)
			{
				RadioButton agePreferenceRadioButton = groupBoxAge.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
				DataManagerWrapper.DataManager.Ride.AddFilter(FilterFactory.GetFilter(FilterFactory.eFilter.AGE, agePreferenceRadioButton.Text));
			}

			try
			{
				ICollection<User> friendsAfterFilter = DataManagerWrapper.DataManager.Ride.Filter();
				FillFriendsResultOnDataTable(friendsAfterFilter);
			}
			catch (Exception ex)
			{
				FormFacebookApp.ShowFacebookError(ex.Message);
			}
		}

		internal void FillFriendsResultOnDataTable(ICollection<User> i_AllFriendsFromStartPoint)
		{
			dataGridFriendsResult.Controls.Clear();
			bindingSourceRideFriendsGrid.DataSource = i_AllFriendsFromStartPoint;
			int counter = 0;

			foreach (User currentUser in i_AllFriendsFromStartPoint)
			{
				DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell()
				{
					Value = AgeFilter.GetAgeFromUserBirthday(currentUser.Birthday)
				};
				dataGridFriendsResult.Rows[counter].Cells[AgeColumn.Index] = cell;
				counter++;
			}
		}
	}
}