using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypeToolbar : ActionItemType
{
	public static readonly Guid Guid = new Guid("{CC80BF61-0E3C-43BB-8BCD-118DCA1A0362}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/ActionToolbar/Toolbar", (object)actionItem));
	}
}
