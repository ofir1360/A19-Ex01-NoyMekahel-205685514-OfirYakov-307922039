using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using Model;

namespace UI
{
	public partial class FormCollageView : Form
	{
		private CollageBase m_Collage;

		public FormCollageView(CollageBase i_Collage)
		{
			InitializeComponent();
			m_Collage = i_Collage;
			displayCollageResult();
		}

		private void displayCollageResult()
		{
			Type colorType = typeof(Color);
			bindingSourceColor.DataSource = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
			showCollage();
		}

		private void showCollage()
		{
			pictureBoxCollageView.Image = m_Collage.Collage;
			pictureBoxCollageView.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void buttonSaveAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*.Jpeg)|*.Jpeg";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					m_Collage.Save(saveFileDialog.FileName);
					MessageBox.Show("Your collage saved!");
					this.Close();
				}
				catch (Exception ex)
				{
					FormFacebookApp.ShowFacebookError(ex.Message);
				}
			}
		}

		private void comboBoxFrameColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Color userChoiceColor = Color.FromName(comboBoxFrameColor.GetItemText(comboBoxFrameColor.SelectedItem));
			m_Collage.FillFrame(userChoiceColor);
			showCollage();
		}
	}
}
