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

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 1)]
public class ProcessActionItemsProvider : IActionItemProvider
{
	private readonly ISecurityService securityService;

	public ProcessActionItemsProvider(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		ActionToolbarGroup actionToolbarGroup = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "buttons-processAdditionalGroup") as ActionToolbarGroup;
		if (securityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission) && actionToolbarGroup != null && htmlHelper.get_ViewData().get_Model() is CatalogItemModel catalogItemModel)
		{
			StartRouteButtonInfo startRouteButtonInfo = ProcessToolbarWorkflow.CreateStartRouteButtonInfo(catalogItemModel);
			if (startRouteButtonInfo != null)
			{
				startRouteButtonInfo.Text = SR.T("Запустить процесс");
				startRouteButtonInfo.ToolTipHeader = SR.T("Запустить бизнес-процесс");
				startRouteButtonInfo.ObjectType = catalogItemModel.TypeUid;
				startRouteButtonInfo.ToolTip = SR.T("Запустить один из доступных процессов. Процессы настраиваются в дизайнере ELMA.");
				startRouteButtonInfo.ActionItem = actionToolbarGroup;
				htmlHelper.StartRouteToolbarButton(startRouteButtonInfo);
			}
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		return null;
	}
}
