using System;
using System.Web;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

[Serializable]
public class ActionToolbarSeparator : ActionToolbarItem
{
	public ActionToolbarSeparator()
	{
	}

	public ActionToolbarSeparator(string itemUid)
		: base(itemUid)
	{
	}

	public ActionToolbarSeparator(Guid itemUid)
		: base(itemUid)
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.ToolbarItemSeparator;
	}

	public new ActionToolbarSeparator CloneItem()
	{
		return (ActionToolbarSeparator)Clone();
	}

	public override bool Equals(object obj)
	{
		if (obj is ActionToolbarSeparator actionToolbarSeparator)
		{
			return Uid == actionToolbarSeparator.Uid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (Uid == null)
		{
			return 0;
		}
		return uid.GetHashCode();
	}

	protected override string GenerateName()
	{
		return HttpContext.Current.GenerateName("toolbar-separator-");
	}

	protected override bool InternalVisible()
	{
		return true;
	}
}
