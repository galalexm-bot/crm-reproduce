using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class InpaymentSettingsPermission : InstanceSettingsPermissionChildBase<IInpayment, ISale, ISalePersonPermission>
{
	public InpaymentSettingsPermission()
		: base((Expression<Func<ISalePersonPermission, ISale>>)((ISalePersonPermission access) => access.Sale), (Expression<Func<IInpayment, ISale>>)((IInpayment inpayment) => inpayment.Sale))
	{
	}

	public override Guid GetParentPermissionId(Guid childPermissionId)
	{
		if (childPermissionId == CRMPermissionProvider.CreateInpaymentPermission.Id)
		{
			return CRMPermissionProvider.CreateInpaymentPermission.ParentPermission.Id;
		}
		if (childPermissionId == CRMPermissionProvider.EditInpaymentPermission.Id)
		{
			return CRMPermissionProvider.EditInpaymentPermission.ParentPermission.Id;
		}
		if (childPermissionId == CRMPermissionProvider.ViewInpaymentPermission.Id)
		{
			return CRMPermissionProvider.ViewInpaymentPermission.ParentPermission.Id;
		}
		if (childPermissionId == CRMPermissionProvider.DeleteInpaymentPermission.Id)
		{
			return CRMPermissionProvider.DeleteInpaymentPermission.ParentPermission.Id;
		}
		return childPermissionId;
	}

	protected override ICollection<ISalePersonPermission> GetPermissionHolderCollection(ISale target)
	{
		return (ICollection<ISalePersonPermission>)target.Permission;
	}
}
