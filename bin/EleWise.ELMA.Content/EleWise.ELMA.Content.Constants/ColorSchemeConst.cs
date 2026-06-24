using System;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Content.Constants;

public static class ColorSchemeConst
{
	private static ColorSchemeSettingsModel defaultColorSchemeSettings;

	private static ColorSchemeSettingsModel darkColorSchemeSettings;

	private static ColorSchemeSettingsModel redColorSchemeSettings;

	private static ColorSchemeSettingsModel blueColorSchemeSettings;

	private static ColorSchemeSettingsModel greenColorSchemeSettings;

	private static ColorSchemeSettingsModel yellowColorSchemeSettings;

	public const string SystemColorsStyleFileName = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/SystemColors.css";

	public static Guid DefaultColorSchemeUid = new Guid("{12F6068E-59DA-40EB-8A34-22E2DE054904}");

	private const string DarkSystemColorsStyleFileName = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/DarkSystemColors.css";

	internal static Guid DarkColorSchemeUid = new Guid("{16949BC6-28CF-4B15-A41B-10829C010F80}");

	private const string RedSystemColorsStyleFileName = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/RedSystemColors.css";

	internal static Guid RedColorSchemeUid = new Guid("{FA8E4B71-B13A-4098-9E67-B0375225DB40}");

	private const string BlueSystemColorsStyleFileName = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/BlueSystemColors.css";

	internal static Guid BlueColorSchemeUid = new Guid("{C022139C-E49A-4F69-B38B-4883B1D57C1E}");

	private const string GreenSystemColorsStyleFileName = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/GreenSystemColors.css";

	internal static Guid GreenColorSchemeUid = new Guid("{B6C2879A-7AC7-4912-99E5-A6885F655528}");

	private const string YellowSystemColorsStyleFileName = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/YellowSystemColors.css";

	internal static Guid YellowColorSchemeUid = new Guid("{4AA0A8B8-A73B-4E0F-A580-09CD9F4EDDA3}");

	public static Guid DefaultWorkplaceColorSchemeUid = new Guid("{EDB6130B-E012-4DF7-8ACC-7574154B4F6A}");

	public static string DefaultColorSchemeName { get; } = SR.T("По умолчанию");


	public static ColorSchemeSettingsModel DefaultColorSchemeSettings
	{
		get
		{
			if (defaultColorSchemeSettings == null)
			{
				defaultColorSchemeSettings = ColorSchemeManager.GetDefaultColorScheme("~/Modules/EleWise.ELMA.BPM.Web.Content/Content/SystemColors.css");
			}
			return defaultColorSchemeSettings;
		}
	}

	internal static ColorSchemeSettingsModel DarkColorSchemeSettings
	{
		get
		{
			if (darkColorSchemeSettings == null)
			{
				darkColorSchemeSettings = ColorSchemeManager.GetDefaultColorScheme("~/Modules/EleWise.ELMA.BPM.Web.Content/Content/DarkSystemColors.css");
				darkColorSchemeSettings.MainActionButton = ButtonStyle.Blue;
			}
			return darkColorSchemeSettings;
		}
	}

	internal static ColorSchemeSettingsModel RedColorSchemeSettings
	{
		get
		{
			if (redColorSchemeSettings == null)
			{
				redColorSchemeSettings = ColorSchemeManager.GetDefaultColorScheme("~/Modules/EleWise.ELMA.BPM.Web.Content/Content/RedSystemColors.css");
				redColorSchemeSettings.MainActionButton = ButtonStyle.Red;
			}
			return redColorSchemeSettings;
		}
	}

	internal static ColorSchemeSettingsModel BlueColorSchemeSettings
	{
		get
		{
			if (blueColorSchemeSettings == null)
			{
				blueColorSchemeSettings = ColorSchemeManager.GetDefaultColorScheme("~/Modules/EleWise.ELMA.BPM.Web.Content/Content/BlueSystemColors.css");
				blueColorSchemeSettings.MainActionButton = ButtonStyle.Blue;
			}
			return blueColorSchemeSettings;
		}
	}

	internal static ColorSchemeSettingsModel GreenColorSchemeSettings
	{
		get
		{
			if (greenColorSchemeSettings == null)
			{
				greenColorSchemeSettings = ColorSchemeManager.GetDefaultColorScheme("~/Modules/EleWise.ELMA.BPM.Web.Content/Content/GreenSystemColors.css");
				greenColorSchemeSettings.MainActionButton = ButtonStyle.Green;
			}
			return greenColorSchemeSettings;
		}
	}

	internal static ColorSchemeSettingsModel YellowColorSchemeSettings
	{
		get
		{
			if (yellowColorSchemeSettings == null)
			{
				yellowColorSchemeSettings = ColorSchemeManager.GetDefaultColorScheme("~/Modules/EleWise.ELMA.BPM.Web.Content/Content/YellowSystemColors.css");
				yellowColorSchemeSettings.MainActionButton = ButtonStyle.Yellow;
			}
			return yellowColorSchemeSettings;
		}
	}
}
