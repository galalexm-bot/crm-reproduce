using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Extensions;

[Component(Order = 100)]
public class FilterPortletCheckPermissionExtensions : IFilterPortletCheckPermission
{
	public bool AvailablePermissionType(Guid TypeUid)
	{
		if (!(TypeUid == InterfaceActivator.UID<IContractor>()) && !(TypeUid == InterfaceActivator.UID<IContact>()) && !(TypeUid == InterfaceActivator.UID<ILead>()) && !(TypeUid == InterfaceActivator.UID<ISale>()) && !(TypeUid == InterfaceActivator.UID<IInpayment>()))
		{
			return TypeUid == InterfaceActivator.UID<IMarketingBase>();
		}
		return true;
	}

	public bool HasPermission(Guid TypeUid)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		if (TypeUid == InterfaceActivator.UID<ISale>())
		{
			if (serviceNotNull.HasPermission(CRMPermissionProvider.CRMAccessPermission))
			{
				return serviceNotNull.HasPermission(CRMPermissionProvider.SalesAccessPermission);
			}
			return false;
		}
		if (TypeUid == InterfaceActivator.UID<IInpayment>())
		{
			if (serviceNotNull.HasPermission(CRMPermissionProvider.CRMAccessPermission))
			{
				return serviceNotNull.HasPermission(CRMPermissionProvider.InpaymentsAccessPermission);
			}
			return false;
		}
		return serviceNotNull.HasPermission(CRMPermissionProvider.CRMAccessPermission);
	}
}
