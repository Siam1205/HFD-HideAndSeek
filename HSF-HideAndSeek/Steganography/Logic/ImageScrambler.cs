using System;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace HSF_HideAndSeek.Steganography.Logic {

	/// <summary>
	/// This class provides static methods for scramblinga the pixels of a <see cref="System.Drawing.Bitmap"/> object.
	/// The whole class and its methods are slightly modified versions of the code found
	/// <a href="https://codegolf.stackexchange.com/questions/35005/rearrange-pixels-in-image-so-it-cant-be-recognized-and-then-get-it-back/35034">here</a>.
	/// </summary>
	internal class ImageScrambler {

		#region First algorithm
		/// <summary>
		/// Self-inversly scramble all pixels of a <see cref="System.Drawing.Bitmap"/> object.
		/// </summary>
		/// <param name="bmp">The image whose pixels are to be scrambled</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The image with scrambled pixels</returns>
		public static Bitmap ScrambleOne(Bitmap bmp) {
			var res = new Bitmap(bmp);
			var r = new Random(1);

			// Making lists of even and odd numbers and shuffling them
			// They contain numbers between 0 and picture.Width (or picture.Height)
			var rX = Enumerable.Range(0, bmp.Width / 2).Select(x => x * 2).OrderBy(x => r.Next()).ToList();
			var rrX = rX.Select(x => x + 1).OrderBy(x => r.Next()).ToList();
			var rY = Enumerable.Range(0, bmp.Height / 2).Select(x => x * 2).OrderBy(x => r.Next()).ToList();
			var rrY = rY.Select(x => x + 1).OrderBy(x => r.Next()).ToList();

			for (int y = 0; y < bmp.Height; y++) {
				for (int x = 0; x < rX.Count; x++) {
					// Swapping pixels in a row using lists rX and rrX
					res.SetPixel(rrX[x], y, bmp.GetPixel(rX[x], y));
					res.SetPixel(rX[x], y, bmp.GetPixel(rrX[x], y));
				}
			}
			for (int x = 0; x < bmp.Width; x++) {
				for (int y = 0; y < rY.Count; y++) {
					// Swapping pixels in a column using sets rY and rrY
					var px = res.GetPixel(x, rrY[y]);
					res.SetPixel(x, rrY[y], res.GetPixel(x, rY[y]));
					res.SetPixel(x, rY[y], px);
				}
			}

			return res;
		}
		#endregion

		#region Second algorithm
		/// <summary>
		/// Self-inversly scramble all pixels of a <see cref="System.Drawing.Bitmap"/> object.
		/// </summary>
		/// <param name="image">The image whose pixels are to be scrambled</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The image with scrambled pixels</returns>
		public static Bitmap ScrambleTwo(Bitmap image) {
			var origImage = image;
			using (var tmpImage = new Bitmap(origImage)) {
				{
					int x = origImage.Width;
					while (x > 0) {
						int xbit = x & -x;
						do {
							x--;
							var xalt = BitReverse(x, xbit);
							for (int y = 0; y < origImage.Height; y++) {
								tmpImage.SetPixel(xalt, y, origImage.GetPixel(x, y));
							}
						} while ((x & (xbit - 1)) != 0);
					}
				}

				{
					int y = origImage.Height;
					while (y > 0) {
						int ybit = y & -y;
						do {
							y--;
							var yalt = BitReverse(y, ybit);
							for (int x = 0; x < origImage.Width; x++) {
								origImage.SetPixel(x, yalt, tmpImage.GetPixel(x, y));
							}
						} while ((y & (ybit - 1)) != 0);
					}
				}
				return origImage;
			}
		}

		/// <summary>
		/// Helper method for the second algorithm
		/// </summary>
		/// <param name="n"></param>
		/// <param name="bit"></param>
		/// <returns></returns>
		private static int BitReverse(int n, int bit) {
			if (bit < 4) {
				return n;
			}
			int r = n & ~(bit - 1);
			int tmp = 1;
			while (bit > 1) {
				bit >>= 1;
				if ((n & bit) != 0)
					r |= tmp;
				tmp <<= 1;
			}
			return r;
		}
		#endregion

		#region Third algorithm
		/// <summary>
		/// Self-inversly scramble all pixels of a <see cref="System.Drawing.Bitmap"/> object.
		/// </summary>
		/// <param name="image">The image whose pixels are to be scrambled</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The image with scrambled pixels</returns>
		public static Bitmap ScrambleThree(Bitmap image) {
			var origImage = image;
			var newImage = new Bitmap(origImage);

			BigInteger totalPixels = origImage.Width * origImage.Height;
			BigInteger modSquare = GetSquareRootOf1(totalPixels);
			for (var x = 0; x < origImage.Width; x++) {
				for (var y = 0; y < origImage.Height; y++) {
					var newNum = modSquare * GetPixelNumber(new Point(x, y), origImage.Size) % totalPixels;
					var newPoint = GetPoint(newNum, origImage.Size);
					newImage.SetPixel(newPoint.X, newPoint.Y, origImage.GetPixel(x, y));
				}
			}
			return newImage;
		}

		/// <summary>
		/// Helper method for the third algorithm
		/// </summary>
		/// <param name="point"></param>
		/// <param name="totalSize"></param>
		/// <returns></returns>
		private static BigInteger GetPixelNumber(Point point, Size totalSize) {
			return totalSize.Width * point.Y + point.X;
		}

		/// <summary>
		/// Helper method for the third algorithm
		/// </summary>
		/// <param name="pixelNumber"></param>
		/// <param name="totalSize"></param>
		/// <returns></returns>
		private static Point GetPoint(BigInteger pixelNumber, Size totalSize) {
			return new Point((int) (pixelNumber % totalSize.Width), (int) (pixelNumber / totalSize.Width));
		}

		/// <summary>
		/// Helper method for the third algorithm
		/// </summary>
		/// <param name="modulo"></param>
		/// <returns></returns>
		private static BigInteger GetSquareRootOf1(BigInteger modulo) {
			for (var i = (BigInteger) 2; i < modulo - 1; i++) {
				if ((i * i) % modulo == 1)
					return i;
			}
			return modulo - 1;
		}
		#endregion
	}
}
