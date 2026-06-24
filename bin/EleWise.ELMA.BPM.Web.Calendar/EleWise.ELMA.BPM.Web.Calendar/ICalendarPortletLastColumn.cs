using System;
using System.Web.Mvc;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICalendarPortletLastColumn
{
	Guid EntityTypeUid { get; }

	Func<ICalendarItem, MvcHtmlString> LastColumnCellData(HtmlHelper html);
}
