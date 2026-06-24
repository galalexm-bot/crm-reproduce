using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public class ActionToolbarSerialized : ActionItem
{
	public string VirtualPath { get; set; }

	public ToolbarTreeItem ToolbarTreeItem { get; set; }

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemTypeToolbarSerialized.ToolbarSerialized;
	}
}
