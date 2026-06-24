using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Common.Helpers;

public static class ColorHelper
{
	public static Color ToSystemColor(this string colorCode)
	{
		try
		{
			Match match = Regex.Match(colorCode, "^\\s*#(?<hex>[\\da-f]{3}|[\\da-f]{6})\\s*$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				string text = match.Groups["hex"].Value;
				if (text.Length == 3)
				{
					text = text.Insert(3, text[2].ToString()).Insert(2, text[1].ToString()).Insert(1, text[0].ToString());
				}
				return Color.FromArgb(Convert.ToInt32(text, 16));
			}
			match = Regex.Match(colorCode, "^\\s*rgb(?<alpha>a)?\\s*\\(\\s*(?<r>[\\d]+)(?<percent>\\s*%)?\\s*,\\s*(?<g>[\\d]+)(?(percent)\\s*%|)\\s*,\\s*(?<b>[\\d]+)(?(percent)\\s*%|)\\s*(?(alpha),\\s*(?<a>0|(0?\\.[\\d]+)|(1\\.?0*))\\s*|)\\)\\s*$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				int red = (int)((double)Convert.ToInt32(match.Groups["r"].Value, CultureInfo.InvariantCulture) * (match.Groups["percent"].Success ? 2.55 : 1.0));
				int green = (int)((double)Convert.ToInt32(match.Groups["g"].Value, CultureInfo.InvariantCulture) * (match.Groups["percent"].Success ? 2.55 : 1.0));
				int blue = (int)((double)Convert.ToInt32(match.Groups["b"].Value, CultureInfo.InvariantCulture) * (match.Groups["percent"].Success ? 2.55 : 1.0));
				return Color.FromArgb(match.Groups["a"].Success ? ((int)(Convert.ToDouble(match.Groups["a"].Value, CultureInfo.InvariantCulture) * 255.0)) : 255, red, green, blue);
			}
			match = Regex.Match(colorCode, "^\\s*hsl(?<alpha>a)?\\s*\\(\\s*(?<h>[\\d]+)\\s*,\\s*(?<s>[\\d]+)\\s*%\\s*,\\s*(?<l>[\\d]+)\\s*%\\s*(?(alpha),\\s*(?<a>0|(0?\\.[\\d]+)|(1\\.?0*))\\s*|)\\)\\s*$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				int hue = Convert.ToInt32(match.Groups["h"].Value, CultureInfo.InvariantCulture);
				int saturation = Convert.ToInt32(match.Groups["s"].Value, CultureInfo.InvariantCulture);
				int luminosity = Convert.ToInt32(match.Groups["l"].Value, CultureInfo.InvariantCulture);
				return FromAhsl(match.Groups["a"].Success ? ((int)(Convert.ToDouble(match.Groups["a"].Value, CultureInfo.InvariantCulture) * 255.0)) : 255, hue, saturation, luminosity);
			}
			match = Regex.Match(colorCode, "^\\s*(?<name>[\\w]+)\\s*$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				return Color.FromName(match.Groups["name"].Value);
			}
		}
		catch
		{
		}
		return default(Color);
	}

	private static float Hue_2_RGB(float v1, float v2, float vH)
	{
		if (vH < 0f)
		{
			vH += 1f;
		}
		if (vH > 1f)
		{
			vH -= 1f;
		}
		if (6f * vH < 1f)
		{
			return v1 + (v2 - v1) * 6f * vH;
		}
		if (2f * vH < 1f)
		{
			return v2;
		}
		if (3f * vH < 2f)
		{
			return v1 + (v2 - v1) * (0f - vH) * 6f;
		}
		return v1;
	}

	private static Color FromAhsl(int alpha, int hue, int saturation, int luminosity)
	{
		int red;
		int green;
		int blue;
		if ((float)saturation == 0f)
		{
			red = (byte)(luminosity * 255);
			green = (byte)(luminosity * 255);
			blue = (byte)(luminosity * 255);
		}
		else
		{
			int num = (((double)luminosity < 0.5) ? (luminosity * (1 + saturation)) : (luminosity + saturation - saturation * luminosity));
			int num2 = 2 * luminosity - num;
			red = (byte)(255f * Hue_2_RGB(num2, num, hue));
			green = (byte)(255f * Hue_2_RGB(num2, num, hue));
			blue = (byte)(255f * Hue_2_RGB(num2, num, hue));
		}
		return Color.FromArgb(alpha, red, green, blue);
	}

	public static Color ToSystemColor(this IColor color)
	{
		return (color?.ColorCode).ToSystemColor();
	}
}
