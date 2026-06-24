using System;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public class ActionPanel : ActionItem
{
	public ActionPanel()
	{
	}

	public ActionPanel(string itemUid)
		: base(itemUid)
	{
	}

	public ActionPanel(Guid itemUid)
		: base(itemUid)
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.Panel;
	}
}
