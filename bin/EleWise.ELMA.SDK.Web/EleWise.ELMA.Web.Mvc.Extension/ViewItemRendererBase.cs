using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public class ViewItemRendererBase<T> : ViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.GetType() == typeof(T);
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		return PartialExtensions.Partial(html, ViewName(viewItem), model);
	}

	public virtual string ViewName(ViewItem viewItem)
	{
		return $"ViewItems/{viewItem.GetType().Name}";
	}

	public override MvcHtmlString RenderSubItems(HtmlHelper html, ViewItem viewItem, object model)
	{
		return PartialExtensions.Partial(html, ViewNameSubItems(viewItem), model);
	}

	public virtual string ViewNameSubItems(ViewItem viewItem)
	{
		return $"ViewItems/{viewItem.GetType().Name}SubItems";
	}
}
