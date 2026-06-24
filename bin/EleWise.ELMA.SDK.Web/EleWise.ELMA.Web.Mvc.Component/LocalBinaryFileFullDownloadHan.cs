using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.HttpHeaders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = 800)]
internal class LocalBinaryFileFullDownloadHandler : IBinaryFileDownloadHandler
{
	private readonly IEnumerable<IEncryptedFileDownloadProvider> encryptedFileDownloads;

	public LocalBinaryFileFullDownloadHandler(IEnumerable<IEncryptedFileDownloadProvider> encryptedFileDownloads)
	{
		this.encryptedFileDownloads = encryptedFileDownloads;
	}

	public bool CanHandle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		if (!new RangeHttpHeader(httpContext.Request.Headers.Get("Range")).IsPresent && binaryFile.ContentLocation != null)
		{
			return binaryFile.ContentLocation.Scheme == "file";
		}
		return false;
	}

	public ActionResult Handle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		if (!binaryFile.Encrypt && cachingOptions != null)
		{
			httpContext.Response.Cache.SetCacheability(HttpCacheability.Private);
			httpContext.Response.Cache.SetValidUntilExpires(validUntilExpires: true);
			httpContext.Response.Cache.SetMaxAge(cachingOptions.MaxAge);
		}
		Stream fileStream;
		if (binaryFile.Encrypt)
		{
			IEncryptedFileDownloadProvider encryptedFileDownloadProvider = encryptedFileDownloads.FirstOrDefault((IEncryptedFileDownloadProvider d) => d.CanDecrypt(binaryFile));
			if (encryptedFileDownloadProvider == null)
			{
				throw new Exception(SR.T("Для файла uid={0} location='{1}' не нашлось подходящего провайдера скачивания шифрованного файла.", binaryFile.Uid, binaryFile.ContentLocation));
			}
			fileStream = encryptedFileDownloadProvider.GetDecryptedContent(binaryFile);
		}
		else
		{
			fileStream = binaryFile.GetContent(GetContentOptions.NonSeekable);
		}
		return (ActionResult)(object)new FileStreamResult(fileStream, binaryFile.ContentType ?? "application/octet-stream")
		{
			FileDownloadName = binaryFile.Name.ReplaceInvalidFileNameChars()
		};
	}
}
