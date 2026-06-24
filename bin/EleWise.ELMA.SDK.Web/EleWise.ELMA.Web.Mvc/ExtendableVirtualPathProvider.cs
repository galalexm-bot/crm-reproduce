using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc;

[Service(Type = ComponentType.Web, EnableInterceptors = false)]
public class ExtendableVirtualPathProvider : VirtualPathProvider, IMapVirtualPathProvider
{
	private const string cacheKey = "IVirtualPathProviders";

	private readonly IContextBoundVariableService contextBoundService;

	public ExtendableVirtualPathProvider(IContextBoundVariableService contextBoundService)
	{
		this.contextBoundService = contextBoundService;
	}

	public override bool FileExists(string virtualPath)
	{
		foreach (IVirtualPathProvider provider in GetProviders())
		{
			if (provider.FileExists(virtualPath))
			{
				return true;
			}
		}
		return base.FileExists(virtualPath);
	}

	public override VirtualFile GetFile(string virtualPath)
	{
		foreach (IVirtualPathProvider provider in GetProviders())
		{
			VirtualFile file = provider.GetFile(virtualPath);
			if (file != null)
			{
				return file;
			}
		}
		return base.GetFile(virtualPath);
	}

	public override string GetFileHash(string virtualPath, IEnumerable virtualPathDependencies)
	{
		foreach (IVirtualPathProvider provider in GetProviders())
		{
			string fileHash = provider.GetFileHash(virtualPath, virtualPathDependencies);
			if (fileHash != null)
			{
				return fileHash;
			}
		}
		return base.GetFileHash(virtualPath, virtualPathDependencies);
	}

	string IMapVirtualPathProvider.GetExistsFilePath(string virtualPath)
	{
		foreach (IMapVirtualPathProvider item in GetProviders().OfType<IMapVirtualPathProvider>())
		{
			string existsFilePath = item.GetExistsFilePath(virtualPath);
			if (existsFilePath != null)
			{
				return existsFilePath;
			}
		}
		return null;
	}

	private IEnumerable<IVirtualPathProvider> GetProviders()
	{
		return contextBoundService.GetOrAdd("IVirtualPathProviders", delegate
		{
			IEnumerable<IVirtualPathProvider> enumerable = Locator.GetService<IEnumerable<IVirtualPathProvider>>();
			if (enumerable == null)
			{
				enumerable = new List<IVirtualPathProvider>();
			}
			return enumerable;
		});
	}
}
