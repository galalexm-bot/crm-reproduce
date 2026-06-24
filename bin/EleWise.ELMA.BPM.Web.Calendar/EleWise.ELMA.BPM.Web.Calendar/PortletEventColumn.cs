using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
public class PortletEventColumn : ICalendarPortletLastColumn
{
	public Guid EntityTypeUid => Guid.Empty;

	public Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html)
	{
		return (ICalendarItem eventItem) => MvcHtmlString.Create(eventItem.PrivateAccess ? null : string.Join(", ", eventItem.EventUsers.Select((KeyValuePair<string, string> u) => u.Value).ToArray()));
	}
}
