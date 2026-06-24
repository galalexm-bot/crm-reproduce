// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.LeadScoringSettingsController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  [RouteArea("EleWise.ELMA.CRM.Web")]
  public class LeadScoringSettingsController : BPMController
  {
    public ActionResult Index()
    {
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View();
    }

    [CustomGridAction]
    public ActionResult Grid(GridCommand command)
    {
      List<LeadScoringSettings> leadScoringSettings = LeadScoringSettings.GetLeadScoringSettings();
      return PartialView((object) new GridData<LeadScoringSettings>()
      {
        DataSource = (IEnumerable) leadScoringSettings,
        PageSize = 10,
        Command = command
      });
    }

    [HttpGet]
    public ActionResult Add()
    {
      LeadScoringModel model = new LeadScoringModel();
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View("Edit", (object) model);
    }

    [HttpGet]
    public ActionResult Edit(long id)
    {
      LeadScoringModel model = new LeadScoringModel(id);
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View((object) model);
    }

    [HttpPost]
    public ActionResult Save(LeadScoringModel model)
    {
      try
      {
        model.Save();
      }
      catch (Exception ex)
      {
        // ISSUE: explicit non-virtual call
        Notifier.Error(ex);
        ((BaseController) this).Logger.Error((object) "Error while saving LeadScoringSettings", ex);
      }
      return RedirectToAction("Index");
    }

    [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
    [HttpPost]
    public ActionResult Delete(long id)
    {
      try
      {
        LeadScoringSettings.GetLeadScoringSettings().FirstOrDefault<LeadScoringSettings>((Func<LeadScoringSettings, bool>) (m => m.Id == id))?.Delete();
        // ISSUE: explicit non-virtual call
        Notifier.Information(EleWise.ELMA.SR.T("Настройка удалена"));
      }
      catch (Exception ex)
      {
        // ISSUE: explicit non-virtual call
        Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время удаления настройки."));
        ((BaseController) this).Logger.Error((object) EleWise.ELMA.SR.T("Произошла ошибка во время удаления настройки."), ex);
      }
      return (ActionResult) new EmptyResult();
    }

    [CustomGridAction]
    public ActionResult StepGrid(GridCommand command)
    {
      IEnumerable<LeadStepScoringModel> stepScoringModels = LeadStepScoring.GetListStepScoring().Select<LeadStepScoring, LeadStepScoringModel>((Func<LeadStepScoring, LeadStepScoringModel>) (m => new LeadStepScoringModel(m.Id)));
      return PartialView((object) new GridData<LeadStepScoringModel>()
      {
        DataSource = (IEnumerable) stepScoringModels,
        PageSize = 10,
        Command = command
      });
    }

    [HttpGet]
    public ActionResult EditStep(long id)
    {
      LeadStepScoringModel model = new LeadStepScoringModel(id);
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View((object) model);
    }

    [HttpPost]
    public ActionResult SaveStep(LeadStepScoringModel model)
    {
      try
      {
        model.Save();
      }
      catch (Exception ex)
      {
        // ISSUE: explicit non-virtual call
        Notifier.Error(ex);
        ((BaseController) this).Logger.Error((object) "Error while saving LeadStepScoring", ex);
      }
      return RedirectToAction("Index");
    }
  }
}
