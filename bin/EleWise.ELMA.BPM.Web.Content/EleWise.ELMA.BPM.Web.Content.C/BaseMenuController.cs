using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Menu;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class BaseMenuController<T> : BPMController<T, int>, IBaseMenuController where T : IMenu
{
	public MenuInitializer MenuInitializer { get; set; }

	public ActionResult Create()
	{
		return (ActionResult)(object)((Controller)this).View("Menu/Create", (object)InterfaceActivator.Create<T>());
	}

	public ActionResult Edit(T menu)
	{
		return (ActionResult)(object)((Controller)this).View("Menu/Edit", (object)menu);
	}

	public ActionResult View(T menu)
	{
		return (ActionResult)(object)((Controller)this).View("Menu/View", (object)menu);
	}

	[HttpPost]
	public ActionResult Save(T menu)
	{
		menu.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = menu.Id
		});
	}

	[HttpGet]
	public ActionResult Delete(T menu)
	{
		MenuManager.Instance.Delete(menu);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			delete = true
		}, (JsonRequestBehavior)0);
	}

	public virtual ActionResult Links(T menu, bool enableEdit = false)
	{
		return ProtectedLinks(menu, enableEdit, "Menu/Links");
	}

	protected ActionResult ProtectedLinks(T menu, bool enableEdit, string viewName)
	{
		return ProtectedLinks(menu, enableEdit, viewName, customToolbar: false);
	}

	protected ActionResult ProtectedLinks(T menu, bool enableEdit, string viewName, bool customToolbar)
	{
		if (menu == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		List<MenuItemNode> treeItems = MenuModelForEdit(menu).TreeItems;
		SaveTree(menu, treeItems, null);
		string text = "LinksTree" + menu.Id;
		TreeState treeState = TreePersonalizationAdministration.LoadState(text);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = text
			};
			TreePersonalizationAdministration.SaveState(text, treeState);
		}
		IWorkPlace[] workPlaces = GetWorkPlaces(menu);
		bool readOnly = !enableEdit && workPlaces.Length > 1;
		MenuLinksModel menuLinksModel = new MenuLinksModel
		{
			Menu = menu,
			ReadOnly = readOnly,
			WorkPlaces = workPlaces,
			LinksTreeModel = new TreeModel
			{
				Id = text,
				Children = treeItems.BuildTreeNodes(treeState, (MenuItemNode item, int level) => CreateMenuTreeItem(item, menu, readOnly, level)),
				HtmlAttributes = new
				{
					style = "height:440px; border: 0px solid #FFF;"
				},
				ShowExpandCollapseButtons = true,
				OnNodeDroppedFunction = (readOnly ? null : "menuLinksDropped")
			},
			CustomToolbar = customToolbar
		};
		return (ActionResult)(object)((Controller)this).View(viewName, (object)menuLinksModel);
	}

	protected virtual IWorkPlace[] GetWorkPlaces(T menu)
	{
		return new IWorkPlace[0];
	}

	private MenuModel MenuModelForEdit(T menu)
	{
		return menu.GetTreeForEdit();
	}

	[HttpGet]
	public ActionResult NodeDrop(int menuId, string target, string destination, string position)
	{
		if (string.IsNullOrEmpty(position))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Неизвестное действие")
			}, (JsonRequestBehavior)0);
		}
		T menu = base.Manager.Load(menuId);
		List<MenuItemNode> treeItems = MenuModelForEdit(menu).TreeItems;
		SaveTree(menu, treeItems, null);
		MenuItemNode targetNode = treeItems.Find(target);
		if (targetNode == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не найдены элементы меню target" + target)
			}, (JsonRequestBehavior)0);
		}
		MenuItemNode destinationNode = treeItems.Find(destination);
		if (destinationNode == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не найдены элементы меню destinationNode")
			}, (JsonRequestBehavior)0);
		}
		IMenuItem menuItem = MenuItemManager.Instance.Load(targetNode.Id);
		IMenuItem menuItem2 = MenuItemManager.Instance.Load(destinationNode.Id);
		switch (position)
		{
		case "over":
			menuItem.ParentItem = menuItem2;
			menuItem.Weight = ((destinationNode.Items.Count > 0) ? (destinationNode.Items.Max((MenuItemNode i) => i.Weight) + 1) : 0);
			menuItem.Save();
			break;
		case "before":
		{
			menuItem.ParentItem = menuItem2.ParentItem;
			menuItem.Weight = menuItem2.Weight;
			menuItem.Save();
			List<MenuItemNode> list2 = ((destinationNode.Parent != null) ? destinationNode.Parent.Items : treeItems).Where((MenuItemNode i) => i.Weight >= destinationNode.Weight && i.Id != targetNode.Id).ToList();
			int num = menuItem.Weight + 1;
			foreach (MenuItemNode item in list2)
			{
				IMenuItem menuItem4 = MenuItemManager.Instance.Load(item.Id);
				menuItem4.Weight = num;
				menuItem4.Save();
				num++;
			}
			break;
		}
		case "after":
		{
			menuItem.ParentItem = menuItem2.ParentItem;
			menuItem.Weight = menuItem2.Weight + 1;
			menuItem.Save();
			List<MenuItemNode> list = ((destinationNode.Parent != null) ? destinationNode.Parent.Items : treeItems).Where((MenuItemNode i) => i.Weight > destinationNode.Weight && i.Id != targetNode.Id).ToList();
			int num = menuItem.Weight + 1;
			foreach (MenuItemNode item2 in list)
			{
				IMenuItem menuItem3 = MenuItemManager.Instance.Load(item2.Id);
				menuItem3.Weight = num;
				menuItem3.Save();
				num++;
			}
			break;
		}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Положение сохранено"),
			tree = menu.BuildJsonTree((MenuItemNode item, int level) => CreateMenuTreeItem(item, menu, readOnly: false, level), allowDisabled: true)
		}, (JsonRequestBehavior)0);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Menu/Grid", (object)base.Manager.CreateGridData<T, IEntityFilter, IMenu>(command));
	}

	private bool SaveTree(T menu, IEnumerable<MenuItemNode> items, IMenuItem parent)
	{
		int num = 0;
		bool flag = false;
		foreach (MenuItemNode item in items)
		{
			bool flag2 = false;
			IMenuItem menuItem = null;
			if (item.Id == 0L)
			{
				InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
				instanceOf.New.Menu = menu;
				instanceOf.New.Disabled = item.Disabled;
				instanceOf.New.ExtensionPointName = item.Code;
				instanceOf.New.Name = item.Name;
				instanceOf.New.NavigateUrl = item.NavigateUrl;
				instanceOf.New.ImageUrl = item.ImageUrl;
				instanceOf.New.ParentItem = parent;
				menuItem = instanceOf.New;
				flag = true;
				flag2 = true;
			}
			else
			{
				menuItem = MenuItemManager.Instance.Load(item.Id);
			}
			if (menuItem.Weight != num)
			{
				menuItem.Weight = num;
				flag = true;
				flag2 = true;
			}
			if (flag2)
			{
				menuItem.Save();
			}
			item.Id = menuItem.Id;
			if (item.Items.Count > 0)
			{
				bool flag3 = SaveTree(menu, item.Items, menuItem);
				flag = flag || flag3;
			}
			num++;
		}
		return flag;
	}

	public ActionResult Reset(long id)
	{
		MenuInitializer.RecreateMenuItems(id);
		IMenu menu = MenuManager.Instance.Load((int)id);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Положение сохранено"),
			tree = menu.BuildJsonTree((MenuItemNode item, int level) => CreateMenuTreeItem(item, menu, readOnly: false, level), allowDisabled: true)
		}, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public ActionResult TopMenuSubItems(string menuUid, long parentItemId)
	{
		Guid result;
		IMenu menu = (Guid.TryParse(menuUid, out result) ? MenuManager.Instance.Load(result) : MenuManager.Instance.Load(MenuManager.TopMenuUid));
		return (ActionResult)(object)((Controller)this).PartialView("Toolbar/TopMenuSubItems", (object)new MenuSubItemsModel
		{
			Menu = menu,
			ParentItemId = parentItemId
		});
	}

	public virtual ActionResult CreateNew(T menu, long workPlaceId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return (ActionResult)new EmptyResult();
	}

	protected virtual MenuTreeItem CreateMenuTreeItem(MenuItemNode item, IMenu menu, bool readOnly, int level)
	{
		return CreateMenuTreeItemStatic(item, menu, readOnly, level);
	}

	private static MenuTreeItem CreateMenuTreeItemStatic(MenuItemNode item, IMenu menu, bool readOnly, int level)
	{
		return new MenuTreeItem
		{
			id = ((item.Id > 0) ? item.Id.ToString(CultureInfo.InvariantCulture) : item.Code),
			Menu = menu,
			ReadOnly = readOnly,
			text = item.Name,
			icon = item.GetImageUrl(level switch
			{
				2 => ObjectIconFormat.x24, 
				1 => ObjectIconFormat.x32, 
				_ => ObjectIconFormat.x16, 
			})
		};
	}
}
