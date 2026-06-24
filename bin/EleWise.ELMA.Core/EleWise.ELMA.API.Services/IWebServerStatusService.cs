using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[BaseWebService]
public interface IWebServerStatusService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "StartInfoHandler.ashx", BodyContentType = "application/x-www-form-urlencoded")]
	System.Threading.Tasks.Task<string> GetServerStatus(string type);
}
