using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Scripts.Manager;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class UIEntityMetadataUpdateDataHandler : BaseMetadataUpdateDataHandler
{
	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	public UIEntityMetadataUpdateDataHandler(MetadataItemHeaderManager metadataItemHeaderManager, ScriptModuleManager scriptModuleManager)
		: base(scriptModuleManager)
	{
		this.metadataItemHeaderManager = metadataItemHeaderManager;
	}

	public override bool Check(IMetadata metadata)
	{
		if (metadata is EntityMetadata entityMetadata)
		{
			return entityMetadata.TypeUid == EntityMetadata.UID;
		}
		return false;
	}

	public override IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
	{
		if (updateResult.Metadata is EntityMetadata entityMetadata)
		{
			IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(entityMetadata.Uid);
			if (metadataItemHeader != null && metadataItemHeader.Current.ClientScriptModule == null)
			{
				return new ScriptModule[1] { CreateClientScriptModule(entityMetadata) };
			}
		}
		return Enumerable.Empty<ScriptModule>();
	}

	private ScriptModule CreateClientScriptModule(EntityMetadata entityMetadata)
	{
		ScriptModule scriptModule = ScriptModuleManager.Create();
		scriptModule.Uid = Guid.NewGuid();
		scriptModule.ObjectUid = entityMetadata.Uid;
		scriptModule.Namespace = entityMetadata.Namespace;
		scriptModule.ClassName = entityMetadata.Name + "Scripts";
		scriptModule.AssemblyName = scriptModule.ClassName;
		scriptModule.ModuleName = scriptModule.ClassName;
		scriptModule.ModuleTypeUid = ClientScriptModuleType.TypeUid;
		return scriptModule;
	}
}
