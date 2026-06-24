using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class ControllerAsyncHandler : AbstractAsyncCommandHandler
{
	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		if (command.ActionTypeId != "ControllerCommand")
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		if (command.Args.Length <= 1)
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		IController controller = command.Args[0] as IController;
		if (!(command.Args[1] is Func<System.Threading.Tasks.Task> val))
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		return (System.Threading.Tasks.Task)((System.Delegate)(object)val).Call((object)controller);
	}
}
