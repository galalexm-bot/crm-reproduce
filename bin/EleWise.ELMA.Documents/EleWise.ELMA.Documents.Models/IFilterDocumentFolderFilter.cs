using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models.Folders;

[FilterFor(typeof(IFilterDocumentFolder))]
public interface IFilterDocumentFolderFilter : IDmsObjectFilter, IEntityFilter
{
}
