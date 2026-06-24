using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;
using Iesi.Collections.Generic;
using NHibernate;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("76EC51E5-E826-4876-8B8A-BFED9D2CF6CF")]
public class AllTasksController : FilterTreeBaseController<ITaskBase, long>
{
	private static FilterMenuProvider filterMenuProvider;

	private static readonly SolveTaskPortletPersonalization EmptySolveTaskPortletPersonalization = new SolveTaskPortletPersonalization();

	private readonly Type taskBaseType = InterfaceActivator.TypeOf<ITaskBase>();

	private List<string> LocalizedItemNames = new List<string>
	{
		SR.T("Задачи"),
		SR.T("Поиск задач"),
		SR.T("Входящие"),
		SR.T("Текущий контроль"),
		SR.T("Контроль выполнения"),
		SR.T("Исходящие"),
		SR.T("Периодические задачи - Текущие"),
		SR.T("Периодические задачи - Завершенные")
	};

	private static readonly IDictionary<Guid, SearchTasksType> SearchTasksTypeCodes = new Dictionary<Guid, SearchTasksType>
	{
		{
			TaskConstants.IncomingThreadCodeUid,
			SearchTasksType.Incoming
		},
		{
			TaskConstants.OutgoingThreadCodeUid,
			SearchTasksType.Outgoing
		},
		{
			TaskConstants.ExecutionControlThreadCodeUid,
			SearchTasksType.ExecutionControl
		},
		{
			TaskConstants.CurrentControlThreadCodeUid,
			SearchTasksType.CurrentControl
		},
		{
			TaskConstants.CoExecutionControlThreadCodeUid,
			SearchTasksType.CoExecutorCurrent
		},
		{
			TaskConstants.SearchThreadCodeUid,
			SearchTasksType.Search
		}
	};

	public PortletManager PortletManager { get; set; }

	public TaskManager TaskManager { get; set; }

	public TaskBaseManager TaskBaseManager { get; set; }

	public TaskControlManager TaskControlManager { get; set; }

	protected override Guid? Code => ((Guid?)((ControllerBase)this).get_ViewData().get_Item("Code")) ?? TaskConstants.SearchThreadCodeUid;

	protected override Guid? UniqueFilterUid
	{
		get
		{
			if (!IsControl())
			{
				return null;
			}
			return TaskControlUniqueFilterExtension.Guid;
		}
	}

	private static FilterMenuProvider FilterMenuProviderStatic
	{
		get
		{
			if (filterMenuProvider == null)
			{
				filterMenuProvider = Locator.GetServiceNotNull<FilterMenuProvider>();
			}
			return filterMenuProvider;
		}
	}

	protected override string GridIdPrefix => "Tasks";

	protected override bool EnableEqlQuery => !IsControl();

