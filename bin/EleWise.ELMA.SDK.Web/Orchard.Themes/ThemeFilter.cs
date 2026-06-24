using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Filters;
using Orchard.UI.Admin;

namespace Orchard.Themes;

public class ThemeFilter : FilterProvider, IActionFilter, IResultFilter
{
	public void OnActionExecuting(ActionExecutingContext filterContext)
	{
		ThemedAttribute themedAttribute = GetThemedAttribute(filterContext.get_ActionDescriptor());
		if (AdminFilter.IsApplied(((ControllerContext)filterContext).get_RequestContext()))
		{
			if (themedAttribute == null || themedAttribute.Enabled)
			{
				Apply(((ControllerContext)filterContext).get_RequestContext());
			}
		}
		else if (themedAttribute != null && themedAttribute.Enabled)
		{
			Apply(((ControllerContext)filterContext).get_RequestContext());
		}
	}

	public void OnActionExecuted(ActionExecutedContext filterContext)
	{
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}

	public static void Apply(RequestContext context)
	{
		context.HttpContext.Items[typeof(ThemeFilter)] = null;
	}

	public static void Disable(RequestContext context)
	{
		context.HttpContext.Items.Remove(typeof(ThemeFilter));
	}

	public static bool IsApplied(RequestContext context)
	{
		return context.HttpContext.Items.Contains(typeof(ThemeFilter));
	}

	private static ThemedAttribute GetThemedAttribute(ActionDescriptor descriptor)
	{
		return descriptor.GetCustomAttributes(typeof(ThemedAttribute), true).Concat(descriptor.get_ControllerDescriptor().GetCustomAttributes(typeof(ThemedAttribute), true)).OfType<ThemedAttribute>()
			.FirstOrDefault();
	}
}
