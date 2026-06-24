using System.Web;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using Orchard.Localization;
using Orchard.Mvc;
using Orchard.Mvc.Extensions;
using Orchard.Services;
using Orchard.Utility.Extensions;

namespace Orchard.Environment;

public class DefaultHostEnvironment : HostEnvironment
{
	private readonly IClock _clock;

	private readonly IHttpContextAccessor _httpContextAccessor;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public DefaultHostEnvironment(IClock clock, IHttpContextAccessor httpContextAccessor)
	{
		_clock = clock;
		_httpContextAccessor = httpContextAccessor;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public override void RestartAppDomain()
	{
		AppRestartHelper.RestartAppDomain();
		HttpContextBase httpContextBase = _httpContextAccessor.Current();
		if (!httpContextBase.IsBackgroundContext())
		{
			httpContextBase.Response.Redirect(HttpContext.Current.Request.ToUrlString(), endResponse: true);
		}
	}
}
