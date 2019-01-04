using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class DataManagerFacade
	{
		private User m_LoggedInUser;
		private Albums m_Albums;

		public Ride Ride { get; private set; }

		public DataManagerFacade(User i_LoggedInUser)
		{
			m_LoggedInUser = i_LoggedInUser;
		}

		public Image ImageNormal
		{
			get
			{
				return m_LoggedInUser.ImageNormal;
			}
		}

		public string FirstName
		{
			get
			{
				return m_LoggedInUser.FirstName;
			}
		}

		public string LastName
		{
			get
			{
				return m_LoggedInUser.LastName;
			}
		}

		public string Email
		{
			get
			{
				return m_LoggedInUser.Email;
			}
		}

		public string Birthday
		{
			get
			{
				return m_LoggedInUser.Birthday;
			}
		}

		public int DaysTillBirthday
		{
			get
			{
				return calculateDaysTillBirthday();
			}
		}

		public FacebookObjectCollection<User> Friends
		{
			get
			{
				return m_LoggedInUser.Friends;
			}
		}

		public Education[] Educations
		{
			get
			{
				return m_LoggedInUser.Educations;
			}
		}

		public FacebookObjectCollection<Page> UserLikedPages
		{
			get
			{
				return m_LoggedInUser.LikedPages;
			}
		}

		public FacebookObjectCollection<Post> UserPosts
		{
			get
			{
				return m_LoggedInUser.Posts;
			}
		}

		public Albums Albums
        {
			get
			{
				if(m_Albums == null)
				{
					m_Albums = new Albums(m_LoggedInUser.Albums);
				}
				return m_Albums;
			}
		}

        public FacebookObjectCollection<Event> Events
		{
			get
			{
				return m_LoggedInUser.Events;
			}
		}

		public ICollection<string> SortedFriendsLocations
		{
			get
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
		}

		public ICollection<WorkExperience> WorkPlaces
		{
			get
			{
				List<WorkExperience> allWorkPlaces = new List<WorkExperience>();

				foreach (WorkExperience currWorkPlace in m_LoggedInUser.WorkExperiences)
				{
					allWorkPlaces.Add(currWorkPlace);
				}

				return allWorkPlaces;
			}
		}

		public FacebookObjectCollection<Photo> GetAlbumsPhotos(ICollection<Album> i_AlbumsCollection)
		{
			FacebookObjectCollection<Photo> photosCollection = new FacebookObjectCollection<Photo>();

			foreach (Album album in i_AlbumsCollection)
			{
				foreach (Photo photo in album.Photos)
				{
					photosCollection.Add(photo);
				}
			}

			return photosCollection;
		}

		public FacebookObjectCollection<Photo> GetSharedFriendsPhotos(ICollection<User> i_FriendsCollection)
		{
			FacebookObjectCollection<Photo> photosList = new FacebookObjectCollection<Photo>();

			foreach (Album album in m_LoggedInUser.Albums)
			{
				foreach (Photo photo in album.Photos)
				{
					foreach (PhotoTag tag in photo.Tags)
					{
						if (i_FriendsCollection.Contains(tag.User))
						{
							photosList.Add(photo);
							break;
						}
					}
				}
			}

			return photosList;
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
