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
internal class ContractorInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IContractor>();

	public void CreatePermissions(IEntity entity)
	{
		IContractor contractor = (IContractor)entity;
		if (((ICollection<IContractorPersonPermission>)contractor.Permission).Count == 0 && contractor.InheritPermissions)
		{
			ContractorManager.Instance.AddPermissionsFromParent(contractor);
		}
	}
}
