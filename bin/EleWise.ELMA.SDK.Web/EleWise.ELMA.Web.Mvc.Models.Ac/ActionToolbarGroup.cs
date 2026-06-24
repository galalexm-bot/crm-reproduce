using System;
using System.Web;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

public class ActionToolbarGroup : ActionItem, IActionText, IActionUrl, IPossibleHiddenActionItem
{
	protected string text;

	protected string toolTip;

	protected string toolTipHeader;

	protected string _url;

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

	public virtual string Url
	{
		get
		{
			return _url;
		}
		set
		{
			_url = value;
		}
	}

	public string Click { get; set; }

	public bool PosibleHidden { get; set; }

	public bool Hidden { get; set; }

	public bool IsUidSet { get; private set; }

	public override string Uid
	{
		get
		{
			if (!IsUidSet && string.IsNullOrEmpty(base.Uid))
			{
				base.Uid = GenerateName();
			}
			return base.Uid;
		}
		set
		{
			base.Uid = value;
			IsUidSet = true;
		}
	}

	public ActionToolbarGroup()
	{
	}

	public ActionToolbarGroup(string itemUid)
		: base(itemUid)
	{
		IsUidSet = !string.IsNullOrWhiteSpace(itemUid);
	}

	public ActionToolbarGroup(Guid itemUid)
		: base(itemUid)
	{
		IsUidSet = true;
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.ToolbarGroup;
	}

	protected virtual string GenerateName()
	{
		return HttpContext.Current.GenerateName("toolbar-group-");
	}
}
