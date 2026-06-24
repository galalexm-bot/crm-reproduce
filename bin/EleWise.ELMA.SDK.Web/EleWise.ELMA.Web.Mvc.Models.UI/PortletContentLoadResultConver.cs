using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;

[Component]
public class PortletContentLoadResultConverter : IFormResultConverter
{
	public Type ResultType => typeof(PortletContentLoadResultWrapper);

	public ActionResult Convert(FormResult result, BaseController controller)
	{
		UIPortletContentRenderModel model = new UIPortletContentRenderModel((PortletContentLoadResultWrapper)result);
		return (ActionResult)(object)controller.GetPartialViewResult("UI/UIPortletContent", model);
	}

	public Dictionary<string, object> GetClientData(FormResult result, BaseController controller)
	{
		return null;
	}
}
