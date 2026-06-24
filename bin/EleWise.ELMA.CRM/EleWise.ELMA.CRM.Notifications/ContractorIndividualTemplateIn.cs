using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Notifications;

public class ContractorIndividualTemplateInput : ContractorTemplateInputBase<IContractorIndividual>
{
	public override string ControllerName(IContractor value)
	{
		return "ContractorIndividual";
	}

	public override string ContractorName(IContractor value)
	{
		if (value is IContractorIndividual contractorIndividual)
		{
			return contractorIndividual.ToString();
		}
		return value.ToString();
	}
}
