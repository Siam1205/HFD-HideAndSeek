using HSF_HideAndSeek.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSF_HideAndSeek.Helper {
	class FileManager {

		#region Singleton definition
		private static FileManager instance;

		private FileManager() {

		}

		public static FileManager Instance {
			get {
				if (instance == null) {
					instance = new FileManager();
				}
				return instance;
			}
		}
		#endregion


		/// <summary>
		/// Read a message file and return it using an array of bytes
		/// </summary>
		/// <param name="path"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="UnauthorizedAccessException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <returns></returns>
		public byte[] ReadMessageFile(string path) {
			return File.ReadAllBytes(path);
		}


		/// <summary>
		/// Loads an image without creating a memory-mapped file
		/// which creates a lock to the file referenced to by the path argument
		/// </summary>
		/// <param name="path"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="OutOfMemoryException"></exception>
		/// <exception cref="WrongPixelFormatException"></exception>
		/// <returns></returns>
		public Bitmap ReadImageFile(string path, bool forceTrueColor) {
			using (var img = Image.FromFile(path)) {
				PixelFormat pf = img.PixelFormat;
				bool wrongPixelFormat = false;
				switch (pf) {
					//case PixelFormat.Alpha:
					//	break;
					//case PixelFormat.PAlpha:
					//	break;
					//case PixelFormat.Canonical:
					//	break;
					case PixelFormat.Undefined:
						wrongPixelFormat = true;
						break;
					case PixelFormat.Indexed:
						wrongPixelFormat = true;
						break;
					case PixelFormat.Format8bppIndexed:
						wrongPixelFormat = true;
						break;
					case PixelFormat.Format4bppIndexed:
						wrongPixelFormat = true;
						break;
					case PixelFormat.Format1bppIndexed:
						wrongPixelFormat = true;
						break;
					default:
						break;
				}

				if (wrongPixelFormat) {
					if (forceTrueColor) {
						Bitmap bp = new Bitmap(img);
						Bitmap newImg = new Bitmap(img.Width, img.Height);
						newImg = bp;
						return newImg;
					} else {
						throw new WrongPixelFormatException();
					}
				} else {
					return new Bitmap(img);
				}
			} // using
		} // method

		/// <summary>
		/// Returns a long variable storing the size of a file specified by a path in bytes
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public long getFileSizeInBytes(string path) {
			long len = new FileInfo(path).Length;
			return len;
		}
	}
}
