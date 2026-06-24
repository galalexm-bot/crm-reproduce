using Orchard.Tasks;

namespace Orchard.Commands;

internal class CommandBackgroundService : IBackgroundService, IDependency
{
	public void Sweep()
	{
	}
}
