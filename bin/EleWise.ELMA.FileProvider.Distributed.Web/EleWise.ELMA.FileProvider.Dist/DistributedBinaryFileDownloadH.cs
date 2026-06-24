using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FileProvider.Distributed.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.FileProvider.Distributed.Web.Components;

[Component(Order = 500)]
internal class DistributedBinaryFileDownloadHandler : IBinaryFileDownloadHandler
{
	private readonly IEnumerable<IEncryptedFileDownloadProvider> encryptedFileDownloads;

	public IDownloadUrlService DownloadUrlService { get; set; }

	public DistributedBinaryFileDownloadHandler(IEnumerable<IEncryptedFileDownloadProvider> encryptedFileDownloads)
	{
		this.encryptedFileDownloads = encryptedFileDownloads;
	}

	public bool CanHandle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		if (binaryFile.ContentLocation != null && binaryFile.ContentLocation.Scheme == "elma")
		{
			return cachingOptions == null;
		}
		return false;
	}

	public ActionResult Handle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		httpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
		string password = null;
		if (binaryFile.Encrypt)
		{
			IEncryptedFileDownloadProvider encryptedFileDownloadProvider = encryptedFileDownloads.FirstOrDefault((IEncryptedFileDownloadProvider d) => d.CanDecrypt(binaryFile));
			if (encryptedFileDownloadProvider == null)
			{
				throw new Exception(SR.T("Для файла uid={0} location='{1}' не нашлось подходящего провайдера скачивания шифрованного файла.", binaryFile.Uid, binaryFile.ContentLocation));
			}
			password = encryptedFileDownloadProvider.GetPassword(binaryFile);
		}
		return (ActionResult)new RedirectResult(DownloadUrlService.GetDownloadUrl(binaryFile, password).AbsoluteUri);
	}
}
