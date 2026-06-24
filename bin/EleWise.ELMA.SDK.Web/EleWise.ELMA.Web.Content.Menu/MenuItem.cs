using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Web.Content.Menu;

[Serializable]
public class MenuItem
{
	private Guid? uid;

	private MenuItemParentReference parent;

	public Guid Uid
	{
		get
		{
			Guid? guid = (uid = uid ?? GetUid(Container, Code, (Action != null) ? Action.ActionId : null, (Action != null) ? Action.ActionTypeProviderId : null, (int)Type, Name, (Parent != null) ? Parent.Code : null));
			return guid.Value;
		}
		set
		{
			uid = value;
		}
	}

	public string Container { get; set; }

	public string Code { get; set; }

	public string Target { get; set; }

	public string Name { get; set; }

	public int Weight { get; set; }

	public ContentActionReference Action { get; set; }

	public MenuItemParentReference Parent
	{
		get
		{
			return parent ?? (parent = new MenuItemParentReference());
		}
		set
		{
			parent = value;
		}
	}

	public string Description { get; set; }

	public string Image16 { get; set; }

	public string Image24 { get; set; }

	public string Image32 { get; set; }

	public bool OnTop { get; set; }

	public bool Stretch { get; set; }

	public MenuItemNodeType Type { get; set; }

	public string Color { get; set; }

	public MenuItem()
	{
		Action = new ContentActionReference("", "");
		Parent = new MenuItemParentReference();
		Weight = 100;
	}

	public static Guid GetUid(string container, string code, string actionId, string actionTypeProviderId, int type, string name, string parent)
	{
		if (string.IsNullOrWhiteSpace(code))
		{
			IContentActionRegistry serviceNotNull = Locator.GetServiceNotNull<IContentActionRegistry>();
			IContentAction contentAction = ((!string.IsNullOrWhiteSpace(actionId)) ? serviceNotNull.Get(actionTypeProviderId, actionId) : null);
			if (contentAction != null)
			{
				code = contentAction.Id;
			}
		}
		if (string.IsNullOrWhiteSpace(code))
		{
			code = $"{type}_{name}_{parent}";
		}
		return $"{container}_[{code}]".GetDeterministicGuid();
	}

	public override string ToString()
	{
		return $"Container: {Container}, Code: {Code}, Name: {Name}, Parent: {Parent}, Order: {Weight}, Action: {Action}";
	}

	public static implicit operator MenuItem(MenuItemBuilder b)
	{
		return b.MenuItem;
	}

	public MenuItem Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is MenuItem menuItem))
		{
			return this == obj;
		}
		if (Uid == menuItem.Uid && Weight == menuItem.Weight && Name == menuItem.Name && Description == menuItem.Description && Code == menuItem.Code && OnTop == menuItem.OnTop && Target == menuItem.Target && Stretch == menuItem.Stretch && Type == menuItem.Type && Color == menuItem.Color && ((Action == null) ? (menuItem.Action == null) : Action.Equals(menuItem.Action)))
		{
			return Parent.Equals(menuItem.Parent);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)(((uint)(((((((((((((((((((Uid.GetHashCode() * 397) ^ ((Parent != null) ? Parent.GetHashCode() : 0)) * 397) ^ ((Code != null) ? Code.GetHashCode() : 0)) * 397) ^ ((Target != null) ? Target.GetHashCode() : 0)) * 397) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 397) ^ Weight) * 397) ^ ((Action != null) ? Action.GetHashCode() : 0)) * 397) ^ ((Description != null) ? Description.GetHashCode() : 0)) * 397) ^ OnTop.GetHashCode()) * 397) ^ Stretch.GetHashCode()) * 397) ^ (uint)Type) * 397) ^ ((Color != null) ? Color.GetHashCode() : 0);
	}
}
