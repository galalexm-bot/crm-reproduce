using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Mvc;

namespace Orchard.Localization.Services;

public class CurrentCultureWorkContext : IWorkContextStateProvider, IDependency
{
	private readonly IEnumerable<ICultureSelector> _cultureSelectors;

	private readonly IHttpContextAccessor _httpContextAccessor;

	public CurrentCultureWorkContext(IEnumerable<ICultureSelector> cultureSelectors, IHttpContextAccessor httpContextAccessor)
	{
		_cultureSelectors = cultureSelectors;
		_httpContextAccessor = httpContextAccessor;
	}

	public Func<WorkContext, T> Get<T>(string name)
	{
		if (name == "CurrentCulture")
		{
			string cultureName = GetCurrentCulture();
			return (WorkContext ctx) => (T)(object)cultureName;
		}
		return null;
	}

	private string GetCurrentCulture()
	{
		HttpContextBase httpContext = _httpContextAccessor.Current();
		CultureSelectorResult cultureSelectorResult = (from c in _cultureSelectors
			select c.GetCulture(httpContext) into c
			where c != null
			orderby c.Priority descending
			select c).FirstOrDefault((CultureSelectorResult c) => !string.IsNullOrEmpty(c.CultureName));
		if (cultureSelectorResult != null)
		{
			return cultureSelectorResult.CultureName;
		}
		return string.Empty;
	}
}
