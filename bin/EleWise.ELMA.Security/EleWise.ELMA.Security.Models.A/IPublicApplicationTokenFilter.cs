using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models.API;

[FilterFor(typeof(IPublicApplicationToken))]
public interface IPublicApplicationTokenFilter : IEntityFilter
{
	IPublicApplication Application { get; set; }

	string Token { get; set; }

	DateTimeRange Expire { get; set; }

	bool? IsSystem { get; set; }
}
