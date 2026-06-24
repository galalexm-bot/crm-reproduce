namespace Orchard.UI.Resources;

public interface IResourceManifestProvider : ISingletonDependency, IDependency
{
	void BuildManifests(ResourceManifestBuilder builder);
}
