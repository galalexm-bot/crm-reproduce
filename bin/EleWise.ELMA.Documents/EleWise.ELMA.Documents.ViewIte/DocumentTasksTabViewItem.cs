using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_DocumentTasksTabViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IDocument))]
[Obsolete("Use TabViewItem instead", false)]
public class DocumentTasksTabViewItem : TabViewItem
{
	[Component(Order = 45)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<DocumentTasksTabViewItem>
	{
	}

	public DocumentTasksTabViewItem()
	{
		Caption = SR.T("Задачи");
	}
}
