using System;
using System.Data;
using System.Threading;
using Aspose.Cells;

namespace EleWise.ELMA.Common.BulkDataImport.DataSources;

public class ExcelDataSourceBase : DataSourceBase
{
	private ExcelDataSourceReader workItem;

	private readonly string filePath;

	private long count = -1L;

	public ExcelDataSourceBase(string filePath)
	{
		this.filePath = filePath;
	}

	public override void CleanUpAll()
	{
		workItem.CleanUp();
	}

	protected override DataTable ReadPackage()
	{
		if (workItem == null)
		{
			workItem = new ExcelDataSourceReader(PackageSize, filePath, new AutoResetEvent(initialState: false), new AutoResetEvent(initialState: false));
		}
		return workItem.GetNextPackage();
	}

	protected override long GetCount()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (count >= 0)
		{
			return count;
		}
		using (BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger(LoggerName, LoggerName + ".ExcelGetCount"))
		{
			try
			{
				LoadOptions val = new LoadOptions();
				BulkDataImportLightCellsDataHandler bulkDataImportLightCellsDataHandler = new BulkDataImportLightCellsDataHandler(2147483647L, forCount: true, null, null);
				val.set_LightCellsDataHandler((LightCellsDataHandler)(object)bulkDataImportLightCellsDataHandler);
				new Workbook(filePath, val);
				count = bulkDataImportLightCellsDataHandler.RowCount;
			}
			catch (Exception exception)
			{
				bulkDataImportLogger.Error(exception);
			}
		}
		return count;
	}

	internal override void WritelogBeforeRead(SmartLogger logger)
	{
		base.WritelogBeforeRead(logger);
		logger.Info(SR.T("Начинаем загрузку данных из Excel"));
	}
}
