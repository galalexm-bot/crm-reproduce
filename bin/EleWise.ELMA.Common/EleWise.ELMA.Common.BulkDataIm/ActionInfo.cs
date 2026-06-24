namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class ActionInfo
{
	public ImportObject Object { get; private set; }

	internal SmartLogger Logger { get; private set; }

	internal ActionInfo(ImportObject @object, SmartLogger logger)
	{
		Object = @object;
		Logger = logger;
	}
}
