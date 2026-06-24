using System.Web;
using Orchard.Commands;
using Orchard.ContentManagement;
using Orchard.Core.Settings.Models;
using Orchard.Mvc;
using Orchard.Mvc.Extensions;
using Orchard.Settings;
using Orchard.Utility.Extensions;

namespace Orchard.Core.Settings.Commands;

public class SiteSettingsCommands : DefaultOrchardCommandHandler
{
	private readonly IHttpContextAccessor _httpContextAccessor;

	private readonly ISiteService _siteService;

	[OrchardSwitch]
	public string BaseUrl { get; set; }

	[OrchardSwitch]
	public bool Force { get; set; }

	public SiteSettingsCommands(IHttpContextAccessor httpContextAccessor, ISiteService siteService)
	{
		_httpContextAccessor = httpContextAccessor;
		_siteService = siteService;
	}

	[CommandName("site setting set baseurl")]
	[CommandHelp("site setting set baseurl [/BaseUrl:baseUrl] [/Force:true]\r\n\tSet the 'BaseUrl' site settings. If no base url is provided, use the current request context heuristic to discover the base url. If 'Force' is true, set the site base url even if it is already set. The default behavior is to not override the setting.")]
	[OrchardSwitches("BaseUrl,Force")]
	public void SetBaseUrl()
	{
		if (!string.IsNullOrEmpty(_siteService.GetSiteSettings().BaseUrl) && !Force)
		{
			base.Context.Output.WriteLine(base.T("'BaseUrl' site setting is already set. Use the 'Force' flag to override."));
			return;
		}
		if (string.IsNullOrEmpty(BaseUrl))
		{
			if (_httpContextAccessor.Current().IsBackgroundContext())
			{
				base.Context.Output.WriteLine(base.T("No HTTP request available to determine the base url of the site"));
				return;
			}
			HttpRequestBase request = _httpContextAccessor.Current().Request;
			BaseUrl = request.ToApplicationRootUrlString();
		}
		_siteService.GetSiteSettings().As<SiteSettingsPart>().BaseUrl = BaseUrl;
		base.Context.Output.WriteLine(base.T("'BaseUrl' site setting set to '{0}'", BaseUrl));
	}
}
