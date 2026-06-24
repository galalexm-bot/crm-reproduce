using System;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

public class ActionToolbar : ActionToolbarGroup
{
	public ActionToolbar()
	{
	}

	public ActionToolbar(string itemUid)
		: base(itemUid)
	{
	}

	public ActionToolbar(Guid itemUid)
		: base(itemUid)
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.Toolbar;
	}
}
