using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UIBuilder.Components;

[Component(Type = ComponentType.Server)]
internal sealed class ComponentMetadataSourcesProvider : IMetadataSourcesProvider
{
	private readonly IComponentMetadataSourcesService componentMetadataSourcesService;

	public ComponentMetadataSourcesProvider(IComponentMetadataSourcesService componentMetadataSourcesService)
	{
		this.componentMetadataSourcesService = componentMetadataSourcesService;
	}

	public IEnumerable<(string, string)> GetClientSources(MetadataSourcesProviderArgs args)
	{
		if (!(args?.Metadata is ComponentMetadata componentMetadata))
		{
			return Enumerable.Empty<(string, string)>();
		}
		using (MetadataServiceContext.Extend(componentMetadata.GetMetadataToRegister()))
		{
			return from source in componentMetadataSourcesService.GetClientSources(args)
				select (source.Name, source.Content);
		}
	}

	public IEnumerable<(string, string)> GetViewSources(MetadataSourcesProviderArgs args)
	{
		if (!(args?.Metadata is ComponentMetadata componentMetadata) || !componentMetadata.ViewScriptUid.HasValue)
		{
			return Enumerable.Empty<(string, string)>();
		}
		return from source in componentMetadataSourcesService.GetViewSources(args)
			select (source.Name, source.Content);
	}

	public IEnumerable<string> GetServerSources(MetadataSourcesProviderArgs args)
	{
		if (!(args?.Metadata is ComponentMetadata componentMetadata))
		{
			return Enumerable.Empty<string>();
		}
		using (MetadataServiceContext.Extend(componentMetadata.GetMetadataToRegister()))
		{
			return from source in componentMetadataSourcesService.GetServerSources(args)
				select source.Content;
		}
	}
}
