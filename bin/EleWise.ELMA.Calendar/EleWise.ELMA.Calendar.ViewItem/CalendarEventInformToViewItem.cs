using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_CalendarEventInformToViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ICalendarEvent))]
public class CalendarEventInformToViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : CalendarViewItemToolboxItem<CalendarEventInformToViewItem>
	{
	}

	public CalendarEventInformToViewItem()
	{
		base.Attributes.Name = SR.T("Информировать");
	}
}
