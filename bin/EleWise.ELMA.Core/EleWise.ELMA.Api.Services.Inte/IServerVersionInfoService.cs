using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("ServerVersionInfo", "")]
public interface IServerVersionInfoService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/GetInfo")]
	System.Threading.Tasks.Task<ServerVersionInfo> GetInfo();

	[Operation(Method = WebMethod.POST, UriTemplate = "/UpdateSession")]
	System.Threading.Tasks.Task UpdateSession();
}
