using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("Application", "")]
public interface IApplicationService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/GetAppInfo")]
	System.Threading.Tasks.Task<PublishApplicationModel> GetAppInfo();

	[Operation(Method = WebMethod.POST, UriTemplate = "/PublishIntoFile")]
	System.Threading.Tasks.Task<string> PublishIntoFile(PublishApplicationModel model);

	[Operation(Method = WebMethod.GET, UriTemplate = "/GetConnectionStatus")]
	System.Threading.Tasks.Task<ConnectionStatus> GetConnectionStatus();

	[Operation(Method = WebMethod.POST, UriTemplate = "/PublishIntoELMA")]
	System.Threading.Tasks.Task<string> PublishIntoELMA(PublishApplicationModel model);

	[Operation(Method = WebMethod.POST, UriTemplate = "/ClearAllCaches")]
	System.Threading.Tasks.Task<string> ClearAllCaches();

	[Operation(Method = WebMethod.POST, UriTemplate = "/ClearStartupCache")]
	System.Threading.Tasks.Task ClearStartupCache();

	[Operation(Method = WebMethod.POST, UriTemplate = "/ClearBuildCache")]
	System.Threading.Tasks.Task ClearBuildCache();

	[Operation(Method = WebMethod.POST, UriTemplate = "/ClearModuleRepositoryCache")]
	System.Threading.Tasks.Task ClearModuleRepositoryCache();
}
