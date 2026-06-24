using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Scripts;

[ServiceContract]
public interface IScriptService
{
	System.Threading.Tasks.Task ExecuteScript(ScriptExecutionParams executionParams);

	System.Threading.Tasks.Task<object> ExecuteScriptWithResult(ScriptExecutionParams executionParams);

	System.Collections.Generic.IEnumerable<ScriptMethodParameter> GenerateServerParameters(GenerateParametersOptions options = null);
}
