using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Actions;

public sealed class ActionWithResult<TResult> : AbstractAction
{
	public ActionWithResult(IActionExecutionContext context, IActionExecutionFacade actionExecutionFacade)
		: base(context, actionExecutionFacade)
	{
	}

	public System.Threading.Tasks.Task<TResult> Call()
	{
		return ActionExecutionFacade.Execute<TResult>(Context);
	}
}
