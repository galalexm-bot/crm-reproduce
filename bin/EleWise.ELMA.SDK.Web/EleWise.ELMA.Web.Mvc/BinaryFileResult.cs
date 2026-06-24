using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc;

public class BinaryFileResult : ActionResult
{
	private readonly BinaryFile binaryFile;

	private readonly BinaryFileCachingOptions cachingOptions;

	private static IEnumerable<IBinaryFileDownloadHandler> downloadHandlers;

	static BinaryFileResult()
	{
		downloadHandlers = ComponentManager.Current.GetExtensionPoints<IBinaryFileDownloadHandler>();
	}

	public BinaryFileResult(BinaryFile binaryFile)
	{
		this.binaryFile = binaryFile;
	}

	public BinaryFileResult(BinaryFile binaryFile, BinaryFileCachingOptions cachingOptions)
	{
		this.binaryFile = binaryFile;
		this.cachingOptions = cachingOptions;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		IBinaryFileDownloadHandler binaryFileDownloadHandler = downloadHandlers.FirstOrDefault((IBinaryFileDownloadHandler h) => h.CanHandle(binaryFile, context.get_HttpContext(), cachingOptions));
		((binaryFileDownloadHandler != null) ? binaryFileDownloadHandler.Handle(binaryFile, context.get_HttpContext(), cachingOptions) : GetUnsupportedError(binaryFile)).ExecuteResult(context);
	}

	private ActionResult GetUnsupportedError(BinaryFile binaryFile)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Logger.Log.ErrorFormat("No download handlers can be found for BinaryFile(Id='{0}', Uid='{1}', Name='{2}', ContentType='{3}', ContentLocation='{4}')", binaryFile.Id, binaryFile.Uid, binaryFile.Name, binaryFile.ContentType, binaryFile.ContentLocation);
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			result = false,
			error = SR.T("Скачивание файла (Id={0}, Uid={1}, Name={2}) не поддерживается.", binaryFile.Id, binaryFile.Uid, binaryFile.Name)
		});
		return (ActionResult)(object)val;
	}
}
