using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSF_HideAndSeek.Steganography.DataStructures {
	class StegoImage {

		private Bitmap image;
		private string name;
		private uint sizeInBytes;

		public StegoImage(Bitmap image, string name, uint sizeInBytes) {
			this.image = image;
			this.name = name;
			this.sizeInBytes = sizeInBytes;
		}

		public Bitmap Image {
			get {
				return image;
			}

			set {
				image = value;
			}
		}

		public string Name {
			get {
				return name;
			}

			set {
				name = value;
			}
		}

		public uint SizeInBytes {
			get {
				return sizeInBytes;
			}

			set {
				sizeInBytes = value;
			}
		}
	}
}
