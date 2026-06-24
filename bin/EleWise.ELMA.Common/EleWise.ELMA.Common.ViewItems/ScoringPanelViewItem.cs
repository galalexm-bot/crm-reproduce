using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Common.ViewItems;

[Serializable]
[DisplayName("SR.M('Панель скоринга')")]
public class ScoringPanelViewItem : RootViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<ScoringPanelViewItem>
	{
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return true;
	}
}
