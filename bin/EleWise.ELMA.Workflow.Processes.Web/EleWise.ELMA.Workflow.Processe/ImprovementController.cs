using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[AllPermissions(new string[] { "0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6", "38A743DC-7DDB-4ACD-94C7-323F8014E881" })]
public class ImprovementController : FilterWorkflowInstanceController
{
	private const string jsonTempl = "{{\"records\":0,\"page\":0,\"total\":{0},\"rows\":[{1}]}}";

	protected override Guid? Code => WorkflowConstants.ImprovementFilterCode;

	protected override string GridIdPrefix => "TabImprovementInstancesGridPanDiv";

	public WorkflowInstanceContextService WorkflowInstanceContextService { get; set; }

	public ProcessGroupManager ProcessGroupManager { get; set; }

	public ProcessesWorkflowInstanceManager ProcessesWorkflowInstanceManager { get; set; }

	public WorkflowInstanceManager WorkflowInstanceManager { get; set; }

	protected override bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('Улучшения')", Image24 = "#arrow_up.svg", Order = 120)]
	[FilterMenuItem(Id = "improvement-processes", Type = typeof(IWorkflowInstance), FilterEditAction = "EditFilters", CodeStr = "{167EC7D9-814F-478A-A09F-D2D1D48F2E81}")]
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
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = BaseIndexModel(WorkflowProcessesPermissionProvider.ImprovementAccessPermission.Id, FilterId, instanceFilter, selectedTab);
		return (ActionResult)(object)((Controller)this).View((object)workflowInstanceFilterViewModel);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = BaseIndexModel(WorkflowProcessesPermissionProvider.ImprovementAccessPermission.Id, FilterId);
		return (ActionResult)(object)((Controller)this).View("Index", (object)workflowInstanceFilterViewModel);
	}

	[Permission("6B5D2304-E728-45E7-8834-9879518AE950")]
	public ActionResult Processes()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		ICollection<ProcessHeaderInfo> source = ProcessesWorkflowInstanceManager.LoadAllProcessesHeadTree(onlyActive: true);
		ProcessHeaderManager instance = ProcessHeaderManager.Instance;
		InstanceOf<IProcessHeaderFilter> instanceOf = new InstanceOf<IProcessHeaderFilter>();
		instanceOf.New.ResponsibilityLevels = new List<ResponsibilityLevel> { ResponsibilityLevel.Owner };
		List<long> owner = (from h in instance.GetMonitorProcessesInfo(instanceOf.New)
			select h.Id).ToList();
		ProcessHeaderManager instance2 = ProcessHeaderManager.Instance;
		InstanceOf<IProcessHeaderFilter> instanceOf2 = new InstanceOf<IProcessHeaderFilter>();
		instanceOf2.New.IsCurator = true;
		List<long> curator = (from h in instance2.GetMonitorProcessesInfo(instanceOf2.New)
			select h.Id).ToList();
		return (ActionResult)(object)((Controller)this).View((object)new ImproveOverviewModel
		{
			OwnerHeaderInfos = source.Where((ProcessHeaderInfo h) => owner.Contains(h.Id)).ToList(),
			CuratorHeaderInfos = source.Where((ProcessHeaderInfo h) => curator.Contains(h.Id)).ToList()
		});
	}

	[Permission("70E84328-D900-4584-A798-5D13DD17F6D0")]
	public ActionResult AllProcesses()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		MonitorModel monitorModel = new MonitorModel();
		return (ActionResult)(object)((Controller)this).View((object)monitorModel);
	}

	[Permission("70E84328-D900-4584-A798-5D13DD17F6D0")]
	public ActionResult FullTreeGrid()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		long nodeCount = 0L;
		List<ProcessGroupTreeNode> list = BuildMonitorTree(out nodeCount);
		ProcessGroupTreeNode treeModel = new ProcessGroupTreeNode
		{
			Name = SR.T("Все процессы"),
			Id = 0L,
			TypeNode = 0,
			Nodes = list,
			GlobalIndex = 0L
		};
		list.ForEach(delegate(ProcessGroupTreeNode t)
		{
			t.ParentNode = treeModel;
		});
		string arg = treeModel.ToImprovementJson(((Controller)this).get_Url());
		string content = $"{{\"records\":0,\"page\":0,\"total\":{nodeCount},\"rows\":[{arg}]}}";
		ContentResult val = new ContentResult();
		val.set_ContentType("text/x-json;charset=utf-8");
		val.set_Content(content);
		return (ActionResult)val;
	}

	protected List<ProcessGroupTreeNode> BuildMonitorTree(out long nodeCount)
	{
		List<ProcessGroupDTO> groupTree = ProcessGroupManager.LoadGroupsTree().ToList();
		ICollection<ProcessHeaderInfo> headerInfo = ProcessesWorkflowInstanceManager.LoadAllProcessesHeadTree();
		nodeCount = groupTree.Count + headerInfo.Count;
		List<ProcessGroupTreeNode> list = new List<ProcessGroupTreeNode>();
		int globalIndex = 1;
		Func<ProcessGroupDTO, ProcessGroupTreeNode, ProcessGroupTreeNode> makeGroupNode = null;
		Func<ProcessHeaderInfo, ProcessGroupTreeNode, ProcessGroupTreeNode> makeHeaderNode = null;
		makeHeaderNode = delegate(ProcessHeaderInfo head, ProcessGroupTreeNode parent)
		{
			ProcessGroupTreeNode result = new ProcessGroupTreeNode
			{
				Id = head.Id,
				Name = SR.T(head.Name),
				TypeNode = 1,
				Info = head,
				ParentNode = parent,
				GlobalIndex = globalIndex
			};
			globalIndex++;
			return result;
		};
		makeGroupNode = delegate(ProcessGroupDTO group, ProcessGroupTreeNode parent)
		{
			ProcessGroupTreeNode treeNode = new ProcessGroupTreeNode
			{
				Id = group.Id,
				Name = SR.T(group.Name),
				TypeNode = 0,
				ParentNode = parent,
				GlobalIndex = globalIndex
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
			where h.ParentId == 0
			select makeHeaderNode(h, null);
		list.AddRange(collection);
		list.AddRange(collection2);
		return list;
	}

	public ActionResult ImprovementPopup(long? instanceId, long? taskId, string popupId)
	{
		((Controller)this).get_ModelState().Clear();
		IEntityManager<IImprovementProcessSettings> instance2 = EntityManager<IImprovementProcessSettings>.Instance;
		InstanceOf<IImprovementProcessSettingsFilter> instanceOf = new InstanceOf<IImprovementProcessSettingsFilter>();
		instanceOf.New.Default = true;
		IImprovementProcessSettings improvementProcessSettings = instance2.Find(instanceOf.New, new FetchOptions(0, 1)).FirstOrDefault();
		if (improvementProcessSettings == null)
		{
			throw new Exception(SR.T("Не выбран улучшающий процесс"));
		}
		ITaskBase taskBase = (taskId.HasValue ? TaskBaseManager.Instance.Load(taskId.Value) : null);
		IWorkflowInstance instance = null;
		if (instanceId.HasValue)
		{
			if (taskBase != null)
			{
				base.SecurityService.RunWithElevatedPrivilegies(delegate
				{
					instance = WorkflowInstanceManager.Load(instanceId.Value);
				});
			}
			else
			{
				instance = WorkflowInstanceManager.Load(instanceId.Value);
			}
		}
		IProcessHeader processHeader = ((instance != null) ? instance.Process.Header : null);
		StartImprovementInfo startImprovementInfo = new StartImprovementInfo();
		startImprovementInfo.Caption = ((processHeader != null) ? SR.T("Введите описание улучшения и нажмите кнопку \"Отправить\":") : SR.T("Выберите процесс для улучшения, введите описание и нажмите кнопку \"Отправить\":"));
		startImprovementInfo.PostAction = "ImprovementStart";
		startImprovementInfo.PostController = "Improvement";
		startImprovementInfo.PostArea = "EleWise.ELMA.Workflow.Processes.Web";
		startImprovementInfo.PopupId = popupId;
		startImprovementInfo.Instance = instance;
		startImprovementInfo.Header = processHeader;
		startImprovementInfo.Task = taskBase;
		startImprovementInfo.Settings = improvementProcessSettings;
		startImprovementInfo.Name = ((instance != null) ? SR.T("Улучшение - {0}", SR.T(instance.Process.Name)) : null);
		StartImprovementInfo startImprovementInfo2 = startImprovementInfo;
		return (ActionResult)(object)((Controller)this).PartialView((object)startImprovementInfo2);
	}

	public ActionResult ProcessImprovementPopup()
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[HttpPost]
	public ActionResult ImprovementStart(StartImprovementInfo info)
	{
		IWorkflowRuntimeService serviceNotNull = Locator.GetServiceNotNull<IWorkflowRuntimeService>();
		IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.Create();
		workflowInstance.Process = info.Settings.Header.Published;
		workflowInstance.Name = info.Name;
		workflowInstance.Initiator = base.AuthenticationService.GetCurrentUser<IUser>();
		workflowInstance.Context.SetPropertyValue(info.Settings.ProcessHeaderContextVar, info.Header);
		workflowInstance.Context.SetPropertyValue(info.Settings.WorkflowInstanceContextVar, info.Instance);
		workflowInstance.Context.SetPropertyValue(info.Settings.TaskContextVar, info.Task);
		workflowInstance.Context.SetPropertyValue(info.Settings.DescriptionContextVar, info.Description);
		try
		{
			serviceNotNull.Run(workflowInstance);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			});
		}
		catch (Exception ex)
		{
			base.Logger.Log(LogLevel.Error, ex, "Improvement start error", null);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
	}

	protected List<ImproveInstanceModel> GetImprovementInstances(IEnumerable<long> headerIds, FetchOptions fetchOptions)
	{
		List<ImproveInstanceModel> list = new List<ImproveInstanceModel>();
		ImprovementProcessSettingsManager instance = ImprovementProcessSettingsManager.Instance;
		InstanceOf<IImprovementProcessSettingsFilter> instanceOf = new InstanceOf<IImprovementProcessSettingsFilter>();
		instanceOf.New.Default = true;
		IImprovementProcessSettings sett = instance.Find(instanceOf.New, new FetchOptions(0, 1)).FirstOrDefault();
		List<IWorkflowInstance> source = ImprovementManager.GetInstancesByImprovedProcessHeaders(headerIds, fetchOptions).ToList();
		if (source.Any())
		{
			Locator.GetServiceNotNull<WorkflowTaskBaseManager>();
			Locator.GetServiceNotNull<WorkflowInstanceManager>();
			Locator.GetServiceNotNull<IWorkflowMessagingService>();
			list.AddRange(source.Select((IWorkflowInstance item) => new ImproveInstanceModel
			{
				Instance = item,
				ImprovedProcessHeader = (item.Context.GetPropertyValue(sett.ProcessHeaderContextVar) as IProcessHeader),
				Operations = new OperationsModel(item, init: true, initTasks: true)
			}));
		}
		return list;
	}

	[CustomGridAction]
	public ActionResult LastImprovementsGrid(GridCommand command, List<long> headerIds, string gridId)
	{
		GridData<ImproveInstanceModel> gridData = new GridData<ImproveInstanceModel>
		{
			Command = command
		};
		gridData.SetCount((GridData<ImproveInstanceModel> d, FetchOptions f) => ImprovementManager.GetInstancesByImprovedProcessHeadersCount(headerIds));
		gridData.SetDataSource((GridData<ImproveInstanceModel> d, FetchOptions f) => (d.Count <= 0) ? new List<ImproveInstanceModel>() : GetImprovementInstances(headerIds, f));
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)gridId);
		return (ActionResult)(object)((Controller)this).PartialView("LastImprovementsGrid", (object)gridData);
	}

	public JsonResult GetProcessHeaders(string text = "")
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		object obj = null;
		obj = (from u in ImprovementProcessSettingsManager.Instance.GetProcessHeaderList(text)
			select new
			{
				Value = u.Id.ToString(),
				Text = SR.T(u.Name)
			} into i
			where !string.IsNullOrEmpty(i.Text)
			orderby i.Text
			select i).ToArray();
		JsonResult val = new JsonResult();
		val.set_Data(obj);
		return val;
	}

	[HttpGet]
	public ActionResult Settings()
	{
		ImprovementSettingsModel improvementSettingsModel = new ImprovementSettingsModel();
		improvementSettingsModel.ProcessList = EntityManager<IImprovementProcessSettings>.Instance.FindAll().ToList();
		return (ActionResult)(object)((Controller)this).View((object)improvementSettingsModel);
	}

	[HttpGet]
	public ActionResult EditProcessSettings(long? id)
	{
		IImprovementProcessSettings improvementProcessSettings = ((!id.HasValue) ? InterfaceActivator.Create<IImprovementProcessSettings>() : EntityManager<IImprovementProcessSettings>.Instance.Load(id));
		return (ActionResult)(object)((Controller)this).PartialView((object)improvementProcessSettings);
	}

	[HttpPost]
	public ActionResult EditProcessSettings(IImprovementProcessSettings settings)
	{
		string text = string.Empty;
		try
		{
			if (!EntityManager<IImprovementProcessSettings>.Instance.Find(new FetchOptions(0, 1)).Any())
			{
				settings.Default = true;
			}
			settings.Save();
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	[HttpGet]
	public ActionResult SettingsGrid()
	{
		ImprovementSettingsModel improvementSettingsModel = new ImprovementSettingsModel();
		improvementSettingsModel.ProcessList = EntityManager<IImprovementProcessSettings>.Instance.FindAll().ToList();
		return (ActionResult)(object)((Controller)this).PartialView((object)improvementSettingsModel);
	}

	[HttpGet]
	public ActionResult ContextVarMapping(long id)
	{
		IImprovementProcessSettings improvementProcessSettings = InterfaceActivator.Create<IImprovementProcessSettings>();
		improvementProcessSettings.Header = ProcessHeaderManager.Instance.Load(id);
		List<PropertyMetadata> inputContextVars = GetInputContextVars(id, EntityDescriptor.UID, InterfaceActivator.UID<IProcessHeader>(loadImplementation: false));
		improvementProcessSettings.ProcessHeaderContextVar = inputContextVars.Select((PropertyMetadata x) => x.Uid).FirstOrDefault();
		inputContextVars = GetInputContextVars(id, EntityDescriptor.UID, InterfaceActivator.UID<IWorkflowInstance>(loadImplementation: false));
		improvementProcessSettings.WorkflowInstanceContextVar = inputContextVars.Select((PropertyMetadata x) => x.Uid).FirstOrDefault();
		inputContextVars = GetInputContextVars(id, EntityDescriptor.UID, InterfaceActivator.UID<ITaskBase>(loadImplementation: false));
		improvementProcessSettings.TaskContextVar = inputContextVars.Select((PropertyMetadata x) => x.Uid).FirstOrDefault();
		inputContextVars = GetInputContextVars(id, TextDescriptor.UID, Guid.Empty);
		improvementProcessSettings.DescriptionContextVar = inputContextVars.Select((PropertyMetadata x) => x.Uid).FirstOrDefault();
		return (ActionResult)(object)((Controller)this).PartialView((object)improvementProcessSettings);
	}

	public virtual List<PropertyMetadata> GetInputContextVars(long processHeadId, Guid typeUid, Guid subTypeUid, string text = "")
	{
		ClassMetadata metadata = null;
		if (subTypeUid != Guid.Empty)
		{
			metadata = (ClassMetadata)MetadataLoader.LoadMetadata(subTypeUid, inherit: true, loadImplementation: false);
		}
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(processHeadId);
		if (processHeader.Published == null)
		{
			return new List<PropertyMetadata>();
		}
		return (from EntityPropertyMetadata cp in WorkflowInstanceContextService.GetInstanceContextMetadata(processHeader.Published).Properties
			where cp.Input && (string.IsNullOrEmpty(text) || cp.DisplayName.ToUpper().Contains(text.ToUpper())) && typeUid == cp.TypeUid && (cp.SubTypeUid == subTypeUid || MetadataLoader.IsBaseClass(cp.SubTypeUid, metadata, loadImplementation: false))
			select cp).Cast<PropertyMetadata>().ToList();
	}

	public ActionResult GetContextVars(long? processHeadId, Guid typeUid, Guid subTypeUid, string text = "")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Expected O, but got Unknown
		if (!processHeadId.HasValue)
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)"");
			return (ActionResult)val;
		}
		List<PropertyMetadata> inputContextVars = GetInputContextVars(processHeadId.Value, typeUid, subTypeUid, text);
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)new SelectList((IEnumerable)inputContextVars.Select((PropertyMetadata u) => new
		{
			id = u.Uid,
			text = u.DisplayName
		}).ToList(), "id", "text"));
		return (ActionResult)val2;
	}

	public ActionResult Delete(long id)
	{
		IImprovementProcessSettings improvementProcessSettings = EntityManager<IImprovementProcessSettings>.Instance.Load(id);
		bool @default = improvementProcessSettings.Default;
		improvementProcessSettings.Delete();
		if (@default)
		{
			IImprovementProcessSettings improvementProcessSettings2 = EntityManager<IImprovementProcessSettings>.Instance.Find(new FetchOptions(0, 1)).FirstOrDefault();
			if (improvementProcessSettings2 != null)
			{
				improvementProcessSettings2.Default = true;
				improvementProcessSettings2.Save();
			}
		}
		ImprovementSettingsModel improvementSettingsModel = new ImprovementSettingsModel();
		improvementSettingsModel.ProcessList = EntityManager<IImprovementProcessSettings>.Instance.FindAll().ToList();
		return (ActionResult)(object)((Controller)this).PartialView("SettingsGrid", (object)improvementSettingsModel);
	}

	[TransactionAction]
	public ActionResult SetDefault(long id)
	{
		foreach (IImprovementProcessSettings item in EntityManager<IImprovementProcessSettings>.Instance.Find((IImprovementProcessSettings x) => x.Default))
		{
			item.Default = false;
			item.Save();
		}
		IImprovementProcessSettings improvementProcessSettings = EntityManager<IImprovementProcessSettings>.Instance.Load(id);
		improvementProcessSettings.Default = true;
		improvementProcessSettings.Save();
		ImprovementSettingsModel improvementSettingsModel = new ImprovementSettingsModel();
		improvementSettingsModel.ProcessList = EntityManager<IImprovementProcessSettings>.Instance.FindAll().ToList();
		return (ActionResult)(object)((Controller)this).PartialView("SettingsGrid", (object)improvementSettingsModel);
	}

	[CustomGridAction]
	public ActionResult GridData(GridCommand command, [Bind(Prefix = "InstanceFilter")] IWorkflowInstanceFilter instanceFilter, [Bind(Prefix = "DataFilter")] FilterModel filterModel, string gridId, long? FilterId = null, WorkflowInstanceGeneralStatus? userState = null, bool filterByUserStatus = false, DropDownItem userStatus = null, bool? isPortletModel = false, Guid? portletId = null)
	{
		FilterModel filterModel2 = filterModel;
		IWorkflowInstanceFilter workflowInstanceFilter = ((filterModel2 != null) ? ((IWorkflowInstanceFilter)filterModel2.Filter) : null);
		if (filterModel2 == null || filterModel2.Filter == null)
		{
			GridState getSourceForRefresh = null;
			if (isPortletModel.HasValue && isPortletModel.Value && portletId.HasValue && FilterId.HasValue)
			{
				getSourceForRefresh = FilterPortletPersonalization.GetGridState(AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value), portletId.ToString(), gridId);
			}
			filterModel2 = CreateFilter(FilterId, null, null, getSourceForRefresh);
			workflowInstanceFilter = (IWorkflowInstanceFilter)filterModel2.Filter;
			if (instanceFilter != null && instanceFilter.ProcessHeader != null && instanceFilter.ProcessHeader.Published != null)
			{
				Type instanceContextFilterType = WorkflowInstanceContextService.GetInstanceContextFilterType(instanceFilter.ProcessHeader.Published);
				if (instanceContextFilterType != null && (workflowInstanceFilter.ContextFilter == null || workflowInstanceFilter.ContextFilter.GetType() != instanceContextFilterType))
				{
					workflowInstanceFilter.ContextFilter = (Filter)Activator.CreateInstance(instanceContextFilterType);
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
			workflowInstanceFilter.GeneralStatus = userState;
		}
		if (filterByUserStatus)
		{
			if (userStatus != null)
			{
				Filter contextFilter = workflowInstanceFilter.ContextFilter;
				IProcessHeader processHeader = workflowInstanceFilter.ProcessHeader;
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
				workflowInstanceFilter.WithNullStatus = true;
			}
		}
		string gridPrefix = ((Controller)this).get_Request()["gridPrefix"];
		bool showStartDateColumn = Convert.ToBoolean(((Controller)this).get_Request()["showStartDateColumn"] ?? false.ToString());
		ContextGridModel model = WorkflowInstanceController.CreateContextGridModel(command, (IWorkflowInstanceFilter)filterModel2.Filter, gridPrefix, showStartDateColumn, null, filterModel2);
		InitGridModel(model, gridId, filterModel2);
		model.IsPortletModel = isPortletModel.HasValue && isPortletModel.Value;
		Type type = ((workflowInstanceFilter.ProcessHeader != null) ? WorkflowInstanceManager.Instance.GetContextType(workflowInstanceFilter.ProcessHeader) : typeof(IWorkflowInstanceContext));
		return ExportExcel(model.GridData, type, () => (ActionResult)(object)((Controller)this).PartialView("WorkflowInstance/Grid", (object)model));
	}
}
