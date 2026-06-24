using System;

namespace EleWise.ELMA.Common.BulkDataImport.Exceptions;

public class DataSourceReadException : Exception
{
	public DataSourceReadException(string message)
		: base(message)
	{
	}
}
