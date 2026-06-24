using System.Web.Http.Filters;
using Orchard.WebApi.Filters;

namespace Orchard.Data;

public class WebApiTransactionFilter : ExceptionFilterAttribute, IApiFilterProvider, IDependency
{
	private readonly ITransactionManager _transactionManager;

	public WebApiTransactionFilter(ITransactionManager transactionManager)
	{
		_transactionManager = transactionManager;
	}

	public override void OnException(HttpActionExecutedContext actionExecutedContext)
	{
		_transactionManager.Cancel();
	}
}
