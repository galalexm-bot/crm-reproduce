using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Extensions;

[Component]
public class ContractorLegalWatchNotifier : IWatchNotifier
{
	public IEntityActionHandler EntityActionHandler { get; set; }

	public bool IsAvailable(Guid TypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IContractor>(TypeUid);
	}

	[Transaction]
	public virtual void Notify(object entityId, IEnumerable<EleWise.ELMA.Security.Models.IUser> addUsers, IEnumerable<EleWise.ELMA.Security.Models.IUser> deleteUsers)
	{
		IEntity contractor = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			contractor = ContractorManager.Instance.Load(Convert.ToInt64(entityId));
		});
		EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, contractor, "d17e073c-0f95-4c57-9322-4f18d560401e");
		if (addUsers != null)
		{
			entityActionEventArgs.ExtendedProperties.Add("AddMembers", addUsers);
		}
		if (deleteUsers != null)
		{
			entityActionEventArgs.ExtendedProperties.Add("DeleteMembers", deleteUsers);
		}
		EntityActionHandler.ActionExecuted(entityActionEventArgs);
	}
}
