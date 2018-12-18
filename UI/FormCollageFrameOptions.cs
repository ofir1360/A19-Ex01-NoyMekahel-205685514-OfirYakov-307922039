using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace UI
{
	public partial class FormCollageFrameOptions : Form
	{
		private List<Panel> m_CollageFramePanelList = new List<Panel>();

		public FormCollageFrameOptions(ICollection<CollageBase> i_AllCollagesCollection)
		{
			InitializeComponent();
			createCollageSkeletonPanels(i_AllCollagesCollection);
		}

		private void createCollageSkeletonPanels(ICollection<CollageBase> i_AllCollagesCollection)
		{
			const int k_StartLineX = 25;
			const int k_FrameSize = 150;
			const int k_RightLimit = 455;
			const int k_NextPanelX = 215;
			const int k_NextPanelY = 200;

			// location of the first panel
			int x = k_StartLineX, y = 54;

			for (int collageIndex = 0; collageIndex < Enum.GetNames(typeof(CollageData.eFrameCollage)).Length; collageIndex++)
			{
				Panel panel = new Panel()
				{
					Size = new Size(k_FrameSize, k_FrameSize),
					Location = new Point(x, y)
				};

				m_CollageFramePanelList.Add(panel);
				panelMain.Controls.Add(panel);

				if (x == k_RightLimit)
				{
					x = k_StartLineX;
					y += k_NextPanelY;
				}
				else
				{
					x += k_NextPanelX;
				}
			}

			showSkeletons(i_AllCollagesCollection);
		}

		private void showSkeletons(ICollection<CollageBase> i_AllCollagesCollection)
		{
			int index = 0;

			foreach (CollageBase collage in i_AllCollagesCollection)
			{
				PictureBox collagePictureBox = new PictureBox()
				{
					Location = new Point(0, 0),
					Image = new Bitmap(
						collage.GetSkeleton(),
						new Size(
							m_CollageFramePanelList[index].Width,
							m_CollageFramePanelList[index].Height)),
					Size = new Size(
						m_CollageFramePanelList[index].Width,
						m_CollageFramePanelList[index].Height),
					SizeMode = PictureBoxSizeMode.StretchImage,
					BorderStyle = BorderStyle.FixedSingle
				};

				m_CollageFramePanelList[index].Controls.Add(collagePictureBox);
				index++;
			}
		}

		internal CollageData.eFrameCollage GetUserChoice()
		{
			return (CollageData.eFrameCollage)panelMain.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		internal void AddSaveListener(Action<object, FormClosingEventArgs> formCollage_FormClosing)
		{
			throw new NotImplementedException();
		}
	}
}