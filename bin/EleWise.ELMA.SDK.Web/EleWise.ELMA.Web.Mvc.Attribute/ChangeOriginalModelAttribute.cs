using System;
using System.Web.Mvc;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class ChangeOriginalModelAttribute : FilterAttribute, IResultFilter
{
	private object oldModel;

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (ContextVars.TryGetValue<object>("ViewItemModel", out oldModel))
		{
			ContextVars.Remove("ViewItemModel");
		}
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
		if (oldModel == null)
		{
			ContextVars.Remove("ViewItemModel");
		}
		else
		{
			ContextVars.Set("ViewItemModel", oldModel);
		}
	}
}
