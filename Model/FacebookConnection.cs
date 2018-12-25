using System;
using FacebookWrapper;

namespace Model
{
	public static class FacebookConnection
	{
		public static DataManagerFacade Login()
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
				return new DataManagerFacade(result.LoggedInUser);
			}
			else
			{
				throw new Exception(result.ErrorMessage);
			}
		}

		public static DataManagerFacade Connect(string i_LastAccessToken)
		{
			LoginResult result = FacebookService.Connect(i_LastAccessToken);
			return new DataManagerFacade(result.LoggedInUser);
		}

		public static void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}
