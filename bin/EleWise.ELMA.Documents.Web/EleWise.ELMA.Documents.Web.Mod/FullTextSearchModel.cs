using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.Documents.Web.Models;

public class FullTextSearchModel
{
	public int PageIndex;

	public int PageSize;

	public string SearchString { get; set; }

	public IFolder Folder { get; set; }

	public bool? IsArchived { get; set; }

	public bool? DisableArchive { get; set; }

	public bool? HierarchicalByFolder { get; set; }

	public long CountAllResult => (Result != null) ? Result.CountAllResult : 0;

	public FullTextSearchResultModel Result { get; set; }
}
