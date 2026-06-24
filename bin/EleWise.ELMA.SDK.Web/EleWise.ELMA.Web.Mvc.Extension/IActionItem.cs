using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

public interface IActionItem
{
	string Uid { get; set; }

	IActionItemType Type { get; set; }

	IActionItemList Items { get; }

	object Attributes { get; set; }

	bool Visible { get; set; }

	Action<HtmlHelper> OnRender { get; set; }
}
