using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ExtensionPoint(ComponentType.All)]
public interface IPerformanceReportPageColumnBuilder
{
	void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric;
}
