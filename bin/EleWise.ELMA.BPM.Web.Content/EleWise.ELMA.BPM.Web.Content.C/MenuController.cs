using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Menu;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class MenuController : BPMController<IMenu, int>
{
	public const string MenuItemRendererPopupId = "LeftMenuPopup";

	public MenuManager MenuManager { get; set; }

	public IEnumerable<IMenuItemRenderer> MenuItemRenderer { get; set; }

	[OutputCache(VaryByParam = "culture", Location = OutputCacheLocation.ServerAndClient, Duration = int.MaxValue)]
	public ActionResult StartMenu(int id)
	{
		return (ActionResult)(object)((Controller)this).PartialView("StartMenu", (object)new StartMenuModel(MenuManager.Load(MenuManager.CreateMenuUid), WorkPlaceExtensions.GetCurrentStartMenu()));
	}

	public MvcHtmlString GetPopupContent(string code)
	{
		if (!string.IsNullOrWhiteSpace(code))
		{
			MenuItemNode node = new MenuItemNode
			{
				Code = code
			};
			IMenuItemRenderer menuItemRenderer = MenuItemRenderer.FirstOrDefault((IMenuItemRenderer r) => r.HasCustomRender(node));
			if (menuItemRenderer != null)
			{
				return menuItemRenderer.Render(GetHtmlHelper(), node);
			}
		}
		return MvcHtmlString.Empty;
	}

	public ActionResult GetStartMenuContent(int id, bool enableEdit = false)
	{
		IMenu menu = MenuManager.LoadOrNull(id);
		if (menu == null)
		{
			throw new NullReferenceException(SR.T("Не удалось загрузить меню"));
		}
		((ControllerBase)this).get_ViewData().set_Item("StartMenuForEdit", (object)enableEdit);
		return (ActionResult)(object)((Controller)this).PartialView("StartMenuContent", (object)menu.GetMenuItemsList(GetHtmlHelper()));
	}

	public ActionResult GetMobileSubMenu(string id)
	{
		IMenu leftMenuByUser = MenuManager.GetLeftMenuByUser(GetCurrentUser().Id);
		if (leftMenuByUser != null)
		{
			MenuItemNode menuItemNode = leftMenuByUser.GetTree(skipChildNonActiveItems: false, withExtension: true, allowDisabled: false, GetHtmlHelper(), allowUnnecessarySeparators: false, showActive: true, long.Parse(id)).TreeItems.FirstOrDefault();
			return (ActionResult)(object)((Controller)this).PartialView("Menu/MobileSubMenu", (object)menuItemNode);
		}
		return null;
	}

	public ActionResult GetSettingsSubMenu([JsonBinder] SettingsMenuModel[] items)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Menu/MobileSettingsMenu", (object)items);
	}
}
