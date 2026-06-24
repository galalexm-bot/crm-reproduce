using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContactPersonPermission))]
public interface IContactPersonPermissionFilter : IEntityFilter
{
	IUser User { get; set; }

	Guid? PermissionRole { get; set; }

	IContact Contact { get; set; }
}
