using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[CoreWebService("Authorization")]
internal interface IAuthorizationService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/RefreshToken?refreshToken={refreshToken}")]
	System.Threading.Tasks.Task<JwtAuthResponse> RefreshToken(string refreshToken);
}
