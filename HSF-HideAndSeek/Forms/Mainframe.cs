using HSF_HideAndSeek.Cryptography;
using HSF_HideAndSeek.Helper;
using HSF_HideAndSeek.Steganography.Logic;
using HSF_HideAndSeek.Steganography.DataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using HSF_HideAndSeek.Exceptions;

namespace HSF_HideAndSeek.Forms {

	/// <summary>
	/// This class represents the application's main form and therefore the central user interface.
	/// It contains all elements the user can interact with such as buttons or combo boxes.
	/// From this form, all logic is invoked.
	/// </summary>
	public sealed partial class Mainframe : Form {
		
		#region Fields
		/// <summary>
		/// The reference to the about form object.
		/// </summary>
		private AboutBox _aboutBox;

		/// <summary>
		/// The reference to the carrier bit planes form object
		/// </summary>
		private BitPlaneForm _carrierBitPlaneForm;

		/// <summary>
		/// The reference to the stego image bit planes form object
		/// </summary>
		private BitPlaneForm _stegoImageBitPlaneForm;

		/// <summary>
		/// The reference to the FileManager's singleton instance
		/// </summary>
		private readonly FileManager _fm = FileManager.Instance;

		/// <summary>
		/// The reference to the Embedder's singleton instance
		/// </summary>
		private readonly Embedder _embedder = Embedder.Instance;

		/// <summary>
		/// The reference to the carrier image object the user can load into the system
		/// </summary>
		private StegoImage _carrier;

		/// <summary>
		/// The reference to the stego image object the user can load into the system
		/// </summary>
		private StegoImage _stegoImage;

		/// <summary>
		/// The reference to the message object the user can load into the system
		/// </summary>
		private StegoMessage _message;

		/// <summary>
		/// A string list containing image extensions one of which a potential carrier image needs to have
		/// </summary>
		private readonly List<string> _imageExtensions = new List<string> { ".bmp", ".jpg", ".jpeg", ".jfif", ".gif", ".png" };

		/// <summary>
		/// A readonly string containing a FileDialog filter for carrier images
		/// </summary>
		private readonly string _carrierExtensionsFilter = "" +
				"Image files (*.bmp, *.gif, *.jpg, *.jpeg, *.jfif, *.png) | *.bmp; *.gif; *.jpg; *.jpeg; *.jfif; *.png; |" +
				"BMP files (*.bmp) | *.bmp; |" +
				"GIF files (*.gif) | *.gif; |" +
				"PNG files (*.png) | *.png; |" +
				"JPEG files (*.jpg, *.jpeg, *.jfif)| *.jpg; *.jpeg; *.jfif;";

		/// <summary>
		/// A readonly string containing a FileDialog filter for stego images
		/// </summary>
		private readonly string _stegoImageExtensionsFilter = "" +
				"Image files (*.bmp, *.png) | *.bmp; *.png; |" +
				"BMP files (*.bmp) | *.bmp; |" +
				"PNG files (*.png) | *.png;";

		/// <summary>
		/// A readonly string containing a FileDialog filter for message files
		/// </summary>
		private readonly string _messageExtensionsFilter = "" +
				"All Files (*.*) | *.*; |" +
				"Image files (*.bmp, *.gif, *.jpg, *.jpeg, *.jfif, *.png) | *.bmp; *.gif; *.jpg; *.jpeg; *.jfif; *.png; |" +
				"Office files (*.doc, *.docx, *.xls, *.ppt) | *.doc; *.docx; *.xls; *.ppt; |" +
				"Text files (*.txt, *.pdf) | *.txt; *.pdf;";

		/// <summary>
		/// A readonly string containing a default value for the labels
		/// to use when nothing else is displayed
		/// </summary>
		private readonly string _defaultLabelValue = "---";
		#endregion

		/// <summary>
		/// Constructor: Initializes the main frame.
		/// </summary>
		public Mainframe() {
			InitializeComponent();
		}

