using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

public static class MenuExtensions
{
	private static MenuInitializer menuInitializer;

	private static IEnumerable<IMenuItemCountEvaluator> countEvaluatorPoints;

	private static IEnumerable<IMenuCustomItems> customItemPoints;

	private static IMenuItemPersonalizationAdministration menuItemPersonalizationAdministration;

	private static IEnumerable<IMenuItemRenderer> menuItemRenderers;

	private static Type ownerType;

	private static MethodInfo methodGetStartMenuHashCode;

	private static IContentActionRegistry _contentActionRegistry;

	private static Type OwnerType
	{
		get
		{
			Type result = ownerType ?? typeof(MenuExtensions);
			ownerType = result;
			return result;
		}
	}

	private static MethodInfo MethodGetStartMenuHashCode
	{
		get
		{
			MethodInfo result = methodGetStartMenuHashCode ?? OwnerType.GetMethod("GetStartMenuHashCode");
			methodGetStartMenuHashCode = result;
			return result;
		}
	}

	private static IContentActionRegistry ContentActionRegistry => _contentActionRegistry ?? (_contentActionRegistry = Locator.GetServiceNotNull<IContentActionRegistry>());

	private static MenuInitializer MenuInitializer => menuInitializer ?? (menuInitializer = Locator.GetServiceNotNull<MenuInitializer>());

	private static IEnumerable<IMenuItemCountEvaluator> CountEvaluatorPoints => countEvaluatorPoints ?? (countEvaluatorPoints = ComponentManager.Current.GetExtensionPoints<IMenuItemCountEvaluator>());

	private static IEnumerable<IMenuCustomItems> CustomItemPoints => customItemPoints ?? (customItemPoints = ComponentManager.Current.GetExtensionPoints<IMenuCustomItems>());

	private static IMenuItemPersonalizationAdministration MenuItemPersonalizationAdministration => menuItemPersonalizationAdministration ?? (menuItemPersonalizationAdministration = Locator.GetServiceNotNull<IMenuItemPersonalizationAdministration>());

	private static IEnumerable<IMenuItemRenderer> MenuItemRenderers => menuItemRenderers ?? (menuItemRenderers = ComponentManager.Current.GetExtensionPoints<IMenuItemRenderer>());

	public static MvcHtmlString RenderMenu(this HtmlHelper html, Guid menuUid, string template)
	{
		if (menuUid == Guid.Empty || string.IsNullOrEmpty(template))
		{
			return MvcHtmlString.Create(SR.T("Не заданы параметры menuUid или template!"));
		}
		MenuModel menuModel = html.GetMenuModel(menuUid, throwIfNotFound: true);
		return PartialExtensions.Partial(html, template, (object)menuModel);
	}

	public static MenuModel GetMenuModel(this HtmlHelper html, Guid menuUid)
	{
		return html.GetMenuModel(menuUid, throwIfNotFound: false);
	}

	public static MenuModel GetMenuModel(this HtmlHelper html, Guid menuUid, bool throwIfNotFound)
	{
		return html.GetMenuModel(menuUid, throwIfNotFound, skipChildNonActiveItems: false);
	}

	public static MenuModel GetMenuModel(this HtmlHelper html, Guid menuUid, bool throwIfNotFound, bool skipChildNonActiveItems)
	{
		IMenu menu = null;
		if (menuUid == MenuManager.LeftMenuUid)
		{
			menu = WorkPlaceExtensions.GetCurrentLeftMenu();
		}
		menu = menu ?? MenuManager.Instance.Load(menuUid);
		if (menu == null)
		{
			if (throwIfNotFound)
			{
				throw new InvalidOperationException(SR.T("Не найдено меню с идентификатором '{0}'", menuUid));
			}
			return null;
		}
		return menu.GetTree(skipChildNonActiveItems, withExtension: true, allowDisabled: false, html);
	}

