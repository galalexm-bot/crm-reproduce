using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_CalendarEventPeriodicityViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ICalendarEvent))]
public class CalendarEventPeriodicityViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : CalendarViewItemToolboxItem<CalendarEventPeriodicityViewItem>
	{
	}

	public CalendarEventPeriodicityViewItem()
	{
		base.Attributes.Name = SR.T("Периодичность");
	}
}
