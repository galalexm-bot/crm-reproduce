using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[Permission("{B68AE858-467E-4AFA-8D02-A8BACE0EB955}")]
public class WorkflowQueueController : FilterTreeBaseController<IWorkflowQueueItem, long>
{
	private readonly WorkflowQueueItemManager workflowQueueItemManager;

	private readonly WorkflowInstanceManager workflowInstanceManager;

	public WorkflowQueueController(WorkflowQueueItemManager workflowQueueItemManager, WorkflowInstanceManager workflowInstanceManager)
	{
		this.workflowQueueItemManager = workflowQueueItemManager;
		this.workflowInstanceManager = workflowInstanceManager;
	}

	[ContentItem(Name = "SR.M('Текущие операции')", Image24 = "#clock.svg", Order = 400)]
	public ActionResult Index()
	{
		((ControllerBase)this).get_ViewData().set_Item("showError", (object)false);
		FilterModel filterModel = CreateFilter();
		return (ActionResult)(object)((Controller)this).View((object)filterModel);
	}

	[ContentItem(Name = "SR.M('Ошибки')", Image24 = "#delete.svg", Order = 500)]
	public ActionResult WorkflowQueueError()
	{
		((ControllerBase)this).get_ViewData().set_Item("showError", (object)true);
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult GridData(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, bool? showError, string gridId = null, long instanceId = 0L)
	{
		bool flag = false;
		if (filter == null)
		{
			filter = CreateFilter();
			flag = true;
		}
		IWorkflowQueueItemFilter workflowQueueFilter = ((filter.Filter == null) ? new InstanceOf<IWorkflowQueueItemFilter>().New : ((IWorkflowQueueItemFilter)filter.Filter));
		workflowQueueFilter.StatusExecutionError = showError.HasValue && showError.Value;
		workflowQueueFilter.StatusExecutionActive = showError.HasValue && !showError.Value;
		if (flag)
		{
			workflowQueueFilter.ShowTimer = showError ?? false;
		}
		if (instanceId != 0L)
		{
			IWorkflowInstance workflowInstance = workflowInstanceManager.LoadOrNull(instanceId);
			if (workflowInstance != null)
			{
				workflowQueueFilter.Instance = workflowInstance;
			}
		}
		GridDataFilter<IWorkflowQueueItem> gridDataFilter = CreateGridData(command, filter);
		if (workflowQueueFilter.Instance == null)
		{
			FetchOptions fetchOptions = new FetchOptions();
			if (command != null)
			{
				fetchOptions = new FetchOptions
				{
					MaxResults = command.get_PageSize(),
					FirstResult = (command.get_Page() - 1) * command.get_PageSize(),
					SortDirection = command.get_SortDirection(),
					SortExpression = command.get_SortExpressionString()
				};
			}
			else
			{
				fetchOptions.MaxResults = 15;
			}
			gridDataFilter.SetCount((GridData<IWorkflowQueueItem> d, FetchOptions f) => workflowQueueItemManager.GetFullQueueItemCount(workflowQueueFilter));
			gridDataFilter.SetDataSource((GridData<IWorkflowQueueItem> d, FetchOptions f) => workflowQueueItemManager.GetFullQueueItemData(workflowQueueFilter, fetchOptions));
		}
		((ControllerBase)this).get_ViewData().set_Item("showError", (object)showError);
		((ControllerBase)this).get_ViewData().set_Item("gridId", (object)gridId);
		return GridView(gridDataFilter);
	}

	[HttpPost]
	public ActionResult TerminateItem(Guid executionUid)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Locator.GetServiceNotNull<IWorkflowQueueService>().TerminateItem(executionUid);
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult ProcessItem(long itemId)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Locator.GetServiceNotNull<IWorkflowQueueService>().ProcessItemAsync(itemId);
		return (ActionResult)new EmptyResult();
	}
}
