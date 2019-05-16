# HFD Hide & Seek
Steganography is the art and science of concealing data inside carrier media like images, audio files, movie clips, text files or even header segments of TCP/IP segments. Within this context, the term "message" describes the data which is to be hidden inside another file. This file, which is used to carry the data, is called "carrier" or rarely "vessel". After embedding the message into the carrier, the result, hence the original carrier file which now carries the message, is called "stego file".<br />
<br />
HFD Hide & Seek (HFD-HAS) is an LSB-based Steganography tool with a Graphical User Interface (GUI) developed primarily for the purpose of teaching. It allows to hide arbitrary files inside BMP or PNG images. Furthermore, the messages may be encrypted beforehand.

## Background
Since in the scope of this tool, only BMP or PNG files are allowed as carriers, HFD-HAS obviously is an image-based Steganography tool. In order to explain the whole scope of the tool itself, a short excursus on digital images is necessary.

### Digital images
Slightly simplified, digital images are nothing more than a set of pixels storing three-dimensional color vectors. These vectors are mostly 24 bit-based which means each dimension has 8 bit available for storing a color value of a specific color. The most common color space is RGB which means each pixel has 256 different values for the colors red green and blue. A pixel with the color value (255, 168, 0) for example is colored orange since it stores the maximum amount of red, moderately much green and no blue.<br/>

### Bit planes
A bit plane of a digital image is a set of bits corresponding to a given bit position over all bytes of an image's color channel. It can also be represented as a binary image drawn with the values of the original image's bit position whereas black pixels illustrate a bit value of 1 and white pixels illustrate a value of 0.
<p align="center">
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins.png" alt="Original image: pumpkins.png" width="30%"/>
</p>
<p align="center">
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_0_red.png" alt="Carrier image: Bit plane 0" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_1_red.png" alt="Carrier image: Bit plane 1" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_2_red.png" alt="Carrier image: Bit plane 2" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_3_red.png" alt="Carrier image: Bit plane 3" width="22%"/>
</p>
<p align="center">
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_4_red.png" alt="Carrier image: Bit plane 4" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_5_red.png" alt="Carrier image: Bit plane 5" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_6_red.png" alt="Carrier image: Bit plane 6" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/pumpkins_red/pumpkins_7_red.png" alt="Carrier image: Bit plane 7" width="22%"/>
</p>
<p>
  While embedding a message, bit planes are manipulated which may in some cases lead to the fact that a message has been embedded into the respective carrier. This is processed is called a visual attack:
</p>
<p align="center">
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/seq_stegged_pumpkins_12bpp_pfm_red/seq_stegged_pumpkins_12bpp_pfm_0_red.png" alt="Stego image: Bit plane 0" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/seq_stegged_pumpkins_12bpp_pfm_red/seq_stegged_pumpkins_12bpp_pfm_1_red.png" alt="Stego image: Bit plane 1" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/seq_stegged_pumpkins_12bpp_pfm_red/seq_stegged_pumpkins_12bpp_pfm_2_red.png" alt="Stego image: Bit plane 2" width="22%"/>
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/pumpkins/seq_stegged_pumpkins_12bpp_pfm_red/seq_stegged_pumpkins_12bpp_pfm_3_red.png" alt="Stego image: Bit plane 3" width="22%"/>
</p>
HFD-HAS provides the possibility to show the individual bit planes so that the risk that a message may be detected due to visual attacks can be reduced by selecting a proper carrier image (unlike the one shown in this example) and especially the most proper embedding scheme and options.

### Embedding schemes:
Even for a single steganographic technique, different modes of operation can be used (similar to the AES modes of operation ECB, CBC, CFB, OFB, ...). HFD-HAS itself implements derivatives of the Sequential and Randomized Hide & Seek algorithms which means it embeds the message into the Least Significant Bits (LSB) of all color channels over all of the carrier's pixels. In other words, the message is embedded into the image's bit plane 0 containing the bits of all color values at position 0. For example, a pixel with the color (255, 0, 0) will receive the color (254, 0, 1) if the message bits 001 are embedded. Nevertheless, bits can also be embedded into higher bit planes. Embedding the message bits 001 into bit plane 1 would make the color (255, 0, 0) become (253, 0, 2).<br />
HFD-HAS provides message embedding in all but the highest bit plane as well as in "bit planes first-mode" or in "pixels first-mode". In the former mode, the bit planes are filled completely before another one is used while in the latter mode the pixels are up to the maximum amount of allowed bit planes before the next pixel is used as it is shown in the previous images.

## HFD-HAS usage
Upon starting the tool, the HFD-HAS main frame appears:
<p align="center">
  <img src="https://github.com/Siam1205/HFD-HideAndSeek/blob/master/Example/GUI.png" alt="Example image: HFD-HAS Graphical User Interface (GUI)" width="90%"/>
</p>
At this point, one carrier image, one message file and one stego image can be loaded at a time. All operations that address the respective object will overwrite it or its counterpart. As an example, if a carrier is loaded while another one has already been loaded, it will be overwritten. Furthermore, if a stego image is loaded and a message is hidden, the existing stego image is overwritten with the newly generated stego image.<br />
The following paragraph describes the function of the available controls:
<ul>
  <li><b>Load carrier: </b>Opens a file dialog in order to load a carrier image from the file system.</li>
  <li><b>Load message: </b>Opens a file dialog in order to load a message file from the file system.</li>
  <li><b>Show carrier bit planes: </b>Opens a new window and displays the eight individual bit planes of the carrier's red color channel.</li>
  <li><b>Rate carrier: </b>Rates a carrier based on its suitability to hide the message. Ratings above 90% are considered secure.<br />
  A carrier with a rating below 90% might be exposed as such by statistical attacks.</li>
  <li><b>Encrypt message: </b>Encrypts the currently loaded message with AES256-CBC.</li>
  <li><b>Decrypt message: </b>Decrypts the currently loaded message with AES256-CBC.</li>
  <li><b>Hide message: </b>Hides the message inside the carrier image based on the specified options.</li>
  <li><b>Extract message: </b>Hides the message inside the carrier image based on the specified options.</li>
  <li><b>Bits per pixel: </b>Select the amount of allowed bit planes (3 bits per pixel correspond to 1 bit plane)</li>
  <li><b>Load stego image: </b>Opens a file dialog in order to load a stego image from the file system.</li>
  <li><b>Show stego image bit planes: </b>Opens a new windows and displays the eight individual bit planes of the stego image's red color channel.</li>
  <li><b>Help: </b>Opens the Help / About window.</li>
  <li><b>Save stego image: </b>Opens a dialog in order to save the stego image to the file system.</li>
  <li><b>Save message: </b>Opens a dialog in order to save the carrier to the file system.</li>
</ul>

## Private Comment
This tool has been developed in 2018 for "Cryptography - theory and practice" at the Fulda University of Applied Sciences hence for the purpose of teaching. It is documented in order to facilitate further changes and improvements by anyone or to provide maintainability in general.<br />
Although effective, the implemented algorithms are not necessarily efficient regarding the amount of time it takes to hide or extract messages.

## Contact
If you have any questions regarding the tool, if you find bugs or in case you would like a feature to be added while being too lazy to implement it yourself, contact me at <a href="mailto:s.amelunxen@gmx.de">s.amelunxen@gmx.de</a>.
