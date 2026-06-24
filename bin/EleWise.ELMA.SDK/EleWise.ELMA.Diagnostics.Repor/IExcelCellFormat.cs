using Aspose.Cells;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public interface IExcelCellFormat
{
	void SetCellValue(Cell cell, object value);

	void ApplyFormat(Style style);
}
