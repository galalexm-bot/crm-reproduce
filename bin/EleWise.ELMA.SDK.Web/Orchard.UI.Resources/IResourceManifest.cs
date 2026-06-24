using System.Collections.Generic;

namespace Orchard.UI.Resources;

public interface IResourceManifest
{
	string Name { get; }

	string BasePath { get; }

	ResourceDefinition DefineResource(string resourceType, string resourceName);

	IDictionary<string, ResourceDefinition> GetResources(string resourceType);
}
