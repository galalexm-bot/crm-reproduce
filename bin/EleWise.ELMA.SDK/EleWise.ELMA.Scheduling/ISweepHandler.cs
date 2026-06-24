using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Scheduling;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ISweepHandler
{
	void Execute();
}
