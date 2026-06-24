using System;
using System.Web.Mvc;

namespace Orchard.Mvc.Filters;

public interface IFilterProvider : IDependency
{
	[Obsolete]
	void AddFilters(FilterInfo filterInfo);
}
