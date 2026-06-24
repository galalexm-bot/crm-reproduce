using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ICodeEditorExtension
{
	bool Check(InitWorkspaceRequest request);

	Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request);

	IScriptData GenerateSource(InitWorkspaceRequest request);

	int GetMethodPosition(string sourceCode, string className, string methodName);
}
