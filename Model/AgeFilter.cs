using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class AgeFilter : IFilter
	{
		private int m_MinAge;
		private int m_MaxAge;

		public AgeFilter(string i_Range)
		{
			const int k_MaxPossibleAge = 200;
			const int k_StartOfMinAge = 0;
			const int k_StartOfMaxAge = 3;
			const int k_LengthOfAge = 2;

			m_MinAge = int.Parse(i_Range.Substring(k_StartOfMinAge, k_LengthOfAge));			
			m_MaxAge = i_Range.Contains("-") ? int.Parse(i_Range.Substring(k_StartOfMaxAge, k_LengthOfAge)) : k_MaxPossibleAge;
		}

		public static int? GetAgeFromUserBirthday(string i_Birthday)
		{
			const int	k_StartOfBirthYear = 6;
			const int	k_LengthOfBirthYear = 4;
			int?		age = null;
			int			birthYear;

			if (isDateContainsYear(i_Birthday))
			{
				birthYear = int.Parse(i_Birthday.Substring(k_StartOfBirthYear, k_LengthOfBirthYear));
				age = DateTime.Today.Year - birthYear;
			}

			return age;
		}

		private static bool isDateContainsYear(string i_Birthday)
		{
			const int	k_LengthStringWithBirthYear = 10;
			return		i_Birthday.Length == k_LengthStringWithBirthYear;
		}

		public ICollection<User> filter(ICollection<User> i_Friends)
		{
			HashSet<User> friendsFromStartPointToEndPoint = new HashSet<User>();

			foreach(User user in i_Friends)
			{
				int? age = GetAgeFromUserBirthday(user.Birthday);
				if(age >= m_MinAge && age <= m_MaxAge)
				{
					friendsFromStartPointToEndPoint.Add(user);
				}
			}

			return friendsFromStartPointToEndPoint;
		}
	}
}
