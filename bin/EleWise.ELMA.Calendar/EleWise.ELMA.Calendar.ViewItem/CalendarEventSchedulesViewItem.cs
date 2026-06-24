using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_CalendarEventSchedulesViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ICalendarEvent))]
public class CalendarEventSchedulesViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : CalendarViewItemToolboxItem<CalendarEventSchedulesViewItem>
	{
	}

	public CalendarEventSchedulesViewItem()
	{
		base.Attributes.Name = SR.T("Календари");
	}
}
