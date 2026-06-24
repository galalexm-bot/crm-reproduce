using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Dispatcher;

[ExtensionPoint]
public interface IAsyncCommandHandler
{
	System.Threading.Tasks.Task HandleAsync(ActionCommand command);
}
