using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentLifeCycleStatusViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
public class DocumentLifeCycleStatusViewItem : ViewItem
{
	[Component(Order = 60)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentLifeCycleStatusViewItem>
	{
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
