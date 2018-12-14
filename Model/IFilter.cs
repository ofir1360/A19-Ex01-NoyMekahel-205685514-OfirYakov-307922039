using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public interface IFilter
	{
		ICollection<User> filter(ICollection<User> i_Friends);
	}
}
