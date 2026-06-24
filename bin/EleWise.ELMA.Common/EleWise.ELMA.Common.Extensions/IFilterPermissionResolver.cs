using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IFilterPermissionResolver
{
	FilterType FilterType { get; }

	bool SupportedType(IFilterFolder filter);

	bool HasPermission(IFilterFolder filter);
}
