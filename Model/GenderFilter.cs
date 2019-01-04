using FacebookWrapper.ObjectModel;

namespace Model
{
	public class GenderFilter : IFilter
	{
		private User.eGender m_GenderType;

		internal GenderFilter(string i_GenderType)
		{
			const string k_MaleString = "male";

			m_GenderType = i_GenderType.ToLower().Equals(k_MaleString) ? User.eGender.male : User.eGender.female;
		}

		public bool HasPassedFilter(User i_Friend)
		{
			return i_Friend.Gender == m_GenderType;
		}
	}
}
