using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IPersonalGroup))]
public interface IPersonalGroupFilter : IEntityFilter
{
	[Uid("0258083a-809b-4e44-8fd7-2db5dea34b85")]
	IUser Owner { get; set; }

	[Uid("4fd1e379-fb9c-4e3f-ac7d-fb0c7e362858")]
	string Name { get; set; }
}
