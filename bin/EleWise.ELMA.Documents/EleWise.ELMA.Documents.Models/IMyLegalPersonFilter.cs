using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IMyLegalPerson))]
public interface IMyLegalPersonFilter : IEntityFilter
{
	IOrganizationItem HeadOrganizationItem { get; set; }
}
