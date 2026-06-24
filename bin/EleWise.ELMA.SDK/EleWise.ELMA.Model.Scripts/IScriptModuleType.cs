using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IScriptModuleType
{
	Guid Uid { get; }

	string Name { get; }

	string GenerateSourceCode(object parameters);

	ScriptCompileResult Compile(ScriptModule module);
}
