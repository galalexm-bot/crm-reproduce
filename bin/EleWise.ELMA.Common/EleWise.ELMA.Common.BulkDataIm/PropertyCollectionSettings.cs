using System.Data;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class PropertyCollectionSettings
{
	public DataRow Row { get; private set; }

	internal SmartLogger Logger { get; private set; }

	public bool CollectionHandler { get; set; }

	internal PropertyCollectionSettings(DataRow row, SmartLogger logger)
	{
		Row = row;
		Logger = logger;
	}
}
