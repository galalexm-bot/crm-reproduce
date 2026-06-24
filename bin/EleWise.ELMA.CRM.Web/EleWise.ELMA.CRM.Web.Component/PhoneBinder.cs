using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components;

public class PhoneBinder : ElmaModelBinder
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
		if (!(obj is IPhone phone))
		{
			return obj;
		}
		if (string.IsNullOrWhiteSpace(phone.PhoneString))
		{
			return null;
		}
		return phone;
	}
}
