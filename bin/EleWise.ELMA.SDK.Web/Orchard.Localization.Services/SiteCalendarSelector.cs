using System.Web;

namespace Orchard.Localization.Services;

public class SiteCalendarSelector : ICalendarSelector, IDependency
{
	private readonly IWorkContextAccessor _workContextAccessor;

	public SiteCalendarSelector(IWorkContextAccessor workContextAccessor)
	{
		_workContextAccessor = workContextAccessor;
	}

	public CalendarSelectorResult GetCalendar(HttpContextBase context)
	{
		string siteCalendar = _workContextAccessor.GetContext().CurrentSite.SiteCalendar;
		if (string.IsNullOrEmpty(siteCalendar))
		{
			return null;
		}
		return new CalendarSelectorResult
		{
			Priority = -5,
			CalendarName = siteCalendar
		};
	}
}
