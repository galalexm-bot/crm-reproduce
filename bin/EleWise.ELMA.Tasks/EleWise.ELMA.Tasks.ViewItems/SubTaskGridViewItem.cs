using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_SubTaskGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ITaskBase))]
public class SubTaskGridViewItem : RootViewItem
{
	[Component(Order = 110)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<SubTaskGridViewItem>
	{
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
