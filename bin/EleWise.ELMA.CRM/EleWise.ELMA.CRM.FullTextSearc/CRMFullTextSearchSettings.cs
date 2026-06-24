using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch;

public class CRMFullTextSearchSettings : GlobalSettingsBase, IFullTextSearchModuleSettings
{
	[DisplayName(typeof(__Resources_CRMFullTextSearchSettings), "IndexingContractor")]
	public bool IndexingContractor { get; set; }

	[DisplayName(typeof(__Resources_CRMFullTextSearchSettings), "IndexingContractorAttachments")]
	public bool IndexingContractorAttachments { get; set; }

	[DisplayName("SR.M('Причина последней остановки индексирования')")]
	public string IndexingStopInfo { get; set; }

	public CRMFullTextSearchSettings()
	{
		IndexingContractor = true;
		IndexingContractorAttachments = true;
	}

	public void BindAndSaveToGlobalSettings()
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null)
		{
			if (serviceNotNull.Settings != this)
			{
				serviceNotNull.Settings.IndexingContractor = IndexingContractor;
				serviceNotNull.Settings.IndexingContractorAttachments = IndexingContractorAttachments;
			}
			serviceNotNull.SaveSettings();
		}
	}
}
