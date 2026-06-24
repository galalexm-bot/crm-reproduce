using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Orchard.Mvc.Filters;

public class OrchardFilterProvider : IFilterProvider
{
	public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
	{
		return controllerContext.GetWorkContext().Resolve<IEnumerable<IFilterProvider>>().Reverse()
			.Select((Func<IFilterProvider, int, Filter>)((IFilterProvider filter, int index) => new Filter((object)filter, (FilterScope)30, (int?)(-(index + 1)))));
	}
}
