using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[FilterFor(typeof(IPaymentSystem))]
public interface IPaymentSystemFilter : IEntityFilter
{
	string Name { get; set; }
}
