using EleWise.ELMA.Events;

namespace Orchard.Environment.State;

public interface IShellStateManagerEventHandler : IEventHandler
{
	void ApplyChanges();
}
