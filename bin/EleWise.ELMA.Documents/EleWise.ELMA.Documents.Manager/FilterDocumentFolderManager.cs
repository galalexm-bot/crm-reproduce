using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

public class FilterDocumentFolderManager : FolderManager<IFilterDocumentFolder, long>
{
	public new static FilterDocumentFolderManager Instance => Locator.GetServiceNotNull<FilterDocumentFolderManager>();
}
