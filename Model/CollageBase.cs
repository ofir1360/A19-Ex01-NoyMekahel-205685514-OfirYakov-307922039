using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Model
{
	public abstract class CollageBase
	{
		protected CollageData m_CollageData = new CollageData();

		public abstract void createSubFramePositions();

		public Bitmap Collage
		{
			get
			{
				return m_CollageData.Collage;
			}
		}

		public Bitmap GetSkeleton()
		{
			createSkeleton();

			return m_CollageData.CollageSkeleton;
		}

		protected void createSkeleton()
		{
			createSubFramePositions();
			m_CollageData.CollageSkeleton = new Bitmap(m_CollageData.Size, m_CollageData.Size);
			using (Graphics g = Graphics.FromImage(m_CollageData.CollageSkeleton))
			{
				foreach (SubFramePosition subFramePosition in m_CollageData.SubFramePositionList)
				{
					g.FillRectangle(Brushes.LightGray, new Rectangle(subFramePosition.Point, subFramePosition.Size));
					g.DrawRectangle(new Pen(Color.Black), new Rectangle(subFramePosition.Point, subFramePosition.Size));
				}

				g.DrawImage(m_CollageData.CollageSkeleton, m_CollageData.InitPoint);
			}
		}

		public void CreateCollage(ICollection<Image> i_SelectedImages)
		{
			m_CollageData.Collage = new Bitmap(m_CollageData.Size, m_CollageData.Size);
			using (Graphics g = Graphics.FromImage(m_CollageData.Collage))
			{
				int counter = 0;
				foreach (SubFramePosition subFramePosition in m_CollageData.SubFramePositionList)
				{
					g.DrawImage(
						i_SelectedImages.ElementAt(counter),
						subFramePosition.Point.X,
						subFramePosition.Point.Y,
						subFramePosition.Size.Width,
						subFramePosition.Size.Height);
					counter++;
				}

				g.DrawImage(m_CollageData.Collage, m_CollageData.InitPoint);
				FillFrame(Color.White);
			}
		}

		public void Save(string i_FilePath)
		{
			m_CollageData.Collage.Save(i_FilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
		}

		public void FillFrame(Color i_Color)
		{
			const int k_SubFrameWidth = 5;
			const int k_AllFrameWidth = 8;

			using (Graphics g = Graphics.FromImage(m_CollageData.Collage))
			{
				foreach (SubFramePosition subFramePosition in m_CollageData.SubFramePositionList)
				{
					g.DrawRectangle(new Pen(i_Color, k_SubFrameWidth), new Rectangle(subFramePosition.Point, subFramePosition.Size));
				}

				g.DrawRectangle(new Pen(i_Color, k_AllFrameWidth), new Rectangle(m_CollageData.InitPoint, m_CollageData.Collage.Size));
				g.DrawImage(m_CollageData.Collage, m_CollageData.InitPoint);
			}
		}
	}
}
