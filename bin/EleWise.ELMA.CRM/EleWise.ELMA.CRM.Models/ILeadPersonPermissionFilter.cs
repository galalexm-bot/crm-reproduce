using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILeadPersonPermission))]
public interface ILeadPersonPermissionFilter : IEntityFilter
{
	IUser User { get; set; }

	Guid? PermissionRole { get; set; }

	ILead Lead { get; set; }
}
