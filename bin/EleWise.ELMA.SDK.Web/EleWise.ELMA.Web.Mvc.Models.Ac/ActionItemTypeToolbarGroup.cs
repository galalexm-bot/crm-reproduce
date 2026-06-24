using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypeToolbarGroup : ActionItemType
{
	public static readonly Guid Guid = new Guid("{34F27C7D-FE49-477B-B127-5FC972A488D9}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/ActionToolbar/Group", (object)actionItem));
	}
}
