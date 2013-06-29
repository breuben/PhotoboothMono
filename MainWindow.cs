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

		private void MainWindow_Load(object sender, EventArgs e)
		{
			var settings = LoadSettings();

			PopulateFormWithSettings(settings);
		}

		private void btnStartKiosk_Click(object sender, EventArgs e)
		{
			KioskWindow kioskWindow = new KioskWindow(ReadSettingsFromForm());

			kioskWindow.ShowDialog();
		}

		private void PopulateFormWithSettings(PhotoboothSettings settings)
		{
			txtCaptureDirectory.Text = settings.ImagePath;
			txtCaptureExtension.Text = settings.ImageExtension;
			txtPreviewSeconds.Text = settings.DisplaySeconds.ToString();
			txtFontName.Text = settings.FontFamilyName;
			txtFontSize.Text = settings.FontSize.ToString();
			txtPrompt.Text = settings.PromptText;
		}

		private PhotoboothSettings ReadSettingsFromForm()
		{
			return new PhotoboothSettings
			{
				ImagePath = txtCaptureDirectory.Text,
				ImageExtension = txtCaptureExtension.Text,
				DisplaySeconds = Convert.ToInt32(txtPreviewSeconds.Text),
				FontFamilyName = txtFontName.Text,
				FontSize = Convert.ToInt32(txtFontSize.Text),
				PromptText = txtPrompt.Text
			};
		}

		private PhotoboothSettings LoadSettings()
		{
			return new PhotoboothSettings
			{
				PromptText = "Press the button on the remote to take a picture.\r\nDon't forget to smile!",
				ImageExtension = "*.jpg",
				ImagePath = @"C:\Captures",
				FontFamilyName = "Gabriola",
				FontSize = 90,
				DisplaySeconds = 5,
			};
		}
	}
}
