using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class Albums : IEnumerable<Album>
	{
		ICollection<Album> m_AlbumsCollection;

		public Albums(FacebookObjectCollection<Album> i_AlbumsCollection)
		{
			m_AlbumsCollection = i_AlbumsCollection;
		}

		public IEnumerator<Album> GetEnumerator()
		{
			foreach(Album album in m_AlbumsCollection)
			{
				yield return album;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
