using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Extensions;

public class DocumentVersionsTabViewItemBuilder<TM> : TabViewItemBuilder<TM, DocumentVersionsTabViewItem, DocumentVersionsTabViewItemBuilder<TM>> where TM : IDocument
{
	public DocumentVersionsTabViewItemBuilder()
	{
	}

	internal DocumentVersionsTabViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
		base.ViewItem.Caption = SR.T("Версии");
	}
}
