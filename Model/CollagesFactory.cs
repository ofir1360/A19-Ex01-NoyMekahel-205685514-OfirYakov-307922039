using System.Collections.Generic;

namespace Model
{
	public static class CollagesFactory
	{
		public static ICollection<CollageBase> CreateAllCollages()
		{
			List<CollageBase> allCollagesList = new List<CollageBase>();

			allCollagesList.Add(new ThreeImagesCollage());
			allCollagesList.Add(new FourImagesCollage());
			allCollagesList.Add(new FiveImagesCollage());
			allCollagesList.Add(new SixImagesCollage());
			allCollagesList.Add(new SevenImagesCollage());
			allCollagesList.Add(new EightImagesCollage());

			return allCollagesList;
		}
	}
}
