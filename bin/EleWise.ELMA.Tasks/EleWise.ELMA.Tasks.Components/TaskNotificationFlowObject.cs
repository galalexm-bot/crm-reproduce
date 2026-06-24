using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class TaskNotificationFlowObject : INotificationFlowObject
{
	public bool Can(Guid flowUid)
	{
		return TaskNotificationFlow.UID.Equals(flowUid);
	}

	public IDictionary<Guid, Guid[]> Get()
	{
		Dictionary<Guid, Guid[]> dictionary = new Dictionary<Guid, Guid[]>();
		dictionary.Add(InterfaceActivator.UID<ITask>(), new Guid[5]
		{
			DefaultEntityActions.CreateGuid,
			TaskBaseActions.RedirectGuid,
			TaskBaseActions.ActivateGuid,
			TaskBaseActions.CompleteGuid,
			TaskBaseActions.IncompleteGuid
		});
		dictionary.Add(InterfaceActivator.UID<IApprovalTask>(), new Guid[3]
		{
			DefaultEntityActions.CreateGuid,
			TaskBaseActions.RedirectGuid,
			TaskBaseActions.ActivateGuid
		});
		dictionary.Add(InterfaceActivator.UID<IQuestion>(), new Guid[3]
		{
			DefaultEntityActions.CreateGuid,
			TaskBaseActions.RedirectGuid,
			TaskBaseActions.ActivateGuid
		});
		return dictionary;
	}
}
