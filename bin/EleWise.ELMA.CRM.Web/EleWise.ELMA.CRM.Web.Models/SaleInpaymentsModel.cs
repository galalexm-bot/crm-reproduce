using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleInpaymentsModel
{
	public ISale Sale { get; set; }

	public GridData<IInpayment> GridData { get; set; }
}
