using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

[Component]
internal class ProfilePermissionResolver : IProfilePermission
{
	public IEnumerable<ProfilePermissionDescriptor> ProfilePermissionDescriptors { get; private set; }

	public ProfilePermissionResolver(IEnumerable<IPermissionProvider> permissionProviders)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		ProfilePermissionDescriptors = (from p in permissionProviders.SelectMany((IPermissionProvider p) => p.GetPermissions())
			where _003C_003Ec.uMjhR9peEJ6NrBhFn2sy(_003C_003Ec.DvVIVfpe0J5YDnF4CEaS(p), null)
			select new ProfilePermissionDescriptor(p.ProfileForPermission, p)).ToArray();
	}
}
