using System;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

[Serializable]
public class ActionMenuItem : ActionItem, IActionText, IActionIcon, IActionUrl, IActionSubmit, IActionClick, IActionClass
{
	protected string actionUrl;

	protected string formId;

	protected string click;

	protected string iconUrl;

	protected string iconCls;

	protected bool @checked;

	protected string cssClass;

	protected string url;

	protected string text;

	protected string toolTip;

	protected string toolTipHeader;

	protected bool isMainAction;

	[ChangeableProperty]
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

	[ChangeableProperty]
	public virtual string IconCls
	{
		get
		{
			return iconCls;
		}
		set
		{
			iconCls = value;
		}
	}

	[ChangeableProperty]
	public virtual bool Checked
	{
		get
		{
			return @checked;
		}
		set
		{
			@checked = value;
		}
	}

	[ChangeableProperty]
	public virtual string Url
	{
		get
		{
			return url;
		}
		set
		{
			url = value;
		}
	}

	[ChangeableProperty]
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

	[ChangeableProperty]
	public virtual string ToolTip
	{
		get
		{
			return toolTip;
		}
		set
		{
			toolTip = value;
		}
	}

	[ChangeableProperty]
	public virtual string ToolTipHeader
	{
		get
		{
			return toolTipHeader;
		}
		set
		{
			toolTipHeader = value;
		}
	}

	[ChangeableProperty]
	public virtual bool IsMainAction
	{
		get
		{
			return isMainAction;
		}
		set
		{
			isMainAction = value;
		}
	}

	[ChangeableProperty]
	public virtual bool IsAbortAction { get; set; }

	[ChangeableProperty]
	public virtual bool IsApproveAction { get; set; }

	[ChangeableProperty]
	public virtual string ActionUrl
	{
		get
		{
			return actionUrl;
		}
		set
		{
			actionUrl = value;
		}
	}

	[ChangeableProperty]
	public virtual string FormId
	{
		get
		{
			return formId;
		}
		set
		{
			formId = value;
		}
	}

	[ChangeableProperty]
	public virtual string Click
	{
		get
		{
			return click;
		}
		set
		{
			click = value;
		}
	}

	[ChangeableProperty]
	public virtual string Class
	{
		get
		{
			return cssClass;
		}
		set
		{
			cssClass = value;
		}
	}

	public ActionMenuItem()
	{
	}

	public ActionMenuItem(string itemUid)
		: base(itemUid)
	{
	}

	public ActionMenuItem(Guid itemUid)
		: base(itemUid)
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.MenuItem;
	}

	public ActionMenuItem CloneItem()
	{
		return (ActionMenuItem)Clone();
	}
}
