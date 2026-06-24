using System.Collections.Generic;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Scripts;

public interface IScriptService
{
	GenerateMethodCodeResponse GenerateMethodCode(GenerateMethodCodeRequest request);

	IEnumerable<ScriptMethodDeclaration> ParseMethods(ParseMethodsRequest request);

	string ChangeSourceClassName(string sourceCode, string oldName, string newName);

	AddInterfaceResult AddInterface(AddInterfaceData data);

	bool InterfaceExists(InterfaceExistsInfo info);
}
