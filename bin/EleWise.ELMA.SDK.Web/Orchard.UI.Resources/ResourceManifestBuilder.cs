using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;

namespace Orchard.UI.Resources;

public class ResourceManifestBuilder
{
	public Feature Feature { get; set; }

	internal HashSet<IResourceManifest> ResourceManifests { get; private set; }

	public ResourceManifestBuilder()
	{
		ResourceManifests = new HashSet<IResourceManifest>();
	}

	public ResourceManifest Add()
	{
		ResourceManifest resourceManifest = new ResourceManifest
		{
			Feature = Feature
		};
		ResourceManifests.Add(resourceManifest);
		return resourceManifest;
	}

	public void Add(IResourceManifest manifest)
	{
		ResourceManifests.Add(manifest);
	}
}
