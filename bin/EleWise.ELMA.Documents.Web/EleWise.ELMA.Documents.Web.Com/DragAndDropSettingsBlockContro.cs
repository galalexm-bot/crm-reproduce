using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 30)]
public class DragAndDropSettingsBlockControllerBase : DocumentStorageSettingsBlockControllerBase<DragAndDropSettings, DragAndDropSettingsBlock>
{
	public DragAndDropSettingsBlockControllerBase(DragAndDropSettingsBlock module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Document/DragAndDropSettings", (object)this);
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Document/DragAndDropSettingsEdit", (object)this);
	}
}
