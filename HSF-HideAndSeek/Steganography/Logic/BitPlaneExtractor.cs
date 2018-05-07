using System;
using System.Drawing;

namespace HSF_HideAndSeek.Steganography.Logic {

	/// <summary>
	/// This class represents a bit plane extractor which provides methods to extract the individual
	/// bit planes of a <see cref="System.Drawing.Bitmap"/> object.
	/// </summary>
	internal class BitPlaneExtractor {

		/// <summary>
		/// Extracts and returns a single bit planes of a given image's red color channel at a given position.
		/// </summary>
		/// <param name="image">The image of which the bit plane should be extracted</param>
		/// <param name="pos">The bit plane's bit position</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="Exception"></exception>
		/// <returns>A <see cref="System.Drawing.Bitmap"/> object representing the bit plane</returns>
		public static Bitmap ExtractSingleBitPlane(Bitmap image, byte pos) {

			// Variable declarations
			int width = image.Width;
			int height = image.Height;
			Color black = Color.FromArgb(0, 0, 0);
			Color white = Color.FromArgb(255, 255, 255);

			Bitmap bitPlane = new Bitmap(width, height);

			// Iterate over the whole image
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					Color pixel = image.GetPixel(x, y);
					byte red = pixel.R;

					// Set the pixel to black if the bit is set and to white otherwise
					bitPlane.SetPixel(x, y, IsBitSet(red, pos) ? black : white);
				} // for
			} // for
			return bitPlane;
		}

		/// <summary>
		/// Returns an array containing all bit planes of a given image's red color channel.
		/// </summary>
		/// <param name="image">The image of which the bit planes should be extracted</param>
		/// <exception cref="Exception"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>An array containing eight <see cref="System.Drawing.Bitmap"/> objects all of which represent one bit plane</returns>
		public static Bitmap[] ExtractRBitPlanes(Bitmap image) {

			// Variable declarations
			int width = image.Width;
			int height = image.Height;
			Color black = Color.FromArgb(0, 0, 0);
			Color white = Color.FromArgb(255, 255, 255);
			Bitmap[] bitPlanes = new Bitmap[8];

			// Iterate over all bit planes of each color value
			for (int pos = 0; pos <= 7; pos++) {
				bitPlanes[pos] = new Bitmap(width, height);

				// Iterate over the whole image
				for (int x = 0; x < width; x++) {
					for (int y = 0; y < height; y++) {
						Color pixel = image.GetPixel(x, y);
						byte red = pixel.R;

						// Set the pixel to black if the bit is set and to white otherwise
						bitPlanes[pos].SetPixel(x, y, IsBitSet(red, pos) ? black : white);
					} // for
				} // for
			} // for
			return bitPlanes;
		}

		/// <summary>
		/// Checks if a given bit inside a byte is set or not.
		/// </summary>
		/// <param name="b">The byte whose bit should be checked</param>
		/// <param name="pos">The position of the bit inside the byte</param>
		/// <returns></returns>
		private static bool IsBitSet(byte b, int pos) {
			return (b & (1 << pos)) != 0;
		}
	}
}
