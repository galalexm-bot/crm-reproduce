using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Extensions;

public class DocumentLinksGridViewItemBuilder<TM> : ViewItemBuilder<TM, DocumentLinksGridViewItem, DocumentLinksGridViewItemBuilder<TM>> where TM : IDocument
{
	public DocumentLinksGridViewItemBuilder()
	{
	}

	internal DocumentLinksGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
