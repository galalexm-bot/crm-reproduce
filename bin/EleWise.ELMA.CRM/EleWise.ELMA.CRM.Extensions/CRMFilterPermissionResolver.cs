using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Extensions;

[Component]
public class CRMFilterPermissionResolver : IFilterPermissionResolver
{
	public FilterType FilterType => FilterType.SharedFilter;

	public bool SupportedType(IFilterFolder filter)
	{
		if (!(filter.ObjectsType.TypeUid == InterfaceActivator.UID<IContractor>()) && !(filter.ObjectsType.TypeUid == InterfaceActivator.UID<IContact>()) && !(filter.ObjectsType.TypeUid == InterfaceActivator.UID<ILead>()) && !(filter.ObjectsType.TypeUid == InterfaceActivator.UID<IInpayment>()) && !(filter.ObjectsType.TypeUid == InterfaceActivator.UID<ISale>()))
		{
			return filter.ObjectsType.TypeUid == InterfaceActivator.UID<IMarketingBase>();
		}
		return true;
	}

	public bool HasPermission(IFilterFolder filter)
	{
		if (SupportedType(filter))
		{
			return Locator.GetService<ISecurityService>().HasPermission(CRMPermissionProvider.CRMEditGlobalFilters);
		}
		return false;
	}
}
