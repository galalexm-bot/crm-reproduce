using Orchard.Tasks;

namespace Orchard.Environment;

public interface IOrchardShell
{
	ISweepGenerator Sweep { get; }

	void Activate();

	void Terminate();
}
