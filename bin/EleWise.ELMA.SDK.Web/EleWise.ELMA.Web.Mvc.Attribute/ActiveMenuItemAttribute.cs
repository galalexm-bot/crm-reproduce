using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class ActiveMenuItemAttribute : ActionFilterAttribute
{
	public string ItemName { get; set; }

	public int Level { get; set; }

	public ActiveMenuItemAttribute(string itemName)
	{
		ItemName = itemName;
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		if (!string.IsNullOrWhiteSpace(ItemName))
		{
			ControllerBase controller = ((ControllerContext)filterContext).get_Controller();
			((Controller)(object)((controller is Controller) ? controller : null))?.SetCurrentMenuItem(ItemName);
		}
	}
}
