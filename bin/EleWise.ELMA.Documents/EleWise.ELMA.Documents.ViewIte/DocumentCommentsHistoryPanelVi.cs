using System;
using EleWise.ELMA.Common.ViewItems;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentCommentsHistoryPanelViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
public class DocumentCommentsHistoryPanelViewItem : HistoryPanelViewItem
{
	[Component(Order = 90)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentCommentsHistoryPanelViewItem>
	{
	}
}
