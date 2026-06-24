using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Extensions;

[Component]
public class CrmSystemCatalogCheckerExtension : ISystemCatalogChecker
{
	public bool CantDelete(object entity)
	{
		if (entity is IContractorType contractorType && contractorType.Uid == ContractorTypeManager.PartnerItemUid)
		{
			return true;
		}
		return false;
	}
}
