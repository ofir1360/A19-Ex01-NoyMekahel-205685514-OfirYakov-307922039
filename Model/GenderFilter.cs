using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class GenderFilter : IFilter
	{
		private User.eGender m_GenderType;

		public GenderFilter(string i_GenderType)
		{
			const string k_MaleString = "male";

			m_GenderType = i_GenderType.ToLower().Equals(k_MaleString) ? User.eGender.male : User.eGender.female;
		}

		public ICollection<User> filter(ICollection<User> i_Friends)
		{
			HashSet<User> friendsFromStartPointToEndPoint = new HashSet<User>();

			foreach (User user in i_Friends)
			{
				if (user.Gender == m_GenderType)
				{
					friendsFromStartPointToEndPoint.Add(user);
				}
			}

			return friendsFromStartPointToEndPoint;
		}
	}
}
