using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Diagnostics.Reports;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class DiagnosticsController : BPMController
{
	[ContentItem(Name = "SR.M('Диагностика системы')", Image24 = "#computer.svg")]
	public ActionResult Index()
	{
		DiagnosticsPageModel diagnosticsPageModel = new DiagnosticsPageModel();
		diagnosticsPageModel.Settings = DiagnosticsManager.Instance.Settings;
		diagnosticsPageModel.SettingsController = Locator.GetServiceNotNull<DiagnosticsSettingsModuleController>();
		diagnosticsPageModel.Reports = ComponentManager.Current.GetExtensionPoints<IDiagnosticsReport>();
		return (ActionResult)(object)((Controller)this).View((object)diagnosticsPageModel);
	}

	[WithoutSpa]
	public ActionResult Report(Guid id)
	{
		IDiagnosticsReport diagnosticsReport = ComponentManager.Current.GetExtensionPoints<IDiagnosticsReport>().FirstOrDefault((IDiagnosticsReport r) => r.Uid == id);
		if (diagnosticsReport == null)
		{
			base.Notifier.Error(SR.T("Отчет не найден"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		string text = diagnosticsReport.Export();
		string typeByExtension = Locator.GetServiceNotNull<IMimeMappingService>().GetTypeByExtension(Path.GetExtension(text));
		return (ActionResult)(object)File(text, typeByExtension, Path.GetFileName(text));
	}

	[HttpPost]
	public ActionResult ClearStatistics()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DiagnosticsManager.Instance.ClearStatistics();
		return (ActionResult)new EmptyResult();
	}
}
