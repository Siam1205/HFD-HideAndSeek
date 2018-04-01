# HSF-HideAndSeek

Steganography is the art and science of concealing data inside carrier media like images, audio files, movie clips, text files or even header segments of TCP/IP segments. Within this context, the term "message" describes the data which is to be hidden inside another file. This file, which is used to carry the data, is called "carrier" or rarely "vessel". After embedding the message into the carrier, the result, hence the original carrier file which now carries the message, is called "stego file".<br />
<br />
HSF-HideAndSeek (HSF-HAS) is an LSB-based Steganography tool with a Graphical User Interface (GUI) developed primarily for the purpose of teaching. It allows to hide arbitrary files inside BMP or PNG images. Furthermore, the messages may be encrypted beforehand.

## Background
Since in the scope of this tool, only BMP or PNG files are allowed as carriers, HSF-HAS obviously is an image-based Steganography tool. In order to explain the whole scope of the tool itself, a short excursus on digital images is necessary.

### Digital images
Slightly simplified, digital images are nothing more than a set of pixels storing three-dimensional color vectors. These vectors are mostly 24 bit-based which means each dimension has 8 bit available for storing a color value of a specific color. The most common color space is RGB which means each pixel has 256 different values for the colors red green and blue. A pixel with the color value (255, 168, 0) for example is colored orange since it stores the maximum amount of red, moderately much green and no blue.<br/>

### Bit planes
A bit plane of a digital image is a set of bits corresponding to a given bit position over all bytes of an image's color channel. It can also be represented as a binary image drawn with the values of the original image's bit position whereas black pixels illustrate a bit value of 1 and white pixels illustrate a value of 0.
<p align="center">
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube.png" width="30%"/>
</p>
<p align="center">
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_0_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_1_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_2_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_3_red.png" width="22%"/>
</p>
<p align="center">
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_4_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_5_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_6_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/cube_red/cube_7_red.png" width="22%"/>
</p>
<p>
  While embedding a message, bit planes are manipulated which may in some cases lead to the fact that a message has been embedded into the respective carrier. This is processed is called a visual attack:
</p>
<p align="center">
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/seq_stegged_cube_9bpp_bpfm_red/seq_stegged_cube_9bpp_bpfm_0_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/seq_stegged_cube_9bpp_bpfm_red/seq_stegged_cube_9bpp_bpfm_1_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/seq_stegged_cube_9bpp_bpfm_red/seq_stegged_cube_9bpp_bpfm_2_red.png" width="22%"/>
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/seq_stegged_cube_9bpp_bpfm_red/seq_stegged_cube_9bpp_bpfm_3_red.png" width="22%"/>
</p>
HSF-HAS provides the possibility to show the individual bit planes so that the risk that a message may be detected due to visual attacks can be reduced by selecting a proper carrier image (unlike the one shown in this example).

### Embedding schemes:
Even for a single steganographic technique, different modes of operation can be used (similar to the AES modes of operation ECB, CBC, CFB, OFB, ...). HSF-HAS itself implements derivatives of the Sequential and Randomized Hide & Seek algorithms which means it embeds the message into the Least Significant Bits (LSB) of all color channels over all of the carrier's pixels. In other words, the message is embedded into the image's bit plane 0 containing the bits of all color values at position 0. For example, a pixel with the color (255, 0, 0) will receive the color (254, 0, 1) if the message bits 001 are embedded. Nevertheless, bits can also be embedded into higher bit planes. Embedding the message bits 001 into bit plane 1 would make the color (255, 0, 0) become (253, 0, 2).<br />
HSF-HAS provides message embedding in "bit planes first-mode" or in "pixels first-mode". In the former mode, the bit planes are filled completely before another one is used while in the latter mode the pixels are up to the maximum amount of allowed bit planes before the next pixel is used.

## HSF-HAS usage
Upon starting the tool, the HSF-HAS mainframe appears:
<p align="center">
  <img src="https://github.com/Siam1205/HSF-HideAndSeek/blob/master/Example/GUI.png" width="80%"/>
</p>
At this point, one carrier image, one message file and one stego image can be loaded at a time. All operations that address the respective object will overwrite it or its counterpart. As an example, if a carrier is loaded while another one has already been loaded, it will be overwritten. Furthermore, if a stego image is loaded and a message is hidden, the existing stego image is overwritten with the newly generated stego image.<br />
The following paragraph describes the function of the available controls:
<ul>
  <li><b>Load carrier: </b>Opens a file dialog in order to load a carrier image from the file system.</li>
  <li><b>Load message: </b>Opens a file dialog in order to load a message file from the file system.</li>
  <li><b>Show carrier bit planes: </b>Opens a new window and displays the eight individual bit planes of the carrier's red color channel.</li>
  <li><b>Rate carrier: </b>Rates a carrier based on its suitability to hide the message. Ratings above 90% are considered secure. A carrier with a rating below 90% might be exposed as such by statistical attacks.</li>
  <li><b>Encrypt message: </b>Encrypts the currently loaded message with AES256-CBC.</li>
  <li><b>Decrypt message: </b></li>Decrypts the currently loaded message with AES256-CBC.
  <li><b>Hide message: </b></li>Hides the message inside the carrier image based on the specified options.
  <li><b>Extract message: </b></li>Hides the message inside the carrier image based on the specified options.
  <li><b>Bits per pixel: </b></li>Select the amount of allowed bit planes (3 bits per pixel correspond to 1 bit plane)
  <li><b>Load stego image: </b></li>Opens a file dialog in order to load a stego image from the file system.
  <li><b>Show stego image bit planes: </b></li>Opens a new windows and displays the eight individual bit planes of the stego image's red color channel.
  <li><b>Help: </b></li>Opens the Help / About window.
  <li><b>Save stego image: </b></li>Opens a dialog in order to save the stego image to the file system.
  <li><b>Save message: </b></li>Opens a dialog in order to save the carrier to the file system.
</ul>

## Private Comment
I developed this tool for the purpose of teaching one possible type of steganographic algorithm in a 'quick and dirty' way under no license. There was no time wasted for efficiency or high quality code.
