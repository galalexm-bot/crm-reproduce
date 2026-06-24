using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;

namespace EleWise.ELMA.Diagnostics.Reports.Activity;

[ExtensionPoint(ComponentType.All)]
public interface IActivityReportPage
{
	string Name { get; }

	void ExportExcel(IEnumerable<CallContextInfo> currentCalls, ExcelReportBuilder builder);
}
