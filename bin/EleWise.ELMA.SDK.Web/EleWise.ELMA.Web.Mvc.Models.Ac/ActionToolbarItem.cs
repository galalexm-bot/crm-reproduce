using System;
using System.ComponentModel;
using System.Linq;
using System.Web;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

[Serializable]
public class ActionToolbarItem : ActionMenuItem, IPossibleHiddenActionItem
{
	public bool PosibleHidden { get; set; }

	public bool Hidden { get; set; }

	public bool IsUidSet { get; private set; }

	[DefaultValue(false)]
	public bool TruncateTextIfLong { get; set; }

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

	public override bool Visible
	{
		get
		{
			if (base.Visible)
			{
				return InternalVisible();
			}
			return false;
		}
		set
		{
			base.Visible = value;
		}
	}

	public string ActionId { get; set; }

	public string ActionTypeProviderId { get; set; }

	public bool DisplayArrowWithoutSubitems { get; set; }

	public ActionToolbarItem()
	{
		DisplayArrowWithoutSubitems = false;
	}

	public ActionToolbarItem(string itemUid)
		: base(itemUid)
	{
		IsUidSet = !string.IsNullOrWhiteSpace(itemUid);
		DisplayArrowWithoutSubitems = false;
	}

	public ActionToolbarItem(Guid itemUid)
		: base(itemUid)
	{
		IsUidSet = true;
		DisplayArrowWithoutSubitems = false;
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.ToolbarItem;
	}

	public new ActionToolbarItem CloneItem()
	{
		return (ActionToolbarItem)Clone();
	}

	protected virtual string GenerateName()
	{
		return HttpContext.Current.GenerateName("toolbar-button-");
	}

	public override bool Equals(object obj)
	{
		bool result = false;
		if (obj is ActionToolbarItem actionToolbarItem)
		{
			result = (IsUidSet || actionToolbarItem.IsUidSet || !(Uid != actionToolbarItem.Uid)) && ((IsUidSet && actionToolbarItem.IsUidSet && Uid == actionToolbarItem.Uid) || (Click == actionToolbarItem.Click && Url == actionToolbarItem.Url && FormId == actionToolbarItem.FormId && ActionUrl == actionToolbarItem.ActionUrl && Text == actionToolbarItem.Text));
		}
		return result;
	}

	public override int GetHashCode()
	{
		return ((((((((((IsUidSet ? Uid.GetHashCode() : 0) * 397) ^ ((Click != null) ? Click.GetHashCode() : 0)) * 397) ^ ((Url != null) ? Url.GetHashCode() : 0)) * 397) ^ ((FormId != null) ? FormId.GetHashCode() : 0)) * 397) ^ ((ActionUrl != null) ? ActionUrl.GetHashCode() : 0)) * 397) ^ ((Text != null) ? Text.GetHashCode() : 0);
	}

	protected virtual bool InternalVisible()
	{
		if (string.IsNullOrWhiteSpace(Click) && string.IsNullOrWhiteSpace(Url) && (string.IsNullOrWhiteSpace(ActionTypeProviderId) || string.IsNullOrWhiteSpace(ActionId)) && ActionUrl == null && FormId == null)
		{
			return Items.Any((IActionItem i) => (i.Visible && !(i is ActionToolbarSeparator)) || (!Items.Any() && DisplayArrowWithoutSubitems));
		}
		return true;
	}
}
