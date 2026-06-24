using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_CalendarEventParticipantsViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ICalendarEvent))]
public class CalendarEventParticipantsViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : CalendarViewItemToolboxItem<CalendarEventParticipantsViewItem>
	{
	}

	public CalendarEventParticipantsViewItem()
	{
		base.Attributes.Name = SR.T("Участники");
	}
}
