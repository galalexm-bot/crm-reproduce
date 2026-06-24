using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.UI;

public class FlatPositionComparer : IComparer<string>
{
	public int Compare(string x, string y)
	{
		if (x == y)
		{
			return 0;
		}
		x = ((x == null) ? "before" : ((x.Trim().Length == 0) ? "0" : x.Trim(':').TrimEnd('.')));
		y = ((y == null) ? "before" : ((y.Trim().Length == 0) ? "0" : y.Trim(':').TrimEnd('.')));
		string[] array = x.Split('.', ':');
		string[] array2 = y.Split('.', ':');
		for (int i = 0; i < array.Count(); i++)
		{
			if (array2.Length < i + 1)
			{
				return 1;
			}
			string partition = (string.IsNullOrWhiteSpace(array[i]) ? "before" : array[i]);
			string partition2 = (string.IsNullOrWhiteSpace(array2[i]) ? "before" : array2[i]);
			partition = NormalizeKnownPartitions(partition);
			partition2 = NormalizeKnownPartitions(partition2);
			int result;
			bool flag = int.TryParse(partition, out result);
			int result2;
			bool flag2 = int.TryParse(partition2, out result2);
			if (!flag && !flag2)
			{
				return string.Compare(string.Join(".", array), string.Join(".", array2), StringComparison.OrdinalIgnoreCase);
			}
			if (!flag || (flag2 && result > result2))
			{
				return 1;
			}
			if (!flag2 || result < result2)
			{
				return -1;
			}
		}
		if (array.Length < array2.Length)
		{
			return -1;
		}
		return 0;
	}

	private static string NormalizeKnownPartitions(string partition)
	{
		if (partition.Length < 5)
		{
			return partition;
		}
		if (string.Compare(partition, "before", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "-9999";
		}
		if (string.Compare(partition, "after", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "9999";
		}
		return partition;
	}
}
