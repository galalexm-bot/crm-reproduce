using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class CreatorFormAttribute : ActionFilterAttribute
{
	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (((ControllerContext)filterContext).get_RouteData().Values.TryGetValue("prefix", out var value) && value != null && !string.IsNullOrEmpty(value.ToString()))
		{
			((ControllerContext)filterContext).get_Controller().get_ViewData().get_TemplateInfo()
				.set_HtmlFieldPrefix(value.ToString());
			((ControllerContext)filterContext).get_Controller().get_ViewData().set_Item("CreatorRequest", (object)true);
			((ControllerContext)filterContext).get_Controller().get_ViewData().set_Item("CreatorPrefix", (object)value.ToString());
		}
	}
}
