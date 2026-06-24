using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class ComponentDependenciesExtension : IDependenciesExtension
{
	private readonly IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager;

	public ComponentDependenciesExtension(IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.componentMetadataItemManager = componentMetadataItemManager;
	}

	public IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid)
	{
		List<IDependencyContainer> list = new List<IDependencyContainer>();
		ComponentMetadataItemHeader componentMetadataItemHeader = componentMetadataItemManager.LoadOrNull(uid);
		ComponentMetadata componentMetadata;
		if (componentMetadataItemHeader?.Draft != null)
		{
			componentMetadata = componentMetadataItemHeader.Draft.Metadata as ComponentMetadata;
		}
		else
		{
			if (componentMetadataItemHeader?.Published == null)
			{
				return list;
			}
			componentMetadata = componentMetadataItemHeader.Published.Metadata as ComponentMetadata;
		}
		if (componentMetadata != null)
		{
			ComponentDependencyContainer componentDependencyContainer = new ComponentDependencyContainer();
			componentDependencyContainer.ComponentDependencies.AddRange(componentMetadata.ComponentDependencies);
			componentDependencyContainer.EntityDependencies.AddRange(componentMetadata.EntityDependencies);
			componentDependencyContainer.EnumDependencies.AddRange(componentMetadata.EnumDependencies);
			componentDependencyContainer.DataClassDependencies.AddRange(componentMetadata.DataClassDependencies);
			componentDependencyContainer.FunctionDependencies.AddRange(componentMetadata.FunctionDependencies);
			list.Add(componentDependencyContainer);
		}
		return list;
	}
}
