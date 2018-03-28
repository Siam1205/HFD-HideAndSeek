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
			this.bppComboBox = new System.Windows.Forms.ComboBox();
			this.lsbsLabel = new System.Windows.Forms.Label();
			this.stegoPasswordTextbox = new System.Windows.Forms.TextBox();
			this.stegoPasswordLabel = new System.Windows.Forms.Label();
			this.encryptionKeyTextbox = new System.Windows.Forms.TextBox();
			this.encryptionKeyLabel = new System.Windows.Forms.Label();
			this.showCarrierBitplanesButton = new System.Windows.Forms.Button();
			this.decryptMessageButton = new System.Windows.Forms.Button();
			this.encryptMessageButton = new System.Windows.Forms.Button();
			this.saveMessageButton = new System.Windows.Forms.Button();
			this.saveStegoImageButton = new System.Windows.Forms.Button();
			this.loadMessageButton = new System.Windows.Forms.Button();
			this.extractMessageButton = new System.Windows.Forms.Button();
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
			this.infCarrierRatingLabel = new System.Windows.Forms.Label();
			this.carrierRatingLabel = new System.Windows.Forms.Label();
			this.infStegoImageNameLabel = new System.Windows.Forms.Label();
			this.messageSizeLabel = new System.Windows.Forms.Label();
			this.carrierNameLabel = new System.Windows.Forms.Label();
			this.carrierCapacityLabel = new System.Windows.Forms.Label();
			this.carrierSizeLabel = new System.Windows.Forms.Label();
			this.messageNameLabel = new System.Windows.Forms.Label();
			this.helpButton = new System.Windows.Forms.Button();
			this.radioTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.pixelFirstRadio = new System.Windows.Forms.RadioButton();
			this.bitPlaneFirstRadio = new System.Windows.Forms.RadioButton();
			this.rateButton = new System.Windows.Forms.Button();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.carrierImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).BeginInit();
			this.stegoImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).BeginInit();
			this.informationTableLayout.SuspendLayout();
			this.radioTableLayout.SuspendLayout();
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
			this.carrierImageGroupBox.Location = new System.Drawing.Point(12, 9);
			this.carrierImageGroupBox.Name = "carrierImageGroupBox";
			this.carrierImageGroupBox.Size = new System.Drawing.Size(480, 300);
			this.carrierImageGroupBox.TabIndex = 0;
			this.carrierImageGroupBox.TabStop = false;
			this.carrierImageGroupBox.Text = "Carrier image";
			// 
			// carrierImagePictureBox
			// 
			this.carrierImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carrierImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carrierImagePictureBox.Location = new System.Drawing.Point(3, 22);
			this.carrierImagePictureBox.Name = "carrierImagePictureBox";
			this.carrierImagePictureBox.Size = new System.Drawing.Size(474, 275);
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
			this.stegoImageGroupBox.Location = new System.Drawing.Point(510, 9);
			this.stegoImageGroupBox.Name = "stegoImageGroupBox";
			this.stegoImageGroupBox.Size = new System.Drawing.Size(480, 300);
			this.stegoImageGroupBox.TabIndex = 0;
			this.stegoImageGroupBox.TabStop = false;
			this.stegoImageGroupBox.Text = "Stego image";
			// 
			// stegoImagePictureBox
			// 
			this.stegoImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.stegoImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stegoImagePictureBox.Location = new System.Drawing.Point(3, 22);
			this.stegoImagePictureBox.Name = "stegoImagePictureBox";
			this.stegoImagePictureBox.Size = new System.Drawing.Size(474, 275);
			this.stegoImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.stegoImagePictureBox.TabIndex = 0;
			this.stegoImagePictureBox.TabStop = false;
			// 
			// bppComboBox
			// 
			this.bppComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bppComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.bppComboBox.FormattingEnabled = true;
			this.bppComboBox.Items.AddRange(new object[] {
            "3 bpp",
            "6 bpp",
            "9 bpp",
            "12 bpp",
            "15 bpp",
            "18 bpp",
            "21 bpp"});
			this.bppComboBox.Location = new System.Drawing.Point(430, 467);
			this.bppComboBox.Name = "bppComboBox";
			this.bppComboBox.Size = new System.Drawing.Size(146, 24);
			this.bppComboBox.TabIndex = 10;
			this.bppComboBox.SelectedIndexChanged += new System.EventHandler(this.bppComboBox_SelectedIndexChanged);
			// 
			// lsbsLabel
			// 
			this.lsbsLabel.AutoSize = true;
			this.lsbsLabel.Location = new System.Drawing.Point(428, 451);
			this.lsbsLabel.Name = "lsbsLabel";
			this.lsbsLabel.Size = new System.Drawing.Size(96, 13);
			this.lsbsLabel.TabIndex = 8;
			this.lsbsLabel.Text = "Bits per pixel (bpp):";
			// 
			// stegoPasswordTextbox
			// 
			this.stegoPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.stegoPasswordTextbox.Location = new System.Drawing.Point(510, 419);
			this.stegoPasswordTextbox.Name = "stegoPasswordTextbox";
			this.stegoPasswordTextbox.Size = new System.Drawing.Size(146, 22);
			this.stegoPasswordTextbox.TabIndex = 9;
			// 
			// stegoPasswordLabel
			// 
			this.stegoPasswordLabel.AutoSize = true;
			this.stegoPasswordLabel.Location = new System.Drawing.Point(510, 402);
			this.stegoPasswordLabel.Name = "stegoPasswordLabel";
			this.stegoPasswordLabel.Size = new System.Drawing.Size(86, 13);
			this.stegoPasswordLabel.TabIndex = 0;
			this.stegoPasswordLabel.Text = "Stego password:";
			// 
			// encryptionKeyTextbox
			// 
			this.encryptionKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.encryptionKeyTextbox.Location = new System.Drawing.Point(347, 419);
			this.encryptionKeyTextbox.Name = "encryptionKeyTextbox";
			this.encryptionKeyTextbox.Size = new System.Drawing.Size(146, 22);
			this.encryptionKeyTextbox.TabIndex = 7;
			this.encryptionKeyTextbox.TextChanged += new System.EventHandler(this.encryptionKeyTextbox_TextChanged);
			// 
			// encryptionKeyLabel
			// 
			this.encryptionKeyLabel.AutoSize = true;
			this.encryptionKeyLabel.Location = new System.Drawing.Point(347, 402);
			this.encryptionKeyLabel.Name = "encryptionKeyLabel";
			this.encryptionKeyLabel.Size = new System.Drawing.Size(80, 13);
			this.encryptionKeyLabel.TabIndex = 0;
			this.encryptionKeyLabel.Text = "Encryption key:";
			// 
			// showCarrierBitplanesButton
			// 
			this.showCarrierBitplanesButton.Enabled = false;
			this.showCarrierBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showCarrierBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showCarrierBitplanesButton.Location = new System.Drawing.Point(15, 359);
			this.showCarrierBitplanesButton.Name = "showCarrierBitplanesButton";
			this.showCarrierBitplanesButton.Size = new System.Drawing.Size(182, 30);
			this.showCarrierBitplanesButton.TabIndex = 4;
			this.showCarrierBitplanesButton.Text = "Show carrier bit planes";
			this.showCarrierBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showCarrierBitplanesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.showCarrierBitplanesButton.UseVisualStyleBackColor = true;
			this.showCarrierBitplanesButton.Click += new System.EventHandler(this.showCarrierBitplanesButton_Click);
			// 
			// decryptMessageButton
			// 
			this.decryptMessageButton.Enabled = false;
			this.decryptMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.decryptMessageButton.Location = new System.Drawing.Point(347, 359);
			this.decryptMessageButton.Name = "decryptMessageButton";
			this.decryptMessageButton.Size = new System.Drawing.Size(145, 30);
			this.decryptMessageButton.TabIndex = 12;
			this.decryptMessageButton.Text = "Decrypt message";
			this.decryptMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.decryptMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.decryptMessageButton.UseVisualStyleBackColor = true;
			this.decryptMessageButton.Click += new System.EventHandler(this.decryptMessageButton_Click);
			// 
			// encryptMessageButton
			// 
			this.encryptMessageButton.Enabled = false;
			this.encryptMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.encryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.encryptMessageButton.Location = new System.Drawing.Point(347, 323);
			this.encryptMessageButton.Name = "encryptMessageButton";
			this.encryptMessageButton.Size = new System.Drawing.Size(145, 30);
			this.encryptMessageButton.TabIndex = 6;
			this.encryptMessageButton.Text = "Encrypt message";
			this.encryptMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.encryptMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.encryptMessageButton.UseVisualStyleBackColor = true;
			this.encryptMessageButton.Click += new System.EventHandler(this.encryptMessageButton_Click);
			// 
			// saveMessageButton
			// 
			this.saveMessageButton.Enabled = false;
			this.saveMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveMessageButton.Location = new System.Drawing.Point(510, 567);
			this.saveMessageButton.Name = "saveMessageButton";
			this.saveMessageButton.Size = new System.Drawing.Size(145, 30);
			this.saveMessageButton.TabIndex = 14;
			this.saveMessageButton.Text = "Save message";
			this.saveMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveMessageButton.UseVisualStyleBackColor = true;
			this.saveMessageButton.Click += new System.EventHandler(this.saveMessageButton_Click);
			// 
			// saveStegoImageButton
			// 
			this.saveStegoImageButton.Enabled = false;
			this.saveStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveStegoImageButton.Location = new System.Drawing.Point(347, 567);
			this.saveStegoImageButton.Name = "saveStegoImageButton";
			this.saveStegoImageButton.Size = new System.Drawing.Size(145, 30);
			this.saveStegoImageButton.TabIndex = 11;
			this.saveStegoImageButton.Text = "Save stego image";
			this.saveStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveStegoImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.saveStegoImageButton.UseVisualStyleBackColor = true;
			this.saveStegoImageButton.Click += new System.EventHandler(this.saveStegoImageButton_Click);
			// 
			// loadMessageButton
			// 
			this.loadMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadMessageButton.Location = new System.Drawing.Point(140, 323);
			this.loadMessageButton.Name = "loadMessageButton";
			this.loadMessageButton.Size = new System.Drawing.Size(141, 30);
			this.loadMessageButton.TabIndex = 2;
			this.loadMessageButton.Text = "Load message";
			this.loadMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loadMessageButton.UseVisualStyleBackColor = true;
			this.loadMessageButton.Click += new System.EventHandler(this.loadMessageButton_Click);
			// 
			// extractMessageButton
			// 
			this.extractMessageButton.Enabled = false;
			this.extractMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.extractMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.extractMessageButton.Location = new System.Drawing.Point(510, 359);
			this.extractMessageButton.Name = "extractMessageButton";
			this.extractMessageButton.Size = new System.Drawing.Size(145, 30);
			this.extractMessageButton.TabIndex = 13;
			this.extractMessageButton.Text = "Extract message";
			this.extractMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.extractMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.extractMessageButton.UseVisualStyleBackColor = true;
			this.extractMessageButton.Click += new System.EventHandler(this.extractMesssageButton_Click);
			// 
			// hideMessageButton
			// 
			this.hideMessageButton.Enabled = false;
			this.hideMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hideMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.hideMessageButton.Location = new System.Drawing.Point(510, 323);
			this.hideMessageButton.Name = "hideMessageButton";
			this.hideMessageButton.Size = new System.Drawing.Size(145, 30);
			this.hideMessageButton.TabIndex = 8;
			this.hideMessageButton.Text = "Hide message";
			this.hideMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.hideMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.hideMessageButton.UseVisualStyleBackColor = true;
			this.hideMessageButton.Click += new System.EventHandler(this.hideMessageButton_Click);
			// 
			// loadCarrierButton
			// 
			this.loadCarrierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loadCarrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadCarrierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadCarrierButton.Location = new System.Drawing.Point(15, 323);
			this.loadCarrierButton.Name = "loadCarrierButton";
			this.loadCarrierButton.Size = new System.Drawing.Size(119, 30);
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
			this.showStegoImageBitplanesButton.Location = new System.Drawing.Point(687, 359);
			this.showStegoImageBitplanesButton.Name = "showStegoImageBitplanesButton";
			this.showStegoImageBitplanesButton.Size = new System.Drawing.Size(216, 30);
			this.showStegoImageBitplanesButton.TabIndex = 17;
			this.showStegoImageBitplanesButton.Text = "Show stego image bit planes";
			this.showStegoImageBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showStegoImageBitplanesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.showStegoImageBitplanesButton.UseVisualStyleBackColor = true;
			this.showStegoImageBitplanesButton.Click += new System.EventHandler(this.showStegoImageBitplanesButton_Click);
			// 
			// loadStegoImageButton
			// 
			this.loadStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadStegoImageButton.Location = new System.Drawing.Point(687, 323);
			this.loadStegoImageButton.Name = "loadStegoImageButton";
			this.loadStegoImageButton.Size = new System.Drawing.Size(181, 30);
			this.loadStegoImageButton.TabIndex = 16;
			this.loadStegoImageButton.Text = "Load stego image";
			this.loadStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadStegoImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loadStegoImageButton.UseVisualStyleBackColor = true;
			this.loadStegoImageButton.Click += new System.EventHandler(this.loadStegoImageButton_Click);
			// 
			// clearCarrierAndMessageButton
			// 
			this.clearCarrierAndMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearCarrierAndMessageButton.Location = new System.Drawing.Point(287, 323);
			this.clearCarrierAndMessageButton.Name = "clearCarrierAndMessageButton";
			this.clearCarrierAndMessageButton.Size = new System.Drawing.Size(29, 30);
			this.clearCarrierAndMessageButton.TabIndex = 3;
			this.clearCarrierAndMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearCarrierAndMessageButton.UseVisualStyleBackColor = true;
			this.clearCarrierAndMessageButton.Click += new System.EventHandler(this.clearCarrierAndMessageButton_Click);
			// 
			// clearStegoButton
			// 
			this.clearStegoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearStegoButton.Location = new System.Drawing.Point(874, 323);
			this.clearStegoButton.Name = "clearStegoButton";
			this.clearStegoButton.Size = new System.Drawing.Size(29, 30);
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
			this.informationTableLayout.Controls.Add(this.infCarrierRatingLabel, 0, 5);
			this.informationTableLayout.Controls.Add(this.carrierRatingLabel, 1, 5);
			this.informationTableLayout.Controls.Add(this.infStegoImageNameLabel, 0, 6);
			this.informationTableLayout.Controls.Add(this.messageSizeLabel, 1, 4);
			this.informationTableLayout.Controls.Add(this.carrierNameLabel, 1, 0);
			this.informationTableLayout.Controls.Add(this.carrierCapacityLabel, 1, 2);
			this.informationTableLayout.Controls.Add(this.carrierSizeLabel, 1, 1);
			this.informationTableLayout.Controls.Add(this.messageNameLabel, 1, 3);
			this.informationTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.informationTableLayout.Location = new System.Drawing.Point(15, 396);
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
			this.informationTableLayout.Size = new System.Drawing.Size(301, 202);
			this.informationTableLayout.TabIndex = 0;
			// 
			// infCarrierNameLabel
			// 
			this.infCarrierNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierNameLabel.AutoSize = true;
			this.infCarrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierNameLabel.Location = new System.Drawing.Point(3, 5);
			this.infCarrierNameLabel.Name = "infCarrierNameLabel";
			this.infCarrierNameLabel.Size = new System.Drawing.Size(82, 15);
			this.infCarrierNameLabel.TabIndex = 0;
			this.infCarrierNameLabel.Text = "Carrier name:";
			this.infCarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infCarrierSizeLabel
			// 
			this.infCarrierSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierSizeLabel.AutoSize = true;
			this.infCarrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierSizeLabel.Location = new System.Drawing.Point(3, 30);
			this.infCarrierSizeLabel.Name = "infCarrierSizeLabel";
			this.infCarrierSizeLabel.Size = new System.Drawing.Size(72, 15);
			this.infCarrierSizeLabel.TabIndex = 0;
			this.infCarrierSizeLabel.Text = "Carrier size:";
			this.infCarrierSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infCarrierCapacityLabel
			// 
			this.infCarrierCapacityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierCapacityLabel.AutoSize = true;
			this.infCarrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierCapacityLabel.Location = new System.Drawing.Point(3, 55);
			this.infCarrierCapacityLabel.Name = "infCarrierCapacityLabel";
			this.infCarrierCapacityLabel.Size = new System.Drawing.Size(94, 15);
			this.infCarrierCapacityLabel.TabIndex = 0;
			this.infCarrierCapacityLabel.Text = "Carrier capacity:";
			this.infCarrierCapacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stegoImageSizeLabel
			// 
			this.stegoImageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.stegoImageSizeLabel.AutoEllipsis = true;
			this.stegoImageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stegoImageSizeLabel.Location = new System.Drawing.Point(127, 177);
			this.stegoImageSizeLabel.Name = "stegoImageSizeLabel";
			this.stegoImageSizeLabel.Size = new System.Drawing.Size(171, 22);
			this.stegoImageSizeLabel.TabIndex = 0;
			this.stegoImageSizeLabel.Text = "---";
			this.stegoImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infMessageNameLabel
			// 
			this.infMessageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infMessageNameLabel.AutoSize = true;
			this.infMessageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infMessageNameLabel.Location = new System.Drawing.Point(3, 80);
			this.infMessageNameLabel.Name = "infMessageNameLabel";
			this.infMessageNameLabel.Size = new System.Drawing.Size(96, 15);
			this.infMessageNameLabel.TabIndex = 0;
			this.infMessageNameLabel.Text = "Message name:";
			this.infMessageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stegoImageNameLabel
			// 
			this.stegoImageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.stegoImageNameLabel.AutoEllipsis = true;
			this.stegoImageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stegoImageNameLabel.Location = new System.Drawing.Point(127, 151);
			this.stegoImageNameLabel.Name = "stegoImageNameLabel";
			this.stegoImageNameLabel.Size = new System.Drawing.Size(171, 22);
			this.stegoImageNameLabel.TabIndex = 0;
			this.stegoImageNameLabel.Text = "---";
			this.stegoImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infMessageSizeLabel
			// 
			this.infMessageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infMessageSizeLabel.AutoSize = true;
			this.infMessageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infMessageSizeLabel.Location = new System.Drawing.Point(3, 105);
			this.infMessageSizeLabel.Name = "infMessageSizeLabel";
			this.infMessageSizeLabel.Size = new System.Drawing.Size(86, 15);
			this.infMessageSizeLabel.TabIndex = 0;
			this.infMessageSizeLabel.Text = "Message size:";
			this.infMessageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infStegoImageSizeLabel
			// 
			this.infStegoImageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infStegoImageSizeLabel.AutoSize = true;
			this.infStegoImageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infStegoImageSizeLabel.Location = new System.Drawing.Point(3, 181);
			this.infStegoImageSizeLabel.Name = "infStegoImageSizeLabel";
			this.infStegoImageSizeLabel.Size = new System.Drawing.Size(105, 15);
			this.infStegoImageSizeLabel.TabIndex = 0;
			this.infStegoImageSizeLabel.Text = "Stego image size:";
			this.infStegoImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infCarrierRatingLabel
			// 
			this.infCarrierRatingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infCarrierRatingLabel.AutoSize = true;
			this.infCarrierRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infCarrierRatingLabel.Location = new System.Drawing.Point(3, 130);
			this.infCarrierRatingLabel.Name = "infCarrierRatingLabel";
			this.infCarrierRatingLabel.Size = new System.Drawing.Size(81, 15);
			this.infCarrierRatingLabel.TabIndex = 0;
			this.infCarrierRatingLabel.Text = "Carrier rating:";
			this.infCarrierRatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierRatingLabel
			// 
			this.carrierRatingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierRatingLabel.AutoEllipsis = true;
			this.carrierRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierRatingLabel.Location = new System.Drawing.Point(127, 126);
			this.carrierRatingLabel.Name = "carrierRatingLabel";
			this.carrierRatingLabel.Size = new System.Drawing.Size(171, 22);
			this.carrierRatingLabel.TabIndex = 0;
			this.carrierRatingLabel.Text = "---";
			this.carrierRatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// infStegoImageNameLabel
			// 
			this.infStegoImageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.infStegoImageNameLabel.AutoSize = true;
			this.infStegoImageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infStegoImageNameLabel.Location = new System.Drawing.Point(3, 155);
			this.infStegoImageNameLabel.Name = "infStegoImageNameLabel";
			this.infStegoImageNameLabel.Size = new System.Drawing.Size(115, 15);
			this.infStegoImageNameLabel.TabIndex = 0;
			this.infStegoImageNameLabel.Text = "Stego image name:";
			this.infStegoImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// messageSizeLabel
			// 
			this.messageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.messageSizeLabel.AutoEllipsis = true;
			this.messageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageSizeLabel.Location = new System.Drawing.Point(127, 101);
			this.messageSizeLabel.Name = "messageSizeLabel";
			this.messageSizeLabel.Size = new System.Drawing.Size(171, 22);
			this.messageSizeLabel.TabIndex = 0;
			this.messageSizeLabel.Text = "---";
			this.messageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierNameLabel
			// 
			this.carrierNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierNameLabel.AutoEllipsis = true;
			this.carrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierNameLabel.Location = new System.Drawing.Point(127, 1);
			this.carrierNameLabel.Name = "carrierNameLabel";
			this.carrierNameLabel.Size = new System.Drawing.Size(171, 22);
			this.carrierNameLabel.TabIndex = 0;
			this.carrierNameLabel.Text = "---";
			this.carrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierCapacityLabel
			// 
			this.carrierCapacityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierCapacityLabel.AutoEllipsis = true;
			this.carrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierCapacityLabel.Location = new System.Drawing.Point(127, 51);
			this.carrierCapacityLabel.Name = "carrierCapacityLabel";
			this.carrierCapacityLabel.Size = new System.Drawing.Size(171, 22);
			this.carrierCapacityLabel.TabIndex = 0;
			this.carrierCapacityLabel.Text = "---";
			this.carrierCapacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierSizeLabel
			// 
			this.carrierSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.carrierSizeLabel.AutoEllipsis = true;
			this.carrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carrierSizeLabel.Location = new System.Drawing.Point(127, 26);
			this.carrierSizeLabel.Name = "carrierSizeLabel";
			this.carrierSizeLabel.Size = new System.Drawing.Size(171, 22);
			this.carrierSizeLabel.TabIndex = 0;
			this.carrierSizeLabel.Text = "---";
			this.carrierSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// messageNameLabel
			// 
			this.messageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.messageNameLabel.AutoEllipsis = true;
			this.messageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageNameLabel.Location = new System.Drawing.Point(127, 76);
			this.messageNameLabel.Name = "messageNameLabel";
			this.messageNameLabel.Size = new System.Drawing.Size(171, 22);
			this.messageNameLabel.TabIndex = 0;
			this.messageNameLabel.Text = "---";
			this.messageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// helpButton
			// 
			this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpButton.Location = new System.Drawing.Point(934, 323);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(53, 66);
			this.helpButton.TabIndex = 5;
			this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.helpButton.UseVisualStyleBackColor = true;
			this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// radioTableLayout
			// 
			this.radioTableLayout.ColumnCount = 1;
			this.radioTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.radioTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.radioTableLayout.Controls.Add(this.pixelFirstRadio, 0, 1);
			this.radioTableLayout.Controls.Add(this.bitPlaneFirstRadio, 0, 0);
			this.radioTableLayout.Location = new System.Drawing.Point(430, 495);
			this.radioTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.radioTableLayout.Name = "radioTableLayout";
			this.radioTableLayout.RowCount = 2;
			this.radioTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.radioTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.radioTableLayout.Size = new System.Drawing.Size(145, 51);
			this.radioTableLayout.TabIndex = 20;
			// 
			// pixelFirstRadio
			// 
			this.pixelFirstRadio.AutoSize = true;
			this.pixelFirstRadio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pixelFirstRadio.Location = new System.Drawing.Point(2, 27);
			this.pixelFirstRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pixelFirstRadio.Name = "pixelFirstRadio";
			this.pixelFirstRadio.Size = new System.Drawing.Size(141, 22);
			this.pixelFirstRadio.TabIndex = 21;
			this.pixelFirstRadio.Text = "Pixels first-mode";
			this.pixelFirstRadio.UseVisualStyleBackColor = true;
			// 
			// bitPlaneFirstRadio
			// 
			this.bitPlaneFirstRadio.AutoSize = true;
			this.bitPlaneFirstRadio.Checked = true;
			this.bitPlaneFirstRadio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bitPlaneFirstRadio.Location = new System.Drawing.Point(2, 2);
			this.bitPlaneFirstRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bitPlaneFirstRadio.Name = "bitPlaneFirstRadio";
			this.bitPlaneFirstRadio.Size = new System.Drawing.Size(141, 21);
			this.bitPlaneFirstRadio.TabIndex = 22;
			this.bitPlaneFirstRadio.TabStop = true;
			this.bitPlaneFirstRadio.Text = "Bit planes first-mode";
			this.bitPlaneFirstRadio.UseVisualStyleBackColor = true;
			// 
			// rateButton
			// 
			this.rateButton.Enabled = false;
			this.rateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rateButton.Location = new System.Drawing.Point(204, 359);
			this.rateButton.Name = "rateButton";
			this.rateButton.Size = new System.Drawing.Size(112, 30);
			this.rateButton.TabIndex = 21;
			this.rateButton.Text = "Rate carrier";
			this.rateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rateButton.UseVisualStyleBackColor = true;
			this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.logoPictureBox.ErrorImage = null;
			this.logoPictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.logo;
			this.logoPictureBox.InitialImage = null;
			this.logoPictureBox.Location = new System.Drawing.Point(784, 558);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(206, 46);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			// 
			// Mainframe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1002, 619);
			this.Controls.Add(this.rateButton);
			this.Controls.Add(this.radioTableLayout);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.informationTableLayout);
			this.Controls.Add(this.clearStegoButton);
			this.Controls.Add(this.clearCarrierAndMessageButton);
			this.Controls.Add(this.showStegoImageBitplanesButton);
			this.Controls.Add(this.showCarrierBitplanesButton);
			this.Controls.Add(this.decryptMessageButton);
			this.Controls.Add(this.encryptMessageButton);
			this.Controls.Add(this.saveMessageButton);
			this.Controls.Add(this.saveStegoImageButton);
			this.Controls.Add(this.encryptionKeyLabel);
			this.Controls.Add(this.encryptionKeyTextbox);
			this.Controls.Add(this.stegoPasswordLabel);
			this.Controls.Add(this.stegoPasswordTextbox);
			this.Controls.Add(this.loadMessageButton);
			this.Controls.Add(this.lsbsLabel);
			this.Controls.Add(this.bppComboBox);
			this.Controls.Add(this.extractMessageButton);
			this.Controls.Add(this.loadStegoImageButton);
			this.Controls.Add(this.loadCarrierButton);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.stegoImageGroupBox);
			this.Controls.Add(this.hideMessageButton);
			this.Controls.Add(this.carrierImageGroupBox);
			this.MaximumSize = new System.Drawing.Size(1018, 658);
			this.MinimumSize = new System.Drawing.Size(1018, 658);
			this.Name = "Mainframe";
			this.Text = "HSF - Hide and Seek";
			this.Load += new System.EventHandler(this.mainframe_Load);
			this.carrierImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).EndInit();
			this.stegoImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).EndInit();
			this.informationTableLayout.ResumeLayout(false);
			this.informationTableLayout.PerformLayout();
			this.radioTableLayout.ResumeLayout(false);
			this.radioTableLayout.PerformLayout();
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
		private System.Windows.Forms.Button extractMessageButton;
		private System.Windows.Forms.ComboBox bppComboBox;
		private System.Windows.Forms.Label lsbsLabel;
		private System.Windows.Forms.Button loadMessageButton;
		private System.Windows.Forms.TextBox stegoPasswordTextbox;
		private System.Windows.Forms.Label stegoPasswordLabel;
		private System.Windows.Forms.TextBox encryptionKeyTextbox;
		private System.Windows.Forms.Label encryptionKeyLabel;
		private System.Windows.Forms.Button saveStegoImageButton;
		private System.Windows.Forms.Button saveMessageButton;
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
		private System.Windows.Forms.Label infMessageNameLabel;
		private System.Windows.Forms.Label infMessageSizeLabel;
		private System.Windows.Forms.Label infCarrierRatingLabel;
		private System.Windows.Forms.Label carrierRatingLabel;
		private System.Windows.Forms.Label messageSizeLabel;
		private System.Windows.Forms.Label carrierNameLabel;
		private System.Windows.Forms.Label carrierCapacityLabel;
		private System.Windows.Forms.Label carrierSizeLabel;
		private System.Windows.Forms.Label messageNameLabel;
		private System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.TableLayoutPanel radioTableLayout;
		private System.Windows.Forms.RadioButton pixelFirstRadio;
		private System.Windows.Forms.RadioButton bitPlaneFirstRadio;
		private System.Windows.Forms.Label stegoImageSizeLabel;
		private System.Windows.Forms.Label stegoImageNameLabel;
		private System.Windows.Forms.Label infStegoImageSizeLabel;
		private System.Windows.Forms.Label infStegoImageNameLabel;
		private System.Windows.Forms.Button rateButton;
	}
}

