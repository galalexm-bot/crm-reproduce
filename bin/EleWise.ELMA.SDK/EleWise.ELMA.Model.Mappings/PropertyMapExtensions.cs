using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Mappings;

public static class PropertyMapExtensions
{
	public static void ReplaceContextVars(this PropertyMap propertyMap, Dictionary<Guid, Guid> replaceContextVarMap)
	{
		if (replaceContextVarMap.TryGetValue(propertyMap.RightClassUid, out var value))
		{
			propertyMap.RightClassUid = value;
		}
		if (replaceContextVarMap.TryGetValue(propertyMap.LeftClassUid, out value))
		{
			propertyMap.LeftClassUid = value;
		}
		foreach (PropertyMapItem item in propertyMap.Items)
		{
			Guid leftPropertyUid = item.LeftPropertyUid;
			if (replaceContextVarMap.TryGetValue(leftPropertyUid, out value))
			{
				item.LeftPropertyUid = value;
			}
			Guid rightPropertyUid = item.RightPropertyUid;
			if (replaceContextVarMap.TryGetValue(rightPropertyUid, out value))
			{
				item.RightPropertyUid = value;
			}
		}
	}
}
