using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

public class BankAccountModel : DynamicEntityViewModel<IBankAccount>
{
	public string DefaultFormId { get; set; }

	public string Prefix { get; set; }

	public string ButtonText { get; set; }

	public string CallbackFunc { get; set; }

	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string RowId { get; set; }

	public string PopupId { get; set; }

	public BankAccountModel()
		: base(InterfaceActivator.Create<IBankAccount>(), ViewType.Create)
	{
	}

	public BankAccountModel(IBankAccount bankAccount, ViewType viewType)
		: base(bankAccount, viewType)
	{
	}
}
