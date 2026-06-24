using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components;

public class EmailBinder : ElmaModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		object obj;
		try
		{
			obj = base.BindModel(controllerContext, bindingContext);
		}
		catch
		{
			return null;
		}
		if (!(obj is IEmail email))
		{
			return obj;
		}
		if (string.IsNullOrWhiteSpace(email.EmailString))
		{
			return null;
		}
		return email;
	}
}
