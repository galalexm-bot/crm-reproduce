using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class CSSController : BaseController
{
	private readonly IEnumerable<IStylePathResolver> styleResolvers;

	public CSSController(IEnumerable<IStylePathResolver> styleResolvers)
	{
		this.styleResolvers = styleResolvers;
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[Compress(Order = 5)]
	[ContentType("text/css", Order = 20)]
	public ActionResult Get(string id)
	{
		IStylePathResolver stylePathResolver = styleResolvers.FirstOrDefault((IStylePathResolver s) => s.ShouldResolve(id));
		if (stylePathResolver != null)
		{
			return (ActionResult)(object)((Controller)this).Content(stylePathResolver.Resolve(id));
		}
		return (ActionResult)(object)((Controller)this).View("Shared/UI/MergedCSSStyles");
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[Compress(Order = 5)]
	[ContentType("text/css", Order = 20)]
	public ActionResult GetPageAppCss(string id)
	{
		return (ActionResult)(object)((Controller)this).View("Shared/UI/PageAppMergedCSSStyles");
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[Compress(Order = 5)]
	[ContentType("text/css", Order = 20)]
	public ActionResult GetColorScheme()
	{
		return (ActionResult)(object)((Controller)this).View("Shared/UI/ColorSchemeCssStyles");
	}

	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 2628000, Order = 10, VaryByParam = "")]
	[Compress(Order = 5)]
	[ContentType("text/css", Order = 20)]
	public ActionResult File(string fileNameWithHash)
	{
		int length = fileNameWithHash.LastIndexOf('/');
		string virtualPath = "~/" + fileNameWithHash.Substring(0, length);
		if (HostingEnvironment.VirtualPathProvider.FileExists(virtualPath))
		{
			using (StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(virtualPath).Open()))
			{
				return (ActionResult)(object)((Controller)this).Content(streamReader.ReadToEnd());
			}
		}
		return (ActionResult)(object)((Controller)this).Content(string.Empty);
	}
}
