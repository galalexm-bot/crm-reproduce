using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class ContractorIndividualModel : ContractorBaseModel<IContractorIndividual>
{
	public override string EditorViewName => "ContractorIndividual/Editors/ContractorIndividualEdit";

	public override string EditorFieldsViewName => "ContractorIndividual/ContractorIndividualEditForm";

	public bool LockEditPermission { get; set; }

	public ContractorIndividualModel()
	{
	}

	public ContractorIndividualModel(IContractorIndividual contractor)
		: base(contractor)
	{
	}

	public ContractorIndividualModel(IContractorIndividual contractor, ViewType viewType)
		: base(contractor, viewType)
	{
	}

	public override void PrepareSave()
	{
		base.Entity.Name = string.Format("{2} {0} {1}", base.Entity.FirstName, base.Entity.MiddleName, base.Entity.SecondName);
		base.PrepareSave();
	}

	protected override IContractorBaseModel CreateConcreteModel(IContractorIndividual entity, ViewType viewType, Guid? customFormUid)
	{
		return new ContractorIndividualModel(entity, viewType)
		{
			FormUid = customFormUid
		};
	}
}
