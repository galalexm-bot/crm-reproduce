using System.Collections.Generic;
using EleWise.ELMA.Model;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.Services;

public interface IComponentMetadataSourcesService
{
	string ServerControllerName(ComponentMetadata metadata);

	IEnumerable<IScriptSource> GetServerSources(MetadataSourcesProviderArgs args);

	string ClientControllerName(ComponentMetadata metadata);

	IEnumerable<IScriptSource> GetClientSources(MetadataSourcesProviderArgs args);

	string TestControllerName(ComponentMetadata metadata);

	IEnumerable<IScriptSource> GetTestSources(MetadataSourcesProviderArgs args);

	string ViewControllerName(ComponentMetadata metadata);

	IEnumerable<IScriptSource> GetViewSources(MetadataSourcesProviderArgs args);
}
