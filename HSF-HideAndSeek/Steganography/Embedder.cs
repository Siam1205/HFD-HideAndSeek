using HSF_HideAndSeek.Cryptography;
using HSF_HideAndSeek.Exceptions;
using HSF_HideAndSeek.Helper;
using HSF_HideAndSeek.Steganography.DataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
		/// Extracts a specific bit of a byte and returns it as char
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

		/// <summary>
		/// Calculates the hiding capacity of a given carrier
		/// based on the amount of specified bit planes and returns it in bytes
		/// </summary>
		/// <param name="carrier"></param>
		/// <param name="unit"></param>
		/// <exception cref="FormatException"></exception>
		/// <returns></returns>
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

		public float RateCarrier(
			StegoImage carrier,
			StegoMessage message,
			string stegoPassword,
			int bitPlanes,
			bool bitPlanesFirst) {

			// Get all necessary information about the carrier
			uint carrierWidth = (uint) carrier.Image.Width;
			uint carrierHeight = (uint) carrier.Image.Height;
			uint maxCarrierPixels = (carrierWidth * carrierHeight);
			uint capacityInBytes = CalculateCapacity(carrier, bitPlanes);
			string completeMessage = GenerateMessageBitPattern(message);

			// Throw exception if the message is too big
			if (completeMessage.Length > capacityInBytes*8) {
				throw new MessageTooBigException();
			}

			// TODO: Write a comment
			string carrierBits = collectCarrierBits(carrier, bitPlanes, bitPlanesFirst);

			// Calculate the Hamming distance
			uint hammingDistance = 0;
			int lsbCounter = 0;
			foreach (char bit in completeMessage) {

				// If the index of an array reaches 2^31 it needs to be resetted
				// This is because an array is accessible only by int values
				if (lsbCounter == int.MaxValue) {
					carrierBits = carrierBits.Substring(lsbCounter);
					lsbCounter = 0;
				}

				// Increase Hamming distance if message bit and carrier bit do not match
				if (!Char.Equals(bit, carrierBits[lsbCounter])) {
					hammingDistance++;
				}
				lsbCounter++;
			}

			double rating = (double) (capacityInBytes - hammingDistance) / capacityInBytes;
			return (float) Math.Round((rating * 100), 3);
		}

		
		public string collectCarrierBits(StegoImage carrier, int bitPlanes, bool bitPlanesFirst) {
			StringBuilder sb = new StringBuilder();
			int width = carrier.Image.Width;
			int height = carrier.Image.Height;
			Color pixel;

			if (bitPlanesFirst) {
				for (int currentBitPlane = 0; currentBitPlane <= bitPlanes; currentBitPlane++) {
					for (int y = 0; y < height; y++) {
						for (int x = 0; x < width; x++) {
							pixel = carrier.Image.GetPixel(x, y);
							sb.Append(getBit(pixel.R, currentBitPlane));
							sb.Append(getBit(pixel.G, currentBitPlane));
							sb.Append(getBit(pixel.B, currentBitPlane));
						} // for
					} // for
				} // for
			} else {
				for (int y = 0; y < height; y++) {
					for (int x = 0; x < width; x++) {
						for (int currentBitPlane = 0; currentBitPlane < bitPlanes; currentBitPlane++) {
							pixel = carrier.Image.GetPixel(x, y);
							sb.Append(getBit(pixel.R, currentBitPlane));
							sb.Append(getBit(pixel.G, currentBitPlane));
							sb.Append(getBit(pixel.B, currentBitPlane)); 
						} // for
					} // for
				} // for
			} // else
			return sb.ToString();
		}



		/// <summary>
		/// Generates a binary bitstring from a message object
		/// </summary>
		/// <param name="message"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <returns></returns>
		public string GenerateMessageBitPattern(StegoMessage message) {

			// Extract data from the message object
			string messageName = message.Name;
			byte[] payload = message.Payload;
			long payloadSize = message.PayloadSizeInBits;

			// Convert data to binary strings
			string payloadNameBinary = Converter.StringToBinary(messageName, 64);
			string payloadSizeBinary = Converter.DecimalToBinary(payloadSize, 24);
			string payloadBinary = Converter.ByteArrayToBinary(payload);

			// Generate complete message
			StringBuilder sb = new StringBuilder();
			sb.Append(payloadNameBinary);
			sb.Append(payloadSizeBinary);
			sb.Append(payloadBinary);

			return sb.ToString();
		}

		public StegoImage HideMessage(StegoImage carrierImage,
			StegoMessage message,
			string stegoPassword,
			int bitPlanes,
			bool bitPlanesFirst) {

			// Check if a password is set
			bool passwordSet = false;
			if (!stegoPassword.Equals(null) && !stegoPassword.Equals("")) {
				passwordSet = true;
			}

			// Generate stego image (Pass by reference)
			StegoImage stegoImage = new StegoImage(
				new Bitmap(
					carrierImage.Image
				),
				carrierImage.Name,
				carrierImage.SizeInBytes
			);
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
			uint carrierCapacity = this.CalculateCapacity(carrierImage, bitPlanes);
			if (completeMessageLength > carrierCapacity*8) {
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
			int messageBitCounter = 0;		// Counter iterating over all message bits
			Color pixel;					// Pixel object used to generate the new color
			byte color = 0x00;              // Variable storing an RGB color value
			uint currentPixel = 0;          // Variable storing the currently considered pixel
			int currentPixelXValue;			// x coordinate of current pixel
			int currentPixelYValue;			// y coordinate of current pixel
			uint restClassCounter = 0;      // Counter iterating over all rest classes
			byte bitPlaneSelector = 0;		// Variable used to select which bit plane is used for embedding

			// While there is something left to hide
			while (messageBitCounter < completeMessageLength) {

				// Get current pixel
				currentPixelXValue = (int) (currentPixel % carrierWidth);
				currentPixelYValue = (int) (currentPixel / carrierWidth);
				pixel = stegoImage.Image.GetPixel(currentPixelXValue, currentPixelYValue);

				// Define which of the three LSBs of a pixel should be used
				switch (messageBitCounter % 3) {
					case 0:
						color = setBit(pixel.R, completeMessage[messageBitCounter].ToString(), bitPlaneSelector);
						stegoImage.Image.SetPixel(currentPixelXValue, currentPixelYValue, Color.FromArgb(color, pixel.G, pixel.B));
						break;
					case 1:
						color = setBit(pixel.G, completeMessage[messageBitCounter].ToString(), bitPlaneSelector);
						stegoImage.Image.SetPixel(currentPixelXValue, currentPixelYValue, Color.FromArgb(pixel.R, color, pixel.B));
						break;
					case 2:
						color = setBit(pixel.B, completeMessage[messageBitCounter].ToString(), bitPlaneSelector);
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
					default:
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


		public StegoMessage ExtractMessage(StegoImage stegoImage,
			string stegoPassword,
			int bitPlanes,
			bool bitPlanesFirst) {

			// Set extraction option
			bool passwordSet = false;
			if (!stegoPassword.Equals(null) && !stegoPassword.Equals("")) {
				passwordSet = true;
			}

			// Base variable declaration
			StringBuilder messageNameBuilder = new StringBuilder();
			StringBuilder payloadSizeBuilder = new StringBuilder();
			StringBuilder payloadBuilder = new StringBuilder();
			int stegoWidth = stegoImage.Image.Width;
			int stegoHeight = stegoImage.Image.Height;
			uint maxStegoPixels = (uint) (stegoWidth * stegoHeight);
			uint pixelDistance = 1;

			// If a stego password is specified
			if (passwordSet) {

				// Transform the password into a value defining the distance between pixels
				byte[] passwordBytes = Encoding.UTF8.GetBytes(stegoPassword);
				passwordBytes = Hasher.HashSha256(passwordBytes);
				pixelDistance = (uint) ((ulong) BitConverter.ToInt64(passwordBytes, 0) % maxStegoPixels);

				// Scramble image
				stegoImage.Image = ImageScrambler.ScrambleOne(stegoImage.Image);
				stegoImage.Image = ImageScrambler.ScrambleThree(stegoImage.Image);
				stegoImage.Image = ImageScrambler.ScrambleTwo(stegoImage.Image);
			}

			// Variables for LSB extraction
			int messageBitCounter = 0;  // Counter iterating over all message bits
			Color pixel;                // Pixel object used to generate the new color
			int currentPixelXValue;     // x coordinate of current pixel
			int currentPixelYValue;     // y coordinate of current pixel
			uint currentPixel = 0;      // Variable storing the currently considered pixel
			uint restClassCounter = 0;  // Counter iterating over all rest classes
			uint payloadSize = 0;       // Variable indicating the size of the payload
			string messageName = "";    // String storing the name of the message
			byte bitPlaneSelector = 0;  // Variable used to select which bit plane is used for embedding

			// Extract the first 512 bits which encode the message's name
			while (messageBitCounter < 512) {

				// Get current pixel
				currentPixelXValue = (int) currentPixel % stegoWidth;
				currentPixelYValue = (int) currentPixel / stegoWidth;
				pixel = stegoImage.Image.GetPixel(currentPixelXValue, currentPixelYValue);

				switch (messageBitCounter % 3) {
					case 0:
						messageNameBuilder.Append(getBit(pixel.R, bitPlaneSelector));
						break;
					case 1:
						messageNameBuilder.Append(getBit(pixel.G, bitPlaneSelector));
						break;
					case 2:
						messageNameBuilder.Append(getBit(pixel.B, bitPlaneSelector));

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
					default:
						break;
				} // switch
				messageBitCounter++;
			}

			// Compose the message's name
			string messageNameString = messageNameBuilder.ToString();
			messageName = Converter.BinaryToString(messageNameString).Replace("\0", "");

			// Extract the next 24 bits which encode the message's payload size
			while (messageBitCounter < 536) {

				// Get current pixel
				currentPixelXValue = (int) currentPixel % stegoWidth;
				currentPixelYValue = (int) currentPixel / stegoWidth;
				pixel = stegoImage.Image.GetPixel(currentPixelXValue, currentPixelYValue);

				switch (messageBitCounter % 3) {
					case 0:
						payloadSizeBuilder.Append(getBit(pixel.R, bitPlaneSelector));
						break;
					case 1:
						payloadSizeBuilder.Append(getBit(pixel.G, bitPlaneSelector));
						break;
					case 2:
						payloadSizeBuilder.Append(getBit(pixel.B, bitPlaneSelector));

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
					default:
						break;
				} // switch
				messageBitCounter++;
			}

			// Compose the payloads's size
			string payloadSizeString = payloadSizeBuilder.ToString();
			payloadSize = Converter.BinaryToUint(payloadSizeString);

			// Extract the payload
			while (messageBitCounter < payloadSize + 536) {

				// Get current pixel
				currentPixelXValue = (int) currentPixel % stegoWidth;
				currentPixelYValue = (int) currentPixel / stegoWidth;
				pixel = stegoImage.Image.GetPixel(currentPixelXValue, currentPixelYValue);

				switch (messageBitCounter % 3) {
					case 0:
						payloadBuilder.Append(getBit(pixel.R, bitPlaneSelector));
						break;
					case 1:
						payloadBuilder.Append(getBit(pixel.G, bitPlaneSelector));
						break;
					case 2:
						payloadBuilder.Append(getBit(pixel.B, bitPlaneSelector));

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
					default:
						break;
				} // switch
				messageBitCounter++;
			}

			// Compose the message object
			string payloadString = payloadBuilder.ToString();
			byte[] payload = Extensions.ConvertBitstringToByteArray(payloadString);
			StegoMessage message = new StegoMessage(messageName, payload);
			return message;
		}

		/// <summary>
		/// Gets the bit of a specific position inside an arbitrary byte
		/// </summary>
		/// <param name="arbitraryByte"></param>
		/// <param name="bitPosition"></param>
		/// <returns></returns>
		public static string getBit(byte arbitraryByte, int bitPosition) {
			bool bit = (1 == ((arbitraryByte >> bitPosition) & 1));
			return (bit == true) ? "1" : "0";
		}

		/// <summary>
		/// Sets a bit of an arbitrary byte at a specified position to a given value
		/// </summary>
		/// <param name="arbitraryByte"></param>
		/// <param name="messsageBit"></param>
		/// <param name="bitPosition"></param>
		/// <exception cref="FormatException"></exception>
		/// <returns></returns>
		private byte setBit(byte arbitraryByte, byte bit, byte bitPosition) {
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
		/// Sets a bit of an arbitrary byte at a specified position to a given value
		/// </summary>
		/// <param name="arbitraryByte"></param>
		/// <param name="bit"></param>
		/// <param name="bitPosition"></param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="FormatException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns></returns>
		private byte setBit(byte arbitraryByte, string bit, byte bitPosition) {
			return setBit(arbitraryByte, Byte.Parse(bit), bitPosition);
		}
	}
}
