using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentCopyFromParentPermissionViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
public class DocumentCopyFromParentPermissionViewItem : PropertyViewItem
{
	[Component(Order = 35)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentCopyFromParentPermissionViewItem>
	{
	}

	public DocumentCopyFromParentPermissionViewItem()
	{
		base.Attributes.Name = SR.T("Копировать права из родительского документа");
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
