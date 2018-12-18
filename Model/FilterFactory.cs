namespace Model
{
	public static class FilterFactory
	{
		public enum eFilter { GENDER, AGE };

		public static IFilter GetFilter(eFilter i_Filter, string i_Text)
		{
			IFilter filter;

			if (i_Filter == eFilter.AGE)
			{
				filter = new AgeFilter(i_Text);
			}
			else
			{
				filter = new GenderFilter(i_Text);
			}

			return filter;
		}
	}
}
