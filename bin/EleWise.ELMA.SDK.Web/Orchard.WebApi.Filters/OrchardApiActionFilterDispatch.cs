using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Orchard.WebApi.Filters;

public class OrchardApiActionFilterDispatcher : IActionFilter, IFilter
{
	public bool AllowMultiple { get; private set; }

	public async Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
	{
		foreach (IActionFilter actionFilter in actionContext.get_ControllerContext().GetWorkContext().Resolve<IEnumerable<IApiFilterProvider>>()
			.OfType<IActionFilter>())
		{
			Func<Task<HttpResponseMessage>> tempContinuation = continuation;
			continuation = () => actionFilter.ExecuteActionFilterAsync(actionContext, cancellationToken, tempContinuation);
		}
		return await continuation();
	}
}
