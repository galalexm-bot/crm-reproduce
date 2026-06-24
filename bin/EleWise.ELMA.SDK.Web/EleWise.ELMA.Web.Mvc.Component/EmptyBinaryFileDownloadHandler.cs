using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = int.MaxValue)]
internal class EmptyBinaryFileDownloadHandler : IBinaryFileDownloadHandler
{
	public bool CanHandle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		return binaryFile.ContentLocation == null;
	}

	public ActionResult Handle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			result = false,
			error = SR.T("У файла (Id={0}, Uid={1}, Name={2}) отсутствует контент", binaryFile.Id, binaryFile.Uid, binaryFile.Name.ReplaceInvalidFileNameChars())
		});
		return (ActionResult)(object)val;
	}
}
