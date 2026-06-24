using System;
using System.Drawing;
using System.IO;
using System.Text;
using Aspose.Cells;
using EleWise.TemplateGenerator.Formats;

namespace EleWise.TemplateGenerator.Cells.Internal;

internal class WorkbookWrapper
{
	public enum CellType
	{
		Decimal,
		DateTime,
		String,
		Default
	}

	internal sealed class CellStyleInfo
	{
		public CellType CellType { get; set; }

		public bool IsTextFormat { get; set; }
	}

	internal sealed class RunningTitleTexts
	{
		public string[] Headers { get; private set; }

		public string[] Footers { get; private set; }

		public RunningTitleTexts()
		{
			Headers = new string[3];
			Footers = new string[3];
		}
	}

	private Workbook _workbook;

	public const char NewColumnSymbol = '\ufffe';

	public const char NewLineSymbol = '\uffff';

	public const int ExcelSheetSectionsCount = 3;

	public WorkbookWrapper(Workbook workbook)
	{
		_workbook = workbook;
	}

	public int GetSheetsCount()
	{
		return ((CollectionBase<Worksheet>)(object)_workbook.get_Worksheets()).get_Count();
	}

	public int GetColsCount(int nSheet)
	{
		return ((CollectionBase<Column>)(object)_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Columns()).get_Count();
	}

	public int GetRowsCount(int nSheet)
	{
		return _workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Rows()
			.get_Count();
	}

	public string ExtractText(int nSheet)
	{
		Worksheet val = _workbook.get_Worksheets().get_Item(nSheet);
		if (val.get_Cells().get_FirstCell() == null || val.get_Cells().get_LastCell() == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = val.get_Cells().get_MaxRow() + 1;
		int num2 = val.get_Cells().get_MaxColumn() + 1;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (val.get_Cells().get_Item(i, j) != null && val.get_Cells().get_Item(i, j).get_Value() != null && !val.get_Cells().get_Item(i, j).get_IsFormula())
				{
					stringBuilder.Append(val.get_Cells().get_Item(i, j).get_Value()
						.ToString());
				}
				stringBuilder.Append('\ufffe');
			}
			stringBuilder.Append('\uffff');
		}
		return stringBuilder.ToString();
	}

	public void SetCellText(int nSheet, int nCol, int nRow, object value)
	{
		SetCellValueString(nSheet, nCol, nRow, (value != null) ? value.ToString() : "");
	}

	public void SetCellValue(int nSheet, int nCol, int nRow, CellType cellType, object value)
	{
		switch (cellType)
		{
		case CellType.Decimal:
			SetCellValueDouble(nSheet, nCol, nRow, Convert.ToDouble(value));
			break;
		case CellType.DateTime:
			SetCellValueDateTime(nSheet, nCol, nRow, Convert.ToDateTime(value));
			break;
		default:
			SetCellText(nSheet, nCol, nRow, value);
			break;
		}
	}

	public void SetCellValueWithTypeConvert(int nSheet, int nCol, int nRow, string value)
	{
		DateTime result2;
		if (double.TryParse(value, out var result))
		{
			SetCellValueDouble(nSheet, nCol, nRow, result);
		}
		else if (DateTime.TryParse(value, out result2))
		{
			SetCellValueDateTime(nSheet, nCol, nRow, result2);
		}
		else
		{
			SetCellText(nSheet, nCol, nRow, value);
		}
	}

	public void SetCellValueBool(int nSheet, int nCol, int nRow, int bValue)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.PutValue(bValue != 0);
	}

	public void SetCellValueInt(int nSheet, int nCol, int nRow, int nValue)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.PutValue(nValue);
	}

	public void SetCellValueDouble(int nSheet, int nCol, int nRow, double nValue)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.PutValue(nValue);
	}

	public void SetCellValueString(int nSheet, int nCol, int nRow, string sValue)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.PutValue(sValue);
	}

	public void SetCellValueDateTime(int nSheet, int nCol, int nRow, DateTime dtValue)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.PutValue(dtValue);
	}

	public string GetCellText(int nSheet, int nCol, int nRow)
	{
		return _workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.get_StringValue();
	}

	public CellStyleInfo GetCellType(int nSheet, int nCol, int nRow)
	{
		Style style = _workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.get_Item(nRow, nCol)
			.GetStyle();
		CellStyleInfo cellStyleInfo = new CellStyleInfo
		{
			IsTextFormat = (style.get_Custom() == "")
		};
		int number = style.get_Number();
		if ((number >= 1 && number <= 11) || (number >= 37 && number <= 40) || number == 48)
		{
			cellStyleInfo.CellType = CellType.Decimal;
		}
		else if ((number >= 14 && number <= 22) || (number >= 45 && number <= 47))
		{
			cellStyleInfo.CellType = CellType.DateTime;
		}
		else if (number == 49)
		{
			cellStyleInfo.CellType = CellType.String;
		}
		else
		{
			cellStyleInfo.CellType = CellType.Default;
		}
		return cellStyleInfo;
	}

	public int InsertImage(int nSheet, int nCol, int nRow, Image image, DrawingFormat format)
	{
		using MemoryStream memoryStream = new MemoryStream();
		image.Save(memoryStream, image.RawFormat);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		if (format == null)
		{
			format = new DrawingFormat();
		}
		return _workbook.get_Worksheets().get_Item(nSheet).get_Pictures()
			.Add(nRow, nCol, (Stream)memoryStream, (int)format.Scale, (int)format.Scale);
	}

	public void CopyRows(int nSheet, int nStartRow, int nEndRow, int nRowToInsert)
	{
		Cells cells = _workbook.get_Worksheets().get_Item(nSheet).get_Cells();
		int num = nEndRow - nStartRow + 1;
		cells.InsertRows(nRowToInsert, num);
		cells.CopyRows(cells, nStartRow + num, nRowToInsert, num);
	}

	public void DeleteRows(int nSheet, int nStartRow, int nEndRow)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_Cells()
			.DeleteRows(nStartRow, nEndRow - nStartRow + 1);
	}

	internal RunningTitleTexts ExtractRunningTitleTexts(int nSheet)
	{
		PageSetup pageSetup = _workbook.get_Worksheets().get_Item(nSheet).get_PageSetup();
		RunningTitleTexts runningTitleTexts = new RunningTitleTexts();
		for (int i = 0; i < 3; i++)
		{
			runningTitleTexts.Headers[i] = pageSetup.GetHeader(i);
			runningTitleTexts.Footers[i] = pageSetup.GetFooter(i);
		}
		return runningTitleTexts;
	}

	internal void SetHeader(int nSheet, int section, string value)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_PageSetup()
			.SetHeader(section, value);
	}

	internal void SetFooter(int nSheet, int section, string value)
	{
		_workbook.get_Worksheets().get_Item(nSheet).get_PageSetup()
			.SetFooter(section, value);
	}
}
