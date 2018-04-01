# HSF-HideAndSeek

Steganography is the art and science of concealing data inside carrier media like images. Within this context, the term "message" describes the data which is to be hidden inside another file. This file, which is used to carry the data, is called "carrier" or rarely "vessel". After embedding the message into the carrier, the result, hence the original carrier file which now carries the message, is called "stego file".<br />
<br />
HSF-HideAndSeek (HSF-HAS) is an LSB-based Steganography tool with a Graphical User Interface (GUI) developed primarily for the purpose of teaching. It allows to hide arbitrary files inside BMP or PNG images. Furthermore, the messages may be encrypted before. In order to achieve this, HSF-HAS implements derivatives of the Sequential and Randomized Hide & Seek algorithms as well as AES256-CBC.

## Instructions

### Bit planes
A bit plane of a digital image is a set of bits corresponding to a given bit position in each of the bytes representing the image. It can also be represented as a binary image drawn with the values of the original image's bit position whereas black pixels illustrate a bit value of 1 and white pixels illustrate a value of 0.

## Embedding schemes:
The hiding can be done in "bit planes first-mode" or in "pixels first-mode". In the former mode, the bit planes are filled completely before another one is used while in the latter mode, the pixels are filled first which almost always results in a worse stego image.

### Usage
Upon starting the tool, the HSF-HAS mainframe appears. Into the main frame, one carrier image, one message file and one stego image can be loaded at a time. All operations that address the respective object will overwrite it or its counterpart. As an example, if a carrier is loaded while another one has already been loaded, it will be overwritten. Furthermore, if a stego image is loaded and a message is hidden, the existing stego image is overwritten with the newly generated stego image.<br />
The following paragraph describes the function of the available controls:
Load carrier:				Opens a file dialog in order to load a carrier image from the file system.
Load message:				Opens a file dialog in order to load a message file from the file system.
Show carrier bit planes:	Opens a new windows and displays the eight individual bit planes of the carrier's red color channel.
Rate carrier:				Rates a carrier based on its suitability to hide the message. Ratings above 90% are considered secure.
Encrypt message:			Encrypts the currently loaded message with AES256-CBC.
Decrypt message:			Decrypts the currently loaded message with AES256-CBC.
Hide message:				Hides the message inside the carrier image based on the specified options.
Extract message:			Hides the message inside the carrier image based on the specified options.
Load stego image:			Opens a file dialog in order to load a stego image from the file system.
Show stego bit planes:		Opens a new windows and displays the eight individual bit planes of the stego image's red color channel.
Help:						Opens the Help / About window
Save stego image:			Opens a dialog in order to save the stego image to the file system.
Save message:				Opens a dialog in order to save the carrier to the file system. 

## Private Comment
I developed this tool for the purpose of teaching one possible type of steganographic algorithm in a 'quick and dirty' way under no license. There was no time wasted for efficiency or high quality code.