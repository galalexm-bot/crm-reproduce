using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowMigrationSwitcher : IActionItemProvider
{
	public const string WorkflowInstanceMigrationGroupUid = "workflowInstanceMigrationGroup";

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (htmlHelper.get_ViewData().get_Model() is GridData<IWorkflowInstanceMigrationPackage, IWorkflowInstanceMigrationPackageFilter> gridData && gridData.DataFilter != null)
		{
			ActionToolbarSwitсher actionToolbarSwitсher = new ActionToolbarSwitсher();
			ActionToolbarItem actionToolbarItem = new ActionToolbarItem("WorkflowMigrationSwitcher");
			actionToolbarItem.Items.Add(new ActionToolbarItem
			{
				Uid = "change-version-package-list-processed",
				Text = SR.T("Обработанные"),
				Url = htmlHelper.Url().Action("MigrationPackageProcessedList", "WorkflowInstanceMigrationPackage", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web"
				}),
				Checked = !gridData.DataFilter.IsActive.GetValueOrDefault()
			});
			actionToolbarItem.Items.Add(new ActionToolbarItem
			{
				Uid = "change-version-packages-list-active",
				Text = SR.T("Текущие операции"),
				Url = htmlHelper.Url().Action("MigrationPackageIsActiveList", "WorkflowInstanceMigrationPackage", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web"
				}),
				Checked = gridData.DataFilter.IsActive.GetValueOrDefault()
			});
			actionToolbarSwitсher.Items.Add(actionToolbarItem);
			return new IActionItem[1] { actionToolbarSwitсher };
		}
		return Enumerable.Empty<IActionItem>();
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || !rootItem.Items.Any((IActionItem i) => i.Uid == "workflowInstanceMigrationGroup"))
		{
			return;
		}
		IActionItem actionItem = rootItem.Items.FirstOrDefault((IActionItem i) => i.Uid == "workflowInstanceMigrationGroup");
		if (actionItem == null)
		{
			return;
		}
		foreach (IActionItem item in GetItems(rootItem, htmlHelper))
		{
			actionItem.Items.Add(item);
		}
	}
}
