using System.Web.Mvc;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class InLineTranslateDisableAttribute : ActionFilterAttribute
{
	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		TranslateService.Instance.InLineTurned = true;
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		if (!((ControllerContext)filterContext).get_IsChildAction())
		{
			TranslateService.Instance.InLineTurned = false;
		}
	}
}
