using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.BPM.Web.Tasks.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Processes.Web.Portlets;
using EleWise.ELMA.Workflow.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[Permission("61F8D4F7-C299-4B44-9B4F-A56C2F63B15B")]
public class MonitorController : FilterWorkflowInstanceController
{
	private const string jsonTempl = "{{\"records\":0,\"page\":0,\"total\":{0},\"rows\":[{1}]}}";

	protected override Guid? Code => WorkflowConstants.MonitorFilterCode;

	protected override string GridIdPrefix => "TabMonitorInstancesGridPanDiv";

	public WorkflowInstanceContextService WorkflowInstanceContextService { get; set; }

	public WorkflowTaskBaseManager WorkflowTaskBaseManager { get; set; }

	public ProcessGroupManager ProcessGroupManager { get; set; }

	public ProcessHeaderManager ProcessHeaderManager { get; set; }

	protected override bool EnableEqlQuery => true;

	[HttpGet]
	public ActionResult List()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		MonitorModel monitorModel = new MonitorModel();
		AddPart(monitorModel, ResponsibilityLevel.Owner, null, "OwnerPanel", SR.T("Владелец"));
		AddPart(monitorModel, null, true, "CuratorPanel", SR.T("Куратор"));
		AddPart(monitorModel, null, null, "MonitorAccessPanel", SR.T("Информация по процессу"));
		return (ActionResult)(object)((Controller)this).View((object)monitorModel);
	}

	[ContentItem(Name = "SR.M('Монитор процессов')", Image24 = "#computer.svg", Order = 130)]
	[FilterMenuItem(Id = "monitor-processes", Type = typeof(IWorkflowInstance), FilterEditAction = "EditFilters", CodeStr = "{8BB3D8A8-3D4E-4A1A-8AB7-75F0D6EFA774}")]
	public ActionResult Index(long? FilterId = null, [Bind(Prefix = "InstanceFilter")] IWorkflowInstanceFilter instanceFilter = null, int? selectedTab = null)
	{
		if (instanceFilter == null)
		{
			ActionResult val = BaseIndex(FilterId);
			if (val != null)
			{
				return val;
			}
		}
		if (instanceFilter != null && !instanceFilter.IsEmulation.HasValue)
		{
			instanceFilter.IsEmulation = false;
		}
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = BaseIndexModel(WorkflowPermissionProvider.ProcessMonitor.Id, FilterId, instanceFilter, selectedTab);
		return (ActionResult)(object)((Controller)this).View((object)workflowInstanceFilterViewModel);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = BaseIndexModel(WorkflowPermissionProvider.ProcessMonitor.Id, FilterId);
		return (ActionResult)(object)((Controller)this).View("Index", (object)workflowInstanceFilterViewModel);
	}

	public ActionResult AllStatuses(long id, long? filterId = null, [Bind(Prefix = "DataFilter")] FilterModel filterModel = null)
	{
		AllStatusesInfo allStatusesInfo = new AllStatusesInfo
		{
			StatesInfo = GetInstanceStatesInfo(id, filterId, filterModel),
			StatusesInfo = GetInstanceStatusesInfo(id, filterId, filterModel)
		};
		allStatusesInfo.StatesInfo.UniquePostfix = allStatusesInfo.UniquePostfix;
		if (allStatusesInfo.StatusesInfo != null)
		{
			allStatusesInfo.StatusesInfo.UniquePostfix = allStatusesInfo.UniquePostfix;
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)allStatusesInfo);
	}

	public ActionResult SwimlaneExecutors(long id, long? filterId = null, [Bind(Prefix = "DataFilter")] FilterModel filterModel = null)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(id);
		CurrentInstancesInfo currentInstancesInfo = new CurrentInstancesInfo(new ProcessHeaderInfo
		{
			Id = processHeader.Id
		})
		{
			SwimlaniesInfo = GetSwimlanesInfo(processHeader, filterId, filterModel),
			ExecutorsInfo = GetExecutorsInfo(processHeader, filterId, filterModel)
		};
		string text2 = (currentInstancesInfo.ExecutorsInfo.UniquePostfix = (currentInstancesInfo.SwimlaniesInfo.UniquePostfix = currentInstancesInfo.UniquePostfix));
		return (ActionResult)(object)((Controller)this).PartialView("CurrentInstances", (object)currentInstancesInfo);
	}

	protected override void CalculateTaskCount(Guid permissionId, WorkflowInstanceFilterViewModel model, [Bind(Prefix = "DataFilter")] FilterModel filterModel)
	{
		InstanceOf<IWorkflowTaskBaseFilter> instanceOf = new InstanceOf<IWorkflowTaskBaseFilter>();
		instanceOf.New.PermissionId = permissionId;
		instanceOf.New.DisableSecurity = true;
		instanceOf.New.Statuses = WorkflowTaskBaseExtensions.ActiveTaskStatuses.ToList();
		instanceOf.New.InstanceFilter = (Filter)filterModel.Filter;
		ITaskBaseFilter filter = AllTasksController.CreateFilterForGrid(instanceOf.New, SearchTasksType.Search);
		model.TasksCount = AbstractNHEntityManager<ITaskBase, long>.Instance.Count(filter);
	}

	[HttpPost]
	public override ActionResult EditFilter([Bind(Prefix = "DataFilter")] FilterModel model, EditableListModel access)
	{
		model.Filter.PermissionId = WorkflowPermissionProvider.ProcessMonitor.Id;
		return base.EditFilter(model, access);
	}

	[CustomGridAction]
	public ActionResult GridData(GridCommand command, [Bind(Prefix = "InstanceFilter")] IWorkflowInstanceFilter instanceFilter, [Bind(Prefix = "DataFilter")] FilterModel filterModel, string gridId, long? FilterId = null, WorkflowInstanceGeneralStatus? userState = null, bool filterByUserStatus = false, DropDownItem userStatus = null, bool? isPortletModel = false, Guid? portletId = null)
	{
		if (instanceFilter != null && !instanceFilter.IsEmulation.HasValue)
		{
			instanceFilter.IsEmulation = false;
		}
		FilterModel filterModel2 = filterModel;
		if (filterModel2 == null || filterModel2.Filter == null)
		{
			GridState getSourceForRefresh = null;
			if (isPortletModel.HasValue && isPortletModel.Value && portletId.HasValue && FilterId.HasValue)
			{
				getSourceForRefresh = FilterPortletPersonalization.GetGridState(AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value), portletId.ToString(), gridId);
			}
			filterModel2 = CreateFilter(FilterId, null, null, getSourceForRefresh);
			if (instanceFilter != null && instanceFilter.ProcessHeader != null && instanceFilter.ProcessHeader.Published != null)
			{
				Type instanceContextFilterType = WorkflowInstanceContextService.GetInstanceContextFilterType(instanceFilter.ProcessHeader.Published);
				if (instanceContextFilterType != null && (((IWorkflowInstanceFilter)filterModel2.Filter).ContextFilter == null || ((IWorkflowInstanceFilter)filterModel2.Filter).ContextFilter.GetType() != instanceContextFilterType))
				{
					((IWorkflowInstanceFilter)filterModel2.Filter).ContextFilter = (Filter)Activator.CreateInstance(instanceContextFilterType);
				}
			}
		}
		object datafilter = UniversalFilterSaver.Pack(filterModel2.Filter);
		if (instanceFilter != null)
		{
			filterModel2.Filter = UniversalFilterSaver.UnPack(datafilter, null, instanceFilter);
		}
		if (userState.HasValue)
		{
			((IWorkflowInstanceFilter)filterModel2.Filter).GeneralStatus = userState;
		}
		if (filterByUserStatus)
		{
			if (userStatus != null)
			{
				Filter contextFilter = ((IWorkflowInstanceFilter)filterModel2.Filter).ContextFilter;
				IProcessHeader processHeader = ((IWorkflowInstanceFilter)filterModel2.Filter).ProcessHeader;
				if (processHeader != null && contextFilter != null && processHeader.Published != null && processHeader.Published.StatusContextVar != Guid.Empty)
				{
					IPropertyMetadata fullInstanceContextPropertyMetadata = WorkflowInstanceContextService.GetFullInstanceContextPropertyMetadata(processHeader, processHeader.Published.StatusContextVar);
					if (fullInstanceContextPropertyMetadata != null)
					{
						contextFilter.GetType().GetReflectionProperty(fullInstanceContextPropertyMetadata.Name).SetValue(contextFilter, userStatus, null);
					}
				}
			}
			else
			{
				((IWorkflowInstanceFilter)filterModel2.Filter).WithNullStatus = true;
			}
		}
		string gridPrefix = ((Controller)this).get_Request()["gridPrefix"];
		bool showStartDateColumn = Convert.ToBoolean(((Controller)this).get_Request()["showStartDateColumn"] ?? false.ToString());
		ContextGridModel model = WorkflowInstanceController.CreateContextGridModel(command, (IWorkflowInstanceFilter)filterModel2.Filter, gridPrefix, showStartDateColumn, null, filterModel2);
		InitGridModel(model, gridId, filterModel2);
		model.IsPortletModel = isPortletModel.HasValue && isPortletModel.Value;
		Type type = ((((IWorkflowInstanceFilter)filterModel2.Filter).ProcessHeader != null) ? WorkflowInstanceManager.Instance.GetContextType(((IWorkflowInstanceFilter)filterModel2.Filter).ProcessHeader) : typeof(IWorkflowInstanceContext));
		return ExportExcel(model.GridData, type, () => (ActionResult)(object)((Controller)this).PartialView("WorkflowInstance/Grid", (object)model));
	}

	public ActionResult Info(long id, int? selectedTab, IWorkflowInstanceFilter InstanceFilter = null, int? secondTab = null)
	{
		ProcessHeaderInfo processHeaderInfo = ProcessHeaderManager.Instance.GetProcessesInfo(id, filterByMembers: false).FirstOrDefault();
		if (selectedTab.HasValue)
		{
			processHeaderInfo.SelectedTab = selectedTab.Value;
		}
		if (secondTab.HasValue)
		{
			processHeaderInfo.SecondTab = secondTab.Value;
		}
		processHeaderInfo.InstanceFilter = InstanceFilter ?? InterfaceActivator.Create<IWorkflowInstanceFilter>();
		processHeaderInfo.InstanceFilter.ProcessHeader = ProcessHeaderManager.Instance.Load(id);
		IWorkflowProcess published = ProcessHeaderManager.Instance.Load(id).Published;
		if (published != null)
		{
			Type instanceContextFilterType = WorkflowInstanceContextService.GetInstanceContextFilterType(published);
			if (instanceContextFilterType != null)
			{
				processHeaderInfo.InstanceFilter.ContextFilter = (Filter)Activator.CreateInstance(instanceContextFilterType);
			}
		}
		return (ActionResult)(object)((Controller)this).View((object)processHeaderInfo);
	}

	public JsonResult GetProcessHeaders(string text = "")
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		object obj = null;
		if (base.SecurityService.HasPermission(WorkflowPermissionProvider.FullMonitorAccessPermission))
		{
			InstanceOf<IProcessHeaderFilter> instanceOf = new InstanceOf<IProcessHeaderFilter>();
			instanceOf.New.SearchString = text;
			instanceOf.New.HasPublished = true;
			IProcessHeaderFilter @new = instanceOf.New;
			obj = (from u in ProcessHeaderManager.Instance.Find(@new, FetchOptions.All)
				select new
				{
					Value = u.Id.ToString(),
					Text = SR.T(u.Name)
				} into i
				where !string.IsNullOrEmpty(i.Text)
				orderby i.Text
				select i).ToArray();
		}
		else
		{
			obj = (from u in ProcessHeaderManager.Instance.GetMonitorProcessesAllInfo(text).ToList()
				select new
				{
					Value = u.Id.ToString(),
					Text = u.Name
				} into i
				where !string.IsNullOrEmpty(i.Text)
				orderby i.Text
				select i).ToArray();
		}
		JsonResult val = new JsonResult();
		val.set_Data(obj);
		return val;
	}

	public ActionResult PortletView(MonitorPortletPersonalization settings)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)settings);
	}

	[Permission("3534CCCF-2C6A-4510-849D-90B223DC1596")]
	public ActionResult FullIndex()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		MonitorModel monitorModel = new MonitorModel();
		return (ActionResult)(object)((Controller)this).View((object)monitorModel);
	}

	[Permission("3534CCCF-2C6A-4510-849D-90B223DC1596")]
	public ActionResult FullTreeGrid(string ProcessName, int[] Owner, bool isEmulation = false)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		long nodeCount = 0L;
		bool expandAll = ((ProcessName != null || Owner != null) ? true : false);
		List<ProcessGroupTreeNode> list = BuildMonitorTree(out nodeCount, ProcessName, Owner, isEmulation, expandAll);
		ProcessGroupTreeNode treeModel = new ProcessGroupTreeNode
		{
			Name = SR.T("Все процессы"),
			Id = 0L,
			TypeNode = 0,
			Nodes = list,
			GlobalIndex = 0L,
			ExpandAll = expandAll
		};
		list.ForEach(delegate(ProcessGroupTreeNode t)
		{
			t.ParentNode = treeModel;
		});
		string arg = treeModel.ToMonitorJson(((Controller)this).get_Url(), isEmulation);
		string content = $"{{\"records\":0,\"page\":0,\"total\":{nodeCount},\"rows\":[{arg}]}}";
		ContentResult val = new ContentResult();
		val.set_ContentType("text/x-json;charset=utf-8");
		val.set_Content(content);
		return (ActionResult)val;
	}

	protected List<ProcessGroupTreeNode> BuildMonitorTree(out long nodeCount, string NameProcess = null, int[] listUser = null, bool isEmulation = false, bool expandAll = false)
	{
		List<ProcessGroupDTO> groupTree = ProcessGroupManager.LoadGroupsTree().ToList();
		List<ProcessHeaderInfo> headerInfo = ProcessHeaderManager.LoadProcessHeadFullTree(NameProcess, listUser, isEmulation).ToList();
		nodeCount = groupTree.Count + headerInfo.Count;
		List<ProcessGroupTreeNode> list = new List<ProcessGroupTreeNode>();
		int globalIndex = 1;
		Func<ProcessGroupDTO, ProcessGroupTreeNode, ProcessGroupTreeNode> makeGroupNode = null;
		Func<ProcessHeaderInfo, ProcessGroupTreeNode, ProcessGroupTreeNode> makeHeaderNode = null;
		makeHeaderNode = delegate(ProcessHeaderInfo head, ProcessGroupTreeNode parent)
		{
			ProcessGroupTreeNode treeNode2 = new ProcessGroupTreeNode
			{
				Id = head.Id,
				Name = SR.T(head.Name),
				TypeNode = 1,
				Info = head,
				ParentNode = parent,
				GlobalIndex = globalIndex,
				ExpandAll = expandAll
			};
			globalIndex++;
			IEnumerable<ProcessHeaderInfo> source3 = headerInfo.Where((ProcessHeaderInfo h) => h.ParentProcessId == treeNode2.Id);
			treeNode2.Nodes.AddRange(source3.Select((ProcessHeaderInfo h) => makeHeaderNode(h, treeNode2)));
			return treeNode2;
		};
		makeGroupNode = delegate(ProcessGroupDTO group, ProcessGroupTreeNode parent)
		{
			ProcessGroupTreeNode treeNode = new ProcessGroupTreeNode
			{
				Id = group.Id,
				Name = SR.T(group.Name),
				TypeNode = 0,
				ParentNode = parent,
				GlobalIndex = globalIndex,
				ExpandAll = expandAll
			};
			globalIndex++;
			IEnumerable<ProcessGroupDTO> source = groupTree.Where((ProcessGroupDTO n) => n.ParentId == treeNode.Id);
			treeNode.Nodes = source.Select((ProcessGroupDTO ch) => makeGroupNode(ch, treeNode)).ToList();
			IEnumerable<ProcessHeaderInfo> source2 = headerInfo.Where((ProcessHeaderInfo h) => h.ParentId == treeNode.Id);
			treeNode.Nodes.AddRange(source2.Select((ProcessHeaderInfo h) => makeHeaderNode(h, treeNode)));
			return treeNode;
		};
		IEnumerable<ProcessGroupTreeNode> collection = from g in groupTree
			where g.ParentId == 0
			select g into r
			select makeGroupNode(r, null);
		IEnumerable<ProcessGroupTreeNode> collection2 = from h in headerInfo
			where h.ParentId == 0L && h.ParentProcessId == 0
			select makeHeaderNode(h, null);
		list.AddRange(collection);
		list.AddRange(collection2);
		return list;
	}

	public static SwimlaneGroupInfo GetSwimlanesInfo(IProcessHeader header, long? filterId = null, FilterModel filterModel = null)
	{
		IWorkflowProcess published = header.Published;
		IWorkflowInstanceFilter workflowInstanceFilter = ((filterModel != null) ? (filterModel.Filter as IWorkflowInstanceFilter) : null);
		List<ActivityInfoHeader> source = ((workflowInstanceFilter != null) ? WorkflowTaskBaseManager.Instance.GetTasksCountByActivitiesSwimlayn(header.Id, workflowInstanceFilter) : WorkflowTaskBaseManager.Instance.GetTasksCountByActivitiesSwimlayn(header.Id, filterId));
		List<IProcessHeader> subprocess = ProcessHeaderManager.Instance.GetSubprocessTreeList(header.Id);
		SwimlaneGroupInfo swimlaneGroupInfo = new SwimlaneGroupInfo();
		foreach (SwimlaneElement item in published.Diagram.Elements.OfType<SwimlaneElement>())
		{
			SwimlaneInfo swimlaneInfo = new SwimlaneInfo
			{
				Name = item.LocalizableName,
				SwimlaneUid = item.Uid
			};
			SwimlaneElement element = item;
			foreach (BPMNFlowElement item2 in from e in published.Diagram.Elements.OfType<BPMNFlowElement>()
				where e.ParentUid == element.Uid
				select e)
			{
				if (string.IsNullOrEmpty(item2.LocalizableName))
				{
					continue;
				}
				BPMNFlowElement activity1 = item2;
				if (activity1 is InternalSubprocessElement)
				{
					ActivityInfoHeader activityInfoHeader = source.FirstOrDefault((ActivityInfoHeader i) => subprocess.Where((IProcessHeader a) => a.Id == i.HeaderId).Count() > 0);
					if (activityInfoHeader == null)
					{
						activityInfoHeader = new ActivityInfoHeader
						{
							Uid = item2.Uid
						};
					}
					ActivityInfo activityInfo = new ActivityInfo
					{
						Name = activityInfoHeader.Name,
						Uid = activityInfoHeader.Uid,
						Count = activityInfoHeader.Count
					};
					swimlaneInfo.TotalCount += activityInfo.Count;
					activityInfo.Name = item2.LocalizableName;
					swimlaneInfo.ActivitiesInfo.Add(activityInfo);
				}
				else
				{
					ActivityInfoHeader activityInfoHeader2 = source.FirstOrDefault((ActivityInfoHeader i) => i.Uid == activity1.Uid);
					if (activityInfoHeader2 == null)
					{
						activityInfoHeader2 = new ActivityInfoHeader
						{
							Uid = item2.Uid
						};
					}
					ActivityInfo activityInfo2 = new ActivityInfo
					{
						Name = activityInfoHeader2.Name,
						Uid = activityInfoHeader2.Uid,
						Count = activityInfoHeader2.Count
					};
					swimlaneInfo.TotalCount += activityInfo2.Count;
					activityInfo2.Name = item2.LocalizableName;
					swimlaneInfo.ActivitiesInfo.Add(activityInfo2);
				}
			}
			swimlaneGroupInfo.SwimlanesInfo.Add(swimlaneInfo);
		}
		swimlaneGroupInfo.Header = header;
		swimlaneGroupInfo.FilterId = filterId;
		return swimlaneGroupInfo;
	}

	public static ExecutorsInfo GetExecutorsInfo(IProcessHeader header, long? filterId = null, FilterModel filterModel = null)
	{
		IWorkflowInstanceFilter workflowInstanceFilter = ((filterModel != null) ? (filterModel.Filter as IWorkflowInstanceFilter) : null);
		List<EleWise.ELMA.Workflow.Models.ExecutorInfo> executors = ((workflowInstanceFilter != null) ? WorkflowTaskBaseManager.Instance.GetTasksCountByExecuters(header.Id, workflowInstanceFilter) : WorkflowTaskBaseManager.Instance.GetTasksCountByExecuters(header.Id, filterId));
		return new ExecutorsInfo
		{
			Header = header,
			Executors = executors,
			FilterId = filterId
		};
	}

	public static StatesInfo GetInstanceStatesInfo(long headerId, long? filterId = null, FilterModel filterModel = null)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(headerId);
		if (processHeader.Published == null)
		{
			return null;
		}
		Filter contextFilter = null;
		IWorkflowInstanceFilter workflowInstanceFilter = ((filterModel != null) ? (filterModel.Filter as IWorkflowInstanceFilter) : null);
		List<StatusInfo> states = ((workflowInstanceFilter != null) ? WorkflowInstanceManager.Instance.GetInstanceCountByStatus(headerId, workflowInstanceFilter, out contextFilter) : WorkflowInstanceManager.Instance.GetInstanceCountByStatus(headerId, filterId, out contextFilter));
		return new StatesInfo
		{
			States = states,
			Filter = contextFilter,
			Header = processHeader,
			FilterId = filterId
		};
	}

	public static StatusesInfo GetInstanceStatusesInfo(long headerId, long? filterId = null, FilterModel filterModel = null)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(headerId);
		if (processHeader.Published == null || processHeader.Published.StatusContextVar == Guid.Empty)
		{
			return null;
		}
		IPropertyMetadata fullInstanceContextPropertyMetadata = WorkflowInstanceContextService.Instance.GetFullInstanceContextPropertyMetadata(processHeader, processHeader.Published.StatusContextVar);
		if (fullInstanceContextPropertyMetadata == null)
		{
			return null;
		}
		Filter contextFilter = null;
		IWorkflowInstanceFilter workflowInstanceFilter = ((filterModel != null) ? (filterModel.Filter as IWorkflowInstanceFilter) : null);
		List<CustomStatusInfo> statuses = ((workflowInstanceFilter != null) ? WorkflowInstanceManager.Instance.GetInstanceCountByCustomStatus(processHeader, workflowInstanceFilter, out contextFilter) : WorkflowInstanceManager.Instance.GetInstanceCountByCustomStatus(processHeader, filterId, out contextFilter));
		if (contextFilter == null)
		{
			return null;
		}
		return new StatusesInfo
		{
			Statuses = statuses,
			StatusContextVarName = fullInstanceContextPropertyMetadata.Name,
			Filter = contextFilter,
			Header = processHeader,
			FilterId = filterId
		};
	}

	private void AddPart(MonitorModel model, ResponsibilityLevel? level, bool? isCurator, string partId, string title)
	{
		IProcessHeaderFilter processHeaderFilter = InterfaceActivator.Create<IProcessHeaderFilter>();
		if (level.HasValue)
		{
			processHeaderFilter.ResponsibilityLevels = new List<ResponsibilityLevel> { level.Value };
		}
		if (isCurator.HasValue)
		{
			processHeaderFilter.IsCurator = true;
		}
		if (processHeaderFilter.ResponsibilityLevels == null && !processHeaderFilter.IsCurator.HasValue)
		{
			processHeaderFilter.PermissionId = WorkflowPermissionProvider.ProcessMonitor.Id;
		}
		IEnumerable<ProcessHeaderInfo> monitorProcessesInfo = ProcessHeaderManager.Instance.GetMonitorProcessesInfo(processHeaderFilter);
		MonitorPartModel monitorPartModel = new MonitorPartModel
		{
			PartId = partId,
			Title = title,
			Headers = monitorProcessesInfo.ToList()
		};
		if (monitorPartModel.Headers.Count > 0)
		{
			model.Parts.Add(monitorPartModel);
		}
	}
}
