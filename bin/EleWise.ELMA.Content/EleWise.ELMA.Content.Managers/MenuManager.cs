using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MenuManager : EntityManager<IMenu, int>
{
	public static readonly Guid LeftMenuUid = new Guid("24C7E5E8-42B0-4A6E-8D8D-A2858DC372E4");

	public static readonly Guid CreateMenuUid = new Guid("546486B7-E4C5-439F-AB51-7F5187016032");

	public static readonly Guid StartMenuUid = new Guid("1A1F59F1-DB4C-4DB7-9FE6-CD93CFBEB587");

	public static readonly Guid TopMenuUid = new Guid("029F7F56-6D7A-4FDA-903B-C30246A6A03A");

	public static readonly Guid[] SystemMenus = new Guid[4] { LeftMenuUid, CreateMenuUid, StartMenuUid, TopMenuUid };

	private static MenuManager instance;

	private static string LoadMenuReadOnlyFormat = "LoadMenuReadOnly_{0}";

	private static string LoadMenuReadOnlyTimestampFormat = "LoadMenuReadOnly_timestamp_{0}";

	private static string LeftMenuByWorkPlaceFormat = "LeftMenuByWorkPlace_{0}";

	private static string LeftMenuByWorkPlaceTimestampFormat = "LeftMenuByWorkPlace_timestamp_{0}";

	private static string StartMenuByWorkPlaceFormat = "StartMenuByWorkPlace_{0}";

	private static string StartMenuByWorkPlaceTimestampFormat = "StartMenuByWorkPlace_timestamp_{0}";

	private static readonly ConcurrentDictionary<Guid, int> ids = new ConcurrentDictionary<Guid, int>();

	[NotNull]
	public new static MenuManager Instance => instance ?? (instance = Locator.GetServiceNotNull<MenuManager>());

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	[Obsolete("Use MenuManager.LeftMenuUid instead GetMenuUid(\"left\")")]
	public static Guid GetMenuUid(string menuUid)
	{
		return menuUid switch
		{
			"left" => LeftMenuUid, 
			"create" => CreateMenuUid, 
			"start" => StartMenuUid, 
			"top" => TopMenuUid, 
			_ => Guid.Empty, 
		};
	}

	public IMenu GetLeftMenuByUser(long userId)
	{
		int? leftMenuIdByUser = GetLeftMenuIdByUser(userId);
		if (!leftMenuIdByUser.HasValue)
		{
			return null;
		}
		return LoadOrNull(leftMenuIdByUser.Value);
	}

	public IMenu GetLeftMenuByUserReadOnly(long userId)
	{
		int? leftMenuIdByUser = GetLeftMenuIdByUser(userId);
		if (!leftMenuIdByUser.HasValue)
		{
			return null;
		}
		return LoadOrNullReadOnly(leftMenuIdByUser.Value);
	}

	internal int? GetLeftMenuIdByUser(long userId)
	{
		long? workPlaceId = WorkPlaceManager.Instance.GetWorkPlaceIdByUser(userId);
		return ComplexCacheService.GetOrAdd(string.Format(LeftMenuByWorkPlaceFormat, workPlaceId), string.Format(LeftMenuByWorkPlaceTimestampFormat, workPlaceId), () => CreateCriteria(null, InterfaceActivator.TypeOf<IWorkPlace>()).Add((ICriterion)((!workPlaceId.HasValue) ? ((object)Restrictions.Eq("Uid", (object)WorkPlaceManager.DefaultWorkPlaceUid)) : ((object)Restrictions.IdEq((object)workPlaceId)))).CreateAlias("LeftMenu", "lm").SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("lm.Id") })
			.UniqueResult<int?>());
	}

	public IMenu GetStartMenuByUser(long userId)
	{
		int? startMenuIdByUser = GetStartMenuIdByUser(userId);
		if (!startMenuIdByUser.HasValue)
		{
			return null;
		}
		return LoadOrNull(startMenuIdByUser.Value);
	}

	public IMenu GetStartMenuByUserReadOnly(long userId)
	{
		int? startMenuIdByUser = GetStartMenuIdByUser(userId);
		if (!startMenuIdByUser.HasValue)
		{
			return null;
		}
		return LoadOrNullReadOnly(startMenuIdByUser.Value);
	}

	internal int? GetStartMenuIdByUser(long userId)
	{
		long? workPlaceId = WorkPlaceManager.Instance.GetWorkPlaceIdByUser(userId);
		return ComplexCacheService.GetOrAdd(string.Format(StartMenuByWorkPlaceFormat, workPlaceId), string.Format(StartMenuByWorkPlaceTimestampFormat, workPlaceId), () => CreateCriteria(null, InterfaceActivator.TypeOf<IWorkPlace>()).Add((ICriterion)((!workPlaceId.HasValue) ? ((object)Restrictions.Eq("Uid", (object)WorkPlaceManager.DefaultWorkPlaceUid)) : ((object)Restrictions.IdEq((object)workPlaceId)))).CreateAlias("StartMenu", "sm").SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("sm.Id") })
			.UniqueResult<int?>());
	}

	internal void RefreshMenuByWorkPlaceCache(IWorkPlace workPlace)
	{
		if (workPlace != null)
		{
			long? num = ((workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid) ? null : new long?(workPlace.Id));
			ComplexCacheService.RefreshTimestamp(string.Format(LeftMenuByWorkPlaceTimestampFormat, num));
			ComplexCacheService.RefreshTimestamp(string.Format(StartMenuByWorkPlaceTimestampFormat, num));
		}
	}

	internal void RefreshMenuReadOnly(IMenu menu)
	{
		if (menu != null)
		{
			ComplexCacheService.RefreshTimestamp(string.Format(LoadMenuReadOnlyTimestampFormat, menu.Id));
			ComplexCacheService.RefreshTimestamp(string.Format(LoadMenuReadOnlyTimestampFormat, menu.Uid));
		}
	}

	[Transaction]
	public virtual void ResetCache()
	{
		foreach (IMenu item in FindAll())
		{
			item.ItemsChangeDate = DateTime.Now;
			item.Save();
		}
	}

	[Transaction]
	public virtual T CloneMenu<T>(T menu) where T : class, IMenu
	{
		T val = CloneHelperBuilder.Create(menu).Restrictions(delegate(RestrictionsBuilder<T> r)
		{
			r.Rule().ForPropertyName((IMenuItem i) => i.ParentItem).Clone();
		}).Clone();
		val.Save();
		return val;
	}

	[Transaction]
	public override void Delete(IMenu obj)
	{
		if (!Array.Exists(SystemMenus, (Guid uid) => obj.Uid == uid))
		{
			MenuItemManager.Instance.DeleteAllItems(obj.Id);
			base.Delete(obj);
		}
	}

	protected override IMenu LoadByUid(Guid uid)
	{
		if (ids.TryGetValue(uid, out var value))
		{
			return Load(value);
		}
		IMenu menu = base.LoadByUid(uid);
		if (menu != null && !menu.IsNew())
		{
			ids.TryAdd(uid, menu.Id);
		}
		return menu;
	}

	public IMenu LoadOrNullReadOnly(int menuId)
	{
		return ComplexCacheService.GetOrAdd(string.Format(LoadMenuReadOnlyFormat, menuId), string.Format(LoadMenuReadOnlyTimestampFormat, menuId), () => LoadOrNull(menuId));
	}

	public IMenu LoadOrNullReadOnly(Guid menuUid)
	{
		return ComplexCacheService.GetOrAdd(string.Format(LoadMenuReadOnlyFormat, menuUid), string.Format(LoadMenuReadOnlyTimestampFormat, menuUid), () => LoadOrNull(menuUid));
	}
}
