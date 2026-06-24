using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("ScriptExecution", "")]
internal interface IScriptExecutionService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/ExecuteScript?scriptName={scriptName}")]
	System.Threading.Tasks.Task<ScriptExecutionResponseDto> ExecuteScript(ScriptExecutionRequestDto model, string scriptName = "");
}
