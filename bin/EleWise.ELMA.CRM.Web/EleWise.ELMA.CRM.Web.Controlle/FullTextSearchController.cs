using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.FullTextSearch;
using EleWise.ELMA.CRM.FullTextSearch.Components;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class FullTextSearchController : BPMController
{
	[HttpPost]
	public ActionResult IndexingContractorOff()
	{
		Locator.GetServiceNotNull<IFullTextSearchService>().StopIndexingType(typeof(IContractorFullTextSearchObject));
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		serviceNotNull.Settings.IndexingContractor = false;
		serviceNotNull.Settings.IndexingStopInfo = null;
		serviceNotNull.SaveSettings();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "FullTextSearch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}

	[HttpPost]
	public ActionResult IndexingContractorAttachmentsOff()
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		serviceNotNull.Settings.IndexingContractorAttachments = false;
		serviceNotNull.Settings.IndexingStopInfo = null;
		serviceNotNull.SaveSettings();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "FullTextSearch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}

	[HttpGet]
	public ActionResult IndexingContractorOn(bool indexingContractorAttachments)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
		indexQueue.QueueType = IndexQueueType.IndexByType;
		indexQueue.CardTypeUid = ContractorFullTextSearchExtension.ContractorCardUid;
		indexQueue.Save();
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		serviceNotNull.Settings.IndexingContractor = true;
		serviceNotNull.Settings.IndexingStopInfo = null;
		if (indexingContractorAttachments)
		{
			serviceNotNull.Settings.IndexingContractorAttachments = true;
		}
		serviceNotNull.SaveSettings();
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			Result = true
		});
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val;
	}
}
