using System;
using System.Windows.Forms;

namespace HSF_HideAndSeek.Forms {

	/// <summary>
	/// This class represents a form for displaying the information about the tool itself and its developer.
	/// </summary>
	public partial class AboutBox : Form {
		
		/// <summary>
		/// Constructor.
		/// </summary>
		public AboutBox() {
			InitializeComponent();
		}

		/// <summary>
		/// Opens the default email application right when the email link label is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void emailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process proc = new System.Diagnostics.Process {
				StartInfo = {FileName = "mailto:s.amelunxen@gmx.de?subject=HSF-Hide and Seek&body=Test this"}
			};
			proc.Start();
		}

		/// <summary>
		/// Closes the form when the OK-button is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void okButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
