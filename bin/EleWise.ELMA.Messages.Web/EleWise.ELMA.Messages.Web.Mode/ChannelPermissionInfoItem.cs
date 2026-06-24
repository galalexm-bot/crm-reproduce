using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelPermissionInfoItem
{
	public IInformationChannelPermission Permission { get; set; }

	public PermissionRoleType RoleType
	{
		get
		{
			IPermissionTypeRoleService service = Locator.GetService<IPermissionTypeRoleService>();
			if (Permission.PermissionRole.HasValue)
			{
				return service.Get(Permission.PermissionRole.Value);
			}
			return null;
		}
	}
}
