using System;
using System.Web;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Serializable]
public class ActionButtonGroup : ActionItem
{
	public override string Uid
	{
		get
		{
			if (string.IsNullOrEmpty(base.Uid))
			{
				base.Uid = GenerateName();
			}
			return base.Uid;
		}
		set
		{
			base.Uid = value;
		}
	}

	public virtual bool IsMerged { get; set; }

	public virtual bool AsBreadcrumbs { get; set; }

	public ActionButtonGroup()
	{
		IsMerged = true;
	}

	public ActionButtonGroup(string uid)
		: this()
	{
		Uid = uid;
	}

	protected override IActionItemType GetDefaultType()
	{
		return ActionItemType.ActionButtonGroup;
	}

	protected virtual string GenerateName()
	{
		return HttpContext.Current.GenerateName("button-group");
	}
}
