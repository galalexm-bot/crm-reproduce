using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class WatchDescriptionComparer : IEqualityComparer<WatchDescription>
{
	public bool Equals(WatchDescription x, WatchDescription y)
	{
		if (x == null && y == null)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		if (x.Global)
		{
			return x.Description == y.Description;
		}
		if (x.Entity != null)
		{
			return x.Entity.Equals(y.Entity);
		}
		return false;
	}

	public int GetHashCode(WatchDescription obj)
	{
		int result = 0;
		if (!string.IsNullOrEmpty(obj.Description))
		{
			result = obj.Description.GetHashCode();
		}
		if (obj.Entity != null)
		{
			result = obj.Entity.GetHashCode();
		}
		return result;
	}
}
