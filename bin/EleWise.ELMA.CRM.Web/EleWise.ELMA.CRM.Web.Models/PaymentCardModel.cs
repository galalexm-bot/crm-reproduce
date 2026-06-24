using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

public class PaymentCardModel : DynamicEntityViewModel<IPaymentCard>
{
	public string DefaultFormId { get; set; }

	public string Prefix { get; set; }

	public string ButtonText { get; set; }

	public string CallbackFunc { get; set; }

	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string RowId { get; set; }

	public string PopupId { get; set; }

	public PaymentCardModel()
		: base(InterfaceActivator.Create<IPaymentCard>(), ViewType.Create)
	{
	}

	public PaymentCardModel(IPaymentCard paymentCard, ViewType viewType)
		: base(paymentCard, viewType)
	{
	}
}
