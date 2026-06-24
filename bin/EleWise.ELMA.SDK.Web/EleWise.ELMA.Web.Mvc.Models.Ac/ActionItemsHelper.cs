using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public static class ActionItemsHelper
{
	public static IEnumerable<IActionItemManager> Managers => HttpContext.Current.GetOrAddItem("EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems.IActionItemManager", () => ComponentManager.Current.GetExtensionPoints<IActionItemManager>());

	public static IEnumerable<IActionItemProvider> ActionItemProviders => HttpContext.Current.GetOrAddItem("EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems.IActionItemProvider", () => ComponentManager.Current.GetExtensionPoints<IActionItemProvider>());

	public static IEnumerable<IActionItemType> ActionItemTypes => HttpContext.Current.GetOrAddItem("EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems.IActionItemType", () => ComponentManager.Current.GetExtensionPoints<IActionItemType>());

	public static IEnumerable<IActionItemRenderHandler> ActionItemTypeRenderExtensions => HttpContext.Current.GetOrAddItem("EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems.IActionItemRenderHandler", () => ComponentManager.Current.GetExtensionPoints<IActionItemRenderHandler>());

	public static IActionItem Process(this IActionItem actionItem, HtmlHelper htmlHelper)
	{
		if (actionItem == null)
		{
			return actionItem;
		}
		Managers.ForEach(delegate(IActionItemManager m)
		{
			m.ProcessItem(actionItem, htmlHelper);
		});
		return actionItem;
	}

	public static MvcHtmlString Render(this IActionItem actionItem, HtmlHelper htmlHelper)
	{
		if (actionItem == null)
		{
			return null;
		}
		if (htmlHelper == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IActionItemRenderHandler actionItemTypeRenderExtension in ActionItemTypeRenderExtensions)
		{
			actionItemTypeRenderExtension.OnRenderBegin(actionItem, htmlHelper, stringBuilder);
		}
		if (actionItem.Type != null)
		{
			actionItem.Type.Render(actionItem, htmlHelper, stringBuilder);
		}
		if (actionItem.OnRender != null)
		{
			actionItem.OnRender(htmlHelper);
		}
		foreach (IActionItemRenderHandler actionItemTypeRenderExtension2 in ActionItemTypeRenderExtensions)
		{
			actionItemTypeRenderExtension2.OnRenderComplete(actionItem, htmlHelper, stringBuilder);
		}
		return MvcHtmlString.Create(stringBuilder.ToString());
	}
}
