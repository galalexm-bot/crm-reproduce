using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Actions;

public sealed class ActionWithParamResult<TParam, TResult> : AbstractAction
{
	public ActionWithParamResult(IActionExecutionContext context, IActionExecutionFacade actionExecutionFacade)
		: base(context, actionExecutionFacade)
	{
	}

	public System.Threading.Tasks.Task<TResult> Call(TParam param)
	{
		return ActionExecutionFacade.Execute<TParam, TResult>(Context, param);
	}
}
