using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypePanel : ActionItemType
{
	public static readonly Guid Guid = new Guid("{980CC385-62A8-454D-9B58-E1EFAED73AFF}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/Panel", (object)actionItem));
	}
}
