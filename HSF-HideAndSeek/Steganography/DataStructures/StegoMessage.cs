namespace HSF_HideAndSeek.Steganography.DataStructures {

	internal sealed class StegoMessage {

		private string name;
		private byte[] payload;

		public string Name {
			get {
				return name;
			}

			set {
				name = value;
			}
		}

		public uint PayloadSizeInBits {
			get {
				return (uint) payload.LongLength*8;
			}
		}

		public byte[] Payload {
			get {
				return payload;
			}

			set {
				payload = value;
			}
		}

		public uint FullSizeInBits {
			get {
				return (uint) (payload.LongLength * 8) + 536;
			}
		}

		public uint FullSizeInBytes {
			get {
				return (uint) payload.LongLength + 67;
			}
		}

		public StegoMessage(string name, byte[] payload) {
			this.Name = name;
			this.Payload = payload;
		}
	} // class
} // namespace