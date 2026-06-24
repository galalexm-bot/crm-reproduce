using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.API.Services;

[InternalWebService("AssemblyReference", "")]
internal interface IAssemblyReferenceService
{
	[GlobalFunction("e9dc0c7d-3941-41de-bec3-855dda602f5b")]
	System.Threading.Tasks.Task<string[]> GetDefaultReferences();

	[GlobalFunction("b5e6f778-be00-4783-a7b8-b1812eea993b")]
	System.Threading.Tasks.Task<string[]> GetGlobalAssemblies();

	[GlobalFunction("3ea1c673-0f85-46ba-b6f2-fdc6552a2a2d")]
	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<AssemblyReference>> GetGlobalModules();

	[Operation(Method = WebMethod.POST, UriTemplate = "/DiscoverServiceReference")]
	System.Threading.Tasks.Task<DiscoverServiceReferenceResponseDto> DiscoverServiceReference(DiscoverServiceReferenceRequestDto request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/DiscoverWebReference")]
	System.Threading.Tasks.Task<DiscoverServiceReferenceResponseDto> DiscoverWebReference(DiscoverServiceReferenceRequestDto request);
}
