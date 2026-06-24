using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models.API;

[FilterFor(typeof(IPublicApplication))]
public interface IPublicApplicationFilter : IEntityFilter
{
	string Name { get; set; }

	bool? IsActive { get; set; }

	bool? IsSystem { get; set; }
}