		/// <summary>
		/// Invokes the <see cref="HSF_HideAndSeek.Helper.FileManager"/> to load a carrier image from a specified path to the system.
		/// </summary>
		/// <param name="path">Preferably the absolute path of a desired carrier image</param>
		/// <param name="forceTrueColor">True if the image should be recreated in case it uses a wrong pixel format and false otherwise</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="OutOfMemoryException"></exception>
		/// <exception cref="Exceptions.WrongPixelFormatException">Always thrown when forceTrueColor is false but the image is not RGB-based</exception>
		/// <exception cref="FormatException"></exception>
		private void LoadCarrierImage(string path, bool forceTrueColor) {

			// Do nothing if the file does not exist 
			if (!File.Exists(path)) {
				return;
			}

			//  Do nothing if the image is stored using an inappropriate format
			if (!_imageExtensions.Contains(Path.GetExtension(path).ToLowerInvariant())) {
				return;
			}

			// Generate carrier image object
			_carrier = new StegoImage(
				_fm.ReadImageFile(path, forceTrueColor),
				Path.GetFileName(path),
				_fm.GetFileSizeInBytes(path)
			);

			// Display image
			carrierImagePictureBox.Image = _carrier.Image;

			// Fill labels with data
			carrierNameLabel.Text = _carrier.Name;
			carrierSizeLabel.Text = Converter.BytesToHumanReadableString(_carrier.SizeInBytes);
			carrierCapacityLabel.Text = Converter.BytesToHumanReadableString(
				_embedder.CalculateCapacity(_carrier, (byte) (bppComboBox.SelectedIndex + 1)));

			// Check GUI components
			CheckEverything();
		}

		/// <summary>
		/// Invokes the <see cref="HSF_HideAndSeek.Helper.FileManager"/> to load a stego image from a specified path to the system.
		/// </summary>
		/// <param name="path">Preferably the absolute path of a desired stego image</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="OutOfMemoryException"></exception>
		/// <exception cref="Exceptions.WrongPixelFormatException"></exception>
		/// <exception cref="FormatException"></exception>
		private void LoadStegoImage(string path) {

			// Do nothing if the file does not exist 
			if (!File.Exists(path)) {
				return;
			}

			//  Do nothing if the image is stored using an inappropriate format
			if (!_imageExtensions.Contains(Path.GetExtension(path).ToLowerInvariant())) {
				return;
			}

			// Generate stego image object
			_stegoImage = new StegoImage(
				_fm.ReadImageFile(path, false),
				Path.GetFileName(path),
				_fm.GetFileSizeInBytes(path)
			);

			// Display image
			stegoImagePictureBox.Image = _stegoImage.Image;

			// Fill labels with data
			stegoImageNameLabel.Text = _stegoImage.Name;
			stegoImageSizeLabel.Text = Converter.BytesToHumanReadableString(_stegoImage.SizeInBytes);

			// Check GUI components
			CheckEverything();
		}

		/// <summary>
		/// Invokes the <see cref="HSF_HideAndSeek.Helper.FileManager"/> to save a stego image to a specified path.
		/// </summary>
		/// <param name="stegoImage">The stego image object that should be written to the file system</param>
		/// <param name="path">Preferably the absolute path where the stego image should be written to</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		/// <exception cref="System.Runtime.InteropServices.ExternalException"></exception>
		private void SaveStegoImage(StegoImage stegoImage, string path) {
			_fm.WriteStegoImage(stegoImage.Image, path);
			stegoImageSizeLabel.Text = Converter.BytesToHumanReadableString(_fm.GetFileSizeInBytes(path));
		}

		/// <summary>
		/// Invokes the <see cref="HSF_HideAndSeek.Helper.FileManager"/> to load a message from a specified path.
		/// </summary>
		/// <param name="path">Preferably the absolute path of a message file</param>
		private void LoadMessage(string path) {

			//  Do nothing if the file does not exist
			if (!File.Exists(path)) {
				return;
			}

			// Generate message object
			_message = new StegoMessage(
				Path.GetFileName(path),
				_fm.ReadMessageFile(path)
			);

			// Fill labels with data
			messageNameLabel.Text = _message.Name;
			messageSizeLabel.Text = Converter.BytesToHumanReadableString(_message.FullSizeInBytes);

			// Check GUI components
			CheckEverything();
		}

		/// <summary>
		/// Removes the carrier image from the system.
		/// </summary>
		private void ClearCarrierImage() {

			// Reset carrier image object
			_carrier = null;

			// Remove image
			if (carrierImagePictureBox.Image != null) {
				carrierImagePictureBox.Image.Dispose();
				carrierImagePictureBox.Image = null;
			}
			
			// Remove data from labels
			carrierNameLabel.Text = _defaultLabelValue;
			carrierSizeLabel.Text = _defaultLabelValue;
			carrierCapacityLabel.Text = _defaultLabelValue;
			carrierRatingLabel.Text = _defaultLabelValue;

			// Check GUI components
			CheckEverything();
		}

