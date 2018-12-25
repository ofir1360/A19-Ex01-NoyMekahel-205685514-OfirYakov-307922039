using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace UI
{
	// Creating this class to able all the panels to use the most updated datamanager without holding an instance of it,
	// and the creator of this datamanager can only be the FormFacebookApp in which the login was preformed
	internal static class DataManagerWrapper
	{
		private static FormFacebookApp m_OwnerApp;

		public static DataManagerFacade DataManager { get; private set; }

		internal static void SetDataManager(FormFacebookApp i_FacebookApp, DataManagerFacade i_DataManager)
		{
			if (DataManager == null)
			{
				m_OwnerApp = i_FacebookApp;
			}

			if (m_OwnerApp == i_FacebookApp)
			{
				DataManager = i_DataManager;
			}
		}
	}
}