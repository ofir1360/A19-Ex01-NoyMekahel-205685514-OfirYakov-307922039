namespace UI
{
	public partial class ControlFilter
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridFriendsResult = new System.Windows.Forms.DataGridView();
			this.imageSmallDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.relationshipStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceRideFriendsGrid = new System.Windows.Forms.BindingSource(this.components);
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.radioButtonFamale = new System.Windows.Forms.RadioButton();
			this.groupBoxGender = new System.Windows.Forms.GroupBox();
			this.checkBoxGender = new System.Windows.Forms.CheckBox();
			this.radioButtonAge4 = new System.Windows.Forms.RadioButton();
			this.radioButtonAge3 = new System.Windows.Forms.RadioButton();
			this.radioButtonAge2 = new System.Windows.Forms.RadioButton();
			this.radioButtonAge1 = new System.Windows.Forms.RadioButton();
			this.groupBoxAge = new System.Windows.Forms.GroupBox();
			this.checkBoxAge = new System.Windows.Forms.CheckBox();
			this.panelFilter = new System.Windows.Forms.Panel();
			this.buttonFilter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridFriendsResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).BeginInit();
			this.groupBoxGender.SuspendLayout();
			this.groupBoxAge.SuspendLayout();
			this.panelFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridFriendsResult
			// 
			this.dataGridFriendsResult.AllowUserToAddRows = false;
			this.dataGridFriendsResult.AllowUserToDeleteRows = false;
			this.dataGridFriendsResult.AllowUserToOrderColumns = true;
			this.dataGridFriendsResult.AllowUserToResizeRows = false;
			this.dataGridFriendsResult.AutoGenerateColumns = false;
			this.dataGridFriendsResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridFriendsResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridFriendsResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.imageSmallDataGridViewImageColumn,
			this.nameDataGridViewTextBoxColumn,
			this.genderDataGridViewTextBoxColumn,
			this.relationshipStatusDataGridViewTextBoxColumn,
			this.religionDataGridViewTextBoxColumn,
			this.AgeColumn});
			this.dataGridFriendsResult.DataSource = this.bindingSourceRideFriendsGrid;
			this.dataGridFriendsResult.Location = new System.Drawing.Point(26, 29);
			this.dataGridFriendsResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridFriendsResult.Name = "dataGridFriendsResult";
			this.dataGridFriendsResult.RowTemplate.Height = 28;
			this.dataGridFriendsResult.Size = new System.Drawing.Size(596, 394);
			this.dataGridFriendsResult.TabIndex = 49;
			// 
			// imageSmallDataGridViewImageColumn
			// 
			this.imageSmallDataGridViewImageColumn.DataPropertyName = "ImageSmall";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.imageSmallDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.imageSmallDataGridViewImageColumn.HeaderText = "Image";
			this.imageSmallDataGridViewImageColumn.Name = "imageSmallDataGridViewImageColumn";
			this.imageSmallDataGridViewImageColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.genderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// relationshipStatusDataGridViewTextBoxColumn
			// 
			this.relationshipStatusDataGridViewTextBoxColumn.DataPropertyName = "RelationshipStatus";
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.relationshipStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.relationshipStatusDataGridViewTextBoxColumn.HeaderText = "RelationshipStatus";
			this.relationshipStatusDataGridViewTextBoxColumn.Name = "relationshipStatusDataGridViewTextBoxColumn";
			this.relationshipStatusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// religionDataGridViewTextBoxColumn
			// 
			this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.religionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
			this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
			this.religionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// AgeColumn
			// 
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			this.AgeColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.AgeColumn.HeaderText = "Age";
			this.AgeColumn.Name = "AgeColumn";
			this.AgeColumn.ReadOnly = true;
			// 
			// bindingSourceRideFriendsGrid
			// 
			this.bindingSourceRideFriendsGrid.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.Checked = true;
			this.radioButtonMale.Location = new System.Drawing.Point(9, 20);
			this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
			this.radioButtonMale.TabIndex = 36;
			this.radioButtonMale.TabStop = true;
			this.radioButtonMale.Text = "Male";
			this.radioButtonMale.UseVisualStyleBackColor = true;
			// 
			// radioButtonFamale
			// 
			this.radioButtonFamale.AutoSize = true;
			this.radioButtonFamale.Location = new System.Drawing.Point(130, 20);
			this.radioButtonFamale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonFamale.Name = "radioButtonFamale";
			this.radioButtonFamale.Size = new System.Drawing.Size(87, 24);
			this.radioButtonFamale.TabIndex = 35;
			this.radioButtonFamale.Text = "Famale";
			this.radioButtonFamale.UseVisualStyleBackColor = true;
			// 
			// groupBoxGender
			// 
			this.groupBoxGender.Controls.Add(this.radioButtonFamale);
			this.groupBoxGender.Controls.Add(this.radioButtonMale);
			this.groupBoxGender.Location = new System.Drawing.Point(122, 5);
			this.groupBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxGender.Name = "groupBoxGender";
			this.groupBoxGender.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxGender.Size = new System.Drawing.Size(266, 52);
			this.groupBoxGender.TabIndex = 48;
			this.groupBoxGender.TabStop = false;
			this.groupBoxGender.Visible = false;
			// 
			// checkBoxGender
			// 
			this.checkBoxGender.AutoSize = true;
			this.checkBoxGender.Location = new System.Drawing.Point(21, 26);
			this.checkBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxGender.Name = "checkBoxGender";
			this.checkBoxGender.Size = new System.Drawing.Size(89, 24);
			this.checkBoxGender.TabIndex = 50;
			this.checkBoxGender.Text = "Gender";
			this.checkBoxGender.UseVisualStyleBackColor = true;
			this.checkBoxGender.CheckedChanged += new System.EventHandler(this.checkBoxGender_CheckedChanged);
			// 
			// radioButtonAge4
			// 
			this.radioButtonAge4.AutoSize = true;
			this.radioButtonAge4.Location = new System.Drawing.Point(374, 20);
			this.radioButtonAge4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonAge4.Name = "radioButtonAge4";
			this.radioButtonAge4.Size = new System.Drawing.Size(61, 24);
			this.radioButtonAge4.TabIndex = 41;
			this.radioButtonAge4.Text = "40+";
			this.radioButtonAge4.UseVisualStyleBackColor = true;
			// 
			// radioButtonAge3
			// 
			this.radioButtonAge3.AutoSize = true;
			this.radioButtonAge3.Location = new System.Drawing.Point(252, 20);
			this.radioButtonAge3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonAge3.Name = "radioButtonAge3";
			this.radioButtonAge3.Size = new System.Drawing.Size(75, 24);
			this.radioButtonAge3.TabIndex = 40;
			this.radioButtonAge3.Text = "30-40";
			this.radioButtonAge3.UseVisualStyleBackColor = true;
			// 
			// radioButtonAge2
			// 
			this.radioButtonAge2.AutoSize = true;
			this.radioButtonAge2.Location = new System.Drawing.Point(130, 20);
			this.radioButtonAge2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonAge2.Name = "radioButtonAge2";
			this.radioButtonAge2.Size = new System.Drawing.Size(75, 24);
			this.radioButtonAge2.TabIndex = 39;
			this.radioButtonAge2.Text = "20-30";
			this.radioButtonAge2.UseVisualStyleBackColor = true;
			// 
			// radioButtonAge1
			// 
			this.radioButtonAge1.AutoSize = true;
			this.radioButtonAge1.Checked = true;
			this.radioButtonAge1.Location = new System.Drawing.Point(9, 20);
			this.radioButtonAge1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonAge1.Name = "radioButtonAge1";
			this.radioButtonAge1.Size = new System.Drawing.Size(75, 24);
			this.radioButtonAge1.TabIndex = 38;
			this.radioButtonAge1.TabStop = true;
			this.radioButtonAge1.Text = "16-20";
			this.radioButtonAge1.UseVisualStyleBackColor = true;
			// 
			// groupBoxAge
			// 
			this.groupBoxAge.Controls.Add(this.radioButtonAge1);
			this.groupBoxAge.Controls.Add(this.radioButtonAge2);
			this.groupBoxAge.Controls.Add(this.radioButtonAge3);
			this.groupBoxAge.Controls.Add(this.radioButtonAge4);
			this.groupBoxAge.Location = new System.Drawing.Point(122, 66);
			this.groupBoxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxAge.Name = "groupBoxAge";
			this.groupBoxAge.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxAge.Size = new System.Drawing.Size(446, 57);
			this.groupBoxAge.TabIndex = 49;
			this.groupBoxAge.TabStop = false;
			this.groupBoxAge.Visible = false;
			// 
			// checkBoxAge
			// 
			this.checkBoxAge.AutoSize = true;
			this.checkBoxAge.Location = new System.Drawing.Point(21, 88);
			this.checkBoxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxAge.Name = "checkBoxAge";
			this.checkBoxAge.Size = new System.Drawing.Size(64, 24);
			this.checkBoxAge.TabIndex = 51;
			this.checkBoxAge.Text = "Age";
			this.checkBoxAge.UseVisualStyleBackColor = true;
			this.checkBoxAge.CheckedChanged += new System.EventHandler(this.checkBoxAge_CheckedChanged);
			// 
			// panelFilter
			// 
			this.panelFilter.Controls.Add(this.buttonFilter);
			this.panelFilter.Controls.Add(this.checkBoxGender);
			this.panelFilter.Controls.Add(this.groupBoxAge);
			this.panelFilter.Controls.Add(this.checkBoxAge);
			this.panelFilter.Controls.Add(this.groupBoxGender);
			this.panelFilter.Location = new System.Drawing.Point(26, 432);
			this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelFilter.Name = "panelFilter";
			this.panelFilter.Size = new System.Drawing.Size(596, 195);
			this.panelFilter.TabIndex = 51;
			// 
			// buttonFilter
			// 
			this.buttonFilter.BackColor = System.Drawing.Color.Transparent;
			this.buttonFilter.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonFilter.Enabled = false;
			this.buttonFilter.FlatAppearance.BorderSize = 0;
			this.buttonFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonFilter.Location = new System.Drawing.Point(228, 132);
			this.buttonFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Size = new System.Drawing.Size(144, 35);
			this.buttonFilter.TabIndex = 53;
			this.buttonFilter.Text = "Filter";
			this.buttonFilter.UseVisualStyleBackColor = false;
			this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
			// 
			// ControlFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelFilter);
			this.Controls.Add(this.dataGridFriendsResult);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ControlFilter";
			this.Size = new System.Drawing.Size(640, 648);
			((System.ComponentModel.ISupportInitialize)(this.dataGridFriendsResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceRideFriendsGrid)).EndInit();
			this.groupBoxGender.ResumeLayout(false);
			this.groupBoxGender.PerformLayout();
			this.groupBoxAge.ResumeLayout(false);
			this.groupBoxAge.PerformLayout();
			this.panelFilter.ResumeLayout(false);
			this.panelFilter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridFriendsResult;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private System.Windows.Forms.RadioButton radioButtonFamale;
		private System.Windows.Forms.GroupBox groupBoxGender;
		private System.Windows.Forms.CheckBox checkBoxGender;
		private System.Windows.Forms.RadioButton radioButtonAge4;
		private System.Windows.Forms.RadioButton radioButtonAge3;
		private System.Windows.Forms.RadioButton radioButtonAge2;
		private System.Windows.Forms.RadioButton radioButtonAge1;
		private System.Windows.Forms.GroupBox groupBoxAge;
		private System.Windows.Forms.CheckBox checkBoxAge;
		private System.Windows.Forms.Panel panelFilter;
		private System.Windows.Forms.BindingSource bindingSourceRideFriendsGrid;
		private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn relationshipStatusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
		private System.Windows.Forms.Button buttonFilter;
	}
}