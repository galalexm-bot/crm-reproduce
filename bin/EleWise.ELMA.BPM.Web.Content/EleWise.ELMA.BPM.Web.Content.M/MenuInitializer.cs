using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Filters;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using Telerik.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

[Service(Scope = ServiceScope.Shell, EnableInterceptors = true, InjectProperties = true)]
public class MenuInitializer : IModuleEvents, IModuleContainerEvents
{
	private const string BlobStorePreviousMenuKeyFormat = "B52069DE-0E45-4459-A676-EC1749C14BA4_PreviousMenu_{0}";

	private static readonly Guid RootMenuUid = new Guid("12E57FBB-BB13-4E78-8301-F84B98EAE371");

	private Dictionary<Guid, MenuItem> _sourceMenuItems = new Dictionary<Guid, MenuItem>();

	private Dictionary<int, List<MenuItem>> _previousMenuItems = new Dictionary<int, List<MenuItem>>();

	public ILogger Logger { get; set; }

	public IContentActionRegistry ContentActionRegistry { get; set; }

	public IEnumerable<IMenuItemsProvider> MenuItemsProviders { get; set; }

	public MenuManager MenuManager { get; set; }

	public MenuItemManager MenuItemManager { get; set; }

	public ControllerActionRegistry ControllerActionRegistry { get; set; }

	public ISecurityService SecurityService { get; set; }

	public UrlActionProvider UrlActionProvider { get; set; }

	public MenuSecurity MenuSecurity { get; set; }

	public ISessionProvider SessionProvider { get; set; }

	public BlobStore BlobStore { get; set; }

	public void Installing(IWebModuleUnit module)
	{
	}

	public void Installed(IWebModuleUnit module)
	{
		CreateMenuItems();
	}

	public void Enabling(IWebModuleUnit module)
	{
	}

	public void Enabled(IWebModuleUnit module)
	{
		CreateMenuItems();
	}

	public void Disabling(IWebModuleUnit module)
	{
	}

	public void Disabled(IWebModuleUnit module)
	{
	}

	public void Uninstalling(IWebModuleUnit module)
	{
	}

	public void Uninstalled(IWebModuleUnit module)
	{
	}

	public void Activated()
	{
		CreateMenuItems();
	}

	public void Terminating()
	{
	}

