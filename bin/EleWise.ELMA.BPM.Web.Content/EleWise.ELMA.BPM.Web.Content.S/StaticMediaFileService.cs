using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[Service(Scope = ServiceScope.Shell)]
public class StaticMediaFileService : IStaticMediaFileService
{
	private readonly StaticMediaFileProvider provider;

	private readonly string rootPhisicalDirectory;

	private readonly string rootPath;

	public StaticMediaFileService(StaticMediaFileProvider provider)
	{
		this.provider = provider;
		rootPhisicalDirectory = HostingEnvironment.MapPath("~").Replace('/', '\\');
		rootPath = provider.RootPath.Replace('\\', '/');
		if (!rootPath.StartsWith("~"))
		{
			if (!rootPath.StartsWith("/"))
			{
				rootPath = "/" + rootPath;
			}
			rootPath = "~" + rootPath;
		}
	}

	public IEnumerable<FileEntry> GetFiles(string webPath)
	{
		return provider.GetFiles(webPath);
	}

	public IEnumerable<DirectoryEntry> GetDirectories(string webPath)
	{
		return provider.GetDirectories(webPath);
	}

	public string GetWebPath(string path)
	{
		string text = Path.Combine(rootPath, path ?? "").Replace('\\', '/');
		if (!text.StartsWith("~"))
		{
			if (!text.StartsWith("/"))
			{
				text = "/" + text;
			}
			text = "~" + text;
		}
		return text;
	}

	public string GetPhysicalPath(string webPath)
	{
		string text = webPath.Replace('\\', '/');
		if (text.StartsWith("#"))
		{
			text = Path.Combine(rootPath, text.Substring(1));
		}
		if (!text.StartsWith(rootPath))
		{
			return GetPhisicalPath(webPath);
		}
		return provider.GetFilePhysicalPath(webPath);
	}

	private string GetPhisicalPath(string path)
	{
		path = path.Replace("..", "").Replace('/', '\\');
		if (path.StartsWith("~"))
		{
			path = path.Substring(1);
		}
		if (path.StartsWith("\\"))
		{
			path = path.Substring(1);
		}
		return Path.Combine(rootPhisicalDirectory, path);
	}
}
