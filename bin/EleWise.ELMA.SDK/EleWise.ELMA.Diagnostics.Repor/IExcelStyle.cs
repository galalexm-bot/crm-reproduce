using Aspose.Cells;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public interface IExcelStyle
{
	void Apply(Style style, StyleFlag styleFlag);
}
