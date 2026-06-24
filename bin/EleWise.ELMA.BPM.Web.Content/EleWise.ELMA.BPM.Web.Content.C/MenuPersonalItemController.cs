using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Menu;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.BPM.Web.Content.Services;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class MenuPersonalItemController : BPMController<IMenuItem, long>
{
	public MenuManager MenuManager { get; set; }

	public MenuItemManager MenuItemManager { get; set; }

	public ContentActionRegistry ContentActionRegistry { get; set; }

	public IMenuItemPersonalizationAdministration MenuItemPersonalizationAdministration { get; set; }

	public ActionResult CreatePersonalItem(int menuId, int lastItemWeight)
	{
		InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
		instanceOf.New.Menu = MenuManager.Load(menuId);
		instanceOf.New.Weight = lastItemWeight + 10;
		IMenuItem @new = instanceOf.New;
		IMenuItem orCreateMainMenuCustomGroup = MenuItemManager.GetOrCreateMainMenuCustomGroup(menuId);
		return MenuItemEdit(@new, orCreateMainMenuCustomGroup);
	}

	public ActionResult MenuItemEditByMenuUid(Guid menuItemUid, int menuId)
	{
		IMenuItem transformedStartMenuItem = GetTransformedStartMenuItem(menuItemUid, menuId);
		return MenuItemEdit(transformedStartMenuItem, transformedStartMenuItem.ParentItem);
	}

	public ActionResult MenuItemEdit(IMenuItem menuItem, IMenuItem originParent)
	{
		Contract.ArgumentNotNull(menuItem, "menuItem");
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
		menuItemModel.ParentItemId = originParent?.Id;
		if (string.IsNullOrWhiteSpace(menuItemModel.MenuItem.Color) && menuItemModel.MenuItem.ParentItem != null)
		{
			menuItemModel.MenuItem.Color = menuItemModel.MenuItem.ParentItem.Color;
		}
		if (menuItemModel.MenuItem.ImageUrl == null)
		{
			menuItemModel.MenuItem.ImageUrl = MenuExtensions.GetMenuItemImageUrl(menuItemModel.MenuItem);
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)menuItemModel);
	}

	public ActionResult DisableMenuItem(Guid menuItemUid, int menuId)
	{
		bool success = false;
		IMenuItem startMenuItem = GetStartMenuItem(menuItemUid, menuId);
		if (!string.IsNullOrWhiteSpace(startMenuItem.Code) && startMenuItem.Code.IndexOf("custom_main_menu_item_") == 0)
		{
			IMenuItem orCreateMainMenuCustomGroup = MenuItemManager.GetOrCreateMainMenuCustomGroup(menuId);
			IMenuItem transformedItem = MenuItemPersonalizationAdministration.GetTransformedItem(orCreateMainMenuCustomGroup);
			if (transformedItem.Items.RemoveAll((IMenuItem i) => i.MenuUid == menuItemUid) > 0)
			{
				MenuItemPersonalizationAdministration.SaveState(transformedItem, orCreateMainMenuCustomGroup);
				success = true;
			}
		}
		else
		{
			IMenuItem menuItem = startMenuItem.ParentItem ?? startMenuItem;
			IMenuItem transformedItem2 = MenuItemPersonalizationAdministration.GetTransformedItem(menuItem);
			IMenuItem menuItem2 = transformedItem2.Items.FirstOrDefault((IMenuItem i) => i.MenuUid == menuItemUid);
			if (menuItem2 != null)
			{
				menuItem2.Disabled = true;
				MenuItemPersonalizationAdministration.SaveState(transformedItem2, menuItem);
				success = true;
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { success }, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public ActionResult SavePersonalItem(MenuItemModel model)
	{
		IMenuItem menuItem = null;
		IMenuItem orCreateMainMenuCustomGroup = MenuItemManager.GetOrCreateMainMenuCustomGroup(model.MenuItem.Menu.Id);
		if (orCreateMainMenuCustomGroup.Id == model.ParentItemId)
		{
			menuItem = orCreateMainMenuCustomGroup;
			if (string.IsNullOrWhiteSpace(model.MenuItem.Code))
			{
				model.MenuItem.Code = "custom_main_menu_item_" + Guid.NewGuid().ToStringId();
				model.MenuItem.MenuUid = Guid.NewGuid();
				model.MenuItem.ParentItem = orCreateMainMenuCustomGroup;
			}
		}
		else if (model.ParentItemId.HasValue)
		{
			menuItem = MenuItemManager.LoadOrNull(model.ParentItemId.Value);
		}
		if (!string.IsNullOrEmpty(model.Link.ActionTypeProviderId))
		{
			model.MenuItem.ActionTypeProviderId = model.Link.ActionTypeProviderId;
			model.MenuItem.ActionId = model.Link.ActionId;
			model.MenuItem.Type = MenuItemType.Action;
		}
		IMenuItem transformedItem = MenuItemPersonalizationAdministration.GetTransformedItem(menuItem);
		transformedItem.Items.RemoveAll((IMenuItem i) => i.MenuUid == model.MenuItem.MenuUid);
		transformedItem.Items.Add(model.MenuItem);
		MenuItemPersonalizationAdministration.SaveState(transformedItem, menuItem);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true,
			message = SR.T("Ссылка сохранена")
		});
	}

	public ActionResult ChangeMenuItemOrder(Guid menuItemUid, int newOrder, int menuId)
	{
		bool success = true;
		string errorText = "";
		IMenuItem startMenuItem = GetStartMenuItem(menuItemUid, menuId);
		if (startMenuItem == null)
		{
			success = false;
			errorText = SR.T("Не удалось загрузить элемент меню {0}", menuItemUid);
		}
		else
		{
			IMenuItem transformedItem = MenuItemPersonalizationAdministration.GetTransformedItem(startMenuItem.ParentItem);
			IMenuItem menuItem = transformedItem.Items.FirstOrDefault((IMenuItem i) => i.MenuUid == menuItemUid);
			if (menuItem != null)
			{
				menuItem.Weight = newOrder - transformedItem.Weight * 100;
			}
			MenuItemPersonalizationAdministration.SaveState(transformedItem, startMenuItem.ParentItem);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { success, errorText, menuItemUid, menuId, newOrder }, (JsonRequestBehavior)0);
	}

	public ActionResult RemovePersonalSetting()
	{
		MenuItemPersonalizationAdministration.ResetState();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}

	private IMenuItem GetStartMenuItem(Guid menuItemUid, int menuId)
	{
		IMenu menu = MenuManager.LoadOrNull(menuId);
		if (menu == null)
		{
			throw new ArgumentNullException(SR.T("Не удалось загрузить меню"));
		}
		IMenuItem menuItem = MenuItemManager.LoadByMenuUid(menu, menuItemUid);
		if (menuItem == null)
		{
			IMenuItem orCreateMainMenuCustomGroup = MenuItemManager.GetOrCreateMainMenuCustomGroup(menuId);
			if (orCreateMainMenuCustomGroup != null)
			{
				menuItem = MenuItemPersonalizationAdministration.GetTransformedItem(orCreateMainMenuCustomGroup).Items.FirstOrDefault((IMenuItem i) => i.MenuUid == menuItemUid);
			}
		}
		return menuItem;
	}

	private IMenuItem GetTransformedStartMenuItem(Guid menuItemUid, int menuId)
	{
		IMenuItem startMenuItem = GetStartMenuItem(menuItemUid, menuId);
		return MenuItemPersonalizationAdministration.GetTransformedItem(startMenuItem.ParentItem ?? startMenuItem).Items.FirstOrDefault((IMenuItem i) => i.MenuUid == menuItemUid);
	}
}
