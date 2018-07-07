using System;
using System.Drawing;
using System.IO;
using System.Text;
using HFD_HideAndSeek.Cryptography;
using HFD_HideAndSeek.Exceptions;
using HFD_HideAndSeek.Helper;
using HFD_HideAndSeek.Steganography.DataStructures;

namespace HFD_HideAndSeek.Steganography.Logic {

	/// <summary>
	/// This class represents a message embedder which provides methods to embed or extract steganographical messages.
	/// Such messages can be any file. On the other hand, the medium a message can be hidden within must be a <see cref="System.Drawing.Bitmap"/> object
	/// which is available in the Format24bppRgb pixel format. Such images are most likely BMPs or PNGs.
	/// </summary>
	internal class Embedder {

		#region Singleton definition

		/// <summary>
		/// Singleton instance of the <see cref="Embedder"/> class
		/// </summary>
		private static Embedder _instance;

		/// <summary>
		/// Private constructor according to the singleton design pattern.
		/// </summary>
		private Embedder() {

		}

		/// <summary>
		/// Returns the singleton instance of the class or creates it in case there is none.
		/// </summary>
		public static Embedder Instance => _instance ?? (_instance = new Embedder());

		#endregion

		/// <summary>
		/// Hides a <see cref="StegoMessage"/> object inside a
		/// <see cref="StegoImage"/> object.
		/// </summary>
		/// <param name="carrierImage">The carrier image which is to be used to hide the message</param>
		/// <param name="message">The message which is to be hidden inside the carrier image</param>
		/// <param name="stegoPassword">The password which is to be used to hide the message (Randomized Hide and Seek)</param>
		/// <param name="bitPlanes">The amount of bit planes that are to be used to hide the message</param>
		/// <param name="bitPlanesFirst">true for bit planes first-mode and false for pixels first-mode</param>
		/// <exception cref="MessageNameTooBigException"></exception>
		/// <exception cref="MessageTooBigException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="EncoderFallbackException"></exception>
		/// <exception cref="ObjectDisposedException"></exception>
		/// <exception cref="System.Reflection.TargetInvocationException"></exception>
		/// <exception cref="Exception"></exception>
		/// <returns>The stego image containing the hidden message</returns>
		public StegoImage HideMessage(
			StegoImage carrierImage,
			StegoMessage message,
			string stegoPassword,
			int bitPlanes,
			bool bitPlanesFirst) {

			// Check if a password is set
			bool passwordSet = !(stegoPassword.Equals(""));

			// Generate stego image (Pass by reference)
			StegoImage stegoImage = new StegoImage(
				new Bitmap(
					carrierImage.Image
				),
				carrierImage.Name,
				carrierImage.SizeInBytes
			);

			// Rename the stego image
			stegoImage.Name = "stegged_" + Path.GetFileNameWithoutExtension(stegoImage.Name) + ".png";

			// Base variable declaration
			int carrierWidth = carrierImage.Image.Width;
			int carrierHeight = carrierImage.Image.Height;
			uint maxCarrierPixels = (uint) (carrierWidth * carrierHeight);
			uint pixelDistance = 1;

			// Get the binary string of a message object and its length
			string completeMessage = GenerateMessageBitPattern(message);
			uint completeMessageLength = (uint) completeMessage.Length;

			// Throw exception if the message is too big
			uint carrierCapacity = CalculateCapacity(carrierImage, bitPlanes);
			if (completeMessageLength > carrierCapacity * 8) {
				throw new MessageTooBigException();
			}

			// If a stego password is specified, scramble the image and change the pixelDistance value
			if (passwordSet) {

				// Transform the password into a value defining the distance between pixels
				byte[] passwordBytes = Encoding.UTF8.GetBytes(stegoPassword);
				passwordBytes = Hasher.HashSha256(passwordBytes);
				pixelDistance = (uint) ((ulong) BitConverter.ToInt64(passwordBytes, 0) % maxCarrierPixels);

				// Scramble image
				stegoImage.Image = ImageScrambler.ScrambleOne(stegoImage.Image);
				stegoImage.Image = ImageScrambler.ScrambleThree(stegoImage.Image);
				stegoImage.Image = ImageScrambler.ScrambleTwo(stegoImage.Image);
			}

			// Hiding variables
			int messageBitCounter = 0;      // Counter iterating over all message bits
			uint currentPixel = 0;          // Variable storing the currently considered pixel
			uint restClassCounter = 0;      // Counter iterating over all rest classes
			byte bitPlaneSelector = 0;      // Variable used to select which bit plane is used for embedding

			// While there is something left to hide
			while (messageBitCounter < completeMessageLength) {

				var currentPixelXValue = (int) (currentPixel % carrierWidth);	// x coordinate of current pixel
				var currentPixelYValue = (int) (currentPixel / carrierWidth);	// y coordinate of current pixel

				// Get current pixel
				var pixel = stegoImage.Image.GetPixel(currentPixelXValue, currentPixelYValue);	// Pixel object used to generate the new color

				// Define which of the three LSBs of a pixel should be used
				byte color;
				switch (messageBitCounter % 3) {
					case 0:
						color = SetBit(pixel.R, completeMessage[messageBitCounter].ToString(), bitPlaneSelector);
						stegoImage.Image.SetPixel(currentPixelXValue, currentPixelYValue, Color.FromArgb(color, pixel.G, pixel.B));
						break;
					case 1:
						color = SetBit(pixel.G, completeMessage[messageBitCounter].ToString(), bitPlaneSelector);
						stegoImage.Image.SetPixel(currentPixelXValue, currentPixelYValue, Color.FromArgb(pixel.R, color, pixel.B));
						break;
					case 2:
						color = SetBit(pixel.B, completeMessage[messageBitCounter].ToString(), bitPlaneSelector);
						stegoImage.Image.SetPixel(currentPixelXValue, currentPixelYValue, Color.FromArgb(pixel.R, pixel.G, color));

						// If the whole bit plane should be filled before a pixel should be reused
						if (bitPlanesFirst) {

							// Go to the next pixel
							currentPixel += pixelDistance;

							// If the pixel exceeds the maximum amount of pixels
							// go to the next rest class
							if (currentPixel >= maxCarrierPixels) {
								currentPixel = ++restClassCounter;

								// If all rest classes are exhausted,
								// begin at pixel 0 again but go to the next bit plane
								if (restClassCounter >= pixelDistance) {
									currentPixel = 0;
									restClassCounter = 0;
									bitPlaneSelector++;
								}
							}

						// If a pixel should be used in full before the next pixel is chosen
						} else {

							// Go to the next bit plane
							bitPlaneSelector++;

							// If all allowed bits of a single pixel are used
							// go to the next pixel
							if (bitPlaneSelector >= bitPlanes) {
								currentPixel += pixelDistance;
								bitPlaneSelector = 0;

								// If the pixel exceeds the maximum amount of pixels
								// go to the next rest class
								if (currentPixel >= maxCarrierPixels) {
									currentPixel = ++restClassCounter;
								}
							} // if
						} // else
						break;
				} // switch
				messageBitCounter++;
			}

			// If a password has been used, scramble back the image
			if (passwordSet) {
				stegoImage.Image = ImageScrambler.ScrambleOne(ImageScrambler.ScrambleThree(ImageScrambler.ScrambleTwo(stegoImage.Image)));
			}
			return stegoImage;
		}

