using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public static class GridStateExtensions
{
	public static IEnumerable<ColumnState> OrderColumns(this IEnumerable<ColumnState> columnStates, IEnumerable<CustomColumnDescriptor> customColumns = null)
	{
		if (customColumns != null)
		{
			IList<string> customColumnUniqueNames = customColumns.Select((CustomColumnDescriptor c) => c.UniqueName).ToArray();
			int customColumnUniqueNamesCount = customColumnUniqueNames.Count + 1;
			columnStates = columnStates.OrderBy((ColumnState c) => (customColumnUniqueNames.IndexOf(c.UniqueName) + customColumnUniqueNamesCount) % customColumnUniqueNamesCount);
		}
		return columnStates.OrderColumns(customColumns, null);
	}

	internal static IEnumerable<ColumnState> OrderColumns(this IEnumerable<ColumnState> columnStates, IEnumerable<CustomColumnDescriptor> customColumns, IDictionary<string, int> orderOverride)
	{
		if (customColumns != null)
		{
			IList<string> customColumnUniqueNames = customColumns.Select((CustomColumnDescriptor c) => c.UniqueName).ToArray();
			int customColumnUniqueNamesCount = customColumnUniqueNames.Count + 1;
			columnStates = columnStates.OrderBy((ColumnState c) => (customColumnUniqueNames.IndexOf(c.UniqueName) + customColumnUniqueNamesCount) % customColumnUniqueNamesCount);
		}
		if (orderOverride == null)
		{
			return columnStates.OrderBy((ColumnState c) => c.Order);
		}
		int value;
		return columnStates.OrderBy((ColumnState column) => (!orderOverride.TryGetValue(column.UniqueName, out value)) ? column.Order : value);
	}
}
