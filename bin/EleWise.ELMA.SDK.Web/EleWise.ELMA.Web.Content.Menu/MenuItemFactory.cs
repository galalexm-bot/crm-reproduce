using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Web.Content.Menu;

public class MenuItemFactory
{
	private readonly ControllerActionRegistry controllerActionRegistry;

	private readonly IContentActionRegistry contentActionRegistry;

	private readonly UrlActionProvider urlActionProvider;

	[NotNull]
	private Action<MenuItemBuilder> menuItemBuilderAction = delegate
	{
	};

	private readonly List<MenuItem> addedItems = new List<MenuItem>();

	public IEnumerable<MenuItem> AddedItems => addedItems;

	public List<string> LocalizedItemsNames => new List<string> { SR.T("Разделитель") };

	public MenuItemFactory(ControllerActionRegistry controllerActionRegistry, IContentActionRegistry contentActionRegistry, UrlActionProvider urlActionProvider)
	{
		this.controllerActionRegistry = controllerActionRegistry;
		this.contentActionRegistry = contentActionRegistry;
		this.urlActionProvider = urlActionProvider;
	}

	[NotNull]
	public MenuItemBuilder Action<TController>(Expression<Action<TController>> expression) where TController : Controller
	{
		ContentAction action = controllerActionRegistry.Action(expression);
		return Create(action, "ActionsLinkTypeProvider");
	}

	[NotNull]
	[Obsolete("Use the method without iconSize")]
	public MenuItemBuilder Action<TController>(Expression<Action<TController>> expression, ObjectIconFormat iconSize) where TController : Controller
	{
		return Action(expression);
	}

	[NotNull]
	public MenuItemBuilder Action(ActionRoute actionRoute)
	{
		ContentAction action = controllerActionRegistry.Action(actionRoute);
		return Create(action, "ActionsLinkTypeProvider");
	}

	[NotNull]
	[Obsolete("Use the method without iconSize")]
	public MenuItemBuilder Action(ActionRoute actionRoute, ObjectIconFormat iconSize)
	{
		return Action(actionRoute);
	}

	[NotNull]
	private MenuItemBuilder Create(IContentAction action, string actionProviderId)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return ApplyMenuItemBuilderAction(new MenuItemBuilder(Add(new MenuItem
		{
			Action = new ContentActionReference(action.Id, actionProviderId),
			Name = action.NameForLocalization,
			Description = action.DescriptionForLocalization,
			Image16 = action.GetImage(ObjectIconFormat.x16),
			Image24 = action.GetImage(ObjectIconFormat.x24),
			Image32 = action.GetImage(ObjectIconFormat.x32),
			Weight = action.Order,
			Code = action.Id
		}), this));
	}

	public MenuItem Add(MenuItem menuItem)
	{
		addedItems.Add(menuItem);
		return menuItem;
	}

	[NotNull]
	public MenuItemBuilder Action(string actionId)
	{
		if (actionId == null)
		{
			throw new ArgumentNullException("actionId");
		}
		IContentAction contentAction = controllerActionRegistry.Get(actionId);
		if (contentAction == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось найти зарегистрированный ContetnAction по Id {0}", actionId));
		}
		return ApplyMenuItemBuilderAction(Create(contentAction, "ActionsLinkTypeProvider"));
	}

	[NotNull]
	[Obsolete("Use the method without iconSize")]
	public MenuItemBuilder Action(string actionId, ObjectIconFormat iconSize)
	{
		return Action(actionId);
	}

	[NotNull]
	public MenuItemBuilder Url(string url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IContentAction contentAction = urlActionProvider.Get(url);
		if (contentAction == null)
		{
			throw new InvalidOperationException();
		}
		return ApplyMenuItemBuilderAction(Create(contentAction, urlActionProvider.Id));
	}

	[NotNull]
	[Obsolete("Use the method without iconSize")]
	public MenuItemBuilder Url(string url, ObjectIconFormat iconSize)
	{
		return Url(url);
	}

	[NotNull]
	public MenuItemBuilder Section(string name, string code)
	{
		return ApplyMenuItemBuilderAction(new MenuItemBuilder(Add(new MenuItem
		{
			Name = name,
			Code = code,
			Type = MenuItemNodeType.Section
		}), this));
	}

	[NotNull]
	public MenuItemBuilder Separator()
	{
		return ApplyMenuItemBuilderAction(new MenuItemBuilder(Add(new MenuItem
		{
			Name = "Разделитель",
			Type = MenuItemNodeType.Separator
		}), this));
	}

	public void With(Action<MenuItemBuilder> menuItemBuilder)
	{
		if (menuItemBuilder == null)
		{
			menuItemBuilderAction = delegate
			{
			};
		}
		else
		{
			menuItemBuilderAction = menuItemBuilder;
		}
	}

	protected MenuItemBuilder ApplyMenuItemBuilderAction(MenuItemBuilder builder)
	{
		menuItemBuilderAction(builder);
		return builder;
	}
}
