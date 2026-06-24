using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Calendar.API.Models;
using EleWise.ELMA.Calendar.API.Service.v1;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Calendar.API.Service;

[Component(Order = 200)]
public class CalendarItemUpdatePackageService : IUpdatePackageService
{
	internal static readonly Guid serviceUid = new Guid("04FAF318-CA85-4DB8-9D02-2D7D3983636C");

	internal static readonly Guid calendarItemTypeUid = new Guid("C44495BC-F9AF-4F53-938C-4445CBA2191C");

	private const string CalendarItemFilterKey = "CurrentUser";

	private static Dictionary<Guid, Pair<IUpdatePackageCalendarItemProvider, Guid>> packageTypeUidDictionary;

	private static object packageTypeUidDictionaryLocker = new object();

	protected IEntityModelHistoryService EntityModelHistoryService => Locator.GetServiceNotNull<IEntityModelHistoryService>();

	public string ServiceName => SR.T("Элементы календаря");

	public Guid ServiceUid => serviceUid;

	private IEnumerable<Guid> AllTypeUids
	{
		get
		{
			FillPackageTypeUidDictionary();
			return packageTypeUidDictionary.Keys;
		}
	}

	public IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider)
	{
		yield return typeof(CalendarItemPackage);
	}

	public IEnumerable<PackageBase> CreatePackages(DateTime date)
	{
		IPublicClientSession session = Locator.GetServiceNotNull<IPublicClientService>().GetSession(PackageChangesService.AuthToken);
		if (session == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
		}
		int num = DataAccessManager.BLOBManager.GetBLOB<int?>(CalendarService.Guid, session.SessionToken) ?? 2;
		DateTime today = DateTime.Today;
		DateTime startDate = today.AddDays(1 - today.Day).AddMonths(-num);
		DateTime endDate = today.AddDays(1 - today.Day).AddMonths(1 + num).AddTicks(-1L);
		IEnumerable<IUpdatePackageCalendarItemProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IUpdatePackageCalendarItemProvider>();
		ISchedule[] schedules = new ISchedule[1] { ScheduleManager.Instance.GetUserSchedule(AuthenticationService.GetCurrentUser<IUser>()) };
		return extensionPoints.SelectMany((IUpdatePackageCalendarItemProvider p) => p.GetTypeUids().SelectMany(delegate(Guid typeUid)
		{
			IEnumerable<IEntityModelHistoryItem> source = EntityModelHistoryService.Find(typeUid, date, "CurrentUser", p.GetFilter(schedules, startDate, endDate));
			IGrouping<long, IEntityModelHistoryItem>[] source2 = (from h in source
				group h by h.ObjectId).ToArray();
			IGrouping<long, IEntityModelHistoryItem>[] deleted = source2.Where((IGrouping<long, IEntityModelHistoryItem> g) => g.Any((IEntityModelHistoryItem h) => h.ActionTypeUid == DefaultEntityActions.DeleteGuid)).ToArray();
			IGrouping<long, IEntityModelHistoryItem>[] source3 = source2.Where((IGrouping<long, IEntityModelHistoryItem> g) => !deleted.Contains(g)).ToArray();
			List<PackageBase> list = ((IEnumerable<IGrouping<long, IEntityModelHistoryItem>>)source3).Select((Func<IGrouping<long, IEntityModelHistoryItem>, PackageBase>)((IGrouping<long, IEntityModelHistoryItem> items) => new UpdateIdPackage(serviceUid, p.GetPackageTypeUid(typeUid), items.Key))).ToList();
			if (deleted.Any())
			{
				list.Add(new DeletedIdsPackage(serviceUid, p.GetPackageTypeUid(typeUid), deleted.Select((IGrouping<long, IEntityModelHistoryItem> items) => items.Key)));
			}
			return list;
		}));
	}

	private void FillPackageTypeUidDictionary()
	{
		if (packageTypeUidDictionary != null)
		{
			return;
		}
		lock (packageTypeUidDictionaryLocker)
		{
			if (packageTypeUidDictionary != null)
			{
				return;
			}
			packageTypeUidDictionary = ComponentManager.Current.GetExtensionPoints<IUpdatePackageCalendarItemProvider>().SelectMany((IUpdatePackageCalendarItemProvider provider) => from typeUid in provider.GetTypeUids()
				select new { provider, typeUid }).ToDictionary(p => p.provider.GetPackageTypeUid(p.typeUid), p => new Pair<IUpdatePackageCalendarItemProvider, Guid>(p.provider, p.typeUid));
		}
	}

	private IUpdatePackageCalendarItemProvider GetProvider(Guid packageTypeUid)
	{
		FillPackageTypeUidDictionary();
		Pair<IUpdatePackageCalendarItemProvider, Guid> value;
		return packageTypeUidDictionary.TryGetValue(packageTypeUid, out value) ? value.First : null;
	}

	private Guid GetTypeUid(Guid packageTypeUid)
	{
		FillPackageTypeUidDictionary();
		Pair<IUpdatePackageCalendarItemProvider, Guid> value;
		return packageTypeUidDictionary.TryGetValue(packageTypeUid, out value) ? value.Second : Guid.Empty;
	}

	public PackageBase[] ConvertPackages(UpdateIdPackage[] updateIdPackages)
	{
		ISchedule[] schedules = new ISchedule[1] { ScheduleManager.Instance.GetUserSchedule(AuthenticationService.GetCurrentUser<IUser>()) };
		return (from up in updateIdPackages
			group up by up.TypeUid).SelectMany(delegate(IGrouping<Guid, UpdateIdPackage> pair)
		{
			IUpdatePackageCalendarItemProvider provider = GetProvider(pair.Key);
			long[] array = pair.Select((UpdateIdPackage p) => p.Updated).ToArray();
			CalendarItemPackage[] items = (from i in provider.GetItems(GetTypeUid(pair.Key), array, schedules)
				select new CalendarItemPackage(pair.Key)
				{
					Data = new CalendarItemWCF(i)
				}).ToArray();
			return array.Where((long id) => items.All((CalendarItemPackage i) => i.Data.Id != id)).Select((Func<long, PackageBase>)((long id) => new DeletedIdsPackage(serviceUid, pair.Key, id))).Union(items);
		}).ToArray();
	}

	public bool PackagesCommit(DateTime serverTime, DateTime now, PackageBase[] packages)
	{
		if (packages.OfType<UpdateIdPackage>().Any())
		{
			return false;
		}
		IPublicCacheService cacheSvc = Locator.GetServiceNotNull<IPublicCacheService>();
		return (from p in packages
			group p by p.TypeUid).All(delegate(IGrouping<Guid, PackageBase> pair)
		{
			long[] array = (from p in pair.OfType<CalendarItemPackage>()
				select p.Data.Id).ToArray();
			long[] deleted = pair.OfType<DeletedIdsPackage>().SelectMany((DeletedIdsPackage p) => p.Deleted).ToArray();
			return (serverTime == DateTime.MinValue) ? cacheSvc.SyncCache(PackageChangesService.AuthToken, GetTypeUid(pair.Key), now, array, "CurrentUser") : cacheSvc.UpdateCache(PackageChangesService.AuthToken, GetTypeUid(pair.Key), now, array, deleted, "CurrentUser");
		});
	}

	public bool Sync(DateTime now, PackageChangesSyncData[] changes)
	{
		IPublicCacheService cacheSvc = Locator.GetServiceNotNull<IPublicCacheService>();
		return (from sr in changes
			join g in AllTypeUids on sr.TypeUid equals g
			select sr into p
			group p by p.TypeUid).All((IGrouping<Guid, PackageChangesSyncData> pair) => cacheSvc.SyncCache(PackageChangesService.AuthToken, GetTypeUid(pair.Key), now, pair.SelectMany((PackageChangesSyncData sr) => sr.List).ToArray(), "CurrentUser"));
	}
}
