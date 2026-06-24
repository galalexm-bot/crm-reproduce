using System;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Model.Entities;

public interface IEntityPermission : IEntity<long>, IEntity, IIdentified, ISecuritySetIdHolder, IInstanceSettingsPermissionHolder
{
	Guid? PermissionRole { get; set; }

	IEntity Instance { get; set; }
}
