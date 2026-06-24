using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class SaleFunnelController : BPMController<ISaleFunnel, long>
    {
        private const string CATALOGS_MENU = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

        [EntityListLink(typeof(ISaleFunnel))]
        public ActionResult Index()
        {
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            return View();
        }

        [CustomGridAction]
        public ActionResult Grid(GridCommand command)
        {
            ISaleFunnelFilter filter = InterfaceActivator.Create<ISaleFunnelFilter>();
            GridData<ISaleFunnel, ISaleFunnelFilter> model = CreateGridData(command, filter);
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            SaleFunnelEditModel model = new SaleFunnelEditModel(InterfaceActivator.Create<ISaleFunnel>());
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            return View("Edit", (object)model);
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            SaleFunnelEditModel model = new SaleFunnelEditModel(EntityManager<ISaleFunnel>.Instance.Load((object)id));
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            return View((object)model);
        }

        [HttpPost]
        public ActionResult Save(SaleFunnelEditModel model)
        {
            try
            {
                string name = model.Entity.Name;
                List<ISaleStage> json = SaleFunnelEditModel.Deserialize(model.JsonData);
                model.Entity.Name = name;
                model.Entity.SaleStages.Where<ISaleStage>((Func<ISaleStage, bool>)(s => !json.Contains(s))).ToList<ISaleStage>().ForEach((Action<ISaleStage>)(s =>
              {
                  s.SaleFunnel = (ISaleFunnel)null;
                  model.Entity.SaleStages.Remove(s);
                  s.Delete();
              }));
                json.Where<ISaleStage>((Func<ISaleStage, bool>)(s => s.IsNew())).ToList<ISaleStage>().ForEach((Action<ISaleStage>)(s =>
              {
                  s.Id = 0L;
                  s.SaleFunnel = model.Entity;
                  model.Entity.SaleStages.Add(s);
              }));
                model.Entity.Save();
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Воронка продаж успешно сохранена."));
            }
            catch (Exception ex)
            {
                ((BaseController)this).Logger.Log(EleWise.ELMA.Logging.LogLevel.Error, ex, "Error while saving Sale Funnel ID:{0} Name:{1}", (object)model.Entity.Id, (object)model.Entity.Name);
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время сохранения воронки продаж."));
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditStage(long? id, string JsonData)
        {
            AddStagePopupViewModel model = new AddStagePopupViewModel();
            if (id.HasValue)
            {
                List<ISaleStage> source = SaleFunnelEditModel.Deserialize(JsonData, false);
                model.Entity = source.FirstOrDefault<ISaleStage>((Func<ISaleStage, bool>)(s => s.Id == id.Value));
            }
            if (model.Entity == null)
                model.Entity = new InstanceOf<ISaleStage>()
                {
                    New = {
            Color = new InstanceOf<IColor>()
            {
              New = {
                ColorCode = "#0054a5"
              }
            }.New
          }
                }.New;
            ((ControllerBase)this).ViewData.TemplateInfo = new TemplateInfo()
            {
                HtmlFieldPrefix = "SaleStage"
            };
            return PartialView("AddStage", (object)model);
        }

        public ActionResult SaveStage([Bind(Prefix = "SaleStage")] AddStagePopupViewModel stageModel, string stagesJsonData)
        {
            List<ISaleStage> saleStageList = SaleFunnelEditModel.Deserialize(stagesJsonData, false);
            int index = saleStageList.FindIndex((Predicate<ISaleStage>)(s => s.Id == stageModel.Entity.Id));
            if (index >= 0)
            {
                saleStageList[index] = stageModel.Entity;
            }
            else
            {
                stageModel.Entity.Id = 0L;
                saleStageList.Add(stageModel.Entity);
                stageModel.Entity.Id = saleStageList.Min<ISaleStage>((Func<ISaleStage, long>)(s => s.Id)) - 1L;
                stageModel.Entity.GlobalOrder = saleStageList.Max<ISaleStage>((Func<ISaleStage, long>)(s => s.GlobalOrder)) + 1L;
            }
          ((ControllerBase)this).ViewData["GridId"] = (object)"SaleStagesGrid";
            return PartialView("SaleStagesGrid", (object)saleStageList);
        }

        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        [HttpPost]
        public ActionResult Delete(long id)
        {
            try
            {
                EntityManager<ISaleFunnel>.Instance.Delete(EntityManager<ISaleFunnel>.Instance.Load((object)id));
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Воронка продаж удалена"));
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время удаления воронки продаж."));
                ((BaseController)this).Logger.Error((object)EleWise.ELMA.SR.T("Произошла ошибка во время удаления воронки продаж."), ex);
            }
            return (ActionResult)new EmptyResult();
        }
    }
}
