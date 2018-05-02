using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace HSF_HideAndSeek.Cryptography {

	/// <summary>
	/// This class provides static methods for encrypting data with supplied keys.
	/// The whole class and its methods are modified and extended versions of the code found
	/// <a href="https://www.codeproject.com/Articles/769741/Csharp-AES-bits-Encryption-Library-with-Salt">here</a>.
	/// </summary>
	internal class AES {

		/// <summary>
		/// Predefined salt for the encryption algorithms.
		/// It must be at least 8 bytes
		/// </summary>
		private static readonly byte[] DefaultSalt = {
			0xD0, 0xA1, 0xF2, 0x0A, 0xF9, 0xA8, 0x57, 0xC0,
			0xD4, 0xBE, 0xC7, 0x8B, 0xEE, 0x91, 0x4D, 0xB6,
			0x98, 0xAE, 0xA3, 0x2D, 0xD8, 0x23, 0x33, 0x38,
			0x30, 0x61, 0xC6, 0x42, 0x2C, 0x46, 0xE9, 0x8E,
			0xF8, 0x29, 0x67, 0xFA, 0x0A, 0xBC, 0xD0, 0x11,
			0x8E, 0x22, 0x54, 0xF2, 0x81, 0xBB, 0xDB, 0x9F,
			0x09, 0x11, 0x86, 0x23, 0x7B, 0x26, 0x57, 0xC4,
			0x0C, 0xFA, 0x66, 0xE7, 0x9D, 0xB2, 0x41, 0xC1
		};

		/// <summary>
		/// Callback method which uses the managed Rijndael class
		/// to encrypt a data byte array with a given key byte array.
		/// </summary>
		/// <param name="bytesToBeEncrypted">The array of bytes that should be encrypted</param>
		/// <param name="keyBytes">They encryption key as byte array</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns></returns>
		private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] keyBytes) {
			byte[] encryptedBytes;

			using (MemoryStream ms = new MemoryStream()) {
				using (RijndaelManaged aes = new RijndaelManaged()) {

					// Set the Rijndael parameters
					aes.KeySize = 256;
					aes.BlockSize = 128;

					var key = new Rfc2898DeriveBytes(keyBytes, DefaultSalt, 1000);
					aes.Key = key.GetBytes(aes.KeySize / 8);
					aes.IV = key.GetBytes(aes.BlockSize / 8);

					// Set the AES mode of operation
					aes.Mode = CipherMode.CBC;

					using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write)) {
						cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
						//cs.Close();
					}
					encryptedBytes = ms.ToArray();
				}
			}
			return encryptedBytes;
		}

		/// <summary>
		/// Callback method which uses the managed Rijndael class
		/// to decrypt a data byte array with a given key byte array.
		/// </summary>
		/// <param name="bytesToBeDecrypted">The array of bytes that should be decrypted</param>
		/// <param name="keyBytes">The encryption key as byte array</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns></returns>
		private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] keyBytes) {
			byte[] decryptedBytes;

			using (MemoryStream ms = new MemoryStream()) {
				using (RijndaelManaged aes = new RijndaelManaged()) {

					// Set the Rijndael parameters
					aes.KeySize = 256;
					aes.BlockSize = 128;

					var key = new Rfc2898DeriveBytes(keyBytes, DefaultSalt, 1000);
					aes.Key = key.GetBytes(aes.KeySize / 8);
					aes.IV = key.GetBytes(aes.BlockSize / 8);

					// Set the AES mode of operation
					aes.Mode = CipherMode.CBC;

					using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write)) {
						cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						//cs.Close();
					}
					decryptedBytes = ms.ToArray();
				}
			}
			return decryptedBytes;
		}

		/// <summary>
		/// Encrypts a string using a given password-like key.
		/// </summary>
		/// <param name="input">The text string that should be encrypted</param>
		/// <param name="key">The text string that should be used as key</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns></returns>
		public static string EncryptText(string input, string key) {
			// Get the bytes of the string
			byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
			byte[] passwordBytes = Encoding.UTF8.GetBytes(key);

			// Hash the password with SHA256 and a predefined salt
			passwordBytes = Hasher.HashSha256(passwordBytes);

			byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

			string result = Convert.ToBase64String(bytesEncrypted);

			return result;
		}

		/// <summary>
		/// Decrypts a string using a given password-like key.
		/// </summary>
		/// <param name="input">The text string that should be decrypted</param>
		/// <param name="key">The text string that should be used as key</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <returns></returns>
		public static string DecryptText(string input, string key) {
			// Get the bytes of the string
			byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
			byte[] passwordBytes = Encoding.UTF8.GetBytes(key);

			// Hash the password with SHA256 and a predefined salt
			passwordBytes = Hasher.HashSha256(passwordBytes);

			byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

			string result = Encoding.UTF8.GetString(bytesDecrypted);

			return result;
		}

		/// <summary>
		/// Encrypts a byte array using a given password-like key.
		/// </summary>
		/// <param name="input">The array of bytes that should be encrypted</param>
		/// <param name="key">The text string that should be used as key</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="System.Reflection.TargetInvocationException"></exception>
		/// <exception cref="ObjectDisposedException"></exception>
		/// <returns></returns>
		public static byte[] Encrypt(byte[] input, string key) {
			byte[] passwordBytes = Encoding.UTF8.GetBytes(key);

			// Hash the password with SHA256 and a predefined salt
			passwordBytes = Hasher.HashSha256(passwordBytes);

			// Call encryption routine and return the result
			byte[] bytesEncrypted = AES_Encrypt(input, passwordBytes);
			return bytesEncrypted;
		}

		/// <summary>
		/// Decrypts a byte array using a given password-like key.
		/// </summary>
		/// <param name="input">The array of bytes that should be decrypted</param>
		/// <param name="key">The text string that should be used as key</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="System.Reflection.TargetInvocationException"></exception>
		/// <exception cref="ObjectDisposedException"></exception>
		/// <returns></returns>
		public static byte[] Decrypt(byte[] input, string key) {
			byte[] passwordBytes = Encoding.UTF8.GetBytes(key);

			// Hash the password with SHA256 and a predefined salt
			passwordBytes = Hasher.HashSha256(passwordBytes);

			// Call decryption routine and return the result
			byte[] bytesDecrypted = AES_Decrypt(input, passwordBytes);
			return bytesDecrypted;
		}

		/// <summary>
		/// Encrypts a file read from a source path using a given key and writes it to a destination path.
		/// </summary>
		/// <param name="originalFilePath">The path of the file that should be read and encrypted</param>
		/// <param name="key">The text string that should be used as key</param>
		/// <param name="encryptedFilePath">The path where the encrypted file should be written</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="UnauthorizedAccessException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		/// <exception cref="OverflowException"></exception>
		public static void EncryptFile(string originalFilePath, string key, string encryptedFilePath) {
			byte[] bytesToBeEncrypted = File.ReadAllBytes(originalFilePath);
			byte[] passwordBytes = Encoding.UTF8.GetBytes(key);

			// Hash the password with SHA256 and a predefined salt
			passwordBytes = Hasher.HashSha256(passwordBytes);

			byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

			File.WriteAllBytes(encryptedFilePath, bytesEncrypted);
		}

		/// <summary>
		/// Decrypts a file read from a source path using a given key and writes it to a destination path.
		/// </summary>
		/// <param name="encryptedFilePath">The path of the file that should be read and decrypted</param>
		/// <param name="password">The text string that should be used as key</param>
		/// <param name="decryptedFilePath">The path where the decrypted file should be written</param>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="CryptographicException"></exception>
		/// <exception cref="NotSupportedException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="DirectoryNotFoundException"></exception>
		/// <exception cref="IOException"></exception>
		/// <exception cref="PathTooLongException"></exception>
		/// <exception cref="UnauthorizedAccessException"></exception>
		/// <exception cref="System.Security.SecurityException"></exception>
		public static void DecryptFile(string encryptedFilePath, string password, string decryptedFilePath) {
			byte[] bytesToBeDecrypted = File.ReadAllBytes(encryptedFilePath);
			byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

			// Hash the password with SHA256 and a predefined salt
			passwordBytes = Hasher.HashSha256(passwordBytes);

			byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

			File.WriteAllBytes(decryptedFilePath, bytesDecrypted);
		}
	}
}
