using HSF_HideAndSeek.Steganography.Logic;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HSF_HideAndSeek.Forms {
	
	/// <summary>
	/// This class represents a form for the only purpose of displaying the eight red bit planes of a given carrier or stego image.
	/// </summary>
	public sealed partial class BitPlaneForm : Form {

		/// <summary>
		/// The original image the bit planes are to be extracted from
		/// </summary>
		private readonly Bitmap _image;

		/// <summary>
		/// Constructor: Generates a new form with a given name and
		/// displays the eight bit planes (red color channel) of the given image one after another.
		/// </summary>
		/// <param name="title">The form's title</param>
		/// <param name="image">The image whose bit planes are to be extracted from</param>
		public BitPlaneForm(string title, Bitmap image) {
			InitializeComponent();
			_image = new Bitmap(image);
			Text = title;
			
			// Prevent the GUI from blocking by generating the bit planes inside a new thread
			Thread thread = new Thread(DisplayBitPlanes);
			thread.Start();
		}

		/// <summary>
		/// Fills the picture boxes with the bit plane images
		/// </summary>
		private void DisplayBitPlanes() {
			bitPlanePictureBox0.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 0);
			//Update();
			bitPlanePictureBox1.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 1);
			//Update();
			bitPlanePictureBox2.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 2);
			//Update();
			bitPlanePictureBox3.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 3);
			//Update();
			bitPlanePictureBox4.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 4);
			//Update();
			bitPlanePictureBox5.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 5);
			//Update();
			bitPlanePictureBox6.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 6);
			//Update();
			bitPlanePictureBox7.Image = BitPlaneExtractor.ExtractSingleBitPlane(_image, 7);
		}

		/// <summary>
		/// Free memory while closing the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BitPlaneForm_FormClosing(object sender, FormClosingEventArgs e) {
			try {
				bitPlanePictureBox0.Image.Dispose();
				bitPlanePictureBox1.Image.Dispose();
				bitPlanePictureBox2.Image.Dispose();
				bitPlanePictureBox3.Image.Dispose();
				bitPlanePictureBox4.Image.Dispose();
				bitPlanePictureBox5.Image.Dispose();
				bitPlanePictureBox6.Image.Dispose();
				bitPlanePictureBox7.Image.Dispose();
			} catch (Exception) {
				//this.Dispose();
			}
		}
	}
}
