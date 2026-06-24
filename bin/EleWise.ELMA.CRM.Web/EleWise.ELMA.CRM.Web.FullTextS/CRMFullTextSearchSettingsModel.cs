using EleWise.ELMA.CRM.FullTextSearch;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.FullTextSearch.Models;

public class CRMFullTextSearchSettingsModel
{
	public CRMFullTextSearchSettings Settings { get; set; }

	public FullTextSearchState IndexState { get; set; }

	public bool ReIndexState { get; set; }

	[DisplayName("SR.M('Индексировать приложения контрагентов')")]
	public bool IndexingContractorAttachments { get; set; }
}
