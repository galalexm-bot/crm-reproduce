using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IFile))]
public interface IFileFilter : IDocumentFilter, IDmsObjectFilter, IEntityFilter
{
}
