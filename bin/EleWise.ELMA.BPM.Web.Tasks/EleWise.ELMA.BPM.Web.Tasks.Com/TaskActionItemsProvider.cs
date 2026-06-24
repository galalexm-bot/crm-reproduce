using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 1)]
public class TaskActionItemsProvider : IActionItemProvider
{
	private readonly ISecurityService securityService;

	public const string CreateTaskGroupUid = "toolbar-group-createtask";

	public const string EditTaskGroupUid = "TaskEditToolbarGroup";

	public TaskActionItemsProvider(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		ActionToolbarGroup group = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "HomePageToolbarGroup") as ActionToolbarGroup;
		if (securityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission) && group != null)
		{
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				group.Items.Add(item);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && item.Uid == "HomePageToolbarGroup"))
		{
			yield return new CreateTaskToobarButton(htmlHelper);
		}
	}
}
