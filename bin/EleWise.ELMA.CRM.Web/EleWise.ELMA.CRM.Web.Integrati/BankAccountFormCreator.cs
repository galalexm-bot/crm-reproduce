using System;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Integration.Views;

[Component]
internal class BankAccountFormCreator : FormCreator
{
	public override bool CheckType(Type type)
	{
		if (type == null)
		{
			return false;
		}
		if (type == typeof(IBankAccount))
		{
			return InitActionMap(type, typeof(CatalogsController));
		}
		return false;
	}
}
