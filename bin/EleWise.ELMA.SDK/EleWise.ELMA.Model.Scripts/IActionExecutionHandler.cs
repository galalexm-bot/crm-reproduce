using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IActionExecutionHandler
{
	bool Check(ActionExecutionParams parameters);

	ActionExecutionResult Execute(ActionExecutionParams parameters);
}
