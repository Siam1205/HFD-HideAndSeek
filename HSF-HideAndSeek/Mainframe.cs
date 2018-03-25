using HSF_HideAndSeek.Helper;
using HSF_HideAndSeek.Steganography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSF_HideAndSeek {
	public partial class Mainframe : Form {

		// Instances for backend logic
		private FileManager fm = FileManager.Instance;
		private Embedder embedder = Embedder.Instance;

		// Variables for the carrier image
		private Bitmap carrier;
		private string carrierName;
		private long carrierSizeInBytes = 0;
		private long carrierCapacityInBytes = 0;

		// Variables for the stego image
		private Bitmap stegoImage;
		private string stegoImageName;
		private long stegoImageSizeInBytes = 0;

		// Variables for the message
		private byte[] message;
		private string messageName;
		private long messageSizeInBytes = 0;

		// File extensions and its filter for the OpenFileDialog class
		private readonly List<string> imageExtensions = new List<string> { ".bmp", ".jpg", ".jpeg", ".jfif", ".gif", ".png" };
		private readonly string imageExtensionsFilter = "" +
				"Image files (*.bmp, *.gif, *.jpg, *.jpeg, *.jfif, *.png) | *.bmp; *.gif; *.jpg; *.jpeg; *.jfif; *.png; |" +
				"BMP files (*.bmp) | *.bmp; |" +
				"GIF files (*.gif) | *.gif; |" +
				"PNG files (*.png) | *.png; |" +
				"JPEG files (*.jpg, *.jpeg, *.jfif)| *.jpg; *.jpeg; *.jfif;";
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

					// Fill variables
					carrier = fm.ReadImageFile(path, false);
					carrierName = Path.GetFileName(path);
					carrierSizeInBytes = fm.getFileSizeInBytes(path);
					carrierCapacityInBytes = embedder.CalculateCapacity(carrier);

					// Display image
					carrierImagePictureBox.Image = carrier;

					// Fill labels with data
					carrierNameLabel.Text = carrierName;
					carrierSizeLabel.Text = Converter.BytesToHumanReadableString(carrierSizeInBytes);
					carrierCapacityLabel.Text = Converter.BytesToHumanReadableString(carrierCapacityInBytes);

					// Check wheter embedding is possible
					isEmbeddingPossible();
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

					// Fill variables
					stegoImage = fm.ReadImageFile(path, false);
					stegoImageName = Path.GetFileName(path);
					stegoImageSizeInBytes = fm.getFileSizeInBytes(path);

					// Display image
					stegoImagePictureBox.Image = stegoImage;

					// Fill labels with data
					stegoImageNameLabel.Text = stegoImageName;
					stegoImageSizeLabel.Text = Converter.BytesToHumanReadableString(stegoImageSizeInBytes);
				}
			}
		}

		/// <summary>
		/// Loads a message from a specified path
		/// </summary>
		/// <param name="path"></param>
		private void loadMessage(string path) {
			if (File.Exists(path)) {

				// Fill variables
				message = fm.ReadMessageFile(path);
				messageName = Path.GetFileName(path);
				messageSizeInBytes = fm.getFileSizeInBytes(path);

				// Fill labels with data
				messageNameLabel.Text = messageName;
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(messageSizeInBytes);

				// Check wheter embedding is possible
				isEmbeddingPossible();
			}
		}

		/// <summary>
		/// Removes the carrier image from the GUI
		/// </summary>
		private void clearCarrierImage() {

			// Reset variables
			carrier = null;
			carrierName = "";
			carrierSizeInBytes = 0;
			carrierCapacityInBytes = 0;

			// Remove image
			carrierImagePictureBox.Image = null;
			//carrierImagePictureBox.Image = HSF_HideAndSeek.Properties.Resources.chooseAnImage;

			// Remove data from labels
			carrierNameLabel.Text = defaultLabelValue;
			carrierSizeLabel.Text = defaultLabelValue;
			carrierCapacityLabel.Text = defaultLabelValue;

			// Check wheter embedding is possible
			isEmbeddingPossible();
		}

		/// <summary>
		/// Removes the stego image from the GUI
		/// </summary>
		private void clearStegoImage() {

			// Reset variables
			stegoImage = null;
			stegoImageName = "";
			stegoImageSizeInBytes = 0;

			// Remove image
			stegoImagePictureBox.Image = null;
			//stegoImagePictureBox.Image = HSF_HideAndSeek.Properties.Resources.chooseAnImage;

			// Remove data from labels
			stegoImageNameLabel.Text = defaultLabelValue;
			stegoImageSizeLabel.Text = defaultLabelValue;
		}

		/// <summary>
		/// Removes the message from the GUI
		/// </summary>
		private void clearMessage() {

			// Reset variables
			message = null;
			messageName = "";
			messageSizeInBytes = 0;

			// Remove data from labels
			messageNameLabel.Text = defaultLabelValue;
			messageSizeLabel.Text = defaultLabelValue;

			isEmbeddingPossible();
		}

		/// <summary>
		/// Check whether all requirements are set to hide a message
		/// </summary>
		/// <returns></returns>
		private bool isEmbeddingPossible() {
			if (carrier == null || message == null) {
				hideMessageButton.Enabled = false;
				return false;
			}
			if (carrierCapacityInBytes < messageSizeInBytes) {
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
		private bool isExtractionPossible() {
			if (stegoImage == null) {
				extractMesssageButton.Enabled = false;
				return false;
			}

			extractMesssageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Load resources for the mainframe and initialize it
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mainframe_Load(object sender, EventArgs e) {

			// Selected bits per pixel combo box
			lsbsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			lsbsComboBox.SelectedIndex = 0;

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
			this.extractMesssageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.leftArrow, new Size(22, 22)));

			this.saveStegoImageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.save, new Size(21, 21)));
			this.saveMesssageButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.save, new Size(21, 21)));

			this.helpButton.Image = (Image) (new Bitmap(HSF_HideAndSeek.Properties.Resources.help_1, new Size(21, 21)));
		}

		#region Button click events
		private void loadCarrierButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = @"C:\";
			ofd.Multiselect = false;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			ofd.Title = "Please select a carrier image file";
			ofd.Filter = imageExtensionsFilter;
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
			ofd.Filter = imageExtensionsFilter;
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
		#endregion
	}
}
