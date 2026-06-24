using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class EntityFormAttribute : ActionFilterAttribute
{
	public string PostAction { get; set; }

	public string AreaName { get; set; }

	public EntityFormAttribute()
	{
	}

	public EntityFormAttribute(string postAction, string areaName)
	{
		PostAction = postAction;
		AreaName = areaName;
	}

	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (((ControllerContext)filterContext).get_RouteData().Values.TryGetValue("prefix", out var value) && value != null)
		{
			string text = value.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				((ControllerContext)filterContext).get_Controller().get_ViewData().get_TemplateInfo()
					.set_HtmlFieldPrefix(text);
				((ControllerContext)filterContext).get_Controller().get_ViewData().set_Item("CreatorRequest", (object)true);
				((ControllerContext)filterContext).get_Controller().get_ViewData().set_Item("CreatorPrefix", (object)text);
			}
		}
	}
}
