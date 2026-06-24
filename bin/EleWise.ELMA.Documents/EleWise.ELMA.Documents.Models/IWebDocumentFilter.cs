using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IWebDocument))]
public interface IWebDocumentFilter : IDocumentFilter, IDmsObjectFilter, IEntityFilter
{
}
