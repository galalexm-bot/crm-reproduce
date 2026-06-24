using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan;

public class PaymentModel : EntityModel<IPayment>
{
	public PaymentModel(IPayment payment)
	{
		base.Entity = payment;
	}

	public PaymentModel()
	{
		base.Entity = InterfaceActivator.Create<IPayment>();
	}

	public void Save()
	{
		if (base.Entity.IsNew())
		{
			base.Entity.PaymentStatus = PaymentStatus.Planned;
		}
		base.Entity.Save();
	}
}
