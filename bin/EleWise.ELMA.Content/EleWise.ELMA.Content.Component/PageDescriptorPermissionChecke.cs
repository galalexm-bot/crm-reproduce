using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.UI.Descriptors;

namespace EleWise.ELMA.Content.Components;

[Component]
public class PageDescriptorPermissionChecker : IFormDescriptorPermissionChecker
{
	public ISecurityService SecurityService { get; set; }

	public bool CanCheckPermission(Permission permission, FormDescriptor descriptor)
	{
		if (!(descriptor is PageDescriptor))
		{
			return false;
		}
		return permission == CommonPermissions.View;
	}

	public bool HasPermission(Permission permission, FormDescriptor descriptor)
	{
		if (permission == CommonPermissions.View)
		{
			permission = PageSecurity.ViewPagePermission;
		}
		IPageProfile pageProfile = PageProfileManager.Instance.LoadOrNull(descriptor.MetadataItemHederUid);
		if (pageProfile != null)
		{
			if (!SecurityService.HasPermission(PermissionProvider.ContentAdminPermission))
			{
				return SecurityService.HasPermission(permission, pageProfile);
			}
			return true;
		}
		return false;
	}
}
