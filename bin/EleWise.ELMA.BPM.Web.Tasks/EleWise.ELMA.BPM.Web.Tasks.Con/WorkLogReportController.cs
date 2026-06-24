using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Components.WorkLog;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[WorkLogPermission]
public class WorkLogReportController : FilterTreeBaseController<IWorkLogItem, long>
{
	public const string LastHistoryActionGridId = "LastHistoryActionGrid10";

	public const string LastWorkLogItemObjectGridId = "LastWorkLogItemObjectGrid";

	public const string ObjectGridId = "ObjectGrid10";

	private const int AddEmptyCount = 1;

	[NotNull]
	public IProductionCalendarService ProductionCalendarService { get; set; }

	public WorkLogManager WorkLogManager { get; set; }

	public WorkLogItemManager WorkLogItemManager { get; set; }

	protected IBLOBDataManager BLOBManager => DataAccessManager.BLOBManager;

	protected IUser CurrentUser => base.AuthenticationService.GetCurrentUser<IUser>();

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	protected override bool EnableEqlQuery => false;

	protected override Guid? UniqueFilterUid => new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}");

	protected override string GridIdPrefix => "WorkLogReportGrid";

	protected override Guid? Code => new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}");

	protected static int GetWeekDay(ICollection<int> weekDays, IWorkLog workLog)
	{
		return GetWeekDay(weekDays, workLog.StartDate);
	}

	protected static int GetWeekDay(ICollection<int> weekDays, DateTime? date)
	{
		int num = 1;
		if (date.HasValue)
		{
			num = WorkLogHelper.DayOfWeekNumber(date.Value);
			if (!weekDays.Contains(num))
			{
				num = weekDays.First();
			}
		}
		return num;
	}

	internal static Pair<int, WorkLogReportItem> GetWorkLogReportItem(ITaskBase taskBase, List<int> weekDays, List<IWorkLog> workLogs)
	{
		IWorkLog workLog = workLogs[0];
		int num = GetWeekDay(weekDays, workLog);
		StringBuilder stringBuilder = new StringBuilder("");
		List<long> list = new List<long>();
		WorkTime value = new WorkTime(0);
		foreach (IWorkLog workLog2 in workLogs)
		{
			list.Add(workLog2.Id);
			if (workLog2.WorkMinutes.HasValue)
			{
				value += workLog2.WorkMinutes.Value;
			}
			if (!workLog2.StartDate.HasValue && !workLog2.WorkMinutes.HasValue && string.IsNullOrEmpty(workLog2.Comment))
			{
				continue;
			}
			num = Math.Max(GetWeekDay(weekDays, workLog2), num);
			if (stringBuilder.Length != 0)
			{
				stringBuilder.Append("\r\n--------------------------------------------------\r\n");
			}
			if (workLog2.StartDate.HasValue)
			{
				string text = ((workLog2.StartDate.Value.Hour > 0 || workLog2.StartDate.Value.Minute > 0) ? "g" : "d");
				stringBuilder.Append(workLog2.StartDate.Value.ToString(text));
				if (workLog2.WorkMinutes.HasValue || !string.IsNullOrEmpty(workLog2.Comment))
				{
					stringBuilder.Append(" - ");
				}
			}
			if (workLog2.WorkMinutes.HasValue)
			{
				stringBuilder.Append(workLog2.WorkMinutes.ToString());
				if (!string.IsNullOrEmpty(workLog2.Comment))
				{
					stringBuilder.Append(" - ");
				}
			}
			if (!string.IsNullOrEmpty(workLog2.Comment))
			{
				stringBuilder.Append(workLog2.Comment);
			}
		}
		IWorkLogExtension workLogExtension = WorkLogExtensionHelper.FindExtensionByObjectUid(taskBase.TypeUid, enabled: true);
		if (workLogExtension == null)
		{
			return null;
		}
		WorkLogReportItem second = new WorkLogReportItem
		{
			Description = stringBuilder.ToString(),
			FactWorkTime = value,
			ObjectId = taskBase.Id,
			ObjectUid = taskBase.TypeUid,
			ExtensionUid = workLogExtension.Uid,
			Harmonizator = WorkLogExtensionHelper.DefaultHarmonizator(taskBase.TypeUid, taskBase.Id),
			WorkLogIdList = string.Join(",", list.Select((long v) => v.ToString(CultureInfo.InvariantCulture)).ToArray()),
			HasWorkLogItem = WorkLogItemManager.Instance.ForObjectExists(taskBase.TypeUid, taskBase.Id)
		};
		return new Pair<int, WorkLogReportItem>(num, second);
	}

	protected IWorkLogItemFilter GetWorkLogItemFilter(WorkLogItemGridParams parameters)
	{
		DateTime? dateStart = null;
		DateTime? dateEnd = null;
		if (parameters.Mode.HasValue)
		{
			DateTime today = DateTime.Today;
			switch (parameters.Mode.Value)
			{
			case WorkLogSummaryTableMode.CurrentWeek:
				dateStart = WorkLogHelper.StartDateOfWeek(today);
				dateEnd = today.AddDays(1.0).AddSeconds(-1.0);
				break;
			case WorkLogSummaryTableMode.LastWeek:
				dateStart = WorkLogHelper.StartDateOfWeek(today.AddDays(-7.0));
				dateEnd = WorkLogHelper.StartDateOfWeek(today).AddSeconds(-1.0);
				break;
			case WorkLogSummaryTableMode.CurrentMonth:
				dateStart = new DateTime(today.Year, today.Month, 1);
				dateEnd = today.AddDays(1.0).AddSeconds(-1.0);
				break;
			case WorkLogSummaryTableMode.LastMonth:
				dateStart = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
				dateEnd = new DateTime(today.Year, today.Month, 1).AddSeconds(-1.0);
				break;
			}
		}
		else
		{
			dateStart = parameters.DateFrom;
			dateEnd = parameters.DateTo;
		}
		List<IUser> users = (parameters.MyDepartment ? UserManager.Instance.GetSubordinateByUser(CurrentUser).ToList() : null);
		IWorkLogItemFilter workLogItemFilter = WorkLogItemManager.Instance.FilterForObject(users, parameters.Status, parameters.ActivityId, (parameters.ObjectUid == Guid.Empty) ? null : parameters.ObjectUid, parameters.ObjectId, dateStart, dateEnd, parameters.ShowDraft);
		workLogItemFilter.DisableSecurity = workLogItemFilter.DisableSecurity || parameters.DisableSecurity;
		workLogItemFilter.Ids = (string.IsNullOrEmpty(parameters.Ids) ? null : (from id in parameters.Ids.Split(',')
			select Convert.ToInt64(id)).ToList());
		if (!parameters.MyDepartment)
		{
			if (!workLogItemFilter.DisableSecurity && (!parameters.User.HasValue || parameters.User.Value != CurrentUser.Id))
			{
				parameters.User = CurrentUser.Id;
			}
			if (parameters.User.HasValue)
			{
				IUser user = UserManager.Instance.LoadOrNull(parameters.User.Value);
				workLogItemFilter.CreationAuthors.Add(user);
			}
		}
		workLogItemFilter.ObjectUids = new List<Guid>();
		foreach (List<Guid> item in from e in WorkLogExtensionHelper.ExtensionList()
			select e.EnabledObjectTypes())
		{
			workLogItemFilter.ObjectUids.AddRange(item);
		}
		return workLogItemFilter;
	}

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult TypeSettings()
	{
		((Controller)(object)this).SetCurrentMenuItem("tasks-admin-menu");
		TreeState treeState = TreePersonalizationAdministration.LoadState("WorkLogObjectTypeTree");
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = "WorkLogObjectTypeTree"
			};
			TreePersonalizationAdministration.SaveState("WorkLogObjectTypeTree", treeState);
		}
		TreeModel tree = new TreeModel
		{
			Id = "WorkLogObjectTypeTree",
			Children = BuildTree(WorkLogExtensionHelper.ExtensionList(), treeState, enabled: true),
			HtmlAttributes = new
			{
				style = "width:100%;",
				@class = "tree-padding"
			},
			ShowExpandCollapseButtons = true
		};
		return (ActionResult)(object)((Controller)this).View("TypeSettings", (object)new WorkLogTypeSettingsModel
		{
			Tree = tree
		});
	}

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult TypeAdd(string popupId)
	{
		TreeState treeState = TreePersonalizationAdministration.LoadState("WorkLogTypeTreeAdd");
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = "WorkLogTypeTreeAdd"
			};
			TreePersonalizationAdministration.SaveState("WorkLogTypeTreeAdd", treeState);
		}
		TreeModel tree = new TreeModel
		{
			Id = "WorkLogTypeTreeAdd",
			Children = BuildTree(from ext in WorkLogExtensionHelper.ExtensionList()
				where ext.BaseObjectUid != Guid.Empty
				select ext, treeState, enabled: false),
			HtmlAttributes = new
			{
				style = "width:100%; border: 0px solid #FFF;"
			},
			ShowExpandCollapseButtons = true,
			ShowCheckBox = true,
			HighlightPath = false
		};
		return (ActionResult)(object)((Controller)this).PartialView("TypeAddPopup", (object)new WorkLogTypeSettingsModel
		{
			Tree = tree,
			PopupId = popupId
		});
	}

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult TypeAddSave(List<Guid> checkedValues)
	{
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		if (checkedValues != null)
		{
			Dictionary<Guid, List<Guid>> dictionary = new Dictionary<Guid, List<Guid>>();
			List<IWorkLogExtension> source = WorkLogExtensionHelper.ExtensionList();
			foreach (Guid checkedValue in checkedValues)
			{
				IWorkLogExtension workLogExtension = WorkLogExtensionHelper.FindExtensionByObjectUid(checkedValue);
				if (workLogExtension != null)
				{
					if (!dictionary.ContainsKey(workLogExtension.Uid))
					{
						dictionary.Add(workLogExtension.Uid, new List<Guid>());
					}
					dictionary[workLogExtension.Uid].Add(checkedValue);
				}
			}
			foreach (Guid extensionUid in dictionary.Keys)
			{
				IWorkLogExtension extension = source.FirstOrDefault((IWorkLogExtension ext) => ext.Uid == extensionUid);
				WorkLogExtensionSettings settings = extension.LoadSettings();
				if (settings.EnabledObjectsUids == null)
				{
					settings.EnabledObjectsUids = new List<Guid>();
				}
				foreach (Guid item in dictionary[extensionUid].Where((Guid uid) => settings.EnabledObjectsUids.All((Guid u) => u != uid)))
				{
					settings.EnabledObjectsUids.Add(item);
				}
				extension.SaveSettings(settings);
			}
		}
		return (ActionResult)new EmptyResult();
	}

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult TypeSave(WorkLogTypeSettingsViewModel model)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		WorkLogExtensionHelper.FindExtensionByUid(model.Uid).SaveSettings(model.Settings);
		return (ActionResult)new EmptyResult();
	}

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult TypeDelete(Guid metadataUid)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		IWorkLogExtension workLogExtension = WorkLogExtensionHelper.FindExtensionByObjectUid(metadataUid);
		if (workLogExtension != null)
		{
			WorkLogExtensionSettings workLogExtensionSettings = workLogExtension.LoadSettings();
			if (workLogExtensionSettings.EnabledObjectsUids != null && workLogExtensionSettings.EnabledObjectsUids.Any((Guid u) => u == metadataUid))
			{
				workLogExtensionSettings.EnabledObjectsUids.Remove(metadataUid);
				workLogExtension.SaveSettings(workLogExtensionSettings);
			}
		}
		return (ActionResult)new EmptyResult();
	}

	private static List<TreeMenuNode> BuildTree(IEnumerable<IWorkLogExtension> extensions, TreeState treeState, bool enabled, Func<ClassMetadata, string> nameFormatter = null, Func<ClassMetadata, string> onClick = null)
	{
		List<Guid> list = new List<Guid>();
		foreach (IWorkLogExtension extension in extensions)
		{
			IWorkLogExtension ext = extension;
			IEnumerable<Guid> collection;
			if (!enabled)
			{
				collection = extension.ObjectUidList.Where((Guid u) => ext.EnabledObjectTypes().All((Guid u1) => u1 != u));
			}
			else
			{
				IEnumerable<Guid> enumerable = extension.EnabledObjectTypes();
				collection = enumerable;
			}
			list.AddRange(collection);
		}
		return EntityTreeHelper.BuildTree(list.Where((Guid u) => MetadataLoader.LoadMetadata(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(u)) is ClassMetadata classMetadata && classMetadata.ShowInTypeTree), treeState, enabled, nameFormatter, onClick);
	}

	public ActionResult Create(WorkLogCreateModel workLogCreateModel)
	{
		bool allWeeks = workLogCreateModel.allWeeks;
		DateTime? dateTime = workLogCreateModel.dayForWeek;
		if (allWeeks)
		{
			dateTime = DateTime.Now;
		}
		int num = 0;
		if (dateTime.HasValue)
		{
			num = WorkLogHelper.DayOfWeekNumber(dateTime.Value);
		}
		DateTime? dateEnd;
		DateTime? dateStart;
		if (allWeeks)
		{
			dateEnd = DateTime.Now;
			dateStart = new DateTime(dateEnd.Value.Year, dateEnd.Value.Month, 1).AddMonths(-1);
		}
		else if (dateTime.HasValue)
		{
			dateStart = dateTime.Value.Date.AddDays(-num);
			dateEnd = dateStart.Value.Date.AddDays(7.0);
		}
		else
		{
			dateStart = DateTime.Now.Date.AddDays(-WorkLogHelper.DayOfWeekNumber(DateTime.Now));
			dateEnd = dateStart.Value.Date.AddDays(7.0);
		}
		WorkLogSettings settings = WorkLogSettingsHelper.GetSettings();
		WorkLogReportModel model = new WorkLogReportModel
		{
			DayForWeek = (dateTime ?? DateTime.Now.Date),
			AllWeeks = allWeeks
		};
		Dictionary<ITaskBase, List<IWorkLog>> dictionary = (from g in WorkLogItemManager.Instance.GetWorkLogList(null, isNew: true, dateStart, dateEnd)
			group g by g.TaskBase).ToDictionary((IGrouping<ITaskBase, IWorkLog> k) => k.Key, (IGrouping<ITaskBase, IWorkLog> v) => v.OrderBy((IWorkLog g) => new DateTime(g.StartDate.Value.Year, g.StartDate.Value.Month, g.StartDate.Value.Day)).ToList());
		Action<ITaskBase, List<IWorkLog>> action = delegate(ITaskBase taskBase, List<IWorkLog> workLogList)
		{
			Pair<int, WorkLogReportItem> workLogReportItem2 = GetWorkLogReportItem(taskBase, model.WeekDays(), workLogList);
			if (workLogReportItem2 != null)
			{
				int num3 = ((settings.GroupTasks != GroupTasksType.Weeks) ? workLogReportItem2.First : 0);
				CreateDraftWorkLogItem(workLogReportItem2.Second, dateStart.Value.AddDays(num3));
			}
		};
		foreach (ITaskBase key in dictionary.Keys)
		{
			if (settings.GroupTasks == GroupTasksType.None)
			{
				foreach (IWorkLog item in dictionary[key])
				{
					action(key, new List<IWorkLog> { item });
				}
				continue;
			}
			Dictionary<DateTime, List<IWorkLog>> dictionary2 = dictionary[key].GroupBy(delegate(IWorkLog g)
			{
				if (settings.GroupTasks == GroupTasksType.Days)
				{
					DateTime dateTime2 = (g.StartDate.HasValue ? g.StartDate.Value : DateTime.Now);
					return new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day);
				}
				return dateStart.Value;
			}).ToDictionary((IGrouping<DateTime, IWorkLog> k) => k.Key, (IGrouping<DateTime, IWorkLog> v) => v.ToList());
			foreach (DateTime key2 in dictionary2.Keys)
			{
				action(key, dictionary2[key2]);
			}
		}
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.Date = new DateTimeRange(dateStart, dateEnd.Value.AddSeconds(-1.0));
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.ShowDraft = true;
		workLogItemFilter.Status = WorkLogItemStatus.Draft;
		workLogItemFilter.EmptyObjectUid = true;
		foreach (WorkLogItemModel item2 in WorkLogItemManager.LoadWorkLogItemModelList(workLogItemFilter))
		{
			IWorkLogItem workLogItem = item2.WorkLogItem;
			IEntity workLogObject = item2.WorkLogObject;
			IWorkLogExtension workLogExtension2;
			if (workLogItem == null || !(workLogItem.ObjectUID != Guid.Empty))
			{
				IWorkLogExtension workLogExtension = new EmptyEntityWorkLogExtension();
				workLogExtension2 = workLogExtension;
			}
			else
			{
				workLogExtension2 = WorkLogExtensionHelper.FindExtensionByObjectUid(workLogItem.ObjectUID, enabled: true);
			}
			IWorkLogExtension workLogExtension3 = workLogExtension2;
			int weekDay = GetWeekDay(model.WeekDays(), workLogItem.Date);
			IWorkLogFilter workLogFilter = InterfaceActivator.Create<IWorkLogFilter>();
			workLogFilter.WorkLogItem = workLogItem;
			List<long> source = (from workLog in WorkLogManager.Find(workLogFilter, null)
				select workLog.Id).ToList();
			WorkLogReportItem workLogReportItem = model.Day(weekDay).Items.FirstOrDefault((WorkLogReportItem m) => m.IsEmpty);
			workLogReportItem.Id = workLogItem.Id;
			workLogReportItem.Uid = workLogItem.Uid;
			workLogReportItem.Description = workLogItem.Comment;
			workLogReportItem.FactWorkTime = workLogItem.FactWorkTime;
			workLogReportItem.Harmonizator = workLogItem.Harmonizator;
			if (workLogExtension3 != null && workLogItem.ObjectId != 0L)
			{
				workLogReportItem.ObjectId = workLogItem.ObjectId;
				workLogReportItem.ObjectUid = workLogItem.ObjectUID;
				workLogReportItem.Object = workLogObject;
				workLogReportItem.ExtensionUid = workLogExtension3.Uid;
				workLogReportItem.WorkLogIdList = string.Join(",", source.Select((long id) => Convert.ToString(id)).ToArray());
				workLogReportItem.HasWorkLogItem = WorkLogItemManager.ForObjectExists(workLogItem.ObjectUID, workLogItem.ObjectId);
				workLogReportItem.Activity = workLogItem.WorkLogActivity;
				if (allWeeks)
				{
					workLogItem.Date = dateTime.Value.Date.AddDays(weekDay - num);
				}
				if (settings.DisableOvertime)
				{
					workLogReportItem.OvertimeDescriptions = WorkLogHelper.WorkLogItemDraftOvertime(workLogItem);
				}
			}
			if (allWeeks)
			{
				SaveDraft(new WorkLogItemDraftModel
				{
					Item = workLogReportItem,
					Date = workLogItem.Date
				});
			}
			int num2 = model.Day(weekDay).Items.Count((WorkLogReportItem i) => i.IsEmpty);
			if (num2 < 1)
			{
				model.FillEmptyItems(weekDay, 1 - num2);
			}
		}
		if (allWeeks)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Create");
		}
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[HttpGet]
	public ActionResult WorkLogSettingsPopup(string popup)
	{
		IUser currentUser = GetCurrentUser();
		WorkLogControlSettingsModel workLogControlSettingsModel = new WorkLogControlSettingsModel((currentUser != null) ? PersonalizationAdministration.LoadState<TaskControlSettingsModel>(currentUser.UserName, "UserTaskControlSettings") : null)
		{
			Popup = popup
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/WorkLogSettingsPopup", (object)workLogControlSettingsModel);
	}

	[HttpPost]
	public ActionResult WorkLogControlSettingsSave(WorkLogControlSettingsModel workLogControlSettingsModel)
	{
		IUser currentUser = GetCurrentUser();
		TaskControlSettingsModel taskControlSettingsModel = ((currentUser == null) ? null : PersonalizationAdministration.LoadState<TaskControlSettingsModel>(currentUser.UserName, "UserTaskControlSettings"));
		TaskControlSettingsModel taskControlSettingsModel2 = workLogControlSettingsModel.MergeSettings(taskControlSettingsModel);
		PersonalizationAdministration.SaveState(currentUser.UserName, "UserTaskControlSettings", taskControlSettingsModel2);
		if (taskControlSettingsModel2.AutomaticSendingOfWorkLog)
		{
			WorkLogManager.SaveAutoSaveWorkLogsUsers(currentUser);
		}
		else
		{
			WorkLogManager.RemoveAutoSaveWorkLogsUsers(currentUser);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Create");
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult ToApprov(List<long> selectedIds, bool onlySelected, DateTime? dayForWeek)
	{
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.Status = WorkLogItemStatus.Draft;
		workLogItemFilter.ShowDraft = true;
		workLogItemFilter.Ids = selectedIds;
		List<WorkLogItemModel> list = WorkLogItemManager.LoadWorkLogItemModelList(workLogItemFilter).ToList();
		if (!list.Any())
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Необходимо заполнить отчёт о трудозатратах")
			});
		}
		if (WorkLogSettingsHelper.GetSettings().DisableOvertime && WorkLogHelper.WorkLogItemDraftOvertime(list, selectedIds).Any((KeyValuePair<WorkLogItemModel, List<string>> pair) => pair.Value.Any()))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Недопустимые значения в трудозатратах")
			});
		}
		List<IWorkLogItem> workLogItemList = new List<IWorkLogItem>();
		DateTime dateTime = dayForWeek ?? DateTime.Now;
		if (dateTime == DateTime.MinValue)
		{
			dateTime = DateTime.Now;
		}
		DateTime startDateOfWeek = WorkLogHelper.StartDateOfWeek(dateTime);
		list.ForEach(delegate(WorkLogItemModel workLogItemModel)
		{
			IWorkLogItem workLogItem = workLogItemModel.WorkLogItem;
			if (workLogItem != null)
			{
				workLogItem.Date = startDateOfWeek.AddDays(WorkLogHelper.DayOfWeekNumber(workLogItem.Date));
				workLogItem.Status = WorkLogItemStatus.New;
				workLogItem.Save();
				if (workLogItem.Harmonizator.Id == CurrentUser.Id && WorkLogItemManager.CanAutoApproveMyWorklog())
				{
					WorkLogItemManager.ApprovalConfirm(workLogItem);
				}
				else
				{
					EntityActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(null, workLogItem, "2a7a7985-796f-4eac-a1aa-4d81234ac405"));
				}
				workLogItemList.Add(workLogItem);
			}
		});
		WorkLogItemManager.SendNotifications(workLogItemList);
		base.Notifier.Information(SR.T("Трудозатраты отправлены на согласование"));
		return (ActionResult)(object)((Controller)this).Json((object)new { });
	}

	public ActionResult CopyWeekPopup(string popupId, DateTime dayForWeek)
	{
		WorkLogCopyWeekModel workLogCopyWeekModel = CreateCopyWeekModel(dayForWeek);
		workLogCopyWeekModel.PopupId = popupId;
		return (ActionResult)(object)((Controller)this).PartialView("CopyWeekPopup", (object)workLogCopyWeekModel);
	}

	public ActionResult CopyWeekSave(WorkLogCopyWeekModel model)
	{
		if (!string.IsNullOrEmpty(model.Ids))
		{
			WorkLogItemManager.Instance.CopyForPreviousWeek(model.DayForWeek, (from m in model.Ids.Split(',')
				select Convert.ToInt64(m)).ToList());
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "WorkLogReport", (object)new
		{
			dayForWeek = model.DayForWeek.ToShortDateString()
		});
	}

	[HttpGet]
	public ActionResult CopyWeekPopupContent(DateTime dayForWeek, int week = 1)
	{
		WorkLogCopyWeekModel workLogCopyWeekModel = CreateCopyWeekModel(dayForWeek, week);
		return (ActionResult)(object)((Controller)this).PartialView("Partial/CopyWeekPopupContent", (object)workLogCopyWeekModel);
	}

	[CustomGridAction]
	public ActionResult CopyWeekPopupGrid(ICollection<IWorkLogItem> items, long dayIndex)
	{
		((ControllerBase)this).get_ViewData().set_Item("DayIndex", (object)dayIndex);
		GridData<IWorkLogItem> gridData = new GridData<IWorkLogItem>();
		gridData.SetCount((GridData<IWorkLogItem> d, FetchOptions f) => items.Count);
		gridData.SetData((IGridData d, FetchOptions f) => items.Count, (IGridData d, FetchOptions f) => items);
		return (ActionResult)(object)((Controller)this).PartialView("Partial/CopyWeekPopupGrid", (object)gridData);
	}

	public ActionResult CopyWeekWorkLogsGrid(DateTime dayForWeek, int weekPrevious)
	{
		WorkLogCopyWeekModel workLogCopyWeekModel = CreateCopyWeekModel(dayForWeek, weekPrevious);
		return (ActionResult)(object)((Controller)this).PartialView("ReplacementRulesGrid", (object)workLogCopyWeekModel);
	}

	private WorkLogCopyWeekModel CreateCopyWeekModel(DateTime dayForWeek, int weekPrevious = 0)
	{
		int num = 10;
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.ShowDraft = true;
		workLogItemFilter.Statuses = new List<WorkLogItemStatus>
		{
			WorkLogItemStatus.Draft,
			WorkLogItemStatus.New,
			WorkLogItemStatus.Confirm
		};
		workLogItemFilter.EmptyObjectUid = true;
		Func<int, int, Pair<DateTime, DateTime>> func = delegate(int s, int e)
		{
			DateTime first = dayForWeek.Date.AddDays(-WorkLogHelper.DayOfWeekNumber(dayForWeek) - 7 * s);
			DateTime second = first.Date.AddDays(7 * e).AddSeconds(-10.0);
			return new Pair<DateTime, DateTime>(first, second);
		};
		List<WorkLogsOfWeek> list = new List<WorkLogsOfWeek>();
		for (int i = 0; i < num; i++)
		{
			WorkLogsOfWeek workLogsOfWeek = new WorkLogsOfWeek();
			if (!list.Any())
			{
				workLogsOfWeek.StartDate = WorkLogHelper.StartDateOfWeek(dayForWeek).AddDays(-7.0);
			}
			else
			{
				workLogsOfWeek.StartDate = list[list.Count - 1].StartDate.AddDays(-7.0);
			}
			workLogsOfWeek.EndDate = workLogsOfWeek.StartDate.AddDays(6.0);
			list.Add(workLogsOfWeek);
		}
		Pair<DateTime, DateTime> pair = ((weekPrevious == 0) ? func(num, num) : func(weekPrevious, 1));
		workLogItemFilter.Date = new DateTimeRange(pair.First, pair.Second);
		List<IWorkLogItem> source = WorkLogItemManager.Instance.Find(workLogItemFilter, new FetchOptions
		{
			SortExpression = "Date",
			SortDirection = ListSortDirection.Descending
		}).ToList();
		foreach (WorkLogsOfWeek workLogWeek in list)
		{
			IEnumerable<IWorkLogItem> source2 = source.Where((IWorkLogItem m) => workLogWeek.StartDate <= m.Date && m.Date <= workLogWeek.EndDate);
			if (source2.Any())
			{
				workLogWeek.FactWorkTime = source2.Sum(delegate(IWorkLogItem m)
				{
					WorkTime? workTime = ((m.Status == WorkLogItemStatus.Confirm) ? m.ApprovalWorkTime : m.FactWorkTime) ?? new WorkTime?(new WorkTime(0));
					return (!workTime.HasValue) ? null : ((long?)workTime.GetValueOrDefault());
				});
			}
		}
		if (weekPrevious == 0 || !source.Any())
		{
			IWorkLogItem workLogItem = source.FirstOrDefault();
			weekPrevious = ((workLogItem == null) ? 1 : ((WorkLogHelper.StartDateOfWeek(dayForWeek) - WorkLogHelper.StartDateOfWeek(workLogItem.Date)).Days / 7));
		}
		DateTime dateStart = DateTime.Now;
		Dictionary<int, List<IWorkLogItem>> dictionary = new Dictionary<int, List<IWorkLogItem>>();
		if (weekPrevious != 0)
		{
			Pair<DateTime, DateTime> week = func(weekPrevious, 1);
			dateStart = week.First;
			dictionary = (from m in source
				where week.First <= m.Date && m.Date <= week.Second
				group m by WorkLogHelper.DayOfWeekNumber(m.Date)).ToDictionary((IGrouping<int, IWorkLogItem> m) => m.Key, (IGrouping<int, IWorkLogItem> m) => m.ToList());
		}
		for (int j = 0; j < 7; j++)
		{
			if (!dictionary.ContainsKey(j))
			{
				dictionary.Add(j, new List<IWorkLogItem>());
			}
		}
		return new WorkLogCopyWeekModel
		{
			DateStart = dateStart,
			DayForWeek = dayForWeek,
			WeekPrevious = weekPrevious,
			Items = dictionary,
			WorkLogWeeks = list
		};
	}

	private WorkLogSummaryTableGroup GetWorkLogSummaryTableGroupType(string keyPrefix)
	{
		string workLogSummaryTableGroupModeKey = GetWorkLogSummaryTableGroupModeKey(keyPrefix);
		object bLOB = BLOBManager.GetBLOB<object>(new Guid("{741CEE5B-4B38-4895-B30A-7353C2B520D5}"), workLogSummaryTableGroupModeKey);
		if (bLOB != null)
		{
			return (WorkLogSummaryTableGroup)bLOB;
		}
		return WorkLogSummaryTableGroup.Activity;
	}

	private string GetWorkLogSummaryTableGroupModeKey(string keyPrefix)
	{
		return string.Format("{0}_{1}_{2}", "WorkLogItemSummary.GroupType", keyPrefix, CurrentUser.Id);
	}

	public static IWorkLogObjectSearchFilter CreateWorkLogItemSearchFilter(WorkLogItemGridParams parameters = null)
	{
		IWorkLogObjectSearchFilter workLogObjectSearchFilter = InterfaceActivator.Create<IWorkLogObjectSearchFilter>();
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)workLogObjectSearchFilter;
		if (parameters == null)
		{
			IUser item = (IUser)Locator.GetService<IAuthenticationService>().GetCurrentUser();
			workLogItemSearchFilter.WorkLogItemAuthors.Add(item);
			return workLogObjectSearchFilter;
		}
		workLogItemSearchFilter.Ids = (string.IsNullOrEmpty(parameters.Ids) ? null : (from id in parameters.Ids.Split(',')
			select Convert.ToInt64(id)).ToList());
		workLogObjectSearchFilter.DisableSecurity = parameters.DisableSecurity;
		if (parameters.User.HasValue)
		{
			IUser user = UserManager.Instance.LoadOrNull(parameters.User.Value);
			if (user != null)
			{
				if (workLogItemSearchFilter.WorkLogItemAuthors == null)
				{
					workLogItemSearchFilter.WorkLogItemAuthors = new List<IUser>();
				}
				workLogItemSearchFilter.WorkLogItemAuthors.Add(user);
			}
		}
		workLogItemSearchFilter.WorkLogItemObjectId = parameters.ObjectId;
		workLogItemSearchFilter.WorkLogItemObjectTypeUid = parameters.ObjectUid;
		workLogItemSearchFilter.MyDepartment = parameters.MyDepartment;
		workLogItemSearchFilter.WorkLogItemDate = new RelativeDateTime(parameters.DateFrom, parameters.DateTo);
		if (parameters.Status.HasValue)
		{
			workLogItemSearchFilter.WorkLogItemStatus = parameters.Status;
		}
		if (parameters.ActivityId.HasValue)
		{
			List<IWorkLogActivity> list = new List<IWorkLogActivity>();
			list.Add(EntityManager<IWorkLogActivity>.Instance.LoadOrNull(parameters.ActivityId));
			workLogItemSearchFilter.WorkLogItemActivities = list;
		}
		IEnumerable<IWorkLogSummaryTableExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IWorkLogSummaryTableExtension>();
		if (extensionPoints != null)
		{
			foreach (IWorkLogSummaryTableExtension item2 in extensionPoints)
			{
				item2.SetFilter(workLogObjectSearchFilter, parameters);
			}
			return workLogObjectSearchFilter;
		}
		return workLogObjectSearchFilter;
	}

	private GridData<IEntity<long>, IWorkLogObjectSearchFilter> GetObjectGrid(GridCommand command, IWorkLogObjectSearchFilter filter)
	{
		FetchOptions fetchOptions = new FetchOptions
		{
			MaxResults = command.get_PageSize(),
			FirstResult = (command.get_Page() - 1) * command.get_PageSize(),
			SortDirection = command.get_SortDirection(),
			SortExpression = command.get_SortExpressionString()
		};
		int num = (int)WorkLogItemManager.Instance.LoadObjectCount(filter);
		List<IEntity<long>> dataSource = new List<IEntity<long>>();
		if (num > 0)
		{
			dataSource = WorkLogItemManager.Instance.LoadObjectList(filter, fetchOptions);
		}
		return new GridData<IEntity<long>, IWorkLogObjectSearchFilter>
		{
			DataFilter = filter,
			Command = command,
			Count = num,
			DataSource = dataSource
		};
	}

	private GridData<EntityLastActionInfo> GetLastEntityActionHistaryGrid(GridCommand command, DateTime dateTo, DateTime dateFrom)
	{
		FetchOptions fetchOptions = new FetchOptions
		{
			MaxResults = command.get_PageSize(),
			FirstResult = (command.get_Page() - 1) * command.get_PageSize(),
			SortDirection = command.get_SortDirection(),
			SortExpression = command.get_SortExpressionString()
		};
		List<Guid> actionObjectUids = WorkLogExtensionHelper.ObjectsUidEnabledList();
		return new GridData<EntityLastActionInfo>
		{
			Count = (int)EntityActionHistoryManager.Instance.LoadLastEntityActionHistaryCount(CurrentUser, dateFrom, dateTo, actionObjectUids),
			DataSource = EntityActionHistoryManager.Instance.LoadLastEntityActionHistaryList(CurrentUser, dateFrom, dateTo, actionObjectUids, fetchOptions),
			Command = command
		};
	}

	private GridData<EntityLastActionInfo> GetLastWorkLogItemObjectGrid(GridCommand command)
	{
		FetchOptions fetchOptions = new FetchOptions
		{
			MaxResults = command.get_PageSize(),
			FirstResult = (command.get_Page() - 1) * command.get_PageSize(),
			SortDirection = command.get_SortDirection(),
			SortExpression = command.get_SortExpressionString()
		};
		List<Guid> actionObjectUids = WorkLogExtensionHelper.ObjectsUidEnabledList();
		return new GridData<EntityLastActionInfo>
		{
			Count = (int)WorkLogItemManager.Instance.LoadLastWorkLogItemObjectCount(CurrentUser, actionObjectUids),
			DataSource = WorkLogItemManager.Instance.LoadLastWorkLogItemObjectList(CurrentUser, actionObjectUids, fetchOptions),
			Command = command
		};
	}

	public static string ConverStringToScriptValue(string value)
	{
		return (value ?? "").Replace("\\", "\\\\").Replace("'", "\\'").Replace("\"", "\\\"");
	}

	public ActionResult GetActivityList(string text = "")
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Expected O, but got Unknown
		IWorkLogActivityFilter workLogActivityFilter = InterfaceActivator.Create<IWorkLogActivityFilter>();
		workLogActivityFilter.SearchString = text;
		ICollection<IWorkLogActivity> source = EntityManager<IWorkLogActivity>.Instance.Find(workLogActivityFilter, FetchOptions.All);
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)source.Select((IWorkLogActivity p) => new
		{
			id = p.Id,
			text = p.Name
		}).ToList(), "id", "text"));
		return (ActionResult)val;
	}

	public ActionResult SelectWeekPopup(string popupId, string scriptSelect)
	{
		SelectWeekModel selectWeekModel = new SelectWeekModel
		{
			PopupId = popupId,
			ScriptSelect = scriptSelect
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)selectWeekModel);
	}

	public ActionResult FreeWorkLogReportTime(DateTime currentDate)
	{
		List<Guid> objectsUid = WorkLogExtensionHelper.ObjectsUidEnabledList();
		Dictionary<DateTime, WorkTime> dictionary = new Dictionary<DateTime, WorkTime>();
		if (currentDate == DateTime.MinValue)
		{
			currentDate = DateTime.Now;
		}
		DateTime dateTime = WorkLogHelper.StartDateOfWeek(currentDate);
		DateTime value = dateTime.AddDays(7.0);
		DateTime now = DateTime.Now;
		DateTime dateStart = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
		foreach (Dictionary<DateTime?, long> item in new List<Dictionary<DateTime?, long>>
		{
			WorkLogManager.Instance.GetWorkLogReportMinutes(objectsUid, dateStart, now),
			WorkLogItemManager.Instance.GetDraftReportMinutes(dateStart, now)
		})
		{
			foreach (DateTime? key2 in item.Keys)
			{
				if (!key2.HasValue)
				{
					continue;
				}
				DateTime? dateTime2 = key2;
				DateTime dateTime3 = dateTime;
				if (!dateTime2.HasValue || !(dateTime2.GetValueOrDefault() >= dateTime3) || !(key2 < value))
				{
					DateTime key = WorkLogHelper.StartDateOfWeek(key2.Value);
					if (!dictionary.ContainsKey(key))
					{
						dictionary.Add(key, new WorkTime(0));
					}
					dictionary[key] += (WorkTime)item[key2];
				}
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)dictionary);
	}

	public ActionResult FreeWorkLogReportTimeIgnore(DateTime dateIgnore, DateTime currentDate)
	{
		WorkLogItemManager.Instance.DraftForWeekIgnore(dateIgnore, deleteWorkLog: true);
		return (ActionResult)(object)((Controller)this).RedirectToAction("FreeWorkLogReportTime", new RouteValueDictionary { { "currentDate", currentDate } });
	}

	[HttpGet]
	public ActionResult MyWorkLogPortlet(MyWorkLogPortletPersonalization settings)
	{
		WorkLogItemGridParams workLogItemGridParams = new WorkLogItemGridParams
		{
			Mode = settings.Mode,
			SimpleSearch = true,
			User = CurrentUser.Id,
			GridId = settings.InstanceId.ToString().Replace("-", "")
		};
		((ControllerBase)this).get_ViewData().set_Item("PrefixId", (object)settings.InstanceId.ToString().Replace("-", ""));
		return (ActionResult)(object)((Controller)this).PartialView((object)workLogItemGridParams);
	}

	private WorkLogSummaryTableGroup GetWorkLogItemSummaryTableModel(string keyPrefix, WorkLogSummaryTableGroup? groupType = null)
	{
		if (string.IsNullOrEmpty(keyPrefix))
		{
			return groupType ?? WorkLogSummaryTableGroup.Activity;
		}
		WorkLogSummaryTableGroup workLogSummaryTableGroupType = GetWorkLogSummaryTableGroupType(keyPrefix);
		if (groupType.HasValue && groupType.Value != workLogSummaryTableGroupType)
		{
			string workLogSummaryTableGroupModeKey = GetWorkLogSummaryTableGroupModeKey(keyPrefix);
			BLOBManager.SetBLOB(new Guid("{741CEE5B-4B38-4895-B30A-7353C2B520D5}"), workLogSummaryTableGroupModeKey, groupType);
			return groupType.Value;
		}
		return workLogSummaryTableGroupType;
	}

	public ActionResult ObjectWorkLogItemListPopup(Guid? objectUid, long? objectId, string popupId, [Bind(Prefix = "Parameters")] WorkLogItemGridParams searchParam = null, bool? currentUser = null, string ids = null, bool showDisplayName = false, bool showSummaryTable = true, Guid? prefixLevel = null)
	{
		WorkLogItemFormParams formParams = new WorkLogItemFormParams
		{
			OpenOnPopup = true,
			CanChange = false,
			ShowDisplayName = showDisplayName,
			ShowSummaryTable = showSummaryTable
		};
		WorkLogItemGridParams workLogItemGridParams = new WorkLogItemGridParams();
		workLogItemGridParams = ((searchParam != null) ? searchParam : new WorkLogItemGridParams
		{
			ObjectId = objectId,
			ObjectUid = objectUid,
			User = ((currentUser.HasValue && currentUser.Value) ? new long?(CurrentUser.Id) : null),
			SimpleSearch = false,
			Ids = ids
		});
		FilterModel filterModel = CreateFilter();
		filterModel.GridIdPrefix = "WorkLogItemReportGridPopup";
		if (searchParam != null && !searchParam.SimpleSearch)
		{
			filterModel.Filter = CreateWorkLogItemSearchFilter(searchParam);
		}
		if (currentUser.HasValue && currentUser.Value)
		{
			((IWorkLogItemSearchFilter)filterModel.Filter).WorkLogItemAuthors = new List<IUser> { CurrentUser };
		}
		InitNewFilter(filterModel, objectUid, objectId, !currentUser.HasValue || !currentUser.Value, ids);
		GridDataFilter<IWorkLogItem> gridData = CreateGridData(null, filterModel);
		if (!prefixLevel.HasValue)
		{
			prefixLevel = Guid.NewGuid();
		}
		WorkLogItemIndexModel workLogItemIndexModel = new WorkLogItemIndexModel
		{
			FormParams = formParams,
			GridData = gridData,
			PopupId = (string.IsNullOrEmpty(popupId) ? "ObjectWorkLogItemListPopup" : popupId),
			Parameters = workLogItemGridParams,
			PrefixLevel = prefixLevel
		};
		((ControllerBase)this).get_ViewData().set_Item("objectUid", (object)objectUid);
		((ControllerBase)this).get_ViewData().set_Item("objectId", (object)objectId);
		((ControllerBase)this).get_ViewData().set_Item("all", (object)(!currentUser.HasValue || !currentUser.Value));
		((ControllerBase)this).get_ViewData().set_Item("ids", (object)ids);
		return (ActionResult)(object)((Controller)this).PartialView("WorkLogView", (object)workLogItemIndexModel);
	}

	public ActionResult SummaryTable([Bind(Prefix = "Parameters")] WorkLogItemGridParams parameters = null, string keyGroup = null, WorkLogSummaryTableGroup? group = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? filterId = null, bool enabledLink = false, string prefixId = "", string ids = null, string filterDataFunction = null, string filterDataFunctionParam = null, string summaryTableGuid = null)
	{
		WorkLogSummaryTableModel workLogSummaryTableModel = new WorkLogSummaryTableModel
		{
			Group = GetWorkLogItemSummaryTableModel(keyGroup, group),
			EnabledLink = enabledLink,
			PrefixId = prefixId,
			Parameters = parameters,
			FilterDataFunction = filterDataFunction,
			FilterDataFunctionParam = filterDataFunctionParam,
			FilterId = filterId,
			Ids = ids
		};
		if (filter == null && filterId.HasValue && filterId.Value > 0)
		{
			filter = CreateFilter(filterId);
		}
		List<IWorkLogItem> list = new List<IWorkLogItem>();
		if (parameters != null)
		{
			list = ((!parameters.SimpleSearch) ? WorkLogItemManager.Instance.LoadWorkLogItemList(CreateWorkLogItemSearchFilter(parameters)) : ((List<IWorkLogItem>)base.Manager.Find(GetWorkLogItemFilter(parameters), FetchOptions.All)));
		}
		else if (filter != null)
		{
			IWorkLogObjectSearchFilter workLogObjectSearchFilter = ((filter.Filter != null) ? ((IWorkLogObjectSearchFilter)filter.Filter) : CreateWorkLogItemSearchFilter());
			if (!string.IsNullOrEmpty(ids))
			{
				try
				{
					List<long> list2 = (from m in ids.Split(',')
						select Convert.ToInt64(m)).ToList();
					if (list2 != null && list2.Any())
					{
						((IWorkLogItemSearchFilter)workLogObjectSearchFilter).Ids = list2;
					}
				}
				catch
				{
				}
			}
			list = WorkLogItemManager.Instance.LoadWorkLogItemList(workLogObjectSearchFilter);
		}
		if (list.Count > 0)
		{
			switch (workLogSummaryTableModel.Group)
			{
			case WorkLogSummaryTableGroup.User:
			{
				IOrderedEnumerable<IGrouping<IUser, IWorkLogItem>> orderedEnumerable2 = from i in list
					group i by i.CreationAuthor into i
					orderby (i.Key == null) ? string.Empty : i.Key.FullName
					select i;
				workLogSummaryTableModel.Rows.AddRange(orderedEnumerable2.Select((IGrouping<IUser, IWorkLogItem> k) => new SummaryTableRow
				{
					Author = k.Key
				}));
				foreach (IGrouping<IUser, IWorkLogItem> activity in orderedEnumerable2)
				{
					SummaryTableRow summaryTableRow2 = workLogSummaryTableModel.Rows.FirstOrDefault((SummaryTableRow i) => i.Author == activity.Key);
					summaryTableRow2.WorkTime = new WorkTime(activity.Where((IWorkLogItem i) => i.Status == WorkLogItemStatus.New).Sum((IWorkLogItem i) => (!i.FactWorkTime.HasValue) ? 0 : i.FactWorkTime.Value.TotalMinutes));
					summaryTableRow2.ConfirmTime = new WorkTime(activity.Where((IWorkLogItem i) => i.Status == WorkLogItemStatus.Confirm).Sum((IWorkLogItem i) => (!i.ApprovalWorkTime.HasValue) ? 0 : i.ApprovalWorkTime.Value.TotalMinutes));
					summaryTableRow2.UnconfirmTime = new WorkTime(activity.Where((IWorkLogItem i) => i.Status == WorkLogItemStatus.Unconfirm).Sum((IWorkLogItem i) => (!i.FactWorkTime.HasValue) ? 0 : i.FactWorkTime.Value.TotalMinutes));
				}
				break;
			}
			case WorkLogSummaryTableGroup.Activity:
			{
				IOrderedEnumerable<IGrouping<IWorkLogActivity, IWorkLogItem>> orderedEnumerable = from i in list
					group i by i.WorkLogActivity into i
					orderby (i.Key == null) ? string.Empty : i.Key.Name
					select i;
				workLogSummaryTableModel.Rows.AddRange(orderedEnumerable.Select((IGrouping<IWorkLogActivity, IWorkLogItem> k) => new SummaryTableRow
				{
					Activity = k.Key
				}));
				foreach (IGrouping<IWorkLogActivity, IWorkLogItem> activity2 in orderedEnumerable)
				{
					SummaryTableRow summaryTableRow = workLogSummaryTableModel.Rows.FirstOrDefault((SummaryTableRow i) => i.Activity == activity2.Key);
					summaryTableRow.WorkTime = new WorkTime(activity2.Where((IWorkLogItem i) => i.Status == WorkLogItemStatus.New).Sum((IWorkLogItem i) => (!i.FactWorkTime.HasValue) ? 0 : i.FactWorkTime.Value.TotalMinutes));
					summaryTableRow.ConfirmTime = new WorkTime(activity2.Where((IWorkLogItem i) => i.Status == WorkLogItemStatus.Confirm).Sum((IWorkLogItem i) => (!i.ApprovalWorkTime.HasValue) ? 0 : i.ApprovalWorkTime.Value.TotalMinutes));
					summaryTableRow.UnconfirmTime = new WorkTime(activity2.Where((IWorkLogItem i) => i.Status == WorkLogItemStatus.Unconfirm).Sum((IWorkLogItem i) => (!i.FactWorkTime.HasValue) ? 0 : i.FactWorkTime.Value.TotalMinutes));
				}
				break;
			}
			}
		}
		((ControllerBase)this).get_ViewData().set_Model((object)workLogSummaryTableModel);
		if (!string.IsNullOrEmpty(summaryTableGuid))
		{
			HtmlCatchViewResult[] array = new HtmlCatchViewResult[1];
			HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
			((ViewResultBase)htmlCatchViewResult).set_ViewName("SummaryTable");
			((ViewResultBase)htmlCatchViewResult).set_ViewData(((ControllerBase)this).get_ViewData());
			((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
			array[0] = htmlCatchViewResult;
			return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)array, delegate(ControllerContext context, IEnumerable<ActionResult> results)
			{
				Dictionary<string, object> obj2 = new Dictionary<string, object>
				{
					["Html"] = ((HtmlCatchViewResult)(object)results.First()).HtmlResult,
					["SummaryTableGuid"] = summaryTableGuid
				};
				context.get_HttpContext().Response.ContentType = "application/json";
				context.get_HttpContext().Response.Output.Write(obj2.ToJson());
			})
			{
				ResultType = ActionResultType.Unknown
			};
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)workLogSummaryTableModel);
	}

	public ActionResult SummaryTableWorkLogItemPopup([Bind(Prefix = "Parameters")] WorkLogItemGridParams parameters, long entityId, int column, string popupId, WorkLogSummaryTableGroup group, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? filterId = null, string ids = null, Guid? prefixLevel = null)
	{
		if (filter == null && filterId.HasValue && filterId.Value > 0)
		{
			filter = CreateFilter(filterId);
		}
		List<IWorkLogItem> list = new List<IWorkLogItem>();
		List<long> list2 = null;
		if (parameters != null)
		{
			if (entityId > -1)
			{
				switch (group)
				{
				case WorkLogSummaryTableGroup.User:
					parameters.User = entityId;
					break;
				case WorkLogSummaryTableGroup.Activity:
					parameters.ActivityId = entityId;
					break;
				}
			}
			switch (column)
			{
			case 0:
				parameters.Status = WorkLogItemStatus.New;
				break;
			case 1:
				parameters.Status = WorkLogItemStatus.Confirm;
				break;
			case 2:
				parameters.Status = WorkLogItemStatus.Unconfirm;
				break;
			}
			if (parameters.SimpleSearch)
			{
				list = (List<IWorkLogItem>)base.Manager.Find(GetWorkLogItemFilter(parameters), FetchOptions.All);
				if (list.Count > 0)
				{
					list2 = list.Select((IWorkLogItem i) => i.Id).ToList();
				}
			}
		}
		else if (filter != null)
		{
			IWorkLogObjectSearchFilter workLogObjectSearchFilter = (filter.Filter as IWorkLogObjectSearchFilter) ?? CreateWorkLogItemSearchFilter();
			if (!string.IsNullOrEmpty(ids))
			{
				try
				{
					List<long> list3 = (from m in ids.Split(',')
						select Convert.ToInt64(m)).ToList();
					if (list3 != null && list3.Any())
					{
						((IWorkLogItemSearchFilter)workLogObjectSearchFilter).Ids = list3;
					}
				}
				catch
				{
				}
			}
			list = WorkLogItemManager.Instance.LoadWorkLogItemList(workLogObjectSearchFilter);
			if (list.Count > 0)
			{
				list2 = (from i in list
					where entityId == -1 || (@group == WorkLogSummaryTableGroup.Activity && i.WorkLogActivity != null && i.WorkLogActivity.Id == entityId) || (@group == WorkLogSummaryTableGroup.User && i.CreationAuthor.Id == entityId)
					where column == -1 || (i.Status == WorkLogItemStatus.New && column == 0) || (i.Status == WorkLogItemStatus.Confirm && column == 1) || (i.Status == WorkLogItemStatus.Unconfirm && column == 2)
					select i.Id).ToList();
			}
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		if (parameters != null)
		{
			routeValueDictionary = new RouteValueDictionary(parameters.ToRouteValueDictionary(toUrl: true));
		}
		if (list2 != null && list2.Count > 0)
		{
			routeValueDictionary.Add("ids", string.Join(",", list2));
		}
		routeValueDictionary.Add("area", "EleWise.ELMA.BPM.Web.Tasks");
		routeValueDictionary.Add("showDisplayName", true);
		routeValueDictionary.Add("showSummaryTable", false);
		return (ActionResult)(object)((Controller)this).RedirectToAction("ObjectWorkLogItemListPopup", "WorkLogReport", routeValueDictionary);
	}

	public ActionResult ObjectSearchPopup(string popupId, string scriptSelect, string scriptParameters, DateTime? date, WorkLogObjectSearchType searchType, WorkLogObjectSearchTabActive activeTab = WorkLogObjectSearchTabActive.History)
	{
		DateTime dateTime = DateTime.Today;
		DateTime dateFrom = default(DateTime);
		DateTime dateTime2 = dateTime;
		if (date.HasValue)
		{
			DateTime? dateTime3 = date;
			dateTime2 = dateTime3.Value;
		}
		switch (searchType)
		{
		case WorkLogObjectSearchType.Day:
			dateFrom = dateTime2;
			dateTime = dateTime2;
			break;
		case WorkLogObjectSearchType.TwoWeek:
			dateFrom = WorkLogHelper.StartDateOfWeek(dateTime).AddDays(-7.0);
			break;
		case WorkLogObjectSearchType.TwoMonth:
			dateFrom = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(-1);
			break;
		}
		bool flag = WorkLogItemManager.Instance.CanCreateWorkLogForObjectType(InterfaceActivator.UID<ITask>());
		if (!flag && activeTab == WorkLogObjectSearchTabActive.CreateTask)
		{
			activeTab = WorkLogObjectSearchTabActive.History;
		}
		WorkLogObjectSearchModel workLogObjectSearchModel = new WorkLogObjectSearchModel
		{
			PopupId = popupId,
			ScriptParameters = scriptParameters,
			ScriptSelect = scriptSelect,
			DateFrom = dateFrom,
			DateTo = dateTime,
			CurrentDate = dateTime2,
			SearchType = searchType,
			CanCreateTask = flag,
			ActiveTab = activeTab
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)workLogObjectSearchModel);
	}

	public ActionResult ObjectListInfo(Guid objectUid, long objectId, long dayIndex, long indexItem, long? harmonizatorId = null)
	{
		IUser harmonizator = null;
		if (harmonizatorId.HasValue)
		{
			harmonizator = UserManager.Instance.LoadOrNull(harmonizatorId.Value);
		}
		return GetObjectInfo(objectUid, objectId, dayIndex, indexItem, harmonizator);
	}

	public ActionResult WorkLogItemListInfo(long id, long dayIndex, long indexItem)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		IWorkLogItem workLogItem = WorkLogItemManager.Instance.LoadOrNull(id);
		if (workLogItem == null || workLogItem.Status != WorkLogItemStatus.Draft || workLogItem.CreationAuthor.Id != CurrentUser.Id)
		{
			return (ActionResult)new EmptyResult();
		}
		return GetObjectInfo(workLogItem.ObjectUID, workLogItem.ObjectId, dayIndex, indexItem, workLogItem.Harmonizator);
	}

	private ActionResult GetObjectInfo(Guid objectUid, long objectId, long dayIndex, long indexItem, IUser harmonizator = null)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		IWorkLogExtension workLogExtension = WorkLogExtensionHelper.FindExtensionByObjectUid(objectUid, enabled: true);
		if (workLogExtension != null)
		{
			IEntity entity = WorkLogExtensionHelper.LoadObject(objectId, objectUid);
			if (harmonizator == null && entity != null)
			{
				harmonizator = WorkLogExtensionHelper.DefaultHarmonizator(objectUid, objectId);
			}
			if (harmonizator == null)
			{
				harmonizator = CurrentUser;
			}
			WorkLogObjectInfoModel workLogObjectInfoModel = new WorkLogObjectInfoModel
			{
				Entity = entity,
				ExtensionUid = workLogExtension.Uid,
				DayIndex = dayIndex,
				IndexItem = indexItem,
				Harmonizator = harmonizator,
				ObjectUid = objectUid
			};
			return (ActionResult)(object)((Controller)this).PartialView("ObjectListInfo", (object)workLogObjectInfoModel);
		}
		return (ActionResult)new EmptyResult();
	}

	[CustomGridAction]
	public ActionResult LastHistoryActionGrid(GridCommand command, string dateTo, string dateFrom, string gridId = null, string selectScript = "")
	{
		if (string.IsNullOrEmpty(gridId))
		{
			gridId = "LastHistoryActionGrid10";
		}
		((ControllerBase)this).get_ViewData().set_Item("gridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("selectScript", (object)selectScript);
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId) ?? new GridState
		{
			CurrentPage = 1,
			PageSize = 10
		};
		if (command == null)
		{
			ListSortDirection listSortDirection = ListSortDirection.Descending;
			string arg = "ActionDate";
			if (!string.IsNullOrEmpty(gridState.SortExpression))
			{
				listSortDirection = gridState.SortDirection;
				arg = gridState.SortExpression;
			}
			command = GridCommand.Parse((gridState.CurrentPage - 1) * gridState.PageSize + 1, gridState.PageSize, string.Format("{0}-{1}", arg, (listSortDirection == ListSortDirection.Ascending) ? "" : "desc"), (string)null, (string)null);
		}
		GridPersonalizationAdministration.SaveState(gridId, gridState);
		string[] array = dateTo.Split('.');
		DateTime dateTo2 = new DateTime(Convert.ToInt32(array[2]), Convert.ToInt32(array[1]), Convert.ToInt32(array[0]));
		array = dateFrom.Split('.');
		DateTime dateFrom2 = new DateTime(Convert.ToInt32(array[2]), Convert.ToInt32(array[1]), Convert.ToInt32(array[0]));
		return (ActionResult)(object)((Controller)this).PartialView((object)GetLastEntityActionHistaryGrid(command, dateTo2, dateFrom2));
	}

	[CustomGridAction]
	public ActionResult LastWorkLogItemObjectGrid(GridCommand command, string gridId = null, string selectScript = "")
	{
		if (string.IsNullOrEmpty(gridId))
		{
			gridId = "LastWorkLogItemObjectGrid";
		}
		((ControllerBase)this).get_ViewData().set_Item("gridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("selectScript", (object)selectScript);
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId) ?? new GridState
		{
			CurrentPage = 1,
			PageSize = 10
		};
		if (command == null)
		{
			ListSortDirection listSortDirection = ListSortDirection.Descending;
			string arg = "CreationDate";
			if (!string.IsNullOrEmpty(gridState.SortExpression))
			{
				listSortDirection = gridState.SortDirection;
				arg = gridState.SortExpression;
			}
			command = GridCommand.Parse((gridState.CurrentPage - 1) * gridState.PageSize + 1, gridState.PageSize, string.Format("{0}-{1}", arg, (listSortDirection == ListSortDirection.Ascending) ? "" : "desc"), (string)null, (string)null);
		}
		GridPersonalizationAdministration.SaveState(gridId, gridState);
		return (ActionResult)(object)((Controller)this).PartialView((object)GetLastWorkLogItemObjectGrid(command));
	}

	public ActionResult HarmonizatorSelectPopup(string popupId, long userId, string scriptSelect, string scriptParam)
	{
		IUser user = UserManager.Instance.LoadOrNull(userId);
		return (ActionResult)(object)((Controller)this).PartialView("WorkLogReport/HarmonizatorSelectPopup", (object)new HarmonizatorSelectPopupModel
		{
			PopupId = popupId,
			User = user,
			ScriptSelect = scriptSelect,
			ScriptParam = scriptParam
		});
	}

	public ActionResult ActivitySelectPopup(string popupId, string scriptSelect, string scriptParam)
	{
		return (ActionResult)(object)((Controller)this).PartialView("WorkLogReport/ActivitySelectPopup", (object)new ActivitySelectPopupModel
		{
			PopupId = popupId,
			ScriptSelect = scriptSelect,
			ScriptParam = scriptParam
		});
	}

	public ActionResult GetObject(Guid objectUid, long objectId, DateTime? dateStart, DateTime? dateEnd, long? harmonizatorId = null)
	{
		WorkTime workTime = new WorkTime(0);
		string description = "";
		Guid extensionUid = Guid.Empty;
		string displayName = "";
		string workLogIdList = "";
		bool isWorkLogItemExists = false;
		string objectIcon = "";
		IWorkLogExtension workLogExtension = WorkLogExtensionHelper.FindExtensionByObjectUid(objectUid, enabled: true);
		if (workLogExtension != null)
		{
			extensionUid = workLogExtension.Uid;
			IEntity entity = WorkLogExtensionHelper.LoadObject(objectId, objectUid);
			objectIcon = ((Controller)this).get_Url().ObjectIcon(ObjectIconFormat.x16, entity);
			if (entity is ITaskBase taskBase)
			{
				displayName = taskBase.ToString();
				List<int> weekDays = (from wwd in ProductionCalendarService.GetGlobalProductionSchedule().GetWorkingWeekDays()
					select wwd.GetWorkTimeIntervalDayOfWeek()).ToList();
				DateTime? dateTime = dateStart;
				DateTime? dateTime2 = dateEnd;
				if (dateTime.HasValue && dateTime.Value != DateTime.MinValue && dateTime == dateTime2)
				{
					dateTime2 = dateTime2.Value.AddDays(1.0);
				}
				Dictionary<ITaskBase, List<IWorkLog>> dictionary = (from g in WorkLogItemManager.Instance.GetWorkLogList(taskBase, isNew: true, dateTime, dateTime2)
					group g by g.TaskBase).ToDictionary((IGrouping<ITaskBase, IWorkLog> k) => k.Key, (IGrouping<ITaskBase, IWorkLog> v) => v.OrderBy((IWorkLog g) => g.StartDate).ToList());
				if (dictionary.Count != 0)
				{
					Pair<int, WorkLogReportItem> workLogReportItem = GetWorkLogReportItem(taskBase, weekDays, dictionary[taskBase]);
					if (workLogReportItem.Second.FactWorkTime.HasValue)
					{
						workTime = workLogReportItem.Second.FactWorkTime.Value;
					}
					description = workLogReportItem.Second.Description;
					workLogIdList = workLogReportItem.Second.WorkLogIdList;
				}
				isWorkLogItemExists = WorkLogItemManager.Instance.ForObjectExists(objectUid, objectId);
			}
			if (!harmonizatorId.HasValue || harmonizatorId.Value == 0L)
			{
				harmonizatorId = WorkLogExtensionHelper.DefaultHarmonizator(objectUid, objectId)?.Id ?? CurrentUser.Id;
			}
		}
		if (harmonizatorId.HasValue && UserManager.Instance.LoadOrNull(harmonizatorId.Value) == null)
		{
			harmonizatorId = CurrentUser.Id;
		}
		object activityData = (from a in WorkLogActivityFilterProvider.AllowWorkLogActivity(objectUid)
			select new
			{
				Text = HttpUtility.HtmlEncode(a.Name),
				Value = a.Id.ToString()
			}).ToList();
		var anon = new
		{
			Hours = workTime.Value,
			Description = description,
			HarmonizatorId = ((!harmonizatorId.HasValue) ? CurrentUser.Id : harmonizatorId.Value),
			ExtensionUid = extensionUid,
			DisplayName = displayName,
			WorkLogIdList = workLogIdList,
			IsWorkLogItemExists = isWorkLogItemExists,
			ObjectIcon = objectIcon,
			Uid = Guid.NewGuid(),
			ActivityData = activityData
		};
		return (ActionResult)(object)((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
	}

	public ActionResult ObjectSearchTab(string selectScript = null)
	{
		ObjectSearchTabModel objectSearchTabModel = new ObjectSearchTabModel
		{
			ScriptSelect = selectScript
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/ObjectSearchTab", (object)objectSearchTabModel);
	}

	[CustomGridAction]
	public ActionResult ObjectGrid(GridCommand command, string gridId = null, string selectScript = null, DateTime? from = null, [Bind(Prefix = "DataFilter")] IWorkLogObjectSearchFilter filter = null)
	{
		if (string.IsNullOrEmpty(gridId))
		{
			gridId = "ObjectGrid10";
		}
		((ControllerBase)this).get_ViewData().set_Item("gridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("selectScript", (object)selectScript);
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId) ?? new GridState
		{
			CurrentPage = 1,
			PageSize = 10
		};
		if (command == null)
		{
			command = GridCommand.Parse((gridState.CurrentPage - 1) * gridState.PageSize + 1, gridState.PageSize, (string)null, (string)null, (string)null);
		}
		GridPersonalizationAdministration.SaveState(gridId, gridState);
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IWorkLogObjectSearchFilter>();
			filter.CreationDate = new RelativeDateTime(from, null);
		}
		GridData<IEntity<long>, IWorkLogObjectSearchFilter> objectGrid = GetObjectGrid(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView("ObjectGrid", (object)objectGrid);
	}

	[TransactionAction]
	public ActionResult SaveDraft(WorkLogItemDraftModel workLogItemDraftModel)
	{
		WorkLogReportItem item = workLogItemDraftModel.Item;
		DateTime? date = workLogItemDraftModel.Date;
		long id = 0L;
		string error = "";
		int? inputDescriptionMaxLength = WorkLogReportModel.InputDescriptionMaxLength;
		if (!date.HasValue)
		{
			error = SR.T("Не указана дата трудозатрат.");
		}
		else if (item.Description != null && item.Description.Length > inputDescriptionMaxLength)
		{
			error = SR.T("Размер описания не должен превышать {0} символов.", inputDescriptionMaxLength);
		}
		else
		{
			try
			{
				if (item.Activity != null && item.Activity.Id == 0L)
				{
					item.Activity = null;
				}
				if (item.Harmonizator != null && item.Harmonizator.Id == 0L)
				{
					item.Harmonizator = null;
				}
				id = CreateDraftWorkLogItem(item, date.Value).Id;
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { id, error });
	}

	private IWorkLogItem CreateDraftWorkLogItem(WorkLogReportItem item, DateTime date)
	{
		Func<IWorkLogItem> func = delegate
		{
			IWorkLogItem workLogItem2 = WorkLogItemManager.Instance.Create();
			workLogItem2.Status = WorkLogItemStatus.Draft;
			workLogItem2.CreationAuthor = CurrentUser;
			if (item.Uid.HasValue)
			{
				workLogItem2.Uid = item.Uid.Value;
			}
			return workLogItem2;
		};
		IWorkLogItem workLogItem = ((item.Id.HasValue && item.Id.Value > 0) ? (WorkLogItemManager.Instance.LoadOrNull(item.Id.Value) ?? func()) : ((!item.Uid.HasValue) ? func() : (WorkLogItemManager.Instance.LoadOrNull(item.Uid.Value) ?? func())));
		if (!workLogItem.IsNew() && !WorkLogItemManager.Instance.CanSaveDraft(workLogItem))
		{
			throw new Exception(SR.T("Нет прав на сохранение черновика трудозатрат"));
		}
		workLogItem.ObjectId = item.ObjectId;
		workLogItem.ObjectUID = item.ObjectUid;
		workLogItem.Harmonizator = item.Harmonizator;
		workLogItem.FactWorkTime = item.FactWorkTime;
		workLogItem.WorkLogActivity = item.Activity;
		workLogItem.Comment = item.Description;
		workLogItem.Date = date;
		WorkLogItemManager.Save(workLogItem);
		WorkLogManager.SetWorkLogLink(item.WorkLogIdList, workLogItem.Id, item.ObjectId);
		return workLogItem;
	}

	[TransactionAction]
	public ActionResult DeleteDraft(long id, Guid? uid)
	{
		Exception error;
		bool result = DeleteDraftWorkLogItem(id, uid, out error);
		string error2 = ((error != null) ? error.Message : "");
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = result,
			error = error2
		});
	}

	private bool DeleteDraftWorkLogItem(long id, Guid? uid, out Exception error)
	{
		bool result = false;
		error = null;
		IWorkLogItem workLogItem = WorkLogItemManager.Instance.LoadOrNull(id);
		if (workLogItem == null && uid.HasValue)
		{
			workLogItem = WorkLogItemManager.Instance.LoadOrNull(uid.Value);
		}
		if (workLogItem == null || workLogItem.CreationAuthor.Id != CurrentUser.Id || workLogItem.Status != WorkLogItemStatus.Draft)
		{
			return true;
		}
		try
		{
			IWorkLogFilter workLogFilter = InterfaceActivator.Create<IWorkLogFilter>();
			workLogFilter.WorkLogItem = workLogItem;
			if (!WorkLogManager.Instance.Find(workLogFilter, null).Any())
			{
				workLogItem.HardDelete = true;
			}
			workLogItem.Delete();
			result = true;
			return result;
		}
		catch (Exception ex)
		{
			Exception ex2 = (error = ex);
			return result;
		}
	}

	[ContentItem(Name = "SR.M('Отчёты')", Image24 = "#report.svg")]
	[FilterMenuItem(Id = "workLogReport-menu", CodeStr = "{12445703-C5A9-4946-AD1E-7E7B39E318D4}", TypeUidStr = "{BB33273E-8224-4D28-82E6-E1C37F659828}", FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null, string ids = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filterModel = CreateFilter(FilterId);
		filterModel.GridIdPrefix = "WorkLogItemIndexGrid";
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)filterModel.Filter;
		if (!string.IsNullOrEmpty(ids))
		{
			try
			{
				workLogItemSearchFilter.Ids = (from m in ids.Split(',')
					select Convert.ToInt64(m)).ToList();
			}
			catch
			{
			}
		}
		bool hideSearchResult = string.IsNullOrEmpty(ids) && (!FilterId.HasValue || FilterId.Value == 0);
		GridDataFilter<IWorkLogItem> gridData = CreateGridDataInnerLogic(null, filterModel, hideSearchResult);
		string text = $"Index{(FilterId.HasValue ? FilterId.Value : 0)}";
		WorkLogItemIndexModel workLogItemIndexModel = new WorkLogItemIndexModel
		{
			KeyPage = text,
			GridData = gridData,
			Group = GetWorkLogItemSummaryTableModel(text),
			FormParams = 
			{
				OpenOnPopup = false
			},
			HideSearchResult = hideSearchResult,
			PrefixLevel = null
		};
		workLogItemIndexModel.GridData.DataFilter.Entity.ExpandSearch = workLogItemIndexModel.GridData.DataFilter.Entity.ExpandSearch || workLogItemIndexModel.GridData.DataFilter.Entity.Id == 0;
		return (ActionResult)(object)((Controller)this).View((object)workLogItemIndexModel);
	}

	[TransactionAction]
	public ActionResult WorkLogGroupUpdate(List<string> workLogIds, long? harmonizatorId, long? activityId, DateTime? date)
	{
		bool result = false;
		if (workLogIds.Count > 0)
		{
			IEnumerable<Pair<long, Guid?>> source = workLogIds.Select(delegate(string v)
			{
				string[] array = v.Split(',');
				long first = Convert.ToInt64(array[0]);
				Guid? second = ((!string.IsNullOrEmpty(array[1])) ? new Guid?(Guid.Parse(array[1])) : null);
				return new Pair<long, Guid?>(first, second);
			});
			IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
			workLogItemFilter.Ids = source.Select((Pair<long, Guid?> v) => v.First).ToList();
			workLogItemFilter.ShowDraft = true;
			List<IWorkLogItem> workLogItems = WorkLogItemManager.Instance.Find(workLogItemFilter, null).ToList();
			workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
			workLogItemFilter.Uids = (from v in source
				select v.Second into v
				where v.HasValue
				select v.Value).ToList();
			workLogItemFilter.ShowDraft = true;
			workLogItems.AddRange(from w in WorkLogItemManager.Instance.Find(workLogItemFilter, null)
				where workLogItems.Any((IWorkLogItem w1) => w1.Id != w.Id)
				select w);
			if (workLogItems.Count > 0)
			{
				IUser user = UserManager.Instance.LoadOrNull(harmonizatorId.HasValue ? harmonizatorId.Value : 0);
				IWorkLogActivity workLogActivity = ModelHelper.GetEntityManager(typeof(IWorkLogActivity)).LoadOrNull(activityId.HasValue ? activityId.Value : 0) as IWorkLogActivity;
				DateTime? dateTime = date;
				foreach (IWorkLogItem item in workLogItems)
				{
					bool flag = false;
					if (user != null)
					{
						item.Harmonizator = user;
						flag = true;
					}
					if (workLogActivity != null)
					{
						item.WorkLogActivity = workLogActivity;
						flag = true;
					}
					if (dateTime.HasValue)
					{
						item.Date = dateTime.Value;
						flag = true;
					}
					if (flag)
					{
						result = true;
						item.Save();
					}
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { result });
	}

	[TransactionAction]
	public ActionResult WorkLogGroupDelete(List<string> workLogIds)
	{
		bool result = false;
		if (workLogIds.Count > 0)
		{
			foreach (string workLogId in workLogIds)
			{
				string[] array = workLogId.Split(',');
				int num = Convert.ToInt32(array[0]);
				Guid? uid = ((!string.IsNullOrEmpty(array[1])) ? new Guid?(Guid.Parse(array[1])) : null);
				if (DeleteDraftWorkLogItem(num, uid, out var _))
				{
					result = true;
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { result });
	}

	protected GridDataFilter<IWorkLogItem> CreateGridDataInnerLogic(GridCommand command, FilterModel filter, bool hideSearchResult = false)
	{
		WorkLogItemManager manager = WorkLogItemManager.Instance;
		GridDataFilter<IWorkLogItem> gridDataFilter = new GridDataFilter<IWorkLogItem>
		{
			Command = command,
			DataFilter = filter
		};
		IEntityFilter entityFilter = gridDataFilter.DataFilter.Filter ?? InterfaceActivator.Create<IWorkLogObjectSearchFilter>();
		if (!hideSearchResult)
		{
			gridDataFilter.SetCount((GridData<IWorkLogItem> d, FetchOptions f) => manager.LoadWorkLogItemCount((IWorkLogObjectSearchFilter)entityFilter));
			gridDataFilter.SetDataSource((GridData<IWorkLogItem> d, FetchOptions f) => (d.Count <= 0) ? new List<IWorkLogItem>() : manager.LoadWorkLogItemList((IWorkLogObjectSearchFilter)entityFilter, f));
		}
		return gridDataFilter;
	}

	protected override GridDataFilter<IWorkLogItem> CreateGridData(GridCommand command, FilterModel filter)
	{
		return CreateGridDataInnerLogic(command, filter);
	}

	[CustomGridAction]
	public virtual ActionResult WorkLogGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, [Bind(Prefix = "Parameters")] WorkLogItemGridParams parameters = null, long? FilterId = null, string gridId = null, string popupId = "", bool canChange = false, bool openOnPopup = false, bool showDisplayName = true, Guid? objectUid = null, long? objectId = null, bool? all = null, string ids = null, Guid? prefixLevel = null)
	{
		if (filter == null)
		{
			filter = CreateFilter(FilterId);
			filter.GridIdPrefix = string.Format("{0}_{1}", gridId ?? GridIdPrefix, prefixLevel.HasValue ? prefixLevel.Value.ToStringId() : "");
		}
		if (parameters != null && !parameters.SimpleSearch)
		{
			filter.Filter = CreateWorkLogItemSearchFilter(parameters);
		}
		InitNewFilter(filter, objectUid, objectId, all, ids);
		GridDataFilter<IWorkLogItem> gridData = CreateGridData(command, filter);
		((ControllerBase)this).get_ViewData().set_Item("popupId", (object)popupId);
		((ControllerBase)this).get_ViewData().set_Item("canChange", (object)canChange);
		((ControllerBase)this).get_ViewData().set_Item("openOnPopup", (object)openOnPopup);
		((ControllerBase)this).get_ViewData().set_Item("showDisplayName", (object)showDisplayName);
		((ControllerBase)this).get_ViewData().set_Item("objectUid", (object)objectUid);
		((ControllerBase)this).get_ViewData().set_Item("objectId", (object)objectId);
		((ControllerBase)this).get_ViewData().set_Item("all", (object)all);
		((ControllerBase)this).get_ViewData().set_Item("ids", (object)ids);
		((ControllerBase)this).get_ViewData().set_Item("prefixLevel", (object)prefixLevel);
		((ControllerBase)this).get_ViewData().set_Item("gridId", (object)gridId);
		return GridView("WorkLogGrid", gridData);
	}

	private static void InitNewFilter(FilterModel filter, Guid? objectUid, long? objectId, bool? all, string ids)
	{
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)filter.Filter;
		if (all.HasValue)
		{
			workLogItemSearchFilter.DisableSecurity = all.Value;
		}
		if (objectId.HasValue)
		{
			workLogItemSearchFilter.WorkLogItemObjectId = objectId;
		}
		if (objectUid.HasValue)
		{
			workLogItemSearchFilter.WorkLogItemObjectTypeUid = objectUid;
		}
		workLogItemSearchFilter.Ids = (string.IsNullOrEmpty(ids) ? new List<long>() : (from id in ids.Split(',')
			select Convert.ToInt64(id)).ToList());
	}

	public ActionResult OvertimeValidate(DateTime? dayForWeek, List<long> selectedIds)
	{
		List<WorkLogItemValidateInfo> validateInfo = new List<WorkLogItemValidateInfo>();
		if (!WorkLogSettingsHelper.GetSettings().DisableOvertime)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				ValidateInfo = validateInfo
			});
		}
		DateTime dateTime = dayForWeek ?? DateTime.Now;
		if (dateTime == DateTime.MinValue)
		{
			dateTime = DateTime.Now;
		}
		DateTime value = WorkLogHelper.StartDateOfWeek(dateTime);
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.DisableSecurity = false;
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.Status = WorkLogItemStatus.Draft;
		workLogItemFilter.ShowDraft = true;
		workLogItemFilter.Date = new DateTimeRange(value, value.AddDays(7.0).AddSeconds(-1.0));
		workLogItemFilter.EmptyObjectUid = true;
		if (selectedIds != null && selectedIds.Count > 0)
		{
			workLogItemFilter.Ids = selectedIds;
		}
		validateInfo = (from d in WorkLogHelper.WorkLogItemDraftOvertime(WorkLogItemManager.LoadWorkLogItemModelList(workLogItemFilter).ToList(), selectedIds)
			where d.Key.WorkLogItem != null
			select d into pair
			select new WorkLogItemValidateInfo
			{
				Id = pair.Key.WorkLogItem.Id,
				Descriptions = pair.Value
			}).ToList();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			ValidateInfo = validateInfo
		});
	}

	public ActionResult WorkLogTab(long taskId, bool showWorkLog, bool showSummaryTable)
	{
		ITaskBase taskBase = TaskBaseManager.Instance.Load(taskId);
		WorkLogItemGridParams workLogItemGridParams = new WorkLogItemGridParams
		{
			ObjectId = taskId,
			ObjectUid = taskBase.TypeUid,
			SimpleSearch = true,
			GridId = $"WorkLog_SummaryTable_{taskId}"
		};
		((ControllerBase)this).get_ViewData().set_Item("objectId", (object)taskId);
		((ControllerBase)this).get_ViewData().set_Item("showWorkLog", (object)showWorkLog);
		((ControllerBase)this).get_ViewData().set_Item("showSummaryTable", (object)showSummaryTable);
		return (ActionResult)(object)((Controller)this).PartialView("WorkLogReport/WorkLogTab", (object)workLogItemGridParams);
	}
}
