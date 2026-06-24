using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Services.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.OmniSharp.Api.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("OmniSharp", "")]
public interface IOmniSharpService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/Start?needRestart={needRestart}")]
	System.Threading.Tasks.Task Start(bool needRestart);

	[GlobalFunction("4e92f2eb-ec2c-4d84-a65a-77a7dbcd77c1")]
	System.Threading.Tasks.Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/GetResult")]
	System.Threading.Tasks.Task<string> GetResult(OmniSharpRequest request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/AddReferences")]
	System.Threading.Tasks.Task AddReferences(AddReferencesRequest request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/RemoveReferences")]
	System.Threading.Tasks.Task RemoveReferences(RemoveReferencesRequest request);
}
