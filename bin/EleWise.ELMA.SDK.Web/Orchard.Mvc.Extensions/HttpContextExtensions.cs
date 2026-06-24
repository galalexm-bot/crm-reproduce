using System.Web;

namespace Orchard.Mvc.Extensions;

public static class HttpContextExtensions
{
	public static bool IsBackgroundHttpContext(this HttpContext httpContext)
	{
		return HttpContextAccessor.IsBackgroundHttpContext(httpContext);
	}
}