		/// <summary>
		/// Extracts a <see cref="StegoMessage"/> object from a
		/// <see cref="StegoImage"/> object.
		/// </summary>
		/// <param name="stegoImage">The stego image which hides the message</param>
		/// <param name="stegoPassword">The password used to hide the message (Randomized Hide and Seek)</param>
		/// <param name="bitPlanes">The amount of bit planes that have been used to hide the message</param>
		/// <param name="bitPlanesFirst">true for bit planes first-mode and false for pixels first-mode</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ObjectDisposedException"></exception>
		/// <exception cref="System.Reflection.TargetInvocationException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="DecoderFallbackException"></exception>
		/// <exception cref="Exception"></exception>
		/// <returns>The message that has been hidden inside the stego image</returns>
		public StegoMessage ExtractMessage(StegoImage stegoImage,
			string stegoPassword,
			int bitPlanes,
			bool bitPlanesFirst) {

			// Generate new stego image object to omit fucking pass by reference
			Bitmap stegoImageCopy = new Bitmap(stegoImage.Image);

			// Set extraction option
			bool passwordSet = !(stegoPassword.Equals(""));

			// Base variable declaration
			StringBuilder messageNameBuilder = new StringBuilder();
			StringBuilder payloadSizeBuilder = new StringBuilder();
			StringBuilder payloadBuilder = new StringBuilder();
			int stegoWidth = stegoImageCopy.Width;
			int stegoHeight = stegoImageCopy.Height;
			uint maxStegoPixels = (uint) (stegoWidth * stegoHeight);
			uint pixelDistance = 1;

			// If a stego password is specified
			if (passwordSet) {

				// Transform the password into a value defining the distance between pixels
				byte[] passwordBytes = Encoding.UTF8.GetBytes(stegoPassword);
				passwordBytes = Hasher.HashSha256(passwordBytes);
				pixelDistance = (uint) ((ulong) BitConverter.ToInt64(passwordBytes, 0) % maxStegoPixels);

				// Scramble image
				stegoImageCopy = ImageScrambler.ScrambleOne(stegoImageCopy);
				stegoImageCopy = ImageScrambler.ScrambleThree(stegoImageCopy);
				stegoImageCopy = ImageScrambler.ScrambleTwo(stegoImageCopy);
			}

			// Variables for LSB extraction
			int messageBitCounter = 0;  // Counter iterating over all message bits
			Color pixel;                // Pixel object used to generate the new color
			int currentPixelXValue;     // x coordinate of current pixel
			int currentPixelYValue;     // y coordinate of current pixel
			uint currentPixel = 0;      // Variable storing the currently considered pixel
			uint restClassCounter = 0;  // Counter iterating over all rest classes
			byte bitPlaneSelector = 0;  // Variable used to select which bit plane is used for embedding

			// Extract the first 512 bits which encode the message's name
			while (messageBitCounter < 512) {

				// Get current pixel
				currentPixelXValue = (int) currentPixel % stegoWidth;
				currentPixelYValue = (int) currentPixel / stegoWidth;
				pixel = stegoImageCopy.GetPixel(currentPixelXValue, currentPixelYValue);

				switch (messageBitCounter % 3) {
					case 0:
						messageNameBuilder.Append(GetBit(pixel.R, bitPlaneSelector));
						break;
					case 1:
						messageNameBuilder.Append(GetBit(pixel.G, bitPlaneSelector));
						break;
					case 2:
						messageNameBuilder.Append(GetBit(pixel.B, bitPlaneSelector));

						// If the whole bit plane should be filled before a pixel should be reused
						if (bitPlanesFirst) {

							// Go to the next pixel
							currentPixel += pixelDistance;

							// If the pixel exceeds the maximum amount of pixels
							// go to the next rest class
							if (currentPixel >= maxStegoPixels) {
								currentPixel = ++restClassCounter;

								// If all rest classes are exhausted,
								// begin at pixel 0 again but go to the next bit plane
								if (restClassCounter >= pixelDistance) {
									currentPixel = 0;
									restClassCounter = 0;
									bitPlaneSelector++;
								}
							}

							// If a pixel should be used in full before the next pixel is chosen
						} else {

							// Go to the next bit plane
							bitPlaneSelector++;

							// If all allowed bits of a single pixel are used
							// go to the next pixel
							if (bitPlaneSelector >= bitPlanes) {
								currentPixel += pixelDistance;
								bitPlaneSelector = 0;

								// If the pixel exceeds the maximum amount of pixels
								// go to the next rest class
								if (currentPixel >= maxStegoPixels) {
									currentPixel = ++restClassCounter;
								}
							} // if
						} // else
						break;
				} // switch
				messageBitCounter++;
			}

			// Compose the message's name
			string messageNameString = messageNameBuilder.ToString();
			string messageName = Converter.BinaryToString(messageNameString).Replace("\0", "");

			// Extract the next 24 bits which encode the message's payload size
			while (messageBitCounter < 536) {

				// Get current pixel
				currentPixelXValue = (int) currentPixel % stegoWidth;
				currentPixelYValue = (int) currentPixel / stegoWidth;
				pixel = stegoImageCopy.GetPixel(currentPixelXValue, currentPixelYValue);

				switch (messageBitCounter % 3) {
					case 0:
						payloadSizeBuilder.Append(GetBit(pixel.R, bitPlaneSelector));
						break;
					case 1:
						payloadSizeBuilder.Append(GetBit(pixel.G, bitPlaneSelector));
						break;
					case 2:
						payloadSizeBuilder.Append(GetBit(pixel.B, bitPlaneSelector));

						// If the whole bit plane should be filled before a pixel should be reused
						if (bitPlanesFirst) {

							// Go to the next pixel
							currentPixel += pixelDistance;

							// If the pixel exceeds the maximum amount of pixels
							// go to the next rest class
							if (currentPixel >= maxStegoPixels) {
								currentPixel = ++restClassCounter;

								// If all rest classes are exhausted,
								// begin at pixel 0 again but go to the next bit plane
								if (restClassCounter >= pixelDistance) {
									currentPixel = 0;
									restClassCounter = 0;
									bitPlaneSelector++;
								}
							}

							// If a pixel should be used in full before the next pixel is chosen
						} else {

							// Go to the next bit plane
							bitPlaneSelector++;

							// If all allowed bits of a single pixel are used
							// go to the next pixel
							if (bitPlaneSelector >= bitPlanes) {
								currentPixel += pixelDistance;
								bitPlaneSelector = 0;

								// If the pixel exceeds the maximum amount of pixels
								// go to the next rest class
								if (currentPixel >= maxStegoPixels) {
									currentPixel = ++restClassCounter;
								}
							} // if
						} // else
						break;
				} // switch
				messageBitCounter++;
			}

			// Compose the payloads's size
			string payloadSizeString = payloadSizeBuilder.ToString();
			uint payloadSize = Converter.BinaryToUint(payloadSizeString);

			// Extract the payload
			while (messageBitCounter < payloadSize + 536) {

				// Get current pixel
				currentPixelXValue = (int) currentPixel % stegoWidth;
				currentPixelYValue = (int) currentPixel / stegoWidth;
				pixel = stegoImageCopy.GetPixel(currentPixelXValue, currentPixelYValue);

				switch (messageBitCounter % 3) {
					case 0:
						payloadBuilder.Append(GetBit(pixel.R, bitPlaneSelector));
						break;
					case 1:
						payloadBuilder.Append(GetBit(pixel.G, bitPlaneSelector));
						break;
					case 2:
						payloadBuilder.Append(GetBit(pixel.B, bitPlaneSelector));

						// If the whole bit plane should be filled before a pixel should be reused
						if (bitPlanesFirst) {

							// Go to the next pixel
							currentPixel += pixelDistance;

							// If the pixel exceeds the maximum amount of pixels
							// go to the next rest class
							if (currentPixel >= maxStegoPixels) {
								currentPixel = ++restClassCounter;

								// If all rest classes are exhausted,
								// begin at pixel 0 again but go to the next bit plane
								if (restClassCounter >= pixelDistance) {
									currentPixel = 0;
									restClassCounter = 0;
									bitPlaneSelector++;
								}
							}

							// If a pixel should be used in full before the next pixel is chosen
						} else {

							// Go to the next bit plane
							bitPlaneSelector++;

							// If all allowed bits of a single pixel are used
							// go to the next pixel
							if (bitPlaneSelector >= bitPlanes) {
								currentPixel += pixelDistance;
								bitPlaneSelector = 0;

								// If the pixel exceeds the maximum amount of pixels
								// go to the next rest class
								if (currentPixel >= maxStegoPixels) {
									currentPixel = ++restClassCounter;
								}
							} // if
						} // else
						break;
				} // switch
				messageBitCounter++;
			}

			// Compose the message object
			string payloadString = payloadBuilder.ToString();
			byte[] payload = payloadString.ConvertBitstringToByteArray();
			StegoMessage message = new StegoMessage(messageName, payload);
			return message;
		}

