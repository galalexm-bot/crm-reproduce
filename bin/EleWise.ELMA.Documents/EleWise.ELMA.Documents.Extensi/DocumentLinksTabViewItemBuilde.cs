using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Extensions;

public class DocumentLinksTabViewItemBuilder<TM> : TabViewItemBuilder<TM, DocumentLinksTabViewItem, DocumentLinksTabViewItemBuilder<TM>> where TM : IDocument
{
	public DocumentLinksTabViewItemBuilder()
	{
	}

	internal DocumentLinksTabViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
		base.ViewItem.Caption = SR.T("Связи");
	}
}
