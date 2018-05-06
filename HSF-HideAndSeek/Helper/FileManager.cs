using System;
using HSF_HideAndSeek.Exceptions;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace HSF_HideAndSeek.Helper {

	/// <summary>
	/// This class represents a file manager which offers methods for reading or writing files
	/// and getting the size of files saved on the drive.
	/// There will only be one instance of this class be active at a time.
	/// </summary>
	internal class FileManager {

		#region Singleton definition
		/// <summary>
		/// Singleton instance of the <see cref="HSF_HideAndSeek.Helper.FileManager"/> class
		/// </summary>
		private static FileManager _instance;

		/// <summary>
		/// Private constructor according to the singleton design pattern.
		/// </summary>
		private FileManager() {

		}

		/// <summary>
		/// Returns the singleton instance of the class or creates it in case there is none.
		/// </summary>
		public static FileManager Instance => _instance ?? (_instance = new FileManager());
		#endregion

		/// <summary>
		/// Reads a message file from a given path and returns it as a byte array.
		/// </summary>
		/// <param name="path">Preferably the absolute path of the file to read</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="UnauthorizedAccessException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <returns>The byte array that represents the read file</returns>
		public byte[] ReadMessageFile(string path) {
			return File.ReadAllBytes(path);
		}

		/// <summary>
		/// Loads an image from the drive and returns it as <see cref="System.Drawing.Bitmap"/> object.
		/// Thereby, no memory-mapped file is created which would create a lock
		/// to the file referenced by the path argument.
		/// </summary>
		/// <param name="path">Preferably the absolute path of the image to read</param>
		/// <param name="forceTrueColor">True if the image should be recreated in case it is not RGB-based</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="OutOfMemoryException"></exception>
		/// <exception cref="WrongPixelFormatException">Always thrown when forceTrueColor is false but the image is not RGB-based</exception>
		/// <returns>The <see cref="System.Drawing.Bitmap"/> object that represents the loaded image</returns>
		public Bitmap ReadImageFile(string path, bool forceTrueColor) {
			using (var img = Image.FromFile(path)) {
				PixelFormat pf = img.PixelFormat;

				// Check whether the image is RGB-based
				if (pf == PixelFormat.Format24bppRgb ||
				    pf == PixelFormat.Format32bppRgb ||
				    pf == PixelFormat.Format48bppRgb ||
				    pf == PixelFormat.Format32bppArgb ||
				    pf == PixelFormat.Format64bppArgb) {

					return new Bitmap(img);
				}

				// If pixel format is wrong but the image should NOT be recreated
				if (!forceTrueColor) {
					throw new WrongPixelFormatException();
				}

				// If the image should be recreated
				Bitmap bp = new Bitmap(img);
				Bitmap newImg = new Bitmap(img.Width, img.Height);
				newImg = bp;
				return newImg;
			} // using
		}

		/// <summary>
		/// Returns the size of a file specified by the path argument in bytes.
		/// </summary>
		/// <param name="path">Preferably the absolute path of the file whose size is to be returned</param>
		/// <returns>The size of the file in bytes</returns>
		public uint GetFileSizeInBytes(string path) {
			return (uint) new FileInfo(path).Length;
		}

		/// <summary>
		/// Writes a message file to the specified path.
		/// </summary>
		/// <param name="message">The message file that should be saved to the drive</param>
		/// <param name="path">Preferably the absolute path that specifies where the file should be saved</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
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
		/// Writes a carrier or stego image to the given path.
		/// </summary>
		/// <param name="stegoImage">The stego image that should be saved to the drive</param>
		/// <param name="path">Preferably the absolute path that specifies where the image should be saved</param>
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