		/// <summary>
		/// Removes the stego image from the system.
		/// </summary>
		private void ClearStegoImage() {

			// Reset stego image object
			_stegoImage = null;

			// Remove image
			if (stegoImagePictureBox.Image != null) {
				stegoImagePictureBox.Image.Dispose();
				stegoImagePictureBox.Image = null;
			}
			

			// Remove data from labels
			stegoImageNameLabel.Text = _defaultLabelValue;
			stegoImageSizeLabel.Text = _defaultLabelValue;

			// Check GUI components
			CheckEverything();
		}

		/// <summary>
		/// Removes the message from the system.
		/// </summary>
		private void ClearMessage() {

			// Reset message object
			_message = null;

			// Remove data from labels
			messageNameLabel.Text = _defaultLabelValue;
			messageSizeLabel.Text = _defaultLabelValue;

			// Check GUI components
			CheckEverything();
		}

		/// <summary>
		/// Loads resources for the mainframe.
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
			OpenFileDialog ofd = new OpenFileDialog {
				InitialDirectory = @"C:\",
				Multiselect = false,
				CheckPathExists = true,
				CheckFileExists = true,
				Title = @"Please select a carrier image file",
				Filter = _carrierExtensionsFilter
			};
			ofd.ShowDialog();

			try {
				LoadCarrierImage(ofd.FileName, false);
			} catch (WrongPixelFormatException) {
				DialogResult dialogResult = MessageBox.Show("Your image has an improper image file format" +
				                                            "which means that it is not RGB-based. " +
				                                            "Most likely the image is not a BMP or PNG\n\n" +
				                                            "Do you want the image to be losslessly transformed\nto an RGB-based image?",
					@"Improper pixel format!",
					MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes) {
					try {
						LoadCarrierImage(ofd.FileName, true);
					}
					catch (Exception ex) {
						MessageBox.Show(
							@"The sysem caught an exception:"
							+ "\nType:        " + ex.GetType().Name
							+ "\nMessage:  " + ex.Message,
							@"Critical error!",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error
						);
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void loadMessageButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog {
				InitialDirectory = @"C:\",
				Multiselect = false,
				CheckPathExists = true,
				CheckFileExists = true,
				Title = @"Please select a message file",
				Filter = _messageExtensionsFilter
			};
			ofd.ShowDialog();

			try {
				LoadMessage(ofd.FileName);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void loadStegoImageButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog {
				InitialDirectory = @"C:\",
				Multiselect = false,
				CheckPathExists = true,
				CheckFileExists = true,
				Title = @"Please select a stego image file",
				Filter = _stegoImageExtensionsFilter
			};
			ofd.ShowDialog();

			try {
				LoadStegoImage(ofd.FileName);
			}
			catch (WrongPixelFormatException) {
				MessageBox.Show(
					@"The provided stego image is not available in the RGB color space!",
					@"Improper stego image!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Asterisk
				);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void clearCarrierAndMessageButton_Click(object sender, EventArgs e) {
			ClearCarrierImage();
			ClearMessage();
		}

		private void clearStegoButton_Click(object sender, EventArgs e) {
			ClearStegoImage();
		}

		private void encryptMessageButton_Click(object sender, EventArgs e) {
			encryptMessageButton.Text = @"Encrypting ...";
			encryptMessageButton.Enabled = false;
			System.Threading.Thread.Sleep(150);
			try {
				_message.Payload = AES.Encrypt(_message.Payload, encryptionKeyTextbox.Text);
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(_message.FullSizeInBytes);
			} catch (CryptographicException) {
				MessageBox.Show(
					@"Could not encrypt the message.",
					@"Error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			encryptMessageButton.Text = @"Encrypt message";
			encryptMessageButton.Enabled = true;
		}

		private void hideMessageButton_Click(object sender, EventArgs e) {
			hideMessageButton.Text = @"Hiding ...";
			hideMessageButton.Enabled = false;

			try {
				// Generate stego image
				_stegoImage = _embedder.HideMessage(
					_carrier,
					_message,
					stegoPasswordTextbox.Text,
					bppComboBox.SelectedIndex + 1,
					bitPlaneFirstRadio.Checked
				);

				// Fill labels with data
				stegoImageNameLabel.Text = _stegoImage.Name;
				stegoImageSizeLabel.Text = _defaultLabelValue;

				// Display image
				stegoImagePictureBox.Image = _stegoImage.Image;

			} catch (MessageTooBigException) {
				MessageBox.Show(
					@"Could not hide the message since it is too big!",
					@"Error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			} catch (MessageNameTooBigException) {
				MessageBox.Show(
					@"Could not hide the message since its file name is too long!",
					@"Error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}

			// Check GUI components
			hideMessageButton.Text = @"Hide message";
			CheckEverything();
		}

		private void extractMesssageButton_Click(object sender, EventArgs e) {
			extractMessageButton.Text = @"Extracting ...";
			extractMessageButton.Enabled = false;

			try {
				_message = _embedder.ExtractMessage(
					_stegoImage,
					stegoPasswordTextbox.Text,
					bppComboBox.SelectedIndex + 1,
					bitPlaneFirstRadio.Checked
				);

				// Fill labels with data
				messageNameLabel.Text = _message.Name;
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(_message.FullSizeInBytes);

			} catch (OverflowException ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}

			// Check GUI components
			extractMessageButton.Text = @"Extract message";
			CheckEverything();
		}

		private void decryptMessageButton_Click(object sender, EventArgs e) {
			decryptMessageButton.Text = @"Decrypting ...";
			decryptMessageButton.Enabled = false;
			try {
				_message.Payload = AES.Decrypt(_message.Payload, encryptionKeyTextbox.Text);
				messageSizeLabel.Text = Converter.BytesToHumanReadableString(_message.FullSizeInBytes);
			} catch (CryptographicException) {
				MessageBox.Show(
					@"Could not decrypt the message with the given key. Either the key is wrong or the message is unencrypted.",
					@"Could not decrypt the message!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
				@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			decryptMessageButton.Text = @"Decrypt message";
			decryptMessageButton.Enabled = true;
		}

		private void rateButton_Click(object sender, EventArgs e) {
			rateButton.Text = @"Rating ...";
			rateButton.Enabled = false;

			try {
				carrierRatingLabel.Text = "" + _embedder.RateCarrier(_carrier, _message) + "%";
			} catch (MessageNameTooBigException) {
				MessageBox.Show(
					@"Could not rate the carrier since the message file's name is too long!",
					@"Error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			rateButton.Text = @"Rate carrier";
			rateButton.Enabled = true;
		}

		private void showStegoImageBitplanesButton_Click(object sender, EventArgs e) {
			showStegoImageBitplanesButton.Text = @"Generating bit planes ...";
			showStegoImageBitplanesButton.Enabled = false;

			if (_stegoImageBitPlaneForm == null || !_stegoImageBitPlaneForm.Visible) {
				_stegoImageBitPlaneForm = new BitPlaneForm("Stego image bit planes", _stegoImage.Image);
				_stegoImageBitPlaneForm.Show();
				//stegoImageBitPlaneForm.DisplayBitPlanes();

			} else {
				_stegoImageBitPlaneForm.Focus();
			}

			showStegoImageBitplanesButton.Text = @"Show stego image bit planes";
			showStegoImageBitplanesButton.Enabled = true;
		}

		private void helpButton_Click(object sender, EventArgs e) {
			if (_aboutBox == null || !_aboutBox.Visible) {
				_aboutBox = new AboutBox();
				_aboutBox.Show();
			} else {
				_aboutBox.Focus();
			}
		}

		private void encryptionKeyTextbox_TextChanged(object sender, EventArgs e) {
			CheckEncryption();
		}

		private void showCarrierBitplanesButton_Click(object sender, EventArgs e) {
			showCarrierBitplanesButton.Text = @"Generating bit planes ...";
			showCarrierBitplanesButton.Enabled = false;

			if (_carrierBitPlaneForm == null || !_carrierBitPlaneForm.Visible) {
				_carrierBitPlaneForm = new BitPlaneForm("Carrier image bit planes", _carrier.Image);
				_carrierBitPlaneForm.Show();
				_carrierBitPlaneForm.Name = "Carrier bit planes";
				//carrierBitPlaneForm.DisplayBitPlanes();

			} else {
				_carrierBitPlaneForm.Focus();
			}

			showCarrierBitplanesButton.Text = @"Show carrier bit planes";
			showCarrierBitplanesButton.Enabled = true;
		}

		private void saveStegoImageButton_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = @"Save the stego image";
			sfd.FileName = _stegoImage.Name;
			sfd.Filter = _stegoImageExtensionsFilter;
			sfd.ShowDialog();

			try {
				SaveStegoImage(_stegoImage, sfd.FileName);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void saveMessageButton_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = @"Save the message file";
			sfd.FileName = _message.Name;
			sfd.Filter = _messageExtensionsFilter;
			sfd.ShowDialog();

			try {
				_fm.WriteMessageFile(_message.Payload, sfd.FileName);
			} catch (Exception ex) {
				MessageBox.Show(
					@"The sysem caught an exception:"
					   + "\nType:        " + ex.GetType().Name
					   + "\nMessage:  " + ex.Message,
					@"Critical error!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void bppComboBox_SelectedIndexChanged(object sender, EventArgs e) {

			// Change label data
			if (_carrier != null) {
				carrierCapacityLabel.Text = Converter.BytesToHumanReadableString(
				_embedder.CalculateCapacity(_carrier, (byte) (bppComboBox.SelectedIndex + 1)));
			}

			// Check GUI components
			CheckEverything();
		}
		#endregion

		#region GUI component checker methods
		/// <summary>
		/// Wraps all checker methods together.
		/// </summary>
		private void CheckEverything() {
			CheckShowCarrierBitPlanes();
			CheckEncryption();
			CheckEmbedding();
			CheckSavingStegoImage();
			CheckExtraction();
			CheckSavingMessage();
		}

		/// <summary>
		/// Checks whether all requirements are set to extract and show all of the carrier's bit planes.
		/// </summary>
		/// <returns>true if all requirements are set and false otherwise</returns>
		private bool CheckShowCarrierBitPlanes() {
			if (_carrier == null) {
				showCarrierBitplanesButton.Enabled = false;
				return false;
			}

			showCarrierBitplanesButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Checks whether all requirements are set to hide a message.
		/// </summary>
		/// <returns>true if all requirements are set and false otherwise</returns>
		private bool CheckEmbedding() {
			if (_carrier == null || _message == null) {
				hideMessageButton.Enabled = false;
				rateButton.Enabled = false;
				return false;
			}

			if (_embedder.CalculateCapacity(_carrier, bppComboBox.SelectedIndex+1) < _message.FullSizeInBytes) {
				hideMessageButton.Enabled = false;
				rateButton.Enabled = false;
				messageSizeLabel.ForeColor = Color.Red;
				return false;
			}

			messageSizeLabel.ForeColor = Color.Black;
			hideMessageButton.Enabled = true;
			rateButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Checks whether all requirements are set to extract a message.
		/// </summary>
		/// <returns>true if all requirements are set and false otherwise</returns>
		private bool CheckExtraction() {
			if (_stegoImage == null) {
				showStegoImageBitplanesButton.Enabled = false;
				extractMessageButton.Enabled = false;
				return false;
			}
			showStegoImageBitplanesButton.Enabled = true;
			extractMessageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Checks whether all requirements are set to encrypt or decrypt a message.
		/// </summary>
		/// <returns>true if all requirements are set and false otherwise</returns>
		private bool CheckEncryption() {
			if (_message == null) {
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
		/// Checks whether all requirements are set to save a stego image to the drive.
		/// </summary>
		/// <returns>true if all requirements are set and false otherwise</returns>
		private bool CheckSavingStegoImage() {
			if (_stegoImage == null) {
				saveStegoImageButton.Enabled = false;
				return false;
			}

			saveStegoImageButton.Enabled = true;
			return true;
		}

		/// <summary>
		/// Checks whether all requirements are set to save a message file to the drive.
		/// </summary>
		/// <returns>true if all requirements are set and false otherwise</returns>
		private bool CheckSavingMessage() {
			if (_message == null) {
				saveMessageButton.Enabled = false;
				return false;
			}
			saveMessageButton.Enabled = true;
			return true;
		}
		#endregion
	}
}
