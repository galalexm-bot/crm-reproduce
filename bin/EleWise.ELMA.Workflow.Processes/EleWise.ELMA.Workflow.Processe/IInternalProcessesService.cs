using EleWise.ELMA.Modules;

namespace EleWise.ELMA.Workflow.Processes;

internal interface IInternalProcessesService : ILicensedUnit
{
	void Check();
}
