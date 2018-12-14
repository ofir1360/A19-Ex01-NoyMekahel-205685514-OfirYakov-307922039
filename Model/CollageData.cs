using System.Collections.Generic;
using System.Drawing;

namespace Model
{
	public class CollageData
	{
		public enum eFrameCollage
		{
			THREE_IMAGES, FOUR_IMAGES, FIVE_IMAGES, SIX_IMAGES, SEVEN_IMAGES, EIGHT_IMAGES
		}

		private const int		k_Size = 600;
		private readonly Point	r_InitPoint = new Point(0, 0);

		public Bitmap Collage { get; set; }

		public Bitmap CollageSkeleton { get; set; }

		public List<SubFramePosition> SubFramePositionList { get; set; }

		public int Size
		{
			get
			{
				return k_Size;
			}
		}

		public Point InitPoint
		{
			get
			{
				return r_InitPoint;
			}
		}
	}
}
