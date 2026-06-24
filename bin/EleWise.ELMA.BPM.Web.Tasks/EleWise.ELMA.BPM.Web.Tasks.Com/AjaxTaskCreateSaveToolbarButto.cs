using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 8)]
internal sealed class AjaxTaskCreateSaveToolbarButton : IActionItemProvider
{
	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && item.Uid == "TaskEditToolbarGroup"))
		{
			yield return new SaveAjaxTaskCreateToolbarButtonItem(htmlHelper);
		}
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || !(rootItem.Uid == "DefaultActionsToolbar"))
		{
			return;
		}
		ActionToolbarGroup group = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "TaskEditToolbarGroup") as ActionToolbarGroup;
		if (group != null)
		{
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				group.Items.Insert(0, item);
			});
		}
	}
}
