using System.Windows.Forms;

namespace UI
{
	public partial class ControlRidePage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelFromLocation = new System.Windows.Forms.Label();
			this.comboBoxEvents = new System.Windows.Forms.ComboBox();
			this.listBoxLocations = new System.Windows.Forms.ListBox();
			this.comboBoxAcademic = new System.Windows.Forms.ComboBox();
			this.comboBoxWork = new System.Windows.Forms.ComboBox();
			this.bindingSourceRideFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.buttonEvent = new System.Windows.Forms.Button();
			this.buttonWork = new System.Windows.Forms.Button();
			this.buttonAcademicInstitution = new System.Windows.Forms.Button();
			this.controlFilter = new UI.ControlFilter();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// labelFromLocation
			// 
			this.labelFromLocation.AutoSize = true;
			this.labelFromLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.labelFromLocation.Location = new System.Drawing.Point(13, 36);
			this.labelFromLocation.Name = "labelFromLocation";
			this.labelFromLocation.Size = new System.Drawing.Size(252, 29);
			this.labelFromLocation.TabIndex = 29;
			this.labelFromLocation.Text = "Choose Starting Point:";
			// 
			// comboBoxEvents
			// 
			this.comboBoxEvents.Enabled = false;
			this.comboBoxEvents.FormattingEnabled = true;
			this.comboBoxEvents.Location = new System.Drawing.Point(420, 492);
			this.comboBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxEvents.Name = "comboBoxEvents";
			this.comboBoxEvents.Size = new System.Drawing.Size(187, 28);
			this.comboBoxEvents.TabIndex = 28;
			this.comboBoxEvents.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvents_SelectedIndexChanged);
			// 
			// listBoxLocations
			// 
			this.listBoxLocations.FormattingEnabled = true;
			this.listBoxLocations.ItemHeight = 20;
			this.listBoxLocations.Location = new System.Drawing.Point(13, 61);
			this.listBoxLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxLocations.Name = "listBoxLocations";
			this.listBoxLocations.Size = new System.Drawing.Size(187, 344);
			this.listBoxLocations.TabIndex = 25;
			this.listBoxLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxLocations_SelectedIndexChanged);
			// 
			// comboBoxAcademic
			// 
			this.comboBoxAcademic.Enabled = false;
			this.comboBoxAcademic.FormattingEnabled = true;
			this.comboBoxAcademic.Location = new System.Drawing.Point(13, 492);
			this.comboBoxAcademic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxAcademic.Name = "comboBoxAcademic";
			this.comboBoxAcademic.Size = new System.Drawing.Size(187, 28);
			this.comboBoxAcademic.TabIndex = 31;
			this.comboBoxAcademic.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcademic_SelectedIndexChanged);
			// 
			// comboBoxWork
			// 
			this.comboBoxWork.Enabled = false;
			this.comboBoxWork.FormattingEnabled = true;
			this.comboBoxWork.Location = new System.Drawing.Point(216, 492);
			this.comboBoxWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxWork.Name = "comboBoxWork";
			this.comboBoxWork.Size = new System.Drawing.Size(187, 28);
			this.comboBoxWork.TabIndex = 32;
			this.comboBoxWork.SelectedIndexChanged += new System.EventHandler(this.comboBoxWork_SelectedIndexChanged);
			// 
			// bindingSourceRideFriendsGrid
			// 
			this.bindingSourceRideFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// buttonEvent
			// 
			this.buttonEvent.BackColor = System.Drawing.Color.Transparent;
			this.buttonEvent.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonEvent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonEvent.Enabled = false;
			this.buttonEvent.FlatAppearance.BorderSize = 0;
			this.buttonEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonEvent.Location = new System.Drawing.Point(420, 456);
			this.buttonEvent.Name = "buttonEvent";
			this.buttonEvent.Size = new System.Drawing.Size(187, 23);
			this.buttonEvent.TabIndex = 54;
			this.buttonEvent.Text = "Ride To Your Event";
			this.buttonEvent.UseVisualStyleBackColor = false;
			this.buttonEvent.Click += new System.EventHandler(this.buttonEvent_Click);
			// 
			// buttonWork
			// 
			this.buttonWork.BackColor = System.Drawing.Color.Transparent;
			this.buttonWork.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonWork.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonWork.Enabled = false;
			this.buttonWork.FlatAppearance.BorderSize = 0;
			this.buttonWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonWork.Location = new System.Drawing.Point(216, 456);
			this.buttonWork.Name = "buttonWork";
			this.buttonWork.Size = new System.Drawing.Size(187, 23);
			this.buttonWork.TabIndex = 55;
			this.buttonWork.Text = "Ride To Your Work";
			this.buttonWork.UseVisualStyleBackColor = false;
			this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
			// 
			// buttonAcademicInstitution
			// 
			this.buttonAcademicInstitution.BackColor = System.Drawing.Color.Transparent;
			this.buttonAcademicInstitution.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonAcademicInstitution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAcademicInstitution.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAcademicInstitution.Enabled = false;
			this.buttonAcademicInstitution.FlatAppearance.BorderSize = 0;
			this.buttonAcademicInstitution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAcademicInstitution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAcademicInstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAcademicInstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonAcademicInstitution.Location = new System.Drawing.Point(13, 456);
			this.buttonAcademicInstitution.Name = "buttonAcademicInstitution";
			this.buttonAcademicInstitution.Size = new System.Drawing.Size(189, 23);
			this.buttonAcademicInstitution.TabIndex = 56;
			this.buttonAcademicInstitution.Text = "Ride To Your Academic Institution";
			this.buttonAcademicInstitution.UseVisualStyleBackColor = false;
			this.buttonAcademicInstitution.Click += new System.EventHandler(this.buttonAcademicInstitution_Click);
			// 
			// controlFilter
			// 
			this.controlFilter.Location = new System.Drawing.Point(205, 42);
			this.controlFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.controlFilter.Name = "controlFilter";
			this.controlFilter.Size = new System.Drawing.Size(426, 406);
			this.controlFilter.TabIndex = 33;
			this.controlFilter.Visible = false;
			// 
			// ControlRidePage
			// 
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.buttonAcademicInstitution);
			this.Controls.Add(this.buttonWork);
			this.Controls.Add(this.buttonEvent);
			this.Controls.Add(this.controlFilter);
			this.Controls.Add(this.comboBoxWork);
			this.Controls.Add(this.comboBoxAcademic);
			this.Controls.Add(this.labelFromLocation);
			this.Controls.Add(this.comboBoxEvents);
			this.Controls.Add(this.listBoxLocations);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ControlRidePage";
			this.Size = new System.Drawing.Size(636, 628);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Label labelFromLocation;
		private ListBox listBoxLocations;
		private ComboBox comboBoxEvents;
		private ComboBox comboBoxAcademic;
		private ComboBox comboBoxWork;
		private BindingSource bindingSourceRideFriendsGrid;

		#endregion

		private ControlFilter controlFilter;
		private Button buttonEvent;
		private Button buttonWork;
		private Button buttonAcademicInstitution;
	}
}