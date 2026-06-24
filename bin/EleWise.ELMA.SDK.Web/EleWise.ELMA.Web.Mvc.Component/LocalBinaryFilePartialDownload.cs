using System;
using System.IO;
using System.Net;
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
internal class LocalBinaryFilePartialDownloadHandler : IBinaryFileDownloadHandler
{
	public bool CanHandle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		if (new RangeHttpHeader(httpContext.Request.Headers.Get("Range")).IsPresent && binaryFile.ContentLocation != null)
		{
			return binaryFile.ContentLocation.Scheme == "file";
		}
		return false;
	}

	public ActionResult Handle(BinaryFile binaryFile, HttpContextBase httpContext, BinaryFileCachingOptions cachingOptions)
	{
		Stream content = binaryFile.GetContent();
		long length = content.Length;
		RangeHttpHeader rangeHttpHeader = new RangeHttpHeader(httpContext.Request.Headers.Get("Range"), length);
		if (!rangeHttpHeader.IsValid)
		{
			return InvalidRangeError();
		}
		if (rangeHttpHeader.Ranges.Length > 1)
		{
			return MultipleRangesNotSupported();
		}
		RangeHttpHeader.RangeItem rangeItem = rangeHttpHeader.Ranges[0];
		if (rangeItem.Start >= length)
		{
			return RangeNotSatisfiable();
		}
		long start = rangeItem.Start;
		long num = Math.Min(rangeItem.End, length - 1);
		httpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
		httpContext.Response.AddHeader("Accept-Ranges", "bytes");
		httpContext.Response.Headers.Add("Content-Range", $"bytes {start}-{num}/{length}");
		httpContext.Response.StatusCode = 206;
		return (ActionResult)(object)new FileStreamResult(new RangeStreamWrapper(content, start, num), binaryFile.ContentType ?? "application/octet-stream")
		{
			FileDownloadName = binaryFile.Name.ReplaceInvalidFileNameChars()
		};
	}

	private ActionResult RangeNotSatisfiable()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.RequestedRangeNotSatisfiable);
	}

	private ActionResult InvalidRangeError()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			result = false,
			error = SR.T("Некорректный диапазон")
		});
		return (ActionResult)val;
	}

	private ActionResult MultipleRangesNotSupported()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			result = false,
			error = SR.T("Множественные диапазоны в заголовке Range не поддерживаются")
		});
		return (ActionResult)val;
	}
}
