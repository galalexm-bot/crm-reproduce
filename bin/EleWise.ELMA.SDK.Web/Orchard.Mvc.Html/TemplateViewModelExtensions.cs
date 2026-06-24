using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Orchard.ContentManagement.ViewModels;
using Orchard.UI;

namespace Orchard.Mvc.Html;

public static class TemplateViewModelExtensions
{
	public static void RenderTemplates(this HtmlHelper html, IEnumerable<TemplateViewModel> templates)
	{
		if (templates == null)
		{
			return;
		}
		foreach (TemplateViewModel item in templates.OrderByDescending((TemplateViewModel t) => t.Position, new FlatPositionComparer()))
		{
			html.RenderTemplates(item);
		}
	}

	public static void RenderTemplates(this HtmlHelper html, TemplateViewModel template)
	{
		if (template.WasUsed)
		{
			return;
		}
		template.WasUsed = true;
		TemplateInfo templateInfo = html.get_ViewContext().get_ViewData().get_TemplateInfo();
		string htmlFieldPrefix = templateInfo.get_HtmlFieldPrefix();
		try
		{
			templateInfo.set_HtmlFieldPrefix(templateInfo.GetFullHtmlFieldName(template.Prefix));
			RenderPartialExtensions.RenderPartial(html, template.TemplateName, template.Model);
		}
		finally
		{
			templateInfo.set_HtmlFieldPrefix(htmlFieldPrefix);
		}
	}
}
