using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Handlers;

public sealed class TypeControllerRouteHandler : IRouteHandler
{
	private readonly Type controllerType;

	public TypeControllerRouteHandler(Type controllerType)
	{
		if (typeof(IController).IsAssignableFrom(controllerType))
		{
			this.controllerType = controllerType;
			return;
		}
		throw new ArgumentException(SR.T("Переданный тип {0} должен наследовать тип {1}", controllerType, typeof(IController)));
	}

	IHttpHandler IRouteHandler.GetHttpHandler(RequestContext context)
	{
		return GetHttpHandler(context);
	}

	private IHttpHandler GetHttpHandler(RequestContext context)
	{
		return new TypeControllerHandler(context, controllerType);
	}
}
