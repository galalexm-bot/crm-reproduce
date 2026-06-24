using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class JSController : BaseController
{
	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[Compress(Order = 5)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[ContentType("text/javascript", Order = 20)]
	public ActionResult Get(string id)
	{
		return (ActionResult)(object)((Controller)this).View("Shared/UI/MergedJSScripts", new object());
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[Compress(Order = 5)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[ContentType("text/javascript", Order = 20)]
	public ActionResult Globalization(string id)
	{
		CultureInfo cultureInfo = new CultureInfo(id.Substring(0, id.IndexOf('_')));
		CultureInfo cultureInfo4 = (Thread.CurrentThread.CurrentUICulture = (Thread.CurrentThread.CurrentCulture = cultureInfo));
		return (ActionResult)(object)((Controller)this).View("Shared/UI/MergedGlobalizationScripts", new object());
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[Compress(Order = 5)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[ContentType("text/javascript", Order = 20)]
	public ActionResult PageAppScripts(string id)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/PageAppMergedJSScripts", new object());
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[Compress(Order = 5)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[ContentType("text/javascript", Order = 20)]
	public ActionResult InterfaceBuilderScripts(string id)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/InterfaceBuilderMergedJSScripts", new object());
	}
}
