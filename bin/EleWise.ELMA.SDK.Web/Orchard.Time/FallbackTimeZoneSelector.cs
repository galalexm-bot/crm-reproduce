using System;
using System.Web;

namespace Orchard.Time;

public class FallbackTimeZoneSelector : ITimeZoneSelector, IDependency
{
	public TimeZoneSelectorResult GetTimeZone(HttpContextBase context)
	{
		return new TimeZoneSelectorResult
		{
			Priority = -100,
			TimeZone = TimeZoneInfo.Local
		};
	}
}
