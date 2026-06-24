using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IMarketingPersonPermission))]
public interface IMarketingPersonPermissionFilter : IEntityFilter
{
	new Guid? PermissionId { get; set; }

	Guid? PermissionRole { get; set; }

	IMarketingBase PermissionSource { get; set; }
}
