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
internal class MarketingInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IMarketingBase>();

	public void CreatePermissions(IEntity entity)
	{
		IMarketingBase marketingBase = (IMarketingBase)entity;
		if (((ICollection<IMarketingPersonPermission>)marketingBase.Permission).Count == 0 && marketingBase.InheritPermissions)
		{
			MarketingBaseManager.Instance.AddPermissionsFromParent(marketingBase);
		}
	}
}
