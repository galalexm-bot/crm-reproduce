using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowQueueSwitcher : IActionItemProvider
{
	public const string WorkflowQueueGroupUid = "workflowQueueGroup";

	public const string WorkflowQueueBreadcrumbsUid = "workflowQueueGroup-breadcrumbs";

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (htmlHelper.get_ViewData().TryGetValue("showError", out bool value))
		{
			ActionButton actionButton = new ActionButton("WorkflowQueueSwitcher");
			actionButton.AsSwitcher = true;
			actionButton.Items.Add(new ActionButton
			{
				Uid = "workflow-queue-performance",
				Text = SR.T("Текущие операции"),
				Url = htmlHelper.Url().Action("Index", "WorkflowQueue", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web"
				}),
				IsChecked = !value
			});
			actionButton.Items.Add(new ActionButton
			{
				Uid = "workflow-queue-error",
				Text = SR.T("Ошибки"),
				Url = htmlHelper.Url().Action("WorkflowQueueError", "WorkflowQueue", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web"
				}),
				IsChecked = value
			});
			return new IActionItem[1] { actionButton };
		}
		return Enumerable.Empty<IActionItem>();
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "workflowQueueGroup-breadcrumbs")
		{
			return;
		}
		foreach (IActionItem item in GetItems(rootItem, htmlHelper))
		{
			rootItem.Items.Insert(0, item);
		}
	}
}
