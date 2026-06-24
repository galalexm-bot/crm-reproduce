using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Packaging.Extensions;

internal static class ParsedProjectExtensions
{
	public static IEnumerable<IParsedProjectItem> GetItems(this IParsedProject parsedProject, ParsedProjectItemType type)
	{
		return parsedProject.Items.Where((IParsedProjectItem p) => p.ItemType == type);
	}
}
