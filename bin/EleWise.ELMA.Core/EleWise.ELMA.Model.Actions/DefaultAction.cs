using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Actions;

public sealed class DefaultAction : AbstractAction
{
	public DefaultAction(IActionExecutionContext context, IActionExecutionFacade actionExecutionFacade)
		: base(context, actionExecutionFacade)
	{
	}

	public System.Threading.Tasks.Task Call()
	{
		return ActionExecutionFacade.Execute(Context);
	}
}
