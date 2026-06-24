using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.IntegrationModules.CodeGeneration;

internal sealed class IntegrationModuleActivityGenerator : EntityDynamicGenerator
{
	protected new IntegrationModuleActivityMetadata metadata;

	protected override ISyntaxNode GetBaseClass()
	{
		if (metadata.BaseClassUid == Guid.Empty)
		{
			metadata.BaseClassUid = InterfaceActivator.UID(typeof(IIntegrationModuleActivity), loadImplementation: false);
		}
		return base.GetBaseClass();
	}

	protected override void InitInternal(IMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.CheckArgument(metadata is IntegrationModuleActivityMetadata, "metadata is IntegrationModuleActivityMetadata");
		base.InitInternal(metadata);
		this.metadata = (IntegrationModuleActivityMetadata)metadata;
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return base.GetNamespaces().Concat("EleWise.ELMA.IntegrationModules.Models".NamespaceImportDeclaration());
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		Contract.ArgumentNotNull(type, "type");
		Contract.NotNull(metadata, "metadata");
		base.WriteTypeAttributes(type);
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		list.Add(typeof(IntegrationModuleScriptSettingsAttribute).CreateAttribute(metadata.OnComplete, metadata.OnCompleteScript, metadata.OnEnter, metadata.OnEnterScript));
		type.AddAttributes(list);
	}
}
