using System;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Security.Services;

public interface IInstanceSettingsPermissionHolder
{
	IEntity Assigned { get; set; }

	Guid TypeRoleId { get; set; }

	Guid PermissionId { get; set; }

	object Target { get; set; }
}
