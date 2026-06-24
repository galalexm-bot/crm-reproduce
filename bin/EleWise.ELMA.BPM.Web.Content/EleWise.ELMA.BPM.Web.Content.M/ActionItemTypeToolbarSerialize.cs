using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public class ActionItemTypeToolbarSerialized : ActionItemType
{
	public static readonly Guid Guid = new Guid("{A309BD72-AA58-4628-A1BC-5060202AAFFC}");

	public override Guid Uid => Guid;

	public static IActionItemType ToolbarSerialized => ActionItemType.GetType(Guid);

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		builder.Append(PartialExtensions.Partial(htmlHelper, "Toolbar/ActionToolbarSerialized", (object)actionItem));
	}
}
