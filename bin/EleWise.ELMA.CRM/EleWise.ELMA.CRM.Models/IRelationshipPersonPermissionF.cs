using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IRelationshipPersonPermission))]
public interface IRelationshipPersonPermissionFilter : IEntityFilter
{
	new Guid? PermissionId { get; set; }

	IUser User { get; set; }

	Guid? PermissionRole { get; set; }

	IRelationship Relationship { get; set; }
}
