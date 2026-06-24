using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class SearchFilterAttribute : ActionFilterAttribute
{
	public string FromPrefix { get; set; }

	public string ToPrefix { get; set; }

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		if (!(((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod == "POST"))
		{
			return;
		}
		List<string> list = ((ControllerContext)filterContext).get_HttpContext().Request.Form.AllKeys.Where((string f) => !string.IsNullOrEmpty(((ControllerContext)filterContext).get_HttpContext().Request.Form[f])).ToList();
		RouteValueDictionary route = ((ControllerContext)filterContext).get_RouteData().Values;
		string fromPrefix = (string.IsNullOrEmpty(FromPrefix) ? "" : (FromPrefix.EndsWith(".") ? FromPrefix : (FromPrefix + ".")));
		string toPrefix = (string.IsNullOrEmpty(ToPrefix) ? "" : (ToPrefix.EndsWith(".") ? ToPrefix : (ToPrefix + ".")));
		list.ForEach(delegate(string f)
		{
			string text = f;
			if (!string.IsNullOrEmpty(fromPrefix) && text.StartsWith(fromPrefix))
			{
				text = text.Remove(0, fromPrefix.Length);
			}
			if (!string.IsNullOrEmpty(toPrefix))
			{
				text = toPrefix + text;
			}
			string value = ((ControllerContext)filterContext).get_HttpContext().Request.Form[f];
			route.Add(text, value);
		});
		filterContext.set_Result((ActionResult)new RedirectToRouteResult(new RouteValueDictionary(route)));
	}
}
