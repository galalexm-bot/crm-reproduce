using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class UIEntityMetadataPublicationHandler : IPublicationHandler
{
	public void UpdateMetadata(IMetadata metadata)
	{
	}

	public void UpdateMetadataItem(IMetadataItem source, IMetadataItem destination)
	{
		ScriptModule clientScriptModule = source.ClientScriptModule;
		if (clientScriptModule != null)
		{
			ScriptModule scriptModule = CloneHelperBuilder.Create(clientScriptModule).Clone();
			scriptModule.Uid = destination.ClientScriptModule?.Uid ?? Guid.NewGuid();
			scriptModule.Id = destination.ClientScriptModule?.Id ?? 0;
			if (destination.Metadata is IMetadata metadata)
			{
				scriptModule.ObjectUid = metadata.Uid;
			}
			ScriptModule scriptModule2 = source.Header.Published?.ClientScriptModule;
			if (scriptModule2 != null)
			{
				scriptModule.AssemblyName = scriptModule2.AssemblyName;
				scriptModule.AssemblyRaw = scriptModule2.AssemblyRaw;
				scriptModule.DebugRaw = scriptModule2.DebugRaw;
				scriptModule.Dependencies = scriptModule2.Dependencies;
			}
			destination.ClientScriptModule = scriptModule;
		}
		else
		{
			destination.ClientScriptModule = null;
		}
	}
}
