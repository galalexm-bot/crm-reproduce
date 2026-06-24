using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentTasksGridViewItemRenderer : ViewItemRendererBase<DocumentTasksGridViewItem>, ICountViewItemRenderer
{
	private readonly DocumentManager documentManager;

	public DocumentTasksGridViewItemRenderer(DocumentManager documentManager)
	{
		this.documentManager = documentManager;
	}

	public long? Count(object model, ICountViewItem viewItem)
	{
		if (!(model is IDocument document))
		{
			return null;
		}
		return documentManager.GetTasksByDocumentCount(document, null);
	}
}
