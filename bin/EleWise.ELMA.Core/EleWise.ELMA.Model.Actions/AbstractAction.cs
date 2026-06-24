using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model.Actions;

public abstract class AbstractAction : IAction
{
	protected readonly IActionExecutionContext Context;

	protected readonly IActionExecutionFacade ActionExecutionFacade;

	private readonly bool _003CIsEmpty_003Ek__BackingField;

	public bool IsEmpty => _003CIsEmpty_003Ek__BackingField;

	protected AbstractAction(IActionExecutionContext context, IActionExecutionFacade actionExecutionFacade)
	{
		Contract.ArgumentNotNull(context, "context");
		Contract.ArgumentNotNull(actionExecutionFacade, "actionExecutionFacade");
		Context = context;
		ActionExecutionFacade = actionExecutionFacade;
		_003CIsEmpty_003Ek__BackingField = context.IsEmpty;
	}
}
