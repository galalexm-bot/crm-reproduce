using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleInpaymentEditModel
{
	public IInpayment Inpayment { get; set; }

	public bool Create { get; set; }

	public bool CloseInpaymentsPlan { get; set; }

	public SaleInpaymentEditModel()
	{
		CloseInpaymentsPlan = false;
	}
}
