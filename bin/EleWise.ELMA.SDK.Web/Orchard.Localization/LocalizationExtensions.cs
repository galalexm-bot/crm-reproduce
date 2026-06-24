using System.Globalization;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;

namespace Orchard.Localization;

public static class LocalizationExtensions
{
	public static CultureInfo CurrentCultureInfo(this WorkContext workContext)
	{
		return CultureInfo.GetCultureInfo(workContext.CurrentCulture);
	}

	public static string GetTextDirection(this WorkContext workContext)
	{
		return workContext.GetTextDirection(null);
	}

	public static string GetTextDirection(this WorkContext workContext, IContent content)
	{
		string text = workContext.CurrentSite.SiteCulture;
		if (content != null && content.Has<ILocalizableAspect>())
		{
			text = content.As<ILocalizableAspect>().Culture ?? text;
		}
		if (!CultureInfo.GetCultureInfo(text).TextInfo.IsRightToLeft)
		{
			return "ltr";
		}
		return "rtl";
	}
}
