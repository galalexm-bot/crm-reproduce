using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentVersionsTabViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
[Obsolete("Use TabViewItem instead", false)]
public class DocumentVersionsTabViewItem : TabViewItem
{
	[Component(Order = 40)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentVersionsTabViewItem>
	{
	}

	public DocumentVersionsTabViewItem()
	{
		Caption = SR.T("Версии");
	}
}
