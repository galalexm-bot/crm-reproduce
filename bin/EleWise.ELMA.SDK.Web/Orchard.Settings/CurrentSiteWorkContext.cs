using System;

namespace Orchard.Settings;

public class CurrentSiteWorkContext : IWorkContextStateProvider, IDependency
{
	private readonly ISiteService _siteService;

	public CurrentSiteWorkContext(ISiteService siteService)
	{
		_siteService = siteService;
	}

	public Func<WorkContext, T> Get<T>(string name)
	{
		if (name == "CurrentSite")
		{
			ISite siteSettings = _siteService.GetSiteSettings();
			return (WorkContext ctx) => (T)siteSettings;
		}
		return null;
	}
}
