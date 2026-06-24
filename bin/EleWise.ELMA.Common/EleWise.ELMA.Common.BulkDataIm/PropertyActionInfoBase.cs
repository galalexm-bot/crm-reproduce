using System.Data;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class PropertyActionInfoBase
{
	public DataRow Row { get; private set; }

	internal SmartLogger Logger { get; private set; }

	public int? Index { get; private set; }

	public MapObject Object { get; private set; }

	public int Count { get; private set; }

	internal PropertyActionInfoBase(MapObject mapObject, DataRow row, SmartLogger logger, int? index, int count)
	{
		Row = row;
		Logger = logger;
		Index = index;
		Object = mapObject;
		Count = count;
	}
}
