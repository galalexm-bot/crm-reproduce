using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.API.Services;

[InternalWebService("ScriptMethods", "")]
public interface IScriptMethodsService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/GenerateMethodCode")]
	System.Threading.Tasks.Task<GenerateMethodCodeResponseDto> GenerateMethodCode(GenerateMethodCodeRequestDto request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/ParseMethods")]
	System.Threading.Tasks.Task<ScriptMethodDeclarationDto[]> ParseMethods(ParseMethodsRequestDto request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/AddInterface")]
	System.Threading.Tasks.Task<AddInterfaceResponseDto> AddInterface(AddInterfaceRequestDto request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/InterfaceExists")]
	System.Threading.Tasks.Task<bool> InterfaceExists(InterfaceExistsRequestDto request);
}
