using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Serializable]
public class ActionItem : IActionItem, ICloneable
{
	protected IDictionary<string, object> customAttributes = new Dictionary<string, object>();

	protected string uid = "";

	protected IActionItemType type;

	protected IActionItemList items;

	private object attributes;

	protected bool _visible;

	protected Action<HtmlHelper> _onRender;

	public virtual IDictionary<string, object> CustomAttributes
	{
		get
		{
			return customAttributes ?? (customAttributes = new Dictionary<string, object>());
		}
		set
		{
			customAttributes = value;
		}
	}

	public virtual string Uid
	{
		get
		{
			return uid;
		}
		set
		{
			uid = value;
		}
	}

	public virtual IActionItemType Type
	{
		get
		{
			return type ?? GetDefaultType();
		}
		set
		{
			type = value;
		}
	}

	[NotNull]
	public virtual IActionItemList Items
	{
		get
		{
			return items ?? (items = new ActionItemList());
		}
		set
		{
			items = value;
		}
	}

	public virtual object Attributes
	{
		get
		{
			return attributes;
		}
		set
		{
			attributes = value;
		}
	}

	[ChangeableProperty]
	public virtual bool Visible
	{
		get
		{
			return _visible;
		}
		set
		{
			_visible = value;
		}
	}

	public virtual Action<HtmlHelper> OnRender
	{
		get
		{
			return _onRender;
		}
		set
		{
			_onRender = value;
		}
	}

	public ActionItem()
	{
		items = new ActionItemList();
		_visible = true;
	}

	public ActionItem(string itemUid)
		: this()
	{
		uid = itemUid;
		_visible = true;
	}

	public ActionItem(Guid itemUid)
		: this()
	{
		uid = itemUid.ToString();
		_visible = true;
	}

	public override bool Equals(object obj)
	{
		if (obj is IActionItem)
		{
			return Uid == ((IActionItem)obj).Uid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (uid == null)
		{
			return 0;
		}
		return uid.GetHashCode();
	}

	public override string ToString()
	{
		return $"{GetType().Name};{Uid}";
	}

	protected virtual IActionItemType GetDefaultType()
	{
		return ActionItemType.Button;
	}

	public object Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}
}
