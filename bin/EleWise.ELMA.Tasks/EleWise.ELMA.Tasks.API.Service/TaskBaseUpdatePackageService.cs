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
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Service.v1;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.API.Service.v1;

[Component(Order = 100)]
public class TaskBaseUpdatePackageService : IUpdatePackageService
{
	internal static readonly Guid serviceUid = new Guid("7A2A9E12-7CF3-44D8-A1F1-6F56A7BA87FA");

	private const string TaskBaseFilterKey = "CurrentUser && Active";

	private static Guid? taskBaseTypeUid;

	private static Guid[] allTypeUids;

	private static object allTypeUidsLocker = new object();

	public string ServiceName => SR.T("Задачи, базовый список (обязательно для использования набора данных для любых типов задач)");

	public static Guid Uid => serviceUid;

	public Guid ServiceUid => serviceUid;

	protected IEntityModelHistoryService EntityModelHistoryService => Locator.GetServiceNotNull<IEntityModelHistoryService>();

	private static Guid TaskBaseTypeUid
	{
		get
		{
			Guid? guid = taskBaseTypeUid;
			if (!guid.HasValue)
			{
				Guid? guid2 = (taskBaseTypeUid = InterfaceActivator.UID<ITaskBase>());
				return guid2.Value;
			}
			return guid.GetValueOrDefault();
		}
	}

	private static IList<Guid> AllTypeUids
	{
		get
		{
			if (allTypeUids != null)
			{
				return allTypeUids;
			}
			lock (allTypeUidsLocker)
			{
				if (allTypeUids != null)
				{
					return allTypeUids;
				}
				allTypeUids = ComponentManager.Current.GetExtensionPoints<ITaskUpdatePackages>().SelectMany((ITaskUpdatePackages p) => p.TypeUids).Union(new Guid[1] { InterfaceActivator.UID<ITaskBase>() })
					.ToArray();
				return allTypeUids;
			}
		}
	}

	public IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider)
	{
		yield break;
	}

	public IEnumerable<PackageBase> CreatePackages(DateTime date)
	{
		List<Guid> typeUids = (from service in ComponentManager.Current.GetExtensionPoints<ITaskUpdatePackages>()
			join guid in PackageChangesService.DataSets on service.ServiceUid equals guid
			select service).SelectMany((ITaskUpdatePackages service) => service.TypeUids).ToList();
		InstanceOf<ITaskBaseFilter> instanceOf = new InstanceOf<ITaskBaseFilter>();
		ITaskBaseFilter @new = instanceOf.New;
		HashedSet<IUser> obj = new HashedSet<IUser>();
		((Set<IUser>)(object)obj).Add(AuthenticationService.GetCurrentUser<IUser>());
		@new.Executors = (ISet<IUser>)(object)obj;
		instanceOf.New.CompleteStatus = TaskCompleteStatus.Active;
		instanceOf.New.TypeUids = typeUids;
		instanceOf.New.NotShowInLists = false;
		ITaskBaseFilter new2 = instanceOf.New;
		IGrouping<long, IEntityModelHistoryItem>[] source = (from h in EntityModelHistoryService.Find(InterfaceActivator.UID<ITaskBase>(), date, "CurrentUser && Active", new2)
			group h by h.ObjectId).ToArray();
		IGrouping<long, IEntityModelHistoryItem>[] deleted = source.Where((IGrouping<long, IEntityModelHistoryItem> g) => g.Any((IEntityModelHistoryItem h) => h.ActionTypeUid == DefaultEntityActions.DeleteGuid)).ToArray();
		List<PackageBase> list = ((IEnumerable<IGrouping<long, IEntityModelHistoryItem>>)source.Where((IGrouping<long, IEntityModelHistoryItem> g) => !deleted.Contains(g)).ToArray()).Select((Func<IGrouping<long, IEntityModelHistoryItem>, PackageBase>)((IGrouping<long, IEntityModelHistoryItem> items) => new UpdateIdPackage(ServiceUid, TaskBaseTypeUid, items.Key))).ToList();
		if (deleted.Any())
		{
			list.Add(new DeletedIdsPackage(ServiceUid, TaskBaseTypeUid, deleted.Select((IGrouping<long, IEntityModelHistoryItem> items) => items.Key)));
		}
		return list;
	}

	public PackageBase[] ConvertPackages(UpdateIdPackage[] updateIdPackages)
	{
		long[] array = updateIdPackages.Select((UpdateIdPackage p) => p.Updated).ToArray();
		ICollection<ITaskBase> tasks = TaskBaseManager.Instance.FindByIdArray(array);
		return array.Where((long id) => tasks.All((ITaskBase t) => t.Id != id)).Select((Func<long, PackageBase>)((long id) => new DeletedIdsPackage(ServiceUid, TaskBaseTypeUid, id))).Union((from task in tasks
			group task by task.TypeUid).SelectMany((IGrouping<Guid, ITaskBase> g) => (from service in ComponentManager.Current.GetExtensionPoints<ITaskUpdatePackages>()
			join guid in PackageChangesService.DataSets on service.ServiceUid equals guid
			select service).First((ITaskUpdatePackages p) => ((ICollection<Guid>)p.TypeUids).Contains(g.Key)).ConvertPackages(g)))
			.ToArray();
	}

	public bool PackagesCommit(DateTime serverTime, DateTime now, PackageBase[] packages)
	{
		PackageBase[] source = (from p in packages
			join g in AllTypeUids on p.TypeUid equals g
			select p).ToArray();
		if (source.OfType<UpdateIdPackage>().Any())
		{
			return false;
		}
		long[] array = (from p in source.OfType<TaskBasePackage>()
			select p.GetId()).ToArray();
		long[] deleted = source.OfType<DeletedIdsPackage>().SelectMany((DeletedIdsPackage p) => p.Deleted).ToArray();
		IPublicCacheService serviceNotNull = Locator.GetServiceNotNull<IPublicCacheService>();
		if (!(serverTime == DateTime.MinValue))
		{
			return serviceNotNull.UpdateCache(PackageChangesService.AuthToken, TaskBaseTypeUid, now, array, deleted, "CurrentUser && Active");
		}
		return serviceNotNull.SyncCache(PackageChangesService.AuthToken, TaskBaseTypeUid, now, array, "CurrentUser && Active");
	}

	public bool Sync(DateTime now, PackageChangesSyncData[] changes)
	{
		return Locator.GetServiceNotNull<IPublicCacheService>().SyncCache(PackageChangesService.AuthToken, TaskBaseTypeUid, now, (from sr in changes
			join g in AllTypeUids on sr.TypeUid equals g
			select sr).SelectMany((PackageChangesSyncData sr) => sr.List).ToArray(), "CurrentUser && Active");
	}
}
