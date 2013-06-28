//using Photobooth.Properties;

namespace PhotoboothMono
{
	public class PhotoboothSettings
	{
		public string PromptText { get; set; }
		public string FontFamilyName { get; set; }
		public float FontSize { get; set; }
		public string ImagePath { get; set; }
		public string ImageExtension { get; set; }
		public int DisplaySeconds { get; set; }

		//public static PhotoboothSettings Load()
		//{
		//	//return new photoboothsettings
		//	//{
		//	//	prompttext = settings.default.prompttext,
		//	//	fontfamilyname = settings.default.fontfamily,
		//	//	fontsize = settings.default.fontsize,
		//	//	imagepath = settings.default.imagepath,
		//	//	imageextension = settings.default.imageextension,
		//	//	displayseconds = settings.default.displayseconds,
		//	//};
		//}

		//public static void Save(PhotoboothSettings photoboothSettings)
		//{
		//	Settings.Default.PromptText = photoboothSettings.PromptText;
		//	Settings.Default.FontFamily = photoboothSettings.FontFamilyName;
		//	Settings.Default.FontSize = photoboothSettings.FontSize;
		//	Settings.Default.ImagePath = photoboothSettings.ImagePath;
		//	Settings.Default.ImageExtension = photoboothSettings.ImageExtension;
		//	Settings.Default.DisplaySeconds = photoboothSettings.DisplaySeconds;

		//	Settings.Default.Save();
		//}
	}
}