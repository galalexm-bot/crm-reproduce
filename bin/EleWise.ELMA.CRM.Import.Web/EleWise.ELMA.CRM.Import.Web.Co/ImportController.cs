using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Aspose.Cells;
using EleWise.ELMA.CRM.Import.Web.Code;
using EleWise.ELMA.CRM.Import.Web.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using Orchard.Themes;

namespace EleWise.ELMA.CRM.Import.Web.Controllers;

[Themed]
[Permission("A4F6E0B9-1C7D-41AE-87CD-46AD010A011F")]
public class ImportController : BaseController
{
	public ActionResult Index()
	{
		ImportModel importModel = new ImportModel();
		return (ActionResult)(object)((Controller)this).View((object)importModel);
	}

	[HttpPost]
	public ActionResult Preview(ImportModel model)
	{
		model.ImportResultModel = new ImportResultModel();
		model.ImportFileName = ((model.ImportFile != null) ? model.ImportFile.ContentFilePath : string.Empty);
		new ImportManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(model.EntityTypeUid)).ImportToModel(model.ImportFileName, model.ImportResultModel, model.Options, saveEntity: false);
		return (ActionResult)(object)((Controller)this).PartialView("Step2_Preview", (object)model);
	}

	[HttpPost]
	public ActionResult Commit(ImportModel model)
	{
		ImportResultModel importResultModel = new ImportResultModel();
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(model.EntityTypeUid);
		new ImportManager(typeByUid).ImportToModel(model.ImportFileName, importResultModel, model.Options, saveEntity: true);
		if (importResultModel.Entities != null && importResultModel.Entities.Any())
		{
			base.Notifier.Information(SR.T("Успешно импортировано {0} клиентов.", importResultModel.Entities.Count));
			base.Logger.Log(LogLevel.Information, null, "Successfully imported {0} clients. Time spent: {1}.", importResultModel.Entities.Count, string.Join(", ", importResultModel.TotalTime.Select((TotalTimeItem x) => $"{Timers.TimerTypeToString(x.Type)}: {Math.Round(x.Duration / 1000.0)}s")));
		}
		else
		{
			base.Notifier.Warning(SR.T("Нет клиентов для импорта."));
			base.Logger.Log(LogLevel.Information, null, "No contractors to import.");
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", typeof(ILead).IsAssignableFrom(typeByUid) ? "Lead" : "Contractor", new RouteValueDictionary { { "area", "EleWise.ELMA.CRM.Web" } });
	}

	private string LocalizeTemplate(string filename)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Workbook val = new Workbook(filename);
		Cells cells = val.get_Worksheets().get_Item(0).get_Cells();
		for (int i = 0; !string.IsNullOrWhiteSpace(cells.get_Item(1, i).get_StringValue()); i++)
		{
			cells.GetCell(1, i).set_Value((object)SR.T(cells.get_Item(1, i).get_StringValue()));
			cells.GetCell(0, i).set_Value((object)SR.T(cells.get_Item(0, i).get_StringValue()));
		}
		string text = Path.ChangeExtension(IOExtensions.GetTempFileName(), "xls");
		val.Save(text);
		return text;
	}

	[WithoutSpa]
	public ActionResult DownloadTemplate(string templateFilename)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(templateFilename))
		{
			string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules\\EleWise.ELMA.CRM.Import.Web\\Content", templateFilename);
			string fileName = LocalizeTemplate(filename);
			return (ActionResult)(object)File(fileName, "application/octet-stream", templateFilename);
		}
		return (ActionResult)new EmptyResult();
	}
}
