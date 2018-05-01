using System;
using System.Drawing;

namespace HSF_HideAndSeek.Steganography {
	internal class BitPlaneExtractor {

		/// <summary>
		/// Extracts and returns a single bit planes of a given image's red color channel at a given position
		/// </summary>
		/// <param name="image"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
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
		/// Extracts and returns all of bit planes of a given image's red color channel inside an array
		/// </summary>
		/// <param name="image"></param>
		/// <exception cref="Exception"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns></returns>
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
		/// Checks if a given bit inside a byte is set or not
		/// </summary>
		/// <param name="b"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		private static bool IsBitSet(byte b, int pos) {
			return (b & (1 << pos)) != 0;
		}
	}
}
