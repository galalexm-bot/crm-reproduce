using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class UIEntityMetadataUpdateHandler : BaseMetadataUpdateHandler
{
	private readonly ClientScriptModuleType clientScriptModuleType;

	public UIEntityMetadataUpdateHandler(ClientScriptModuleType clientScriptModuleType)
	{
		this.clientScriptModuleType = clientScriptModuleType;
	}

	public override bool Check(IMetadata metadata)
	{
		if (metadata is EntityMetadata entityMetadata)
		{
			return entityMetadata.TypeUid == EntityMetadata.UID;
		}
		return false;
	}

	public override void UpdateMetadata(IMetadataUpdateResult updateResult)
	{
		if (updateResult.Metadata is EntityMetadata entityMetadata && entityMetadata.ViewModelMetadata == null)
		{
			entityMetadata.ViewModelMetadata = entityMetadata.CreateViewModelMetadata();
		}
	}

	public override void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
	{
	}

	public override void UpdateScriptModules(IMetadataUpdateResult updateResult)
	{
		if ((updateResult.Metadata as EntityMetadata)?.ViewModelMetadata == null)
		{
			return;
		}
		foreach (ScriptModule item in updateResult.ScriptModules.Where((ScriptModule sm) => sm != null))
		{
			if (item.ModuleTypeUid == ClientScriptModuleType.TypeUid && string.IsNullOrEmpty(item.SourceCode))
			{
				item.SourceCode = CreateClientSourceCode(updateResult.Metadata);
			}
		}
	}

	private string CreateClientSourceCode(IMetadata metadata)
	{
		return clientScriptModuleType.GenerateSourceCode(new ClientScriptGenerationParams
		{
			Metadata = metadata
		});
	}
}
