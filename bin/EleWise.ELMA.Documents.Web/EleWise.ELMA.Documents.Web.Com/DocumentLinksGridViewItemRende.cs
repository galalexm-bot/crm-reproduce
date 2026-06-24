using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentLinksGridViewItemRenderer : ViewItemRendererBase<DocumentLinksGridViewItem>, ICountViewItemRenderer
{
	public long? Count(object model, ICountViewItem viewItem)
	{
		return (model as IDocument)?.GetLinksCount();
	}
}
