using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Web.Content.Menu;

public static class MenuItemExtensions
{
	[Obsolete("Use SetCurrentMenuItem and GetCurrentMenuItem instead", true)]
	public const string assigneCurrentItemKey = "EleWise.ELMA.Web.Content.Menu.MenuItemExtensions.AssignedCurrentMenuItemLevel";

	private const string _assigneCurrentItemKey = "EleWise.ELMA.Web.Content.Menu.MenuItemExtensions.AssignedCurrentMenuItemLevel";

	public static void SetCurrentMenuItem(this Controller controller, string code)
	{
		controller.SetCurrentMenuItem(code, ContentItemMatchLevel.AreaControllerPlus);
	}

	public static void SetCurrentMenuItem(this Controller controller, string code, ContentItemMatchLevel level)
	{
		List<Pair<string, ContentItemMatchLevel>> list = (((ControllerBase)controller).get_ControllerContext().get_HttpContext().Items["EleWise.ELMA.Web.Content.Menu.MenuItemExtensions.AssignedCurrentMenuItemLevel"] as List<Pair<string, ContentItemMatchLevel>>) ?? new List<Pair<string, ContentItemMatchLevel>>();
		list.Add(new Pair<string, ContentItemMatchLevel>(code, level));
		((ControllerBase)controller).get_ControllerContext().get_HttpContext().Items["EleWise.ELMA.Web.Content.Menu.MenuItemExtensions.AssignedCurrentMenuItemLevel"] = list;
	}

	public static string GetCurrentMenuItem(this HttpContextBase context)
	{
		if (context.Items["EleWise.ELMA.Web.Content.Menu.MenuItemExtensions.AssignedCurrentMenuItemLevel"] is List<Pair<string, ContentItemMatchLevel>> source)
		{
			return source.LastOrDefault().First;
		}
		return null;
	}

	[NotNull]
	public static IList<string> GetCurrentMenuItems(this HttpContextBase context)
	{
		return (from p in context.GetCurrentMenuItemsWithLevels()
			select p.First).ToArray();
	}

	public static IList<Pair<string, ContentItemMatchLevel>> GetCurrentMenuItemsWithLevels(this HttpContextBase context)
	{
		IList<Pair<string, ContentItemMatchLevel>> list = context.Items["EleWise.ELMA.Web.Content.Menu.MenuItemExtensions.AssignedCurrentMenuItemLevel"] as List<Pair<string, ContentItemMatchLevel>>;
		return list ?? new Pair<string, ContentItemMatchLevel>[0];
	}
}
