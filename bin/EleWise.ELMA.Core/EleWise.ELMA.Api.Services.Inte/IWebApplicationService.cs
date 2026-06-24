using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("WebApplication", "")]
public interface IWebApplicationService
{
	[GlobalFunction("d1d24e71-e0a6-46b1-a513-69d2b4029caf")]
	System.Threading.Tasks.Task SaveConfigurationFiles(SaveConfigurationFilesRequest request);

	[GlobalFunction("c19269e5-428f-4e44-aedd-4a402f98f193")]
	System.Threading.Tasks.Task<GetFilePlacesResponse> GetFilePlaces(GetFilePlacesRequest request);

	[GlobalFunction("52a7c74e-4075-42b3-969b-269c0c059866")]
	System.Threading.Tasks.Task<GetViewNamesResponse> GetViewNames(GetViewNamesRequest request);

	[GlobalFunction("3fba946f-05de-4f22-b5c2-1027dc364446")]
	System.Threading.Tasks.Task CopyViewFiles(CopyViewFilesRequest request);

	[GlobalFunction("8081762e-9bbc-4930-b4f9-54a78c1c65fb")]
	System.Threading.Tasks.Task<bool> CheckViewExists(CheckViewExistsRequest request);
}
