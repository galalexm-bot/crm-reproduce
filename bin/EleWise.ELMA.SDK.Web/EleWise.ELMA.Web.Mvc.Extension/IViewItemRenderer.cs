using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IViewItemRenderer
{
	bool CanRender(ViewItem viewItem);

	MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model);

	MvcHtmlString RenderSubItems(HtmlHelper html, ViewItem viewItem, object model);

	bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem);

	IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem);

	IEnumerable<ViewItem> GetItems(ViewItem viewItem);

	bool IsHideEmpty(ViewItem viewItem);

	bool IgnoreOnHideEmpty(ViewItem viewItem);
}
