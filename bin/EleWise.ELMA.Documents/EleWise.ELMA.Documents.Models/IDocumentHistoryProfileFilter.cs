using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentHistoryProfile))]
public interface IDocumentHistoryProfileFilter : IEntityFilter
{
	IDocumentMetadataProfile DocumentProfile { get; set; }
}
