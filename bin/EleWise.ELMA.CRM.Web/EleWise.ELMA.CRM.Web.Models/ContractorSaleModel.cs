using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class ContractorSaleModel
{
	public IContractor Contractor { get; set; }

	public ISale Sale { get; set; }
}
