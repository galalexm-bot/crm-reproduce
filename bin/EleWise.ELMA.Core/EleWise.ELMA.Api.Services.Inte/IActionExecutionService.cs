using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("ActionExecution", "")]
internal interface IActionExecutionService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/Execute?scriptName={scriptName}")]
	System.Threading.Tasks.Task<ActionExecutionResponseDto> Execute(ActionExecutionRequestDto model, string scriptName = "");
}