		/// <summary>
		/// Rates a carrier image based on the amount of bits that have to be changed during the embedding process.
		/// The result is the exact amount of LSBs inside a carrier that stay the same
		/// during sequential embedding (without a stego password) in percent.
		/// </summary>
		/// <param name="carrier">The carrier image which is to be rated</param>
		/// <param name="message">The message which is to be hidden inside the carrier image</param>
		/// <exception cref="MessageNameTooBigException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="EncoderFallbackException"></exception>
		/// <returns>The suitability rating of the carrier for the specific message</returns>
		public float RateCarrier(StegoImage carrier, StegoMessage message) {

			// Get all necessary information of the carrier
			uint capacityInBytes = CalculateCapacity(carrier, 1);           // Only use LSBs
			uint capacityInBits = capacityInBytes * 8;
			string completeMessage = GenerateMessageBitPattern(message);

			// Directly return 0 if the message exceeds the capacity
			if (completeMessage.Length > capacityInBits) {
				return 0.00f;
			}

			// Collect all LSBs of the carrier
			//string carrierBits = collectCarrierBits(carrier, 1, bitPlanesFirst);
			string carrierLsbs = CollectCarrierLsbs(carrier);

			// Calculate the Hamming distance
			uint hammingDistance = 0;
			int lsbCounter = 0;
			foreach (char bit in completeMessage) {

				// If the index of an array reaches 2^31 it needs to be resetted
				// This is because an array is accessible only by int values
				if (lsbCounter == int.MaxValue) {
					carrierLsbs = carrierLsbs.Substring(lsbCounter);
					lsbCounter = 0;
				}

				// Increase Hamming distance if message bit and carrier bit do not match
				if (!char.Equals(bit, carrierLsbs[lsbCounter])) {
					hammingDistance++;
				}
				lsbCounter++;
			}

			double rating = (double) (capacityInBits - hammingDistance) / capacityInBits;
			return (float) Math.Round((rating * 100), 3);
		}

