using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSF_HideAndSeek {
	public partial class AboutBox : Form {
		public AboutBox() {
			InitializeComponent();
		}

		private void emailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "mailto:s.amelunxen@gmx.de?subject=HSF-Hide and Seek&body=Test this";
			proc.Start();
		}

		private void okButton_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
