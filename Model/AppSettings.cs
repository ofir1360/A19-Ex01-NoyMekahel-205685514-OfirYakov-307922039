using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Model
{
	public sealed class AppSettings
	{
		private const string			k_FileName = "AppSettings.xml";
		private static readonly object	sr_ContextLock = new object();
		private static AppSettings		m_AppSettings;

		public static AppSettings Instance
		{
			get
			{
				if (m_AppSettings == null)
				{
					lock (sr_ContextLock)
					{
						if (m_AppSettings == null)
						{
							m_AppSettings = loadFromFile();
						}
					}
				}

				return m_AppSettings;
			}
		}

		public string LastAccessToken { get; set; }

		public Point Location { get; set; }

		public bool RememberUser { get; set; } = false;

		private AppSettings()
		{
		}

		private static AppSettings loadFromFile()
		{
			if (File.Exists(k_FileName))
			{
				using (Stream stream = new FileStream(k_FileName, FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					m_AppSettings = serializer.Deserialize(stream) as AppSettings;
				}
			}
			else
			{
				m_AppSettings = new AppSettings();
			}

			return m_AppSettings;
		}

		public void SaveToFile()
		{
			using (Stream stream = new FileStream(k_FileName, FileMode.Create))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				serializer.Serialize(stream, this);
			}
		}
	}
}
