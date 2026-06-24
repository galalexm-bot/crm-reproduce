using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentMetadataProfile))]
public interface IDocumentMetadataProfileFilter : IEntityFilter
{
}
