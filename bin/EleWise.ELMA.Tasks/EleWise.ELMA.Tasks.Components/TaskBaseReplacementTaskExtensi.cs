using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 100)]
public class TaskBaseReplacementTaskExtension : IReplacementTaskExtension
{
	public IEnumerable<IEntity> ObjectsList(long taskId)
	{
		return ReplacementTaskManager.Instance.ActiveTasksList(taskId, FetchOptions.All);
	}
}
