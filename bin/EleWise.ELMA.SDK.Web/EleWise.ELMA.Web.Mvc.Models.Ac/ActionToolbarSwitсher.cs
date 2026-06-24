using System.Web;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

public class ActionToolbarSwitсher : ActionToolbarGroup
{
	public const string SwitcherUid = "ActionToolbarSwitcherUid";

	public ActionToolbarSwitсher()
		: base("ActionToolbarSwitcherUid")
	{
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.ToolbarSwitcher;
	}

	protected override string GenerateName()
	{
		return HttpContext.Current.GenerateName("toolbar-switcher-");
	}
}
