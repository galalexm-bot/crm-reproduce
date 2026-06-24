using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 10)]
public class CalendarPortletCallColumn : ICalendarPortletLastColumn
{
	public Guid EntityTypeUid => InterfaceActivator.UID<IRelationshipCall>();

	public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html)
	{
		return delegate(ICalendarItem eventItem)
		{
			if (string.IsNullOrWhiteSpace(eventItem.SourceId))
			{
				return MvcHtmlString.Empty;
			}
			IRelationshipCall relationshipCall = null;
			try
			{
				relationshipCall = AbstractNHEntityManager<IRelationshipCall, long>.Instance.LoadOrNull(Convert.ToInt64(eventItem.SourceId));
			}
			catch (SecurityException)
			{
			}
			if (relationshipCall == null)
			{
				return MvcHtmlString.Empty;
			}
			if (relationshipCall.Contact != null && relationshipCall.Contact.Phone != null && ((IEnumerable<IPhone>)relationshipCall.Contact.Phone).Any())
			{
				return PartialExtensions.Partial(html, "DisplayTemplates/Entities/PhoneSet", (object)relationshipCall.Contact.Phone);
			}
			if (relationshipCall.Contractor != null && relationshipCall.Contractor.Phone != null && ((IEnumerable<IPhone>)relationshipCall.Contractor.Phone).Any())
			{
				return PartialExtensions.Partial(html, "DisplayTemplates/Entities/PhoneSet", (object)relationshipCall.Contractor.Phone);
			}
			return (relationshipCall.Lead != null && relationshipCall.Lead.Phone != null && ((IEnumerable<IPhone>)relationshipCall.Lead.Phone).Any()) ? PartialExtensions.Partial(html, "DisplayTemplates/Entities/PhoneSet", (object)relationshipCall.Lead.Phone) : MvcHtmlString.Empty;
		};
	}
}
