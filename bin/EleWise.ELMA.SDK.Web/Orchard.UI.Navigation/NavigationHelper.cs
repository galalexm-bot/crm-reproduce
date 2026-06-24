using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Orchard.UI.Navigation;

public static class NavigationHelper
{
	public static void PopulateMenu(dynamic shapeFactory, dynamic parentShape, dynamic menu, IEnumerable<MenuItem> menuItems)
	{
		foreach (MenuItem menuItem in menuItems)
		{
			dynamic val = NavigationHelper.BuildMenuItemShape(shapeFactory, parentShape, menu, menuItem);
			if (menuItem.Items != null && menuItem.Items.Any())
			{
				NavigationHelper.PopulateMenu(shapeFactory, val, menu, menuItem.Items);
			}
			parentShape.Add(val, menuItem.Position);
		}
	}

	public static void PopulateLocalMenu(dynamic shapeFactory, dynamic parentShape, dynamic menu, Stack<MenuItem> selectedPath)
	{
		MenuItem menuItem = FindParentLocalTask(selectedPath);
		if (menuItem != null && menuItem.Items != null && menuItem.Items.Any())
		{
			NavigationHelper.PopulateLocalMenu(shapeFactory, parentShape, menu, menuItem.Items);
		}
	}

	public static void PopulateLocalMenu(dynamic shapeFactory, dynamic parentShape, dynamic menu, IEnumerable<MenuItem> menuItems)
	{
		foreach (MenuItem menuItem in menuItems)
		{
			dynamic val = NavigationHelper.BuildLocalMenuItemShape(shapeFactory, parentShape, menu, menuItem);
			if (menuItem.Items != null && menuItem.Items.Any())
			{
				NavigationHelper.PopulateLocalMenu(shapeFactory, val, menu, menuItem.Items);
			}
			parentShape.Add(val, menuItem.Position);
		}
	}

	public static Stack<MenuItem> SetSelectedPath(IEnumerable<MenuItem> menuItems, HttpRequestBase currentRequest, RouteData currentRouteData)
	{
		return SetSelectedPath(menuItems, currentRequest, currentRouteData.Values);
	}

	public static Stack<MenuItem> SetSelectedPath(IEnumerable<MenuItem> menuItems, HttpRequestBase currentRequest, RouteValueDictionary currentRouteData)
	{
		Stack<MenuItem> stack = GetSelectedPath(menuItems, currentRequest, currentRouteData, compareUrls: false) ?? GetSelectedPath(menuItems, currentRequest, currentRouteData, compareUrls: true);
		if (stack != null)
		{
			foreach (MenuItem item in stack)
			{
				item.Selected = true;
			}
			return stack;
		}
		return stack;
	}

	private static Stack<MenuItem> GetSelectedPath(IEnumerable<MenuItem> menuItems, HttpRequestBase currentRequest, RouteValueDictionary currentRouteData, bool compareUrls)
	{
		List<Stack<MenuItem>> list = new List<Stack<MenuItem>>();
		foreach (MenuItem menuItem in menuItems)
		{
			Stack<MenuItem> selectedPath = GetSelectedPath(menuItem.Items, currentRequest, currentRouteData, compareUrls);
			if (selectedPath != null)
			{
				selectedPath.Push(menuItem);
				if (!compareUrls)
				{
					return selectedPath;
				}
				list.Add(selectedPath);
			}
			bool flag = !compareUrls && menuItem.RouteValues != null && RouteMatches(menuItem.RouteValues, currentRouteData);
			if (currentRequest != null && !flag && compareUrls)
			{
				string text = currentRequest.ApplicationPath ?? "/";
				string text2 = (currentRequest.Path.StartsWith(text) ? currentRequest.Path.Substring(text.Length) : currentRequest.Path);
				string text3 = menuItem.Href.Replace("~/", text);
				text3 = (text3.StartsWith(text) ? text3.Substring(text.Length) : text3);
				if (text2.Equals(text3, StringComparison.OrdinalIgnoreCase) || (!string.IsNullOrEmpty(text3) && text2.StartsWith(text3 + "/", StringComparison.OrdinalIgnoreCase)))
				{
					flag = true;
				}
			}
			if (flag)
			{
				selectedPath = new Stack<MenuItem>();
				selectedPath.Push(menuItem);
				if (!compareUrls)
				{
					return selectedPath;
				}
				list.Add(selectedPath);
			}
		}
		return list.OrderByDescending((Stack<MenuItem> p) => p.First().Href.Split('/').Length).FirstOrDefault();
	}

	public static MenuItem FindParentLocalTask(Stack<MenuItem> selectedPath)
	{
		if (selectedPath != null)
		{
			MenuItem menuItem = selectedPath.Pop();
			if (menuItem != null)
			{
				while (selectedPath.Count > 0)
				{
					MenuItem menuItem2 = selectedPath.Pop();
					if (menuItem2.LocalNav)
					{
						return menuItem;
					}
					menuItem = menuItem2;
				}
			}
		}
		return null;
	}

	public static bool RouteMatches(RouteValueDictionary itemValues, RouteValueDictionary requestValues)
	{
		if (itemValues == null && requestValues == null)
		{
			return true;
		}
		if (itemValues == null || requestValues == null)
		{
			return false;
		}
		if (itemValues.Keys.Any((string key) => !requestValues.ContainsKey(key)))
		{
			return false;
		}
		return itemValues.Keys.All((string key) => string.Equals(Convert.ToString(itemValues[key]), Convert.ToString(requestValues[key]), StringComparison.OrdinalIgnoreCase));
	}

	public static dynamic BuildMenuItemShape(dynamic shapeFactory, dynamic parentShape, dynamic menu, MenuItem menuItem)
	{
		dynamic val = shapeFactory.MenuItem().Text(menuItem.Text).IdHint(menuItem.IdHint)
			.Href(menuItem.Href)
			.LinkToFirstChild(menuItem.LinkToFirstChild)
			.LocalNav(menuItem.LocalNav)
			.Selected(menuItem.Selected)
			.RouteValues(menuItem.RouteValues)
			.Item(menuItem)
			.Menu(menu)
			.Parent(parentShape)
			.Content(menuItem.Content)
			.Level(menuItem.Level);
		foreach (string @class in menuItem.Classes)
		{
			val.Classes.Add(@class);
		}
		return val;
	}

	public static dynamic BuildLocalMenuItemShape(dynamic shapeFactory, dynamic parentShape, dynamic menu, MenuItem menuItem)
	{
		dynamic val = shapeFactory.LocalMenuItem().Text(menuItem.Text).IdHint(menuItem.IdHint)
			.Href(menuItem.Href)
			.LinkToFirstChild(menuItem.LinkToFirstChild)
			.LocalNav(menuItem.LocalNav)
			.Selected(menuItem.Selected)
			.RouteValues(menuItem.RouteValues)
			.Item(menuItem)
			.Menu(menu)
			.Parent(parentShape);
		foreach (string @class in menuItem.Classes)
		{
			val.Classes.Add(@class);
		}
		return val;
	}
}
