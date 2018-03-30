namespace HSF_HideAndSeek {
	partial class AboutBox {
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.logoTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.infDescriptionLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.iconTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
			this.authorLabel = new System.Windows.Forms.Label();
			this.iconPictureBox = new System.Windows.Forms.PictureBox();
			this.appNameLabel = new System.Windows.Forms.Label();
			this.mainTableLayout.SuspendLayout();
			this.logoTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.iconTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTableLayout
			// 
			this.mainTableLayout.ColumnCount = 2;
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.85756F));
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.14244F));
			this.mainTableLayout.Controls.Add(this.logoTableLayout, 1, 0);
			this.mainTableLayout.Controls.Add(this.iconTableLayout, 0, 0);
			this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayout.Name = "mainTableLayout";
			this.mainTableLayout.RowCount = 1;
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416F));
			this.mainTableLayout.Size = new System.Drawing.Size(716, 438);
			this.mainTableLayout.TabIndex = 0;
			// 
			// logoTableLayout
			// 
			this.logoTableLayout.ColumnCount = 1;
			this.logoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.logoTableLayout.Controls.Add(this.descriptionLabel, 0, 2);
			this.logoTableLayout.Controls.Add(this.logoPictureBox, 0, 0);
			this.logoTableLayout.Controls.Add(this.infDescriptionLabel, 0, 1);
			this.logoTableLayout.Controls.Add(this.okButton, 0, 3);
			this.logoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoTableLayout.Location = new System.Drawing.Point(266, 3);
			this.logoTableLayout.Name = "logoTableLayout";
			this.logoTableLayout.RowCount = 4;
			this.logoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.logoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.40174F));
			this.logoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.80723F));
			this.logoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04819F));
			this.logoTableLayout.Size = new System.Drawing.Size(447, 432);
			this.logoTableLayout.TabIndex = 2;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.descriptionLabel.Location = new System.Drawing.Point(3, 137);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(441, 254);
			this.descriptionLabel.TabIndex = 3;
			this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.logo;
			this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(441, 94);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			// 
			// infDescriptionLabel
			// 
			this.infDescriptionLabel.AutoSize = true;
			this.infDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.infDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infDescriptionLabel.Location = new System.Drawing.Point(3, 100);
			this.infDescriptionLabel.Name = "infDescriptionLabel";
			this.infDescriptionLabel.Size = new System.Drawing.Size(441, 37);
			this.infDescriptionLabel.TabIndex = 1;
			this.infDescriptionLabel.Text = "Description:";
			this.infDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.Location = new System.Drawing.Point(344, 394);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(100, 35);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "Ok";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// iconTableLayout
			// 
			this.iconTableLayout.ColumnCount = 1;
			this.iconTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.iconTableLayout.Controls.Add(this.emailLinkLabel, 0, 4);
			this.iconTableLayout.Controls.Add(this.authorLabel, 0, 2);
			this.iconTableLayout.Controls.Add(this.iconPictureBox, 0, 0);
			this.iconTableLayout.Controls.Add(this.appNameLabel, 0, 1);
			this.iconTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.iconTableLayout.Location = new System.Drawing.Point(3, 3);
			this.iconTableLayout.Name = "iconTableLayout";
			this.iconTableLayout.RowCount = 5;
			this.iconTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.18747F));
			this.iconTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.660089F));
			this.iconTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35185F));
			this.iconTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777778F));
			this.iconTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12963F));
			this.iconTableLayout.Size = new System.Drawing.Size(257, 432);
			this.iconTableLayout.TabIndex = 3;
			// 
			// emailLinkLabel
			// 
			this.emailLinkLabel.AutoSize = true;
			this.emailLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.emailLinkLabel.Location = new System.Drawing.Point(3, 357);
			this.emailLinkLabel.Name = "emailLinkLabel";
			this.emailLinkLabel.Size = new System.Drawing.Size(251, 75);
			this.emailLinkLabel.TabIndex = 18;
			this.emailLinkLabel.TabStop = true;
			this.emailLinkLabel.Text = "s.amelunxen@gmx.de";
			this.emailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLinkLabel_LinkClicked);
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.authorLabel.Location = new System.Drawing.Point(3, 285);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(251, 61);
			this.authorLabel.TabIndex = 16;
			this.authorLabel.Text = "Simon Amelunxen\r\nDepartment of Appl. Computer Science\r\nFulda University of Applie" +
    "d Sciences";
			this.authorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// iconPictureBox
			// 
			this.iconPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.iconPictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.Final_cropped;
			this.iconPictureBox.Location = new System.Drawing.Point(3, 3);
			this.iconPictureBox.Name = "iconPictureBox";
			this.iconPictureBox.Size = new System.Drawing.Size(251, 251);
			this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPictureBox.TabIndex = 10;
			this.iconPictureBox.TabStop = false;
			// 
			// appNameLabel
			// 
			this.appNameLabel.AutoSize = true;
			this.appNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appNameLabel.Location = new System.Drawing.Point(3, 257);
			this.appNameLabel.Name = "appNameLabel";
			this.appNameLabel.Size = new System.Drawing.Size(251, 28);
			this.appNameLabel.TabIndex = 11;
			this.appNameLabel.Text = "HSF Hide and Seek v1.0";
			this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AboutBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 438);
			this.Controls.Add(this.mainTableLayout);
			this.Name = "AboutBox";
			this.Text = "AboutBox";
			this.mainTableLayout.ResumeLayout(false);
			this.logoTableLayout.ResumeLayout(false);
			this.logoTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.iconTableLayout.ResumeLayout(false);
			this.iconTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayout;
		private System.Windows.Forms.TableLayoutPanel logoTableLayout;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.TableLayoutPanel iconTableLayout;
		private System.Windows.Forms.PictureBox iconPictureBox;
		private System.Windows.Forms.Label infDescriptionLabel;
		private System.Windows.Forms.Label appNameLabel;
		private System.Windows.Forms.LinkLabel emailLinkLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Button okButton;
	}
}