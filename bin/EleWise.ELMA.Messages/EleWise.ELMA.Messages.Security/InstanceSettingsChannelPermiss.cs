using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages.Security;

[Component]
public class InstanceSettingsChannelPermission : InstanceSettingsPermissionBase<IInformationChannel, IInformationChannelPermission>
{
	public override Permission AdminPermission => PermissionProvider.ChannelManagmentPermission;

	public InstanceSettingsChannelPermission()
		: base((Expression<Func<IInformationChannelPermission, IInformationChannel>>)((IInformationChannelPermission access) => access.Channel))
	{
	}

	protected override ICollection<IInformationChannelPermission> GetPermissionHolderCollection(IInformationChannel target)
	{
		return (ICollection<IInformationChannelPermission>)target.Permissions;
	}
}
