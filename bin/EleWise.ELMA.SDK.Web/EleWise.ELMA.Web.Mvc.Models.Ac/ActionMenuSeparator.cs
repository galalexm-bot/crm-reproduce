using System;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

public class ActionMenuSeparator : ActionMenuItem
{
	public ActionMenuSeparator()
	{
	}

	public ActionMenuSeparator(string itemUid)
		: base(itemUid)
	{
	}

	public ActionMenuSeparator(Guid itemUid)
		: base(itemUid)
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.MenuSeparator;
	}
}
