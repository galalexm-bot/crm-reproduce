using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Enums;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Serializable]
public class ActionButton : ActionItem
{
	private string iconUrl;

	private IDictionary<string, object> iconAttributes;

	private bool disabled;

	private UISize? size;

	private string text;

	private ButtonStyle style;

	public override string Uid
	{
		get
		{
			if (string.IsNullOrEmpty(base.Uid))
			{
				base.Uid = GenerateName();
			}
			return base.Uid;
		}
		set
		{
			base.Uid = value;
		}
	}

	public virtual ButtonStyle Style
	{
		get
		{
			return style;
		}
		set
		{
			style = value;
		}
	}

	public virtual UISize? Size
	{
		get
		{
			return size;
		}
		set
		{
			size = value;
		}
	}

	public virtual bool Disabled
	{
		get
		{
			return disabled;
		}
		set
		{
			disabled = value;
		}
	}

	public virtual string IconUrl
	{
		get
		{
			return iconUrl;
		}
		set
		{
			iconUrl = value;
		}
	}

	public virtual IDictionary<string, object> IconAttributes
	{
		get
		{
			return iconAttributes;
		}
		set
		{
			iconAttributes = value;
		}
	}

	public virtual string Text
	{
		get
		{
			return text;
		}
		set
		{
			text = value;
		}
	}

	public virtual MvcHtmlString Template { get; set; }

	public virtual bool AsLink { get; set; }

	public virtual bool IsCircle { get; set; }

	public virtual bool IsChecked { get; set; }

	public virtual bool NoFill { get; set; }

	public virtual bool NoBorder { get; set; }

	public bool AsSwitcher { get; set; }

	public bool ReadOnly { get; set; }

	public bool ReadOnlyHover { get; set; }

	public virtual string Click { get; set; }

	public virtual string Url { get; set; }

	public ActionButton()
	{
		iconAttributes = new Dictionary<string, object>();
		style = ButtonStyle.Default;
	}

	public ActionButton(string uid)
		: this()
	{
		Uid = uid;
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.ActionButton;
	}

	protected virtual string GenerateName()
	{
		return HttpContext.Current.GenerateName("button-");
	}
}
