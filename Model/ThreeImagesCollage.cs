using System.Collections.Generic;
using System.Drawing;

namespace Model
{
	public class ThreeImagesCollage : CollageBase
	{
		public override void createSubFramePositions()
		{
			m_CollageData.SubFramePositionList = new List<SubFramePosition>();
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(m_CollageData.InitPoint, new Size(m_CollageData.Size / 2, m_CollageData.Size)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
		}
	}
}
