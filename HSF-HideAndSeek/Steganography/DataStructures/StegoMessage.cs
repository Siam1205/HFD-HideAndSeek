namespace HSF_HideAndSeek.Steganography.DataStructures {

	/// <summary>
	/// This class represents a message as it is used for Steganography
	/// which means it can be any file.
	/// It simply contains the message file itself along with its file name
	/// and its file size in bytes.
	/// </summary>
	internal sealed class StegoMessage {

		/// <summary>
		/// Constructor:
		/// Creates a new <see cref="HSF_HideAndSeek.Steganography.DataStructures.StegoMessage"/> object.
		/// </summary>
		/// <param name="name">The message's file name</param>
		/// <param name="payload">The message itself</param>
		public StegoMessage(string name, byte[] payload) {
			Name = name;
			Payload = payload;
		}

		public string Name { get; set; }

		public byte[] Payload { get; set; }

		public uint PayloadSizeInBits => (uint) Payload.LongLength * 8;

		public uint FullSizeInBits => (uint) (Payload.LongLength * 8) + 536;

		public uint FullSizeInBytes => (uint) Payload.LongLength + 67;
	} // class
} // namespace