using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UIBuilder.CodeGeneration;

namespace EleWise.ELMA.UIBuilder.Components;

[Component(Order = int.MaxValue)]
internal sealed class EntityMetadataClientScriptModuleTypeInfo : IScriptModuleTypeInfo
{
	public Type GeneratorType => typeof(EntityClientScriptModuleCodeGenerator);

	public bool Check(IMetadata metadata, Guid scriptModuleTypeUid)
	{
		if (metadata is EntityMetadata)
		{
			return scriptModuleTypeUid == ClientScriptModuleType.TypeUid;
		}
		return false;
	}
}
