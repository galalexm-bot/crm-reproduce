using System;
using System.Web;
using Orchard.Environment.Extensions.Models;
using Orchard.Mvc;

namespace Orchard.Themes;

public class CurrentThemeWorkContext : IWorkContextStateProvider, IDependency
{
	private readonly IThemeManager _themeManager;

	private readonly IHttpContextAccessor _httpContextAccessor;

	public CurrentThemeWorkContext(IThemeManager themeManager, IHttpContextAccessor httpContextAccessor)
	{
		_themeManager = themeManager;
		_httpContextAccessor = httpContextAccessor;
	}

	public Func<WorkContext, T> Get<T>(string name)
	{
		if (name == "CurrentTheme")
		{
			HttpContextBase httpContextBase = _httpContextAccessor.Current();
			ExtensionDescriptor currentTheme = ((httpContextBase != null && httpContextBase.Request != null) ? _themeManager.GetRequestTheme(httpContextBase.Request.RequestContext) : null);
			return (WorkContext ctx) => (T)(object)currentTheme;
		}
		return null;
	}
}
