using System;

namespace EleWise.ELMA.Common.BulkDataImport.Exceptions;

public class BulkDataImportException : Exception
{
	public BulkDataImportException(string message)
		: base(message)
	{
	}
}
