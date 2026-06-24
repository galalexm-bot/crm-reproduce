using System.Collections.Generic;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Diagnostics.Reports;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class DiagnosticsPageModel
{
	public DiagnosticsSettings Settings { get; set; }

	public DiagnosticsSettingsModuleController SettingsController { get; set; }

	public IEnumerable<IDiagnosticsReport> Reports { get; set; }
}
