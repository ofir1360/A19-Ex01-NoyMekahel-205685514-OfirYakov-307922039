using System;
using FacebookWrapper;

namespace Model
{
	public static class FacebookConnection
	{
		public static DataManager Login()
		{
			LoginResult result = FacebookService.Login(
				"264186474290093", 
				"user_birthday",
				"user_events",
				"user_posts",
				"user_location",
				"user_friends",
                "user_photos");

			if (!string.IsNullOrEmpty(result.AccessToken))
			{
				AppSettings.Instance.LastAccessToken = result.AccessToken;
				return new DataManager(result.LoggedInUser);
			}
			else
			{
				throw new Exception(result.ErrorMessage);
			}
		}

		public static DataManager Connect(string i_LastAccessToken)
		{
			LoginResult result = FacebookService.Connect(i_LastAccessToken);
			return new DataManager(result.LoggedInUser);
		}

		public static void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}
