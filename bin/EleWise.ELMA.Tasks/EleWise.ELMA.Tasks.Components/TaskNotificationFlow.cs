using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 100)]
public class TaskNotificationFlow : INotificationFlow
{
	public static readonly Guid UID = new Guid("{DDDC2682-7518-4C0B-B40C-EFA59A4FD53B}");

	public Guid Uid => UID;

	public string Name => SR.T("Входящие задачи");

	public IEnumerable<INotificationFlowObject> FlowObjects => from nfo in ComponentManager.Current.GetExtensionPoints<INotificationFlowObject>()
		where nfo.Can(Uid)
		select nfo;
}
