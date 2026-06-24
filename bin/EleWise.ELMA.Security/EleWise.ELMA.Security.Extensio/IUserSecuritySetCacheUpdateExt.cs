using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IUserSecuritySetCacheUpdateExtension : IEventHandler
{
	void OnUpdate(Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users, Dictionary<IUserGroup, GroupUpdate> userGroups, Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems);
}
