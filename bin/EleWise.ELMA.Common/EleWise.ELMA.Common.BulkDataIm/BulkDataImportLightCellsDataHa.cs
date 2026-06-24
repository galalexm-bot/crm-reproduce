using System.Collections.Generic;
using System.Data;
using System.Threading;
using Aspose.Cells;
using EleWise.ELMA.Common.BulkDataImport.Exceptions;

namespace EleWise.ELMA.Common.BulkDataImport.DataSources;

internal class BulkDataImportLightCellsDataHandler : LightCellsDataHandler
{
	internal int RowCount;

	internal DataTable WorkSheetTable;

	private long currentIndex;

	private readonly long packageSize;

	private bool forCount;

	private Dictionary<long, string> columnNames;

	private AutoResetEvent callbackEventWait;

	private AutoResetEvent mainEventWait;

	private BulkDataImportLogger logger;

	internal BulkDataImportLightCellsDataHandler(long packageSize, bool forCount, AutoResetEvent mainEventWait, AutoResetEvent callbackEventWait)
	{
		currentIndex = 0L;
		this.packageSize = packageSize;
		this.forCount = forCount;
		this.callbackEventWait = callbackEventWait;
		this.mainEventWait = mainEventWait;
		RowCount = 0;
		logger = new BulkDataImportLogger("BulkDataImport", "BulkDataImportLightCellsDataHandler");
	}

	public bool StartSheet(Worksheet sheet)
	{
		WorkSheetTable = new DataTable(sheet.get_Name());
		currentIndex = 0L;
		columnNames = new Dictionary<long, string>();
		return true;
	}

	public bool StartRow(int rowIndex)
	{
		if (forCount)
		{
			RowCount++;
			return false;
		}
		if (rowIndex != 0 && (rowIndex <= currentIndex || rowIndex > currentIndex + packageSize))
		{
			if (rowIndex > currentIndex + packageSize)
			{
				currentIndex += packageSize;
				mainEventWait.Set();
				callbackEventWait.WaitOne();
				WorkSheetTable.Rows.Clear();
				RowCount = 0;
				return true;
			}
			return false;
		}
		return true;
	}

	public bool ProcessRow(Row row)
	{
		if (row.get_Index() != 0)
		{
			RowCount++;
			WorkSheetTable.Rows.Add(WorkSheetTable.NewRow());
		}
		return true;
	}

	public bool StartCell(int column)
	{
		return true;
	}

	public bool ProcessCell(Cell cell)
	{
		if (cell.get_Row() == 0 && !string.IsNullOrWhiteSpace(cell.get_StringValue()))
		{
			if (columnNames.ContainsValue(cell.get_StringValue()))
			{
				throw new DataSourceReadException(SR.T("Ошибка чтения файла Excel. Несколько столбцов заголовка содержат одно название"));
			}
			WorkSheetTable.Columns.Add(cell.get_StringValue());
			columnNames.Add(cell.get_Column(), cell.get_StringValue());
		}
		else
		{
			string text = columnNames[cell.get_Column()];
			if (string.IsNullOrWhiteSpace(text))
			{
				logger.Warn(SR.T("При чтении из Excel найдены данные, для которых не задано имя колонки. Столбец {0} не содержит данных в первой ячейке.", cell.get_Column()));
			}
			else
			{
				WorkSheetTable.Rows[RowCount - 1][text] = cell.get_Value();
			}
		}
		return false;
	}
}
