using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Scripts;

[ExtensionPoint(ComponentType.All)]
public interface IScriptModuleTypeInfo
{
	Type GeneratorType { get; }

	bool Check(IMetadata metadata, Guid scriptModuleTypeUid);
}
