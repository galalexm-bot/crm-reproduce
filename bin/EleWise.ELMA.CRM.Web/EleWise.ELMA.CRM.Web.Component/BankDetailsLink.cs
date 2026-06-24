using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 1)]
internal class BankDetailsLink : IObjectLink
{
	public bool CheckType(Type type)
	{
		return typeof(IBankDetails).IsAssignableFrom(type);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		UrlHelper val = new UrlHelper(context);
		Guid uid = InterfaceActivator.UID(obj.CastAsRealType().GetType());
		return val.Action("ViewItem", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			id = ((IEntity)obj).GetId(),
			inPopUp = false
		});
	}
}
