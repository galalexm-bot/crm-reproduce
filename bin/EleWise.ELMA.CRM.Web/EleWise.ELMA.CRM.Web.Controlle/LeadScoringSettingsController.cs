using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[RouteArea("EleWise.ELMA.CRM.Web")]
public class LeadScoringSettingsController : BPMController
{
	public ActionResult Index()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		List<LeadScoringSettings> leadScoringSettings = LeadScoringSettings.GetLeadScoringSettings();
		GridData<LeadScoringSettings> gridData = new GridData<LeadScoringSettings>
		{
			DataSource = leadScoringSettings,
			PageSize = 10,
			Command = command
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult Add()
	{
		LeadScoringModel leadScoringModel = new LeadScoringModel();
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View("Edit", (object)leadScoringModel);
	}

	[HttpGet]
	public ActionResult Edit(long id)
	{
		LeadScoringModel leadScoringModel = new LeadScoringModel(id);
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View((object)leadScoringModel);
	}

	[HttpPost]
	public ActionResult Save(LeadScoringModel model)
	{
		try
		{
			model.Save();
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			base.Logger.Error("Error while saving LeadScoringSettings", exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	[HttpPost]
	public ActionResult Delete(long id)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		try
		{
			LeadScoringSettings.GetLeadScoringSettings().FirstOrDefault((LeadScoringSettings m) => m.Id == id)?.Delete();
			base.Notifier.Information(SR.T("Настройка удалена"));
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время удаления настройки."));
			base.Logger.Error(SR.T("Произошла ошибка во время удаления настройки."), exception);
		}
		return (ActionResult)new EmptyResult();
	}

	[CustomGridAction]
	public ActionResult StepGrid(GridCommand command)
	{
		IEnumerable<LeadStepScoringModel> dataSource = from m in LeadStepScoring.GetListStepScoring()
			select new LeadStepScoringModel(m.Id);
		GridData<LeadStepScoringModel> gridData = new GridData<LeadStepScoringModel>
		{
			DataSource = dataSource,
			PageSize = 10,
			Command = command
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult EditStep(long id)
	{
		LeadStepScoringModel leadStepScoringModel = new LeadStepScoringModel(id);
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View((object)leadStepScoringModel);
	}

	[HttpPost]
	public ActionResult SaveStep(LeadStepScoringModel model)
	{
		try
		{
			model.Save();
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			base.Logger.Error("Error while saving LeadStepScoring", exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}
}
