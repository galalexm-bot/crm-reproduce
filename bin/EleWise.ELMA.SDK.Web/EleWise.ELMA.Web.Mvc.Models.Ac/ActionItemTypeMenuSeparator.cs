using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypeMenuSeparator : ActionItemType
{
	public static readonly Guid Guid = new Guid("{AEA510F6-769F-4C3F-A239-3F2D82D59BA8}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/ActionMenu/MenuItemSeparator", (object)actionItem));
	}
}
