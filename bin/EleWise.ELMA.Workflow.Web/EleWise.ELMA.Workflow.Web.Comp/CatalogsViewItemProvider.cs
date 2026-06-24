using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using EleWise.ELMA.Workflow.Web.Extensions;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 5)]
public class CatalogsViewItemProvider : IActionItemProvider
{
	private readonly ISecurityService securityService;

	public CatalogsViewItemProvider(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar"))
		{
			ActionToolbarGroup actionToolbarGroup = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "buttons-selectedEntitiesActions") as ActionToolbarGroup;
			if (securityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission) && actionToolbarGroup != null && htmlHelper.get_ViewData().get_Model() is CatalogViewModel && false)
			{
				CatalogViewModel model;
				StartRouteButtonInfo startRouteButtonInfo = ProcessToolbarWorkflow.CreateStartRouteButtonInfoFromList(model);
				htmlHelper.StartRouteToolbarButton(startRouteButtonInfo);
			}
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		return null;
	}
}
