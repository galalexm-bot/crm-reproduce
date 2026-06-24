using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Extensions;
using EleWise.ELMA.Workflow.Processes.Web.Helpers;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[RouteArea("EleWise.ELMA.Workflow.Processes.Web")]
public class WorkflowInstanceController : BPMController<IWorkflowInstance, long>
{
	public WorkflowInstanceContextService WorkflowInstanceContextService { get; set; }

	public IPermissionTypeRoleService PermissionTypeRoleService { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public WorkflowProcessManager WorkflowProcessManager { get; set; }

	public WorkflowInstanceManager WorkflowInstanceManager { get; set; }

	public WorkflowTaskBaseManager WorkflowTaskBaseManager { get; set; }

	public IWorkflowMessagingService WorkflowMessagingService { get; set; }

	public WorkflowRuntimeService WorkflowRuntimeService { get; set; }

	public SchedulerJobRunInfoManager SchedulerJobRunInfoManager { get; set; }

	[EntityLink]
	public ActionResult Info(long id, int? tabIndex)
	{
		WorkflowInstanceViewModel workflowInstanceViewModel = GetWorkflowInstanceViewModel(id);
		if (tabIndex.HasValue)
		{
			workflowInstanceViewModel.SelectedTab = tabIndex.Value;
		}
		workflowInstanceViewModel.CanTerminateByAdditionalCondition = CanTerminateWorkflowInstanceByActiveScripts(workflowInstanceViewModel.Instance);
		((Controller)(object)this).SetCurrentMenuItem("my-processes");
		return (ActionResult)(object)((Controller)this).View((object)workflowInstanceViewModel);
	}

	public ActionResult Edit(long id, int? tabIndex)
	{
		WorkflowInstanceViewModel workflowInstanceViewModel = GetWorkflowInstanceViewModel(id);
		if (tabIndex.HasValue)
		{
			workflowInstanceViewModel.SelectedTab = tabIndex.Value;
		}
		((Controller)(object)this).SetCurrentMenuItem("my-processes");
		return (ActionResult)(object)((Controller)this).View((object)workflowInstanceViewModel);
	}

	[HttpPost]
	public ActionResult Edit(WorkflowInstanceViewModel model)
	{
		model.Instance.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
		{
			id = model.Instance.Id
		});
	}

