using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentLinksTabViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
[Obsolete("Use TabViewItem instead", false)]
public class DocumentLinksTabViewItem : TabViewItem
{
	[Component(Order = 60)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentLinksTabViewItem>
	{
	}

	public DocumentLinksTabViewItem()
	{
		Caption = SR.T("Связи");
	}
}
