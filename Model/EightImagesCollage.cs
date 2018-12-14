using System.Collections.Generic;
using System.Drawing;

namespace Model
{
	public class EightImagesCollage : CollageBase
	{
		public override void createSubFramePositions()
		{
			m_CollageData.SubFramePositionList = new List<SubFramePosition>();
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(m_CollageData.InitPoint, new Size(3 * m_CollageData.Size / 4, 3 * m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(3 * m_CollageData.Size / 4, 0), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(3 * m_CollageData.Size / 4, m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(3 * m_CollageData.Size / 4, m_CollageData.Size / 2), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(3 * m_CollageData.Size / 4, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(0, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 4, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
			m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
		}
	}
}
