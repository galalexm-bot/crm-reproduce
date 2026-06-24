using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Tasks.API.Service.v1;

[Component(Order = 400)]
public class ExecutionControlTaskUpdatePackageService : IUpdatePackageService
{
	private static readonly Guid serviceUid = new Guid("B03B4A01-1E60-46AF-999E-8515482B0A10");

	private static readonly Guid controlTaskTypeUid = new Guid("672D3BA9-A637-4351-8D93-BC5300549F7F");

	private const string ControlTaskFilterKey = "Control && ExecutionControl && CurrentUser";

	private static Guid? taskTypeUid;

	public string ServiceName => SR.T("Контроль выполнения (TypeUid = {{{0}}})", controlTaskTypeUid);

	public Guid ServiceUid => serviceUid;

	private static Guid TaskTypeUid
	{
		get
		{
			Guid? guid = taskTypeUid;
			if (!guid.HasValue)
			{
				Guid? guid2 = (taskTypeUid = InterfaceActivator.UID<ITask>());
				return guid2.Value;
			}
			return guid.GetValueOrDefault();
		}
	}

	public IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider)
	{
		yield return typeof(ControlTaskPackage);
		yield return typeof(TaskPackage);
	}

	public IEnumerable<PackageBase> CreatePackages(DateTime date)
	{
		InstanceOf<ITaskFilter> instanceOf = new InstanceOf<ITaskFilter>();
		instanceOf.New.TypeUid = InterfaceActivator.UID<ITask>();
		instanceOf.New.UnderControl = true;
		instanceOf.New.ControlUser = AuthenticationService.GetCurrentUser<IUser>();
		instanceOf.New.ControlType = TaskControlType.Execution;
		instanceOf.New.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
		instanceOf.New.NotShowInLists = false;
		ITaskFilter @new = instanceOf.New;
		if (date == DateTime.MinValue)
		{
			return ((IEnumerable<long>)TaskManager.Instance.FindIds(@new, FetchOptions.All)).Select((Func<long, PackageBase>)((long id) => new UpdateIdPackage(ServiceUid, controlTaskTypeUid, id))).ToList();
		}
		IGrouping<long, IEntityModelHistoryItem>[] source = (from h in Locator.GetServiceNotNull<IEntityModelHistoryService>().Find(TaskTypeUid, date, "Control && ExecutionControl && CurrentUser", @new)
			group h by h.ObjectId).ToArray();
		IGrouping<long, IEntityModelHistoryItem>[] deleted = source.Where((IGrouping<long, IEntityModelHistoryItem> g) => g.Any((IEntityModelHistoryItem h) => h.ActionTypeUid == DefaultEntityActions.DeleteGuid)).ToArray();
		List<PackageBase> list = ((IEnumerable<IGrouping<long, IEntityModelHistoryItem>>)source.Where((IGrouping<long, IEntityModelHistoryItem> g) => !deleted.Contains(g)).ToArray()).Select((Func<IGrouping<long, IEntityModelHistoryItem>, PackageBase>)((IGrouping<long, IEntityModelHistoryItem> items) => new UpdateIdPackage(ServiceUid, controlTaskTypeUid, items.Key))).ToList();
		if (deleted.Any())
		{
			list.Add(new DeletedIdsPackage(ServiceUid, controlTaskTypeUid, deleted.Select((IGrouping<long, IEntityModelHistoryItem> items) => items.Key)));
		}
		return list;
	}

	public PackageBase[] ConvertPackages(UpdateIdPackage[] updateIdPackages)
	{
		long[] array = updateIdPackages.Select((UpdateIdPackage p) => p.Updated).ToArray();
		IEnumerable<ITask> tasks = TaskBaseManager.Instance.FindByIdArray(array).OfType<ITask>();
		return array.Where((long id) => tasks.All((ITask t) => t.Id != id)).Select((Func<long, PackageBase>)((long id) => new DeletedIdsPackage(ServiceUid, controlTaskTypeUid, id))).Union(tasks.Select((ITask t) => new ControlTaskPackage(ServiceUid, controlTaskTypeUid)
		{
			Data = new ControlTaskWCF(t)
		}))
			.ToArray();
	}

	public bool PackagesCommit(DateTime serverTime, DateTime now, PackageBase[] packages)
	{
		PackageBase[] source = packages.Where((PackageBase p) => p.TypeUid == controlTaskTypeUid).ToArray();
		if (source.OfType<UpdateIdPackage>().Any())
		{
			return false;
		}
		long[] array = (from p in source.OfType<ControlTaskPackage>()
			select p.GetId()).ToArray();
		long[] deleted = source.OfType<DeletedIdsPackage>().SelectMany((DeletedIdsPackage p) => p.Deleted).ToArray();
		IPublicCacheService serviceNotNull = Locator.GetServiceNotNull<IPublicCacheService>();
		if (!(serverTime == DateTime.MinValue))
		{
			return serviceNotNull.UpdateCache(PackageChangesService.AuthToken, TaskTypeUid, now, array, deleted, "Control && ExecutionControl && CurrentUser");
		}
		return serviceNotNull.SyncCache(PackageChangesService.AuthToken, TaskTypeUid, now, array, "Control && ExecutionControl && CurrentUser");
	}

	public bool Sync(DateTime now, PackageChangesSyncData[] changes)
	{
		return Locator.GetServiceNotNull<IPublicCacheService>().SyncCache(PackageChangesService.AuthToken, TaskTypeUid, now, changes.Where((PackageChangesSyncData p) => p.TypeUid == controlTaskTypeUid).SelectMany((PackageChangesSyncData sr) => sr.List).ToArray(), "Control && ExecutionControl && CurrentUser");
	}
}
