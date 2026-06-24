using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class ContractorLegalModel : ContractorBaseModel<IContractorLegal>
{
	public override string EditorViewName => "ContractorLegal/Editors/ContractorLegalEdit";

	public override string EditorFieldsViewName => "ContractorLegal/ContractorLegalEditForm";

	public bool LockEditPermission { get; set; }

	public ContractorLegalModel()
	{
	}

	public ContractorLegalModel(IContractorLegal contractor)
		: base(contractor)
	{
	}

	public ContractorLegalModel(IContractorLegal contractor, ViewType viewType)
		: base(contractor, viewType)
	{
	}

	protected override IContractorBaseModel CreateConcreteModel(IContractorLegal entity, ViewType viewType, Guid? customFormUid)
	{
		return new ContractorLegalModel(entity, viewType)
		{
			FormUid = customFormUid
		};
	}
}
