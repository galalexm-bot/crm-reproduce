using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

public class SimpleProfileAction : IProfileAction
{
	public string ImageUrl { get; set; }

	public string ActionUrl { get; set; }

	public string Caption { get; set; }

	public string Tooltip { get; set; }

	public int Order { get; set; }

	public Func<HtmlHelper, MvcHtmlString> RenderDelegate { get; set; }

	public virtual MvcHtmlString Render(HtmlHelper html)
	{
		if (RenderDelegate != null)
		{
			return RenderDelegate(html);
		}
		return PartialExtensions.Partial(html, "Views/ProfileAction", (object)this);
	}

	public virtual MvcHtmlString RenderIcons(HtmlHelper html)
	{
		if (RenderDelegate != null)
		{
			return RenderDelegate(html);
		}
		return PartialExtensions.Partial(html, "Views/ProfileIconAction", (object)this);
	}
}
