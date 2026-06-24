using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentLinksTabViewItemRenderer : TabViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.GetType() == typeof(DocumentLinksTabViewItem);
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		((TabViewItem)viewItem).CaptionViewName = "ViewItems/DocumentLinksTabCaption";
		return base.Render(html, viewItem, model);
	}
}
