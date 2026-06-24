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

[Component]
public class CalendarPortletMailColumn : ICalendarPortletLastColumn
{
	public Guid EntityTypeUid => InterfaceActivator.UID<IRelationshipMail>();

	public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html)
	{
		return delegate(ICalendarItem eventItem)
		{
			if (string.IsNullOrWhiteSpace(eventItem.SourceId))
			{
				return MvcHtmlString.Empty;
			}
			IRelationshipMail relationshipMail = null;
			try
			{
				relationshipMail = AbstractNHEntityManager<IRelationshipMail, long>.Instance.LoadOrNull(Convert.ToInt64(eventItem.SourceId));
			}
			catch (SecurityException)
			{
			}
			if (relationshipMail == null)
			{
				return MvcHtmlString.Empty;
			}
			if (relationshipMail.Contact != null && relationshipMail.Contact.Email != null && ((IEnumerable<IEmail>)relationshipMail.Contact.Email).Any())
			{
				return PartialExtensions.Partial(html, "DisplayTemplates/Entities/EmailSet", (object)relationshipMail.Contact.Email);
			}
			if (relationshipMail.Contractor != null && relationshipMail.Contractor.Email != null && ((IEnumerable<IEmail>)relationshipMail.Contractor.Email).Any())
			{
				return PartialExtensions.Partial(html, "DisplayTemplates/Entities/EmailSet", (object)relationshipMail.Contractor.Email);
			}
			return (relationshipMail.Lead != null && relationshipMail.Lead.Email != null && ((IEnumerable<IEmail>)relationshipMail.Lead.Email).Any()) ? PartialExtensions.Partial(html, "DisplayTemplates/Entities/EmailSet", (object)relationshipMail.Lead.Email) : MvcHtmlString.Empty;
		};
	}
}
