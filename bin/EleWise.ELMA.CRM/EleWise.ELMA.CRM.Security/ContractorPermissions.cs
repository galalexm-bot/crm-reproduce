using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Security;

public class ContractorPermissions
{
	public static readonly CrmCustomPermission<IContractorPermission> Read = new CrmCustomPermission<IContractorPermission>(SR.T("Привилегия на чтение контрагентов"), (IContractorPermission p) => p.CanRead);

	public static readonly CrmCustomPermission<IContractorPermission> Edit = new CrmCustomPermission<IContractorPermission>(SR.T("Привилегия на редактирование контрагентов"), (IContractorPermission p) => p.CanEdit);
}
