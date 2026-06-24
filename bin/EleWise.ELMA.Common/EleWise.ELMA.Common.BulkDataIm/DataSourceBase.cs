using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace EleWise.ELMA.Common.BulkDataImport.DataSources;

public abstract class DataSourceBase : IDataSource, IEnumerable<DataTable>, IEnumerable
{
	private const string loggerPartName = "BulkDataImportDataSource";

	private long currentIndex = -1L;

	private long startIndex;

	private DataTable current;

	private IEnumerator<DataTable> enumerator;

	protected virtual string LoggerName => BulkDataImportLogger.LoggerPartName;

	protected virtual string LoggerPartName => "BulkDataImportDataSource";

	public long CurrentIndex => currentIndex;

	protected long StartIndex => startIndex;

	public virtual int PackageSize => SR.GetSetting("BulkDataImport.DataSourcePackageSize", 100);

	public bool IsCleaned { get; private set; }

	public DataTable Current => current;

	public long Count()
	{
		using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger(LoggerName, "BulkDataImportDataSource.GetCount");
		try
		{
			return GetCount();
		}
		catch (Exception exception)
		{
			bulkDataImportLogger.Error(exception);
			throw;
		}
	}

	protected virtual long GetCount()
	{
		return 0L;
	}

	public void CleanUp()
	{
		if (!IsCleaned)
		{
			IsCleaned = true;
			CleanUpAll();
		}
	}

	public abstract void CleanUpAll();

	protected abstract DataTable ReadPackage();

	internal virtual void WritelogBeforeRead(SmartLogger logger)
	{
	}

	internal virtual void WritelogAfterRead(SmartLogger logger, DataTable table)
	{
		logger.InfoIfEnabled("Count readed: " + table.Rows.Count);
	}

	internal virtual void WritelogReadError(SmartLogger logger, Exception exception)
	{
		logger.Error(exception);
	}

	public IEnumerator<DataTable> GetEnumerator()
	{
		Guid logKey = Guid.NewGuid();
		using BulkDataImportLogger logGetEnumerator = new BulkDataImportLogger(LoggerName, "BulkDataImportDataSource.GetEnumerator", logKey);
		int rowsCount;
		do
		{
			rowsCount = 0;
			DataTable dataTable;
			using (SmartLogger logger = logGetEnumerator.InnerLogger("BulkDataImportDataSource.Read", $"PackageSize: {PackageSize}; StartIndex: {startIndex}"))
			{
				WritelogBeforeRead(logger);
				try
				{
					dataTable = ReadPackage();
					rowsCount = dataTable.Rows.Count;
				}
				catch (Exception exception)
				{
					WritelogReadError(logger, exception);
					throw;
				}
				WritelogAfterRead(logger, dataTable);
				startIndex += PackageSize;
			}
			currentIndex += dataTable.Rows.Count;
			yield return dataTable;
		}
		while (rowsCount > 0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public bool Read()
	{
		if (enumerator == null)
		{
			enumerator = GetEnumerator();
		}
		if (enumerator.MoveNext())
		{
			current = enumerator.Current;
			return true;
		}
		current = null;
		return false;
	}
}
