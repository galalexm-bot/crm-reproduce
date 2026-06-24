using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[WorkLogPermission]
public class WorkLogApproveReportController : FilterTreeBaseController<IWorkLogItem, long>
{
	protected const string WorkLogApproveFilterTempKey = "EleWise.ELMA.BPM.Web.Tasks.WorkLogApprove.Filter";

	private const string WorkLogModuleUid = "{741CEE5B-4B38-4895-B30A-7353C2B520D5}";

	private IUser CurrentUser => base.AuthenticationService.GetCurrentUser<IUser>();

	private static ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	protected IBLOBDataManager BLOBManager => DataAccessManager.BLOBManager;

	protected override bool EnableEqlQuery => false;

	protected override Guid? UniqueFilterUid => new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}");

	protected override string GridIdPrefix => "WorkLogApproveReportGrid";

	protected override Guid? Code => new Guid("{DE39923A-6F35-4890-B518-BB9A892C16C3}");

	protected override bool DisableColumnSettings => true;

	public WorkLogItemManager WorkLogItemManager { get; set; }

	public ActionResult WorkLogApproveGrid(WorkLogApproveGroupType? groupType, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? FilterId = null)
	{
		string key = string.Format("{0}_{1}", "EleWise.ELMA.BPM.Web.Tasks.WorkLogApprove.Filter", CurrentUser.Id);
		if (CacheService.TryGetValue<object>(key, out var value))
		{
			if (value != null)
			{
				if (filter == null)
				{
					filter = CreateNewFilter(FilterId);
				}
				IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)(filter.Filter = (IWorkLogItemSearchFilter)UniversalFilterSaver.UnPack(value));
			}
			CacheService.Remove(key);
		}
		WorkLogApproveModel workLogApproveModel = CreateWorkLogApproveModel(filter, groupType, FilterId);
		return (ActionResult)(object)((Controller)this).PartialView("WorkLogApproveGrid", (object)workLogApproveModel);
	}

	public ActionResult WorkLogPartialApprovePopup([JsonBinder] WorkLogApproveItemModel approveItems, string popupId = "")
	{
		int index = approveItems.PartialApproveIndex[0];
		string text = approveItems.Id[index].ToString();
		bool hideApproveButton = approveItems.WorkTime[index] == 0;
		for (int i = 1; i < approveItems.PartialApproveIndex.Count; i++)
		{
			index = approveItems.PartialApproveIndex[i];
			text = text + "," + approveItems.Id[index];
			if (approveItems.WorkTime[index] != 0L)
			{
				hideApproveButton = false;
			}
		}
		string ids = string.Join(",", approveItems.Id);
		string workTime = string.Join(",", approveItems.WorkTime);
		bool workTimeIsZero = approveItems.WorkTime.Contains(0L);
		WorkLogPartialApproveModel workLogPartialApproveModel = new WorkLogPartialApproveModel
		{
			Ids = ids,
			WorkTime = workTime,
			PartialIds = text,
			HideApproveButton = hideApproveButton,
			WorkTimeIsZero = workTimeIsZero,
			PopupId = popupId,
			HtmlPrefix = "DoWorkLogPartialApprove",
			PostAction = "DoWorkLogApprove",
			PostController = "WorkLogApproveReport",
			PostArea = "EleWise.ELMA.BPM.Web.Tasks",
			ShowAttachment = false
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/WorkLogPartialApprove", (object)workLogPartialApproveModel);
	}

	[CustomGridAction]
	public virtual ActionResult PartialApproveGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, long? FilterId = null, string gridId = null, string popupId = "", bool showDisplayName = true, string partialIds = "", string ids = "", string workTime = "")
	{
		if (filter == null)
		{
			filter = CreateFilter(FilterId);
			filter.GridIdPrefix = gridId ?? $"{GridIdPrefix}_{popupId}";
		}
		InitNewFilter(filter, null, null, null, partialIds);
		GridDataFilter<IWorkLogItem> gridDataFilter = new GridDataFilter<IWorkLogItem>
		{
			Command = command,
			DataFilter = filter
		};
		IEntityFilter entityFilter = gridDataFilter.DataFilter.Filter ?? InterfaceActivator.Create<IWorkLogObjectSearchFilter>();
		gridDataFilter.SetCount((GridData<IWorkLogItem> d, FetchOptions f) => WorkLogItemManager.LoadWorkLogItemCount((IWorkLogObjectSearchFilter)entityFilter));
		gridDataFilter.SetDataSource((GridData<IWorkLogItem> d, FetchOptions f) => (d.Count <= 0) ? new List<IWorkLogItem>() : WorkLogItemManager.LoadWorkLogItemList((IWorkLogObjectSearchFilter)entityFilter, f));
		PartialApproveGridModel partialApproveGridModel = new PartialApproveGridModel();
		partialApproveGridModel.GridData = gridDataFilter;
		partialApproveGridModel.ShowDisplayName = showDisplayName;
		partialApproveGridModel.Ids = ids.Split(',');
		partialApproveGridModel.WorkTime = workTime.Split(',');
		partialApproveGridModel.PartialIds = partialIds;
		partialApproveGridModel.PopupId = popupId;
		partialApproveGridModel.GridId = gridId;
		PartialApproveGridModel partialApproveGridModel2 = partialApproveGridModel;
		return (ActionResult)(object)((Controller)this).PartialView("Partial/PartialApproveGrid", (object)partialApproveGridModel2);
	}

	private static void InitNewFilter(FilterModel filter, Guid? objectUid, long? objectId, bool? all, string ids)
	{
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)filter.Filter;
		if (all.HasValue)
		{
			workLogItemSearchFilter.DisableSecurity = all.Value;
		}
		workLogItemSearchFilter.WorkLogItemObjectId = objectId;
		workLogItemSearchFilter.WorkLogItemObjectTypeUid = objectUid;
		workLogItemSearchFilter.Ids = (string.IsNullOrEmpty(ids) ? new List<long>() : (from id in ids.Split(",".ToCharArray())
			select Convert.ToInt64(id)).ToList());
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult DoWorkLogApprove([JsonBinder] WorkLogApproveItemModel workLogApprove, [Bind(Prefix = "DoWorkLogApprove")] CommentWithAttachments commentModel, [Bind(Prefix = "DoWorkLogPartialApprove")] CommentWithAttachments commentPartialModel, bool isPartialApprove = false)
	{
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		List<IWorkLogItem> list = new List<IWorkLogItem>();
		List<IWorkLogItem> list2 = new List<IWorkLogItem>();
		bool flag = WorkLogItemManager.CanAutoApproveMyWorklog();
		bool flag2 = false;
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.Status = WorkLogItemStatus.New;
		workLogItemFilter.Harmonizator = CurrentUser;
		workLogItemFilter.Query = ((!flag) ? ("CreationAuthor <> " + CurrentUser.Id) : null);
		foreach (IWorkLogItem item in WorkLogItemManager.FindByIdArray(workLogApprove.Id.ToArray(), workLogItemFilter, new FetchOptions(0, 0)
		{
			FetchRelations = new List<string>(new string[1] { InterfaceActivator.PropertyName((IWorkLogItem p) => p.CreationAuthor) })
		}))
		{
			WorkTime workTime = new WorkTime(workLogApprove.WorkTime[workLogApprove.Id.IndexOf(item.Id)]);
			if (workLogApprove.IsConfirm)
			{
				if (workTime != 0L)
				{
					WorkLogItemManager.ApprovalConfirm(item, workTime);
					list.Add(item);
				}
				else
				{
					WorkLogItemManager.ApprovalUnConfirm(item);
					list2.Add(item);
					flag2 = true;
				}
			}
			else if (workTime == 0L || !isPartialApprove)
			{
				WorkLogItemManager.ApprovalUnConfirm(item);
				list2.Add(item);
				if (workTime == 0L && isPartialApprove)
				{
					flag2 = true;
				}
			}
			else if (item.FactWorkTime == workTime)
			{
				WorkLogItemManager.ApprovalConfirm(item, workTime);
				list.Add(item);
			}
			else
			{
				Pair<IWorkLogItem, IWorkLogItem> pair = WorkLogItemManager.Divide(item, workTime);
				WorkLogItemManager.ApprovalConfirm(pair.First, workTime);
				WorkLogItemManager.ApprovalUnConfirm(pair.Second);
				list.Add(pair.First);
				list2.Add(pair.Second);
				flag2 = true;
			}
		}
		string key = string.Format("{0}_{1}", "EleWise.ELMA.BPM.Web.Tasks.WorkLogApprove.Filter", CurrentUser.Id);
		object value = UniversalFilterSaver.Pack(workLogApprove.DataFilter.Filter);
		CacheService.Insert(key, value, TimeSpan.FromMinutes(5.0));
		ICommentActionModel actionModel = ((commentModel != null) ? commentModel.ActionModel : commentPartialModel?.ActionModel);
		if (flag2)
		{
			WorkLogItemManager.AddApprovalComment(list, list2, WorkLogItemStatus.Confirm, actionModel);
		}
		else
		{
			WorkLogItemManager.AddApprovalComment(workLogApprove.IsConfirm ? list : list2, workLogApprove.IsConfirm ? WorkLogItemStatus.Confirm : WorkLogItemStatus.Unconfirm, actionModel);
		}
		return (ActionResult)new EmptyResult();
	}

	private WorkLogApproveModel CreateWorkLogApproveModel(FilterModel filter, WorkLogApproveGroupType? groupType = null, long? filterId = null)
	{
		filter.Filter.DisableSecurity = true;
		if (groupType.HasValue)
		{
			string workLogApproveKeyGroupMode = GetWorkLogApproveKeyGroupMode(filterId);
			BLOBManager.SetBLOB(new Guid("{741CEE5B-4B38-4895-B30A-7353C2B520D5}"), workLogApproveKeyGroupMode, groupType);
		}
		else
		{
			groupType = GetWorkLogApproveGroupType(filterId);
		}
		WorkLogApproveModel obj = new WorkLogApproveModel
		{
			GroupType = groupType.Value,
			DataFilter = filter
		};
		IWorkLogItemSearchFilter filter2 = (IWorkLogItemSearchFilter)filter.Filter;
		Dictionary<Pair<Guid, long>, bool> workLogItemList = new Dictionary<Pair<Guid, long>, bool>();
		List<IWorkLogItem> source = WorkLogItemManager.LoadWorkLogItemList(filter2, FetchOptions.All);
		obj.Items.AddRange(source.Select(delegate(IWorkLogItem i)
		{
			bool? flag = null;
			using (IEnumerator<Pair<Guid, long>> enumerator = workLogItemList.Keys.Where((Pair<Guid, long> key) => key.First == i.ObjectUID && key.Second == i.ObjectId).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					Pair<Guid, long> current = enumerator.Current;
					flag = workLogItemList[current];
				}
			}
			if (!flag.HasValue)
			{
				IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
				workLogItemFilter.ObjectId = new Int64Range
				{
					From = i.ObjectId,
					To = i.ObjectId
				};
				workLogItemFilter.ObjectUID = i.ObjectUID;
				workLogItemFilter.DisableSecurity = true;
				workLogItemFilter.Statuses = new List<WorkLogItemStatus>
				{
					WorkLogItemStatus.New,
					WorkLogItemStatus.Confirm
				};
				flag = WorkLogItemManager.Count(workLogItemFilter) > 1;
				workLogItemList.Add(new Pair<Guid, long>(i.ObjectUID, i.ObjectId), flag.Value);
			}
			return new WorkLogItemViewModel(i)
			{
				ApprovalWorkTime = (i.FactWorkTime.HasValue ? i.FactWorkTime.Value : new WorkTime(0)),
				HasWorkLogItem = flag.Value
			};
		}));
		return obj;
	}

	private WorkLogApproveGroupType GetWorkLogApproveGroupType(long? filterId = null)
	{
		string workLogApproveKeyGroupMode = GetWorkLogApproveKeyGroupMode(filterId);
		object bLOB = BLOBManager.GetBLOB<object>(new Guid("{741CEE5B-4B38-4895-B30A-7353C2B520D5}"), workLogApproveKeyGroupMode);
		if (bLOB != null)
		{
			return (WorkLogApproveGroupType)bLOB;
		}
		return WorkLogApproveGroupType.User;
	}

	private string GetWorkLogApproveKeyGroupMode(long? filterId)
	{
		return string.Format("{0}_{1}_f{2}", "WorkLogApprove.GroupType", CurrentUser.Id, filterId);
	}

	[ContentItem(Name = "SR.M('Согласование')", Image24 = "#complete_outline.svg")]
	[FilterMenuItem(Id = "workLogApprove-menu", CodeStr = "{DE39923A-6F35-4890-B518-BB9A892C16C3}", TypeUidStr = "{BB33273E-8224-4D28-82E6-E1C37F659828}", FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null, WorkLogApproveGroupType? groupType = null, string ids = null)
	{
		ActionResult val = BaseIndex(FilterId);
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateNewFilter(FilterId, ids);
		WorkLogApproveModel workLogApproveModel = CreateWorkLogApproveModel(filter, groupType, FilterId);
		return (ActionResult)(object)((Controller)this).View((object)workLogApproveModel);
	}

	private FilterModel CreateNewFilter(long? FilterId = null, string ids = null)
	{
		FilterModel filterModel = CreateFilter(FilterId);
		filterModel.GridIdPrefix = "WorkLogItemApproveIndexGrid";
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)filterModel.Filter;
		workLogItemSearchFilter.WorkLogItemHarmonizators = new List<IUser> { CurrentUser };
		workLogItemSearchFilter.WorkLogItemStatus = WorkLogItemStatus.New;
		if (!string.IsNullOrEmpty(ids))
		{
			try
			{
				workLogItemSearchFilter.Ids = (from m in ids.Split(",".ToCharArray())
					select Convert.ToInt64(m)).ToList();
				return filterModel;
			}
			catch
			{
				return filterModel;
			}
		}
		return filterModel;
	}
}
