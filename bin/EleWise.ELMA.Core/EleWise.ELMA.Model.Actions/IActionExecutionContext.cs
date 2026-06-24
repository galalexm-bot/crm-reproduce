namespace EleWise.ELMA.Model.Actions;

public interface IActionExecutionContext
{
	ActionExecutionType ActionExecutionType { get; }

	bool IsEmpty { get; }
}
