using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IPayment))]
public interface IPaymentFilter : IEntityFilter
{
	string Name { get; set; }

	DateTimeRange PaymentDate { get; set; }

	IUser CreationAuthor { get; set; }

	Int64Range Sum { get; set; }

	ISale Sale { get; set; }
}
