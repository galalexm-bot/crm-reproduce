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
internal class ContactInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IContact>();

	public void CreatePermissions(IEntity entity)
	{
		IContact contact = (IContact)entity;
		if (((ICollection<IContactPersonPermission>)contact.Permission).Count == 0 && contact.InheritPermissions)
		{
			ContactManager.Instance.AddPermissionsFromParent(contact);
		}
	}
}
