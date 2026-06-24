using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 200)]
public class DocumentsSettingsModuleController : GlobalSettingsModuleControllerBase<DocumentsSettings, DocumentsSettingsModule>
{
	public DocumentsSettingsModuleController(DocumentsSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "DocumentsSettings", (object)new
		{
			area = "EleWise.ELMA.Documents.Web"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "DocumentsSettings", (object)new
		{
			area = "EleWise.ELMA.Documents.Web"
		});
	}
}
