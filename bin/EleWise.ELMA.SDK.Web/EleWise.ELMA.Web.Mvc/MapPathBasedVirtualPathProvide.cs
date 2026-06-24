using System.IO;
using System.Web.Hosting;
using EleWise.ELMA.Services;
using EleWise.ELMA.WebCompiler;

namespace EleWise.ELMA.Web.Mvc;

public class MapPathBasedVirtualPathProvider : VirtualPathProvider, IMapVirtualPathProvider
{
	private readonly string root;

	private readonly ApplicationDirectoryFileWatcher watcher;

	public MapPathBasedVirtualPathProvider()
	{
		root = HostingEnvironment.MapPath("~/");
		watcher = Locator.GetServiceNotNull<ApplicationDirectoryFileWatcher>();
	}

	public override VirtualFile GetFile(string virtualPath)
	{
		if (virtualPath == null || virtualPath == "")
		{
			return null;
		}
		string existsFilePath = GetExistsFilePath(virtualPath);
		if (existsFilePath == null)
		{
			return base.GetFile(virtualPath);
		}
		return new MapPathVirtualFile(virtualPath, existsFilePath);
	}

	public override bool FileExists(string virtualPath)
	{
		return GetExistsFilePath(virtualPath) != null;
	}

	public string GetExistsFilePath(string virtualPath)
	{
		string text = MapPath(virtualPath);
		if (string.IsNullOrWhiteSpace(text) || !watcher.FileExists(root, text))
		{
			return null;
		}
		return text;
	}

	private string MapPath(string virtualPath)
	{
		switch (virtualPath)
		{
		case null:
		case "":
			return null;
		case "/":
		case "~":
		case "~/":
			return root;
		default:
		{
			int length = virtualPath.Length;
			if (length >= 1 && (virtualPath[0] == '/' || (virtualPath[0] == '~' && length >= 2 && virtualPath[1] == '/')))
			{
				return Path.Combine(root, virtualPath.Substring((virtualPath[0] != '~') ? 1 : 2).Replace('/', '\\'));
			}
			return HostingEnvironment.MapPath(virtualPath);
		}
		}
	}
}
