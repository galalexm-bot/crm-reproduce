using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class LeadInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<ILead>();

	public void CreatePermissions(IEntity entity)
	{
		ILead lead = (ILead)entity;
		if (((ICollection<ILeadPersonPermission>)lead.Permission).Count == 0 && lead.InheritPermissions)
		{
			LeadManager.Instance.AddPermissionsFromParent(lead);
		}
	}
}
