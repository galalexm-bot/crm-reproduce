using System;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.WebPages;

namespace Orchard.UI.Resources;

public class ResourceRegister
{
	private readonly string _viewVirtualPath;

	protected IResourceManager ResourceManager { get; private set; }

	protected string ResourceType { get; private set; }

	public ResourceRegister(IViewDataContainer container, IResourceManager resourceManager, string resourceType)
	{
		if (container is TemplateControl templateControl)
		{
			_viewVirtualPath = templateControl.AppRelativeVirtualPath;
		}
		else
		{
			WebPageBase val = (WebPageBase)(object)((container is WebPageBase) ? container : null);
			if (val != null)
			{
				_viewVirtualPath = ((WebPageExecutingBase)val).get_VirtualPath();
			}
		}
		ResourceManager = resourceManager;
		ResourceType = resourceType;
	}

	public RequireSettings Include(string resourcePath)
	{
		if (resourcePath == null)
		{
			throw new ArgumentNullException("resourcePath");
		}
		return ResourceManager.Include(ResourceType, resourcePath, null, ResourceDefinition.GetBasePathFromViewPath(ResourceType, _viewVirtualPath));
	}

	public RequireSettings Include(string resourceDebugPath, string resourcePath)
	{
		if (resourcePath == null)
		{
			throw new ArgumentNullException("resourcePath");
		}
		return ResourceManager.Include(ResourceType, resourcePath, resourceDebugPath, ResourceDefinition.GetBasePathFromViewPath(ResourceType, _viewVirtualPath));
	}

	public virtual RequireSettings Require(string resourceName)
	{
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		RequireSettings requireSettings = ResourceManager.Require(ResourceType, resourceName);
		if (_viewVirtualPath != null)
		{
			requireSettings.WithBasePath(ResourceDefinition.GetBasePathFromViewPath(ResourceType, _viewVirtualPath));
		}
		return requireSettings;
	}
}
