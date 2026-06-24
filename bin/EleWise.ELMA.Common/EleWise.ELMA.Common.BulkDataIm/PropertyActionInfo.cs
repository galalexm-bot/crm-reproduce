using System;
using System.Data;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class PropertyActionInfo<T> : PropertyActionInfo
{
	internal PropertyActionInfo(MapObject mapObject, DataRow row, SmartLogger logger, int? index, int count)
		: base(typeof(T), mapObject, row, logger, index, count)
	{
	}
}
public class PropertyActionInfo : PropertyActionInfoBase
{
	public Type ObjectType { get; private set; }

	internal PropertyActionInfo(Type objectType, MapObject mapObject, DataRow row, SmartLogger logger, int? index, int count)
		: base(mapObject, row, logger, index, count)
	{
		ObjectType = objectType;
	}
}
