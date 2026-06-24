using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal sealed class DocumentObjectFormProvider : AbstractObjectFormProvider<IDocument>
{
	public DocumentObjectFormProvider(IMetadataRuntimeService metadataRuntimeService, ViewModelDescriptor viewModelDescriptor)
		: base(metadataRuntimeService, viewModelDescriptor)
	{
	}

	public override void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
	{
		base.InitObject(obj, viewType, arguments);
		IDocument document = (IDocument)obj;
		document.InitDocument(viewType, null, disableProfileFolder: false, disableCreateAccess: false, document.IsNew(), disableDefaultFolder: false);
	}

	protected override FormViewItem Transform(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default)
	{
		if (metadata is DocumentMetadata metadata2)
		{
			formViewItem = formViewItem.Transformate(DocumentFormViewTransformate.GetTransformation(metadata2, viewType));
		}
		return base.Transform(metadata, formViewItem, viewType, itemType);
	}
}
