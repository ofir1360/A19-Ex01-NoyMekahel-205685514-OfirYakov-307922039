using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class DataManager
	{
		private User m_LoggedInUser;

		public Ride Ride { get; private set; }

		public DataManager(User i_LoggedInUser)
		{
			m_LoggedInUser = i_LoggedInUser;
		}

		public string GetPictureNormalURL()
		{
			return m_LoggedInUser.PictureNormalURL;
		}

		public FacebookObjectCollection<User> GetFriends()
		{
			return m_LoggedInUser.Friends;
		}

		public ICollection<string> GetFriendsNames()
		{
			List<string> allNames = new List<string>();

			foreach(User friend in m_LoggedInUser.Friends)
			{
				allNames.Add(friend.Name);
			}

			return allNames;
		}

		public ICollection<string> GetAlbumsNames()
		{
			List<string> allNames = new List<string>();

			foreach (Album album in m_LoggedInUser.Albums)
			{
				allNames.Add(album.Name);
			}

			return allNames;
		}

		public Education[] GetEducations()
		{
			return m_LoggedInUser.Educations;
		}

		public FacebookObjectCollection<Page> GetUserLikedPages()
		{
			return m_LoggedInUser.LikedPages;
		}

		public FacebookObjectCollection<Post> GetUserPosts()
		{
			return m_LoggedInUser.Posts;
		}

		public FacebookObjectCollection<Album> GetAlbums()
        {
            return m_LoggedInUser.Albums;
        }

        public FacebookObjectCollection<Event> GetEvents()
		{
			return m_LoggedInUser.Events;
		}

		public WorkExperience[] GetWorkExperiences()
		{
			return m_LoggedInUser.WorkExperiences;
		}

		public ICollection<string> GetSortedFriendsLocation()
		{
			ISet<string> locationsSet = new SortedSet<string>();

			foreach (User currentFriend in m_LoggedInUser.Friends)
			{
				if (currentFriend.Location != null)
				{
					locationsSet.Add(currentFriend.Location.Name);
				}
			}

			return locationsSet;
		}

		public ICollection<string> GetEventsNames()
		{
			List<string> allEventsNames = new List<string>(m_LoggedInUser.Events.Count);
			
			foreach (Event currEvent in m_LoggedInUser.Events)
			{
				allEventsNames.Add(currEvent.Name);
			}

			return allEventsNames;
		}

		public ICollection<string> GetWorkPlacesNames()
		{
			List<string> allWorkPlacesNames = new List<string>(m_LoggedInUser.WorkExperiences.Length);

			foreach (WorkExperience currWorkPlace in m_LoggedInUser.WorkExperiences)
			{
				allWorkPlacesNames.Add(currWorkPlace.Name);
			}

			return allWorkPlacesNames;
		}

		public FacebookObjectCollection<Photo> GetAlbumsPhotos(ICollection<string> i_AlbumsNamesCollection)
		{
			FacebookObjectCollection<Photo> photosCollection = new FacebookObjectCollection<Photo>();

			foreach (Album album in m_LoggedInUser.Albums)
			{
				if (i_AlbumsNamesCollection.Contains(album.Name))
				{
					foreach (Photo photo in album.Photos)
					{
						photosCollection.Add(photo);
					}
				}
			}

			return photosCollection;
		}

		public ICollection<string> GetAcademicInstitutionsNames()
		{
			List<string> allAcademicInstitutionsNames = new List<string>(m_LoggedInUser.Educations.Length);

			foreach (Education currAcademicInstitution in m_LoggedInUser.Educations)
			{
				allAcademicInstitutionsNames.Add(currAcademicInstitution.School.Name);
			}

			return allAcademicInstitutionsNames;
		}

		public FacebookObjectCollection<Photo> GetSharedFriendsPhotos(ICollection<string> i_FriendsNamesCollection)
		{
			FacebookObjectCollection<Photo> photosList = new FacebookObjectCollection<Photo>();

			foreach (Album album in m_LoggedInUser.Albums)
			{
				foreach (Photo photo in album.Photos)
				{
					foreach (PhotoTag tag in photo.Tags)
					{
						if (i_FriendsNamesCollection.Contains(tag.User.Name))
						{
							photosList.Add(photo);
							break;
						}
					}
				}
			}

			return photosList;
		}

		public string GetFirstName()
		{
			return m_LoggedInUser.FirstName;
		}

		public string GetLastName()
		{
			return m_LoggedInUser.LastName;
		}

		public string GetEmail()
		{
			return m_LoggedInUser.Email;
		}

		public string GetBirthday()
		{
			return m_LoggedInUser.Birthday;
		}

		public int GetDaysTillBirthday()
		{
			return calculateDaysTillBirthday();
		}

		private int calculateDaysTillBirthday()
		{
			const int	k_AddOneYear = 1;
			DateTime	birthdate = parseStringToDateTime(m_LoggedInUser.Birthday);
			DateTime	todayDate = DateTime.Today;
			DateTime	birthday = new DateTime(todayDate.Year, birthdate.Month, birthdate.Day);

			if (birthday < todayDate)
			{
				birthday = birthday.AddYears(k_AddOneYear);
			}

			return (birthday - todayDate).Days;
		}

		private DateTime parseStringToDateTime(string i_Date)
		{
			const string	k_DateRegexWithYear = "^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\\d\\d$";
			const string	k_DateRegexWithoutYear = "^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$";
			const int		k_StartOfMonth = 0;
			const int		k_StartOfDay = 3;
			const int		k_StartOfYear = 6;
			const int		k_LengthOfYear = 4;
			const int		k_LengthOfMonthOrDay = 2;
			int				day = 0, month = 0, year = 0;

			if (Regex.IsMatch(i_Date, k_DateRegexWithYear))
			{
				month = int.Parse(i_Date.Substring(k_StartOfMonth, k_LengthOfMonthOrDay));
				day = int.Parse(i_Date.Substring(k_StartOfDay, k_LengthOfMonthOrDay));
				year = int.Parse(i_Date.Substring(k_StartOfYear, k_LengthOfYear));
			}
			else if (Regex.IsMatch(i_Date, k_DateRegexWithoutYear))
			{
				month = int.Parse(i_Date.Substring(k_StartOfMonth, k_LengthOfMonthOrDay));
				day = int.Parse(i_Date.Substring(k_StartOfDay, k_LengthOfMonthOrDay));
				year = DateTime.Today.Year;
			}
			else
			{
				throw new FormatException("Illegal date format! ");
			}

			return new DateTime(year, month, day);
		}

		public void InitializeRide(string i_RideFromLocationName)
		{
			List<User> friendsFromStartPoint = new List<User>();

			foreach (User user in m_LoggedInUser.Friends)
			{
				if (user.Location.Name.Equals(i_RideFromLocationName))
				{
					friendsFromStartPoint.Add(user);
				}
			}

			Ride = new Ride() { FriendsFromStartPoint = friendsFromStartPoint };
		}
	}
}
