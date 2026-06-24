using System;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.FileProvider.Distributed.Web.Components;

[Component(Order = 500)]
internal class DistributedCachableBinaryFileDownloadHandler : IBinaryFileDownloadHandler
{
	public bool CanHandle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		if (binaryFile.ContentLocation != null && binaryFile.ContentLocation.Scheme == "elma")
		{
			return cachingOptions != null;
		}
		return false;
	}

	public ActionResult Handle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		string key = string.Format("cached-content-{0}", binaryFile.Uid.ToString("N"));
		byte[] array = httpContext.Cache[key] as byte[];
		if (array == null)
		{
			array = new byte[binaryFile.GetSize()];
			Stream content = binaryFile.GetContent(GetContentOptions.NonSeekable);
			MemoryStream memoryStream = MemoryHelper.GetMemoryStream(array, writable: true);
			content.CopyAllBytesToStream(memoryStream);
			httpContext.Cache.Add(key, array, null, DateTime.Now.Add(cachingOptions.MaxAge), System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
		}
		httpContext.Response.Cache.SetCacheability(HttpCacheability.Private);
		httpContext.Response.Cache.SetValidUntilExpires(validUntilExpires: true);
		httpContext.Response.Cache.SetMaxAge(cachingOptions.MaxAge);
		return (ActionResult)new FileContentResult(array, binaryFile.ContentType);
	}
}
