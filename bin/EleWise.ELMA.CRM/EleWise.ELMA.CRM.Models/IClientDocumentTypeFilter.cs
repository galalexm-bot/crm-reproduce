using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IClientDocumentType))]
public interface IClientDocumentTypeFilter : IEntityFilter
{
	string Name { get; set; }
}