	public static IEnumerable<MenuItemNode> GetMenuItemsList(this IMenu menu, HtmlHelper html)
	{
		Dictionary<string, Func<bool>> nodesCheckAvailability = new Dictionary<string, Func<bool>>();
		List<IMenuItemRenderer> customRenderers = MenuItemRenderers.ToList();
		List<MenuItemNode> list = new List<MenuItemNode>();
		foreach (IMenuItem item in from i in MenuItemManager.Instance.Find((IMenuItem i) => i.Menu == menu)
			where i.ParentItem == null
			select i)
		{
			IMenuItem transformedItem = MenuItemPersonalizationAdministration.GetTransformedItem(item);
			if (transformedItem.Items == null || !transformedItem.Items.Any())
			{
				continue;
			}
			foreach (IMenuItem item2 in transformedItem.Items)
			{
				item2.Menu = menu;
				Tuple<MenuItemNode, IContentAction> tuple = MenuItemToNode(item2, allowDisabled: false, html, nodesCheckAvailability, customRenderers);
				if (tuple != null && tuple.Item1 != null)
				{
					tuple.Item1.Weight += transformedItem.Weight * 100;
					list.Add(tuple.Item1);
				}
			}
		}
		Dictionary<string, bool> nodesAvailability = new Dictionary<string, bool>();
		Func<MenuItemNode, bool> isNodeAvailableFunc = delegate(MenuItemNode node)
		{
			if (string.IsNullOrEmpty(node.Code))
			{
				return true;
			}
			if (nodesAvailability.TryGetValue(node.Code, out var value))
			{
				return value;
			}
			value = !nodesCheckAvailability.TryGetValue(node.Code, out var value2) || value2();
			nodesAvailability[node.Code] = value;
			return value;
		};
		RemoveUnavailableItems(list, isNodeAvailableFunc, skipChildNonActiveItems: false);
		return list.OrderBy((MenuItemNode i) => i.Weight);
	}

	public static MenuModel GetTree(this HtmlHelper html, IMenu menu, bool withExtension = true, bool allowDisabled = false)
	{
		return menu.GetTree(withExtension, allowDisabled, html);
	}

	public static string GetMenuItemImageUrl(IMenuItem menuItem, ObjectIconFormat iconFormat = ObjectIconFormat.x16)
	{
		string imageUrl = menuItem.ImageUrl;
		string text = "";
		string text2 = "";
		string text3 = "";
		if (menuItem.ActionTypeProviderId != null && menuItem.ActionId != null)
		{
			IContentAction contentAction = ContentActionRegistry.Get(menuItem.ActionTypeProviderId, menuItem.ActionId);
			if (contentAction != null)
			{
				text = contentAction.GetImage(ObjectIconFormat.x16);
				text2 = contentAction.GetImage(ObjectIconFormat.x24);
				text3 = contentAction.GetImage(ObjectIconFormat.x32);
			}
		}
		if (!string.IsNullOrEmpty(menuItem.Code))
		{
			MenuItem sourceMenuItem = MenuInitializer.GetSourceMenuItem(menuItem);
			if (sourceMenuItem != null)
			{
				if (!string.IsNullOrEmpty(sourceMenuItem.Image16))
				{
					text = sourceMenuItem.Image16;
				}
				if (!string.IsNullOrEmpty(sourceMenuItem.Image24))
				{
					text2 = sourceMenuItem.Image24;
				}
				if (!string.IsNullOrEmpty(sourceMenuItem.Image32))
				{
					text3 = sourceMenuItem.Image32;
				}
			}
		}
		switch (iconFormat)
		{
		case ObjectIconFormat.x24:
			if (string.IsNullOrEmpty(imageUrl))
			{
				if (string.IsNullOrEmpty(text2))
				{
					if (string.IsNullOrEmpty(text))
					{
						return text3;
					}
					return text;
				}
				return text2;
			}
			return imageUrl;
		case ObjectIconFormat.x32:
			if (string.IsNullOrEmpty(imageUrl))
			{
				if (string.IsNullOrEmpty(text3))
				{
					if (string.IsNullOrEmpty(text2))
					{
						return text;
					}
					return text2;
				}
				return text3;
			}
			return imageUrl;
		default:
			if (string.IsNullOrEmpty(imageUrl))
			{
				if (string.IsNullOrEmpty(text))
				{
					if (string.IsNullOrEmpty(text2))
					{
						return text3;
					}
					return text2;
				}
				return text;
			}
			return imageUrl;
		}
	}

