using HSF_HideAndSeek.Exceptions;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

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
		}

		/// <summary>
		/// Returns a long variable storing the size of a file specified by a path in bytes
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public uint getFileSizeInBytes(string path) {
			return (uint) new FileInfo(path).Length;
		}

		/// <summary>
		/// Write a message file to the specified path
		/// </summary>
		/// <param name="message"></param>
		/// <param name="path"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		/// <exception cref="ObjectDisposedException"></exception>
		public void WriteMessageFile(byte[] message, string path) {
			using (var fs = new FileStream(path, FileMode.Create)) {
				fs.Write(message, 0, message.Length);
			}
		}

		/// <summary>
		/// Writes a stego image to the given path
		/// </summary>
		/// <param name="stegoImage"></param>
		/// <param name="path"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		/// <exception cref="System.Runtime.InteropServices.ExternalException"></exception>
		public void WriteStegoImage(Bitmap stegoImage, string path) {

			// Retrieve the image extension from the destination path
			string extension = Path.GetExtension(path);

			// Set the image format used to write the stego file
			ImageFormat format;
			switch (extension) {
				case ".bmp":
					format = ImageFormat.Bmp;
					break;
				default:
					format = ImageFormat.Png;
					break;
			}
			using (FileStream fs = new FileStream(path, FileMode.Create)) {
				stegoImage.Save(fs, format);
			}
		}
	}
}
