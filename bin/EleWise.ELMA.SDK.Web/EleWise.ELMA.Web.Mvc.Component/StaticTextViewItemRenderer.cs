using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class StaticTextViewItemRenderer : ViewItemRendererBase<StaticTextViewItem>
{
	public override bool IsHideEmpty(ViewItem viewItem)
	{
		if (base.IsHideEmpty(viewItem))
		{
			return string.IsNullOrWhiteSpace(((StaticTextViewItem)viewItem).Text);
		}
		return false;
	}

	public override bool IgnoreOnHideEmpty(ViewItem viewItem)
	{
		return base.IsHideEmpty(viewItem);
	}
}
