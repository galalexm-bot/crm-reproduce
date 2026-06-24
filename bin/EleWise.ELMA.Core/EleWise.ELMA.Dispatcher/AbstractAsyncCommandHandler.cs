using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Dispatcher;

[Component]
public abstract class AbstractAsyncCommandHandler : IAsyncCommandHandler
{
	public abstract System.Threading.Tasks.Task HandleAsync(ActionCommand command);
}
