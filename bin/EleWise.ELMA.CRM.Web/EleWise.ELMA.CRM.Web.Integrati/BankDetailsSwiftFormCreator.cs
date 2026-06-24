using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Integration.Views;

[Component(Order = 100)]
internal class BankDetailsSwiftFormCreator : FormCreator
{
	public override bool CheckType(Type type)
	{
		if (type != null && typeof(IBankDetailsSWIFT).IsAssignableFrom(type))
		{
			return base.CheckType(type);
		}
		return false;
	}
}
