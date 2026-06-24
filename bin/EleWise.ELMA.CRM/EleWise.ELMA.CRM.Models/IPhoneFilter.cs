using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IPhone))]
public interface IPhoneFilter : IEntityFilter
{
	string PhoneString { get; set; }

	string DisplayName { get; set; }

	ReferenceOnEntity ReferenceOnEntity { get; set; }
}
