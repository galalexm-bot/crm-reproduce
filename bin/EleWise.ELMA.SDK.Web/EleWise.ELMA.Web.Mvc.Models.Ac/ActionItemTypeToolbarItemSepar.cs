using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypeToolbarItemSeparator : ActionItemType
{
	public static readonly Guid Guid = new Guid("{BD1F110B-004C-4F6D-8922-AFBCCE9F3D07}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/ActionToolbar/ToolbarItemSeparator", (object)actionItem));
	}
}