	private static MenuModel GetTree(ICollection<IMenuItem> menuItems, IEnumerable<IMenuItemRenderer> customRenderers, bool allowDisabled, bool skipChildNonActiveItems, HtmlHelper html = null, bool allowUnnecessarySeparators = false, bool showActive = true, long? parentItemId = null)
	{
		MenuModel model = new MenuModel();
		Dictionary<string, Func<bool>> nodesCheckAvailability = new Dictionary<string, Func<bool>>();
		Dictionary<string, bool> nodesAvailability = new Dictionary<string, bool>();
		Func<MenuItemNode, bool> func = delegate(MenuItemNode node)
		{
			if (string.IsNullOrEmpty(node.Code))
			{
				return true;
			}
			if (nodesAvailability.TryGetValue(node.Code, out var value3))
			{
				return value3;
			}
			value3 = !nodesCheckAvailability.TryGetValue(node.Code, out var value4) || value4();
			nodesAvailability[node.Code] = value3;
			return value3;
		};
		List<Tuple<MenuItemNode, IContentAction>> allNode = GetAllNode(menuItems, allowDisabled, nodesCheckAvailability, html, customRenderers);
		AddCodeToDuplicates(allNode);
		Dictionary<long, MenuItemNode> dictionary = allNode.ToDictionary((Tuple<MenuItemNode, IContentAction> v) => v.Item1.Id, (Tuple<MenuItemNode, IContentAction> v) => v.Item1);
		foreach (IMenuItem menuItem in menuItems)
		{
			if (dictionary.TryGetValue(menuItem.Id, out var value))
			{
				MenuItemNode value2;
				if ((!parentItemId.HasValue && !value.ParentItemId.HasValue) || (parentItemId.HasValue && value.Id == parentItemId.Value))
				{
					model.TreeItems.Add(value);
				}
				else if (value.ParentItemId.HasValue && dictionary.TryGetValue(value.ParentItemId.Value, out value2) && value2 != null)
				{
					value.Parent = value2;
					value2.Items.Add(value);
				}
			}
		}
		if (showActive)
		{
			if (html != null)
			{
				IList<string> list = (from i in ((ControllerContext)html.get_ViewContext()).get_HttpContext().GetCurrentMenuItemsWithLevels()
					select i.First).ToArray();
				ContentItemMatchLevel[] array = (from i in ((ControllerContext)html.get_ViewContext()).get_HttpContext().GetCurrentMenuItemsWithLevels()
					select i.Second).ToArray();
				List<Pair<MenuItemNode, double>> list2 = new List<Pair<MenuItemNode, double>>();
				for (int j = 0; j < allNode.Count; j++)
				{
					Tuple<MenuItemNode, IContentAction> tuple = allNode[j];
					int num;
					double num2 = (((num = list.IndexOf(tuple.Item1.Code)) >= 0) ? ((double)array[num] + (double)num * 0.0001) : ((tuple.Item2 != null) ? ((double)tuple.Item2.MatchCurrent(((ControllerContext)html.get_ViewContext()).get_RequestContext())) : 0.0));
					if (num2 > 0.0)
					{
						list2.Add(new Pair<MenuItemNode, double>(tuple.Item1, num2));
					}
				}
				IEnumerable<MenuItemNode> source = from v in list2
					orderby 0.0 - v.Second
					select v.First;
				if (source.Count() > 1)
				{
					source = source.Where(func).ToArray();
				}
				MenuItemNode menuItemNode = source.FirstOrDefault();
				if (menuItemNode != null)
				{
					MenuItemNode[] array2 = menuItemNode.GenerateSequense((MenuItemNode c) => c.Parent, (MenuItemNode c) => c != null).ToArray();
					array2.ForEach(delegate(MenuItemNode i)
					{
						i.IsActive = true;
					});
					if (array2.Any((MenuItemNode i) => i.IsHome))
					{
						model.IsHomeActive = true;
					}
					model.ActiveItems.AddRange(array2);
				}
			}
			Visit(model.TreeItems, delegate(MenuItemNode item)
			{
				if (item.IsActive && item.Stretch)
				{
					model.FullScreen = true;
				}
				if (item.IsActive && item.OnTop)
				{
					item.GenerateSequense((MenuItemNode c) => c.Parent, (MenuItemNode c) => c != null).ForEach(delegate(MenuItemNode i)
					{
						i.OnTop = true;
					});
				}
			});
		}
		RemoveUnavailableItems(model.TreeItems, func, skipChildNonActiveItems);
		if (!allowUnnecessarySeparators)
		{
			Action<List<MenuItemNode>> removeUnnecessarySeparators = delegate(List<MenuItemNode> l)
			{
				List<MenuItemNode> list3 = l.Where(delegate(MenuItemNode item, int idx)
				{
					if (idx == 0)
					{
						return true;
					}
					return (item.Type != MenuItemNodeType.Separator || l[idx - 1].Type != MenuItemNodeType.Separator) ? true : false;
				}).ToList();
				if (list3.Count > 0 && list3[0].Type == MenuItemNodeType.Separator)
				{
					list3.RemoveAt(0);
				}
				if (list3.Count > 0 && list3[list3.Count - 1].Type == MenuItemNodeType.Separator)
				{
					list3.RemoveAt(list3.Count - 1);
				}
				if (list3.Count < l.Count)
				{
					l.Clear();
					l.AddRange(list3);
				}
			};
			Visit(model.TreeItems, delegate(MenuItemNode item)
			{
				removeUnnecessarySeparators(item.Items);
			});
		}
		Visit(model.TreeItems, delegate(MenuItemNode item)
		{
			if (item.Type == MenuItemNodeType.Section || string.IsNullOrWhiteSpace(item.NavigateUrl))
			{
				item.NavigateUrl = item.Items.Select((MenuItemNode i) => i.NavigateUrl).FirstOrDefault((string u) => !string.IsNullOrWhiteSpace(u));
			}
			if (!allowDisabled && item.Type == MenuItemNodeType.Section && item.Items.Count == 0)
			{
				if (item.Parent != null)
				{
					item.Parent.Items.Remove(item);
				}
				else
				{
					model.TreeItems.Remove(item);
				}
			}
		});
		return model;
	}

