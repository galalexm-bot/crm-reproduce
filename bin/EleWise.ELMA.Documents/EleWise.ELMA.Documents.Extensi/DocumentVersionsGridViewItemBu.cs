using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Extensions;

public class DocumentVersionsGridViewItemBuilder<TM> : ViewItemBuilder<TM, DocumentVersionsGridViewItem, DocumentVersionsGridViewItemBuilder<TM>> where TM : IDocument
{
	public DocumentVersionsGridViewItemBuilder()
	{
	}

	internal DocumentVersionsGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
