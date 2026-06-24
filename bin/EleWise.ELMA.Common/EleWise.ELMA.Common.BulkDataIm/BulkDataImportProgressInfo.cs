using System;

namespace EleWise.ELMA.Common.BulkDataImport.Models;

[Serializable]
public class BulkDataImportProgressInfo
{
	public Guid Uid { get; private set; }

	public ImportOperations CurrentOperation { get; set; }

	public OperationStatus Status { get; set; }

	public long CurrentPackage { get; set; }

	public long? PackageCount { get; set; }

	public long PackageSize { get; set; }

	public BulkDataImportProgressInfo(Guid uid)
	{
		Uid = uid;
	}

	public BulkDataImportProgressInfo(Guid uid, ImportOperations operation, OperationStatus status)
	{
		Uid = uid;
		CurrentOperation = operation;
		Status = status;
	}
}
