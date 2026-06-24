using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Scripts;

[ServiceContract]
public interface IScriptLoaderService
{
	object LoadModule(string moduleName);

	void ApplyScript(string assemblyName, string sourceCode, Action afterLoadAction = null);

	void UnloadAllScripts();
}
