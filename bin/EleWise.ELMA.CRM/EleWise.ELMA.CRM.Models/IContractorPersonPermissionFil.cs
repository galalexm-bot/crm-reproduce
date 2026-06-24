using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContractorPersonPermission))]
public interface IContractorPersonPermissionFilter : IEntityFilter
{
	new Guid? PermissionId { get; set; }

	IUser User { get; set; }

	long? UserSecuritySetCacheId { get; set; }

	Guid? PermissionRole { get; set; }

	IContractor Contractor { get; set; }
}
