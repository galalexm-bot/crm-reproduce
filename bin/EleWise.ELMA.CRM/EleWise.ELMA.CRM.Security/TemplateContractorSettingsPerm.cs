using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class TemplateContractorSettingsPermission : InstanceSettingsPermissionBase<IContContractorPermission, ITemplateContractorPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public TemplateContractorSettingsPermission()
		: base((Expression<Func<ITemplateContractorPermission, IContContractorPermission>>)((ITemplateContractorPermission access) => access.ContainerContractor))
	{
	}

	protected override ICollection<ITemplateContractorPermission> GetPermissionHolderCollection(IContContractorPermission target)
	{
		return (ICollection<ITemplateContractorPermission>)target.TemplateContractorPermission;
	}
}
