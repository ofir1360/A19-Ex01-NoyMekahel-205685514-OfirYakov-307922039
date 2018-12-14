namespace UI
{
	public partial class FormCollageView
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
			this.components = new System.ComponentModel.Container();
			this.buttonSaveAs = new System.Windows.Forms.Button();
			this.pictureBoxCollageView = new System.Windows.Forms.PictureBox();
			this.comboBoxFrameColor = new System.Windows.Forms.ComboBox();
			this.bindingSourceColor = new System.Windows.Forms.BindingSource(this.components);
			this.labelFrameColor = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollageView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceColor)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSaveAs
			// 
			this.buttonSaveAs.BackColor = System.Drawing.Color.Transparent;
			this.buttonSaveAs.BackgroundImage = global::UI.Properties.Resources.orange_button;
			this.buttonSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSaveAs.FlatAppearance.BorderSize = 0;
			this.buttonSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSaveAs.Location = new System.Drawing.Point(451, 636);
			this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSaveAs.Name = "buttonSaveAs";
			this.buttonSaveAs.Size = new System.Drawing.Size(162, 35);
			this.buttonSaveAs.TabIndex = 60;
			this.buttonSaveAs.Text = "Save As";
			this.buttonSaveAs.UseVisualStyleBackColor = false;
			this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
			// 
			// pictureBoxCollageView
			// 
			this.pictureBoxCollageView.Location = new System.Drawing.Point(13, 14);
			this.pictureBoxCollageView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBoxCollageView.Name = "pictureBoxCollageView";
			this.pictureBoxCollageView.Size = new System.Drawing.Size(600, 600);
			this.pictureBoxCollageView.TabIndex = 0;
			this.pictureBoxCollageView.TabStop = false;
			// 
			// comboBoxFrameColor
			// 
			this.comboBoxFrameColor.DataSource = this.bindingSourceColor;
			this.comboBoxFrameColor.DisplayMember = "Name";
			this.comboBoxFrameColor.FormattingEnabled = true;
			this.comboBoxFrameColor.Location = new System.Drawing.Point(115, 640);
			this.comboBoxFrameColor.Name = "comboBoxFrameColor";
			this.comboBoxFrameColor.Size = new System.Drawing.Size(193, 28);
			this.comboBoxFrameColor.TabIndex = 61;
			this.comboBoxFrameColor.ValueMember = "Name";
			this.comboBoxFrameColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrameColor_SelectedIndexChanged);
			// 
			// bindingSourceColor
			// 
			this.bindingSourceColor.DataSource = typeof(System.Drawing.Color);
			// 
			// labelFrameColor
			// 
			this.labelFrameColor.AutoSize = true;
			this.labelFrameColor.Location = new System.Drawing.Point(12, 643);
			this.labelFrameColor.Name = "labelFrameColor";
			this.labelFrameColor.Size = new System.Drawing.Size(97, 20);
			this.labelFrameColor.TabIndex = 62;
			this.labelFrameColor.Text = "Frame color:";
			// 
			// FormCollageView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 694);
			this.Controls.Add(this.labelFrameColor);
			this.Controls.Add(this.comboBoxFrameColor);
			this.Controls.Add(this.buttonSaveAs);
			this.Controls.Add(this.pictureBoxCollageView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormCollageView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Collage View";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollageView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceColor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCollageView;
		private System.Windows.Forms.Button buttonSaveAs;
		private System.Windows.Forms.ComboBox comboBoxFrameColor;
		private System.Windows.Forms.BindingSource bindingSourceColor;
		private System.Windows.Forms.Label labelFrameColor;
	}
}