using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Model.Scripts.Manager;

internal interface IGlobalScriptModuleManager : IEntityManager<IGlobalScriptModule, long>, IEntityManager<IGlobalScriptModule>, IEntityManager
{
	void GenerateGlobalScriptModuleAssembly(IGlobalScriptModule globalScriptModule);
}
