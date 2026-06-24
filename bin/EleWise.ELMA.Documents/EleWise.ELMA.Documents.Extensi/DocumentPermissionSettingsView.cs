using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Extensions;

public class DocumentPermissionSettingsViewItemBuilder<TM> : ViewItemBuilder<TM, DocumentPermissionSettingsViewItem, DocumentPermissionSettingsViewItemBuilder<TM>> where TM : IDocument
{
	public DocumentPermissionSettingsViewItemBuilder()
	{
	}

	internal DocumentPermissionSettingsViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
