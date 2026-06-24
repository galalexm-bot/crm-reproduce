using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentVersionCreateViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
public class DocumentVersionCreateViewItem : PropertyViewItem
{
	[Component(Order = 35)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentVersionCreateViewItem>
	{
	}

	public DocumentVersionCreateViewItem()
	{
		base.Attributes.Name = SR.T("Создание версии документа");
		base.HideMode = ViewItemHideMode.Modal;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
