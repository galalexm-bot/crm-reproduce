using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Integration.Common;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 2)]
public class StartProcessToolbarButton : IActionItemProvider
{
	public const string STARTPROCESS_GUID = "Processes_StartProcessToobarButton";

	private readonly ISecurityService securityService;

	public StartProcessToolbarButton(ISecurityService securityService)
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
		if (securityService.HasPermission(WorkflowGlobalPermissionProvider.WorkflowAccessPermission) && group != null)
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
			yield return new ActionToolbarItem("Processes_StartProcessToobarButton")
			{
				Text = SR.T("Запустить процесс"),
				IconUrl = "#play.svg",
				ToolTip = SR.T("Запустить процесс"),
				Click = ((object)htmlHelper.OpenPopup("MainProcessTree")).ToString()
			};
		}
	}
}
