using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentVersionsTabViewItemRenderer : TabViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.GetType() == typeof(DocumentVersionsTabViewItem);
	}

	public override string ViewName(ViewItem viewItem)
	{
		return "ViewItems/DocumentVersionsTabViewItem";
	}
}
