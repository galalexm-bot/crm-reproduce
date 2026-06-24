using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc;

public abstract class BaseViewPage : WebViewPage
{
	internal static IAuthenticationService _authenticationService;

	internal static ISecurityService _securityService;

	public IAuthenticationService AuthenticationService { get; protected set; }

	public ISecurityService SecurityService { get; protected set; }

	protected BaseViewPage()
	{
		AuthenticationService = _authenticationService ?? (_authenticationService = Locator.GetService<IAuthenticationService>());
		SecurityService = _securityService ?? (_securityService = Locator.GetService<ISecurityService>());
	}
}
public abstract class BaseViewPage<TModel> : WebViewPage<TModel>
{
	public IAuthenticationService AuthenticationService { get; protected set; }

	public ISecurityService SecurityService { get; protected set; }

	protected BaseViewPage()
	{
		AuthenticationService = BaseViewPage._authenticationService ?? (BaseViewPage._authenticationService = Locator.GetService<IAuthenticationService>());
		SecurityService = BaseViewPage._securityService ?? (BaseViewPage._securityService = Locator.GetService<ISecurityService>());
	}
}
