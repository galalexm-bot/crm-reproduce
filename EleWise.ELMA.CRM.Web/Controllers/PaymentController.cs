// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.PaymentController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.SalesPlan;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class PaymentController : BPMController<IPayment, long>
  {
    [HttpPost]
    public ActionResult Create(PaymentModel model)
    {
      model.Save();
      return (ActionResult) new JsonResult()
      {
        Data = (object) new{ success = true }
      };
    }
  }
}
