using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentPortletsRestrictionProvider : IPortletsRestrictionProvider
{
	public const string PathPrefix = "_Documents_Folder_MainPage_";

	[NotNull]
	public SecurityService SecurityService { get; set; }

	[NotNull]
	public PortletManager PortletManager => Locator.GetServiceNotNull<PortletManager>();

	public EleWise.ELMA.Security.Models.IUser CurrentUser => Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public bool Match(string path)
	{
		return !string.IsNullOrWhiteSpace(path);
	}

	public bool AllowedView(string path)
	{
		return true;
	}

	public bool AllowedAddPortlet(string path)
	{
		return true;
	}

	public bool AllowedAddPortlet(IPortlet portlet, string path)
	{
		return true;
	}

	public bool AllowedPersonalization(string path)
	{
		return true;
	}

	public bool AllowedChangeSharedSettings(string path)
	{
		if (path == "_Documents_Folder_MainPage_")
		{
			return SecurityService.HasPermission(CurrentUser, PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
		}
		return true;
	}
}
