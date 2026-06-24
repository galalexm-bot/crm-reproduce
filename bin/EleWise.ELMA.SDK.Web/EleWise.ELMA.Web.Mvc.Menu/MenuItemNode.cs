using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Menu;

public class MenuItemNode
{
	public Action<HtmlHelper> OnRender;

	public long Id { get; set; }

	public Guid MenuUid { get; set; }

	public int MenuId { get; set; }

	public bool IsHome { get; set; }

	public string Code { get; set; }

	public string Target { get; set; }

	public long? ParentItemId { get; set; }

	public string ParentItemName { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string ImageUrl { get; set; }

	public string Image16Url { get; set; }

	public string Image24Url { get; set; }

	public string Image32Url { get; set; }

	public string NavigateUrl { get; set; }

	public bool Disabled { get; set; }

	public int Weight { get; set; }

	public bool OnTop { get; set; }

	public bool Stretch { get; set; }

	public MenuItemNode Parent { get; set; }

	public List<MenuItemNode> Items { get; set; }

	public bool HasTemplate => Template != null;

	public Func<HtmlHelper, MvcHtmlString> Template { get; set; }

	public IMenuCustomItems CustomItems { get; set; }

	public bool HasCountEvaluator => CountEvaluator != null;

	public Func<HtmlHelper, MenuItemCount> CountEvaluator { get; set; }

	public string Color { get; set; }

	public string Url => NavigateUrl;

	public bool IsActive { get; set; }

	public MenuItemNodeType Type { get; set; }

	public MenuItemNode()
	{
		Items = new List<MenuItemNode>();
	}

	public string GetImageUrl(ObjectIconFormat size)
	{
		switch (size)
		{
		case ObjectIconFormat.x24:
			if (string.IsNullOrEmpty(ImageUrl))
			{
				if (string.IsNullOrEmpty(Image24Url))
				{
					if (string.IsNullOrEmpty(Image16Url))
					{
						return Image32Url;
					}
					return Image16Url;
				}
				return Image24Url;
			}
			return ImageUrl;
		case ObjectIconFormat.x32:
			if (string.IsNullOrEmpty(ImageUrl))
			{
				if (string.IsNullOrEmpty(Image32Url))
				{
					if (string.IsNullOrEmpty(Image24Url))
					{
						return Image16Url;
					}
					return Image24Url;
				}
				return Image32Url;
			}
			return ImageUrl;
		default:
			if (string.IsNullOrEmpty(ImageUrl))
			{
				if (string.IsNullOrEmpty(Image16Url))
				{
					if (string.IsNullOrEmpty(Image24Url))
					{
						return Image32Url;
					}
					return Image24Url;
				}
				return Image16Url;
			}
			return ImageUrl;
		}
	}

	public bool Equals(MenuItemNode other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (other.Id == Id && other.MenuId == MenuId && object.Equals(other.Code, Code) && other.ParentItemId.Equals(ParentItemId) && object.Equals(other.Name, Name) && object.Equals(other.Description, Description) && object.Equals(other.ImageUrl, ImageUrl) && object.Equals(other.NavigateUrl, NavigateUrl) && other.Disabled.Equals(Disabled) && other.Weight == Weight && other.OnTop.Equals(OnTop) && other.Stretch.Equals(Stretch) && object.Equals(other.Parent, Parent) && object.Equals(other.Items, Items))
		{
			return object.Equals(other.Type, Type);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(MenuItemNode))
		{
			return false;
		}
		return Equals((MenuItemNode)obj);
	}

	public override int GetHashCode()
	{
		return (((((((((((((((((((((((((((((((Id.GetHashCode() * 397) ^ MenuId) * 397) ^ ((Code != null) ? Code.GetHashCode() : 0)) * 397) ^ (ParentItemId.HasValue ? ParentItemId.Value.GetHashCode() : 0)) * 397) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 397) ^ ((Description != null) ? Description.GetHashCode() : 0)) * 397) ^ ((ImageUrl != null) ? ImageUrl.GetHashCode() : 0)) * 397) ^ ((Image16Url != null) ? Image16Url.GetHashCode() : 0)) * 397) ^ ((Image24Url != null) ? Image24Url.GetHashCode() : 0)) * 397) ^ ((Image32Url != null) ? Image32Url.GetHashCode() : 0)) * 397) ^ ((NavigateUrl != null) ? NavigateUrl.GetHashCode() : 0)) * 397) ^ Disabled.GetHashCode()) * 397) ^ Weight) * 397) ^ OnTop.GetHashCode()) * 397) ^ Stretch.GetHashCode()) * 397) ^ ((Parent != null) ? Parent.GetHashCode() : 0)) * 397) ^ Type.GetHashCode();
	}
}
