using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IEmail))]
public interface IEmailFilter : IEntityFilter
{
	string EmailString { get; set; }
}
