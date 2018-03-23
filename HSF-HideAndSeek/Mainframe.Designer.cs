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
			this.stegoImageGroupBox = new System.Windows.Forms.GroupBox();
			this.lsbsComboBox = new System.Windows.Forms.ComboBox();
			this.lsbsLabel = new System.Windows.Forms.Label();
			this.infCarrierCapacityLabel = new System.Windows.Forms.Label();
			this.infDetectionLabel = new System.Windows.Forms.Label();
			this.infMessageSizeLabel = new System.Windows.Forms.Label();
			this.infCarrierSizeLabel = new System.Windows.Forms.Label();
			this.infCarrierNameLabel = new System.Windows.Forms.Label();
			this.infMessageNameLabel = new System.Windows.Forms.Label();
			this.stegoKeyTextbox = new System.Windows.Forms.TextBox();
			this.stegoKeyLabel = new System.Windows.Forms.Label();
			this.encryptionKeyTextbox = new System.Windows.Forms.TextBox();
			this.encryptionKeyLabel = new System.Windows.Forms.Label();
			this.carrierNameLabel = new System.Windows.Forms.Label();
			this.carrierSizeLabel = new System.Windows.Forms.Label();
			this.carrierCapacityLabel = new System.Windows.Forms.Label();
			this.messageNameLabel = new System.Windows.Forms.Label();
			this.messageSizeLabel = new System.Windows.Forms.Label();
			this.detectionLabel = new System.Windows.Forms.Label();
			this.showCarrierBitplanesButton = new System.Windows.Forms.Button();
			this.decryptMessageButton = new System.Windows.Forms.Button();
			this.encryptMessageButton = new System.Windows.Forms.Button();
			this.saveMesssageButton = new System.Windows.Forms.Button();
			this.saveStegoImageButton = new System.Windows.Forms.Button();
			this.loadMessageButton = new System.Windows.Forms.Button();
			this.extractMesssageButton = new System.Windows.Forms.Button();
			this.hideMessageButton = new System.Windows.Forms.Button();
			this.infStegoNameLabel = new System.Windows.Forms.Label();
			this.infStegoSizeLabel = new System.Windows.Forms.Label();
			this.stegoNameLabel = new System.Windows.Forms.Label();
			this.stegoSizeLabel = new System.Windows.Forms.Label();
			this.loadCarrierButton = new System.Windows.Forms.Button();
			this.showStegoImageBitplanesButton = new System.Windows.Forms.Button();
			this.loadStegoImageButton = new System.Windows.Forms.Button();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.stegoImagePictureBox = new System.Windows.Forms.PictureBox();
			this.carrierImagePictureBox = new System.Windows.Forms.PictureBox();
			this.clearCarrierAndMessageButton = new System.Windows.Forms.Button();
			this.clearStegoButton = new System.Windows.Forms.Button();
			this.carrierImageGroupBox.SuspendLayout();
			this.stegoImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).BeginInit();
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
			this.lsbsComboBox.Location = new System.Drawing.Point(438, 526);
			this.lsbsComboBox.Name = "lsbsComboBox";
			this.lsbsComboBox.Size = new System.Drawing.Size(131, 24);
			this.lsbsComboBox.TabIndex = 3;
			// 
			// lsbsLabel
			// 
			this.lsbsLabel.AutoSize = true;
			this.lsbsLabel.Location = new System.Drawing.Point(435, 510);
			this.lsbsLabel.Name = "lsbsLabel";
			this.lsbsLabel.Size = new System.Drawing.Size(96, 13);
			this.lsbsLabel.TabIndex = 8;
			this.lsbsLabel.Text = "Bits per pixel (bpp):";
			// 
			// infCarrierCapacityLabel
			// 
			this.infCarrierCapacityLabel.AutoSize = true;
			this.infCarrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infCarrierCapacityLabel.Location = new System.Drawing.Point(12, 472);
			this.infCarrierCapacityLabel.Name = "infCarrierCapacityLabel";
			this.infCarrierCapacityLabel.Size = new System.Drawing.Size(122, 20);
			this.infCarrierCapacityLabel.TabIndex = 10;
			this.infCarrierCapacityLabel.Text = "Carrier capacity:";
			// 
			// infDetectionLabel
			// 
			this.infDetectionLabel.AutoSize = true;
			this.infDetectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infDetectionLabel.Location = new System.Drawing.Point(12, 552);
			this.infDetectionLabel.Name = "infDetectionLabel";
			this.infDetectionLabel.Size = new System.Drawing.Size(157, 20);
			this.infDetectionLabel.TabIndex = 11;
			this.infDetectionLabel.Text = "Detection probability:";
			// 
			// infMessageSizeLabel
			// 
			this.infMessageSizeLabel.AutoSize = true;
			this.infMessageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infMessageSizeLabel.Location = new System.Drawing.Point(12, 525);
			this.infMessageSizeLabel.Name = "infMessageSizeLabel";
			this.infMessageSizeLabel.Size = new System.Drawing.Size(110, 20);
			this.infMessageSizeLabel.TabIndex = 12;
			this.infMessageSizeLabel.Text = "Message size:";
			// 
			// infCarrierSizeLabel
			// 
			this.infCarrierSizeLabel.AutoSize = true;
			this.infCarrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infCarrierSizeLabel.Location = new System.Drawing.Point(12, 445);
			this.infCarrierSizeLabel.Name = "infCarrierSizeLabel";
			this.infCarrierSizeLabel.Size = new System.Drawing.Size(92, 20);
			this.infCarrierSizeLabel.TabIndex = 13;
			this.infCarrierSizeLabel.Text = "Carrier size:";
			// 
			// infCarrierNameLabel
			// 
			this.infCarrierNameLabel.AutoSize = true;
			this.infCarrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infCarrierNameLabel.Location = new System.Drawing.Point(12, 418);
			this.infCarrierNameLabel.Name = "infCarrierNameLabel";
			this.infCarrierNameLabel.Size = new System.Drawing.Size(104, 20);
			this.infCarrierNameLabel.TabIndex = 14;
			this.infCarrierNameLabel.Text = "Carrier name:";
			// 
			// infMessageNameLabel
			// 
			this.infMessageNameLabel.AutoSize = true;
			this.infMessageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infMessageNameLabel.Location = new System.Drawing.Point(12, 498);
			this.infMessageNameLabel.Name = "infMessageNameLabel";
			this.infMessageNameLabel.Size = new System.Drawing.Size(122, 20);
			this.infMessageNameLabel.TabIndex = 15;
			this.infMessageNameLabel.Text = "Message name:";
			// 
			// stegoKeyTextbox
			// 
			this.stegoKeyTextbox.Enabled = false;
			this.stegoKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.stegoKeyTextbox.Location = new System.Drawing.Point(438, 476);
			this.stegoKeyTextbox.Name = "stegoKeyTextbox";
			this.stegoKeyTextbox.Size = new System.Drawing.Size(131, 22);
			this.stegoKeyTextbox.TabIndex = 7;
			// 
			// stegoKeyLabel
			// 
			this.stegoKeyLabel.AutoSize = true;
			this.stegoKeyLabel.Location = new System.Drawing.Point(435, 460);
			this.stegoKeyLabel.Name = "stegoKeyLabel";
			this.stegoKeyLabel.Size = new System.Drawing.Size(86, 13);
			this.stegoKeyLabel.TabIndex = 17;
			this.stegoKeyLabel.Text = "Stego password:";
			// 
			// encryptionKeyTextbox
			// 
			this.encryptionKeyTextbox.Enabled = false;
			this.encryptionKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.encryptionKeyTextbox.Location = new System.Drawing.Point(438, 382);
			this.encryptionKeyTextbox.Name = "encryptionKeyTextbox";
			this.encryptionKeyTextbox.Size = new System.Drawing.Size(131, 22);
			this.encryptionKeyTextbox.TabIndex = 5;
			// 
			// encryptionKeyLabel
			// 
			this.encryptionKeyLabel.AutoSize = true;
			this.encryptionKeyLabel.Location = new System.Drawing.Point(435, 366);
			this.encryptionKeyLabel.Name = "encryptionKeyLabel";
			this.encryptionKeyLabel.Size = new System.Drawing.Size(80, 13);
			this.encryptionKeyLabel.TabIndex = 19;
			this.encryptionKeyLabel.Text = "Encryption key:";
			// 
			// carrierNameLabel
			// 
			this.carrierNameLabel.AutoSize = true;
			this.carrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.carrierNameLabel.Location = new System.Drawing.Point(179, 418);
			this.carrierNameLabel.Name = "carrierNameLabel";
			this.carrierNameLabel.Size = new System.Drawing.Size(24, 20);
			this.carrierNameLabel.TabIndex = 24;
			this.carrierNameLabel.Text = "---";
			// 
			// carrierSizeLabel
			// 
			this.carrierSizeLabel.AutoSize = true;
			this.carrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.carrierSizeLabel.Location = new System.Drawing.Point(179, 445);
			this.carrierSizeLabel.Name = "carrierSizeLabel";
			this.carrierSizeLabel.Size = new System.Drawing.Size(24, 20);
			this.carrierSizeLabel.TabIndex = 25;
			this.carrierSizeLabel.Text = "---";
			// 
			// carrierCapacityLabel
			// 
			this.carrierCapacityLabel.AutoSize = true;
			this.carrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.carrierCapacityLabel.Location = new System.Drawing.Point(179, 472);
			this.carrierCapacityLabel.Name = "carrierCapacityLabel";
			this.carrierCapacityLabel.Size = new System.Drawing.Size(24, 20);
			this.carrierCapacityLabel.TabIndex = 26;
			this.carrierCapacityLabel.Text = "---";
			// 
			// messageNameLabel
			// 
			this.messageNameLabel.AutoSize = true;
			this.messageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.messageNameLabel.Location = new System.Drawing.Point(179, 498);
			this.messageNameLabel.Name = "messageNameLabel";
			this.messageNameLabel.Size = new System.Drawing.Size(24, 20);
			this.messageNameLabel.TabIndex = 27;
			this.messageNameLabel.Text = "---";
			// 
			// messageSizeLabel
			// 
			this.messageSizeLabel.AutoSize = true;
			this.messageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.messageSizeLabel.Location = new System.Drawing.Point(179, 525);
			this.messageSizeLabel.Name = "messageSizeLabel";
			this.messageSizeLabel.Size = new System.Drawing.Size(24, 20);
			this.messageSizeLabel.TabIndex = 28;
			this.messageSizeLabel.Text = "---";
			// 
			// detectionLabel
			// 
			this.detectionLabel.AutoSize = true;
			this.detectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.detectionLabel.Location = new System.Drawing.Point(179, 552);
			this.detectionLabel.Name = "detectionLabel";
			this.detectionLabel.Size = new System.Drawing.Size(24, 20);
			this.detectionLabel.TabIndex = 29;
			this.detectionLabel.Text = "---";
			// 
			// showCarrierBitplanesButton
			// 
			this.showCarrierBitplanesButton.Enabled = false;
			this.showCarrierBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showCarrierBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showCarrierBitplanesButton.Location = new System.Drawing.Point(15, 359);
			this.showCarrierBitplanesButton.Name = "showCarrierBitplanesButton";
			this.showCarrierBitplanesButton.Size = new System.Drawing.Size(178, 30);
			this.showCarrierBitplanesButton.TabIndex = 30;
			this.showCarrierBitplanesButton.Text = "Show carrier bit planes";
			this.showCarrierBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.showCarrierBitplanesButton.UseVisualStyleBackColor = true;
			// 
			// decryptMessageButton
			// 
			this.decryptMessageButton.Enabled = false;
			this.decryptMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.decryptMessageButton.Location = new System.Drawing.Point(510, 323);
			this.decryptMessageButton.Name = "decryptMessageButton";
			this.decryptMessageButton.Size = new System.Drawing.Size(145, 30);
			this.decryptMessageButton.TabIndex = 9;
			this.decryptMessageButton.Text = "Decrypt message";
			this.decryptMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.decryptMessageButton.UseVisualStyleBackColor = true;
			// 
			// encryptMessageButton
			// 
			this.encryptMessageButton.Enabled = false;
			this.encryptMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.encryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.encryptMessageButton.Location = new System.Drawing.Point(347, 323);
			this.encryptMessageButton.Name = "encryptMessageButton";
			this.encryptMessageButton.Size = new System.Drawing.Size(145, 30);
			this.encryptMessageButton.TabIndex = 4;
			this.encryptMessageButton.Text = "Encrypt message";
			this.encryptMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.encryptMessageButton.UseVisualStyleBackColor = true;
			// 
			// saveMesssageButton
			// 
			this.saveMesssageButton.Enabled = false;
			this.saveMesssageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveMesssageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveMesssageButton.Location = new System.Drawing.Point(510, 567);
			this.saveMesssageButton.Name = "saveMesssageButton";
			this.saveMesssageButton.Size = new System.Drawing.Size(145, 30);
			this.saveMesssageButton.TabIndex = 11;
			this.saveMesssageButton.Text = "Save message";
			this.saveMesssageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveMesssageButton.UseVisualStyleBackColor = true;
			// 
			// saveStegoImageButton
			// 
			this.saveStegoImageButton.Enabled = false;
			this.saveStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveStegoImageButton.Location = new System.Drawing.Point(347, 567);
			this.saveStegoImageButton.Name = "saveStegoImageButton";
			this.saveStegoImageButton.Size = new System.Drawing.Size(145, 30);
			this.saveStegoImageButton.TabIndex = 8;
			this.saveStegoImageButton.Text = "Save stego";
			this.saveStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveStegoImageButton.UseVisualStyleBackColor = true;
			// 
			// loadMessageButton
			// 
			this.loadMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadMessageButton.Location = new System.Drawing.Point(140, 323);
			this.loadMessageButton.Name = "loadMessageButton";
			this.loadMessageButton.Size = new System.Drawing.Size(131, 30);
			this.loadMessageButton.TabIndex = 2;
			this.loadMessageButton.Text = "Load message";
			this.loadMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loadMessageButton.UseVisualStyleBackColor = true;
			// 
			// extractMesssageButton
			// 
			this.extractMesssageButton.Enabled = false;
			this.extractMesssageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.extractMesssageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.extractMesssageButton.Location = new System.Drawing.Point(510, 418);
			this.extractMesssageButton.Name = "extractMesssageButton";
			this.extractMesssageButton.Size = new System.Drawing.Size(145, 30);
			this.extractMesssageButton.TabIndex = 10;
			this.extractMesssageButton.Text = "Extract message";
			this.extractMesssageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.extractMesssageButton.UseVisualStyleBackColor = true;
			// 
			// hideMessageButton
			// 
			this.hideMessageButton.Enabled = false;
			this.hideMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hideMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.hideMessageButton.Location = new System.Drawing.Point(347, 418);
			this.hideMessageButton.Name = "hideMessageButton";
			this.hideMessageButton.Size = new System.Drawing.Size(145, 30);
			this.hideMessageButton.TabIndex = 6;
			this.hideMessageButton.Text = "Hide message";
			this.hideMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.hideMessageButton.UseVisualStyleBackColor = true;
			// 
			// infStegoNameLabel
			// 
			this.infStegoNameLabel.AutoSize = true;
			this.infStegoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infStegoNameLabel.Location = new System.Drawing.Point(710, 418);
			this.infStegoNameLabel.Name = "infStegoNameLabel";
			this.infStegoNameLabel.Size = new System.Drawing.Size(147, 20);
			this.infStegoNameLabel.TabIndex = 32;
			this.infStegoNameLabel.Text = "Stego image name:";
			// 
			// infStegoSizeLabel
			// 
			this.infStegoSizeLabel.AutoSize = true;
			this.infStegoSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.infStegoSizeLabel.Location = new System.Drawing.Point(710, 445);
			this.infStegoSizeLabel.Name = "infStegoSizeLabel";
			this.infStegoSizeLabel.Size = new System.Drawing.Size(135, 20);
			this.infStegoSizeLabel.TabIndex = 33;
			this.infStegoSizeLabel.Text = "Stego image size:";
			// 
			// stegoNameLabel
			// 
			this.stegoNameLabel.AutoSize = true;
			this.stegoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.stegoNameLabel.Location = new System.Drawing.Point(863, 418);
			this.stegoNameLabel.Name = "stegoNameLabel";
			this.stegoNameLabel.Size = new System.Drawing.Size(24, 20);
			this.stegoNameLabel.TabIndex = 34;
			this.stegoNameLabel.Text = "---";
			// 
			// stegoSizeLabel
			// 
			this.stegoSizeLabel.AutoSize = true;
			this.stegoSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.stegoSizeLabel.Location = new System.Drawing.Point(863, 445);
			this.stegoSizeLabel.Name = "stegoSizeLabel";
			this.stegoSizeLabel.Size = new System.Drawing.Size(24, 20);
			this.stegoSizeLabel.TabIndex = 35;
			this.stegoSizeLabel.Text = "---";
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
			this.loadCarrierButton.Text = "Load Carrier";
			this.loadCarrierButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loadCarrierButton.UseVisualStyleBackColor = true;
			// 
			// showStegoImageBitplanesButton
			// 
			this.showStegoImageBitplanesButton.Enabled = false;
			this.showStegoImageBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showStegoImageBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showStegoImageBitplanesButton.Location = new System.Drawing.Point(774, 359);
			this.showStegoImageBitplanesButton.Name = "showStegoImageBitplanesButton";
			this.showStegoImageBitplanesButton.Size = new System.Drawing.Size(216, 30);
			this.showStegoImageBitplanesButton.TabIndex = 31;
			this.showStegoImageBitplanesButton.Text = "Show stego image bit planes";
			this.showStegoImageBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.showStegoImageBitplanesButton.UseVisualStyleBackColor = true;
			// 
			// loadStegoImageButton
			// 
			this.loadStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadStegoImageButton.Location = new System.Drawing.Point(843, 323);
			this.loadStegoImageButton.Name = "loadStegoImageButton";
			this.loadStegoImageButton.Size = new System.Drawing.Size(147, 30);
			this.loadStegoImageButton.TabIndex = 12;
			this.loadStegoImageButton.Text = "Load stego image";
			this.loadStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loadStegoImageButton.UseVisualStyleBackColor = true;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.logoPictureBox.ErrorImage = null;
			this.logoPictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.logo;
			this.logoPictureBox.InitialImage = null;
			this.logoPictureBox.Location = new System.Drawing.Point(784, 553);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(206, 46);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 3;
			this.logoPictureBox.TabStop = false;
			// 
			// stegoImagePictureBox
			// 
			this.stegoImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.stegoImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stegoImagePictureBox.Location = new System.Drawing.Point(3, 22);
			this.stegoImagePictureBox.Name = "stegoImagePictureBox";
			this.stegoImagePictureBox.Size = new System.Drawing.Size(474, 275);
			this.stegoImagePictureBox.TabIndex = 0;
			this.stegoImagePictureBox.TabStop = false;
			// 
			// carrierImagePictureBox
			// 
			this.carrierImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carrierImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carrierImagePictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.chooseAnImage;
			this.carrierImagePictureBox.Location = new System.Drawing.Point(3, 22);
			this.carrierImagePictureBox.Name = "carrierImagePictureBox";
			this.carrierImagePictureBox.Size = new System.Drawing.Size(474, 275);
			this.carrierImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.carrierImagePictureBox.TabIndex = 1;
			this.carrierImagePictureBox.TabStop = false;
			// 
			// clearCarrierAndMessageButton
			// 
			this.clearCarrierAndMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearCarrierAndMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearCarrierAndMessageButton.Location = new System.Drawing.Point(277, 323);
			this.clearCarrierAndMessageButton.Name = "clearCarrierAndMessageButton";
			this.clearCarrierAndMessageButton.Size = new System.Drawing.Size(29, 30);
			this.clearCarrierAndMessageButton.TabIndex = 36;
			this.clearCarrierAndMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearCarrierAndMessageButton.UseVisualStyleBackColor = true;
			// 
			// clearStegoButton
			// 
			this.clearStegoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearStegoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearStegoButton.Location = new System.Drawing.Point(808, 323);
			this.clearStegoButton.Name = "clearStegoButton";
			this.clearStegoButton.Size = new System.Drawing.Size(29, 30);
			this.clearStegoButton.TabIndex = 37;
			this.clearStegoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearStegoButton.UseVisualStyleBackColor = true;
			// 
			// Mainframe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 611);
			this.Controls.Add(this.clearStegoButton);
			this.Controls.Add(this.clearCarrierAndMessageButton);
			this.Controls.Add(this.stegoSizeLabel);
			this.Controls.Add(this.stegoNameLabel);
			this.Controls.Add(this.infStegoSizeLabel);
			this.Controls.Add(this.infStegoNameLabel);
			this.Controls.Add(this.showStegoImageBitplanesButton);
			this.Controls.Add(this.showCarrierBitplanesButton);
			this.Controls.Add(this.detectionLabel);
			this.Controls.Add(this.messageSizeLabel);
			this.Controls.Add(this.messageNameLabel);
			this.Controls.Add(this.carrierCapacityLabel);
			this.Controls.Add(this.carrierSizeLabel);
			this.Controls.Add(this.carrierNameLabel);
			this.Controls.Add(this.decryptMessageButton);
			this.Controls.Add(this.encryptMessageButton);
			this.Controls.Add(this.saveMesssageButton);
			this.Controls.Add(this.saveStegoImageButton);
			this.Controls.Add(this.encryptionKeyLabel);
			this.Controls.Add(this.encryptionKeyTextbox);
			this.Controls.Add(this.stegoKeyLabel);
			this.Controls.Add(this.stegoKeyTextbox);
			this.Controls.Add(this.infMessageNameLabel);
			this.Controls.Add(this.infCarrierNameLabel);
			this.Controls.Add(this.infCarrierSizeLabel);
			this.Controls.Add(this.infMessageSizeLabel);
			this.Controls.Add(this.infDetectionLabel);
			this.Controls.Add(this.infCarrierCapacityLabel);
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
			this.MaximumSize = new System.Drawing.Size(1018, 650);
			this.MinimumSize = new System.Drawing.Size(1018, 650);
			this.Name = "Mainframe";
			this.Text = "HSF - Hide and Seek";
			this.Load += new System.EventHandler(this.mainframe_Load);
			this.carrierImageGroupBox.ResumeLayout(false);
			this.stegoImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).EndInit();
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
		private System.Windows.Forms.Label infCarrierCapacityLabel;
		private System.Windows.Forms.Label infDetectionLabel;
		private System.Windows.Forms.Label infMessageSizeLabel;
		private System.Windows.Forms.Label infCarrierSizeLabel;
		private System.Windows.Forms.Label infCarrierNameLabel;
		private System.Windows.Forms.Label infMessageNameLabel;
		private System.Windows.Forms.TextBox stegoKeyTextbox;
		private System.Windows.Forms.Label stegoKeyLabel;
		private System.Windows.Forms.TextBox encryptionKeyTextbox;
		private System.Windows.Forms.Label encryptionKeyLabel;
		private System.Windows.Forms.Button saveStegoImageButton;
		private System.Windows.Forms.Button saveMesssageButton;
		private System.Windows.Forms.Button encryptMessageButton;
		private System.Windows.Forms.Button decryptMessageButton;
		private System.Windows.Forms.Label carrierNameLabel;
		private System.Windows.Forms.Label carrierSizeLabel;
		private System.Windows.Forms.Label carrierCapacityLabel;
		private System.Windows.Forms.Label messageNameLabel;
		private System.Windows.Forms.Label messageSizeLabel;
		private System.Windows.Forms.Label detectionLabel;
		private System.Windows.Forms.Button showCarrierBitplanesButton;
		private System.Windows.Forms.Button showStegoImageBitplanesButton;
		private System.Windows.Forms.Label infStegoSizeLabel;
		private System.Windows.Forms.Label stegoNameLabel;
		private System.Windows.Forms.Label stegoSizeLabel;
		private System.Windows.Forms.Label infStegoNameLabel;
		private System.Windows.Forms.Button clearCarrierAndMessageButton;
		private System.Windows.Forms.Button clearStegoButton;
	}
}

