using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.Documents.FullTextSearch.Model;

public class DocumentFullTextSearchResultModel : FullTextSearchResultModel
{
	public IFolder SearchFolder;

	public bool? IsArchived;

	public bool? DisableArchive;

	public bool? HierarchicalByFolder;
}
