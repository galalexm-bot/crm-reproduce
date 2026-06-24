using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "Description")]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IAuthorizationService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Version")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "VersionDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "VersionResultDescription")]
	string Version();

	[OperationContract]
	[WebGet(UriTemplate = "/ApiVersion?all={allServices}")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "ApiVersionDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "ApiVersionResultDescription")]
	ApiVersionResponse ApiVersion(bool allServices);

	[OperationContract]
	[WebGet(UriTemplate = "/ServerTime")]
	[AuthorizeOperationBehavior]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "ServerTimeDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "ServerTimeResultDescription")]
	DateTime ServerTime();

	[OperationContract]
	[WebGet(UriTemplate = "/ServerTimeUTC")]
	[AuthorizeOperationBehavior]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "ServerTimeUTCDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "ServerTimeUTCResultDescription")]
	DateTime ServerTimeUTC();

	[OperationContract]
	[WebGet(UriTemplate = "/CheckToken?token={token}")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "CheckTokenDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "CheckTokenResultDescription")]
	AuthResponse CheckToken([WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "CheckTokenTokenParamDescription")] Guid token);

	[OperationContract]
	[WebGet(UriTemplate = "/RefreshToken?refreshToken={refreshToken}")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "RefreshTokenDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "RefreshTokenResultDescription")]
	JwtAuthResponse RefreshToken([WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "RefreshTokenTokenParamDescription")] string refreshToken);

	[OperationContract]
	[WebGet(UriTemplate = "/LoginWith?basic=1")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithBasicDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithBasicResultDescription")]
	AuthResponse LoginWithBasic();

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/LoginWith?username={username}")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithUserNameDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithUserNameResultDescription")]
	AuthResponse LoginWithUserName([WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithUserNameUsernameParamDescription")] string username, [WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithUserNamePasswordParamDescription")] string password);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/LoginWithJwt?username={username}")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "LoginJwtDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginJwtResultDescription")]
	JwtAuthResponse LoginJwt([WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginJwtUsernameParamDescription")] string username, [WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginJwtPasswordParamDescription")] string password);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/LoginWithSSPI")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithSspiTicketDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithSspiTicketResultDescription")]
	AuthResponse LoginWithSSPI([WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "LoginWithSspiTicketParamDescription")] string ticket);

	[OperationContract]
	[AuthorizeOperationBehavior]
	[WebGet(UriTemplate = "/TemporaryGuid")]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "TemporaryGuidDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "TemporaryGuidResultDescription")]
	Guid TemporaryGuid();

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/CheckPermissions")]
	[AuthorizeOperationBehavior]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "CheckPermissionsDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "CheckPermissionsResultDescription")]
	CheckPermissionResponse[] CheckPermissions([WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "CheckPermissionsRequestListParamDescription")] CheckPermissionRequest[] requestList);

	[OperationContract]
	[WebGet(UriTemplate = "/ApplicationLogOut")]
	[AuthorizeOperationBehavior]
	[WsdlDocumentation(typeof(__IAuthorizationServiceResources), "ApplicationLogOutDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IAuthorizationServiceResources), "ApplicationLogOutResultDescription")]
	LogOutResponse ApplicationLogOut();
}
