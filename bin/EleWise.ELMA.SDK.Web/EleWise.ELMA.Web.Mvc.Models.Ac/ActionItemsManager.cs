using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Component]
public class ActionItemsManager : IActionItemManager
{
	public void ProcessItem(IActionItem actionItem, HtmlHelper htmlHelper)
	{
		if (actionItem != null && actionItem.Items != null)
		{
			ActionItemsHelper.ActionItemProviders.ForEach(delegate(IActionItemProvider p)
			{
				p.InsertItems(actionItem, htmlHelper);
			});
		}
	}
}
