using System.Web.Mvc;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines;

public class WebFormViewEngine : WebFormViewEngine
{
	protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
	{
		return ((VirtualPathProviderViewEngine)this).get_VirtualPathProvider().FileExists(virtualPath);
	}
}
