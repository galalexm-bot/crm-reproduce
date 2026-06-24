using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_WebDocumentContentViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IWebDocument))]
public class WebDocumentContentViewItem : ViewItem
{
	[Component(Order = 10)]
	private class ToolboxItem : DocumentsViewItemToolboxItem<WebDocumentContentViewItem>
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
