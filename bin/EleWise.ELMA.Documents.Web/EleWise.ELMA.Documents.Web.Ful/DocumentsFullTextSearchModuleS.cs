using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Documents.Web.FullTextSearch.Models;

public class DocumentsFullTextSearchModuleSettingsModel
{
	public DocumentsFullTextSearchSettings Settings { get; set; }

	public FullTextSearchState IndexState { get; set; }

	public bool ReIndexState { get; set; }

	[DisplayName("SR.M('Индексировать версии документов')")]
	public bool IndexVersion { get; set; }
}
