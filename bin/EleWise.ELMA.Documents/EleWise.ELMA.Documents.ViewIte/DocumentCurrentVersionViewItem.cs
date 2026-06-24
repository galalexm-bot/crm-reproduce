using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentCurrentVersionViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
public class DocumentCurrentVersionViewItem : ViewItem
{
	[Component(Order = 30)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentCurrentVersionViewItem>
	{
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
