using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IMarketingTag))]
public interface IMarketingTagFilter : IEntityFilter
{
	string Name { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	IMarketingBase MarketingObject { get; set; }
}
