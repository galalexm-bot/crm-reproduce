using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public sealed class ActionItemPlain : ActionItem
{
	public ActionItemPlain()
	{
	}

	public ActionItemPlain(string plainHtml)
	{
		Attributes = plainHtml;
	}

	public static IActionItem Create(string plainHtml)
	{
		return new ActionItemPlain(plainHtml);
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.PlainHtml;
	}
}
