using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace Orchard.WebApi.Filters;

public class OrchardApiExceptionFilterDispatcher : IExceptionFilter, IFilter
{
	public bool AllowMultiple { get; private set; }

	public async Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
	{
		WorkContext workContext = actionExecutedContext.get_ActionContext().get_ControllerContext().GetWorkContext();
		foreach (IExceptionFilter item in workContext.Resolve<IEnumerable<IApiFilterProvider>>().OfType<IExceptionFilter>())
		{
			await item.ExecuteExceptionFilterAsync(actionExecutedContext, cancellationToken);
		}
	}
}
