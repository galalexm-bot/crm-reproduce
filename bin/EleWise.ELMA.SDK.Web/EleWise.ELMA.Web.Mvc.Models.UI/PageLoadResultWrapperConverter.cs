using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;

[Component]
public class PageLoadResultWrapperConverter : IFormResultConverter
{
	public Type ResultType => typeof(PageLoadResultWrapper);

	public ActionResult Convert(FormResult result, BaseController controller)
	{
		UIPageRenderModel model = new UIPageRenderModel((PageLoadResultWrapper)result);
		bool flag = (((Controller)controller).get_RouteData().Values["partial"] as bool?) ?? false;
		((ControllerBase)controller).get_ViewData().set_Item("Partial", (object)flag);
		if (!flag)
		{
			return (ActionResult)(object)controller.GetViewResult("UI/UIPage", model);
		}
		return (ActionResult)(object)controller.GetPartialViewResult("UI/UIPage", model);
	}

	public Dictionary<string, object> GetClientData(FormResult result, BaseController controller)
	{
		return null;
	}
}
