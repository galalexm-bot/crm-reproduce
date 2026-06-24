using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Security.Web.Extensions;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 5)]
public class ImportUsersButton : IActionItemProvider
{
	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		ActionToolbarGroup group = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "user_list_users_group") as ActionToolbarGroup;
		if (group != null)
		{
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				group.Items.Insert(1, item);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && item.Uid == "user_list_users_group"))
		{
			yield return new ImportUsersButtonItem(htmlHelper);
		}
	}
}
