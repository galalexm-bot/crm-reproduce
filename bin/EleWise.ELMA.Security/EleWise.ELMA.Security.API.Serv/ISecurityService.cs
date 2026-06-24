using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Security.API.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Security.API.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__ISecurityServiceResources), "ServiceDescription")]
public interface ISecurityService
{
	[WsdlDocumentation(typeof(__ISecurityServiceResources), "GetSubordinateUsersDescription")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[OperationContract]
	[WebGet(UriTemplate = "/GetSubordinateUsers")]
	[return: WsdlParamOrReturnDocumentation(typeof(__ISecurityServiceResources), "GetSubordinateUsersResultDescription")]
	SubordinateUsersResponse GetSubordinateUsers();

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/AddUserToGroup?userId={userId}&userGroupUid={userGroupUid}")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__ISecurityServiceResources), "AddUserToGroupDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__ISecurityServiceResources), "AddUserToGroupResultDescription")]
	bool AddUserToGroup([WsdlParamOrReturnDocumentation(typeof(__ISecurityServiceResources), "AddUserToGroupUserIdDescription")] long userId, [WsdlParamOrReturnDocumentation(typeof(__ISecurityServiceResources), "AddUserToGroupUserGroupIdDescription")] Guid userGroupUid);
}
