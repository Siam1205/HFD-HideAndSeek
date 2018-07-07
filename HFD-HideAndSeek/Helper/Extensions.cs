using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HFD_HideAndSeek.Helper {

	/// <summary>
	/// This class adds extension methods for to strings
	/// </summary>
	internal static class Extensions {

		/// <summary>
		/// Extension method:
		/// Splits string into chunks of a specified length.
		/// </summary>
		/// <param name="source">The string that should be splitted</param>
		/// <param name="maxLength">The chunk length</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <returns>The string array containing the chunks</returns>
		public static string[] SplitToChunks(this string source, int maxLength) {
			return source
				.Where((x, i) => i % maxLength == 0)
				.Select(
					(x, i) => new string(source
						.Skip(i * maxLength)
						.Take(maxLength)
						.ToArray()))
				.ToArray();
		}

		/// <summary>
		/// Extension method:
		/// Converts a string into an array of bytes.
		/// </summary>
		/// <param name="str">The string that should be converted</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns>The byte array representation of the string</returns>
		public static byte[] ConvertBitstringToByteArray(this string str) {
			byte[] data =
			  Regex.Matches(str, ".{8}").Cast<Match>()
			  .Select(m => Convert.ToByte(m.Groups[0].Value, 2))
			  .ToArray();
			return data;
		}
	}
}
