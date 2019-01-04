using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Model
{
	public class Albums
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

	}
}
