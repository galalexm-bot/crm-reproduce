using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Comparers;

public class SelectListItemComparer : IEqualityComparer<SelectListItem>
{
	public bool Equals(SelectListItem x, SelectListItem y)
	{
		if (y == null && x == null)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		if (x.get_Value() == y.get_Value() && x.get_Selected() == y.get_Selected())
		{
			return x.get_Text().Equals(y.get_Text(), StringComparison.Ordinal);
		}
		return false;
	}

	public int GetHashCode(SelectListItem obj)
	{
		return obj.get_Text().GetHashCode();
	}
}
