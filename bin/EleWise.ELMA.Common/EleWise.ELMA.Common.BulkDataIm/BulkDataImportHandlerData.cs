namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class BulkDataImportHandlerData
{
	public long PackageIndex { get; private set; }

	public object Context { get; set; }

	public BulkDataImportHandlerData()
	{
		PackageIndex = -1L;
	}

	internal void SetPackageNextIndex()
	{
		PackageIndex++;
	}
}
