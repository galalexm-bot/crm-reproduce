using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[Component]
public abstract class PerformanceReportPage : IPerformanceReportPage
{
	private readonly List<IPerformanceReportPageColumnBuilder> performanceReportPageColumnBuilders;

	public IEnumerable<IPerformanceReportPageColumnBuilder> PerformanceReportPageColumnBuilders => performanceReportPageColumnBuilders;

	public abstract string Name { get; }

	protected PerformanceReportPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		performanceReportPageColumnBuilders = builders.ToList();
	}

	public abstract void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder);
}
