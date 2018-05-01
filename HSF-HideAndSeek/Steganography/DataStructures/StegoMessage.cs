namespace HSF_HideAndSeek.Steganography.DataStructures {

	internal sealed class StegoMessage {
		private byte[] _payload;

		public string Name { get; set; }

		public uint PayloadSizeInBits {
			get {
				return (uint) _payload.LongLength*8;
			}
		}

		public byte[] Payload {
			get {
				return _payload;
			}

			set {
				_payload = value;
			}
		}

		public uint FullSizeInBits {
			get {
				return (uint) (_payload.LongLength * 8) + 536;
			}
		}

		public uint FullSizeInBytes {
			get {
				return (uint) _payload.LongLength + 67;
			}
		}

		public StegoMessage(string name, byte[] payload) {
			Name = name;
			Payload = payload;
		}
	} // class
} // namespace