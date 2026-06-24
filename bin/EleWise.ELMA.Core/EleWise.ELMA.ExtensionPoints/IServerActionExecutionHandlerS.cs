using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.ExtensionPoints;

internal interface IServerActionExecutionHandlerServices
{
	IActionExecutionService ActionExecutionService { get; }

	IProxyGeneratorService ProxyGeneratorService { get; }

	FindComponentService FindComponentService { get; }

	IExtendEntityService ExtendEntityService { get; }
}
