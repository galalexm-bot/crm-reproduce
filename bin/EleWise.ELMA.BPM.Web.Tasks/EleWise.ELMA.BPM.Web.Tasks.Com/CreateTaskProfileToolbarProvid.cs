using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(EnableInterceptors = false, InjectProerties = false, Order = 1)]
internal sealed class CreateTaskProfileToolbarProvider : IActionItemProvider
{
	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		ActionToolbarGroup group = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup") as ActionToolbarGroup;
		EditUserModel editUserModel = htmlHelper.get_ViewData().get_Model() as EditUserModel;
		if (group == null || editUserModel != null)
		{
			return;
		}
		IActionItem actionItem = group.Items.FirstOrDefault();
		if (actionItem != null)
		{
			int index = group.Items.IndexOf(actionItem);
			IActionItem actionItem2 = GetItems(rootItem, htmlHelper).FirstOrDefault();
			if (actionItem2 != null)
			{
				group.Items.RemoveAt(index);
				group.Items.Insert(index, actionItem2);
				group.Items.Add(actionItem);
			}
		}
		else
		{
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				group.Items.Add(item);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		yield return new CreateTaskProfileToobarButton(htmlHelper);
	}
}
