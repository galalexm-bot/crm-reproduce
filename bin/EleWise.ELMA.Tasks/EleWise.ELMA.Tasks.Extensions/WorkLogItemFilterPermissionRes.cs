using System;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Tasks.Extensions;

[Component]
public class WorkLogItemFilterPermissionResolver : IFilterPermissionResolver
{
	public FilterType FilterType => FilterType.SharedFilter;

	public bool SupportedType(IFilterFolder filter)
	{
		return filter.ObjectsType.TypeUid == new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}");
	}

	public bool HasPermission(IFilterFolder filter)
	{
		if (SupportedType(filter))
		{
			return Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.WorkLogItemEditGlobalFilters);
		}
		return false;
	}
}
