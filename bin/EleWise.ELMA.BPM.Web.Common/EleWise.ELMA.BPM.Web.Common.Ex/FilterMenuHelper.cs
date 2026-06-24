using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models.Filters;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class FilterMenuHelper
{
	public static IFilterFolder Find(this IEnumerable<IFilterFolder> folders, string stringId)
	{
		if (!long.TryParse(stringId, out var longId))
		{
			return null;
		}
		return folders.FirstOrDefault((IFilterFolder folder) => folder.Id == longId);
	}
}
