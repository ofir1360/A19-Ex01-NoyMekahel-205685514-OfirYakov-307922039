namespace UI
{
	public partial class FormMap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
			this.webBrowserGoogleMap = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// webBrowserGoogleMap
			// 
			this.webBrowserGoogleMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowserGoogleMap.Location = new System.Drawing.Point(0, 0);
			this.webBrowserGoogleMap.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowserGoogleMap.Name = "webBrowserGoogleMap";
			this.webBrowserGoogleMap.Size = new System.Drawing.Size(704, 488);
			this.webBrowserGoogleMap.TabIndex = 0;
			// 
			// FormMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(704, 488);
			this.Controls.Add(this.webBrowserGoogleMap);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Map";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowserGoogleMap;
	}
}