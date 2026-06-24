using System;
using System.Web;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;

namespace Orchard.Time;

public class SiteTimeZoneSelector : ITimeZoneSelector, IDependency
{
	private readonly IWorkContextAccessor _workContextAccessor;

	public ILogger Logger { get; set; }

	public SiteTimeZoneSelector(IWorkContextAccessor workContextAccessor)
	{
		_workContextAccessor = workContextAccessor;
		Logger = NullLogger.Instance;
	}

	public TimeZoneSelectorResult GetTimeZone(HttpContextBase context)
	{
		try
		{
			string siteTimeZone = _workContextAccessor.GetContext().CurrentSite.SiteTimeZone;
			if (string.IsNullOrEmpty(siteTimeZone))
			{
				return null;
			}
			return new TimeZoneSelectorResult
			{
				Priority = -5,
				TimeZone = TimeZoneInfo.FindSystemTimeZoneById(siteTimeZone)
			};
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Error(ex, "TimeZone could not be loaded");
			return null;
		}
	}
}