		/// <summary>
		/// Calculates the hiding capacity of a given carrier
		/// based on the amount of specified bit planes and returns it in bytes.
		/// </summary>
		/// <param name="carrier">The carrier whose capacity should be calculated</param>
		/// <param name="bitPlanes">The amount of the carrier's bit planes that are allowed to be used</param>
		/// <exception cref="FormatException"></exception>
		/// <returns>The capacity in bytes</returns>
		public uint CalculateCapacity(StegoImage carrier, int bitPlanes) {
			if (bitPlanes < 0 || bitPlanes > 7) {
				throw new FormatException();
			}

			uint width = (uint) carrier.Image.Width;
			uint height = (uint) carrier.Image.Height;

			// Calculate the capacity in bytes and substract 67 bytes for the name and message length
			// which is embedded before the actual payload
			return (uint) (((bitPlanes * 3 * width * height) / 8) - 67);
		}

		/// <summary>
		/// Generates a binary bit string from a <see cref="StegoMessage"/> object.
		/// At this, the message itself along with its name and its size is transformed to a series of 0s and 1s.
		/// </summary>
		/// <param name="message">The message whose bit string is to be generated</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="EncoderFallbackException"></exception>
		/// <exception cref="MessageNameTooBigException"></exception>
		/// <returns>The bit string that represents the message</returns>
		public string GenerateMessageBitPattern(StegoMessage message) {

			// Extract data from the message object
			string messageName = message.Name;
			byte[] payload = message.Payload;
			long payloadSize = message.PayloadSizeInBits;

			string payloadNameBinary = EncodeMessageName(messageName, 64);
			string payloadSizeBinary = Converter.DecimalToBinary(payloadSize, 24);
			string payloadBinary = Converter.ByteArrayToBinary(payload);

			// Generate complete message
			StringBuilder sb = new StringBuilder();
			sb.Append(payloadNameBinary);
			sb.Append(payloadSizeBinary);
			sb.Append(payloadBinary);

			return sb.ToString();
		}

