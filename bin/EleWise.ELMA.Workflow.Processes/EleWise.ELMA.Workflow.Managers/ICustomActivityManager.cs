using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Managers;

internal interface ICustomActivityManager : IEntityManager<ICustomActivity, long>, IEntityManager<ICustomActivity>, IEntityManager
{
	void GenerateCustomActivityParametersAssembly(ICustomActivity ca, bool debugAssembly = false);
}
