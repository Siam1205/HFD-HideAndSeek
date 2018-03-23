using HSF_HideAndSeek.Helper;
using HSF_HideAndSeek.Steganography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSF_HideAndSeek {
	public partial class Mainframe : Form {

		private FileManager fm = FileManager.Instance;
		private Embedder embedder = Embedder.Instance;

		private Bitmap carrierImage;
		private Bitmap stegoImage;
		private byte[] message;

		public Mainframe() {
			InitializeComponent();
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

		private void loadCarrierButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = @"C:\";
			ofd.Multiselect = false;
			ofd.RestoreDirectory = true;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			ofd.Title = "Please select a carrier image file";
			ofd.Filter = "Image files (*.bmp, *.gif, *.jpg, *.jpeg, *.jfif, *.png) | *.bmp; *.gif; *.jpg; *.jpeg; *.jfif; *.png";
			ofd.ShowDialog();
			carrierImage = fm.ReadImageFile(ofd.FileName, false);
			carrierImagePictureBox.Image = carrierImage;
		}

		private void clearCarrierAndMessageButton_Click(object sender, EventArgs e) {
			carrierImage = null;
			message = null;
			carrierImagePictureBox.Image = HSF_HideAndSeek.Properties.Resources.chooseAnImage;
		}
	}
}
