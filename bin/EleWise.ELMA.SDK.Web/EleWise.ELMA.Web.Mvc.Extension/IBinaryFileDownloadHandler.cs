using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IBinaryFileDownloadHandler
{
	bool CanHandle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions);

	ActionResult Handle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions);
}
