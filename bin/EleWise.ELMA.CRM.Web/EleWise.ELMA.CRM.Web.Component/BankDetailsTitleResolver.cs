using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 100)]
internal class BankDetailsTitleResolver : IEntityTitleResolver
{
	public bool CheckType(IEntity entity)
	{
		return entity is IBankDetails;
	}

	public MvcHtmlString GetTitle(IEntity entity, UrlHelper helper)
	{
		IBankDetails obj = (IBankDetails)entity;
		string arg = HttpUtility.HtmlEncode(obj.Name);
		if (obj.EndDate < DateTime.Today)
		{
			return MvcHtmlString.Create($"<strike>{arg}</strike>");
		}
		return MvcHtmlString.Create($"{arg}");
	}
}
