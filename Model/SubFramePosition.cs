using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public class SubFramePosition
	{
		public Point Point { get; private set; }

		public Size Size { get; private set; }

		public SubFramePosition(Point i_Point, Size i_Size)
		{
			Point = i_Point;
			Size = i_Size;
		}
	}
}
