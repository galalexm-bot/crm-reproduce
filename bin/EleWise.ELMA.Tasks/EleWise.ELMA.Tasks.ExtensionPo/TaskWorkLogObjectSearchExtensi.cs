using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
public class TaskWorkLogObjectSearchExtension : WorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{90326371-B0FB-4FA4-A086-AC9EB51FFD0B}");

	public override Type BaseObjectType => typeof(ITask);

	protected override void Init()
	{
	}

	public override void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
		base.SetupFilter(entityFilter, filter);
		if (entityFilter is ITaskFilter taskFilter)
		{
			taskFilter.IsEmulation = false;
			taskFilter.Period = CalendarEventPeriod.Once;
		}
	}
}
