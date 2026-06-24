using System.Collections.Generic;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapActionInfo
{
	public IList<MapInfo> MapObjects { get; private set; }

	internal SmartLogger Logger { get; private set; }

	public int? Index { get; private set; }

	internal MapActionInfo(IList<MapInfo> mapObjects, SmartLogger logger, int? index)
	{
		MapObjects = mapObjects;
		Logger = logger;
		Index = index;
	}
}