	private static List<Tuple<MenuItemNode, IContentAction>> GetAllNode(ICollection<IMenuItem> menuItems, bool allowDisabled, Dictionary<string, Func<bool>> nodesCheckAvailability, HtmlHelper html, IEnumerable<IMenuItemRenderer> customRenderers)
	{
		return (from item in menuItems
			select MenuItemToNode(item, allowDisabled, html, nodesCheckAvailability, customRenderers) into i
			where i != null
			select i).ToList();
	}

	private static Tuple<MenuItemNode, IContentAction> MenuItemToNode(IMenuItem item, bool allowDisabled, HtmlHelper html, Dictionary<string, Func<bool>> nodesCheckAvailability, IEnumerable<IMenuItemRenderer> customRenderers)
	{
		MenuItemNode node = new MenuItemNode
		{
			Id = item.Id,
			MenuUid = item.MenuUid,
			MenuId = item.Menu.Id,
			ParentItemId = ((item.ParentItem != null) ? new long?(item.ParentItem.Id) : null),
			ParentItemName = ((item.ParentItem != null) ? item.ParentItem.Name : ""),
			Name = SR.T(item.Name),
			Code = item.Code,
			Target = item.Target,
			Description = SR.T(item.Description),
			ImageUrl = item.ImageUrl,
			NavigateUrl = item.NavigateUrl,
			Disabled = item.Disabled,
			Weight = item.Weight,
			OnTop = item.OnTop,
			Stretch = item.Stretch,
			Items = new List<MenuItemNode>(),
			Type = (MenuItemNodeType)item.Type,
			Color = ((!string.IsNullOrWhiteSpace(item.Color)) ? item.Color : ((item.ParentItem != null) ? item.ParentItem.Color : ""))
		};
		IContentAction contentItem = null;
		if (!string.IsNullOrWhiteSpace(item.ActionTypeProviderId))
		{
			contentItem = ContentActionRegistry.Get(item.ActionTypeProviderId, item.ActionId);
			if (!allowDisabled && !string.IsNullOrWhiteSpace(item.ActionTypeProviderId) && !string.IsNullOrWhiteSpace(item.ActionId) && contentItem == null)
			{
				return null;
			}
			if (contentItem != null)
			{
				if (string.IsNullOrWhiteSpace(node.Code))
				{
					node.Code = contentItem.Id;
				}
				nodesCheckAvailability[node.Code] = () => html == null || contentItem.IsAvalilable(((ControllerContext)html.get_ViewContext()).get_RequestContext());
				node.NavigateUrl = ((html != null) ? contentItem.GetHref(((ControllerContext)html.get_ViewContext()).get_RequestContext()) : null);
				node.OnRender = contentItem.OnRender;
				if (!allowDisabled)
				{
					contentItem.OnRender(html);
				}
				node.Image16Url = contentItem.GetImage(ObjectIconFormat.x16);
				node.Image24Url = contentItem.GetImage(ObjectIconFormat.x24);
				node.Image32Url = contentItem.GetImage(ObjectIconFormat.x32);
			}
		}
		if (!allowDisabled && node.Disabled)
		{
			return null;
		}
		if (!string.IsNullOrEmpty(item.Code))
		{
			MenuItem sourceMenuItem = MenuInitializer.GetSourceMenuItem(item);
			if (sourceMenuItem != null)
			{
				if (!string.IsNullOrEmpty(sourceMenuItem.Image16))
				{
					node.Image16Url = sourceMenuItem.Image16;
				}
				if (!string.IsNullOrEmpty(sourceMenuItem.Image24))
				{
					node.Image24Url = sourceMenuItem.Image24;
				}
				if (!string.IsNullOrEmpty(sourceMenuItem.Image32))
				{
					node.Image32Url = sourceMenuItem.Image32;
				}
			}
		}
		if (string.IsNullOrEmpty(node.ImageUrl) && string.IsNullOrEmpty(node.Image16Url) && string.IsNullOrEmpty(node.Image24Url) && string.IsNullOrEmpty(node.Image32Url) && contentItem != null)
		{
			node.ImageUrl = contentItem.GetImage(ObjectIconFormat.x16);
		}
		IMenuItemRenderer customRenderer = customRenderers.FirstOrDefault((IMenuItemRenderer r) => r.HasCustomRender(node));
		if (customRenderer != null)
		{
			node.Template = (HtmlHelper helper) => customRenderer.Render(helper, node);
		}
		IMenuItemCountEvaluator countEvaluator = CountEvaluatorPoints.FirstOrDefault((IMenuItemCountEvaluator r) => r.HasCountEvaluator(node));
		if (countEvaluator != null)
		{
			node.CountEvaluator = (HtmlHelper helper) => countEvaluator.Evaluate(node);
		}
		IMenuCustomItems menuCustomItems = CustomItemPoints.FirstOrDefault((IMenuCustomItems r) => r.HasCustomItems(node));
		if (menuCustomItems != null)
		{
			node.CustomItems = menuCustomItems;
		}
		node.IsHome = node.Code == "home";
		return new Tuple<MenuItemNode, IContentAction>(node, contentItem);
	}

