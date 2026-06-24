using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IMetadataSourcesProvider
{
	IEnumerable<string> GetServerSources(MetadataSourcesProviderArgs args);

	IEnumerable<(string fileName, string sourceCode)> GetClientSources(MetadataSourcesProviderArgs args);

	IEnumerable<(string fileName, string sourceCode)> GetViewSources(MetadataSourcesProviderArgs args);
}
