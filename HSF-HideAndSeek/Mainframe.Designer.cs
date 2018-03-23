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
			this.clearCarrierAndMessageButton = new System.Windows.Forms.Button();
			this.clearStegoButton = new System.Windows.Forms.Button();
			this.carrierImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).BeginInit();
			this.stegoImageGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).BeginInit();
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
			this.carrierImageGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.carrierImageGroupBox.Name = "carrierImageGroupBox";
			this.carrierImageGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.carrierImageGroupBox.Size = new System.Drawing.Size(600, 375);
			this.carrierImageGroupBox.TabIndex = 0;
			this.carrierImageGroupBox.TabStop = false;
			this.carrierImageGroupBox.Text = "Carrier image";
			// 
			// carrierImagePictureBox
			// 
			this.carrierImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carrierImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carrierImagePictureBox.Image = global::HSF_HideAndSeek.Properties.Resources.chooseAnImage;
			this.carrierImagePictureBox.Location = new System.Drawing.Point(4, 27);
			this.carrierImagePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.carrierImagePictureBox.Name = "carrierImagePictureBox";
			this.carrierImagePictureBox.Size = new System.Drawing.Size(592, 344);
			this.carrierImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.carrierImagePictureBox.TabIndex = 1;
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
			this.stegoImageGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.stegoImageGroupBox.Name = "stegoImageGroupBox";
			this.stegoImageGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.stegoImagePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.stegoImagePictureBox.Name = "stegoImagePictureBox";
			this.stegoImagePictureBox.Size = new System.Drawing.Size(592, 344);
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
			this.lsbsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lsbsComboBox.Name = "lsbsComboBox";
			this.lsbsComboBox.Size = new System.Drawing.Size(163, 28);
			this.lsbsComboBox.TabIndex = 3;
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
			// infCarrierCapacityLabel
			// 
			this.infCarrierCapacityLabel.AutoSize = true;
			this.infCarrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infCarrierCapacityLabel.Location = new System.Drawing.Point(15, 590);
			this.infCarrierCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infCarrierCapacityLabel.Name = "infCarrierCapacityLabel";
			this.infCarrierCapacityLabel.Size = new System.Drawing.Size(144, 24);
			this.infCarrierCapacityLabel.TabIndex = 10;
			this.infCarrierCapacityLabel.Text = "Carrier capacity:";
			// 
			// infDetectionLabel
			// 
			this.infDetectionLabel.AutoSize = true;
			this.infDetectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infDetectionLabel.Location = new System.Drawing.Point(15, 690);
			this.infDetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infDetectionLabel.Name = "infDetectionLabel";
			this.infDetectionLabel.Size = new System.Drawing.Size(184, 24);
			this.infDetectionLabel.TabIndex = 11;
			this.infDetectionLabel.Text = "Detection probability:";
			// 
			// infMessageSizeLabel
			// 
			this.infMessageSizeLabel.AutoSize = true;
			this.infMessageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infMessageSizeLabel.Location = new System.Drawing.Point(15, 656);
			this.infMessageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infMessageSizeLabel.Name = "infMessageSizeLabel";
			this.infMessageSizeLabel.Size = new System.Drawing.Size(130, 24);
			this.infMessageSizeLabel.TabIndex = 12;
			this.infMessageSizeLabel.Text = "Message size:";
			// 
			// infCarrierSizeLabel
			// 
			this.infCarrierSizeLabel.AutoSize = true;
			this.infCarrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infCarrierSizeLabel.Location = new System.Drawing.Point(15, 556);
			this.infCarrierSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infCarrierSizeLabel.Name = "infCarrierSizeLabel";
			this.infCarrierSizeLabel.Size = new System.Drawing.Size(109, 24);
			this.infCarrierSizeLabel.TabIndex = 13;
			this.infCarrierSizeLabel.Text = "Carrier size:";
			// 
			// infCarrierNameLabel
			// 
			this.infCarrierNameLabel.AutoSize = true;
			this.infCarrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infCarrierNameLabel.Location = new System.Drawing.Point(15, 522);
			this.infCarrierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infCarrierNameLabel.Name = "infCarrierNameLabel";
			this.infCarrierNameLabel.Size = new System.Drawing.Size(124, 24);
			this.infCarrierNameLabel.TabIndex = 14;
			this.infCarrierNameLabel.Text = "Carrier name:";
			// 
			// infMessageNameLabel
			// 
			this.infMessageNameLabel.AutoSize = true;
			this.infMessageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infMessageNameLabel.Location = new System.Drawing.Point(15, 622);
			this.infMessageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infMessageNameLabel.Name = "infMessageNameLabel";
			this.infMessageNameLabel.Size = new System.Drawing.Size(145, 24);
			this.infMessageNameLabel.TabIndex = 15;
			this.infMessageNameLabel.Text = "Message name:";
			// 
			// stegoKeyTextbox
			// 
			this.stegoKeyTextbox.Enabled = false;
			this.stegoKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.stegoKeyTextbox.Location = new System.Drawing.Point(548, 595);
			this.stegoKeyTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.stegoKeyTextbox.Name = "stegoKeyTextbox";
			this.stegoKeyTextbox.Size = new System.Drawing.Size(163, 26);
			this.stegoKeyTextbox.TabIndex = 7;
			// 
			// stegoKeyLabel
			// 
			this.stegoKeyLabel.AutoSize = true;
			this.stegoKeyLabel.Location = new System.Drawing.Point(544, 575);
			this.stegoKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stegoKeyLabel.Name = "stegoKeyLabel";
			this.stegoKeyLabel.Size = new System.Drawing.Size(113, 17);
			this.stegoKeyLabel.TabIndex = 17;
			this.stegoKeyLabel.Text = "Stego password:";
			// 
			// encryptionKeyTextbox
			// 
			this.encryptionKeyTextbox.Enabled = false;
			this.encryptionKeyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.encryptionKeyTextbox.Location = new System.Drawing.Point(548, 478);
			this.encryptionKeyTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.encryptionKeyTextbox.Name = "encryptionKeyTextbox";
			this.encryptionKeyTextbox.Size = new System.Drawing.Size(163, 26);
			this.encryptionKeyTextbox.TabIndex = 5;
			// 
			// encryptionKeyLabel
			// 
			this.encryptionKeyLabel.AutoSize = true;
			this.encryptionKeyLabel.Location = new System.Drawing.Point(544, 458);
			this.encryptionKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.encryptionKeyLabel.Name = "encryptionKeyLabel";
			this.encryptionKeyLabel.Size = new System.Drawing.Size(105, 17);
			this.encryptionKeyLabel.TabIndex = 19;
			this.encryptionKeyLabel.Text = "Encryption key:";
			// 
			// carrierNameLabel
			// 
			this.carrierNameLabel.AutoSize = true;
			this.carrierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.carrierNameLabel.Location = new System.Drawing.Point(224, 522);
			this.carrierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carrierNameLabel.Name = "carrierNameLabel";
			this.carrierNameLabel.Size = new System.Drawing.Size(28, 24);
			this.carrierNameLabel.TabIndex = 24;
			this.carrierNameLabel.Text = "---";
			// 
			// carrierSizeLabel
			// 
			this.carrierSizeLabel.AutoSize = true;
			this.carrierSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.carrierSizeLabel.Location = new System.Drawing.Point(224, 556);
			this.carrierSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carrierSizeLabel.Name = "carrierSizeLabel";
			this.carrierSizeLabel.Size = new System.Drawing.Size(28, 24);
			this.carrierSizeLabel.TabIndex = 25;
			this.carrierSizeLabel.Text = "---";
			// 
			// carrierCapacityLabel
			// 
			this.carrierCapacityLabel.AutoSize = true;
			this.carrierCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.carrierCapacityLabel.Location = new System.Drawing.Point(224, 590);
			this.carrierCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carrierCapacityLabel.Name = "carrierCapacityLabel";
			this.carrierCapacityLabel.Size = new System.Drawing.Size(28, 24);
			this.carrierCapacityLabel.TabIndex = 26;
			this.carrierCapacityLabel.Text = "---";
			// 
			// messageNameLabel
			// 
			this.messageNameLabel.AutoSize = true;
			this.messageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.messageNameLabel.Location = new System.Drawing.Point(224, 622);
			this.messageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.messageNameLabel.Name = "messageNameLabel";
			this.messageNameLabel.Size = new System.Drawing.Size(28, 24);
			this.messageNameLabel.TabIndex = 27;
			this.messageNameLabel.Text = "---";
			// 
			// messageSizeLabel
			// 
			this.messageSizeLabel.AutoSize = true;
			this.messageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.messageSizeLabel.Location = new System.Drawing.Point(224, 656);
			this.messageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.messageSizeLabel.Name = "messageSizeLabel";
			this.messageSizeLabel.Size = new System.Drawing.Size(28, 24);
			this.messageSizeLabel.TabIndex = 28;
			this.messageSizeLabel.Text = "---";
			// 
			// detectionLabel
			// 
			this.detectionLabel.AutoSize = true;
			this.detectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.detectionLabel.Location = new System.Drawing.Point(224, 690);
			this.detectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.detectionLabel.Name = "detectionLabel";
			this.detectionLabel.Size = new System.Drawing.Size(28, 24);
			this.detectionLabel.TabIndex = 29;
			this.detectionLabel.Text = "---";
			// 
			// showCarrierBitplanesButton
			// 
			this.showCarrierBitplanesButton.Enabled = false;
			this.showCarrierBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showCarrierBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showCarrierBitplanesButton.Location = new System.Drawing.Point(19, 449);
			this.showCarrierBitplanesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.showCarrierBitplanesButton.Name = "showCarrierBitplanesButton";
			this.showCarrierBitplanesButton.Size = new System.Drawing.Size(222, 38);
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
			this.decryptMessageButton.Location = new System.Drawing.Point(638, 404);
			this.decryptMessageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.decryptMessageButton.Name = "decryptMessageButton";
			this.decryptMessageButton.Size = new System.Drawing.Size(181, 38);
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
			this.encryptMessageButton.Location = new System.Drawing.Point(434, 404);
			this.encryptMessageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.encryptMessageButton.Name = "encryptMessageButton";
			this.encryptMessageButton.Size = new System.Drawing.Size(181, 38);
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
			this.saveMesssageButton.Location = new System.Drawing.Point(638, 709);
			this.saveMesssageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.saveMesssageButton.Name = "saveMesssageButton";
			this.saveMesssageButton.Size = new System.Drawing.Size(181, 38);
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
			this.saveStegoImageButton.Location = new System.Drawing.Point(434, 709);
			this.saveStegoImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.saveStegoImageButton.Name = "saveStegoImageButton";
			this.saveStegoImageButton.Size = new System.Drawing.Size(181, 38);
			this.saveStegoImageButton.TabIndex = 8;
			this.saveStegoImageButton.Text = "Save stego";
			this.saveStegoImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveStegoImageButton.UseVisualStyleBackColor = true;
			// 
			// loadMessageButton
			// 
			this.loadMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadMessageButton.Location = new System.Drawing.Point(175, 404);
			this.loadMessageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loadMessageButton.Name = "loadMessageButton";
			this.loadMessageButton.Size = new System.Drawing.Size(164, 38);
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
			this.extractMesssageButton.Location = new System.Drawing.Point(638, 522);
			this.extractMesssageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.extractMesssageButton.Name = "extractMesssageButton";
			this.extractMesssageButton.Size = new System.Drawing.Size(181, 38);
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
			this.hideMessageButton.Location = new System.Drawing.Point(434, 522);
			this.hideMessageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.hideMessageButton.Name = "hideMessageButton";
			this.hideMessageButton.Size = new System.Drawing.Size(181, 38);
			this.hideMessageButton.TabIndex = 6;
			this.hideMessageButton.Text = "Hide message";
			this.hideMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.hideMessageButton.UseVisualStyleBackColor = true;
			// 
			// infStegoNameLabel
			// 
			this.infStegoNameLabel.AutoSize = true;
			this.infStegoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infStegoNameLabel.Location = new System.Drawing.Point(888, 522);
			this.infStegoNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infStegoNameLabel.Name = "infStegoNameLabel";
			this.infStegoNameLabel.Size = new System.Drawing.Size(174, 24);
			this.infStegoNameLabel.TabIndex = 32;
			this.infStegoNameLabel.Text = "Stego image name:";
			// 
			// infStegoSizeLabel
			// 
			this.infStegoSizeLabel.AutoSize = true;
			this.infStegoSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.infStegoSizeLabel.Location = new System.Drawing.Point(888, 556);
			this.infStegoSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infStegoSizeLabel.Name = "infStegoSizeLabel";
			this.infStegoSizeLabel.Size = new System.Drawing.Size(159, 24);
			this.infStegoSizeLabel.TabIndex = 33;
			this.infStegoSizeLabel.Text = "Stego image size:";
			// 
			// stegoNameLabel
			// 
			this.stegoNameLabel.AutoSize = true;
			this.stegoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.stegoNameLabel.Location = new System.Drawing.Point(1079, 522);
			this.stegoNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stegoNameLabel.Name = "stegoNameLabel";
			this.stegoNameLabel.Size = new System.Drawing.Size(28, 24);
			this.stegoNameLabel.TabIndex = 34;
			this.stegoNameLabel.Text = "---";
			// 
			// stegoSizeLabel
			// 
			this.stegoSizeLabel.AutoSize = true;
			this.stegoSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.stegoSizeLabel.Location = new System.Drawing.Point(1079, 556);
			this.stegoSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stegoSizeLabel.Name = "stegoSizeLabel";
			this.stegoSizeLabel.Size = new System.Drawing.Size(28, 24);
			this.stegoSizeLabel.TabIndex = 35;
			this.stegoSizeLabel.Text = "---";
			// 
			// loadCarrierButton
			// 
			this.loadCarrierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loadCarrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadCarrierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadCarrierButton.Location = new System.Drawing.Point(19, 404);
			this.loadCarrierButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loadCarrierButton.Name = "loadCarrierButton";
			this.loadCarrierButton.Size = new System.Drawing.Size(149, 38);
			this.loadCarrierButton.TabIndex = 1;
			this.loadCarrierButton.Text = "Load carrier";
			this.loadCarrierButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loadCarrierButton.UseVisualStyleBackColor = true;
			// 
			// showStegoImageBitplanesButton
			// 
			this.showStegoImageBitplanesButton.Enabled = false;
			this.showStegoImageBitplanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showStegoImageBitplanesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showStegoImageBitplanesButton.Location = new System.Drawing.Point(968, 449);
			this.showStegoImageBitplanesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.showStegoImageBitplanesButton.Name = "showStegoImageBitplanesButton";
			this.showStegoImageBitplanesButton.Size = new System.Drawing.Size(270, 38);
			this.showStegoImageBitplanesButton.TabIndex = 31;
			this.showStegoImageBitplanesButton.Text = "Show stego image bit planes";
			this.showStegoImageBitplanesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.showStegoImageBitplanesButton.UseVisualStyleBackColor = true;
			// 
			// loadStegoImageButton
			// 
			this.loadStegoImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadStegoImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loadStegoImageButton.Location = new System.Drawing.Point(1054, 404);
			this.loadStegoImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loadStegoImageButton.Name = "loadStegoImageButton";
			this.loadStegoImageButton.Size = new System.Drawing.Size(184, 38);
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
			this.logoPictureBox.Location = new System.Drawing.Point(980, 697);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(258, 58);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 3;
			this.logoPictureBox.TabStop = false;
			// 
			// clearCarrierAndMessageButton
			// 
			this.clearCarrierAndMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearCarrierAndMessageButton.Location = new System.Drawing.Point(346, 404);
			this.clearCarrierAndMessageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.clearCarrierAndMessageButton.Name = "clearCarrierAndMessageButton";
			this.clearCarrierAndMessageButton.Size = new System.Drawing.Size(36, 38);
			this.clearCarrierAndMessageButton.TabIndex = 36;
			this.clearCarrierAndMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearCarrierAndMessageButton.UseVisualStyleBackColor = true;
			// 
			// clearStegoButton
			// 
			this.clearStegoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearStegoButton.Location = new System.Drawing.Point(1010, 404);
			this.clearStegoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.clearStegoButton.Name = "clearStegoButton";
			this.clearStegoButton.Size = new System.Drawing.Size(36, 38);
			this.clearStegoButton.TabIndex = 37;
			this.clearStegoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearStegoButton.UseVisualStyleBackColor = true;
			// 
			// Mainframe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1250, 768);
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
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximumSize = new System.Drawing.Size(1268, 815);
			this.MinimumSize = new System.Drawing.Size(1268, 815);
			this.Name = "Mainframe";
			this.Text = "HSF - Hide and Seek";
			this.Load += new System.EventHandler(this.mainframe_Load);
			this.carrierImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.carrierImagePictureBox)).EndInit();
			this.stegoImageGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.stegoImagePictureBox)).EndInit();
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

