using System;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

public class ActionMenu : ActionItem
{
	public ActionMenu()
	{
	}

	public ActionMenu(string itemUid)
		: base(itemUid)
	{
	}

	public ActionMenu(Guid itemUid)
		: base(itemUid)
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.Menu;
	}
}
