using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
internal sealed class SubTasksTabViewItemRenderer : TabViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.Uid == new Guid("2cccc7d0-a2bf-43f1-8f14-202a91041c5f");
	}

	public override string ViewName(ViewItem viewItem)
	{
		return "ViewItems/SubTasksTabViewItem";
	}
}
