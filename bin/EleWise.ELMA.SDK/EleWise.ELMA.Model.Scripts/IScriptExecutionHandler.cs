using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.Server)]
public interface IScriptExecutionHandler
{
	bool Check(ScriptExecutionParams parameters);

	ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters);
}
