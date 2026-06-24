using System;
using System.Web.Mvc;

namespace Orchard.Mvc.Filters;

public abstract class FilterProvider : IFilterProvider, IDependency
{
	[Obsolete]
	void IFilterProvider.AddFilters(FilterInfo filterInfo)
	{
		AddFilters(filterInfo);
	}

	[Obsolete]
	protected virtual void AddFilters(FilterInfo filterInfo)
	{
		if (this is IAuthorizationFilter)
		{
			filterInfo.get_AuthorizationFilters().Add((IAuthorizationFilter)(object)((this is IAuthorizationFilter) ? this : null));
		}
		if (this is IActionFilter)
		{
			filterInfo.get_ActionFilters().Add((IActionFilter)(object)((this is IActionFilter) ? this : null));
		}
		if (this is IResultFilter)
		{
			filterInfo.get_ResultFilters().Add((IResultFilter)(object)((this is IResultFilter) ? this : null));
		}
		if (this is IExceptionFilter)
		{
			filterInfo.get_ExceptionFilters().Add((IExceptionFilter)(object)((this is IExceptionFilter) ? this : null));
		}
	}
}
