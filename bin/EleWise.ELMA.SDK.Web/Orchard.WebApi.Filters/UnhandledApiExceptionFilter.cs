using System.Threading.Tasks;
using System.Web.Http.Filters;
using EleWise.ELMA.Logging;
using Orchard.Logging;

namespace Orchard.WebApi.Filters;

public class UnhandledApiExceptionFilter : ExceptionFilterAttribute, IApiFilterProvider, IDependency
{
	public ILogger Logger { get; set; }

	public UnhandledApiExceptionFilter()
	{
		Logger = NullLogger.Instance;
	}

	public override void OnException(HttpActionExecutedContext actionExecutedContext)
	{
		if (actionExecutedContext.get_Exception() is TaskCanceledException)
		{
			Logger.Warning(actionExecutedContext.get_Exception(), "A pending API operation was canceled by the client.");
		}
		else
		{
			Logger.Error(actionExecutedContext.get_Exception(), "An unhandled exception was thrown in an API operation.");
		}
	}
}
