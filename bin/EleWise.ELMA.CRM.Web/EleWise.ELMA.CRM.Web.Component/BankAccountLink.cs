using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 1)]
internal class BankAccountLink : IObjectLink
{
	public bool CheckType(Type type)
	{
		return typeof(IBankAccount).IsAssignableFrom(type);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("Details", "BankAccount", (object)new
		{
			area = "EleWise.ELMA.CRM.Web",
			id = ((IEntity)obj).GetId(),
			inPopup = false
		});
	}
}
