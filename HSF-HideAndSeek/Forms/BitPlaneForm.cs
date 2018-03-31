using HSF_HideAndSeek.Steganography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSF_HideAndSeek.Forms {
	public partial class BitPlaneForm : Form {

		private Bitmap image;

		/// <summary>
		/// Constructor: Generates a new form with a given name and
		/// displays the eight bit planes (red color channel) of the given image
		/// </summary>
		/// <param name="title">The form's title</param>
		/// <param name="image">The image whose bit planes are to be shown</param>
		public BitPlaneForm(string title, Bitmap image) {
			InitializeComponent();
			this.image = new Bitmap(image);
			this.Text = title;
			
			// Prevent the GUI from blocking by generating the bit planes inside a new thread
			Thread thread = new Thread(new ThreadStart(displayBitPlanes));
			thread.Start();
		}

		/// <summary>
		/// Fills the picture boxes with the bit plane images
		/// </summary>
		private void displayBitPlanes() {
			bitPlanePictureBox0.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 0);
			//Update();
			bitPlanePictureBox1.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 1);
			//Update();
			bitPlanePictureBox2.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 2);
			//Update();
			bitPlanePictureBox3.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 3);
			//Update();
			bitPlanePictureBox4.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 4);
			//Update();
			bitPlanePictureBox5.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 5);
			//Update();
			bitPlanePictureBox6.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 6);
			//Update();
			bitPlanePictureBox7.Image = BitPlaneExtractor.ExtractSingleBitPlane(image, 7);
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