	private static void RemoveUnavailableItems(List<MenuItemNode> nodes, Func<MenuItemNode, bool> isNodeAvailableFunc, bool skipChildNonActiveItems)
	{
		foreach (MenuItemNode item in nodes.ToList())
		{
			if (!isNodeAvailableFunc(item))
			{
				nodes.Remove(item);
				continue;
			}
			if (skipChildNonActiveItems && !item.IsActive)
			{
				MenuItemNode menuItemNode = item.Items.FirstOrDefault((MenuItemNode i) => isNodeAvailableFunc(i) && !string.IsNullOrWhiteSpace(i.NavigateUrl));
				if (menuItemNode == null && item.Items.Count > 0)
				{
					menuItemNode = item.Items.FirstOrDefault(isNodeAvailableFunc);
				}
				item.Items.Clear();
				if (menuItemNode != null)
				{
					item.Items.Add(menuItemNode);
					if (!string.IsNullOrEmpty(menuItemNode.NavigateUrl))
					{
						continue;
					}
				}
			}
			RemoveUnavailableItems(item.Items, isNodeAvailableFunc, skipChildNonActiveItems);
		}
	}

	private static void AddCodeToDuplicates(IEnumerable<Tuple<MenuItemNode, IContentAction>> allNodes)
	{
		foreach (IGrouping<string, Tuple<MenuItemNode, IContentAction>> item2 in from x in allNodes
			where !string.IsNullOrEmpty(x.Item1.NavigateUrl)
			group x by x.Item1.NavigateUrl into g
			where g.Count() > 1 && !g.Key.Contains("activeMenuItemCode=")
			select g)
		{
			foreach (Tuple<MenuItemNode, IContentAction> item3 in item2)
			{
				string text = (item3.Item1.NavigateUrl.Contains("?") ? "&" : "?");
				MenuItemNode item = item3.Item1;
				item.NavigateUrl = item.NavigateUrl + text + "activeMenuItemCode=" + item3.Item1.Code;
			}
		}
	}

