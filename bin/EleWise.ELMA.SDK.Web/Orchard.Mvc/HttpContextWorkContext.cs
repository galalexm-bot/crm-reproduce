using System;

namespace Orchard.Mvc;

public class HttpContextWorkContext : IWorkContextStateProvider, IDependency
{
	private readonly IHttpContextAccessor _httpContextAccessor;

	public HttpContextWorkContext(IHttpContextAccessor httpContextAccessor)
	{
		_httpContextAccessor = httpContextAccessor;
	}

	public Func<WorkContext, T> Get<T>(string name)
	{
		if (name == "HttpContext")
		{
			T result = (T)(object)_httpContextAccessor.Current();
			return (WorkContext ctx) => result;
		}
		return null;
	}
}
