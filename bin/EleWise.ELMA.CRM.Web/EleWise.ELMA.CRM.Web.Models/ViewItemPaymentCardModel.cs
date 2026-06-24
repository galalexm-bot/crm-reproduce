using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

public class ViewItemPaymentCardModel
{
	public IPaymentCard Entity { get; set; }

	public FormViewItem FormViewItem { get; set; }

	public string Prefix { get; set; }

	public bool InPopup { get; set; }
}
