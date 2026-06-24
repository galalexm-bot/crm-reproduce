using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components.WorkLog;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

public static class WorkLogHelper
{
	private static ISessionProvider sessionProvider;

	private static ITransformationProvider transformationProvider;

	private static ISessionProvider SessionProvider => sessionProvider ?? (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());

	private static ITransformationProvider TransformationProvider => transformationProvider ?? (transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>());

	public static DateTime StartDateOfWeek()
	{
		return StartDateOfWeek(DateTime.Now);
	}

	public static DateTime StartDateOfWeek(DateTime date)
	{
		return date.Date.AddDays(0 - date.Date.DayOfWeek + 1);
	}

	public static int DayOfWeekNumber(DateTime date)
	{
		return (int)(date.DayOfWeek + 6) % 7;
	}

	public static WorkTime? PlanWorkLog(IWorkLogItem workLogItem)
	{
		if (workLogItem != null)
		{
			return PlanWorkLog(workLogItem.ObjectUID, workLogItem.ObjectId);
		}
		return null;
	}

	public static WorkTime? PlanWorkLog(Guid objectUid, long objectId)
	{
		if (objectId == 0L)
		{
			return null;
		}
		return PlanWorkLog(WorkLogExtensionHelper.LoadObject(objectId, objectUid));
	}

	public static WorkTime? PlanWorkLog(IEntity obj)
	{
		if (obj == null)
		{
			return null;
		}
		return WorkLogExtensionHelper.FindExtensionByObjectUid(InterfaceActivator.UID(obj.GetType()))?.PlanWorkLog(obj);
	}

	public static List<string> WorkLogItemDraftOvertime(long workLogItemId)
	{
		return WorkLogItemDraftOvertime(workLogItemId, includeDraft: true);
	}

	public static List<string> WorkLogItemDraftOvertime(long workLogItemId, bool includeDraft)
	{
		return WorkLogItemDraftOvertime(WorkLogItemManager.Instance.LoadOrNull(workLogItemId), includeDraft);
	}

	public static List<string> WorkLogItemDraftOvertime(IWorkLogItem workLogItem, List<long> selectedIds = null)
	{
		return WorkLogItemDraftOvertime(workLogItem, includeDraft: true);
	}

	public static List<string> WorkLogItemDraftOvertime(IWorkLogItem workLogItem, bool includeDraft, List<long> selectedIds = null)
	{
		IEntity workLogObject = ((workLogItem != null) ? WorkLogExtensionHelper.LoadObject(workLogItem.ObjectId, workLogItem.ObjectUID) : null);
		WorkLogItemModel workLogItemModel = new WorkLogItemModel
		{
			WorkLogItem = workLogItem,
			WorkLogObject = workLogObject
		};
		return WorkLogItemDraftOvertime(new List<WorkLogItemModel> { workLogItemModel }, includeDraft, selectedIds)[workLogItemModel];
	}

	public static Dictionary<WorkLogItemModel, List<string>> WorkLogItemDraftOvertime(List<WorkLogItemModel> workLogItemModels, List<long> selectedIds = null)
	{
		return WorkLogItemDraftOvertime(workLogItemModels, includeDraft: true, selectedIds);
	}

	public static Dictionary<WorkLogItemModel, List<string>> IsWorkLogItemDraftOvertime(List<WorkLogItemModel> workLogItemModels, List<long> selectedIds = null)
	{
		return WorkLogItemDraftOvertime(workLogItemModels, includeDraft: true, selectedIds, isAutomaticSend: true);
	}

