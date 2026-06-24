using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.IntegrationModules.Managers;

public class IntegrationModulesGroupManager : EntityManager<IIntegrationModulesGroup, long>
{
	public IIntegrationModulesGroup GetDeletedModulesGroup()
	{
		return Load(IntegrationsConstants.DeletedModulesGroupUid);
	}
}
