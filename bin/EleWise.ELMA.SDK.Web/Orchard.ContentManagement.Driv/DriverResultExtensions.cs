using System.Collections.Generic;
using System.Linq;

namespace Orchard.ContentManagement.Drivers;

internal static class DriverResultExtensions
{
	public static IEnumerable<ContentShapeResult> GetShapeResults(this DriverResult driverResult)
	{
		if (driverResult is CombinedResult)
		{
			return from result in ((CombinedResult)driverResult).GetResults()
				select result as ContentShapeResult;
		}
		return new ContentShapeResult[1] { driverResult as ContentShapeResult };
	}
}
