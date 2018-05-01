using System.Drawing;

namespace HSF_HideAndSeek.Steganography.DataStructures {
	class StegoImage {
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