	public static void Visit(IEnumerable<MenuItemNode> nodes, Action<MenuItemNode> action)
	{
		MenuItemNode head = new MenuItemNode();
		(from i in head.AsBreadthFirstEnumerable((MenuItemNode item) => (!object.Equals(item, head)) ? item.Items : nodes).Reverse()
			where !object.Equals(i, head)
			select i).ForEach(action);
	}

	public static string GetGashCodeString(this MenuModel model)
	{
		HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
		Visit(model.TreeItems, delegate(MenuItemNode node)
		{
			hashCodeCombiner.AddInt(node.GetHashCode());
		});
		return hashCodeCombiner.CombinedHashString;
	}

	public static MenuModel GetTree(this IMenu menu, bool withExtension = true, bool allowDisabled = false, HtmlHelper html = null, bool allowUnnecessarySeparators = false, bool showActive = true, long? parentItemId = null)
	{
		return menu.GetTree(skipChildNonActiveItems: false, withExtension, allowDisabled, html, allowUnnecessarySeparators, showActive, parentItemId);
	}

	public static MenuModel GetTree(this IMenu menu, bool skipChildNonActiveItems, bool withExtension = true, bool allowDisabled = false, HtmlHelper html = null, bool allowUnnecessarySeparators = false, bool showActive = true, long? parentItemId = null)
	{
		return Locator.GetServiceNotNull<IContextBoundVariableService>().GetOrAdd($"GetTree({menu.Id}, {skipChildNonActiveItems}, {withExtension}, {allowDisabled}, {html != null}, {allowUnnecessarySeparators}, {showActive}, {parentItemId})", delegate
		{
			IList<IMenuItem> menuItems = MenuItemManager.Instance.LoadItemsReadOnly(menu, allowDisabled);
			List<IMenuItemRenderer> customRenderers = (withExtension ? MenuItemRenderers.ToList() : new List<IMenuItemRenderer>());
			if (html != null)
			{
				((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Items["ContentActionAvalilableSender"] = menu;
			}
			MenuModel tree = GetTree(menuItems, customRenderers, allowDisabled, skipChildNonActiveItems, html, allowUnnecessarySeparators, showActive, parentItemId);
			if (html != null)
			{
				((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Items.Remove("ContentActionAvalilableSender");
			}
			tree.Name = menu.Name;
			tree.MenuUid = menu.Uid.ToString();
			return tree;
		});
	}

	public static MenuModel GetTreeForEdit(this IMenu menu)
	{
		return menu.GetTree(withExtension: true, allowDisabled: true, null, allowUnnecessarySeparators: true, showActive: false);
	}

	public static object BuildJson(this IEnumerable<MenuItemNode> items, IMenu menu, TreeState treeState)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		UrlHelper url = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
		List<MenuItemNode> list = items.ToList();
		object[] array = new object[list.Count()];
		for (int i = 0; i < list.Count(); i++)
		{
			MenuItemNode menuItemNode = list[i];
			MenuTreeItem menuTreeItem = new MenuTreeItem
			{
				id = ((menuItemNode.Id > 0) ? menuItemNode.Id.ToString(CultureInfo.InvariantCulture) : menuItemNode.Code),
				Menu = menu,
				text = menuItemNode.Name,
				icon = menuItemNode.GetImageUrl(ObjectIconFormat.x16)
			};
			array[i] = new
			{
				Text = menuTreeItem.GetEncodedText(),
				ImageUrl = ((!string.IsNullOrEmpty(menuTreeItem.icon)) ? url.Image(menuTreeItem.icon) : null),
				Value = menuTreeItem.id,
				Expanded = (treeState?[menuTreeItem.id] ?? false),
				Items = list[i].Items.BuildJson(menu, treeState)
			};
		}
		return array;
	}

	public static object BuildJsonTree(this IMenu menu, bool allowDisabled = false)
	{
		if (menu == null)
		{
			return null;
		}
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
		List<MenuItemNode> treeItems = menu.GetTree(withExtension: true, allowDisabled, null, allowUnnecessarySeparators: false, showActive: true, null).TreeItems;
		return new TreeModel
		{
			Id = text,
			Children = treeItems.BuildTreeNodes(menu, treeState)
		}.ToTreeViewItemList();
	}

	public static object BuildJsonTree(this IMenu menu, Func<MenuItemNode, int, MenuTreeItem> nodeCreator, bool allowDisabled = false)
	{
		if (menu == null)
		{
			return null;
		}
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
		List<MenuItemNode> treeItems = menu.GetTree(withExtension: true, allowDisabled, null, allowUnnecessarySeparators: false, showActive: true, null).TreeItems;
		return new TreeModel
		{
			Id = text,
			Children = treeItems.BuildTreeNodes(treeState, nodeCreator)
		}.ToTreeViewItemList();
	}

	public static List<TreeMenuNode> BuildTreeNodes(this IEnumerable<MenuItemNode> items, IMenu menu, TreeState treeState)
	{
		return items.BuildTreeNodes(menu, treeState, readOnly: false);
	}

	public static List<TreeMenuNode> BuildTreeNodes(this IEnumerable<MenuItemNode> items, IMenu menu, TreeState treeState, bool readOnly)
	{
		return items.BuildTreeNodes(treeState, (MenuItemNode item, int level) => new MenuTreeItem
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
		});
	}

	public static List<TreeMenuNode> BuildTreeNodes(this IEnumerable<MenuItemNode> items, TreeState treeState, Func<MenuItemNode, int, MenuTreeItem> nodeCreator)
	{
		return items.BuildTreeNodes(treeState, 1, nodeCreator);
	}

	private static List<TreeMenuNode> BuildTreeNodes(this IEnumerable<MenuItemNode> items, TreeState treeState, int level, Func<MenuItemNode, int, MenuTreeItem> nodeCreator)
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		foreach (MenuItemNode item in items)
		{
			MenuTreeItem menuTreeItem = nodeCreator(item, level);
			if (treeState != null)
			{
				menuTreeItem.expanded = treeState[menuTreeItem.id];
			}
			if (item.Items.Count > 0)
			{
				menuTreeItem.children = item.Items.BuildTreeNodes(treeState, level + 1, nodeCreator);
			}
			list.Add(menuTreeItem);
		}
		return list;
	}

	public static MenuItemNode Find(this IEnumerable<MenuItemNode> items, string stringId)
	{
		if (!long.TryParse(stringId, out var longId))
		{
			longId = 0L;
		}
		MenuItemNode[] source = (items as MenuItemNode[]) ?? items.ToArray();
		MenuItemNode menuItemNode = source.FirstOrDefault((MenuItemNode i) => (longId <= 0) ? (i.Code == stringId) : (i.Id == longId));
		if (menuItemNode == null)
		{
			foreach (MenuItemNode item in source.Where((MenuItemNode node) => node.Items.Count > 0))
			{
				menuItemNode = item.Items.Find(stringId);
				if (menuItemNode != null)
				{
					return menuItemNode;
				}
			}
			return menuItemNode;
		}
		return menuItemNode;
	}

	public static int GetStartMenuHashCode(this HtmlHelper html)
	{
		int result = 0;
		DiagnosticsManager.StartCall(delegate
		{
			Type type = OwnerType;
			MethodInfo method = MethodGetStartMenuHashCode;
			object[] arguments = (object[])(object)new HtmlHelper[1] { html };
			return new MethodCallInfo(type, method, arguments);
		}, delegate
		{
			Dictionary<string, bool> nodesAvailability = new Dictionary<string, bool>();
			HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
			hashCodeCombiner.AddObject(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true).Id);
			IMenu menu = MenuManager.Instance.LoadOrNullReadOnly(MenuManager.CreateMenuUid);
			hashCodeCombiner.AddDateTime(menu.ItemsChangeDate);
			hashCodeCombiner.AddEnumerable(GetMenuAvalilableItemCodes(html, menu, nodesAvailability));
			IMenu currentStartMenuReadOnly = WorkPlaceExtensions.GetCurrentStartMenuReadOnly();
			hashCodeCombiner.AddDateTime(currentStartMenuReadOnly.ItemsChangeDate);
			hashCodeCombiner.AddEnumerable(GetMenuAvalilableItemCodes(html, currentStartMenuReadOnly, nodesAvailability));
			hashCodeCombiner.AddObject(SR.GetCurrentCulture());
			result = hashCodeCombiner.CombinedHash32;
		});
		return result;
	}

	private static IEnumerable<string> GetMenuAvalilableItemCodes(HtmlHelper html, IMenu menu, Dictionary<string, bool> nodesAvailability)
	{
		((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Items["ContentActionAvalilableSender"] = menu;
		string[] result = (from item in MenuItemManager.Instance.LoadItemsReadOnly(menu, allowDisabled: true).Where(delegate(IMenuItem item)
			{
				if (item.Disabled)
				{
					return false;
				}
				if (string.IsNullOrWhiteSpace(item.ActionTypeProviderId) || string.IsNullOrEmpty(item.Code))
				{
					return true;
				}
				if (!nodesAvailability.TryGetValue(item.Code, out var value))
				{
					IContentAction contentAction = ContentActionRegistry.Get(item.ActionTypeProviderId, item.ActionId);
					if (!string.IsNullOrWhiteSpace(item.ActionId) && contentAction == null)
					{
						return false;
					}
					if (contentAction != null)
					{
						value = (nodesAvailability[item.Code] = contentAction.IsAvalilable(((ControllerContext)html.get_ViewContext()).get_RequestContext()));
					}
				}
				return value;
			})
			select item.Code).ToArray();
		((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Items.Remove("ContentActionAvalilableSender");
		return result;
	}
}
