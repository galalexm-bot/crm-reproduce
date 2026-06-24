using System.Data;
using System.IO;
using System.Threading;
using Aspose.Cells;
using EleWise.ELMA.Common.BulkDataImport.Exceptions;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Common.BulkDataImport.DataSources;

internal class ExcelDataSourceReader
{
	private AutoResetEvent mainEventWait;

	private AutoResetEvent callbackEventWait;

	private BulkDataImportLightCellsDataHandler excelDataHandler;

	private bool initialize;

	private readonly string filePath;

	private Thread thread;

	private bool readException;

	private bool readComplete;

	public ExcelDataSourceReader(long packageSize, string filePath, AutoResetEvent mainEventWait, AutoResetEvent callbackEventWait)
	{
		this.filePath = filePath;
		this.mainEventWait = mainEventWait;
		this.callbackEventWait = callbackEventWait;
		excelDataHandler = new BulkDataImportLightCellsDataHandler(packageSize, forCount: false, mainEventWait, callbackEventWait);
	}

	public DataTable GetNextPackage()
	{
		if (readComplete)
		{
			return new DataTable();
		}
		if (!initialize)
		{
			thread = ThreadStarter.StartNewThread(GetNextPageInThread);
			initialize = true;
		}
		else
		{
			callbackEventWait.Set();
		}
		if (readException)
		{
			return new DataTable();
		}
		mainEventWait.WaitOne();
		return excelDataHandler.WorkSheetTable;
	}

	public void CleanUp()
	{
		if (thread != null)
		{
			thread.Abort();
			thread.Join();
		}
		mainEventWait.Dispose();
		callbackEventWait.Dispose();
	}

	private void GetNextPageInThread()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "GetNextPageInThread");
		try
		{
			LoadOptions val = new LoadOptions();
			val.set_LightCellsDataHandler((LightCellsDataHandler)(object)excelDataHandler);
			new Workbook(filePath, val);
		}
		catch (FileNotFoundException exception)
		{
			readException = true;
			bulkDataImportLogger.Error(exception);
		}
		catch (DataSourceReadException exception2)
		{
			readException = true;
			bulkDataImportLogger.Error(exception2);
		}
		catch (ThreadAbortException exception3)
		{
			readException = true;
			bulkDataImportLogger.Error(exception3);
		}
		finally
		{
			readComplete = true;
			mainEventWait.Set();
		}
	}
}
