using System.Web;

namespace Orchard.Localization.Services;

public interface ICalendarSelector : IDependency
{
	CalendarSelectorResult GetCalendar(HttpContextBase context);
}
