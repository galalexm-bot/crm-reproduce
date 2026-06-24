using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelPermissionInfo
{
	private Permission _permission;

	public IInformationChannel Channel { get; set; }

	public List<ChannelPermissionInfoItem> ChannelPermissions { get; set; }

	public Guid PermissionId { get; set; }

	public long ChannelPermissionsCount => ((IEnumerable<IInformationChannelPermission>)Channel.Permissions).Count((IInformationChannelPermission p) => p.PermissionId == PermissionId);

	public Permission Permission
	{
		get
		{
			if (_permission == null)
			{
				IPermissionManagmentService service = Locator.GetService<IPermissionManagmentService>();
				_permission = service.GetPermission(PermissionId);
			}
			return _permission;
		}
	}

	public string GetRoletypeImage(IInformationChannelPermission perm)
	{
		if (!perm.PermissionRole.HasValue)
		{
			return "";
		}
		PermissionRoleType permissionRoleType = Locator.GetService<IPermissionTypeRoleService>().Get(perm.PermissionRole.Value);
		if (permissionRoleType == null)
		{
			return "";
		}
		return permissionRoleType.Image;
	}
}
