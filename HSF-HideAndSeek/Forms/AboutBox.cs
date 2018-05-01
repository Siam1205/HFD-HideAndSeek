using System;
using System.Windows.Forms;

namespace HSF_HideAndSeek.Forms {
	public partial class AboutBox : Form {
		
		/// <summary>
		/// Constructor
		/// </summary>
		public AboutBox() {
			InitializeComponent();
		}

		private void emailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process proc = new System.Diagnostics.Process {
				StartInfo = {FileName = "mailto:s.amelunxen@gmx.de?subject=HSF-Hide and Seek&body=Test this"}
			};
			proc.Start();
		}

		private void okButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
