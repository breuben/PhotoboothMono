using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoboothMono
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			KioskWindow kioskWindow = new KioskWindow(new PhotoboothSettings
			{
				PromptText = "Press the button on the remote to take a picture.\nDon't forget to smile!",
				ImageExtension = "*.jpg",
				ImagePath = @"C:\Captures",
				FontFamilyName = "Gabriola",
				FontSize = 90,
				DisplaySeconds = 5,
			});

			kioskWindow.ShowDialog();
		}
	}
}
