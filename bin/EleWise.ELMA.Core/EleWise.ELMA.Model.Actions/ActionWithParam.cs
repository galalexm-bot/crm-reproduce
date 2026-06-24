using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Actions;

public sealed class ActionWithParam<TParam> : AbstractAction
{
	public ActionWithParam(IActionExecutionContext context, IActionExecutionFacade actionExecutionFacade)
		: base(context, actionExecutionFacade)
	{
	}

	public System.Threading.Tasks.Task Call(TParam param)
	{
		return ActionExecutionFacade.Execute(Context, param);
	}
}
