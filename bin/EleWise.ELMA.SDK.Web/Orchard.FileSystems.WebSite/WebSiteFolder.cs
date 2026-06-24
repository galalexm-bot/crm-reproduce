using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.FileSystems.VirtualPath;

namespace Orchard.FileSystems.WebSite;

public class WebSiteFolder : IWebSiteFolder, IVolatileProvider, ISingletonDependency, IDependency
{
	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IVirtualPathMonitor _virtualPathMonitor;

	public ILogger Logger { get; set; }

	public WebSiteFolder(IVirtualPathMonitor virtualPathMonitor, IVirtualPathProvider virtualPathProvider)
	{
		_virtualPathMonitor = virtualPathMonitor;
		_virtualPathProvider = virtualPathProvider;
		Logger = NullLogger.Instance;
	}

	public IEnumerable<string> ListDirectories(string virtualPath)
	{
		if (!_virtualPathProvider.DirectoryExists(virtualPath))
		{
			return Enumerable.Empty<string>();
		}
		return _virtualPathProvider.ListDirectories(virtualPath);
	}

	private IEnumerable<string> ListFiles(IEnumerable<string> directories)
	{
		return directories.SelectMany((string d) => ListFiles(d, recursive: true));
	}

	public IEnumerable<string> ListFiles(string virtualPath, bool recursive)
	{
		if (!recursive)
		{
			return _virtualPathProvider.ListFiles(virtualPath);
		}
		return _virtualPathProvider.ListFiles(virtualPath).Concat(ListFiles(ListDirectories(virtualPath)));
	}

	public bool FileExists(string virtualPath)
	{
		return _virtualPathProvider.FileExists(virtualPath);
	}

	public string ReadFile(string virtualPath)
	{
		return ReadFile(virtualPath, actualContent: false);
	}

	public string ReadFile(string virtualPath, bool actualContent)
	{
		if (!_virtualPathProvider.FileExists(virtualPath))
		{
			return null;
		}
		if (actualContent)
		{
			using (FileStream stream = File.Open(_virtualPathProvider.MapPath(virtualPath), FileMode.Open, FileAccess.Read))
			{
				using StreamReader streamReader = new StreamReader(stream);
				return streamReader.ReadToEnd();
			}
		}
		using Stream stream2 = _virtualPathProvider.OpenFile(Normalize(virtualPath));
		using StreamReader streamReader2 = new StreamReader(stream2);
		return streamReader2.ReadToEnd();
	}

	public void CopyFileTo(string virtualPath, Stream destination)
	{
		CopyFileTo(virtualPath, destination, actualContent: false);
	}

	public void CopyFileTo(string virtualPath, Stream destination, bool actualContent)
	{
		if (actualContent)
		{
			using (FileStream fileStream = File.Open(_virtualPathProvider.MapPath(virtualPath), FileMode.Open, FileAccess.Read))
			{
				fileStream.CopyTo(destination);
				return;
			}
		}
		using Stream stream = _virtualPathProvider.OpenFile(Normalize(virtualPath));
		stream.CopyTo(destination);
	}

	public IVolatileToken WhenPathChanges(string virtualPath)
	{
		return _virtualPathMonitor.WhenPathChanges(virtualPath);
	}

	private static string Normalize(string virtualPath)
	{
		return HostingEnvironment.VirtualPathProvider.GetFile(virtualPath).VirtualPath;
	}
}
