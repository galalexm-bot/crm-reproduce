using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class PackagesAvailabilityAttribute : BasePermissionAttribute
{
	public override bool HasPermission()
	{
		PackageService packageService = (Locator.Initialized ? Locator.GetService<PackageService>() : null);
		if (packageService != null && packageService.Initialized)
		{
			return packageService.ComponentName == "Web";
		}
		return false;
	}
}