	private IMenuItem GetCurrentRootMenu(IMenu menu, out IList<IMenuItem> currentMenuItems, bool readOnly = true, bool createRoot = false)
	{
		IList<IMenuItem> list2;
		if (!readOnly)
		{
			IList<IMenuItem> list = MenuItemManager.Instance.Find(new MenuItemFilter
			{
				Menu = menu
			}, null).ToList();
			list2 = list;
		}
		else
		{
			list2 = MenuItemManager.Instance.LoadItemsReadOnly(menu, allowDisabled: true);
		}
		currentMenuItems = list2;
		List<IMenuItem> menuItems = GetMenuItems(currentMenuItems);
		if (!createRoot && menuItems.Count == 0)
		{
			return null;
		}
		InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
		instanceOf.New.Uid = RootMenuUid;
		instanceOf.New.MenuUid = RootMenuUid;
		instanceOf.New.Menu = menu;
		instanceOf.New.Items = menuItems;
		IMenuItem root = instanceOf.New;
		EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)menuItems, (Action<IMenuItem>)delegate(IMenuItem i)
		{
			i.ParentItem = root;
		});
		return root;
	}

	private void ApplyMenu(IMenu menu, MenuItemTransformation transformation, Func<IMenuItem> currentRootItemFunc)
	{
		if (transformation == null || transformation.Items.Count <= 0)
		{
			return;
		}
		IMenuItem menuItem = currentRootItemFunc();
		HashSet<IMenuItem> saveItems = new HashSet<IMenuItem>();
		HashSet<IMenuItem> deleteItems = new HashSet<IMenuItem>();
		EventHandler<MenuItemTransformationBase<MenuItemTransformation, MenuItemTransformationAdd, MenuItemTransformationMove, MenuItemTransformationHide, MenuItemTransformationChange>.MenuItemWeightChanged> b = delegate(object sender, MenuItemTransformationBase<MenuItemTransformation, MenuItemTransformationAdd, MenuItemTransformationMove, MenuItemTransformationHide, MenuItemTransformationChange>.MenuItemWeightChanged changed)
		{
			saveItems.Add(changed.MenuItem);
		};
		MenuItemTransformation menuItemTransformation = new MenuItemTransformation();
		menuItemTransformation.WeightChanged = (EventHandler<MenuItemTransformationBase<MenuItemTransformation, MenuItemTransformationAdd, MenuItemTransformationMove, MenuItemTransformationHide, MenuItemTransformationChange>.MenuItemWeightChanged>)Delegate.Combine(menuItemTransformation.WeightChanged, b);
		foreach (BaseTransformation<IMenuItem, Guid> item in transformation.Items)
		{
			if (item is MenuItemTransformationAdd menuItemTransformationAdd)
			{
				IMenuItem menuItem2 = menuItemTransformationAdd.ApplyReturn(menuItem, menuItemTransformation);
				if (menuItem2 != null)
				{
					saveItems.Add(menuItem2);
				}
			}
			if (item is MenuItemTransformationMove menuItemTransformationMove)
			{
				IMenuItem menuItem3 = menuItemTransformationMove.ApplyReturn(menuItem, menuItemTransformation);
				if (menuItem3 != null)
				{
					saveItems.Add(menuItem3);
				}
			}
			if (item is MenuItemTransformationHide menuItemTransformationHide)
			{
				IMenuItem menuItem4 = menuItemTransformationHide.ApplyReturn(menuItem, menuItemTransformation);
				if (menuItem4 != null)
				{
					deleteItems.Add(menuItem4);
				}
			}
			if (item is MenuItemTransformationChange menuItemTransformationChange)
			{
				IMenuItem menuItem5 = menuItemTransformationChange.ApplyReturn(menuItem, menuItemTransformation);
				if (menuItem5 != null)
				{
					saveItems.Add(menuItem5);
				}
			}
		}
		if (menuItem.ParentItem == null)
		{
			EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)menuItem.Items, (Action<IMenuItem>)delegate(IMenuItem i)
			{
				i.ParentItem = null;
			});
		}
		deleteItems = EnumerableExtensions.SelectRecursive<IMenuItem>((IEnumerable<IMenuItem>)deleteItems, (Func<IMenuItem, IEnumerable<IMenuItem>>)((IMenuItem i) => i.Items)).ToHashSet();
		EnumerableExtensions.Each<IMenuItem>(saveItems.Where((IMenuItem i) => !deleteItems.Contains(i)), (Action<IMenuItem>)delegate(IMenuItem i)
		{
			i.Menu = menu;
			i.Save();
		});
		EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)deleteItems, (Action<IMenuItem>)delegate(IMenuItem i)
		{
			if (i.ParentItem != null)
			{
				i.ParentItem.Items.Remove(i);
				i.ParentItem = null;
			}
			if (i.Menu != null)
			{
				((ICollection<IMenuItem>)i.Menu.Items).Remove(i);
				i.Menu = null;
			}
			i.Delete();
		});
	}

	private IMenuItem RootItem(IMenu menu, List<MenuItem> allItems, bool setToSourceMenuItems, List<IMenuItem> allMenuItems = null)
	{
		InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
		instanceOf.New.Uid = RootMenuUid;
		instanceOf.New.MenuUid = RootMenuUid;
		instanceOf.New.Menu = menu;
		instanceOf.New.Items = new List<IMenuItem>();
		IMenuItem rootItem = instanceOf.New;
		List<string> menuItemCodeStack = new List<string>();
		allMenuItems = allMenuItems ?? new List<IMenuItem>();
		EnumerableExtensions.Each<MenuItem>((IEnumerable<MenuItem>)allItems, (Action<MenuItem>)delegate(MenuItem i)
		{
			CreateMenuItem(menu, rootItem, i, allItems, allMenuItems, menuItemCodeStack, setToSourceMenuItems);
		});
		return rootItem;
	}

	private List<MenuItem> GetCache(int menuId)
	{
		if (!_previousMenuItems.TryGetValue(menuId, out var value))
		{
			byte[] array = BlobStore.LoadOrNull($"B52069DE-0E45-4459-A676-EC1749C14BA4_PreviousMenu_{menuId}");
			value = (_previousMenuItems[menuId] = ((array != null) ? ClassSerializationHelper.DeserializeObjectByXml<List<MenuItem>>(array) : null));
		}
		return value;
	}

	private void SetCache(int menuId, List<MenuItem> items)
	{
		_previousMenuItems[menuId] = items;
		BlobStore.Save($"B52069DE-0E45-4459-A676-EC1749C14BA4_PreviousMenu_{menuId}", ClassSerializationHelper.SerializeObjectByXmlToBytes(items));
	}

	private void InitializeMenu(IMenu menu, string container, List<MenuItem> allItems)
	{
		MenuItemTransformation transformation = null;
		IMenuItem currentRootItem = null;
		allItems.Sort((MenuItem item1, MenuItem item2) => Comparer<Guid>.Default.Compare(item1.Uid, item2.Uid));
		List<MenuItem> cache2 = GetCache(menu.Id);
		if (cache2 != null)
		{
			IMenuItem item3 = RootItem(menu, allItems, setToSourceMenuItems: true);
			if (!cache2.SequenceEqual(allItems))
			{
				transformation = Transformation<IMenuItem, MenuItemTransformation, Guid, Guid?>.CreateTransformation(item3, RootItem(menu, cache2, setToSourceMenuItems: false));
			}
		}
		else
		{
			currentRootItem = GetCurrentRootMenu(menu, out var currentMenuItems);
			if (currentRootItem != null)
			{
				List<IMenuItem> allMenuItems = new List<IMenuItem>();
				IMenuItem item3 = RootItem(menu, allItems, setToSourceMenuItems: true, allMenuItems);
				HashSet<Guid> cache = new HashSet<Guid>();
				EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)currentMenuItems, (Action<IMenuItem>)delegate(IMenuItem i)
				{
					Guid menuUid = MenuItem.GetUid(container, i.Code, i.ActionId, i.ActionTypeProviderId, (int)i.Type, i.Name, (i.ParentItem != null) ? i.ParentItem.Code : null);
					i.MenuUid = ((!cache.Contains(menuUid) && allMenuItems.Any((IMenuItem m) => m.MenuUid == menuUid)) ? menuUid : i.Uid);
					cache.Add(i.MenuUid);
				});
				transformation = Transformation<IMenuItem, MenuItemTransformation, Guid, Guid?>.CreateTransformation(item3, currentRootItem);
				if (transformation != null)
				{
					transformation.Items.RemoveAll((BaseTransformation<IMenuItem, Guid> t) => !(t is MenuItemTransformationAdd));
				}
				else
				{
					transformation = new MenuItemTransformation();
				}
				EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)currentMenuItems, (Action<IMenuItem>)delegate(IMenuItem i)
				{
					transformation.Items.Insert(0, new MenuItemTransformationChange
					{
						Uid = i.MenuUid,
						PropertyName = "Name",
						Value = i.Name
					});
				});
			}
			else
			{
				IMenuItem item3 = RootItem(menu, allItems, setToSourceMenuItems: true);
				EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)item3.Items, (Action<IMenuItem>)delegate(IMenuItem i)
				{
					i.ParentItem = null;
				});
				SaveMenuItem(item3.Items);
			}
		}
		if (cache2 == null || transformation != null)
		{
			SetCache(menu.Id, allItems);
		}
		ApplyMenu(menu, transformation, () => currentRootItem ?? GetCurrentRootMenu(menu, out var _, readOnly: true, createRoot: true));
		if (currentRootItem != null)
		{
			EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)currentRootItem.Items, (Action<IMenuItem>)delegate(IMenuItem i)
			{
				i.ParentItem = null;
			});
		}
	}

	private void SaveMenuItem(IList<IMenuItem> items)
	{
		if (items == null)
		{
			return;
		}
		foreach (IMenuItem item in items)
		{
			item.Save();
			SaveMenuItem(item.Items);
		}
	}

	private IMenuItem CreateMenuItem(IMenu menu, IMenuItem root, MenuItem source, List<MenuItem> allItems, List<IMenuItem> allMenuItems, List<string> menuItemCodeStack, bool setToSourceMenuItems)
	{
		IMenuItem newItem = allMenuItems.Find((IMenuItem i) => i.MenuUid == source.Uid);
		if (newItem != null)
		{
			return newItem;
		}
		IContentItem contentItem = null;
		if (!string.IsNullOrWhiteSpace(source.Code))
		{
			contentItem = ContentActionRegistry.Get(source.Action.ActionTypeProviderId, source.Code);
		}
		if (contentItem == null)
		{
			contentItem = ContentActionRegistry.Get(source.Action.ActionTypeProviderId, source.Action.ActionId);
		}
		if (contentItem == null && !string.IsNullOrWhiteSpace(source.Action.ActionTypeProviderId) && setToSourceMenuItems)
		{
			throw new InvalidOperationException(SR.T("Неправильный идентификатор действия ActionTypeProviderId:{0} ActionId:{1}", source.Action.ActionTypeProviderId, source.Action.ActionId));
		}
		contentItem = contentItem ?? ContentAction.EmptyAction;
		if (setToSourceMenuItems)
		{
			_sourceMenuItems[source.Uid] = source;
		}
		string menuItemCode = GetMenuItemCode(source.Code, contentItem?.Id);
		IMenuItem menuItem = null;
		string parentCode = source.Parent.Code;
		if (!string.IsNullOrWhiteSpace(parentCode))
		{
			menuItem = allMenuItems.Find((IMenuItem i) => i.Code == parentCode && i.Menu == menu);
			if (menuItem == null)
			{
				MenuItem menuItem2 = allItems.FirstOrDefault((MenuItem i) => i.Code == parentCode && i.Container == source.Container);
				if (menuItemCodeStack.Count > 100)
				{
					throw new InvalidOperationException("Cannot initialize menu. Stack overflow: " + string.Join(" -> ", menuItemCodeStack));
				}
				List<string> list = new List<string>(menuItemCodeStack);
				list.Add(menuItemCode);
				menuItem = ((menuItem2 != null) ? CreateMenuItem(menu, root, menuItem2, allItems, allMenuItems, list, setToSourceMenuItems) : null);
			}
			if (menuItem == null)
			{
				Logger.Warn(SR.T("Не удалось найти родительский пункт меню. Код родительского элемнета \"{0}\", uid меню \"{1}\" для элемента {2}", parentCode, menu.Uid, source));
				return null;
			}
		}
		menuItem = menuItem ?? root;
		InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
		instanceOf.New.MenuUid = source.Uid;
		instanceOf.New.Menu = menu;
		instanceOf.New.Name = (string.IsNullOrWhiteSpace(source.Name) ? SR.Untitled : source.Name);
		instanceOf.New.Description = source.Description;
		instanceOf.New.ParentItem = menuItem;
		instanceOf.New.Weight = source.Weight;
		instanceOf.New.Code = source.Code;
		instanceOf.New.Target = source.Target;
		instanceOf.New.OnTop = source.OnTop;
		instanceOf.New.Stretch = source.Stretch;
		instanceOf.New.Type = (MenuItemType)source.Type;
		instanceOf.New.Color = source.Color;
		newItem = instanceOf.New;
		if (contentItem != ContentAction.EmptyAction)
		{
			newItem.ActionId = contentItem.Id;
			newItem.ActionTypeProviderId = source.Action.ActionTypeProviderId;
		}
		menuItem.Items = menuItem.Items ?? new List<IMenuItem>();
		int num = menuItem.Items.FindIndex((IMenuItem i) => i.Weight > newItem.Weight);
		if (num >= 0)
		{
			menuItem.Items.Insert(num, newItem);
		}
		else
		{
			menuItem.Items.Add(newItem);
		}
		allMenuItems.Add(newItem);
		return newItem;
	}

	private List<IMenuItem> GetMenuItems(IList<IMenuItem> allItems, IMenuItem parentItem = null)
	{
		return (from i in allItems.Where((IMenuItem i) => i.ParentItem == parentItem).Select(delegate(IMenuItem i)
			{
				i.Items = GetMenuItems(allItems, i);
				return i;
			})
			orderby i.Weight
			select i).ToList();
	}

	[Transaction]
	public virtual void CreateMenuItems()
	{
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			List<MenuItem> source = MenuItemsProviders.SelectMany(delegate(IMenuItemsProvider p)
			{
				MenuItemFactory menuItemFactory = new MenuItemFactory(ControllerActionRegistry, ContentActionRegistry, UrlActionProvider);
				p.Items(menuItemFactory);
				return menuItemFactory.AddedItems;
			}).ToList();
			List<Guid> affectedMenuUids = new List<Guid>();
			EnumerableExtensions.Each<IGrouping<string, MenuItem>>(from i in source
				group i by i.Container into g
				where g.Key != "top"
				select g, (Action<IGrouping<string, MenuItem>>)delegate(IGrouping<string, MenuItem> g)
			{
				IMenu menu = MenuManager.LoadOrNull(MenuManager.GetMenuUid(g.Key));
				if (menu != null)
				{
					InitializeMenu(menu, g.Key, g.ToList());
					affectedMenuUids.Add(menu.Uid);
				}
			});
			EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)(from i in MenuItemManager.Find(new Filter
				{
					Query = "MenuUid is null or MenuUid = Guid('Empty')"
				}, null)
				where i.MenuUid == Guid.Empty
				select i).ToList(), (Action<IMenuItem>)delegate(IMenuItem i)
			{
				i.MenuUid = i.Uid;
				i.Save();
				if (!affectedMenuUids.Contains(i.Menu.Uid))
				{
					affectedMenuUids.Add(i.Menu.Uid);
				}
			});
			foreach (Guid item in affectedMenuUids)
			{
				MenuItemManager.ResetItemsCache(item);
			}
		});
	}

	[Transaction]
	public virtual void RecreateMenuItems(long menuId)
	{
		MenuItemManager.DeleteAllItems(menuId);
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IMenu menu = MenuManager.LoadOrNull((int)menuId);
			if (menu != null)
			{
				List<MenuItem> allItems = GetCache(menu.Id);
				if (allItems != null)
				{
					InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
					instanceOf.New.Uid = RootMenuUid;
					instanceOf.New.MenuUid = RootMenuUid;
					instanceOf.New.Menu = menu;
					instanceOf.New.Items = new List<IMenuItem>();
					IMenuItem rootItem = instanceOf.New;
					List<string> menuItemCodeStack = new List<string>();
					List<IMenuItem> allMenuItems = new List<IMenuItem>();
					EnumerableExtensions.Each<MenuItem>((IEnumerable<MenuItem>)allItems, (Action<MenuItem>)delegate(MenuItem i)
					{
						CreateMenuItem(menu, rootItem, i, allItems, allMenuItems, menuItemCodeStack, setToSourceMenuItems: false);
					});
					EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)rootItem.Items, (Action<IMenuItem>)delegate(IMenuItem i)
					{
						i.ParentItem = null;
					});
					SaveMenuItem(rootItem.Items);
				}
			}
		});
	}

	[Transaction]
	public virtual void RecreateMenuItem(long id)
	{
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IMenuItem menuItem = MenuItemManager.Load(id);
			IMenu menu = menuItem.Menu;
			Guid menuUid = menuItem.MenuUid;
			IMenuItem parentItem = menuItem.ParentItem;
			int weight = menuItem.Weight;
			MenuItemManager.DeleteItemRecursive(id);
			List<MenuItem> allItems = GetCache(menu.Id);
			if (allItems != null)
			{
				InstanceOf<IMenuItem> instanceOf = new InstanceOf<IMenuItem>();
				instanceOf.New.Uid = RootMenuUid;
				instanceOf.New.MenuUid = RootMenuUid;
				instanceOf.New.Menu = menu;
				instanceOf.New.Items = new List<IMenuItem>();
				IMenuItem rootItem = instanceOf.New;
				List<string> menuItemCodeStack = new List<string>();
				List<IMenuItem> allMenuItems = new List<IMenuItem>();
				EnumerableExtensions.Each<MenuItem>((IEnumerable<MenuItem>)allItems, (Action<MenuItem>)delegate(MenuItem i)
				{
					CreateMenuItem(menu, rootItem, i, allItems, allMenuItems, menuItemCodeStack, setToSourceMenuItems: false);
				});
				IMenuItem menuItem2 = allMenuItems.FirstOrDefault((IMenuItem i) => i.MenuUid == menuUid);
				if (menuItem2 != null)
				{
					menuItem2.ParentItem = parentItem;
					menuItem2.Weight = weight;
					menuItem2.Save();
					SaveMenuItem(menuItem2.Items);
				}
			}
		});
	}

	[Transaction]
	public virtual void CopyMenuItem(long id, long[] menuIds)
	{
		if (menuIds == null || menuIds.Length == 0)
		{
			return;
		}
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IMenu[] array = (from menuId in menuIds
				select MenuManager.LoadOrNull((int)menuId) into m
				where m != null
				select m).ToArray();
			if (array.Length != 0)
			{
				IMenuItem menuItem = MenuItemManager.Load(id);
				IMenuItem parentItem = menuItem.ParentItem;
				IList<IMenuItem> currentMenuItems;
				IMenuItem currentRootMenu = GetCurrentRootMenu(menuItem.Menu, out currentMenuItems, readOnly: false);
				MenuItemTransformation transformation = new MenuItemTransformation();
				int num = menuItem.ParentItem.Items.IndexOf(menuItem);
				transformation.Items.Add(Transformation<IMenuItem, MenuItemTransformation, Guid, Guid?>.Add(menuItem.ParentItem.MenuUid, menuItem, (num > 0) ? new Guid?(menuItem.ParentItem.Items[num - 1].MenuUid) : null, (num + 1 < menuItem.ParentItem.Items.Count) ? new Guid?(menuItem.ParentItem.Items[num + 1].MenuUid) : null));
				CopyAddTransformation(transformation, menuItem);
				EnumerableExtensions.Each<IMenu>((IEnumerable<IMenu>)array, (Action<IMenu>)delegate(IMenu menu)
				{
					ApplyMenu(menu, transformation, () => GetCurrentRootMenu(menu, out var _, readOnly: false, createRoot: true));
					if (parentItem == null)
					{
						EnumerableExtensions.Each<IMenuItem>(((IEnumerable<IMenuItem>)menu.Items).Where(delegate(IMenuItem a)
						{
							Guid? guid = a.ParentItem?.Uid;
							Guid rootMenuUid = RootMenuUid;
							if (!guid.HasValue)
							{
								return false;
							}
							return !guid.HasValue || guid.GetValueOrDefault() == rootMenuUid;
						}), (Action<IMenuItem>)delegate(IMenuItem mi)
						{
							mi.ParentItem = null;
						});
						menu.Save();
					}
				});
				EnumerableExtensions.Each<IMenuItem>((IEnumerable<IMenuItem>)currentRootMenu.Items, (Action<IMenuItem>)delegate(IMenuItem i)
				{
					i.ParentItem = null;
				});
			}
		});
	}

	private void CopyAddTransformation(MenuItemTransformation transformation, IMenuItem item)
	{
		foreach (IMenuItem item2 in item.Items)
		{
			transformation.Items.Add(Transformation<IMenuItem, MenuItemTransformation, Guid, Guid?>.Add(item.MenuUid, item2));
			CopyAddTransformation(transformation, item2);
		}
	}

	public MenuItem GetSourceMenuItem(IMenuItem menuItem)
	{
		if (menuItem == null)
		{
			return null;
		}
		if (_sourceMenuItems.Count == 0)
		{
			CreateMenuItems();
		}
		_sourceMenuItems.TryGetValue(menuItem.MenuUid, out var value);
		return value;
	}

	private string GetMenuItemCode(string code, string actionId)
	{
		if (string.IsNullOrWhiteSpace(code))
		{
			return actionId;
		}
		return code;
	}
}
