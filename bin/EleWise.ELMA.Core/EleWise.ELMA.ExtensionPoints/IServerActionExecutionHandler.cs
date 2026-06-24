using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.ExtensionPoints;
using EleWise.ELMA.Model.Actions;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint]
internal interface IServerActionExecutionHandler : IActionExecutionHandler
{
	ActionExecutionRequestDto CreateRequest(IActionExecutionContext context);
}
