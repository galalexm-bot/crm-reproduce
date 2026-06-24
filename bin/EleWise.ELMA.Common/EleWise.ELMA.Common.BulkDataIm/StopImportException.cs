using System;

namespace EleWise.ELMA.Common.BulkDataImport.Exceptions;

public class StopImportException : Exception
{
	public Guid Uid { get; private set; }

	public StopImportException(Guid uid)
		: base(SR.T("Процесс массового импорта данных прерван"))
	{
		Uid = uid;
	}
}
