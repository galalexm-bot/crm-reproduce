using System;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CalendarPortletMeetingColumn : ICalendarPortletLastColumn
{
	public Guid EntityTypeUid => InterfaceActivator.UID<IRelationshipMeeting>();

	public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html)
	{
		return delegate(ICalendarItem eventItem)
		{
			if (string.IsNullOrWhiteSpace(eventItem.SourceId))
			{
				return MvcHtmlString.Empty;
			}
			IRelationshipMeeting relationshipMeeting = null;
			try
			{
				relationshipMeeting = RelationshipMeetingManager.Instance.LoadOrNull(Convert.ToInt64(eventItem.SourceId));
			}
			catch (SecurityException)
			{
			}
			return (relationshipMeeting == null) ? MvcHtmlString.Empty : MvcHtmlString.Create(relationshipMeeting.Place.HtmlEncode());
		};
	}
}
