// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.SaleTypeController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class SaleTypeController : BPMController<ISaleType, long>
    {
        private const string CATALOGS_MENU = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

        [EntityListLink(typeof(ISaleType))]
        public ActionResult Index()
        {
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            return View();
        }

        [CustomGridAction]
        public ActionResult Grid(GridCommand command) => PartialView(CreateGridData(command));

        [HttpGet]
        public ActionResult Add()
        {
            ISaleType model = InterfaceActivator.Create<ISaleType>();
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            return View("Edit", (object)model);
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            ISaleType model = EntityManager<ISaleType>.Instance.Load((object)id);
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            return View((object)model);
        }

        [HttpPost]
        public ActionResult Save(ISaleType model)
        {
            try
            {
                model.Save();
            }
            catch (Exception ex)
            {
                base.Notifier.Error(ex);
                ((BaseController)this).Logger.Log(EleWise.ELMA.Logging.LogLevel.Error, ex, "Error while saving ISaleType");
            }
            return RedirectToAction("Index");
        }

        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        [HttpPost]
        public ActionResult Delete(long id)
        {
            try
            {
                EntityManager<ISaleType>.Instance.Delete(EntityManager<ISaleType>.Instance.Load((object)id));
                base.Notifier.Information(EleWise.ELMA.SR.T("Тип сделки удалён"));
            }
            catch (Exception ex)
            {
                base.Notifier.Error(EleWise.ELMA.SR.T("Произошла ошибка во время удаления типа сделки."));
                ((BaseController)this).Logger.Error((object)EleWise.ELMA.SR.T("Произошла ошибка во время удаления типа сделки."), ex);
            }
            return (ActionResult)new EmptyResult();
        }
    }
}
