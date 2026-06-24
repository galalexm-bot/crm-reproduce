using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Extensions;

[Component]
public class TaskFilterPermissionResolver : IFilterPermissionResolver
{
	public FilterType FilterType => FilterType.SharedFilter;

	public bool SupportedType(IFilterFolder filter)
	{
		if (!(filter.ObjectsType.TypeUid == InterfaceActivator.UID<ITaskBase>()))
		{
			return filter.ObjectsType.TypeUid == TaskControlUniqueFilterExtension.Guid;
		}
		return true;
	}

	public bool HasPermission(IFilterFolder filter)
	{
		if (SupportedType(filter))
		{
			return Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.TasksEditGlobalFilters);
		}
		return false;
	}
}