	public ActionResult Questions(long instanceId)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)GetWorkflowInstanceViewModel(instanceId));
	}

	public ActionResult Comments(long instanceId)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)GetWorkflowInstanceViewModel(instanceId));
	}

	public ActionResult Members(long instanceId)
	{
		WorkflowInstanceViewModel workflowInstanceViewModel = GetWorkflowInstanceViewModel(instanceId);
		PermissionRoleType[] array = new PermissionRoleType[3]
		{
			CommonRoleTypes.OrganizationItem,
			CommonRoleTypes.Group,
			CommonRoleTypes.User
		};
		string popupId = "WorkflowInstanceMemberAddPopup";
		workflowInstanceViewModel.MemberPermissionModel = new PermissionRoleTypeSelectorModel
		{
			PopupId = popupId,
			Title = SR.T("Добавление участника экземпляра процесса"),
			ObjectId = "D1E8731D-2178-4925-9BB2-6284F8EE036A".ToString(),
			TypeRoles = array,
			SelectedTypeRole = array.First(),
			OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel(popupId),
			GroupsTreeModel = PermissionsModelService.CreateGroupsModel(popupId),
			ExtGroupsTreeModel = PermissionsModelService.CreateExtGroupsModel(popupId),
			UserModel = PermissionsModelService.CreateUserModel(popupId, ((Controller)this).get_Url())
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)workflowInstanceViewModel);
	}

	[HttpPost]
	public ActionResult AddMember(long instanceId, [Bind(Prefix = "members")] List<WorkflowMemberModel> addedMembers)
	{
		IWorkflowInstance workflowInstance = base.Manager.Load(instanceId);
		if (workflowInstance == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (addedMembers != null)
		{
			foreach (WorkflowMemberModel addedMember in addedMembers)
			{
				if (addedMember.ObjectType == CommonRoleTypes.User.Id)
				{
					WorkflowInstanceManager.Instance.AddMember(workflowInstance, UserManager.Instance.LoadOrNull(addedMember.Id));
				}
				if (addedMember.ObjectType == CommonRoleTypes.Group.Id)
				{
					WorkflowInstanceManager.Instance.AddMember(workflowInstance, UserGroupManager.Instance.LoadOrNull(addedMember.Id));
				}
				if (addedMember.ObjectType == CommonRoleTypes.OrganizationItem.Id)
				{
					WorkflowInstanceManager.Instance.AddMember(workflowInstance, OrganizationItemManager.Instance.LoadOrNull(addedMember.Id));
				}
			}
		}
		workflowInstance.Save();
		return (ActionResult)(object)((Controller)this).Json((object)"");
	}

	[HttpPost]
	public ActionResult DeleteMember(long instanceId, long userId)
	{
		IWorkflowInstance workflowInstance = base.Manager.Load(instanceId);
		if (workflowInstance == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		List<IWorkflowInstanceMember> list = ((IEnumerable<IWorkflowInstanceMember>)workflowInstance.Members).Where((IWorkflowInstanceMember m) => m.User.Id == userId && !m.PermissionRole.HasValue).ToList();
		foreach (IWorkflowInstanceMember item in list)
		{
			((ICollection<IWorkflowInstanceMember>)workflowInstance.Members).Remove(item);
			item.Delete();
		}
		if (list.Count() > 0)
		{
			workflowInstance.Save();
		}
		return (ActionResult)(object)((Controller)this).Json((object)"");
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, string gridPrefix, [Bind(Prefix = "InstanceFilter")] IWorkflowInstanceFilter filter, bool showStartDateColumn = true, string DefaultFilter = null, bool isPortlet = false)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		ContextGridModel contextGridModel = CreateContextGridModel(command, filter, gridPrefix, showStartDateColumn, DefaultFilter, null, isPortlet);
		return (ActionResult)(object)((Controller)this).PartialView((object)contextGridModel);
	}

	public ActionResult GetNonVisibleMenuItems(long id)
	{
		List<string> list = new List<string>();
		try
		{
			IWorkflowInstance target = WorkflowInstanceManager.Instance.Load(id);
			if (!base.SecurityService.HasPermission(WorkflowPermissionProvider.AssignResponsibleForInstance, target))
			{
				list.Add("btnChangeResponsible");
			}
		}
		catch (Exception)
		{
			list.Add("btnChangeResponsible");
		}
		return (ActionResult)(object)((Controller)this).Json((object)list.ToArray());
	}

	public ActionResult OperationsColumn(IWorkflowInstance instance)
	{
		OperationsModel operationsModel = new OperationsModel(instance, init: true, initTasks: true);
		return (ActionResult)(object)((Controller)this).PartialView("OperationsColumn", (object)operationsModel);
	}

	[HttpGet]
	public ActionResult Context(long workflowInstanceId)
	{
		WorkflowInstanceViewModel workflowInstanceViewModel = GetWorkflowInstanceViewModel(workflowInstanceId);
		return (ActionResult)(object)((Controller)this).PartialView("FieldsView", (object)workflowInstanceViewModel);
	}

	[HttpGet]
	public ActionResult Operations(long workflowInstanceId)
	{
		IWorkflowInstance instance = WorkflowInstanceManager.Load(workflowInstanceId);
		return Operations(instance);
	}

	[HttpGet]
	public ActionResult History(long workflowInstanceId)
	{
		IWorkflowInstance entity = WorkflowInstanceManager.Load(workflowInstanceId);
		EventHistoryCommentViewModel eventHistoryCommentViewModel = new EventHistoryCommentViewModel
		{
			InTab = true,
			Entity = entity,
			DisableButtons = null,
			AsyncLoading = true,
			HideButtons = null,
			AddCommentActionUid = WorkflowInstanceActions.AddCommentGuid,
			ShowAttachment = true
		};
		return (ActionResult)(object)((Controller)this).PartialView("History", (object)eventHistoryCommentViewModel);
	}

	public ActionResult Operations(IWorkflowInstance instance)
	{
		OperationsModel operationsModel = new OperationsModel(instance, init: true, initTasks: false);
		return (ActionResult)(object)((Controller)this).PartialView("Operations", (object)operationsModel);
	}

	[HttpGet]
	public ActionResult TasksInfo(long workflowInstanceId)
	{
		IWorkflowInstance instance = WorkflowInstanceManager.Load(workflowInstanceId);
		WorkflowTasksInfoViewModel workflowTasksInfoViewModel = new WorkflowTasksInfoViewModel
		{
			Instance = instance
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)workflowTasksInfoViewModel);
	}

	[CustomGridAction]
	public ActionResult TasksInfoGrid(long workflowInstanceId, GridCommand command, [Bind(Prefix = "DataFilter")] IWorkflowTaskBaseFilter filter)
	{
		if (filter == null)
		{
			IWorkflowInstance workflowInstance = WorkflowInstanceManager.Load(workflowInstanceId);
			InstanceOf<IWorkflowTaskBaseFilter> instanceOf = new InstanceOf<IWorkflowTaskBaseFilter>();
			instanceOf.New.InstanceId = workflowInstance.Id;
			instanceOf.New.DisableSecurity = true;
			filter = instanceOf.New;
		}
		GridData<IWorkflowTaskBase, IWorkflowTaskBaseFilter> gridData = new GridData<IWorkflowTaskBase, IWorkflowTaskBaseFilter>
		{
			Command = command,
			DataFilter = filter
		};
		gridData.SetCount((GridData<IWorkflowTaskBase, IWorkflowTaskBaseFilter> d, FetchOptions f) => WorkflowTaskBaseManager.CountOfAllTasksWithSubtasks(d.DataFilter));
		gridData.SetDataSource((GridData<IWorkflowTaskBase, IWorkflowTaskBaseFilter> d, FetchOptions f) => WorkflowTaskBaseManager.GetAllTasksWithSubtasks(d.DataFilter, f));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Terminate(CommentWithAttachments model)
	{
		IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.LoadOrNull(model.ObjectId);
		if (workflowInstance != null)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			WorkflowInstanceManager.Instance.Terminate(workflowInstance, (model.ActionModel != null && model.ActionModel.Comment != null && !string.IsNullOrWhiteSpace(model.ActionModel.Comment.Text)) ? model.ActionModel.Comment.Text : null, currentUser);
		}
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
		{
			id = model.ObjectId
		});
	}

	public ActionResult ChangeProcessVersion(long id)
	{
		IWorkflowInstance target = base.Manager.Load(id);
		if (!base.SecurityService.HasPermission(WorkflowPermissionProvider.ChangeProcessVersionPermission, target))
		{
			throw new SecurityException(SR.T("Недостаточно прав для изменения версии процесса"));
		}
		((Controller)(object)this).SetCurrentMenuItem("my-processes");
		ChangeProcessVersionViewModel changeProcessVersionViewModel = BuildChangeVersionProcessViewModel(id);
		return (ActionResult)(object)((Controller)this).View((object)changeProcessVersionViewModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult ChangeProcessVersion(long id, ChangeProcessVersionResponseModel ResponseModel)
	{
		IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.LoadOrNull(id);
		try
		{
			if (workflowInstance != null)
			{
				if (WorkflowInstanceChangingVersionHelper.DeleteStatuses.Contains(workflowInstance.Status))
				{
					base.Notifier.Error(SR.T("Не удалось изменить версию: экземпляр #{0} завешен или прерван.", workflowInstance.Id));
					return (ActionResult)(object)((Controller)this).RedirectToAction("ChangeProcessVersion", (object)new
					{
						id = workflowInstance.Id
					});
				}
				EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				Dictionary<IWorkflowInstance, IWorkflowProcess> instanceUpdateVersionInfo = WorkflowInstanceManager.Instance.GetInstanceUpdateVersionInfo(workflowInstance, workflowInstance.Process.Header.Published);
				WorkflowInstanceManager.Instance.ChangeProcessVersion(ChangeProcessVersionHelper.GetActionDataWithSubProcesses(ResponseModel, workflowInstance, null, currentUser, instanceUpdateVersionInfo));
			}
			base.Notifier.Information(SR.T("Изменение версии процесса экземпляра прошло успешно!"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
			{
				id = workflowInstance.Id
			});
		}
		catch (TargetInvocationException ex)
		{
			if (ex.InnerException is WorkflowInstanceLockException)
			{
				base.Notifier.Error(SR.T("Не удалось изменить версию: экземпляр #{0} активен, т.е. по крайней мере одна из его задач выполняется в данный момент. Для смены версии необходимо, чтобы весь экземпляр находился в состоянии простоя.", workflowInstance.Id));
				return (ActionResult)(object)((Controller)this).RedirectToAction("ChangeProcessVersion", (object)new
				{
					id = workflowInstance.Id
				});
			}
			throw;
		}
	}

	public ActionResult ChangeResponsible(long instanceid, string PopupId, string GridId)
	{
		ChangeResponsibleModel changeResponsibleModel = new ChangeResponsibleModel
		{
			Instance = WorkflowInstanceManager.Load(instanceid)
		};
		changeResponsibleModel.Responsible = changeResponsibleModel.Instance.Responsible;
		changeResponsibleModel.GridId = GridId;
		changeResponsibleModel.PopupId = PopupId;
		return (ActionResult)(object)((Controller)this).PartialView("ChangeResponsible", (object)changeResponsibleModel);
	}

	[HttpPost]
	public ActionResult ChangeResponsible(ChangeResponsibleModel model)
	{
		if (model.Instance.Responsible != model.Responsible)
		{
			WorkflowInstanceManager.ChangeResponsible(model.Instance, model.Responsible);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			sucsess = true
		});
	}

	public ActionResult TimerError(long schedulerJobId)
	{
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = EntityManager<IResumeProcessSchedulerJob>.Instance.LoadOrNull(schedulerJobId);
		string text = SR.T("Таймер уже выполняется. Попробуйте обновить страницу.");
		if (resumeProcessSchedulerJob != null)
		{
			ISchedulerJobRunInfo lastRunInfo = SchedulerJobRunInfoManager.GetLastRunInfo(resumeProcessSchedulerJob.Task.Uid, resumeProcessSchedulerJob.Uid, onlyFinished: true);
			if (lastRunInfo != null && lastRunInfo.Status == JobStatus.Fail)
			{
				text = lastRunInfo.Error;
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)text);
	}

	public ActionResult QueueItemError(long queueItemId)
	{
		IWorkflowQueueItem workflowQueueItem = EntityManager<IWorkflowQueueItem>.Instance.Load(queueItemId);
		return (ActionResult)(object)((Controller)this).PartialView((object)workflowQueueItem.LastError);
	}

	[HttpPost]
	public ActionResult CloseTimer(long schedulerJobId, long? instanceId)
	{
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = EntityManager<IResumeProcessSchedulerJob>.Instance.LoadOrNull(schedulerJobId);
		if (resumeProcessSchedulerJob != null && resumeProcessSchedulerJob.Task != null && (resumeProcessSchedulerJob.Task.Status == SchedulerTaskStatus.Enabled || (resumeProcessSchedulerJob.OnceExecuteStatus.HasValue && resumeProcessSchedulerJob.OnceExecuteStatus.Value == JobStatus.Fail)))
		{
			WorkflowInstanceManager.CloseTimer(resumeProcessSchedulerJob);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", "WorkflowInstance", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			id = (instanceId ?? resumeProcessSchedulerJob.WorkflowBookmark.Instance.Id),
			tabIndex = 1
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult CloseMessageBookmark(long messageBookmarkId)
	{
		IWorkflowMessageBookmark workflowMessageBookmark = EntityManager<IWorkflowMessageBookmark>.Instance.Load(messageBookmarkId);
		if (workflowMessageBookmark.Status == WorkflowMessageBookmarkStatus.Awaiting)
		{
			workflowMessageBookmark.Status = WorkflowMessageBookmarkStatus.Terminated;
			WorkflowMessageExecuteData data = new WorkflowMessageExecuteData(workflowMessageBookmark);
			WorkflowRuntimeService.Execute(data);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", "WorkflowInstance", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			id = workflowMessageBookmark.Bookmark.Instance.Id,
			tabIndex = 1
		});
	}

	public ActionResult ChangeTimer(long schedulerJobId, bool isAjaxRequest = false, string gridId = "", long? instanceId = null)
	{
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = EntityManager<IResumeProcessSchedulerJob>.Instance.LoadOrNull(schedulerJobId);
		WorkflowInstanceTimerInfo workflowInstanceTimerInfo = null;
		if (resumeProcessSchedulerJob != null && resumeProcessSchedulerJob.Task != null)
		{
			workflowInstanceTimerInfo = new WorkflowInstanceTimerInfo
			{
				SchedulerJobId = resumeProcessSchedulerJob.Id,
				ExecuteTime = resumeProcessSchedulerJob.Task.OnceExecuteTime,
				Instance = resumeProcessSchedulerJob.WorkflowBookmark.Instance,
				GridId = gridId,
				IsAjaxRequest = isAjaxRequest,
				TaskStatus = resumeProcessSchedulerJob.Task.Status
			};
		}
		return (ActionResult)(object)((Controller)this).PartialView("ChangeTimer", (object)workflowInstanceTimerInfo);
	}

	[HttpPost]
	public ActionResult ChangeTimer(long schedulerJobId, DateTime executeTime)
	{
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = EntityManager<IResumeProcessSchedulerJob>.Instance.Load(schedulerJobId);
		WorkflowInstanceManager.ChangeTimer(resumeProcessSchedulerJob, executeTime);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", "WorkflowInstance", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			id = resumeProcessSchedulerJob.WorkflowBookmark.Instance.Id,
			tabIndex = 1
		});
	}

	private WorkflowInstanceViewModel GetWorkflowInstanceViewModel(long id)
	{
		IWorkflowInstance instance = base.Manager.Load(id);
		return GetWorkflowInstanceViewModel(instance, new List<IWorkflowTaskBase>());
	}

	private WorkflowInstanceViewModel GetWorkflowInstanceViewModel(IWorkflowInstance instance, List<IWorkflowTaskBase> tasks)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		WorkflowInstanceContext context = instance.Context;
		ClassMetadata classMetadata = ((context != null) ? ((ClassMetadata)MetadataLoader.LoadMetadata(context.GetType())) : null);
		return new WorkflowInstanceViewModel
		{
			Instance = instance,
			Context = context,
			TypeUid = (classMetadata?.Uid ?? Guid.Empty),
			Tasks = new WorkflowTaskListModel
			{
				Tasks = tasks,
				CurrentUser = currentUser
			}
		};
	}

	private static IGridData GetGridData(GridCommand command, Type type, IWorkflowInstanceFilter filter, FilterModel filterModel = null)
	{
		if (type == null)
		{
			return null;
		}
		IGridData gridData = null;
		if (filterModel == null)
		{
			gridData = (IGridData)typeof(GridBuilderExtensions).GetMethod("GetFilteredGridNoData").MakeGenericMethod(type, typeof(IWorkflowInstanceFilter)).Invoke(null, new object[2] { command, filter });
		}
		else
		{
			gridData = (IGridData)typeof(EleWise.ELMA.BPM.Web.Common.Extensions.HtmlExtensions).GetMethod("CreateGridDataNoData").MakeGenericMethod(type).Invoke(null, new object[2] { command, filterModel });
			FilterModel filterModel2 = (FilterModel)gridData.GetType().GetProperty("DataFilter").GetValue(gridData, null);
			filter = (IWorkflowInstanceFilter)filterModel2.Filter;
		}
		gridData.SetData((IGridData d, FetchOptions f) => WorkflowInstanceManager.Instance.CountUsingContext(filter), (IGridData d, FetchOptions f) => WorkflowInstanceManager.Instance.FindUsingContext(filter, f));
		return gridData;
	}

	private ChangeProcessVersionViewModel BuildChangeVersionProcessViewModel(long id)
	{
		WorkflowInstanceViewModel workflowInstanceViewModel = GetWorkflowInstanceViewModel(id);
		IWorkflowInstance instance = workflowInstanceViewModel.Instance;
		IWorkflowProcess process = instance.Process;
		IWorkflowProcess published = instance.Process.Header.Published;
		return ChangeProcessVersionHelper.BuildChangeVersionProcessViewModel(workflowInstanceViewModel, instance, process, published);
	}

	private bool CanTerminateWorkflowInstanceByActiveScripts(IWorkflowInstance instance)
	{
		bool result = false;
		if (instance != null && instance.Status != WorkflowInstanceStatus.Terminated)
		{
			result = true;
			List<IWorkflowQueueItem> list = new List<IWorkflowQueueItem>();
			IList<IWorkflowQueueItem> activeQueueItems = WorkflowInstanceManager.GetActiveQueueItems(new IWorkflowInstance[1] { instance }, allowSubInstances: true);
			if (activeQueueItems.Count > 0)
			{
				Dictionary<Guid, IEnumerable<Guid>> dictionary = new Dictionary<Guid, IEnumerable<Guid>>();
				foreach (IWorkflowQueueItem activeQueueItem in activeQueueItems)
				{
					if (activeQueueItem.BackgroundOperation?.Status != BackgroundOperationStatus.Active && activeQueueItem.Attempt >= 1)
					{
						continue;
					}
					Guid uid = activeQueueItem.Instance.Process.Uid;
					if (!dictionary.TryGetValue(uid, out var value))
					{
						value = from tel in activeQueueItem.Instance.Process.Diagram.Elements.OfType<TaskElement>()
							where AttributeHelper<TaskTypeAttribute>.GetAttribute(tel.GetType(), inherited: true)?.TaskType == TaskType.Script
							select tel.Uid;
						dictionary.Add(uid, value);
					}
					if (value.FirstOrDefault((Guid eluid) => eluid == activeQueueItem.ElementUid) != Guid.Empty)
					{
						list.Add(activeQueueItem);
					}
				}
				result = list.Count == 0;
			}
		}
		return result;
	}

	public static ContextGridModel CreateContextGridModel(GridCommand command, IWorkflowInstanceFilter fil, string gridPrefix, bool showStartDateColumn, string defaultFilter, FilterModel filterModel = null, bool isPortlet = false)
	{
		IWorkflowInstanceFilter workflowInstanceFilter = fil;
		if (!string.IsNullOrEmpty(defaultFilter))
		{
			IWorkflowInstanceFilter filter = (IWorkflowInstanceFilter)UniversalFilterSaver.UnPack(ClassSerializationHelper.DeserializeObjectByXml<SerializableFilter>(defaultFilter));
			workflowInstanceFilter = (IWorkflowInstanceFilter)UniversalFilterSaver.UnPack(UniversalFilterSaver.Pack(fil), null, filter);
			if (filterModel != null)
			{
				filterModel.Filter = workflowInstanceFilter;
			}
		}
		IProcessHeader processHeader = workflowInstanceFilter.ProcessHeader ?? ((filterModel != null) ? ((IWorkflowInstanceFilter)filterModel.Filter).ProcessHeader : null);
		Type contextType = ((processHeader != null) ? WorkflowInstanceManager.Instance.GetContextType(processHeader) : typeof(WorkflowInstanceContextStub));
		if (workflowInstanceFilter.ContextFilter == null && processHeader != null)
		{
			Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(processHeader.Published);
			if (instanceContextFilterType != null)
			{
				workflowInstanceFilter.ContextFilter = (Filter)Activator.CreateInstance(instanceContextFilterType);
			}
		}
		IGridData gridData = GetGridData(command, contextType, workflowInstanceFilter, filterModel);
		if (gridData == null)
		{
			return null;
		}
		List<Guid> availablePropertyUids = ((processHeader != null) ? Locator.GetServiceNotNull<WorkflowProcessManager>().GetVisiblePropertyUids(processHeader.Published) : null);
		ContextGridModel model = new ContextGridModel
		{
			GridId = gridPrefix + ((workflowInstanceFilter.ProcessHeader != null) ? workflowInstanceFilter.ProcessHeader.Id.ToString() : ""),
			ContextType = contextType,
			Filter = workflowInstanceFilter,
			GridData = gridData,
			ShowStartDateColumn = showStartDateColumn,
			AvailablePropertyUids = availablePropertyUids,
			IsPortletModel = isPortlet
		};
		if (model.AvailablePropertyUids != null)
		{
			model.StateLoadedAction = delegate(GridState s)
			{
				if (s != null)
				{
					s.ProviderUid = (model.IsFilterGridState ? WorkflowInstanceFilterGridStateProvider.UID : WorkflowInstanceGridStateProvider.UID);
					s.ProviderData = ((processHeader != null) ? processHeader.Id.ToString() : null);
					if (s.Refresh(contextType, isNew: false, forceRefresh: true))
					{
						GridPersonalizationAdministration.SaveState(model.GridId, s);
					}
				}
			};
		}
		return model;
	}
}
