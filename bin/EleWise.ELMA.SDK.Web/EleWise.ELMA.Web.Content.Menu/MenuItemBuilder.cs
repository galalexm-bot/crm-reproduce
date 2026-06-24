using System;

namespace EleWise.ELMA.Web.Content.Menu;

public class MenuItemBuilder
{
	private readonly MenuItem menuItem;

	private readonly MenuItemFactory menuItemFactory;

	public MenuItem MenuItem => menuItem;

	public MenuItemBuilder(MenuItem menuItem, MenuItemFactory menuItemFactory)
	{
		this.menuItem = menuItem;
		this.menuItemFactory = menuItemFactory;
	}

	public MenuItemBuilder Container(string container)
	{
		menuItem.Container = container;
		return this;
	}

	public MenuItemBuilder Code(string code)
	{
		menuItem.Code = code;
		return this;
	}

	public MenuItemBuilder OpenInNewTab()
	{
		menuItem.Target = "_blank";
		return this;
	}

	public MenuItemBuilder Name(string name)
	{
		menuItem.Name = name;
		return this;
	}

	public MenuItemBuilder Parent(string code)
	{
		menuItem.Parent.Code = code;
		return this;
	}

	public MenuItemBuilder Order(int weight)
	{
		menuItem.Weight = weight;
		return this;
	}

	public MenuItemBuilder Description(string description)
	{
		menuItem.Description = description;
		return this;
	}

	public MenuItemBuilder Image16(string image)
	{
		menuItem.Image16 = image;
		return this;
	}

	public MenuItemBuilder Image24(string image)
	{
		menuItem.Image24 = image;
		return this;
	}

	public MenuItemBuilder Image32(string image)
	{
		menuItem.Image32 = image;
		return this;
	}

	public MenuItemBuilder Color(string color)
	{
		menuItem.Color = color;
		return this;
	}

	public MenuItemBuilder OnTop(bool onTop)
	{
		menuItem.OnTop = onTop;
		return this;
	}

	public MenuItemBuilder Stretch(bool stretch)
	{
		menuItem.Stretch = stretch;
		return this;
	}

	public void Copy(Action<MenuItemBuilder> action)
	{
		MenuItem menuItem = this.menuItem.Clone();
		action(new MenuItemBuilder(menuItem, menuItemFactory));
		menuItemFactory.Add(menuItem);
	}
}
