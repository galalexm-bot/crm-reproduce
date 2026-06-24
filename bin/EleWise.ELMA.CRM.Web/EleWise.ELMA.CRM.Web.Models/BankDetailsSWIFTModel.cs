using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

public class BankDetailsSWIFTModel : DynamicEntityViewModel<IBankDetailsSWIFT>
{
	public BankDetailsSWIFTModel(IBankDetailsSWIFT bankDetailsSwift, ViewType viewType)
		: base(bankDetailsSwift, viewType)
	{
	}

	public BankDetailsSWIFTModel()
		: base(InterfaceActivator.Create<IBankDetailsSWIFT>(), ViewType.Create)
	{
	}
}
