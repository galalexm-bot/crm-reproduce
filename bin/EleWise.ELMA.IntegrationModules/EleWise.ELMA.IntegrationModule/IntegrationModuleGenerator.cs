using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.CodeGeneration;

internal class IntegrationModuleGenerator : EntityDynamicGenerator
{
	protected new IntegrationModuleMetadata metadata;

	protected override ISyntaxNode GetBaseClass()
	{
		if (metadata.BaseClassUid == Guid.Empty)
		{
			metadata.BaseClassUid = IntegrationModuleMetadata.IntegrationModuleMetadataUid;
		}
		return base.GetBaseClass();
	}

	protected override void InitInternal(IMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.CheckArgument(metadata is IntegrationModuleMetadata, "metadata is IntegrationModuleMetadata");
		base.InitInternal(metadata);
		this.metadata = (IntegrationModuleMetadata)metadata;
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
		list.Add(typeof(PrefixAttribute).CreateAttribute(metadata.Prefix));
		list.Add(typeof(LoggingAttribute).CreateAttribute(metadata.Logging));
		list.Add(typeof(IntegrationModuleTypeAttribute).CreateAttribute(metadata.IntegrationModuleType));
		list.Add(typeof(AuthenticationSettingAttribute).CreateAttribute(metadata.AuthenticationTypeUid.ToString(), metadata.AuthenticationSubTypeUid?.ToString(), metadata.AuthenticationAttemptCount, metadata.AuthenticationAttemptInterval, metadata.BeforeAuthenticationScriptName, metadata.AfterAuthenticationScriptName));
		if (metadata.IntegrationModuleActivity != null)
		{
			foreach (Guid item in metadata.IntegrationModuleActivity)
			{
				list.Add(TypeOf<IntegrationModuleActivityAttribute>.Raw.CreateAttribute(item.ToString()));
			}
		}
		if (metadata.ExternalEvents != null)
		{
			foreach (ExternalEvent externalEvent in metadata.ExternalEvents)
			{
				list.Add(TypeOf<ExternalEventAttribute>.Raw.CreateAttribute(externalEvent.Uid.ToString(), externalEvent.Name, externalEvent.ScriptName));
			}
		}
		type.AddAttributes(list);
	}
}
