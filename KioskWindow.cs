using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoboothMono
{
	public partial class KioskWindow : Form
	{
		private readonly PhotoboothSettings _settings;

		private readonly Label _promptLabel;

		private FileSystemWatcher _imageMonitor;

		private Queue<string> imageQueue = new Queue<string>();

		public KioskWindow(PhotoboothSettings settings)
		{
			InitializeComponent();

			_promptLabel = new Label
			{
				Location = new Point(0, 0),
				Text = settings.PromptText,
				ForeColor = Color.FromArgb(0xff, 0x23, 0x0f, 0xe4),
				Font = new Font(settings.FontFamilyName, settings.FontSize),
				TextAlign = ContentAlignment.MiddleCenter
			};

			_settings = settings;
		}

		private void KioskWindow_Load(object sender, EventArgs e)
		{
			EnterFullscreenMode();
			ShowPrompt();
			StartMonitoringImageDirectory();
			Cursor.Hide();
		}

		private void KioskWindow_FormClosed(object sender, EventArgs e)
		{
			Cursor.Show();
		}

		private void KioskWindow_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void EnterFullscreenMode()
		{
			this.WindowState = FormWindowState.Normal;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
		}

		private void StartMonitoringImageDirectory()
		{
			try
			{
				_imageMonitor = new FileSystemWatcher(_settings.ImagePath, _settings.ImageExtension);
				_imageMonitor.Created += ImageMonitorOnFileCreated;
				_imageMonitor.EnableRaisingEvents = true;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}

			Task queueWatcher = new Task(WatchImageQueue);
			queueWatcher.Start();
		}

		private void WatchImageQueue()
		{
			while (true)
			{
				if (imageQueue.Count > 0)
				{
					while (imageQueue.Count > 0)
						ShowImageFromTopOfQueue();

					ShowPrompt();
				}

				Thread.Sleep(100);
			}
		}

		private void ShowImageFromTopOfQueue()
		{
			string imagePath;
			lock (imageQueue)
			{
				imagePath = imageQueue.Dequeue();
			}

			ShowImage(imagePath);

			Thread.Sleep(_settings.DisplaySeconds * 1000);
		}

		private void ImageMonitorOnFileCreated(object sender, FileSystemEventArgs fileSystemEventArgs)
		{
			lock (imageQueue)
			{
				imageQueue.Enqueue(fileSystemEventArgs.FullPath);
			}
		}
		private void ShowPrompt()
		{
			this.Invoke(
				new Action(
					() =>
					{
						this.Controls.Clear();
						this.Controls.Add(_promptLabel);
						_promptLabel.Width = this.Width;
						_promptLabel.Height = this.Height;
						_promptLabel.Show();
					}));
		}

		private void ShowImage(string imagePath)
		{
			this.Invoke(
				new Action(
					() =>
					{
						try
						{
							Label imageLabel = new Label
							{
								Width = this.Width,
								Height = this.Height,
								BackgroundImage = LoadBitmap(imagePath),
							};


							if (imageLabel.BackgroundImage.Width > this.Width || imageLabel.BackgroundImage.Height > this.Height)
							{
								imageLabel.BackgroundImageLayout = ImageLayout.Zoom;
							}
							else
							{
								imageLabel.BackgroundImageLayout = ImageLayout.Center;
							}

							this.Controls.Clear();
							this.Controls.Add(imageLabel);
						}
						catch (Exception)
						{
							// Probabably a threading exception, we can safely ignore, just keep chugging along
						}
					}));
		}

		private Bitmap LoadBitmap(string imagePath)
		{
			var bitmap = new Bitmap(new MemoryStream(File.ReadAllBytes(imagePath)));
			return bitmap;
		}

		//private static BitmapImage LoadBitmap(string imagePath)
		//{
		//	var bitmap = new BitmapImage();
		//	using (FileStream fs = new FileStream(imagePath, FileMode.Open))
		//	{
		//		bitmap.BeginInit();
		//		bitmap.CacheOption = BitmapCacheOption.OnLoad;
		//		bitmap.StreamSource = fs;
		//		bitmap.EndInit();
		//	}

		//	bitmap.Freeze();
		//	return bitmap;
		//}

	}
}
