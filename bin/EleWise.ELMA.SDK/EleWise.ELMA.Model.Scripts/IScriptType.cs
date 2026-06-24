using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IScriptType
{
	Guid Uid { get; }

	string Name { get; }

	string ListReferenceAdd { get; }

	ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null);
}
