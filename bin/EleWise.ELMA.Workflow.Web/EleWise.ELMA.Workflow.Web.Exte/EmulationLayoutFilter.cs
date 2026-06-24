using System;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using Orchard;
using Orchard.Mvc.Filters;

namespace EleWise.ELMA.Workflow.Web.Extensions;

public class EmulationLayoutFilter : FilterProvider, IResultFilter
{
	private readonly IWorkContextAccessor wca;

	public EmulationLayoutFilter(IWorkContextAccessor wca)
	{
		this.wca = wca;
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		try
		{
			if (wca != null && filterContext != null && ((ControllerContext)filterContext).get_RouteData() != null && ((ControllerContext)filterContext).get_RouteData().Values != null)
			{
				WorkContext context = wca.GetContext();
				if (context != null && context.HttpContext != null && context.HttpContext.Session != null && (((string)(((ControllerContext)filterContext).get_RouteData().Values["controller"] ?? string.Empty)).Equals("ProcessStartEmulation", StringComparison.OrdinalIgnoreCase) || (SessionVars.TryGetValue<bool>("isEmulation", out var value) && value)))
				{
					context.Layout.Metadata.Alternates.Add("EmulationLayout");
				}
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error("Ошибка применения фильтра", exception);
		}
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}
}
