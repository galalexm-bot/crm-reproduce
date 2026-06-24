using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Exceptions;
using Orchard.Logging;

namespace Orchard.FileSystems.VirtualPath;

public class DefaultVirtualPathProvider : IVirtualPathProvider, IVolatileProvider, ISingletonDependency, IDependency
{
	public ILogger Logger { get; set; }

	public DefaultVirtualPathProvider()
	{
		Logger = NullLogger.Instance;
	}

	public virtual string GetDirectoryName(string virtualPath)
	{
		return Path.GetDirectoryName(virtualPath).Replace(Path.DirectorySeparatorChar, '/');
	}

	public virtual IEnumerable<string> ListFiles(string path)
	{
		return from f in HostingEnvironment.VirtualPathProvider.GetDirectory(path).Files.OfType<VirtualFile>()
			select VirtualPathUtility.ToAppRelative(f.VirtualPath);
	}

	public virtual IEnumerable<string> ListDirectories(string path)
	{
		return from d in HostingEnvironment.VirtualPathProvider.GetDirectory(path).Directories.OfType<VirtualDirectory>()
			select VirtualPathUtility.ToAppRelative(d.VirtualPath);
	}

	public virtual string Combine(params string[] paths)
	{
		return Path.Combine(paths).Replace(Path.DirectorySeparatorChar, '/');
	}

	public virtual string ToAppRelative(string virtualPath)
	{
		if (IsMalformedVirtualPath(virtualPath))
		{
			return null;
		}
		try
		{
			string text = VirtualPathUtility.ToAppRelative(virtualPath);
			if (!text.StartsWith("~/"))
			{
				Logger.Information("Path '{0}' cannot be made app relative: Path returned ('{1}') is not app relative.", virtualPath, text);
				return null;
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Information(ex, "Path '{0}' cannot be made app relative", virtualPath);
			return null;
		}
	}

	public bool IsMalformedVirtualPath(string virtualPath)
	{
		if (string.IsNullOrEmpty(virtualPath))
		{
			return true;
		}
		if (virtualPath.IndexOf("..") >= 0)
		{
			virtualPath = virtualPath.Replace(Path.DirectorySeparatorChar, '/');
			string text = (virtualPath.StartsWith("~/") ? "~/" : (virtualPath.StartsWith("/") ? "/" : ""));
			if (!string.IsNullOrEmpty(text))
			{
				string[] array = virtualPath.Substring(text.Length).Split('/');
				int num = 0;
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == "..")
					{
						if (num == 0)
						{
							Logger.Information("Path '{0}' cannot be made app relative: Too many '..'", virtualPath);
							return true;
						}
						num--;
					}
					else
					{
						num++;
					}
				}
			}
		}
		return false;
	}

	public virtual Stream OpenFile(string virtualPath)
	{
		return HostingEnvironment.VirtualPathProvider.GetFile(virtualPath).Open();
	}

	public virtual StreamWriter CreateText(string virtualPath)
	{
		return File.CreateText(MapPath(virtualPath));
	}

	public virtual Stream CreateFile(string virtualPath)
	{
		return File.Create(MapPath(virtualPath));
	}

	public virtual DateTime GetFileLastWriteTimeUtc(string virtualPath)
	{
		return File.GetLastWriteTimeUtc(MapPath(virtualPath));
	}

	public string GetFileHash(string virtualPath)
	{
		return GetFileHash(virtualPath, new string[1] { virtualPath });
	}

	public string GetFileHash(string virtualPath, IEnumerable<string> dependencies)
	{
		return HostingEnvironment.VirtualPathProvider.GetFileHash(virtualPath, dependencies);
	}

	public virtual void DeleteFile(string virtualPath)
	{
		File.Delete(MapPath(virtualPath));
	}

	public virtual string MapPath(string virtualPath)
	{
		return HostingEnvironment.MapPath(virtualPath);
	}

	public virtual bool FileExists(string virtualPath)
	{
		return HostingEnvironment.VirtualPathProvider.FileExists(virtualPath);
	}

	public virtual bool TryFileExists(string virtualPath)
	{
		if (IsMalformedVirtualPath(virtualPath))
		{
			return false;
		}
		try
		{
			return FileExists(virtualPath);
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Information(ex, "File '{0}' can not be checked for existence. Assuming doesn't exist.", virtualPath);
			return false;
		}
	}

	public virtual bool DirectoryExists(string virtualPath)
	{
		return HostingEnvironment.VirtualPathProvider.DirectoryExists(virtualPath);
	}

	public virtual void CreateDirectory(string virtualPath)
	{
		Directory.CreateDirectory(MapPath(virtualPath));
	}

	public virtual void DeleteDirectory(string virtualPath)
	{
		Directory.Delete(MapPath(virtualPath));
	}
}
