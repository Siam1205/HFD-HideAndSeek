using System.Drawing;

namespace HFD_HideAndSeek.Steganography.DataStructures {

	/// <summary>
	/// This class represents an image as it is used for Steganography
	/// which means it can either be a carrier or a stego image.
	/// It simply contains the image itself along with its file name
	/// and its file size in bytes.
	/// </summary>
	internal sealed class StegoImage {

		/// <summary>
		/// Constructor: Creates a <see cref="StegoImage"/> object.
		/// </summary>
		/// <param name="image">The image itself</param>
		/// <param name="name">The image's file name</param>
		/// <param name="sizeInBytes">The file's size in bytes</param>
		public StegoImage(Bitmap image, string name, uint sizeInBytes) {
			Image = image;
			Name = name;
			SizeInBytes = sizeInBytes;
		}

		public Bitmap Image { get; set; }

		public string Name { get; set; }

		public uint SizeInBytes { get; set; }
	}
}
