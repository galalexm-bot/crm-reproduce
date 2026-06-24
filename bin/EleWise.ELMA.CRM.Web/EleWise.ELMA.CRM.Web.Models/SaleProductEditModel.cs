using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleProductEditModel : EntityModel<ISaleProduct>
{
	public SaleProductEditModel()
	{
		base.Entity = InterfaceActivator.Create<ISaleProduct>();
	}

	public SaleProductEditModel(ISale sale)
	{
		InstanceOf<ISaleProduct> instanceOf = new InstanceOf<ISaleProduct>();
		instanceOf.New.Sale = sale;
		instanceOf.New.Quantity = 1L;
		base.Entity = instanceOf.New;
	}
}