	public static List<TreeMenuNode> GetTreeChildren(Guid? code, SearchTasksType searchType)
	{
		string text = "Index";
		switch (searchType)
		{
		case SearchTasksType.Incoming:
			text = "Incoming";
			break;
		case SearchTasksType.Outgoing:
			text = "Outgoing";
			break;
		case SearchTasksType.ExecutionControl:
			text = "ExecutionControl";
			break;
		case SearchTasksType.CurrentControl:
			text = "CurrentControl";
			break;
		case SearchTasksType.Search:
			text = "Search";
			break;
		case SearchTasksType.CoExecutorCurrent:
			text = "Coexecution";
			break;
		}
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		Guid guid = InterfaceActivator.UID<ITaskBase>();
		if (searchType == SearchTasksType.Search)
		{
			TreeMenuNode item = new TreeMenuNode
			{
				id = "{19545547-E11C-4C4B-9BC5-4FF4BBAE04CE}",
				text = SR.T("Поиск"),
				icon = "#folder.svg",
				typeuid = guid,
				children = FilterMenuProviderStatic.TreeMenuNodesWithoutAll(guid, null, new ActionRoute(text, "AllTasks", new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}), "FilterId", text, code)
			};
			list.Add(item);
			TreeMenuNode item2 = new TreeMenuNode
			{
				id = "{231F289D-88DA-4C29-856A-56365909499D}",
				text = SR.T("Входящие"),
				icon = "#folder.svg",
				typeuid = guid,
				children = FilterMenuProviderStatic.TreeMenuNodesWithoutAll(guid, null, new ActionRoute("Incoming", "AllTasks", new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}), "FilterId", "Incoming", TaskConstants.IncomingThreadCodeUid)
			};
			list.Add(item2);
			TreeMenuNode item3 = new TreeMenuNode
			{
				id = "{05B409B2-4AFA-478B-BE1A-4E51E3BA8EE1}",
				text = SR.T("Исходящие"),
				icon = "#folder.svg",
				typeuid = guid,
				children = FilterMenuProviderStatic.TreeMenuNodesWithoutAll(guid, null, new ActionRoute("Outgoing", "AllTasks", new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}), "FilterId", "Outgoing", TaskConstants.OutgoingThreadCodeUid)
			};
			list.Add(item3);
			TreeMenuNode item4 = new TreeMenuNode
			{
				id = "{FA610A6E-9CF2-4E10-AF47-3AC6AF579C6A}",
				text = SR.T("Контроль выполнения"),
				icon = "#folder.svg",
				typeuid = TaskControlUniqueFilterExtension.Guid,
				children = FilterMenuProviderStatic.TreeMenuNodesWithoutAll(TaskControlUniqueFilterExtension.Guid, null, new ActionRoute("ExecutionControl", "AllTasks", new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}), "FilterId", "ExecutionControl", TaskConstants.ExecutionControlThreadCodeUid)
			};
			list.Add(item4);
			TreeMenuNode item5 = new TreeMenuNode
			{
				id = "{32F61BC5-CBC7-403A-B36D-143018981709}",
				text = SR.T("Текущий контроль"),
				icon = "#folder.svg",
				typeuid = TaskControlUniqueFilterExtension.Guid,
				children = FilterMenuProviderStatic.TreeMenuNodesWithoutAll(TaskControlUniqueFilterExtension.Guid, null, new ActionRoute("CurrentControl", "AllTasks", new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}), "FilterId", "CurrentControl", TaskConstants.CurrentControlThreadCodeUid)
			};
			list.Add(item5);
			TreeMenuNode item6 = new TreeMenuNode
			{
				id = "{91187856-7B58-4913-8194-D60A446861EA}",
				text = SR.T("Соисполнение"),
				icon = "#folder.svg",
				typeuid = guid,
				children = FilterMenuProviderStatic.TreeMenuNodesWithoutAll(guid, null, new ActionRoute("CurrentControl", "AllTasks", new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}), "FilterId", "Coexecution", TaskConstants.CoExecutionControlThreadCodeUid)
			};
			list.Add(item6);
		}
		else
		{
			list = FilterMenuProviderStatic.TreeMenuNodesWithoutAll((code.HasValue && (code.Value == new Guid("{FA610A6E-9CF2-4E10-AF47-3AC6AF579C6A}") || code.Value == new Guid("{32F61BC5-CBC7-403A-B36D-143018981709}"))) ? TaskControlUniqueFilterExtension.Guid : guid, null, new ActionRoute(text, "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			}), "FilterId", text, code);
		}
		return list;
	}

	public ActionResult EditFiltersIncoming()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<ITaskBase>(), TaskConstants.IncomingThreadCodeUid, includeFavorites: false, withoutAll: true));
	}

	public ActionResult EditFiltersOutgoing()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<ITaskBase>(), TaskConstants.OutgoingThreadCodeUid, includeFavorites: false, withoutAll: true));
	}

	public ActionResult EditFiltersExecutionControl()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		((ControllerBase)this).get_ViewData().set_Item("Code", (object)TaskConstants.ExecutionControlThreadCodeUid);
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<ITaskBase>(), TaskConstants.ExecutionControlThreadCodeUid, includeFavorites: false, withoutAll: true));
	}

	public ActionResult EditFiltersCoExecutionControl()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<ITaskBase>(), TaskConstants.CoExecutionControlThreadCodeUid, includeFavorites: false, withoutAll: true));
	}

	public ActionResult EditFiltersCurrentControl()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		((ControllerBase)this).get_ViewData().set_Item("Code", (object)TaskConstants.CurrentControlThreadCodeUid);
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<ITaskBase>(), TaskConstants.CurrentControlThreadCodeUid, includeFavorites: false, withoutAll: true));
	}

	public ActionResult EditFiltersSearch()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		base.Notifier.Information(SR.T("Вы редактируете дерево фильтров поиска. Для редактирования фильтров в других потоках откройте соответствующий поток, нажмите \"Выбрать фильтр\" и перейдите к редактированию."));
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<ITaskBase>(), TaskConstants.SearchThreadCodeUid, includeFavorites: false, withoutAll: true));
	}

	[HttpGet]
	public override ActionResult EditFilter(long? FilterId = null)
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		return base.EditFilter(FilterId);
	}

	protected override Guid FilterObjectTypeUid(IFilterBase filter, Guid? filterCode)
	{
		if (!IsControl(filterCode))
		{
			return InterfaceActivator.UID<ITaskBase>();
		}
		return TaskControlUniqueFilterExtension.Guid;
	}

	[HttpGet]
	public ActionResult SolveTaskPortlet(SolveTaskPortletPersonalization settings)
	{
		SolveTasksPortletModel solveTasksPortletModel = new SolveTasksPortletModel
		{
			Settings = settings
		};
		IUser user = base.AuthenticationService.GetCurrentUser<IUser>();
		List<ISolveTaskManagement> source = ComponentManager.Current.GetExtensionPoints<ISolveTaskManagement>().ToList();
		if (settings.ExecutionControl)
		{
			solveTasksPortletModel.ExecutionControl = source.Sum((ISolveTaskManagement s) => s.GetExecutionControlCount(user, settings.DebugMode));
		}
		InitializeSortExpressions(solveTasksPortletModel, settings);
		return (ActionResult)(object)((Controller)this).PartialView((object)solveTasksPortletModel);
	}

	[CustomGridAction]
	public ActionResult SolveTaskPortletGrid(GridCommand command, string defSort, ListSortDirection? defDir, [Bind(Prefix = "PortletSettings")] SolveTaskPortletPersonalization settings, string GridId = "SolveTaskPortletGrid")
	{
		GridCommand command2 = InitializeCommandGrid(command, GridId, defSort, defDir);
		SolveTaskGridModel taskGrid = new SolveTaskGridModel
		{
			Settings = settings
		};
		return GridView(DefaultGridData(taskGrid, CreateSolveTaskBaseFilter, command2, GridId, hidePager: false));
	}

	protected ITaskBaseFilter CreateSolveTaskBaseFilter()
	{
		IEnumerable<ISolveTaskManagement> extensionPoints = ComponentManager.Current.GetExtensionPoints<ISolveTaskManagement>();
		ITaskBaseFilter taskBaseFilter = CreateTaskBaseFilter();
		taskBaseFilter.TypeUids = extensionPoints.SelectMany((ISolveTaskManagement s) => s.TypeUid).ToList();
		return taskBaseFilter;
	}

	protected ITaskFilter CreateUnderControlSolveTaskBaseFilter(TaskControlType controlType)
	{
		IEnumerable<ISolveTaskUnderControlManagement> extensionPoints = ComponentManager.Current.GetExtensionPoints<ISolveTaskUnderControlManagement>();
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = false;
		taskFilter.TypeUids = extensionPoints.SelectMany((ISolveTaskUnderControlManagement s) => s.TypeUid).ToList();
		if (controlType == TaskControlType.Execution)
		{
			taskFilter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
		}
		else
		{
			taskFilter.Statuses = TaskBaseExtensions.CurrentControlStatuses.ToList();
		}
		taskFilter.ControlUser = base.AuthenticationService.GetCurrentUser<IUser>();
		taskFilter.ControlType = controlType;
		return taskFilter;
	}

	protected ITaskBaseFilter CreateUnderExecutionControlSolveTaskBaseFilter()
	{
		return CreateUnderControlSolveTaskBaseFilter(TaskControlType.Execution);
	}

	protected ITaskBaseFilter CreateUnderCurrentControlSolveTaskBaseFilter()
	{
		return CreateUnderControlSolveTaskBaseFilter(TaskControlType.Current);
	}

	[CustomGridAction]
	public ActionResult SolveUnderExecutionControlTaskPortletGrid(GridCommand command, string defSort, ListSortDirection? defDir, [Bind(Prefix = "PortletSettings")] SolveTaskPortletPersonalization settings, string GridId = "SolveUnderExecutionControlTaskPortletGridPanel")
	{
		GridCommand command2 = InitializeCommandGrid(command, GridId, defSort, defDir);
		SolveTaskGridModel taskGrid = new SolveTaskGridModel
		{
			Settings = settings,
			ForControl = true,
			GridAction = "SolveUnderExecutionControlTaskPortletGrid"
		};
		return GridView("SolveTaskPortletGrid", DefaultGridData(taskGrid, CreateUnderExecutionControlSolveTaskBaseFilter, command2, GridId, hidePager: false, TaskManager, SearchTasksType.ForMeExecutionControl));
	}

	protected void InitializeSortExpressions(MyTasksPortletModel model, TasksPortletPersonalization settings)
	{
		switch (settings.SortSettings)
		{
		case TasksPortletSortExpression.CreationDate:
			model.DefaultSortExpression = settings.SortSettings.ToString();
			model.DefaultSortDirection = ListSortDirection.Descending;
			break;
		case TasksPortletSortExpression.EndDate:
			model.DefaultSortExpression = settings.SortSettings.ToString();
			model.DefaultSortDirection = ListSortDirection.Ascending;
			break;
		default:
			model.DefaultSortExpression = null;
			break;
		}
	}

	protected GridCommand InitializeCommandGrid(GridCommand command, string gridId, string defSort, ListSortDirection? defDir)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		if (command == null)
		{
			command = new GridCommand();
			command.set_PageSize(GridPersonalizationAdministration.LoadState(gridId)?.PageSize ?? command.get_PageSize());
		}
		if (string.IsNullOrEmpty(command.get_SortExpressionString()))
		{
			IList<SortDescriptor> sortDescriptors = command.get_SortDescriptors();
			SortDescriptor val = new SortDescriptor();
			val.set_Member(defSort ?? "CreationDate");
			val.set_SortDirection(defDir ?? ListSortDirection.Descending);
			sortDescriptors.Add(val);
		}
		((dynamic)((ControllerBase)this).get_ViewBag()).DefaultSortExpression = defSort ?? "CreationDate";
		((dynamic)((ControllerBase)this).get_ViewBag()).DefaultSortDirection = defDir ?? ListSortDirection.Descending;
		((ControllerBase)this).get_ViewData().set_Item("Portlet", (object)true);
		return command;
	}

	[HttpGet]
	public ActionResult MyTasksPortlet(TasksPortletPersonalization settings)
	{
		MyTasksPortletModel myTasksPortletModel = new MyTasksPortletModel();
		IUser currentUser = GetCurrentUser();
		myTasksPortletModel.CurrentControl = TaskControlManager.GetCurrentControlCount(currentUser);
		myTasksPortletModel.ExecutionControl = TaskControlManager.GetExecutionControlCount(currentUser);
		myTasksPortletModel.Expired = TaskBaseManager.GetExpiredCount(currentUser);
		InitializeSortExpressions(myTasksPortletModel, settings);
		return (ActionResult)(object)((Controller)this).PartialView(settings.ViewName, (object)myTasksPortletModel);
	}

	[HttpGet]
	public ActionResult MyTasksInformToPortlet(TasksInformToPortletPersonalization settings)
	{
		MyTasksPortletModel myTasksPortletModel = new MyTasksPortletModel();
		myTasksPortletModel.Expired = ((TaskBaseManager)base.Manager).GetInformToExpiredCount(base.AuthenticationService.GetCurrentUser<IUser>());
		InitializeSortExpressions(myTasksPortletModel, settings);
		return (ActionResult)(object)((Controller)this).PartialView(settings.ViewName, (object)myTasksPortletModel);
	}

	protected ITaskBaseFilter CreateTaskBaseFilter()
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.Executor = base.AuthenticationService.GetCurrentUser<IUser>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		return taskBaseFilter;
	}

	protected GridData<ITaskBase, ITaskBaseFilter> DefaultGridData(TaskGridModel taskGrid, Func<ITaskBaseFilter> createFilterFunc, GridCommand command, string GridId = "AllTasks", bool hidePager = true, IEntityManager manager = null, SearchTasksType searchTasksType = SearchTasksType.FromMeCurrent)
	{
		ITaskBaseFilter filter = createFilterFunc();
		GridData<ITaskBase, ITaskBaseFilter> gridData = CreateGridData(taskGrid, manager ?? base.Manager, command, filter, GridId, searchTasksType);
		if (hidePager)
		{
			gridData.AddCountExecuted(delegate(GridData<ITaskBase, ITaskBaseFilter> d)
			{
				d.IsPageable = d.Count > command.get_PageSize();
			});
		}
		return gridData;
	}

	[CustomGridAction]
	public ActionResult MyTasksPortletGrid(GridCommand command, string defSort, ListSortDirection? defDir, string GridId = "AllTasks")
	{
		GridCommand command2 = InitializeCommandGrid(command, GridId, defSort, defDir);
		IEnumerable<ITaskBaseFilterPortlet> extensionPoints = ComponentManager.Current.GetExtensionPoints<ITaskBaseFilterPortlet>();
		ITaskBaseFilter filter = extensionPoints.FirstOrDefault((ITaskBaseFilterPortlet x) => x.CheckGridId(GridId)).GetTaskBaseFilter();
		GridData<ITaskBase, ITaskBaseFilter> gridData = DefaultGridData(null, () => filter, command2, GridId, hidePager: false);
		return GridView(gridData);
	}

	[FilterMenuItem(Type = typeof(ITaskBase), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null, bool loadGridData = true)
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filterModel = CreateFilter(FilterId);
		if (!((ITaskBaseFilter)filterModel.Filter).NotShowInLists.HasValue)
		{
			((ITaskBaseFilter)filterModel.Filter).NotShowInLists = false;
		}
		filterModel.GridIdPrefix += SearchTasksType.Search;
		((ControllerBase)this).get_ViewData().set_Item("SearchTasksType", (object)SearchTasksType.Search);
		return (ActionResult)(object)((Controller)this).View((object)CreateGridData(null, filterModel, SearchTasksType.Search, !loadGridData));
	}

	[ContentItem(Name = "SR.M('Поиск задач')", Id = "searchPage", Image24 = "#search.svg")]
	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Search(long? FilterId = null)
	{
		if (!((Controller)this).get_Request().QueryString.AllKeys.Any())
		{
			ActionResult val = BaseIndex(FilterId, "FilterId", "Search", TaskConstants.SearchThreadCodeUid);
			if (val != null)
			{
				return val;
			}
		}
		FilterModel filterModel = CreateFilter(FilterId);
		((ITaskBaseFilter)filterModel.Filter).NotShowInLists = false;
		filterModel.GridIdPrefix += SearchTasksType.Search;
		((ControllerBase)this).get_ViewData().set_Item("SearchTasksType", (object)SearchTasksType.Search);
		GridDataFilter<ITaskBase> gridDataFilter = CreateGridData(null, filterModel, SearchTasksType.Search, ((Controller)this).get_Request().QueryString.Count == 1 && ((Controller)this).get_Request()["FilterId"] == "0");
		filterModel.Entity.ExpandSearch = filterModel.Entity.ExpandSearch || filterModel.Entity.Id == 0;
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridDataFilter);
	}

	[ContentItem(Name = "SR.M('Входящие')", Image24 = "#down.svg")]
	public ActionResult Incoming(long? FilterId = null, TaskCompleteStatus status = TaskCompleteStatus.Active, SearchTasksType? type = null)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "Incoming", TaskConstants.IncomingThreadCodeUid);
		if (val != null)
		{
			return val;
		}
		((ControllerBase)this).get_ViewData().set_Item("Header", (object)SR.T("Входящие"));
		return (ActionResult)(status switch
		{
			TaskCompleteStatus.Active => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, type ?? SearchTasksType.Incoming, SearchTasksType.Incoming))), 
			TaskCompleteStatus.Expired => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, type ?? SearchTasksType.ForMeExpired, SearchTasksType.Incoming))), 
			TaskCompleteStatus.Complete => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, type ?? SearchTasksType.ForMeCompleted, SearchTasksType.Incoming))), 
			_ => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.Incoming))), 
		});
	}

	[ContentItem(Name = "SR.M('Исходящие')", Image24 = "#up.svg")]
	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Outgoing(long? FilterId = null, TaskCompleteStatus status = TaskCompleteStatus.Active)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "Outgoing", TaskConstants.OutgoingThreadCodeUid);
		if (val != null)
		{
			return val;
		}
		((ControllerBase)this).get_ViewData().set_Item("Header", (object)SR.T("Исходящие"));
		return (ActionResult)(status switch
		{
			TaskCompleteStatus.Active => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.Outgoing))), 
			TaskCompleteStatus.Expired => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.FromMeExpired, SearchTasksType.Outgoing))), 
			TaskCompleteStatus.Complete => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.FromMeCompleted, SearchTasksType.Outgoing))), 
			_ => ((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.Outgoing))), 
		});
	}

	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Coexecution(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "Coexecution", TaskConstants.CoExecutionControlThreadCodeUid);
		if (val != null)
		{
			return val;
		}
		((ControllerBase)this).get_ViewData().set_Item("Header", (object)SR.T("Соисполнение"));
		return (ActionResult)(object)((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.CoExecutorCurrent)));
	}

	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult ExecutionControl(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "ExecutionControl", TaskConstants.ExecutionControlThreadCodeUid);
		if (val != null)
		{
			return val;
		}
		((ControllerBase)this).get_ViewData().set_Item("Header", (object)SR.T("Контроль выполнения"));
		return (ActionResult)(object)((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.ExecutionControl)));
	}

	public ActionResult ControlledSelected(long[] tasks)
	{
		foreach (long taskId in tasks)
		{
			ITaskBase task = TaskControlManager.DoControlComplete(taskId);
			TaskBaseController.NotifyTaskAction(this, task, SR.T("Задача {0} проконтролирована"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("ExecutionControl", "AllTasks", (object)new
		{
			FilterId = 0
		});
	}

	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult CurrentControl(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "CurrentControl", TaskConstants.CurrentControlThreadCodeUid);
		if (val != null)
		{
			return val;
		}
		((ControllerBase)this).get_ViewData().set_Item("Header", (object)SR.T("Текущий контроль"));
		return (ActionResult)(object)((Controller)this).View("Index", (object)CreateGridData(null, BindFilter(FilterId, SearchTasksType.CurrentControl)));
	}

	public ActionResult GetTaskQuickActions(long id, string viewId)
	{
		ITaskBase task = null;
		try
		{
			task = TaskBaseManager.Instance.LoadOrNull(id);
		}
		catch (SecurityException)
		{
		}
		SolveTaskActionsModel solveTaskActionsModel = null;
		if (task != null)
		{
			solveTaskActionsModel = new SolveTaskActionsModel
			{
				Task = task,
				Actions = (from p in ComponentManager.Current.GetExtensionPoints<ISolveTaskAction>()
					where p.CheckType(task) && p.IsVisible(task, EmptySolveTaskPortletPersonalization.DebugMode)
					group p by p.ActionKey into g
					select g.FirstOrDefault()).ToList(),
				Settings = EmptySolveTaskPortletPersonalization
			};
		}
		((ControllerBase)this).get_ViewData().set_Item("containerId", (object)viewId);
		return (ActionResult)(object)((Controller)this).PartialView("MenuSolveTaskActions", (object)solveTaskActionsModel);
	}

	public ActionResult ForDepartmentClosed()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.ForDepartmentClosed, null, "Executor"));
	}

	public ActionResult FromDepartmentClosed()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.FromDepartmentClosed, null, "CreationAuthor"));
	}

	public PeriodTasksModel CreatePeriodTaskModel(SearchTasksType searchTasksType)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = true;
		taskFilter.OnlyFromMyDepartment = true;
		taskFilter.Periodical = true;
		taskFilter.IsTemplate = true;
		switch (searchTasksType)
		{
		case SearchTasksType.PeriodClosed:
			taskFilter.Status = TaskBaseStatus.WasClosed;
			break;
		case SearchTasksType.PeriodCurrent:
			taskFilter.Status = TaskBaseStatus.NewOrder;
			break;
		}
		return new PeriodTasksModel
		{
			SearchTasksType = searchTasksType,
			TaskTemplates = TaskManager.Find(taskFilter, FetchOptions.All).ToList()
		};
	}

	[ContentItem(Name = "SR.M('Периодические задачи - Текущие')", Root = true, Image24 = "#current.svg")]
	public ActionResult PeriodCurrent()
	{
		return (ActionResult)(object)((Controller)this).View("PeriodTasksList", (object)CreatePeriodTaskModel(SearchTasksType.PeriodCurrent));
	}

	[ContentItem(Name = "SR.M('Периодические задачи - Завершенные')", Root = true, Image24 = "#close_outline.svg")]
	public ActionResult PeriodClosed()
	{
		return (ActionResult)(object)((Controller)this).View("PeriodTasksList", (object)CreatePeriodTaskModel(SearchTasksType.PeriodClosed));
	}

	protected DepartmentTasksModel CreateDepartmentTasksModel(SearchTasksType searchTasksType, SearchTasksType? searchTasksType2, string groupProperty, bool swapCounts = false)
	{
		List<ExecutorInfo> dataExpired = null;
		ITaskBaseFilter taskBaseFilter;
		if (searchTasksType2.HasValue)
		{
			taskBaseFilter = CreateFilterForGrid(null, searchTasksType2.Value);
			dataExpired = ((taskBaseFilter.TypeUid == InterfaceActivator.UID<ITask>()) ? TaskManager.Instance.GetMyDepartmentCounts(taskBaseFilter, groupProperty) : TaskBaseManager.Instance.GetMyDepartmentCounts(taskBaseFilter, groupProperty));
		}
		taskBaseFilter = CreateFilterForGrid(null, searchTasksType);
		return new DepartmentTasksModel
		{
			SearchTasksType = searchTasksType,
			ExecutorsInfo = (from d in (taskBaseFilter.TypeUid == InterfaceActivator.UID<ITask>()) ? TaskManager.Instance.GetMyDepartmentCounts(taskBaseFilter, groupProperty) : TaskBaseManager.Instance.GetMyDepartmentCounts(taskBaseFilter, groupProperty)
				where d.Executor.Status == UserStatus.Active
				orderby d.Executor.FullName
				select d).Select(delegate(ExecutorInfo d)
			{
				int count = d.Count;
				int num = ((dataExpired != null) ? (dataExpired.FirstOrDefault((ExecutorInfo e) => e.Executor == d.Executor) ?? new ExecutorInfo()).Count : 0);
				return new DepartmentTaskExecutorInfo
				{
					Executor = d.Executor,
					CountCurrent = (swapCounts ? num : count),
					CountExpired = (swapCounts ? count : num)
				};
			}).ToList()
		};
	}

	public ActionResult MyDepartmentCurrent()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.ForDepartmentCurrent, SearchTasksType.ForDepartmentExpired, "Executor"));
	}

	public ActionResult MyDepartmentExpired()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.ForDepartmentExpired, SearchTasksType.ForDepartmentCurrent, "Executor", swapCounts: true));
	}

	public ActionResult MyDepartmentControl()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.ForDepartmentControl, null, "ControlUser"));
	}

	public ActionResult FromDepartmentCurrent()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.FromDepartmentCurrent, SearchTasksType.FromDepartmentExpired, "CreationAuthor"));
	}

	public ActionResult FromDepartmentExpired()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.FromDepartmentExpired, SearchTasksType.FromDepartmentCurrent, "CreationAuthor", swapCounts: true));
	}

	public ActionResult FromDepartmentCompleted()
	{
		((Controller)(object)this).SetCurrentMenuItem("mydepartment-tree");
		return (ActionResult)(object)((Controller)this).View("DepartmentList", (object)CreateDepartmentTasksModel(SearchTasksType.FromDepartmentCompleted, null, "CreationAuthor"));
	}

	protected FilterModel BindFilter(long? FilterId, SearchTasksType type, SearchTasksType? thread = null)
	{
		((ControllerBase)this).get_ViewData().set_Item("Code", (object)GenerateFilterCode(thread ?? type));
		FilterModel filterModel = CreateFilter(FilterId, Code);
		if (!FilterId.HasValue || FilterId == 0)
		{
			filterModel.Filter.CopyFrom(CreateFilterForGrid((ITaskBaseFilter)filterModel.Filter, type));
		}
		filterModel.GridIdPrefix = $"{GridIdPrefix}{type}";
		((ControllerBase)this).get_ViewData().set_Item("SearchTasksType", (object)(thread ?? type));
		return filterModel;
	}

	public static Guid? GenerateFilterCode(SearchTasksType thread)
	{
		return thread switch
		{
			SearchTasksType.Incoming => TaskConstants.IncomingThreadCodeUid, 
			SearchTasksType.Outgoing => TaskConstants.OutgoingThreadCodeUid, 
			SearchTasksType.ExecutionControl => TaskConstants.ExecutionControlThreadCodeUid, 
			SearchTasksType.CurrentControl => TaskConstants.CurrentControlThreadCodeUid, 
			SearchTasksType.Search => TaskConstants.SearchThreadCodeUid, 
			SearchTasksType.CoExecutorCurrent => TaskConstants.CoExecutionControlThreadCodeUid, 
			_ => null, 
		};
	}

	public static ITaskBaseFilter CreateFilterForGrid(ITaskBaseFilter filter, SearchTasksType searchTasksType)
	{
		IAuthenticationService serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
		if (filter == null)
		{
			filter = InterfaceActivator.Create<ITaskBaseFilter>();
		}
		filter.NotShowInLists = false;
		if (!filter.IsEmulation.HasValue)
		{
			filter.IsEmulation = false;
		}
		switch (searchTasksType)
		{
		case SearchTasksType.FromMeCompleted:
		{
			ITaskBaseFilter taskBaseFilter11 = filter;
			HashedSet<IUser> obj11 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj11).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter11.CreationAuthors = (ISet<IUser>)(object)obj11;
			filter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
			filter.TypeUids = new List<Guid> { InterfaceActivator.UID<ITask>() };
			break;
		}
		case SearchTasksType.FromMeExpired:
		{
			ITaskBaseFilter taskBaseFilter8 = filter;
			HashedSet<IUser> obj8 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj8).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter8.CreationAuthors = (ISet<IUser>)(object)obj8;
			filter.CompleteStatus = TaskCompleteStatus.Expired;
			break;
		}
		case SearchTasksType.FromMeCurrent:
		case SearchTasksType.Outgoing:
		{
			ITaskBaseFilter taskBaseFilter9 = filter;
			HashedSet<IUser> obj9 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj9).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter9.CreationAuthors = (ISet<IUser>)(object)obj9;
			filter.CompleteStatus = TaskCompleteStatus.Active;
			break;
		}
		case SearchTasksType.ForMeExpired:
		{
			ITaskBaseFilter taskBaseFilter10 = filter;
			HashedSet<IUser> obj10 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj10).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter10.Executors = (ISet<IUser>)(object)obj10;
			filter.CompleteStatus = TaskCompleteStatus.Expired;
			break;
		}
		case SearchTasksType.ForMeCompleted:
		{
			ITaskBaseFilter taskBaseFilter7 = filter;
			HashedSet<IUser> obj7 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj7).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter7.Executors = (ISet<IUser>)(object)obj7;
			filter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
			filter.TypeUids = new List<Guid> { InterfaceActivator.UID<ITask>() };
			break;
		}
		case SearchTasksType.ForMeCurrentControl:
		case SearchTasksType.CurrentControl:
		{
			ITaskControlFilter taskControlFilter = filter as ITaskControlFilter;
			if (taskControlFilter == null)
			{
				taskControlFilter = CreateTaskControlFilter();
				taskControlFilter.CopyFrom(filter);
				filter = taskControlFilter;
			}
			taskControlFilter.TypeUid = InterfaceActivator.UID<ITaskBase>();
			taskControlFilter.UnderControl = true;
			taskControlFilter.CurrentControllers.Add(serviceNotNull.GetCurrentUser<IUser>());
			taskControlFilter.ControlStatus = TaskControlStatus.Current;
			break;
		}
		case SearchTasksType.ForMeExecutionControl:
		case SearchTasksType.ExecutionControl:
		{
			ITaskControlFilter taskControlFilter = filter as ITaskControlFilter;
			if (taskControlFilter == null)
			{
				taskControlFilter = CreateTaskControlFilter();
				taskControlFilter.CopyFrom(filter);
				filter = taskControlFilter;
			}
			taskControlFilter.TypeUid = InterfaceActivator.UID<ITaskBase>();
			taskControlFilter.UnderControl = true;
			taskControlFilter.ControlUser = serviceNotNull.GetCurrentUser<IUser>();
			taskControlFilter.ControlType = TaskControlType.Execution;
			taskControlFilter.ControlStatus = TaskControlStatus.ExecutionActive;
			break;
		}
		case SearchTasksType.ForDepartmentCurrent:
			filter.CompleteStatus = TaskCompleteStatus.Active;
			break;
		case SearchTasksType.ForDepartmentExpired:
			filter.CompleteStatus = TaskCompleteStatus.Expired;
			break;
		case SearchTasksType.ForDepartmentControl:
		{
			ITaskControlFilter taskControlFilter = filter as ITaskControlFilter;
			if (taskControlFilter == null)
			{
				taskControlFilter = CreateTaskControlFilter();
				taskControlFilter.CopyFrom(filter);
				filter = taskControlFilter;
			}
			taskControlFilter.TypeUids = new List<Guid> { InterfaceActivator.UID<ITask>() };
			taskControlFilter.UnderControl = true;
			taskControlFilter.Statuses = TaskBaseExtensions.CurrentControlStatuses.ToList();
			break;
		}
		case SearchTasksType.FromDepartmentCurrent:
			filter.CompleteStatus = TaskCompleteStatus.Active;
			break;
		case SearchTasksType.FromDepartmentExpired:
			filter.CompleteStatus = TaskCompleteStatus.Expired;
			break;
		case SearchTasksType.FromDepartmentCompleted:
			filter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
			break;
		case SearchTasksType.DepartmentCoExecutorExpired:
			filter.CompleteStatus = TaskCompleteStatus.Expired;
			break;
		case SearchTasksType.DepartmentCoExecutorCurrent:
			filter.CompleteStatus = TaskCompleteStatus.Active;
			break;
		case SearchTasksType.ClosePeriodTasks:
		{
			ITaskFilter taskFilter = filter as ITaskFilter;
			filter.Statuses = TaskManager.Instance.PeriodicalTasksForCloseFilter(taskFilter.PeriodTemplate).Statuses;
			break;
		}
		case SearchTasksType.FromMeClosed:
		{
			ITaskBaseFilter taskBaseFilter6 = filter;
			HashedSet<IUser> obj6 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj6).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter6.CreationAuthors = (ISet<IUser>)(object)obj6;
			filter.CompleteStatus = TaskCompleteStatus.Complete;
			break;
		}
		case SearchTasksType.ForMeClosed:
		{
			ITaskBaseFilter taskBaseFilter5 = filter;
			HashedSet<IUser> obj5 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj5).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter5.Executors = (ISet<IUser>)(object)obj5;
			filter.CompleteStatus = TaskCompleteStatus.Complete;
			break;
		}
		case SearchTasksType.FromDepartmentClosed:
			filter.CompleteStatus = TaskCompleteStatus.Complete;
			break;
		case SearchTasksType.ForDepartmentClosed:
			filter.CompleteStatus = TaskCompleteStatus.Complete;
			break;
		case SearchTasksType.ForICoExecutorExpired:
		{
			ITaskBaseFilter taskBaseFilter4 = filter;
			HashedSet<IUser> obj4 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj4).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter4.InformTo = (ISet<IUser>)(object)obj4;
			filter.CompleteStatus = TaskCompleteStatus.Expired;
			filter.OnlyICoExecutor = true;
			break;
		}
		case SearchTasksType.ForICoExecutorCurrent:
		{
			ITaskBaseFilter taskBaseFilter3 = filter;
			HashedSet<IUser> obj3 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj3).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter3.InformTo = (ISet<IUser>)(object)obj3;
			filter.CompleteStatus = TaskCompleteStatus.Active;
			filter.OnlyICoExecutor = true;
			break;
		}
		case SearchTasksType.CoExecutorCurrent:
		{
			ITaskBaseFilter taskBaseFilter2 = filter;
			HashedSet<IUser> obj2 = new HashedSet<IUser>();
			((Set<IUser>)(object)obj2).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter2.InformTo = (ISet<IUser>)(object)obj2;
			filter.CompleteStatus = TaskCompleteStatus.Active;
			break;
		}
		default:
		{
			ITaskBaseFilter taskBaseFilter = filter;
			HashedSet<IUser> obj = new HashedSet<IUser>();
			((Set<IUser>)(object)obj).Add(serviceNotNull.GetCurrentUser<IUser>());
			taskBaseFilter.Executors = (ISet<IUser>)(object)obj;
			filter.CompleteStatus = TaskCompleteStatus.Active;
			break;
		}
		case SearchTasksType.Search:
		case SearchTasksType.PeriodCurrent:
		case SearchTasksType.PeriodClosed:
			break;
		}
		return filter;
	}

	private static ITaskControlFilter CreateTaskControlFilter()
	{
		return InterfaceActivator.Create<ITaskControlFilter>();
	}

	[CustomGridAction]
	public override ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, long? FilterId = null, string searchTasksType = null)
	{
		return FilteredGrid(command, filter, FilterId, searchTasksType);
	}

	[CustomGridAction]
	public ActionResult FilteredGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, long? filterId = null, string searchTasksType = null, string gridStateProviderUid = null, string uniquePrefix = null)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (command != null && string.IsNullOrEmpty(command.get_SortExpressionString()))
		{
			IList<SortDescriptor> sortDescriptors = command.get_SortDescriptors();
			SortDescriptor val = new SortDescriptor();
			val.set_Member("CreationDate");
			val.set_SortDirection(ListSortDirection.Descending);
			sortDescriptors.Add(val);
		}
		Enum.TryParse<SearchTasksType>(searchTasksType, out var result);
		if (filter == null)
		{
			((ControllerBase)this).get_ViewData().set_Item("Code", (object)GenerateFilterCode(result));
			filter = CreateFilter(filterId, Code);
			if (result != 0)
			{
				filter.Filter.CopyFrom(CreateFilterForGrid(null, result));
			}
		}
		if (!Guid.TryParse(gridStateProviderUid, out var result2))
		{
			result2 = FilterGridStateProvider.UID;
		}
		filter.GridIdPrefix = $"{GridIdPrefix}{result}";
		((ControllerBase)this).get_ViewData().set_Item("SearchTasksType", (object)result);
		if (bool.TryParse(((Controller)this).get_Request()["forceTableView"], out var result3))
		{
			((ControllerBase)this).get_ViewData().set_Item("ForceTableView", (object)result3);
		}
		TasksGridDataFilterModel gridData = CreateTasksGridData(command, filter, result, result2, withNoData: false, uniquePrefix);
		return GridView(gridData);
	}

	[CustomGridAction]
	public ActionResult DepartmentExecutorTasks(GridCommand command, [Bind(Prefix = "DataFilter")] ITaskBaseFilter filter, SearchTasksType searchTasksType, long id)
	{
		string gridId = $"DepartmentTasks_{searchTasksType}_{id.ToString()}";
		CreateGridData(command, filter, gridId, searchTasksType, null, null);
		return TasksGrid(command, filter, searchTasksType, gridId);
	}

	[CustomGridAction]
	[InNewNHSession(SessionName = "AllTaskGrid")]
	public ActionResult TasksGrid(GridCommand command, [Bind(Prefix = "DataFilter")] ITaskBaseFilter filter, SearchTasksType searchTasksType, string GridId = "Tasks", string UniqueName = null, string callbackFunction = "", bool enableCustomize = true)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (command != null && string.IsNullOrEmpty(command.get_SortExpressionString()))
		{
			IList<SortDescriptor> sortDescriptors = command.get_SortDescriptors();
			SortDescriptor val = new SortDescriptor();
			val.set_Member("CreationDate");
			val.set_SortDirection(ListSortDirection.Descending);
			sortDescriptors.Add(val);
		}
		filter = CreateFilterForGrid(filter, searchTasksType);
		TaskGridModel taskGridModel = CreateGridData(command, filter, GridId, searchTasksType, UniqueName, callbackFunction);
		taskGridModel.CanExportToExcel = base.SecurityService.HasPermission(PermissionProvider.TasksExportPermission);
		taskGridModel.EnableCustomize = enableCustomize;
		return GridView(taskGridModel);
	}

	[CustomGridAction]
	public ActionResult SubTasksGrid(GridCommand command, long? parentTaskId)
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		if (parentTaskId.HasValue)
		{
			taskBaseFilter.ParentTask = base.Manager.Load(parentTaskId.Value);
			IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
			taskBaseFilter.DisableSecurity = taskBaseFilter.ParentTask != null && (taskBaseFilter.ParentTask.Executor == currentUser || taskBaseFilter.ParentTask.CreationAuthor == currentUser || UserManager.Instance.IsSubordinateUser(currentUser, taskBaseFilter.ParentTask.CreationAuthor));
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)CreateGridData(command, taskBaseFilter));
	}

	public ActionResult ChangeTableView(string gridId, bool isTable)
	{
		StateExtensions.SaveState("UserTaskTableView" + gridId, (bool?)isTable);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Request().UrlReferrer.ToString());
	}

	public override ActionResult FastFilterSave(string prefix, [Bind(Prefix = "DataFilter")] FilterModel model)
	{
		if (model != null && model.Entity != null)
		{
			((ControllerBase)this).get_ViewData().set_Item("Code", (object)model.Entity.Code);
		}
		return base.FastFilterSave(prefix, model);
	}

	protected override void InitEqlQuery(FilterModel model)
	{
		if (model != null && model.Entity != null)
		{
			((ControllerBase)this).get_ViewData().set_Item("Code", (object)model.Entity.Code);
			if (!EnableEqlQuery)
			{
				model.EnableEqlQuery = EnableEqlQuery;
				model.ReInit();
			}
		}
		base.InitEqlQuery(model);
	}

	protected TaskGridModel CreateGridData(GridCommand command, ITaskBaseFilter filter, string gridId, SearchTasksType searchTasksType, string uniqueName = null, string callbackFunction = "")
	{
		return CreateGridData(ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(filter.TypeUid ?? InterfaceActivator.UID<ITaskBase>())), command, filter, gridId, searchTasksType, uniqueName, callbackFunction);
	}

	protected TaskGridModel CreateGridData(IEntityManager manager, GridCommand command, ITaskBaseFilter filter, string gridId, SearchTasksType searchTasksType, string uniqueName = null, string callbackFunction = "")
	{
		return CreateGridData(null, manager, command, filter, gridId, searchTasksType, uniqueName, callbackFunction);
	}

	protected TaskGridModel CreateGridData(TaskGridModel gridData, IEntityManager manager, GridCommand command, ITaskBaseFilter filter, string gridId, SearchTasksType searchTasksType, string uniqueName = null, string callbackFunction = "")
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<ITaskBaseFilter>();
		}
		filter.NotShowInLists = false;
		if (gridData == null)
		{
			gridData = new TaskGridModel();
		}
		gridData.DataFilter = filter;
		gridData.Command = command;
		gridData.GridId = gridId ?? GridIdPrefix;
		gridData.SearchTasksType = searchTasksType;
		gridData.UniqueName = uniqueName;
		gridData.CallbackFunction = callbackFunction;
		gridData.SetCount((GridData<ITaskBase, ITaskBaseFilter> d, FetchOptions f) => manager.Count(d.DataFilter));
		gridData.SetDataSource(delegate(GridData<ITaskBase, ITaskBaseFilter> d, FetchOptions f)
		{
			IEnumerable source;
			if (d.Count <= 0)
			{
				IEnumerable enumerable = new List<ITaskBase>();
				source = enumerable;
			}
			else
			{
				source = manager.Find(d.DataFilter, f);
			}
			return source.Cast<ITaskBase>();
		});
		return gridData;
	}

	protected virtual bool IsControl()
	{
		return IsControl(Code);
	}

	protected virtual bool IsControl(Guid? code)
	{
		if (code.HasValue)
		{
			if (!(code.Value == TaskConstants.ExecutionControlThreadCodeUid))
			{
				return code.Value == TaskConstants.CurrentControlThreadCodeUid;
			}
			return true;
		}
		return false;
	}

	protected override GridDataFilter<ITaskBase> CreateGridData(GridCommand command, FilterModel filter)
	{
		return CreateGridData(command, filter, withNoData: false);
	}

	internal static SearchTasksType GetSearchTasksType(FilterModel filterModel)
	{
		return GetSearchTasksType(filterModel.Entity.Code);
	}

	private static SearchTasksType GetSearchTasksType(Guid? filterCode)
	{
		if (filterCode.HasValue && SearchTasksTypeCodes.TryGetValue(filterCode.Value, out var value))
		{
			return value;
		}
		return SearchTasksType.Search;
	}

	private GridDataFilter<ITaskBase> CreateGridData(GridCommand command, FilterModel filter, bool withNoData)
	{
		return CreateTasksGridData(command, filter, GetSearchTasksType(filter), FilterGridStateProvider.UID, withNoData, null);
	}

	private GridDataFilter<ITaskBase> CreateGridData(GridCommand command, FilterModel filter, SearchTasksType searchTasksType, bool withNoData)
	{
		return CreateTasksGridData(command, filter, searchTasksType, FilterGridStateProvider.UID, withNoData, null);
	}

	private TasksGridDataFilterModel CreateTasksGridData(GridCommand command, FilterModel filter, SearchTasksType searchTasksType, Guid gridStateProviderUid, bool withNoData, string uniquePrefix)
	{
		IEntityManager manager = GetManager(filter);
		if (EnableEqlQuery)
		{
			try
			{
				IEntityFilter filter2 = filter.Filter;
				manager.CheckFilter(filter2);
			}
			catch (NullReferenceException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (ADOException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (Exception exception)
			{
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
		}
		return new TasksGridDataFilterModel(command, filter, manager, searchTasksType, gridStateProviderUid, withNoData, uniquePrefix);
	}

	private IEntityManager GetManager(FilterModel filter)
	{
		Type filterType = ((filter != null && filter.Filter != null) ? filter.Filter.GetType() : null);
		IUniqueFilterExtension uniqueFilterExtension = ((filterType != null) ? base.UniqueFilterExtensions.FirstOrDefault((IUniqueFilterExtension e) => e.FilterType == filterType) : null);
		return ModelHelper.GetEntityManager((uniqueFilterExtension != null) ? uniqueFilterExtension.EntityType : ((filterType != null) ? MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filterType).Uid) : taskBaseType));
	}
}
