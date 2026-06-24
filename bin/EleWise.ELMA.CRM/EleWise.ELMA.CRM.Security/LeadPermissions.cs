using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Security;

public class LeadPermissions
{
	public static readonly CrmCustomPermission<ILeadPermission> Read = new CrmCustomPermission<ILeadPermission>(SR.T("Привилегия на чтение возможностей"), (ILeadPermission p) => p.CanRead);

	public static readonly CrmCustomPermission<ILeadPermission> Edit = new CrmCustomPermission<ILeadPermission>(SR.T("Привилегия на редактирование возможностей"), (ILeadPermission p) => p.CanEdit);
}
