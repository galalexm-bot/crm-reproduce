using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TaskWatchNotifier : IWatchNotifier
{
	public IEntityActionHandler EntityActionHandler { get; set; }

	public bool IsAvailable(Guid TypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<ITaskBase>(TypeUid);
	}

	[Transaction]
	public virtual void Notify(object entityId, IEnumerable<EleWise.ELMA.Security.Models.IUser> addUsers, IEnumerable<EleWise.ELMA.Security.Models.IUser> deleteUsers)
	{
		IEntity task = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			task = TaskBaseManager.Instance.Load(Convert.ToInt64(entityId));
		});
		EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, task, "299948dc-dad3-443b-a226-c7f6c76d608c");
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
