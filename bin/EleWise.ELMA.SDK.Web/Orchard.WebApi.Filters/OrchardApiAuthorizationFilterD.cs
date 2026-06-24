using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Orchard.WebApi.Filters;

public class OrchardApiAuthorizationFilterDispatcher : IAuthorizationFilter, IFilter
{
	public bool AllowMultiple { get; private set; }

	public async Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
	{
		foreach (IAuthorizationFilter actionFilter in actionContext.get_ControllerContext().GetWorkContext().Resolve<IEnumerable<IApiFilterProvider>>()
			.OfType<IAuthorizationFilter>())
		{
			Func<Task<HttpResponseMessage>> tempContinuation = continuation;
			continuation = () => actionFilter.ExecuteAuthorizationFilterAsync(actionContext, cancellationToken, tempContinuation);
		}
		return await continuation();
	}
}
