using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Web.Extensions;

namespace EleWise.ELMA.Workflow.Web.Models;

public class WorkflowInstanceExecuteInfo
{
	private static IWorkflowQueueService workflowQueueService;

	private static IUnitOfWorkManager unitOfWorkManager;

	private static WorkflowTaskBaseManager workflowTaskBaseManager;

	private static IEnumerable<IExecutedTaskInfoProvider> executedTaskInfoProviders;

	private IList<IWorkflowQueueItem> queueItems;

	private IList<IWorkflowQueueItem> queueItemsAll;

	public IList<IWorkflowQueueItem> QueueItems => queueItems ?? (queueItems = WorkflowQueueService.WaitWhileQueued(Instance, TimeSpan.Zero));

	public IList<IWorkflowQueueItem> QueueItemsAll => queueItemsAll ?? (queueItemsAll = WorkflowQueueService.WaitWhileQueued(Instance));

	public IList<IWorkflowQueueItem> WorkflowQueueItems
	{
		get
		{
			if (!ImmediatelyExecuteItem)
			{
				return QueueItemsAll;
			}
			return QueueItems;
		}
	}

	public bool ImmediatelyExecuteItem => SR.GetSetting("Workflow.ImmediatelyExecuteItem", defaultValue: true);

	public IWorkflowInstance Instance { get; set; }

	public bool? RedirectOnComplete { get; set; }

	private static IWorkflowQueueService WorkflowQueueService => workflowQueueService ?? (workflowQueueService = Locator.GetServiceNotNull<IWorkflowQueueService>());

	private static IUnitOfWorkManager UnitOfWorkManager => unitOfWorkManager ?? (unitOfWorkManager = Locator.GetServiceNotNull<IUnitOfWorkManager>());

	private static WorkflowTaskBaseManager WorkflowTaskBaseManager => workflowTaskBaseManager ?? (workflowTaskBaseManager = Locator.GetServiceNotNull<WorkflowTaskBaseManager>());

	private static IEnumerable<IExecutedTaskInfoProvider> ExecutedTaskInfoProviders => executedTaskInfoProviders ?? (executedTaskInfoProviders = ComponentManager.Current.GetExtensionPoints<IExecutedTaskInfoProvider>());

	public WorkflowInstanceExecuteInfo(IWorkflowInstance instance)
		: this(instance, null)
	{
	}

	public WorkflowInstanceExecuteInfo(IWorkflowInstance instance, bool? redirectOnComplete)
	{
		Contract.ArgumentNotNull(instance, "instance");
		Instance = instance;
		RedirectOnComplete = redirectOnComplete;
	}

	public string GetNextTaskUrl(ControllerContext context, bool redirectToDefaultIfNoTasks = true, string defaultUrl = null, bool waitQueueItems = true)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		if (waitQueueItems && !UnitOfWorkManager.HasActiveTransaction(""))
		{
			queueItems = WorkflowQueueService.WaitWhileQueued(Instance);
		}
		IList<IWorkflowTaskBase> list = WorkflowTaskBaseManager.FindMyActiveTasks(Instance, allowSubInstances: true);
		if (list.Count > 0)
		{
			return WorkflowLinkHelper.TaskUrl(new UrlHelper(context.get_RequestContext()), list[0]);
		}
		if (QueueItems.Count > 0)
		{
			return defaultUrl;
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		WorkflowTasksSettingsModel workflowTasksSettingsModel = null;
		try
		{
			workflowTasksSettingsModel = PersonalizationAdministration.LoadState<WorkflowTasksSettingsModel>(currentUser.UserName, "UserWorkflowTasksSettings");
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
		}
		if (workflowTasksSettingsModel != null && redirectToDefaultIfNoTasks)
		{
			UrlHelper val = new UrlHelper(context.get_RequestContext());
			switch (workflowTasksSettingsModel.FollowingAction)
			{
			case WorkflowTaskCompleteFollowingAction.RedirectToProcess:
				return val.Entity(Instance);
			case WorkflowTaskCompleteFollowingAction.RedirectToHome:
				return val.Action("Home", "Page", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Content"
				});
			case WorkflowTaskCompleteFollowingAction.RedirectToTaskList:
				return val.Action("Incoming", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks",
					FilterId = 0
				});
			}
		}
		return defaultUrl;
	}

	public HtmlString GetInfo(HtmlHelper html)
	{
		foreach (IExecutedTaskInfoProvider executedTaskInfoProvider in ExecutedTaskInfoProviders)
		{
			HtmlString info = executedTaskInfoProvider.GetInfo(html, Instance);
			if (info != null)
			{
				return info;
			}
		}
		return (HtmlString)(object)MvcHtmlString.Empty;
	}

	public string GetRedirectOnCompleteUrl(ControllerContext context)
	{
		if (RedirectOnComplete.HasValue && RedirectOnComplete.Value && QueueItems.Count == 0)
		{
			return GetNextTaskUrl(context, redirectToDefaultIfNoTasks: true, null, waitQueueItems: false);
		}
		return null;
	}
}
