using System;
using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Security;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
public abstract class BasePermissionAttribute : ActionFilterAttribute
{
	private static IPermissionManagmentService _permissionManagmentService;

	private static IAuthenticationService _authenticationService;

	private static ISecurityService _securityService;

	protected static IPermissionManagmentService PermissionManagmentService => _permissionManagmentService ?? (_permissionManagmentService = Locator.GetServiceNotNull<IPermissionManagmentService>());

	protected static IAuthenticationService AuthenticationService => _authenticationService ?? (_authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	protected static ISecurityService SecurityService => _securityService ?? (_securityService = Locator.GetServiceNotNull<ISecurityService>());

	public abstract bool HasPermission();
}
