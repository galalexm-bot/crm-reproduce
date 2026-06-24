using System;
using System.Collections.Generic;
using System.Web;
using Orchard.Environment.Extensions.Models;

namespace Orchard.UI.Resources;

public class ResourceManifest : IResourceManifest
{
	private string _basePath;

	private readonly IDictionary<string, IDictionary<string, ResourceDefinition>> _resources = new Dictionary<string, IDictionary<string, ResourceDefinition>>(StringComparer.OrdinalIgnoreCase);

	public virtual Feature Feature { get; set; }

	public virtual string Name => GetType().Name;

	public string BasePath
	{
		get
		{
			if (_basePath == null && Feature != null)
			{
				_basePath = VirtualPathUtility.AppendTrailingSlash(Feature.Descriptor.Extension.Location + "/" + Feature.Descriptor.Extension.Id);
			}
			return _basePath;
		}
	}

	public virtual ResourceDefinition DefineResource(string resourceType, string resourceName)
	{
		ResourceDefinition resourceDefinition = new ResourceDefinition(this, resourceType, resourceName);
		GetResources(resourceType)[resourceName] = resourceDefinition;
		return resourceDefinition;
	}

	public ResourceDefinition DefineScript(string name)
	{
		return DefineResource("script", name);
	}

	public ResourceDefinition DefineStyle(string name)
	{
		return DefineResource("stylesheet", name);
	}

	public virtual IDictionary<string, ResourceDefinition> GetResources(string resourceType)
	{
		if (!_resources.TryGetValue(resourceType, out var value))
		{
			value = (_resources[resourceType] = new Dictionary<string, ResourceDefinition>(StringComparer.OrdinalIgnoreCase));
		}
		return value;
	}
}
