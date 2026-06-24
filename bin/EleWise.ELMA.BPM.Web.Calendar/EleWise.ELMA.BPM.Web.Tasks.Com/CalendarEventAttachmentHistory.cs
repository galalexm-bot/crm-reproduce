using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class CalendarEventAttachmentHistoryPartProvider : AttachmentHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is ICalendarEvent;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IAttachedHistoryModel eventData)
	{
		return eventData is ICalendarEventHistoryModel;
	}
}
