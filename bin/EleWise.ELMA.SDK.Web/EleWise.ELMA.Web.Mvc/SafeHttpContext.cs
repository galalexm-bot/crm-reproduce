using System;
using System.Web;

namespace EleWise.ELMA.Web.Mvc;

public class SafeHttpContext : IDisposable
{
	private readonly HttpContext oldContext;

	public static SafeHttpContext Create()
	{
		return new SafeHttpContext();
	}

	public SafeHttpContext()
	{
		oldContext = HttpContext.Current;
		if (HttpContext.Current == null)
		{
			HttpContext.Current = new HttpContext(new HttpRequest(null, "http://www", ""), new HttpResponse(null));
		}
	}

	public void Dispose()
	{
		HttpContext.Current = oldContext;
	}
}
