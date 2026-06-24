using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Menu;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Filters;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class MenuItemController : BPMController<IMenuItem, long>
{
	public ContentActionRegistry ContentActionRegistry { get; set; }

	public MenuInitializer MenuInitializer { get; set; }

	public IEntityManager<IMenu> MenuManager { get; set; }

	public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService { get; set; }

	public ActionResult Create(int menuId, long? parentId)
	{
		MenuItemModel menuItemModel = CreateMenuItem(menuId, parentId);
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)menuItemModel);
	}

	public ActionResult CreateGroup(int menuId, long? parentId)
	{
		MenuItemModel menuItemModel = CreateMenuItem(menuId, parentId);
		return (ActionResult)(object)((Controller)this).PartialView("EditGroupForm", (object)menuItemModel);
	}

	public ActionResult Edit(IMenuItem menuItem)
	{
		MenuItemModel menuItemModel = CreateEditModel(menuItem);
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)menuItemModel);
	}

	public ActionResult EditGroup(IMenuItem menuItem)
	{
		MenuItemModel menuItemModel = CreateEditModel(menuItem);
		return (ActionResult)(object)((Controller)this).PartialView("EditGroupForm", (object)menuItemModel);
	}

	private MenuItemModel CreateMenuItem(int menuId, long? parentId)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		MenuItemModel menuItemModel = new MenuItemModel();
		InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
		instanceOf.New.Menu = MenuManager.Load(menuId);
		menuItemModel.MenuItem = instanceOf.New;
		MenuItemModel menuItemModel2 = menuItemModel;
		IList<SelectListItem> selectList = GetSelectList(menuItemModel2.MenuItem.Menu.GetTreeForEdit().TreeItems, null, "");
		SelectListItem val = new SelectListItem();
		val.set_Text(SR.T("<Верхний уровень>"));
		val.set_Value("");
		selectList.Insert(0, val);
		if (parentId.HasValue)
		{
			selectList.ForEach(delegate(SelectListItem v)
			{
				if (v.get_Value() == parentId.ToString())
				{
					v.set_Selected(true);
				}
			});
			menuItemModel2.MenuItem.ParentItem = MenuItemManager.Instance.Load(parentId.Value);
		}
		menuItemModel2.ItemsList = selectList;
		menuItemModel2.ParentItemId = parentId;
		return menuItemModel2;
	}

	private MenuItemModel CreateEditModel(IMenuItem menuItem)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		if (menuItem == null)
		{
			throw new ArgumentException("Null argument MenuItem");
		}
		LinkModel linkModel = LinkModel.Create(ContentActionRegistry, menuItem.ActionTypeProviderId, menuItem.ActionId);
		if (!string.IsNullOrWhiteSpace(menuItem.ActionTypeProviderId))
		{
			IContentAction contentAction = ContentActionRegistry.Get(menuItem.ActionTypeProviderId, menuItem.ActionId);
			if (contentAction != null)
			{
				linkModel.Image = contentAction.GetImage(ObjectIconFormat.x16);
				linkModel.Text = contentAction.Name;
			}
		}
		MenuItemModel menuItemModel = new MenuItemModel
		{
			MenuItem = menuItem,
			Link = linkModel
		};
		IList<SelectListItem> selectList = GetSelectList(menuItemModel.MenuItem.Menu.GetTreeForEdit().TreeItems, menuItem, "");
		SelectListItem val = new SelectListItem();
		val.set_Text(SR.T("<Верхний уровень>"));
		val.set_Value("");
		selectList.Insert(0, val);
		menuItemModel.ItemsList = selectList;
		menuItemModel.ParentItemId = ((menuItem.ParentItem != null) ? new long?(menuItem.ParentItem.Id) : null);
		menuItemModel.HasChildrens = base.Manager.Exists(new MenuItemFilter
		{
			ParentItem = menuItem
		});
		return menuItemModel;
	}

	private Type GetMenuControllerType(IMenu menu)
	{
		Type menuType = menu.CastAsRealType().GetType();
		return ComponentManager.Current.GetExtensionPointTypes(typeof(IBaseController<, >)).FirstOrDefault(delegate(Type c)
		{
			Type type = c;
			while (type != null && (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(BaseMenuController<>)))
			{
				type = type.BaseType;
			}
			return type != null && menuType.IsInheritOrSame(type.GetGenericArguments()[0]);
		});
	}

	private object BuildJsonTree(IMenu menu)
	{
		Type type = GetMenuControllerType(menu);
		MethodInfo method = null;
		while (method == null && type != null)
		{
			method = type.GetMethod("CreateMenuTreeItemStatic", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			type = type.BaseType;
		}
		method = method ?? typeof(BaseMenuController<>).GetMethod("CreateMenuTreeItemStatic", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		return menu.BuildJsonTree((MenuItemNode item, int level) => (MenuTreeItem)method.Invoke(null, new object[4] { item, menu, false, level }), allowDisabled: true);
	}

	public ActionResult Delete(IMenuItem menuItem)
	{
		string message = string.Empty;
		string error = string.Empty;
		object tree = new object();
		if (menuItem != null)
		{
			try
			{
				IMenu menu = menuItem.Menu;
				MenuItemManager.Instance.DeleteItemRecursive(menuItem);
				message = SR.T("Ссылка удалена");
				tree = BuildJsonTree(menu);
			}
			catch (Exception ex)
			{
				error = SR.T("Ошибка удаления: {0}", ex.Message);
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { message, error, tree }, (JsonRequestBehavior)0);
	}

	public ActionResult Reset(IMenuItem menuItem)
	{
		string message = string.Empty;
		string error = string.Empty;
		object tree = new object();
		if (menuItem != null)
		{
			try
			{
				IMenu menu = menuItem.Menu;
				MenuInitializer.RecreateMenuItem(menuItem.Id);
				message = SR.T("Меню пересоздано");
				tree = BuildJsonTree(menu);
			}
			catch (Exception ex)
			{
				error = SR.T("Ошибка пересоздания: {0}", ex.Message);
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { message, error, tree }, (JsonRequestBehavior)0);
	}

	public ActionResult Copy(IMenuItem menuItem, IMenu[] copyToMenu)
	{
		string message = string.Empty;
		string error = string.Empty;
		if (menuItem != null)
		{
			try
			{
				MenuInitializer.CopyMenuItem(menuItem.Id, ((IEnumerable<IMenu>)copyToMenu).Select((Func<IMenu, long>)((IMenu m) => m.Id)).ToArray());
				message = SR.T("Меню скопировано");
			}
			catch (Exception ex)
			{
				error = SR.T("Ошибка копирования: {0}", ex.Message);
				base.Logger.Error("Ошибка копирования ссылки меню", ex);
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { message, error }, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public ActionResult Save(MenuItemModel model)
	{
		string error = null;
		object tree = new object();
		if (model == null || model.MenuItem == null || model.MenuItem.Menu == null)
		{
			error = SR.T("Неверные входные данные");
		}
		else
		{
			model.MenuItem.ParentItem = (model.ParentItemId.HasValue ? MenuItemManager.Instance.Load(model.ParentItemId.Value) : null);
			if (string.IsNullOrEmpty(model.Link.ActionTypeProviderId))
			{
				model.MenuItem.Type = MenuItemType.Section;
			}
			else
			{
				model.MenuItem.ActionTypeProviderId = model.Link.ActionTypeProviderId;
				model.MenuItem.ActionId = model.Link.ActionId;
				model.MenuItem.Type = MenuItemType.Action;
			}
			if (model.MenuItem.IsNew())
			{
				List<IMenuItem> source = ((IEnumerable<IMenuItem>)model.MenuItem.Menu.Items).Where((IMenuItem i) => i.ParentItem == model.MenuItem.ParentItem).ToList();
				model.MenuItem.Weight = ((!source.Any()) ? 1 : (source.Max((IMenuItem i) => i.Weight) + 1));
			}
			model.MenuItem.Save();
			tree = BuildJsonTree(model.MenuItem.Menu);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Ссылка сохранена"),
			error = error,
			tree = tree
		});
	}

	private IList<SelectListItem> GetSelectList(IEnumerable<MenuItemNode> items, IMenuItem current, string prefix, int level = 0)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		List<SelectListItem> list = new List<SelectListItem>();
		foreach (MenuItemNode item in items)
		{
			bool selected = false;
			if (current != null)
			{
				if (current.Id == item.Id)
				{
					continue;
				}
				selected = current.ParentItem != null && current.ParentItem.Id == item.Id;
			}
			SelectListItem val = new SelectListItem();
			val.set_Selected(selected);
			val.set_Text(prefix + item.Name);
			val.set_Value(item.Id.ToString(CultureInfo.InvariantCulture));
			list.Add(val);
			if (level == 0 && item.Items.Count > 0)
			{
				list.AddRange(GetSelectList(item.Items, current, prefix + "- ", level + 1));
			}
		}
		return list;
	}
}
