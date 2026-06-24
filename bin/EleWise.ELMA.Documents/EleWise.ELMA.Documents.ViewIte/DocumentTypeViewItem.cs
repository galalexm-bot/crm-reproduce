using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentTypeViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
public class DocumentTypeViewItem : PropertyViewItem
{
	[Component(Order = 20)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentTypeViewItem>
	{
	}

	public DocumentTypeViewItem()
	{
		base.Attributes.Name = SR.T("Тип документа");
		base.Attributes.ReadOnly = true;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return base.IsValid(viewType, parentViewItem);
	}
}
