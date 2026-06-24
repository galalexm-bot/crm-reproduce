// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.FullTextSearchController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.FullTextSearch;
using EleWise.ELMA.CRM.FullTextSearch.Components;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class FullTextSearchController : BPMController
  {
    [HttpPost]
    public ActionResult IndexingContractorOff()
    {
      Locator.GetServiceNotNull<IFullTextSearchService>().StopIndexingType(typeof (IContractorFullTextSearchObject));
      CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
      serviceNotNull.Settings.IndexingContractor = false;
      serviceNotNull.Settings.IndexingStopInfo = (string) null;
      serviceNotNull.SaveSettings();
      return RedirectToAction("Index", "FullTextSearch", (object) new
      {
        area = "EleWise.ELMA.BPM.Web.Common"
      });
    }

    [HttpPost]
    public ActionResult IndexingContractorAttachmentsOff()
    {
      CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
      serviceNotNull.Settings.IndexingContractorAttachments = false;
      serviceNotNull.Settings.IndexingStopInfo = (string) null;
      serviceNotNull.SaveSettings();
      return RedirectToAction("Index", "FullTextSearch", (object) new
      {
        area = "EleWise.ELMA.BPM.Web.Common"
      });
    }

    [HttpGet]
    public ActionResult IndexingContractorOn(bool indexingContractorAttachments)
    {
      IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
      indexQueue.QueueType = new IndexQueueType?(IndexQueueType.IndexByType);
      indexQueue.CardTypeUid = new Guid?(ContractorFullTextSearchExtension.ContractorCardUid);
      indexQueue.Save();
      CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
      serviceNotNull.Settings.IndexingContractor = true;
      serviceNotNull.Settings.IndexingStopInfo = (string) null;
      if (indexingContractorAttachments)
        serviceNotNull.Settings.IndexingContractorAttachments = true;
      serviceNotNull.SaveSettings();
      return (ActionResult) new JsonResult()
      {
        Data = (object) new{ Result = true },
        JsonRequestBehavior = JsonRequestBehavior.AllowGet
      };
    }
  }
}
