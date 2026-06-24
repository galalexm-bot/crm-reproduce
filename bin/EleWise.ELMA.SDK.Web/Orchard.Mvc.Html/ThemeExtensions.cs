using System.Web.Mvc;
using System.Web.Mvc.Html;
using Orchard.Environment.Extensions.Models;
using Orchard.Validation;

namespace Orchard.Mvc.Html;

public static class ThemeExtensions
{
	public static void Include(this HtmlHelper helper, string viewName)
	{
		Argument.ThrowIfNull<HtmlHelper>(helper, "helper");
		RenderPartialExtensions.RenderPartial(helper, viewName);
	}

	public static string ThemePath(this HtmlHelper helper, ExtensionDescriptor theme, string path)
	{
		return theme.Location + "/" + theme.Id + path;
	}
}
