using System.Windows.Forms;

namespace UI
{
	public partial class FormMap : Form
	{
		public FormMap()
		{
			InitializeComponent();
		}

		internal void ShowLocationOnMap(string i_Location)
		{
			string url = "http://maps.google.com/maps?q=" + i_Location;
			webBrowserGoogleMap.Navigate(url);
		}

		private void webBrowserGoogleMap_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			webBrowserGoogleMap.Document.Body.Style = "overflow:auto";
		}
	}
}