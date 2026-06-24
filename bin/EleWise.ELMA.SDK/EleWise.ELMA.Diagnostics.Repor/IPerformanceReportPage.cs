using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ExtensionPoint(ComponentType.All)]
public interface IPerformanceReportPage
{
	string Name { get; }

	void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder);
}
