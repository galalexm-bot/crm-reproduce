using System;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypePlainHtml : ActionItemType
{
	public static readonly Guid Guid = new Guid("{04FE18D2-80CF-4540-8642-69E3A56CC5E9}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(actionItem.Attributes);
	}
}
