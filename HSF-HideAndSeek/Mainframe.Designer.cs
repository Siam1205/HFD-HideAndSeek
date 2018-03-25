namespace HSF_HideAndSeek {
	partial class Mainframe {
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
			this.carrierImageGroupBox = new System.Windows.Forms.GroupBox();
			this.carrierImagePictureBox = new System.Windows.Forms.PictureBox();
			this.stegoImageGroupBox = new System.Windows.Forms.GroupBox();
			this.stegoImagePictureBox = new System.Windows.Forms.PictureBox();
			this.lsbsComboBox = new System.Windows.Forms.ComboBox();
			this.lsbsLabel = new System.Windows.Forms.Label();
			this.stegoKeyTextbox = new System.Windows.Forms.TextBox();
			this.stegoKeyLabel = new System.Windows.Forms.Label();
			this.encryptionKeyTextbox = new System.Windows.Forms.TextBox();
			this.encryptionKeyLabel = new System.Windows.Forms.Label();
			this.showCarrierBitplanesButton = new System.Windows.Forms.Button();
			this.decryptMessageButton = new System.Windows.Forms.Button();
			this.encryptMessageButton = new System.Windows.Forms.Button();
			this.saveMesssageButton = new System.Windows.Forms.Button();
			this.saveStegoImageButton = new System.Windows.Forms.Button();
			this.loadMessageButton = new System.Windows.Forms.Button();
			this.extractMesssageButton = new System.Windows.Forms.Button();
			this.hideMessageButton = new System.Windows.Forms.Button();
			this.loadCarrierButton = new System.Windows.Forms.Button();
			this.showStegoImageBitplanesButton = new System.Windows.Forms.Button();
			this.loadStegoImageButton = new System.Windows.Forms.Button();
			this.clearCarrierAndMessageButton = new System.Windows.Forms.Button();
			this.clearStegoButton = new System.Windows.Forms.Button();
			this.informationTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.infCarrierNameLabel = new System.Windows.Forms.Label();
			this.infCarrierSizeLabel = new System.Windows.Forms.Label();
			this.infCarrierCapacityLabel = new System.Windows.Forms.Label();
			this.stegoImageSizeLabel = new System.Windows.Forms.Label();
			this.infMessageNameLabel = new System.Windows.Forms.Label();
			this.stegoImageNameLabel = new System.Windows.Forms.Label();
			this.infMessageSizeLabel = new System.Windows.Forms.Label();
			this.infStegoImageSizeLabel = new System.Windows.Forms.Label();
			this.infDetectionProbabilityLabel = new System.Windows.Forms.Label();
			this.detectionProbabilityLabel = new System.Windows.Forms.Label();
			this.infStegoImageNameLabel = new System.Windows.Forms.Label();
			this.messageSizeLabel = new System.Windows.Forms.Label();
			this.carrierNameLabel = new System.Windows.Forms.Label();
			this.carrierCapacityLabel = new System.Windows.Forms.Label();
			this.carrierSizeLabel = new System.Windows.Forms.Label();
			this.messageNameLabel = new System.Windows.Forms.Label();
			this.helpButton = new System.Windows.Forms.Button();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.carrierImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).BeginInit();
			this.stegoImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).BeginInit();
			this.informationTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// carrierImageGroupBox
			// 
			this.carrierImageGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.carrierImageGroupBox.Controls.Add(this.carrierImagePictureBox);
			this.carrierImageGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.carrierImageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierImageGroupBox.ForeColor = System.Drawing.Color.Blue;
			this.carrierImageGroupBox.Location = new System.Drawing.Point(15, 11);
			this.carrierImageGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.carrierImageGroupBox.Name = "carrierImageGroupBox";
			this.carrierImageGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.carrierImageGroupBox.Size = new System.Drawing.Size(600, 375);
			this.carrierImageGroupBox.TabIndex = 0;
			this.carrierImageGroupBox.TabStop = false;
			this.carrierImageGroupBox.Text = "Carrier image";
			// 
			// carrierImagePictureBox
			// 
			this.carrierImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carrierImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carrierImagePictureBox.Location = new System.Drawing.Point(4, 27);
			this.carrierImagePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.carrierImagePictureBox.Name = "carrierImagePictureBox";
			this.carrierImagePictureBox.Size = new System.Drawing.Size(592, 344);
			this.carrierImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.carrierImagePictureBox.TabIndex = 0;
			this.carrierImagePictureBox.TabStop = false;
			// 
			// stegoImageGroupBox
			// 
			this.stegoImageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.stegoImageGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.stegoImageGroupBox.Controls.Add(this.stegoImagePictureBox);
			this.stegoImageGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stegoImageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stegoImageGroupBox.ForeColor = System.Drawing.Color.Red;
			this.stegoImageGroupBox.Location = new System.Drawing.Point(638, 11);
			this.stegoImageGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.stegoImageGroupBox.Name = "stegoImageGroupBox";
			this.stegoImageGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.stegoImageGroupBox.Size = new System.Drawing.Size(600, 375);
			this.stegoImageGroupBox.TabIndex = 0;
			this.stegoImageGroupBox.TabStop = false;
			this.stegoImageGroupBox.Text = "Stego image";
			// 
			// stegoImagePictureBox
			// 
			this.stegoImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.stegoImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stegoImagePictureBox.Location = new System.Drawing.Point(4, 27);
			this.stegoImagePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.stegoImagePictureBox.Name = "stegoImagePictureBox";
			this.stegoImagePictureBox.Size = new System.Drawing.Size(592, 344);
			this.stegoImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.stegoImagePictureBox.TabIndex = 0;
			this.stegoImagePictureBox.TabStop = false;
			// 
			// lsbsComboBox
			// 
			this.lsbsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lsbsComboBox.Enabled = false;
			this.lsbsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.lsbsComboBox.FormattingEnabled = true;
			this.lsbsComboBox.Items.AddRange(new object[] {
            "3 bpp",
            "6 bpp",
            "9 bpp",
            "12 bpp",
            "15 bpp",
            "18 bpp",
            "21 bpp"});
			this.lsbsComboBox.Location = new System.Drawing.Point(548, 658);
			this.lsbsComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.lsbsComboBox.Name = "lsbsComboBox";
			this.lsbsComboBox.Size = new System.Drawing.Size(163, 28);
			this.lsbsComboBox.TabIndex = 10;
			// 
			// lsbsLabel
			// 
			this.lsbsLabel.AutoSize = true;
			this.lsbsLabel.Location = new System.Drawing.Point(544, 638);
			this.lsbsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lsbsLabel.Name = "lsbsLabel";
			this.lsbsLabel.Size = new System.Drawing.Size(130, 17);
			this.lsbsLabel.TabIndex = 8;
			this.lsbsLabel.Text = "Bits per pixel (bpp):";
			// 
			// stegoKeyTextbox
			// 
			this.stegoKeyTextbox.Enabled = false;
			this.stegoKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.stegoKeyTextbox.Location = new System.Drawing.Point(548, 595);
			this.stegoKeyTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.stegoKeyTextbox.Name = "stegoKeyTextbox";
			this.stegoKeyTextbox.Size = new System.Drawing.Size(163, 26);
			this.stegoKeyTextbox.TabIndex = 9;
			// 
			// stegoKeyLabel
			// 
			this.stegoKeyLabel.AutoSize = true;
			this.stegoKeyLabel.Location = new System.Drawing.Point(544, 575);
			this.stegoKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stegoKeyLabel.Name = "stegoKeyLabel";
			this.stegoKeyLabel.Size = new System.Drawing.Size(113, 17);
			this.stegoKeyLabel.TabIndex = 0;
			this.stegoKeyLabel.Text = "Stego password:";
			// 
			// encryptionKeyTextbox
			// 
			this.encryptionKeyTextbox.Enabled = false;
			this.encryptionKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.encryptionKeyTextbox.Location = new System.Drawing.Point(548, 478);
			this.encryptionKeyTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.encryptionKeyTextbox.Name = "encryptionKeyTextbox";
			this.encryptionKeyTextbox.Size = new System.Drawing.Size(163, 26);
			this.encryptionKeyTextbox.TabIndex = 7;
			// 
			// encryptionKeyLabel
			// 
			this.encryptionKeyLabel.AutoSize = true;
			this.encryptionKeyLabel.Location = new System.Drawing.Point(544, 458);
			this.encryptionKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.encryptionKeyLabel.Name = "encryptionKeyLabel";
			this.encryptionKeyLabel.Size = new System.Drawing.Size(105, 17);
			this.encryptionKeyLabel.TabIndex = 0;
			this.encryptionKeyLabel.Text = "Encryption key:";
			// 
			// showCarrierBitplanesButton
			// 
			this.showCarrierBitplanesButton.Enabled = false;
			this.showCarrierBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showCarrierBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showCarrierBitplanesButton.Location = new System.Drawing.Point(19, 449);
			this.showCarrierBitplanesButton.Margin = new System.Windows.Forms.Padding(4);
			this.showCarrierBitplanesButton.Name = "showCarrierBitplanesButton";
			this.showCarrierBitplanesButton.Size = new System.Drawing.Size(228, 38);
			this.showCarrierBitplanesButton.TabIndex = 4;
			this.showCarrierBitplanesButton.Text = "Show carrier bit planes";
			this.showCarrierBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showCarrierBitplanesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.showCarrierBitplanesButton.UseVisualStyleBackColor = true;
			// 
			// decryptMessageButton
			// 
			this.decryptMessageButton.Enabled = false;
			this.decryptMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.decryptMessageButton.Location = new System.Drawing.Point(638, 404);
			this.decryptMessageButton.Margin = new System.Windows.Forms.Padding(4);
			this.decryptMessageButton.Name = "decryptMessageButton";
			this.decryptMessageButton.Size = new System.Drawing.Size(181, 38);
			this.decryptMessageButton.TabIndex = 12;
			this.decryptMessageButton.Text = "Decrypt message";
			this.decryptMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.decryptMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.decryptMessageButton.UseVisualStyleBackColor = true;
			// 
			// encryptMessageButton
			// 
			this.encryptMessageButton.Enabled = false;
			this.encryptMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.encryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.encryptMessageButton.Location = new System.Drawing.Point(434, 404);
			this.encryptMessageButton.Margin = new System.Windows.Forms.Padding(4);
			this.encryptMessageButton.Name = "encryptMessageButton";
			this.encryptMessageButton.Size = new System.Drawing.Size(181, 38);
			this.encryptMessageButton.TabIndex = 6;
			this.encryptMessageButton.Text = "Encrypt message";
			this.encryptMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.encryptMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.encryptMessageButton.UseVisualStyleBackColor = true;
			// 
			// saveMesssageButton
			// 
			this.saveMesssageButton.Enabled = false;
			this.saveMesssageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveMesssageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveMesssageButton.Location = new System.Drawing.Point(638, 709);
			this.saveMesssageButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveMesssageButton.Name = "saveMesssageButton";
			this.saveMesssageButton.Size = new System.Drawing.Size(181, 38);
			this.saveMesssageButton.TabIndex = 14;
			this.saveMesssageButton.Text = "Save message";
			this.saveMesssageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveMesssageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveMesssageButton.UseVisualStyleBackColor = true;
			// 
			// saveStegoImageButton
			// 
			this.saveStegoImageButton.Enabled = false;
			this.saveStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveStegoImageButton.Location = new System.Drawing.Point(434, 709);
			this.saveStegoImageButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveStegoImageButton.Name = "saveStegoImageButton";
			this.saveStegoImageButton.Size = new System.Drawing.Size(181, 38);
			this.saveStegoImageButton.TabIndex = 11;
			this.saveStegoImageButton.Text = "Save stego";
			this.saveStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveStegoImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.saveStegoImageButton.UseVisualStyleBackColor = true;
			// 
			// loadMessageButton
			// 
			this.loadMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadMessageButton.Location = new System.Drawing.Point(175, 404);
			this.loadMessageButton.Margin = new System.Windows.Forms.Padding(4);
			this.loadMessageButton.Name = "loadMessageButton";
			this.loadMessageButton.Size = new System.Drawing.Size(176, 38);
			this.loadMessageButton.TabIndex = 2;
			this.loadMessageButton.Text = "Load message";
			this.loadMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loadMessageButton.UseVisualStyleBackColor = true;
			this.loadMessageButton.Click += new System.EventHandler(this.loadMessageButton_Click);
			// 
			// extractMesssageButton
			// 
			this.extractMesssageButton.Enabled = false;
			this.extractMesssageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.extractMesssageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.extractMesssageButton.Location = new System.Drawing.Point(638, 522);
			this.extractMesssageButton.Margin = new System.Windows.Forms.Padding(4);
			this.extractMesssageButton.Name = "extractMesssageButton";
			this.extractMesssageButton.Size = new System.Drawing.Size(181, 38);
			this.extractMesssageButton.TabIndex = 13;
			this.extractMesssageButton.Text = "Extract message";
			this.extractMesssageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.extractMesssageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.extractMesssageButton.UseVisualStyleBackColor = true;
			// 
			// hideMessageButton
			// 
			this.hideMessageButton.Enabled = false;
			this.hideMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hideMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.hideMessageButton.Location = new System.Drawing.Point(434, 522);
			this.hideMessageButton.Margin = new System.Windows.Forms.Padding(4);
			this.hideMessageButton.Name = "hideMessageButton";
			this.hideMessageButton.Size = new System.Drawing.Size(181, 38);
			this.hideMessageButton.TabIndex = 8;
			this.hideMessageButton.Text = "Hide message";
			this.hideMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.hideMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.hideMessageButton.UseVisualStyleBackColor = true;
			// 
			// loadCarrierButton
			// 
			this.loadCarrierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loadCarrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadCarrierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadCarrierButton.Location = new System.Drawing.Point(19, 404);
			this.loadCarrierButton.Margin = new System.Windows.Forms.Padding(4);
			this.loadCarrierButton.Name = "loadCarrierButton";
			this.loadCarrierButton.Size = new System.Drawing.Size(149, 38);
			this.loadCarrierButton.TabIndex = 1;
			this.loadCarrierButton.Text = "Load carrier";
			this.loadCarrierButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadCarrierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loadCarrierButton.UseVisualStyleBackColor = true;
			this.loadCarrierButton.Click += new System.EventHandler(this.loadCarrierButton_Click);
			// 
			// showStegoImageBitplanesButton
			// 
			this.showStegoImageBitplanesButton.Enabled = false;
			this.showStegoImageBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showStegoImageBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showStegoImageBitplanesButton.Location = new System.Drawing.Point(968, 449);
			this.showStegoImageBitplanesButton.Margin = new System.Windows.Forms.Padding(4);
			this.showStegoImageBitplanesButton.Name = "showStegoImageBitplanesButton";
			this.showStegoImageBitplanesButton.Size = new System.Drawing.Size(270, 38);
			this.showStegoImageBitplanesButton.TabIndex = 17;
			this.showStegoImageBitplanesButton.Text = "Show stego image bit planes";
			this.showStegoImageBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.showStegoImageBitplanesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.showStegoImageBitplanesButton.UseVisualStyleBackColor = true;
			// 
			// loadStegoImageButton
			// 
			this.loadStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadStegoImageButton.Location = new System.Drawing.Point(1054, 404);
			this.loadStegoImageButton.Margin = new System.Windows.Forms.Padding(4);
			this.loadStegoImageButton.Name = "loadStegoImageButton";
			this.loadStegoImageButton.Size = new System.Drawing.Size(184, 38);
			this.loadStegoImageButton.TabIndex = 16;
			this.loadStegoImageButton.Text = "Load stego image";
			this.loadStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loadStegoImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loadStegoImageButton.UseVisualStyleBackColor = true;
			this.loadStegoImageButton.Click += new System.EventHandler(this.loadStegoImageButton_Click);
			// 
			// clearCarrierAndMessageButton
			// 
			this.clearCarrierAndMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearCarrierAndMessageButton.Location = new System.Drawing.Point(359, 404);
			this.clearCarrierAndMessageButton.Margin = new System.Windows.Forms.Padding(4);
			this.clearCarrierAndMessageButton.Name = "clearCarrierAndMessageButton";
			this.clearCarrierAndMessageButton.Size = new System.Drawing.Size(36, 38);
			this.clearCarrierAndMessageButton.TabIndex = 3;
			this.clearCarrierAndMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearCarrierAndMessageButton.UseVisualStyleBackColor = true;
			this.clearCarrierAndMessageButton.Click += new System.EventHandler(this.clearCarrierAndMessageButton_Click);
			// 
			// clearStegoButton
			// 
			this.clearStegoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearStegoButton.Location = new System.Drawing.Point(1010, 404);
			this.clearStegoButton.Margin = new System.Windows.Forms.Padding(4);
			this.clearStegoButton.Name = "clearStegoButton";
			this.clearStegoButton.Size = new System.Drawing.Size(36, 38);
			this.clearStegoButton.TabIndex = 15;
			this.clearStegoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearStegoButton.UseVisualStyleBackColor = true;
			this.clearStegoButton.Click += new System.EventHandler(this.clearStegoButton_Click);
			// 
			// informationTableLayout
			// 
			this.informationTableLayout.ColumnCount = 2;
			this.informationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.2234F));
			this.informationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.7766F));
			this.informationTableLayout.Controls.Add(this.infCarrierNameLabel, 0, 0);
			this.informationTableLayout.Controls.Add(this.infCarrierSizeLabel, 0, 1);
			this.informationTableLayout.Controls.Add(this.infCarrierCapacityLabel, 0, 2);
			this.informationTableLayout.Controls.Add(this.stegoImageSizeLabel, 1, 7);
			this.informationTableLayout.Controls.Add(this.infMessageNameLabel, 0, 3);
			this.informationTableLayout.Controls.Add(this.stegoImageNameLabel, 1, 6);
			this.informationTableLayout.Controls.Add(this.infMessageSizeLabel, 0, 4);
			this.informationTableLayout.Controls.Add(this.infStegoImageSizeLabel, 0, 7);
			this.informationTableLayout.Controls.Add(this.infDetectionProbabilityLabel, 0, 5);
			this.informationTableLayout.Controls.Add(this.detectionProbabilityLabel, 1, 5);
			this.informationTableLayout.Controls.Add(this.infStegoImageNameLabel, 0, 6);
			this.informationTableLayout.Controls.Add(this.messageSizeLabel, 1, 4);
			this.informationTableLayout.Controls.Add(this.carrierNameLabel, 1, 0);
			this.informationTableLayout.Controls.Add(this.carrierCapacityLabel, 1, 2);
			this.informationTableLayout.Controls.Add(this.carrierSizeLabel, 1, 1);
			this.informationTableLayout.Controls.Add(this.messageNameLabel, 1, 3);
			this.informationTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.informationTableLayout.Location = new System.Drawing.Point(19, 495);
			this.informationTableLayout.Margin = new System.Windows.Forms.Padding(4);
			this.informationTableLayout.Name = "informationTableLayout";
			this.informationTableLayout.RowCount = 8;
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.informationTableLayout.Size = new System.Drawing.Size(376, 252);
			this.informationTableLayout.TabIndex = 0;
			// 
			// infCarrierNameLabel
			// 
			this.infCarrierNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierNameLabel.AutoSize = true;
			this.infCarrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierNameLabel.Location = new System.Drawing.Point(4, 6);
			this.infCarrierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infCarrierNameLabel.Name = "infCarrierNameLabel";
			this.infCarrierNameLabel.Size = new System.Drawing.Size(98, 18);
			this.infCarrierNameLabel.TabIndex = 0;
			this.infCarrierNameLabel.Text = "Carrier name:";
			this.infCarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infCarrierSizeLabel
			// 
			this.infCarrierSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierSizeLabel.AutoSize = true;
			this.infCarrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierSizeLabel.Location = new System.Drawing.Point(4, 37);
			this.infCarrierSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infCarrierSizeLabel.Name = "infCarrierSizeLabel";
			this.infCarrierSizeLabel.Size = new System.Drawing.Size(88, 18);
			this.infCarrierSizeLabel.TabIndex = 0;
			this.infCarrierSizeLabel.Text = "Carrier size:";
			this.infCarrierSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infCarrierCapacityLabel
			// 
			this.infCarrierCapacityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierCapacityLabel.AutoSize = true;
			this.infCarrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierCapacityLabel.Location = new System.Drawing.Point(4, 68);
			this.infCarrierCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infCarrierCapacityLabel.Name = "infCarrierCapacityLabel";
			this.infCarrierCapacityLabel.Size = new System.Drawing.Size(115, 18);
			this.infCarrierCapacityLabel.TabIndex = 0;
			this.infCarrierCapacityLabel.Text = "Carrier capacity:";
			this.infCarrierCapacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stegoImageSizeLabel
			// 
			this.stegoImageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.stegoImageSizeLabel.AutoEllipsis = true;
			this.stegoImageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stegoImageSizeLabel.Location = new System.Drawing.Point(158, 225);
			this.stegoImageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stegoImageSizeLabel.Name = "stegoImageSizeLabel";
			this.stegoImageSizeLabel.Size = new System.Drawing.Size(214, 18);
			this.stegoImageSizeLabel.TabIndex = 0;
			this.stegoImageSizeLabel.Text = "---";
			this.stegoImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infMessageNameLabel
			// 
			this.infMessageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infMessageNameLabel.AutoSize = true;
			this.infMessageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infMessageNameLabel.Location = new System.Drawing.Point(4, 99);
			this.infMessageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infMessageNameLabel.Name = "infMessageNameLabel";
			this.infMessageNameLabel.Size = new System.Drawing.Size(114, 18);
			this.infMessageNameLabel.TabIndex = 0;
			this.infMessageNameLabel.Text = "Message name:";
			this.infMessageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stegoImageNameLabel
			// 
			this.stegoImageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.stegoImageNameLabel.AutoEllipsis = true;
			this.stegoImageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stegoImageNameLabel.Location = new System.Drawing.Point(158, 192);
			this.stegoImageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stegoImageNameLabel.Name = "stegoImageNameLabel";
			this.stegoImageNameLabel.Size = new System.Drawing.Size(214, 18);
			this.stegoImageNameLabel.TabIndex = 0;
			this.stegoImageNameLabel.Text = "---";
			this.stegoImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infMessageSizeLabel
			// 
			this.infMessageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infMessageSizeLabel.AutoSize = true;
			this.infMessageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infMessageSizeLabel.Location = new System.Drawing.Point(4, 130);
			this.infMessageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infMessageSizeLabel.Name = "infMessageSizeLabel";
			this.infMessageSizeLabel.Size = new System.Drawing.Size(104, 18);
			this.infMessageSizeLabel.TabIndex = 0;
			this.infMessageSizeLabel.Text = "Message size:";
			this.infMessageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infStegoImageSizeLabel
			// 
			this.infStegoImageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infStegoImageSizeLabel.AutoSize = true;
			this.infStegoImageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infStegoImageSizeLabel.Location = new System.Drawing.Point(4, 225);
			this.infStegoImageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infStegoImageSizeLabel.Name = "infStegoImageSizeLabel";
			this.infStegoImageSizeLabel.Size = new System.Drawing.Size(126, 18);
			this.infStegoImageSizeLabel.TabIndex = 0;
			this.infStegoImageSizeLabel.Text = "Stego image size:";
			this.infStegoImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infDetectionProbabilityLabel
			// 
			this.infDetectionProbabilityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infDetectionProbabilityLabel.AutoSize = true;
			this.infDetectionProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infDetectionProbabilityLabel.Location = new System.Drawing.Point(4, 161);
			this.infDetectionProbabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infDetectionProbabilityLabel.Name = "infDetectionProbabilityLabel";
			this.infDetectionProbabilityLabel.Size = new System.Drawing.Size(145, 18);
			this.infDetectionProbabilityLabel.TabIndex = 0;
			this.infDetectionProbabilityLabel.Text = "Detection probability:";
			this.infDetectionProbabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// detectionProbabilityLabel
			// 
			this.detectionProbabilityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.detectionProbabilityLabel.AutoEllipsis = true;
			this.detectionProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.detectionProbabilityLabel.Location = new System.Drawing.Point(158, 161);
			this.detectionProbabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.detectionProbabilityLabel.Name = "detectionProbabilityLabel";
			this.detectionProbabilityLabel.Size = new System.Drawing.Size(214, 18);
			this.detectionProbabilityLabel.TabIndex = 0;
			this.detectionProbabilityLabel.Text = "---";
			this.detectionProbabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infStegoImageNameLabel
			// 
			this.infStegoImageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infStegoImageNameLabel.AutoSize = true;
			this.infStegoImageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infStegoImageNameLabel.Location = new System.Drawing.Point(4, 192);
			this.infStegoImageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infStegoImageNameLabel.Name = "infStegoImageNameLabel";
			this.infStegoImageNameLabel.Size = new System.Drawing.Size(136, 18);
			this.infStegoImageNameLabel.TabIndex = 0;
			this.infStegoImageNameLabel.Text = "Stego image name:";
			this.infStegoImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// messageSizeLabel
			// 
			this.messageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.messageSizeLabel.AutoEllipsis = true;
			this.messageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageSizeLabel.Location = new System.Drawing.Point(158, 130);
			this.messageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.messageSizeLabel.Name = "messageSizeLabel";
			this.messageSizeLabel.Size = new System.Drawing.Size(214, 18);
			this.messageSizeLabel.TabIndex = 0;
			this.messageSizeLabel.Text = "---";
			this.messageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierNameLabel
			// 
			this.carrierNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierNameLabel.AutoEllipsis = true;
			this.carrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierNameLabel.Location = new System.Drawing.Point(158, 6);
			this.carrierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carrierNameLabel.Name = "carrierNameLabel";
			this.carrierNameLabel.Size = new System.Drawing.Size(214, 18);
			this.carrierNameLabel.TabIndex = 0;
			this.carrierNameLabel.Text = "---";
			this.carrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierCapacityLabel
			// 
			this.carrierCapacityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierCapacityLabel.AutoEllipsis = true;
			this.carrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierCapacityLabel.Location = new System.Drawing.Point(158, 68);
			this.carrierCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carrierCapacityLabel.Name = "carrierCapacityLabel";
			this.carrierCapacityLabel.Size = new System.Drawing.Size(214, 18);
			this.carrierCapacityLabel.TabIndex = 0;
			this.carrierCapacityLabel.Text = "---";
			this.carrierCapacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierSizeLabel
			// 
			this.carrierSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierSizeLabel.AutoEllipsis = true;
			this.carrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierSizeLabel.Location = new System.Drawing.Point(158, 37);
			this.carrierSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carrierSizeLabel.Name = "carrierSizeLabel";
			this.carrierSizeLabel.Size = new System.Drawing.Size(214, 18);
			this.carrierSizeLabel.TabIndex = 0;
			this.carrierSizeLabel.Text = "---";
			this.carrierSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// messageNameLabel
			// 
			this.messageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.messageNameLabel.AutoEllipsis = true;
			this.messageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageNameLabel.Location = new System.Drawing.Point(158, 99);
			this.messageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.messageNameLabel.Name = "messageNameLabel";
			this.messageNameLabel.Size = new System.Drawing.Size(214, 18);
			this.messageNameLabel.TabIndex = 0;
			this.messageNameLabel.Text = "---";
			this.messageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// helpButton
			// 
			this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.helpButton.Location = new System.Drawing.Point(254, 449);
			this.helpButton.Margin = new System.Windows.Forms.Padding(4);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(141, 38);
			this.helpButton.TabIndex = 5;
			this.helpButton.Text = "About / Help";
			this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.helpButton.UseVisualStyleBackColor = true;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.logoPictureBox.ErrorImage = null;
			this.logoPictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.logo;
			this.logoPictureBox.InitialImage = null;
			this.logoPictureBox.Location = new System.Drawing.Point(980, 698);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(258, 58);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			// 
			// Mainframe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1250, 766);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.informationTableLayout);
			this.Controls.Add(this.clearStegoButton);
			this.Controls.Add(this.clearCarrierAndMessageButton);
			this.Controls.Add(this.showStegoImageBitplanesButton);
			this.Controls.Add(this.showCarrierBitplanesButton);
			this.Controls.Add(this.decryptMessageButton);
			this.Controls.Add(this.encryptMessageButton);
			this.Controls.Add(this.saveMesssageButton);
			this.Controls.Add(this.saveStegoImageButton);
			this.Controls.Add(this.encryptionKeyLabel);
			this.Controls.Add(this.encryptionKeyTextbox);
			this.Controls.Add(this.stegoKeyLabel);
			this.Controls.Add(this.stegoKeyTextbox);
			this.Controls.Add(this.loadMessageButton);
			this.Controls.Add(this.lsbsLabel);
			this.Controls.Add(this.lsbsComboBox);
			this.Controls.Add(this.extractMesssageButton);
			this.Controls.Add(this.loadStegoImageButton);
			this.Controls.Add(this.loadCarrierButton);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.stegoImageGroupBox);
			this.Controls.Add(this.hideMessageButton);
			this.Controls.Add(this.carrierImageGroupBox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1268, 813);
			this.MinimumSize = new System.Drawing.Size(1268, 813);
			this.Name = "Mainframe";
			this.Text = "HSF - Hide and Seek";
			this.Load += new System.EventHandler(this.mainframe_Load);
			this.carrierImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).EndInit();
			this.stegoImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).EndInit();
			this.informationTableLayout.ResumeLayout(false);
			this.informationTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox carrierImageGroupBox;
		private System.Windows.Forms.GroupBox stegoImageGroupBox;
		private System.Windows.Forms.PictureBox stegoImagePictureBox;
		private System.Windows.Forms.PictureBox carrierImagePictureBox;
		private System.Windows.Forms.Button hideMessageButton;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button loadCarrierButton;
		private System.Windows.Forms.Button loadStegoImageButton;
		private System.Windows.Forms.Button extractMesssageButton;
		private System.Windows.Forms.ComboBox lsbsComboBox;
		private System.Windows.Forms.Label lsbsLabel;
		private System.Windows.Forms.Button loadMessageButton;
		private System.Windows.Forms.TextBox stegoKeyTextbox;
		private System.Windows.Forms.Label stegoKeyLabel;
		private System.Windows.Forms.TextBox encryptionKeyTextbox;
		private System.Windows.Forms.Label encryptionKeyLabel;
		private System.Windows.Forms.Button saveStegoImageButton;
		private System.Windows.Forms.Button saveMesssageButton;
		private System.Windows.Forms.Button encryptMessageButton;
		private System.Windows.Forms.Button decryptMessageButton;
		private System.Windows.Forms.Button showCarrierBitplanesButton;
		private System.Windows.Forms.Button showStegoImageBitplanesButton;
		private System.Windows.Forms.Button clearCarrierAndMessageButton;
		private System.Windows.Forms.Button clearStegoButton;
		private System.Windows.Forms.TableLayoutPanel informationTableLayout;
		private System.Windows.Forms.Label infCarrierNameLabel;
		private System.Windows.Forms.Label infCarrierSizeLabel;
		private System.Windows.Forms.Label infCarrierCapacityLabel;
		private System.Windows.Forms.Label stegoImageSizeLabel;
		private System.Windows.Forms.Label infMessageNameLabel;
		private System.Windows.Forms.Label stegoImageNameLabel;
		private System.Windows.Forms.Label infMessageSizeLabel;
		private System.Windows.Forms.Label infStegoImageSizeLabel;
		private System.Windows.Forms.Label infDetectionProbabilityLabel;
		private System.Windows.Forms.Label detectionProbabilityLabel;
		private System.Windows.Forms.Label infStegoImageNameLabel;
		private System.Windows.Forms.Label messageSizeLabel;
		private System.Windows.Forms.Label carrierNameLabel;
		private System.Windows.Forms.Label carrierCapacityLabel;
		private System.Windows.Forms.Label carrierSizeLabel;
		private System.Windows.Forms.Label messageNameLabel;
		private System.Windows.Forms.Button helpButton;
	}
}

