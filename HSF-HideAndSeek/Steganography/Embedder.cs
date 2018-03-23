using HSF_HideAndSeek.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSF_HideAndSeek.Steganography {

	internal class Embedder {

		#region Singleton definition
		private static Embedder instance;

		private Embedder() {
		}

		public static Embedder Instance {
			get {
				if (instance == null) {
					instance = new Embedder();
				}
				return instance;
			}
		}
		#endregion

		/// <summary>
		/// Extracts a specific LSB from a byte and returns it as char
		/// </summary>
		/// <param name="inputByte"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <returns></returns>
		private char ExtractBitFromByte(byte inputByte, int pos) {
			if (pos < 0 || pos > 7) {
				throw new ArgumentException();
			}
			string bitPattern = Converter.DecimalToBinary(inputByte, 8);
			string lsb = bitPattern.Substring(pos, 1);
			return Convert.ToChar(lsb);
		}
	}
}
