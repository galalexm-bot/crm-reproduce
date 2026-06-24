using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Db;

public class TaskDbStructure : DbStructureExtension
{
	private const string BlobPersonalizationProviderUid = "dcb7cb22-3717-4df3-90f2-b9909a5f7c4d";

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void CreateCompulsoryWorklogGroup()
	{
		IUserGroup userGroup = UserGroupManager.Instance.Find((IUserGroup g) => g.Uid == TaskConstants.CompulsoryWorklogGroupUid).FirstOrDefault();
		if (userGroup == null)
		{
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
			if (user == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось найти пользователя \"Администратор\" Uid={0}", SecurityConstants.AdminUserUid));
			}
			InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
			instanceOf.New.Name = TaskConstants.CompulsoryWorklogGroupDescriptor.Name;
			instanceOf.New.Description = TaskConstants.CompulsoryWorklogGroupDescriptor.Description;
			instanceOf.New.CreationAuthor = user;
			instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
			userGroup = instanceOf.New;
		}
		userGroup.Uid = TaskConstants.CompulsoryWorklogGroupUid;
		userGroup.IsSystem = true;
		userGroup.Save();
		Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
	}

	public void CreateAdminWorklogGroup()
	{
		IUserGroup userGroup = UserGroupManager.Instance.Find((IUserGroup g) => g.Uid == TaskConstants.AdminWorklogGroupUid).FirstOrDefault();
		if (userGroup == null)
		{
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
			if (user == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось найти пользователя \"Администратор\" Uid={0}", SecurityConstants.AdminUserUid));
			}
			InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
			instanceOf.New.Name = TaskConstants.AdminWorklogGroupDescriptor.Name;
			instanceOf.New.Description = TaskConstants.AdminWorklogGroupDescriptor.Description;
			instanceOf.New.CreationAuthor = user;
			instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
			userGroup = instanceOf.New;
			userGroup.Users.Add(user);
		}
		userGroup.Uid = TaskConstants.AdminWorklogGroupUid;
		userGroup.IsSystem = true;
		userGroup.Save();
		Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
	}

	public void CreateAutoApproveMyWorklogGroup()
	{
		IUserGroup userGroup = UserGroupManager.Instance.Find((IUserGroup g) => g.Uid == TaskConstants.AutoApproveMyWorklogGroupUid).FirstOrDefault();
		if (userGroup == null)
		{
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
			if (user == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось найти пользователя \"Администратор\" Uid={0}", SecurityConstants.AdminUserUid));
			}
			InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
			instanceOf.New.Name = TaskConstants.AutoApproveMyWorklogGroupDescriptor.Name;
			instanceOf.New.Description = TaskConstants.AutoApproveMyWorklogGroupDescriptor.Description;
			instanceOf.New.CreationAuthor = user;
			instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
			userGroup = instanceOf.New;
		}
		userGroup.Uid = TaskConstants.AutoApproveMyWorklogGroupUid;
		userGroup.IsSystem = true;
		userGroup.Save();
		Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
	}

	private void SetAllToReadFilter(IFilter filter, IUserGroup group, bool edit = false, bool full = false)
	{
		ISet<IFilterPermission> permissions = filter.Permissions;
		InstanceOf<IFilterPermission> instanceOf = new InstanceOf<IFilterPermission>();
		instanceOf.New.Filter = filter;
		instanceOf.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterViewPermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf.New.Group = group;
		instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
		permissions.Add(instanceOf.New);
		if (edit)
		{
			ISet<IFilterPermission> permissions2 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf2 = new InstanceOf<IFilterPermission>();
			instanceOf2.New.Filter = filter;
			instanceOf2.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterEditPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf2.New.Group = group;
			instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
			permissions2.Add(instanceOf2.New);
		}
		if (full)
		{
			ISet<IFilterPermission> permissions3 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
			instanceOf3.New.Filter = filter;
			instanceOf3.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterFullAccessPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf3.New.Group = group;
			instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
			permissions3.Add(instanceOf3.New);
		}
	}

	public void CreateDefaultMyWorkLogItemFiltersForAllUsers1()
	{
		IUserGroup group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(TaskConstants.MyWorkLogItemFilter);
		InstanceOf<IWorkLogItemSearchFilter> instanceOf = new InstanceOf<IWorkLogItemSearchFilter>();
		instanceOf.New.OnlyMy = true;
		instanceOf.New.WorkLogItemDate = new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "0м"
		};
		object filterFields = UniversalFilterSaver.Pack(instanceOf.New);
		if (filter == null)
		{
			InstanceOf<IFilter> instanceOf2 = new InstanceOf<IFilter>();
			instanceOf2.New.Code = new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}");
			instanceOf2.New.FilterType = FilterType.SystemFilter;
			instanceOf2.New.Uid = TaskConstants.MyWorkLogItemFilter;
			instanceOf2.New.Name = SR.T("Мои");
			instanceOf2.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}")
			};
			instanceOf2.New.UseDefaultSettings = true;
			instanceOf2.New.FilterFields = filterFields;
			instanceOf2.New.Weight = 1L;
			filter = instanceOf2.New;
			SetAllToReadFilter(filter, group);
			filter.Save();
			FilterDefaultManager.Instance.SaveSystemDefaultFilter(filter);
		}
		else
		{
			filter.FilterFields = filterFields;
		}
		IFilter filter2 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(TaskConstants.MyWorkLogItemApproveFilter);
		if (filter2 == null)
		{
			InstanceOf<IFilter> instanceOf3 = new InstanceOf<IFilter>();
			instanceOf3.New.Code = new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}");
			instanceOf3.New.FilterType = FilterType.SystemFilter;
			instanceOf3.New.Uid = TaskConstants.MyWorkLogItemApproveFilter;
			instanceOf3.New.Name = SR.T("Мои (На согласовании)");
			instanceOf3.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}")
			};
			instanceOf3.New.UseDefaultSettings = true;
			IFilter @new = instanceOf3.New;
			InstanceOf<IWorkLogItemSearchFilter> instanceOf4 = new InstanceOf<IWorkLogItemSearchFilter>();
			instanceOf4.New.OnlyMy = true;
			instanceOf4.New.WorkLogItemStatus = WorkLogItemStatus.New;
			@new.FilterFields = UniversalFilterSaver.Pack(instanceOf4.New);
			instanceOf3.New.Weight = 2L;
			filter2 = instanceOf3.New;
			SetAllToReadFilter(filter2, group);
			filter2.Save();
		}
		IFilter filter3 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(TaskConstants.MyWorkLogItemApproveConfirmFilter);
		InstanceOf<IWorkLogItemSearchFilter> instanceOf5 = new InstanceOf<IWorkLogItemSearchFilter>();
		instanceOf5.New.OnlyMy = true;
		instanceOf5.New.WorkLogItemStatus = WorkLogItemStatus.Confirm;
		instanceOf5.New.WorkLogItemDate = new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "0м"
		};
		object filterFields2 = UniversalFilterSaver.Pack(instanceOf5.New);
		if (filter3 == null)
		{
			InstanceOf<IFilter> instanceOf6 = new InstanceOf<IFilter>();
			instanceOf6.New.Code = new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}");
			instanceOf6.New.FilterType = FilterType.SystemFilter;
			instanceOf6.New.Uid = TaskConstants.MyWorkLogItemApproveConfirmFilter;
			instanceOf6.New.Name = SR.T("Мои (Согласовано)");
			instanceOf6.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}")
			};
			instanceOf6.New.UseDefaultSettings = true;
			instanceOf6.New.FilterFields = filterFields2;
			instanceOf6.New.Weight = 3L;
			filter3 = instanceOf6.New;
			SetAllToReadFilter(filter3, group);
			filter3.Save();
		}
		else
		{
			filter3.FilterFields = filterFields2;
		}
		IFilter filter4 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(TaskConstants.MyWorkLogItemApproveUnConfirmFilter);
		InstanceOf<IWorkLogItemSearchFilter> instanceOf7 = new InstanceOf<IWorkLogItemSearchFilter>();
		instanceOf7.New.OnlyMy = true;
		instanceOf7.New.WorkLogItemStatus = WorkLogItemStatus.Unconfirm;
		instanceOf7.New.WorkLogItemDate = new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "0м"
		};
		object filterFields3 = UniversalFilterSaver.Pack(instanceOf7.New);
		if (filter4 == null)
		{
			InstanceOf<IFilter> instanceOf8 = new InstanceOf<IFilter>();
			instanceOf8.New.Code = new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}");
			instanceOf8.New.FilterType = FilterType.SystemFilter;
			instanceOf8.New.Uid = TaskConstants.MyWorkLogItemApproveUnConfirmFilter;
			instanceOf8.New.Name = SR.T("Мои (Отклонено)");
			instanceOf8.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}")
			};
			instanceOf8.New.UseDefaultSettings = true;
			instanceOf8.New.FilterFields = filterFields3;
			instanceOf8.New.Weight = 4L;
			filter4 = instanceOf8.New;
			SetAllToReadFilter(filter4, group);
			filter4.Save();
		}
		else
		{
			filter4.FilterFields = filterFields3;
		}
		IFilter filter5 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(TaskConstants.DepartmentWorkLogItemFilter);
		InstanceOf<IWorkLogItemSearchFilter> instanceOf9 = new InstanceOf<IWorkLogItemSearchFilter>();
		instanceOf9.New.MyDepartment = true;
		instanceOf9.New.WorkLogItemDate = new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "0м"
		};
		object filterFields4 = UniversalFilterSaver.Pack(instanceOf9.New);
		if (filter5 == null)
		{
			InstanceOf<IFilter> instanceOf10 = new InstanceOf<IFilter>();
			instanceOf10.New.Code = new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}");
			instanceOf10.New.FilterType = FilterType.SystemFilter;
			instanceOf10.New.Uid = TaskConstants.DepartmentWorkLogItemFilter;
			instanceOf10.New.Name = SR.T("Мой отдел");
			instanceOf10.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}")
			};
			instanceOf10.New.UseDefaultSettings = true;
			instanceOf10.New.FilterFields = filterFields4;
			instanceOf10.New.Weight = 5L;
			filter5 = instanceOf10.New;
			SetAllToReadFilter(filter5, group);
			filter5.Save();
		}
		else
		{
			filter5.FilterFields = filterFields4;
		}
	}

	public void RemoveTaskGridSettings()
	{
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		List<string> source = new List<string> { "TasksIncoming", "TasksOutgoing", "TasksSearch", "MyTasksPortletGrid", "TasksExecutionControl", "TasksCurrentControl" };
		string sql = string.Format("delete from {0} where {1}", transformationProvider.Dialect.QuoteIfNeeded("BlobStoreHolder"), string.Join(" OR ", source.Select((string id) => string.Format("{1} like {0}{2}", transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("Key"), id))));
		transformationProvider.ExecuteNonQuery(sql, ((IEnumerable<string>)source).ToDictionary((Func<string, string>)((string id) => id), (Func<string, object>)((string id) => string.Format("{0}{1}/%", "dcb7cb22-3717-4df3-90f2-b9909a5f7c4d", id))));
	}

	public void ChangeWorkLogSettings()
	{
		DataAccessManager.SettingsManager.RemoveString(WorkLogSettingsModule._ModuleGuid, "EmptyLineCount");
	}

	public void ChangeStatusesToNewControlStatuses()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		ChangeStatusesToNewControlStatuses(serviceNotNull, TaskBaseStatus.Complete.Value, TaskBaseStatus.CompleteNeedControl.Value);
		ChangeStatusesToNewControlStatuses(serviceNotNull, TaskBaseStatus.Incomplete.Value, TaskBaseStatus.IncompleteNeedControl.Value);
	}

	internal void UpdateWorkLogItemsDateTimeZones()
	{
		Dictionary<long, int> usersOffsetDiffToUpdate = GetUsersOffsetDiffToUpdate(TZ.ServerOffset);
		string text = base.Transformation.Dialect.QuoteIfNeeded("WorkLogItem");
		string text2 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem i) => i.Date)));
		string text3 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem i) => i.Status)));
		string text4 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem i) => i.CreationAuthor)));
		string parameterSeparator = base.Transformation.ParameterSeparator;
		string sql = string.Format("update {0} set {1} = {2} where {3} = {4}draftStatus and {5} = {4}userId", text, text2, base.Transformation.Dialect.AddSecond(text2, parameterSeparator + "diffInSeconds"), text3, parameterSeparator, text4);
		Dictionary<string, object> dictionary = new Dictionary<string, object> { { "draftStatus", 3 } };
		foreach (KeyValuePair<long, int> item in usersOffsetDiffToUpdate)
		{
			dictionary["userId"] = item.Key;
			dictionary["diffInSeconds"] = item.Value * 60;
			base.Transformation.ExecuteNonQuery(sql, dictionary);
		}
	}

	internal void TaskControlFiltersUpdate()
	{
		TaskControlFiltersUpdateInternal(new Guid("{FA610A6E-9CF2-4E10-AF47-3AC6AF579C6A}"));
		TaskControlFiltersUpdateInternal(new Guid("{32F61BC5-CBC7-403A-B36D-143018981709}"));
	}

	internal void CopyTaskAttachments()
	{
		base.Transformation.Insert("M_Task_AS", new string[2] { "Task", "Attachment" }, string.Format("ta.{0} task_Id, ta.{1} attachment_Id", base.Transformation.Dialect.QuoteIfNeeded("Task"), base.Transformation.Dialect.QuoteIfNeeded("Attachment")), "M_Task_Attachments ta", isNeedInsertId: false);
	}

	private void TaskControlFiltersUpdateInternal(Guid codeUid)
	{
		base.Transformation.Update("FilterFolder", new string[1] { "ObjectsType" }, new object[1] { TaskControlUniqueFilterExtension.Guid }, string.Format("{0} = {1}Code", base.Transformation.Dialect.QuoteIfNeeded("Code"), base.Transformation.ParameterSeparator), new Dictionary<string, object> { { "Code", codeUid } });
	}

	private static void ChangeStatusesToNewControlStatuses(ITransformationProvider transformationProvider, Guid oldStatusUid, Guid newStatusUid)
	{
		transformationProvider.ExecuteNonQuery(string.Format("update {1} set {2}={0}newStatusUid\r\nwhere {7} in (\r\n    select tb.{7}\r\n    from {1} tb\r\n    inner join {6} t on tb.{7}=t.{7}\r\n    where tb.{2}={0}oldStatusUid\r\n        and t.{4}={5} and t.{3} is not null\r\n)", transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("TaskBase"), transformationProvider.Dialect.QuoteIfNeeded("Status"), transformationProvider.Dialect.QuoteIfNeeded("ControlUser"), transformationProvider.Dialect.QuoteIfNeeded("UnderControl"), Convert.ToInt32(value: true), transformationProvider.Dialect.QuoteIfNeeded("Task"), transformationProvider.Dialect.QuoteIfNeeded("Id")), new Dictionary<string, object>
		{
			{ "newStatusUid", newStatusUid },
			{ "oldStatusUid", oldStatusUid }
		});
	}

	private Dictionary<long, int> GetUsersOffsetDiffToUpdate(int serverOffset)
	{
		Dictionary<long, int> dictionary = new Dictionary<long, int>();
		string arg = base.Transformation.Dialect.QuoteIfNeeded("User");
		string arg2 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<EleWise.ELMA.Security.Models.IUser, object>>)((EleWise.ELMA.Security.Models.IUser u) => u.TimeZoneData)));
		using IDataReader dataReader = base.Transformation.ExecuteQuery(string.Format("select {0}, {1} from {2} where {1} is not null", base.Transformation.Dialect.QuoteIfNeeded("Id"), arg2, arg));
		while (dataReader.Read())
		{
			long @int = dataReader.GetInt64(0);
			int offset = TZ.Deserialize(dataReader.GetString(1)).Offset;
			if (serverOffset != offset)
			{
				dictionary.Add(@int, offset - serverOffset);
			}
		}
		return dictionary;
	}
}
