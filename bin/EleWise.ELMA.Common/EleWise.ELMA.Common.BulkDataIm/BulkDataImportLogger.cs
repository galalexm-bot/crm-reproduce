using System;

namespace EleWise.ELMA.Common.BulkDataImport;

internal class BulkDataImportLogger : SmartLogger
{
	public static string LoggerPartName => "BulkDataImport";

	public BulkDataImportLogger(string loggerName, string action)
		: base(loggerName, LoggerPartName, action, string.Empty, Guid.NewGuid())
	{
	}

	public BulkDataImportLogger(string loggerName, string action, Guid logKey = default(Guid))
		: base(loggerName, LoggerPartName, action, string.Empty, logKey)
	{
	}

	public BulkDataImportLogger(string loggerName, string action, string description, Guid logKey = default(Guid))
		: this(disabled: false, loggerName, action, description, logKey)
	{
	}

	public BulkDataImportLogger(bool disabled, string loggerName, string action, string description = null, Guid logKey = default(Guid))
		: base(disabled, loggerName, "BulkDataImport", action, description, logKey)
	{
	}
}
