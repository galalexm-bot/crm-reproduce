using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Model.Scripts;

public interface IMethodsService
{
	bool MethodExists(string methodName, CodeType codeType);

	bool MethodExists(string methodName, CodeType codeType, Guid metadataUid);

	System.Threading.Tasks.Task<ScriptMethodInfoWrapper> AddMethod(ScriptMethodDeclaration method, CodeType codeType, CodeType[] enableCodeTypes);

	System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper> GetClientScriptMethodWrappers();

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>> GetScriptMethodWrappers(CodeType[] enableCodeTypes);

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>> GetGlobalScriptMethods();

	System.Collections.Generic.IEnumerable<ScriptMethodDeclaration> GetServerScriptMethods();

	System.Collections.Generic.IEnumerable<ScriptMethodDeclaration> GetClientScriptMethods();

	void Refresh(CodeType codeType);
}
