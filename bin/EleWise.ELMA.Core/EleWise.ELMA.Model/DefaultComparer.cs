using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model;

internal sealed class DefaultComparer : IComparer<object>
{
	public int Compare(object x, object y)
	{
		if (x == null)
		{
			if (y == null)
			{
				return 0;
			}
			return -1;
		}
		if (y == null)
		{
			return 1;
		}
		IComparable val;
		if ((val = (IComparable)((x is IComparable) ? x : null)) != null)
		{
			return val.CompareTo(y);
		}
		return string.Compare(x.ToString(), y.ToString(), (StringComparison)4);
	}
}
