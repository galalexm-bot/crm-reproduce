using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace EleWise.ELMA.Web.Mvc.Handlers;

public sealed class TypeControllerHandler : IHttpHandler, IRequiresSessionState
{
	private readonly RequestContext _context;

	private readonly Type _controllerType;

	public bool IsReusable => false;

	public TypeControllerHandler(RequestContext context, Type controllerType)
	{
		_context = context;
		_controllerType = controllerType;
	}

	public void ProcessRequest(HttpContext context)
	{
		IController val = CreateControllerInstance();
		try
		{
			val.Execute(_context);
		}
		finally
		{
			ReleaseController(val);
		}
	}

	private static void ReleaseController(IController controller)
	{
		if (controller is IDisposable disposable)
		{
			disposable.Dispose();
		}
	}

	private IController CreateControllerInstance()
	{
		return (IController)(((object)ControllerBuilder.get_Current().GetControllerFactory().CreateController(_context, _controllerType.Name)) ?? ((object)/*isinst with value type is only supported in some contexts*/));
	}
}
