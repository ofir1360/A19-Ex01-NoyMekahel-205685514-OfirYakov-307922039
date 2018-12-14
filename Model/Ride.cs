using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class Ride
	{
		private List<IFilter> m_FilterList;

		public ICollection<User> FriendsFromStartPoint { get; internal set; }

		public ICollection<User> FriendsFromStartPointToEndPoint { get; private set; }

		public ICollection<User> GetFriendsFromWork(string i_WorkName)
		{
			List<User> friendsFromWork = new List<User>();

			foreach (User user in FriendsFromStartPoint)
			{
				for (int workIndex = 0; workIndex < user.WorkExperiences.Length; ++workIndex)
				{
					if (user.WorkExperiences[workIndex].Name.Equals(i_WorkName))
					{
						friendsFromWork.Add(user);
					}
				}
			}

			FriendsFromStartPointToEndPoint = friendsFromWork;
			return friendsFromWork;
		}

		public ICollection<User> GetFriendsFromAcademicInstitution(string i_AcademicInstitutionName)
		{
			List<User> friendsFromAcademicInstitution = new List<User>();

			foreach (User user in FriendsFromStartPoint)
			{
				for (int academicInstitutionIndex = 0; academicInstitutionIndex < user.Educations.Length; ++academicInstitutionIndex)
				{
					if (user.Educations[academicInstitutionIndex].School.Name.Equals(i_AcademicInstitutionName))
					{
						friendsFromAcademicInstitution.Add(user);
					}
				}
			}

			FriendsFromStartPointToEndPoint = friendsFromAcademicInstitution;

			return friendsFromAcademicInstitution;
		}

		public ICollection<User> GetFriendsFromChosenEvent(string i_EventName)
		{
			List<User> friendsFromChosenEvent = new List<User>();

			foreach (User user in FriendsFromStartPoint)
			{
				for (int eventIndex = 0; eventIndex < user.Events.Count; ++eventIndex)
				{
					if (user.Events[eventIndex].Name.Equals(i_EventName))
					{
						friendsFromChosenEvent.Add(user);
					}
				}
			}

			FriendsFromStartPointToEndPoint = friendsFromChosenEvent;

			return friendsFromChosenEvent;
		}

		public void AddFilter(IFilter i_Filter)
		{
			if (m_FilterList == null)
			{
				m_FilterList = new List<IFilter>();
			}

			m_FilterList.Add(i_Filter);
		}

		public ICollection<User> Filter()
		{
			ICollection<User> friendsBeforeFilter = FriendsFromStartPointToEndPoint;
			ICollection<User> friendsAfterFilter = friendsBeforeFilter;

			foreach (IFilter filter in m_FilterList)
			{
				friendsAfterFilter = filter.filter(friendsBeforeFilter);
				friendsBeforeFilter = friendsAfterFilter;
			}

			return friendsAfterFilter;
		}
	}
}
