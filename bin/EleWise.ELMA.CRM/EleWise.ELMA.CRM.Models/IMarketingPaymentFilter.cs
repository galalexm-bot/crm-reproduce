using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IMarketingPayment))]
public interface IMarketingPaymentFilter : IEntityFilter
{
	ISet<IMarketingBase> MarketingObjectBase { get; set; }

	string Name { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }
}
