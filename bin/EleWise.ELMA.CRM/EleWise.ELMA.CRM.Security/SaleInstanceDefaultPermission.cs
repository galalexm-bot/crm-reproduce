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
internal class SaleInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<ISale>();

	public void CreatePermissions(IEntity entity)
	{
		ISale sale = (ISale)entity;
		if (((ICollection<ISalePersonPermission>)sale.Permission).Count == 0 && sale.InheritPermissions)
		{
			SaleManager.Instance.AddPermissionsFromParent(sale);
		}
	}
}
