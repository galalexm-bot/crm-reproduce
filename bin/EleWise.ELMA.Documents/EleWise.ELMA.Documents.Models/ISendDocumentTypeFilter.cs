using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(ISendDocumentType))]
public interface ISendDocumentTypeFilter : IEntityFilter
{
	string Name { get; set; }
}
