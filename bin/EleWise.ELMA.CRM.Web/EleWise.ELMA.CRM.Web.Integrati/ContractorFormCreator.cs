using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Integration.Views;

[Component(Order = 90)]
internal class ContractorFormCreator : FormCreator
{
	public override bool CheckType(Type type)
	{
		if (type == null)
		{
			return false;
		}
		if (typeof(IContractor).IsAssignableFrom(type))
		{
			return base.CheckType(type);
		}
		return false;
	}
}
