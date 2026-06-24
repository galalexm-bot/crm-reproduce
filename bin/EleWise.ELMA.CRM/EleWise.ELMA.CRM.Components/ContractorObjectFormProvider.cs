using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

[Component]
internal sealed class ContractorObjectFormProvider : AbstractObjectFormProvider<IContractor>
{
	public ContractorObjectFormProvider(IMetadataRuntimeService metadataRuntimeService, ViewModelDescriptor viewModelDescriptor)
		: base(metadataRuntimeService, viewModelDescriptor)
	{
	}

	protected override FormViewItem Transform(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default)
	{
		formViewItem = base.Transform(metadata, formViewItem, viewType, itemType);
		if (metadata is EntityMetadata metadata2)
		{
			formViewItem = formViewItem.Transformate(CRMContractorFormViewTransformate.GetTransformation(metadata2, viewType));
		}
		return formViewItem;
	}
}