	public static Dictionary<WorkLogItemModel, List<string>> WorkLogItemDraftOvertime(List<WorkLogItemModel> workLogItemModels, bool includeDraft, List<long> selectedIds = null, bool isAutomaticSend = false)
	{
		Dictionary<WorkLogItemModel, List<string>> result = new Dictionary<WorkLogItemModel, List<string>>();
		EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)Locator.GetService<IAuthenticationService>().GetCurrentUser();
		if (isAutomaticSend)
		{
			user = workLogItemModels.FirstOrDefault().WorkLogItem.CreationAuthor;
		}
		foreach (WorkLogItemModel workLogItemModel in workLogItemModels)
		{
			List<string> list = new List<string>();
			IWorkLogItem workLogItem = workLogItemModel.WorkLogItem;
			IEntity workLogObject = workLogItemModel.WorkLogObject;
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
			if (workLogExtension2 == null || workLogItem == null)
			{
				result[workLogItemModel] = list;
			}
			else
			{
				if (result.ContainsKey(workLogItemModel))
				{
					continue;
				}
				WorkTime workTime = new WorkTime(0);
				WorkTime workTime2 = new WorkTime(0);
				bool flag = false;
				bool flag2 = false;
				WorkTime? workTime3 = PlanWorkLog(workLogObject);
				IEnumerable<long> idList = new List<long>();
				List<long> excludeIds = null;
				if (workTime3.HasValue && workTime3.Value > 0L)
				{
					foreach (IWorkLogTaskOverallOverflow item in from e in ComponentManager.Current.GetExtensionPoints<IWorkLogTaskOverallOverflow>()
						where e.CheckType(workLogObject)
						select e)
					{
						ICollection<long> id = item.GetId(workLogObject);
						if (id != null)
						{
							idList = idList.Concat(id);
						}
					}
					if (idList.Any())
					{
						flag2 = true;
						IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
						workLogItemFilter.ObjectUID = workLogItem.ObjectUID;
						workLogItemFilter.ObjectIds = idList.ToList();
						workLogItemFilter.CreationAuthors.Add(workLogItem.CreationAuthor);
						workLogItemFilter.Statuses = new List<WorkLogItemStatus>
						{
							WorkLogItemStatus.Draft,
							WorkLogItemStatus.New,
							WorkLogItemStatus.Confirm
						};
						workLogItemFilter.ShowDraft = true;
						workLogItemFilter.DisableSecurity = true;
						workTime2 = WorkLogItemManager.Instance.GetFactWorkLog(workLogItem.ObjectId, workLogItem.ObjectUID, workLogItemFilter);
						if (selectedIds != null && selectedIds.Count > 0)
						{
							workLogItemFilter.Ids = selectedIds;
						}
						DateTime value = StartDateOfWeek(workLogItem?.Date ?? DateTime.Now);
						workLogItemFilter.Date = new DateTimeRange(value, value.AddDays(7.0).AddSeconds(-1.0));
						workLogItemFilter.Statuses = null;
						workLogItemFilter.Status = WorkLogItemStatus.Draft;
						workTime = WorkLogItemManager.Instance.GetFactWorkLog(workLogItem.ObjectId, workLogItem.ObjectUID, workLogItemFilter);
					}
					else
					{
						if (user != null && workLogItem.CreationAuthor != null && workLogItem.CreationAuthor.Id == user.Id)
						{
							if (workLogItem.Status == WorkLogItemStatus.Draft)
							{
								DateTime value2 = StartDateOfWeek(workLogItem.Date);
								DateTimeRange date = new DateTimeRange(value2, value2.AddDays(7.0).AddSeconds(-1.0));
								workTime = WorkLogItemManager.Instance.GetFactDraftWorkLog(workLogItem.ObjectId, workLogItem.ObjectUID, date, selectedIds);
							}
							else if (workLogItem.Status == WorkLogItemStatus.New)
							{
								workTime = workLogItem.FactWorkTime.Value.Value;
								excludeIds = new List<long> { workLogItem.Id };
							}
						}
						workTime2 = WorkLogItemManager.Instance.GetFactWorkLogAll(workLogItem.ObjectId, workLogItem.ObjectUID, excludeIds) + workTime;
					}
					flag = workTime3 < workTime2;
				}
				if (flag)
				{
					string text = SR.T("Превышение планового лимита времени по объекту трудозатрат.");
					if (workLogItem.Status == WorkLogItemStatus.Draft || workLogItem.Status == WorkLogItemStatus.New)
					{
						WorkTime? workTime4 = workTime3 - (workTime2 - workTime);
						if (workTime4 > 0L)
						{
							string text2 = text;
							object[] array = new object[1];
							WorkTime? workTime5 = workTime4;
							array[0] = new WorkTime(workTime5.HasValue ? ((long?)workTime5.GetValueOrDefault()) : null).ToShortFormat();
							text = text2 + " " + SR.T("Доступно не более {0}", array);
						}
					}
					list.Add(text);
				}
				result[workLogItemModel] = list;
				if (!flag2)
				{
					continue;
				}
				foreach (WorkLogItemModel item2 in workLogItemModels.Where((WorkLogItemModel item) => idList.Contains(item.WorkLogItem.ObjectId)))
				{
					if (!result.ContainsKey(item2))
					{
						result[item2] = list;
					}
				}
			}
		}
		FullOvertimeDescriptions(workLogItemModels, selectedIds, includeDraft).ForEach(delegate(KeyValuePair<WorkLogItemModel, List<string>> pair)
		{
			result[pair.Key].AddRange(pair.Value);
		});
		return result;
	}

	public static IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByAllKindId(string userIds, string groupIds, string orgItemIds)
	{
		return ((IQuery)SessionProvider.GetSession(string.Empty).CreateSQLQuery(string.Format("select {2}.* from {0} join {1} on {2}.{4} = {3}.{5} where {3}.{5} in ({8}) or {3}.{6} in ({9}) or {3}.{7} in ({10})", TransformationProvider.NoLockTableExpression("User", "u"), TransformationProvider.NoLockTableExpression("UserSecuritySetCache", "ussc"), "u", "ussc", TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("UserId"), TransformationProvider.Dialect.QuoteIfNeeded("GroupId"), TransformationProvider.Dialect.QuoteIfNeeded("OrgItemId"), string.IsNullOrEmpty(userIds) ? "0" : userIds, string.IsNullOrEmpty(groupIds) ? "0" : groupIds, string.IsNullOrEmpty(orgItemIds) ? "0" : orgItemIds)).AddEntity(InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>())).List<EleWise.ELMA.Security.Models.IUser>().Distinct();
	}

	public static IEnumerable<AssignedRoleTypeModel> GetAssignedRoleTypeModelsById(string userIds, string groupIds, string orgItemIds)
	{
		if (string.IsNullOrEmpty(userIds) && string.IsNullOrEmpty(groupIds) && string.IsNullOrEmpty(orgItemIds))
		{
			return Enumerable.Empty<AssignedRoleTypeModel>();
		}
		List<AssignedRoleTypeModel> list = new List<AssignedRoleTypeModel>();
		ISession session = SessionProvider.GetSession(string.Empty);
		IList<EleWise.ELMA.Security.Models.IUser> source = session.CreateCriteria(InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>()).Add((ICriterion)(object)Restrictions.In("Id", (ICollection)(from i in userIds.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
			select Convert.ToInt64(i)).ToArray())).List<EleWise.ELMA.Security.Models.IUser>();
		IList<IUserGroup> source2 = session.CreateCriteria(InterfaceActivator.TypeOf<IUserGroup>()).Add((ICriterion)(object)Restrictions.In("Id", (ICollection)(from i in groupIds.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
			select Convert.ToInt64(i)).ToArray())).List<IUserGroup>();
		IList<IOrganizationItem> source3 = session.CreateCriteria(InterfaceActivator.TypeOf<IOrganizationItem>()).Add((ICriterion)(object)Restrictions.In("Id", (ICollection)(from i in orgItemIds.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
			select Convert.ToInt64(i)).ToArray())).List<IOrganizationItem>();
		list.AddRange(source.Select((EleWise.ELMA.Security.Models.IUser u) => new AssignedRoleTypeModel(CommonRoleTypes.User, u)));
		list.AddRange(source2.Select((IUserGroup g) => new AssignedRoleTypeModel(CommonRoleTypes.Group, g)));
		list.AddRange(source3.Select((IOrganizationItem o) => new AssignedRoleTypeModel(CommonRoleTypes.OrganizationItem, o)));
		return list;
	}

	private static Dictionary<WorkLogItemModel, List<string>> FullOvertimeDescriptions(List<WorkLogItemModel> workLogItemModels, List<long> selected = null, bool includeDraft = true)
	{
		Dictionary<WorkLogItemModel, List<string>> result = new Dictionary<WorkLogItemModel, List<string>>();
		IEnumerable<IOvertimeWorkLogExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IOvertimeWorkLogExtension>();
		if (extensionPoints.Any())
		{
			foreach (WorkLogItemModel workLogItemModel in workLogItemModels)
			{
				List<string> list = new List<string>();
				IEnumerable<IOvertimeWorkLogExtension> source = extensionPoints.Where((IOvertimeWorkLogExtension e) => e.EnableExtension(workLogItemModel.WorkLogObject));
				list.AddRange(from extension in source
					select extension.FullOvertimeWorkLogDescription(workLogItemModel.WorkLogItem, selected) into info
					where info != null
					select info);
				result[workLogItemModel] = list;
			}
		}
		ComponentManager.Current.GetExtensionPoints<IOvertimeWorkLogExtension2>().ForEach(delegate(IOvertimeWorkLogExtension2 ex)
		{
			List<WorkLogItemModel> workLogItemModels3 = ex.SupportedModels(workLogItemModels).ToList();
			ex.OvertimeDescriptionMap(workLogItemModels3, selected).ToList().ForEach(delegate(KeyValuePair<WorkLogItemModel, string> pair)
			{
				CheckOvertimeExtensionResult(pair, result);
			});
		});
		foreach (IOvertimeWorkLogWithDraftsExtension extensionPoint in ComponentManager.Current.GetExtensionPoints<IOvertimeWorkLogWithDraftsExtension>())
		{
			List<WorkLogItemModel> workLogItemModels2 = extensionPoint.SupportedModels(workLogItemModels).ToList();
			extensionPoint.OvertimeDescriptionMap(workLogItemModels2, selected, includeDraft).ForEach(delegate(KeyValuePair<WorkLogItemModel, string> pair)
			{
				CheckOvertimeExtensionResult(pair, result);
			});
		}
		return result;
	}

	private static void CheckOvertimeExtensionResult(KeyValuePair<WorkLogItemModel, string> pair, Dictionary<WorkLogItemModel, List<string>> result)
	{
		if (pair.Key != null && pair.Value != null)
		{
			if (result.TryGetValue(pair.Key, out var value))
			{
				value.Add(pair.Value);
				return;
			}
			result[pair.Key] = new List<string> { pair.Value };
		}
	}

	public static bool WorkLogItemOvertime(IWorkLogItem workLogItem)
	{
		WorkTime? workTime = PlanWorkLog(workLogItem.ObjectUID, workLogItem.ObjectId);
		WorkTime factWorkLogAll = WorkLogItemManager.Instance.GetFactWorkLogAll(workLogItem);
		if (workTime.HasValue && workTime.Value > 0L)
		{
			return workTime < factWorkLogAll;
		}
		return false;
	}

	[Obsolete]
	public static bool CanShowPropertyOnSearchFilter(PropertyInfo property, bool isWorkLogItemSearch = false, Func<List<string>> hideProperties = null)
	{
		if (property == null)
		{
			return false;
		}
		return property.ReflectedType.GetInterfaces().Any(delegate(Type i)
		{
			PropertyInfo reflectionProperty = i.GetReflectionProperty(property.Name);
			if (reflectionProperty == null || reflectionProperty.PropertyType != property.PropertyType)
			{
				return false;
			}
			if (property.Name == "SearchString")
			{
				return false;
			}
			if (hideProperties != null)
			{
				List<string> list = hideProperties();
				if (list != null && list.Contains(property.Name))
				{
					return false;
				}
			}
			if (i.GetReflectionProperty(property.Name).GetCustomAttributes(typeof(WorkLogItemSearchFieldAttribute), inherit: true).Length != 0)
			{
				return isWorkLogItemSearch;
			}
			if (i.GetReflectionProperty(property.Name).GetCustomAttributes(typeof(WorkLogItemSearchFieldAttribute), inherit: true).Length != 0)
			{
				return isWorkLogItemSearch;
			}
			return i == typeof(IWorkLogObjectSearchFilter) || GetWorkLogItemSearchExtensions().Any((IWorkLogObjectSearchExtension e) => e.Properties.Contains(property.Name) && e.ObjectTypeUids.Any((Guid t) => WorkLogExtensionHelper.FindExtensionByObjectUid(t, enabled: true) != null));
		});
	}

	[Obsolete]
	private static IEnumerable<IWorkLogObjectSearchExtension> GetWorkLogItemSearchExtensions()
	{
		return ComponentManager.Current.GetExtensionPoints<IWorkLogObjectSearchExtension>().ToList();
	}
}
