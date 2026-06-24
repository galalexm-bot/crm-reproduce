using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Notifications;

public class ContractorLegalTemplateInput : ContractorTemplateInputBase<IContractorLegal>
{
	public override string ControllerName(IContractor value)
	{
		return "ContractorLegal";
	}

	public override string ContractorName(IContractor value)
	{
		if (value is IContractorLegal contractorLegal)
		{
			return contractorLegal.ToString();
		}
		return value.ToString();
	}
}
