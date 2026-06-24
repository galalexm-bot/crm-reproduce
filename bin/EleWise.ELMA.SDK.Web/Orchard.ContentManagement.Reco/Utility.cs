using System;

namespace Orchard.ContentManagement.Records;

public static class Utility
{
	public static bool IsPartRecord(Type type)
	{
		if (type.IsSubclassOf(typeof(ContentPartRecord)))
		{
			return !type.IsSubclassOf(typeof(ContentPartVersionRecord));
		}
		return false;
	}

	public static bool IsPartVersionRecord(Type type)
	{
		return type.IsSubclassOf(typeof(ContentPartVersionRecord));
	}
}