		/// <summary>
		/// Collects all LSBs of a given carrier image ordered from pixel
		/// (0, 0) to (xMax, yMax) and from color R over G to B and returns them as string.
		/// </summary>
		/// <param name="carrier">The carrier image whose LSBs are to be taken from</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns></returns>
		private string CollectCarrierLsbs(StegoImage carrier) {
			StringBuilder sb = new StringBuilder();
			int width = carrier.Image.Width;
			int height = carrier.Image.Height;

			// Iterate over the whole image
			for (int y = 0; y < height; y++) {
				for (int x = 0; x < width; x++) {
					var pixel = carrier.Image.GetPixel(x, y);
					sb.Append(GetBit(pixel.R, 0));
					sb.Append(GetBit(pixel.G, 0));
					sb.Append(GetBit(pixel.B, 0));
				}
			}
			return sb.ToString();
		}

		/// <summary>
		/// Converts a message name string to a binary string pattern and adds a zero-padding.
		/// </summary>
		/// <param name="messageName">The message name that should be converted into a series of bits</param>
		/// <param name="zeroPadding">The amount of bytes the resulting string should be padded to</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="EncoderFallbackException"></exception>
		/// <exception cref="MessageNameTooBigException"></exception>
		/// <returns>The message name as binary string padded with zeros up to the given amount of bytes</returns>
		private string EncodeMessageName(string messageName, int zeroPadding) {

			UTF8Encoding encoding = new UTF8Encoding();
			byte[] buffer = encoding.GetBytes(messageName);

			if (buffer.Length > 64) {
				throw new MessageNameTooBigException();
			}

			if (buffer.Length < 64) {
				Array.Resize(ref buffer, zeroPadding);
			}

			StringBuilder sb = new StringBuilder();
			foreach (byte element in buffer) {
				sb.Append(Convert.ToString(element, 2).PadLeft(8, '0'));
			}
			return sb.ToString();
		}

