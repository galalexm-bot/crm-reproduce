using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

[Component(EnableInterceptiors = false, InjectProerties = false)]
internal sealed class MoreActionToolbarButton : ActionToolbarItem
{
	public override bool Visible
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public override string Uid
	{
		get
		{
			return "more_btn";
		}
		set
		{
			base.Uid = value;
		}
	}

	public MoreActionToolbarButton(string itemUid)
		: base(itemUid)
	{
		base.TruncateTextIfLong = false;
		base.DisplayArrowWithoutSubitems = true;
		Text = SR.T("Еще");
		Visible = true;
		Class = "toolbar-additional-button";
	}
}
