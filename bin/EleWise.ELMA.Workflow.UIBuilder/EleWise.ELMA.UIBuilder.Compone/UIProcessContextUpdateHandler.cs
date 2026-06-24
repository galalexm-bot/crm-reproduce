using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.UIBuilder.Model;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class UIProcessContextUpdateHandler : BaseMetadataUpdateHandler
{
	private readonly ClientScriptModuleType clientScriptModuleType;

	public UIProcessContextUpdateHandler(ClientScriptModuleType clientScriptModuleType)
	{
		this.clientScriptModuleType = clientScriptModuleType;
	}

	public override bool Check(IMetadata metadata)
	{
		return metadata is ProcessContext;
	}

	public override void UpdateMetadata(IMetadataUpdateResult updateResult)
	{
		if (updateResult.Metadata is ProcessContext && updateResult.Metadata is EntityMetadata entityMetadata && entityMetadata.ViewModelMetadata == null)
		{
			entityMetadata.ViewModelMetadata = entityMetadata.CreateViewModelMetadata();
		}
	}

	public override void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
	{
	}

	public override void UpdateScriptModules(IMetadataUpdateResult updateResult)
	{
		if (!(updateResult.Metadata is ProcessContext processContext) || processContext.ViewModelMetadata == null)
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
