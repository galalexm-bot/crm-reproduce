using System;
using System.IO;
using System.Web;
using System.Web.Hosting;
using System.Web.SessionState;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;

namespace EleWise.ELMA.Web.Mvc.Handlers;

public class StaticContentHandler : IHttpHandler, IReadOnlySessionState, IRequiresSessionState
{
	private IMimeMappingService mimeMappingService;

	private static readonly IMimeMappingService StaticMappingService = new MimeMappingService();

	private IMimeMappingService Mapping
	{
		get
		{
			if (Locator.Initialized)
			{
				if (mimeMappingService == null)
				{
					mimeMappingService = Locator.GetService<IMimeMappingService>();
				}
				return mimeMappingService ?? StaticMappingService;
			}
			return StaticMappingService;
		}
	}

	public bool IsReusable => true;

	public void ProcessRequest(HttpContext context)
	{
		Logger.Log.Verbose("ProcessRequest " + context.Request.Path);
		string text = context.Request.Path;
		if (text.StartsWith("/Custom/"))
		{
			text = text.Substring("/Custom/".Length - 1);
		}
		if (HostingEnvironment.VirtualPathProvider.FileExists(text))
		{
			context.Response.Cache.SetExpires(DateTime.Today.AddDays(60.0));
			context.Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
			string extension = Path.GetExtension(text).ToLower();
			context.Response.ContentType = Mapping.GetTypeByExtension(extension);
			using Stream stream = HostingEnvironment.VirtualPathProvider.GetFile(text).Open();
			stream.CopyTo(context.Response.OutputStream);
			return;
		}
		Logger.Log.Verbose("File NotFound " + context.Request.Path);
		context.Response.StatusCode = 404;
		context.Response.Flush();
	}
}