		/// <summary>
		/// Returns the bit of a specific position inside an arbitrary byte.
		/// </summary>
		/// <param name="arbitraryByte">The byte whose bit position is to be returned</param>
		/// <param name="bitPosition">The bit's position</param>
		/// <returns></returns>
		public static string GetBit(byte arbitraryByte, int bitPosition) {
			bool bit = (1 == ((arbitraryByte >> bitPosition) & 1));
			return bit ? "1" : "0";
		}

		/// <summary>
		/// Sets a bit of an arbitrary byte at a specified position to a given value.
		/// </summary>
		/// <param name="arbitraryByte">The byte whose bit is to be set</param>
		/// <param name="bit">The value which has to be either 0 or 1</param>
		/// <param name="bitPosition">The position of the bit to set</param>
		/// <exception cref="ArgumentException"></exception>
		/// <returns></returns>
		private byte SetBit(byte arbitraryByte, byte bit, byte bitPosition) {
			if (bit < 0 || bit > 1) {
				throw new ArgumentException();
			}
			if (bitPosition < 0 || bitPosition > 7) {
				throw new ArgumentException();
			}
			int value = arbitraryByte;
			value ^= (-bit ^ value) & (1 << bitPosition);
			return (byte) value;
		}

		/// <summary>
		/// Sets a bit of an arbitrary byte at a specified position to a given value.
		/// </summary>
		/// <param name="arbitraryByte">The byte whose bit is to be set</param>
		/// <param name="bit">The value which has to be either 0 or 1</param>
		/// <param name="bitPosition">The position of the bit to set</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns>The new byte</returns>
		private byte SetBit(byte arbitraryByte, string bit, byte bitPosition) {
			return SetBit(arbitraryByte, byte.Parse(bit), bitPosition);
		}

		#region Unused methods
		/// <summary>
		/// Collects the bits of all specified bit planes from a given carrier image
		/// beginning with the least significant bit plane ordered from pixel
		/// (0, 0) to (xMax, yMax) and from color R over G to B and returns them as string.
		/// </summary>
		/// <param name="carrier">The carrier image whose bits are to be collected</param>
		/// <param name="bitPlanes">The amount of bit planes the bits are to be collected from</param>
		/// <param name="bitPlanesFirst">true for bit planes first-mode and false for pixels first-mode</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns>The binary pattern containing all desired bits from the carrier image</returns>
		private string CollectCarrierBits(StegoImage carrier, int bitPlanes, bool bitPlanesFirst) {
			StringBuilder sb = new StringBuilder();
			int width = carrier.Image.Width;
			int height = carrier.Image.Height;
			Color pixel;

			if (bitPlanesFirst) {
				for (int currentBitPlane = 0; currentBitPlane <= bitPlanes; currentBitPlane++) {
					for (int y = 0; y < height; y++) {
						for (int x = 0; x < width; x++) {
							pixel = carrier.Image.GetPixel(x, y);
							sb.Append(GetBit(pixel.R, currentBitPlane));
							sb.Append(GetBit(pixel.G, currentBitPlane));
							sb.Append(GetBit(pixel.B, currentBitPlane));
						} // for
					} // for
				} // for
			} else {
				for (int y = 0; y < height; y++) {
					for (int x = 0; x < width; x++) {
						for (int currentBitPlane = 0; currentBitPlane < bitPlanes; currentBitPlane++) {
							pixel = carrier.Image.GetPixel(x, y);
							sb.Append(GetBit(pixel.R, currentBitPlane));
							sb.Append(GetBit(pixel.G, currentBitPlane));
							sb.Append(GetBit(pixel.B, currentBitPlane));
						} // for
					} // for
				} // for
			} // else
			return sb.ToString();
		}

		/// <summary>
		/// Extracts a specific bit of a byte and returns it as char.
		/// </summary>
		/// <param name="inputByte">The byte whose bit should be extracted</param>
		/// <param name="pos">The position of the bit which is to be extracted</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <returns>The bit of inputByte at position pos</returns>
		private char ExtractBitFromByte(byte inputByte, int pos) {
			if (pos < 0 || pos > 7) {
				throw new ArgumentException();
			}
			string bitPattern = Converter.DecimalToBinary(inputByte, 8);
			string lsb = bitPattern.Substring(pos, 1);
			return Convert.ToChar(lsb);
		}
		#endregion
	}
}
