using System;

namespace HFD_HideAndSeek.Exceptions {

	/// <summary>
	/// The exception that is thrown when the name of a message is too big
	/// to fit into the bytes allocated for encoding it within the carrier.
	/// </summary>
	internal class MessageNameTooBigException : Exception {

	}
}
