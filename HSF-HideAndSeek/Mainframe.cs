using HSF_HideAndSeek.Cryptography;
using HSF_HideAndSeek.Helper;
using HSF_HideAndSeek.Steganography;
using HSF_HideAndSeek.Steganography.DataStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSF_HideAndSeek {
	public partial class Mainframe : Form {

		// Instances for backend logic
		private FileManager fm = FileManager.Instance;
		private Embedder embedder = Embedder.Instance;

		// Main data structures
		private StegoImage carrier;
		private StegoImage stegoImage;
		private StegoMessage message;

		// File extensions and its filter for the OpenFileDialog class
		private readonly List<string> imageExtensions = new List<string> { ".bmp", ".jpg", ".jpeg", ".jfif", ".gif", ".png" };
		private readonly string carrierExtensionsFilter = "" +
				"Image files (*.bmp, *.gif, *.jpg, *.jpeg, *.jfif, *.png) | *.bmp; *.gif; *.jpg; *.jpeg; *.jfif; *.png; |" +
				"BMP files (*.bmp) | *.bmp; |" +
				"GIF files (*.gif) | *.gif; |" +
				"PNG files (*.png) | *.png; |" +
				"JPEG files (*.jpg, *.jpeg, *.jfif)| *.jpg; *.jpeg; *.jfif;";
		private readonly string stegoImageExtensionsFilter = "" +
				"Image files (*.bmp, *.png) | *.bmp; *.png; |" +
				"BMP files (*.bmp) | *.bmp; |" +
				"PNG files (*.png) | *.png;";
		private readonly string messageExtensionsFilter = "" +
				"All Files (*.*) | *.*; |" +
				"Image files (*.bmp, *.gif, *.jpg, *.jpeg, *.jfif, *.png) | *.bmp; *.gif; *.jpg; *.jpeg; *.jfif; *.png; |" +
				"Office files (*.doc, *.docx, *.xls, *.ppt) | *.doc; *.docx; *.xls; *.ppt; |" +
				"Text files (*.txt, *.pdf) | *.txt; *.pdf;";

		private readonly string defaultLabelValue = "---";

		/// <summary>
		/// Constructor
		/// </summary>
		public Mainframe() {
			InitializeComponent();
		}

		/// <summary>
		/// Loads a carrier image from a specified path to the GUI
		/// </summary>
		/// <param name="path"></param>
		private void loadCarrierImage(string path) {
			if (File.Exists(path)) {
				if (imageExtensions.Contains(Path.GetExtension(path).ToLowerInvariant())) {

					// Generate carrier image object
					carrier = new StegoImage(
						fm.ReadImageFile(path, false),
						Path.GetFileName(path),
						fm.getFileSizeInBytes(path)
					);

					// Display image
					carrierImagePictureBox.Image = carrier.Image;

					// Fill labels with data
					carrierNameLabel.Text = carrier.Name;
					carrierSizeLabel.Text = Converter.BytesToHumanReadableString(carrier.SizeInBytes);
					carrierCapacityLabel.Text = Converter.BytesToHumanReadableString(
						embedder.CalculateCapacity(carrier, (byte) (bppComboBox.SelectedIndex + 1)));

					// Check GUI components
					checkEverything();
				}
			}
		}

		/// <summary>
		/// Loads a stego image from a specified path
		/// </summary>
		/// <param name="path"></param>
		private void loadStegoImage(string path) {
			if (File.Exists(path)) {
				if (imageExtensions.Contains(Path.GetExtension(path).ToLowerInvariant())) {

					// Generate stego image object
					stegoImage = new StegoImage(
						fm.ReadImageFile(path, false),
						Path.GetFileName(path),
						fm.getFileSizeInBytes(path)
					);

					// Display image
					stegoImagePictureBox.Image = stegoImage.Image;

					// Fill labels with data
					stegoImageNameLabel.Text = stegoImage.Name;
					stegoImageSizeLabel.Text = Converter.BytesToHumanReadableString(stegoImage.SizeInBytes);

					// Check GUI components
					checkEverything();
				}
			}
		}

		/// <summary>
		/// Loads a message from a specified path
		/// </summary>
		/// <param name="path"></param>
		private void loadMessage(string path) {
			if (File.Exists(path)) {

				// Generate message object
				message = new StegoMessage(
					Path.GetFileName(path),
					fm.ReadMessageFile(path)
				);

				// Fill labels with data
				messageNameLabel.Text = message.Name;
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(message.FullSizeInBytes);

				// Check GUI components
				checkEverything();
			}
		}

		/// <summary>
		/// Removes the carrier image from the GUI
		/// </summary>
		private void clearCarrierImage() {

			// Reset carrier image object
			carrier = null;

			// Remove image
			carrierImagePictureBox.Image = null;

			// Remove data from labels
			carrierNameLabel.Text = defaultLabelValue;
			carrierSizeLabel.Text = defaultLabelValue;
			carrierCapacityLabel.Text = defaultLabelValue;

			// Check GUI components
			checkEverything();
		}

		/// <summary>
		/// Removes the stego image from the GUI
		/// </summary>
		private void clearStegoImage() {

			// Reset stego image object
			stegoImage = null;

			// Remove image
			stegoImagePictureBox.Image = null;

			// Remove data from labels
			stegoImageNameLabel.Text = defaultLabelValue;
			stegoImageSizeLabel.Text = defaultLabelValue;

			// Check GUI components
			checkEverything();
		}

		/// <summary>
		/// Removes the message from the GUI
		/// </summary>
		private void clearMessage() {

			// Reset message object
			message = null;

			// Remove data from labels
			messageNameLabel.Text = defaultLabelValue;
			messageSizeLabel.Text = defaultLabelValue;

			// Check GUI components
			checkEverything();
		}

		/// <summary>
		/// Load resources for the mainframe and initialize it
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mainframe_Load(object sender, EventArgs e) {

			// Selected bits per pixel combo box
			bppComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			bppComboBox.SelectedIndex = 0;

			// Load button images
			this.loadCarrierButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.load, new Size(22, 22)));
			this.loadMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.load, new Size(22, 22)));
			this.loadStegoImageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.load, new Size(22, 22)));

			this.clearCarrierAndMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.forbidden, new Size(22, 22)));
			this.clearStegoButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.forbidden, new Size(22, 22)));

			this.showCarrierBitplanesButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.binary_2, new Size(21, 21)));
			this.showStegoImageBitplanesButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.binary_2, new Size(21, 21)));

			this.encryptMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.rightArrow, new Size(22, 22)));
			this.decryptMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.leftArrow, new Size(22, 22)));

			this.hideMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.rightArrow, new Size(22, 22)));
			this.extractMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.leftArrow, new Size(22, 22)));

			this.saveStegoImageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.save, new Size(19, 19)));
			this.saveMessageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.save, new Size(19, 19)));

			this.helpButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.help_1, new Size(50, 50)));

			this.rateButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.star, new Size(22, 22)));
		}

		#region Events and listeners
		private void loadCarrierButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = @"C:\";
			ofd.Multiselect = false;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			ofd.Title = "Please select a carrier image file";
			ofd.Filter = carrierExtensionsFilter;
			ofd.ShowDialog();
			loadCarrierImage(ofd.FileName);
		}

		private void loadMessageButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = @"C:\";
			ofd.Multiselect = false;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			ofd.Title = "Please select a message file";
			ofd.Filter = messageExtensionsFilter;
			ofd.ShowDialog();
			loadMessage(ofd.FileName);
		}

		private void loadStegoImageButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = @"C:\";
			ofd.Multiselect = false;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			ofd.Title = "Please select a stego image file";
			ofd.Filter = stegoImageExtensionsFilter;
			ofd.ShowDialog();
			loadStegoImage(ofd.FileName);
		}

		private void clearCarrierAndMessageButton_Click(object sender, EventArgs e) {
			clearCarrierImage();
			clearMessage();
		}

		private void clearStegoButton_Click(object sender, EventArgs e) {
			clearStegoImage();
		}

		private void encryptMessageButton_Click(object sender, EventArgs e) {
			encryptMessageButton.Text = "Encrypting ...";
			encryptMessageButton.Enabled = false;
			System.Threading.Thread.Sleep(150);
			try {
				message.Payload = AES.Encrypt(message.Payload, encryptionKeyTextbox.Text);
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(message.FullSizeInBytes);
			} catch (CryptographicException) {
				MessageBox.Show(
					"Could not encrypt the message.",
					"Error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			encryptMessageButton.Text = "Encrypt message";
			encryptMessageButton.Enabled = true;
		}

		private void hideMessageButton_Click(object sender, EventArgs e) {
			hideMessageButton.Text = "Hiding ...";
			hideMessageButton.Enabled = false;

			// Generate stego image
			if (stegoPasswordTextbox.Equals("") || stegoPasswordTextbox.Text.Equals(null)) {
				stegoImage = embedder.HideMessage(
					carrier,
					message,
					null,
					bppComboBox.SelectedIndex + 1,
					true
				);
			} else {
				stegoImage = embedder.HideMessage(
					carrier,
					message,
					stegoPasswordTextbox.Text,
					bppComboBox.SelectedIndex + 1,
					true
				);
			}

			// Fill labels with data
			stegoImageNameLabel.Text = stegoImage.Name;
			stegoImageSizeLabel.Text = defaultLabelValue; // TODO: Change this

			// Display image
			stegoImagePictureBox.Image = stegoImage.Image;

			// Check GUI components
			hideMessageButton.Text = "Hide message";
			checkEverything();
		}

		private void extractMesssageButton_Click(object sender, EventArgs e) {
			extractMessageButton.Text = "Extracting ...";
			extractMessageButton.Enabled = false;

			if (stegoPasswordTextbox.Equals("") || stegoPasswordTextbox.Text.Equals(null)) {
				message = embedder.ExtractMessage(stegoImage, null, bppComboBox.SelectedIndex + 1, true);
			} else {
				message = embedder.ExtractMessage(stegoImage, stegoPasswordTextbox.Text, bppComboBox.SelectedIndex + 1, true);
			}

			// Fill labels with data
			messageNameLabel.Text = message.Name;
			messageSizeLabel.Text = Converter.BytesToHumanReadableString(message.FullSizeInBytes);

			// Check GUI components
			extractMessageButton.Text = "Extract message";
			checkEverything();
		}

		private void decryptMessageButton_Click(object sender, EventArgs e) {
			decryptMessageButton.Text = "Decrypting ...";
			decryptMessageButton.Enabled = false;
			try {
				message.Payload = AES.Decrypt(message.Payload, encryptionKeyTextbox.Text);
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(message.FullSizeInBytes);
			} catch (CryptographicException) {
				MessageBox.Show(
					"Could not decrypt the message (with the given key).",
					"Error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			decryptMessageButton.Text = "Decrypt message";
			decryptMessageButton.Enabled = true;
		}

		private void rateButton_Click(object sender, EventArgs e) {
			rateButton.Text = "Rating ...";
			rateButton.Enabled = false;

			rateButton.Text = "Rate carrier";
			rateButton.Enabled = true;
		}

		private void showStegoImageBitplanesButton_Click(object sender, EventArgs e) {
			showStegoImageBitplanesButton.Text = "Generating bit planes ...";
			showStegoImageBitplanesButton.Enabled = false;

			showStegoImageBitplanesButton.Text = "Show stego image bit planes";
			showStegoImageBitplanesButton.Enabled = true;
		}

		private void helpButton_Click(object sender, EventArgs e) {

		}

		private void encryptionKeyTextbox_TextChanged(object sender, EventArgs e) {
			checkEncryption();
		}

		private void showCarrierBitplanesButton_Click(object sender, EventArgs e) {
			showCarrierBitplanesButton.Text = "Generating bit planes ...";
			showCarrierBitplanesButton.Enabled = false;

			showCarrierBitplanesButton.Text = "Show carrier bit planes";
			showCarrierBitplanesButton.Enabled = true;
		}

		private void saveStegoImageButton_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Save the stego image";
			sfd.FileName = stegoImage.Name;
			sfd.Filter = stegoImageExtensionsFilter;
			sfd.ShowDialog();
			fm.WriteStegoImage(stegoImage.Image, sfd.FileName);
		}

		private void saveMessageButton_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Save the message file";
			sfd.FileName = message.Name;
			sfd.Filter = messageExtensionsFilter;
			sfd.ShowDialog();
			fm.WriteMessageFile(message.Payload, sfd.FileName);
		}

		private void bppComboBox_SelectedIndexChanged(object sender, EventArgs e) {

			// Change label data
			if (carrier != null) {
				carrierCapacityLabel.Text = Converter.BytesToHumanReadableString(
				embedder.CalculateCapacity(carrier, (byte) (bppComboBox.SelectedIndex + 1)));
			}

			// Check GUI components
			checkEverything();
		}
		#endregion

		#region GUI component checker methods
		/// <summary>
		/// Wrapper for all check-methods
		/// </summary>
		private void checkEverything() {
			checkEncryption();
			checkEmbedding();
			checkExtraction();
			checkSavingMessage();
			checkSavingStegoImage();
		}

		/// <summary>
		/// Check whether all requirements are set to hide a message
		/// </summary>
		/// <returns></returns>
		private bool checkEmbedding() {
			if (carrier == null || message == null) {
				hideMessageButton.Enabled = false;
				return false;
			}

			if (embedder.CalculateCapacity(carrier, bppComboBox.SelectedIndex+1) < message.FullSizeInBytes) {
				hideMessageButton.Enabled = false;
				messageSizeLabel.ForeColor = Color.Red;
				return false;
			}

			messageSizeLabel.ForeColor = Color.Black;
			hideMessageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Check whether all requirements are set to extract a message
		/// </summary>
		/// <returns></returns>
		private bool checkExtraction() {
			if (stegoImage == null) {
				extractMessageButton.Enabled = false;
				return false;
			}
			extractMessageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Check whether all requirements are set to encrypt or decrypt a message
		/// </summary>
		/// <returns></returns>
		private bool checkEncryption() {
			if (message == null) {
				encryptMessageButton.Enabled = false;
				decryptMessageButton.Enabled = false;
				return false;
			}

			if (encryptionKeyTextbox.Text.Equals("")) {
				encryptMessageButton.Enabled = false;
				decryptMessageButton.Enabled = false;
				return false;
			}

			encryptMessageButton.Enabled = true;
			decryptMessageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Check whether all requirements are set to save a stego image to the drive
		/// </summary>
		/// <returns></returns>
		private bool checkSavingStegoImage() {
			if (stegoImage == null) {
				saveStegoImageButton.Enabled = false;
				return false;
			}

			saveStegoImageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Check whether all requirements are set to save a message file to the drive
		/// </summary>
		/// <returns></returns>
		private bool checkSavingMessage() {
			if (message == null) {
				saveMessageButton.Enabled = false;
				return false;
			}
			saveMessageButton.Enabled = true;
			return true;
		}
		#endregion
	}
}
