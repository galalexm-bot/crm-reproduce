using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch;

[Component]
public class CRMFullTextSearchSettingsModule : GlobalSettingsModuleBase<CRMFullTextSearchSettings>
{
	public override string ModuleName => SR.T("Индексация CRM");

	public override Guid ModuleGuid => Guid.Parse("525E552C-871C-4DDF-8946-14077AE34ED7");

	public static bool IndexingContractorAttachmentsIsOn
	{
		get
		{
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if (Locator.GetServiceNotNull<IFullTextSearchService>().IndexingIsWorking() && !IndexQueueManager.Instance.HasIndexAllReIndexByTypeQueue() && serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor)
			{
				return serviceNotNull.Settings.IndexingContractorAttachments;
			}
			return false;
		}
	}
}
