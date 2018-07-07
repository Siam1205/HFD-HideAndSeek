using System;
using System.Text;

namespace HFD_HideAndSeek.Helper {
	
	/// <summary>
	/// This class provides static methods for converting data into other representations or
	/// for converting a value from one data type into another one.
	/// </summary>
	internal class Converter {

		#region Conversions into binary string patterns
		/// <summary>
		/// Converts a string to a binary string pattern
		/// </summary>
		/// <param name="text">The text that should be converted into a series of bits</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="EncoderFallbackException"></exception>
		/// <returns></returns>
		public static string StringToBinary(string text) {
			UTF8Encoding encoding = new UTF8Encoding();
			byte[] buffer = encoding.GetBytes(text);

			StringBuilder sb = new StringBuilder();
			foreach (byte element in buffer) {
				sb.Append(Convert.ToString(element, 2));
			}
			return sb.ToString();
		}

		/// <summary>
		/// Converts a long variable to its binary string representation and fills it with a
		/// specified amount of zeros to the left.
		/// </summary>
		/// <param name="decimalNumber">The decimal number which is to be converted into a binary number</param>
		/// <param name="zeroPadding">The amount of zeros that the binary number should be padded with</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The binary representation of the given decimal number</returns>
		public static string DecimalToBinary(long decimalNumber, int zeroPadding) {
			if (zeroPadding != 0) {
				return Convert.ToString(decimalNumber, 2).PadLeft(zeroPadding, '0');
			}
			return Convert.ToString(decimalNumber, 2);
		}

		/// <summary>
		/// Converts a uint variable to its binary string representation and fills it with a
		/// specified amount of zeros to the left.
		/// </summary>
		/// <param name="decimalNumber">The decimal number which is to be converted into a binary number</param>
		/// <param name="zeroPadding">The amount of zeros that the binary number should be padded with</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The binary representation of the given decimal number</returns>
		public static string DecimalToBinary(uint decimalNumber, int zeroPadding) {
			if (zeroPadding != 0) {
				return Convert.ToString(decimalNumber, 2).PadLeft(zeroPadding, '0');
			}
			return Convert.ToString(decimalNumber, 2);
		}

		/// <summary>
		/// Converts a byte variable to its binary string representation and fills it with a
		/// specified amount of zeros to the left.
		/// </summary>
		/// <param name="decimalNumber">The decimal number which is to be converted into a binary number</param>
		/// <param name="zeroPadding">The amount of zeros that the binary number should be padded with</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The binary representation of the given decimal number</returns>
		public static string DecimalToBinary(byte decimalNumber, int zeroPadding) {
			if (zeroPadding != 0) {
				return Convert.ToString(decimalNumber, 2).PadLeft(zeroPadding, '0');
			}
			return Convert.ToString(decimalNumber, 2);
		}

		/// <summary>
		/// Converts a byte array to its binary string representation.
		/// For this purpose no padding is necessary since a byte variable always uses 8 digits.
		/// </summary>
		/// <param name="array">The byte array which is to be converted into a binary string</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The binary representation of the given byte array</returns>
		public static string ByteArrayToBinary(byte[] array) {
			StringBuilder sb = new StringBuilder();
			foreach (byte by in array) {
				sb.Append(DecimalToBinary(by, 8));
			}
			return sb.ToString();
		}
		#endregion

		/// <summary>
		/// Converts a binary string pattern to its respective UTF8 text representation.
		/// </summary>
		/// <param name="text">The binary string that should be converted to a text</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="DecoderFallbackException"></exception>
		/// <returns>The textual representation of the given binary string</returns>
		public static string BinaryToString(string text) {
			//byte[] temp = Extensions.ConvertBitstringToByteArray(text);
			byte[] temp = text.ConvertBitstringToByteArray();

			string val = Encoding.UTF8.GetString(temp);
			return val;
		}

		/// <summary>
		/// Converts a binary string pattern to a byte variable
		/// </summary>
		/// <param name="binary">The binary string pattern</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns>The byte value</returns>
		public static byte BinaryToByte(string binary) {
			byte by = Convert.ToByte(binary, 2);
			return by;
		}

		/// <summary>,
		/// Converts a binary string pattern to a byte array
		/// </summary>
		/// <param name="binary">The binary string pattern</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns>The byte array</returns>
		public static byte[] BinaryToByteArray(string binary) {
			return binary.ConvertBitstringToByteArray();
		}

		/// <summary>
		/// Converts a binary string pattern to a uint variable
		/// </summary>
		/// <param name="binary">The binary string pattern</param>
		/// /// <exception cref="ArgumentException"></exception>
		/// /// <exception cref="ArgumentOutOfRangeException"></exception>
		/// /// <exception cref="FormatException"></exception>
		/// /// <exception cref="OverflowException"></exception>
		/// <returns>The uint variable</returns>
		public static uint BinaryToUint(string binary) {
			uint unsignedInt = Convert.ToUInt32(binary, 2);
			return unsignedInt;
		}

		/// <summary>
		/// Converts a uint variable storing a value in bits
		/// to a double variable storing the same value but in kB
		/// </summary>
		/// <param name="bits">The value in bits</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The value in kilo bytes</returns>
		public static double BitsToKiloBytes(uint bits) {
			// ReSharper disable once PossibleLossOfFraction
			float bytes = bits / 8;
			float kiloBytes = bytes / 1024;
			return Math.Round(kiloBytes, 5);
		}

		/// <summary>
		/// Converts a value in bytes to its human readable string representation
		/// </summary>
		/// <param name="bytes">The value in bytes</param>
		/// <returns>The string containing the value with a suiting SI unit</returns>
		public static string BytesToHumanReadableString(double bytes) {
			string[] sizes = { "B", "KB", "MB", "GB", "TB" };
			int order = 0;
			while (bytes >= 1024 && order < sizes.Length - 1) {
				order++;
				bytes = bytes / 1024;
			}
			return String.Format("{0:0.##} {1}", bytes, sizes[order]);
		}
	}
}
