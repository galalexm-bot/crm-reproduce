using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.Components;

[Component(Type = ComponentType.Server)]
internal sealed class FunctionMetadataSourcesProvider : IMetadataSourcesProvider
{
	public IEnumerable<(string, string)> GetClientSources(MetadataSourcesProviderArgs args)
	{
		return Enumerable.Empty<(string, string)>();
	}

	public IEnumerable<(string, string)> GetViewSources(MetadataSourcesProviderArgs args)
	{
		return Enumerable.Empty<(string, string)>();
	}

	public IEnumerable<string> GetServerSources(MetadataSourcesProviderArgs args)
	{
		if (!(args?.Metadata is FunctionMetadata))
		{
			return Enumerable.Empty<string>();
		}
		return new string[1] { args.ScriptModule.SourceCode };
	}
}
