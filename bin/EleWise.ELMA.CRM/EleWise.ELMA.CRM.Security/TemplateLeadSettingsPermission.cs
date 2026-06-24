using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class TemplateLeadSettingsPermission : InstanceSettingsPermissionBase<IContLeadPermission, ITemplateLeadPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public TemplateLeadSettingsPermission()
		: base((Expression<Func<ITemplateLeadPermission, IContLeadPermission>>)((ITemplateLeadPermission access) => access.ContainerLead))
	{
	}

	protected override ICollection<ITemplateLeadPermission> GetPermissionHolderCollection(IContLeadPermission target)
	{
		return (ICollection<ITemplateLeadPermission>)target.TemplateLeadPermission;
	}
}
