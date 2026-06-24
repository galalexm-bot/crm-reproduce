using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
internal sealed class WorkLogTabViewItemRenderer : TabViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.Uid == new Guid("4ec6383a-e191-441a-be5e-abb93c86fa3e");
	}

	public override string ViewName(ViewItem viewItem)
	{
		return "ViewItems/WorkLogTabViewItem";
	}
}
