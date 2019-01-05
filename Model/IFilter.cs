using FacebookWrapper.ObjectModel;

namespace Model
{
	public interface IFilter
	{
		bool HasPassedFilter(User i_Friend);
	}
}
