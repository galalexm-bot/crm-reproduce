using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Time;

public class CurrentTimeZoneWorkContext : IWorkContextStateProvider, IDependency
{
	private readonly IEnumerable<ITimeZoneSelector> _timeZoneSelectors;

	public CurrentTimeZoneWorkContext(IEnumerable<ITimeZoneSelector> timeZoneSelectors)
	{
		_timeZoneSelectors = timeZoneSelectors;
	}

	public Func<WorkContext, T> Get<T>(string name)
	{
		if (name == "CurrentTimeZone")
		{
			return (WorkContext ctx) => (T)(object)CurrentTimeZone(ctx.HttpContext);
		}
		return null;
	}

	private TimeZoneInfo CurrentTimeZone(HttpContextBase httpContext)
	{
		return (from x in _timeZoneSelectors
			select x.GetTimeZone(httpContext) into x
			where x != null
			orderby x.Priority descending
			select x).FirstOrDefault()?.TimeZone;
	}
}
