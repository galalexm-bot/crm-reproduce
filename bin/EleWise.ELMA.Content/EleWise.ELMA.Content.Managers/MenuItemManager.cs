using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Cache;
using EleWise.ELMA.Content.Filters;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MenuItemManager : EntityManager<IMenuItem, long>
{
	private static MenuItemManager instance;

	private const string MenuCachePrefix = "Menu_";

	private const string MenuUserCachePrefix = "Menu_User_";

	private const string customGroupCode = "custom_main_menu_item_group";

	public MenuManager MenuManager { get; set; }

	internal MenuUnionComplexCacheService MenuComplexCacheService => Locator.GetServiceNotNull<MenuUnionComplexCacheService>();

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	[NotNull]
	public new static MenuItemManager Instance => instance ?? (instance = Locator.GetServiceNotNull<MenuItemManager>());

	[PublicApiMember]
	public override void Save(IMenuItem obj)
	{
		base.Save(obj);
		if (obj.Menu != null)
		{
			ResetItemsCache(obj.Menu.Uid);
		}
	}

	[PublicApiMember]
	public override void Delete(IMenuItem obj)
	{
		base.Delete(obj);
		if (obj.Menu != null)
		{
			ResetItemsCache(obj.Menu.Uid);
		}
	}

	public IMenuItem LoadByMenuUid(IMenu menu, Guid menuUid)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.Eq("Menu", (object)menu)).Add((ICriterion)(object)Restrictions.Eq("MenuUid", (object)menuUid));
		return obj.UniqueResult<IMenuItem>();
	}

	[Transaction]
	public virtual void DeleteAllItems(long id)
	{
		IMenu menu = MenuManager.Load((int)id);
		((AbstractNHEntityManager<IMenuItem, long>)this).Find((Expression<Func<IMenuItem, bool>>)((IMenuItem i) => i.Menu == menu)).OrderByParentDesc((IMenuItem i) => i.ParentItem, FunctorEqualityComparer<IMenuItem>.Create(IEntityExtensions.Same)).ForEach(delegate(IMenuItem item)
		{
			((IEnumerable<IMenuItemPermission>)item.Permissions).ForEach(delegate(IMenuItemPermission p)
			{
				p.Delete();
			});
			Delete(item);
			base.Session.Flush();
		});
	}

	[Transaction]
	public virtual void DeleteItemRecursive(long id)
	{
		IMenuItem item = Load(id);
		DeleteItemRecursive(item);
	}

	[Transaction]
	public virtual void DeleteItemRecursive(IMenuItem item)
	{
		foreach (IMenuItem item2 in ((AbstractNHEntityManager<IMenuItem, long>)this).Find((Expression<Func<IMenuItem, bool>>)((IMenuItem i) => i.ParentItem == item)))
		{
			DeleteItemRecursive(item2);
		}
		Delete(item);
		base.Session.Flush();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter != null && filter is MenuItemFilter)
		{
			MenuItemFilter menuItemFilter = (MenuItemFilter)filter;
			if (menuItemFilter.Menu != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq("Menu.Id", (object)menuItemFilter.Menu.Id));
			}
			if (menuItemFilter.ParentItem != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq("ParentItem.Id", (object)menuItemFilter.ParentItem.Id));
			}
		}
	}

	public IList<IMenuItem> LoadItemsReadOnly(IMenu menu, bool allowDisabled)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		return LoadItemsReadOnly(menu.Uid, () => menu, allowDisabled);
	}

	public IList<IMenuItem> LoadItemsReadOnly(Guid menuUid, bool allowDisabled)
	{
		return LoadItemsReadOnly(menuUid, () => MenuManager.Load(menuUid), allowDisabled);
	}

	private IList<IMenuItem> LoadItemsReadOnly(Guid menuUid, Func<IMenu> menuAccessor, bool allowDisabled)
	{
		if (menuAccessor == null)
		{
			throw new ArgumentNullException("menuAccessor");
		}
		string text = "Menu_" + menuUid;
		string text2 = "Menu_User_";
		string text3 = text + "_";
		if (!allowDisabled)
		{
			object id = base.AuthenticationService.GetCurrentUser().GetId();
			text3 += id;
			text2 += id;
		}
		return MenuComplexCacheService.GetOrAdd(text3, text2, text, "Menu_", delegate
		{
			MenuItemFilter menuItemFilter = new MenuItemFilter
			{
				Menu = menuAccessor()
			};
			if (!allowDisabled)
			{
				menuItemFilter.PermissionId = MenuSecurity.ViewMenuItemPermission.Id;
			}
			return (from i in Find(menuItemFilter, FetchOptions.All)
				orderby i.Weight
				select i).ToList();
		});
	}

	public IMenuItem CreateMainMenuCustomGroup(int menuId)
	{
		InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
		instanceOf.New.Menu = MenuManager.Load(menuId);
		instanceOf.New.Name = SR.T("Пользовательские");
		instanceOf.New.Weight = int.MaxValue;
		instanceOf.New.Code = "custom_main_menu_item_group";
		instanceOf.New.Description = SR.T("Группа для добавления пользовательских элементов главного меню.");
		IMenuItem @new = instanceOf.New;
		@new.Save();
		return @new;
	}

	public IMenuItem GetOrCreateMainMenuCustomGroup(int menuId)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.Eq("Code", (object)"custom_main_menu_item_group")).Add((ICriterion)(object)Restrictions.Eq("Menu.Id", (object)menuId));
		IMenuItem menuItem = obj.UniqueResult<IMenuItem>();
		if (menuItem == null)
		{
			menuItem = CreateMainMenuCustomGroup(menuId);
		}
		return menuItem;
	}

	public void ResetItems4UserCache(long userId)
	{
		string timestampKey = "Menu_User_" + userId;
		ComplexCacheService.RefreshTimestamp(timestampKey);
	}

	public void ResetItemsCache(Guid menuUid)
	{
		string timestampKey = "Menu_" + menuUid;
		ComplexCacheService.RefreshTimestamp(timestampKey);
	}

	public void ResetItemsCache()
	{
		ComplexCacheService.RefreshTimestamp("Menu_");
	}
}
