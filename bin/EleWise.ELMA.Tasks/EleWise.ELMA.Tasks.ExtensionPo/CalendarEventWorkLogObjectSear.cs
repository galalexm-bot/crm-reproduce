using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
public class CalendarEventWorkLogObjectSearchExtension : WorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{FDB52BED-0CAB-4067-9E9D-0071867D3A9A}");

	public override Type BaseObjectType => typeof(ICalendarEvent);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
	}

	public override void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
		base.SetupFilter(entityFilter, filter);
		if (entityFilter is ICalendarEventFilter calendarEventFilter)
		{
			calendarEventFilter.CreationDate = RelativeDateTimeDescriptor.GetDateTimeRange(filter.CreationDate);
			calendarEventFilter.Subject = filter.Name;
			calendarEventFilter.CreationAuthor = filter.CreationAuthor;
			calendarEventFilter.AllTypes = true;
		}
	}
}
