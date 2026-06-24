using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public static class RecipientInfoForNotificationHelper
{
	public static IEnumerable<IUser> GetUsersFromStrucutre(Guid objectGuid)
	{
		List<IUser> list = new List<IUser>();
		if (objectGuid != Guid.Empty)
		{
			IOrganizationItem organizationItem = OrganizationItemManager.Instance.LoadOrNull(objectGuid);
			if (organizationItem != null)
			{
				if (organizationItem.Users != null && ((ICollection<IUser>)organizationItem.Users).Count > 0)
				{
					list.AddRange((IEnumerable<IUser>)organizationItem.Users);
				}
				if (organizationItem.User != null)
				{
					list.Add(organizationItem.User);
				}
			}
		}
		return list.Distinct();
	}

	public static List<IUser> GetUsersFromUserGroup(Guid objectGuid)
	{
		IUserGroup userGroup = UserGroupManager.Instance.LoadOrNull(objectGuid);
		List<IUser> result = new List<IUser>();
		if (userGroup != null)
		{
			result = UserGroupManager.Instance.GetUsersByGroup(userGroup).Cast<IUser>().ToList();
		}
		return result;
	}

	public static List<IUser> GetUsersFromVariable(IWorkflowInstance instance, Guid objectGuid)
	{
		List<IUser> list = new List<IUser>();
		object obj = ((objectGuid == Guid.Empty) ? null : instance.Context.GetPropertyValue(objectGuid));
		if (obj is IEntity)
		{
			if (obj is IUser item)
			{
				list.Add(item);
				return list;
			}
			if (obj is IUserGroup userGroup)
			{
				list.AddRange(GetUsersFromUserGroup(userGroup.Uid));
				return list;
			}
			if (obj is IOrganizationItem organizationItem)
			{
				list.AddRange(GetUsersFromStrucutre(organizationItem.Uid));
				return list;
			}
		}
		ISet val = (ISet)((obj is ISet) ? obj : null);
		if (val != null && EnumerableExtensions.Any((IEnumerable)val))
		{
			foreach (object item2 in (IEnumerable)val)
			{
				if (item2 is IUser)
				{
					list.AddRange(((IEnumerable)val).OfType<IUser>());
					return list;
				}
				if (item2 is IUserGroup userGroup2)
				{
					list.AddRange(GetUsersFromUserGroup(userGroup2.Uid));
				}
				if (item2 is IOrganizationItem organizationItem2)
				{
					list.AddRange(GetUsersFromStrucutre(organizationItem2.Uid));
				}
			}
			return list;
		}
		IPropertyMetadata instanceContextPropertyMetadata = WorkflowInstanceContextService.Instance.GetInstanceContextPropertyMetadata(instance.Context, objectGuid);
		string text = ((instanceContextPropertyMetadata != null) ? instanceContextPropertyMetadata.Name : "");
		throw new GetRecipientsException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050229686), text));
	}
}
