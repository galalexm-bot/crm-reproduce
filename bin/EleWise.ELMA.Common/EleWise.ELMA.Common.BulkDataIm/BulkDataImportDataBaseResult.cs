using System;

namespace EleWise.ELMA.Common.BulkDataImport.Models;

public struct BulkDataImportDataBaseResult
{
	private bool success;

	private Exception exception;

	public bool Success
	{
		get
		{
			return success;
		}
		private set
		{
			success = value;
		}
	}

	public Exception Exception
	{
		get
		{
			return exception;
		}
		private set
		{
			exception = value;
		}
	}

	public BulkDataImportDataBaseResult(bool success)
	{
		this.success = success;
		exception = null;
	}

	public BulkDataImportDataBaseResult(Exception exception)
	{
		success = false;
		this.exception = exception;
	}
}
