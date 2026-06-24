using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Exceptions;
using Orchard.FileSystems.VirtualPath;
using Orchard.Localization;
using Orchard.Logging;
using Orchard.Validation;

namespace Orchard.FileSystems.AppData;

public class AppDataFolder : IAppDataFolder, IVolatileProvider, ISingletonDependency, IDependency
{
	private readonly IAppDataFolderRoot _root;

	private readonly IVirtualPathMonitor _virtualPathMonitor;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public string RootFolder => _root.RootFolder;

	public string AppDataPath => _root.RootPath;

	public AppDataFolder(IAppDataFolderRoot root, IVirtualPathMonitor virtualPathMonitor)
	{
		_root = root;
		_virtualPathMonitor = virtualPathMonitor;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	private void MakeDestinationFileNameAvailable(string destinationFileName)
	{
		bool flag = Directory.Exists(destinationFileName);
		try
		{
			if (flag)
			{
				Directory.Delete(destinationFileName);
			}
			else
			{
				File.Delete(destinationFileName);
			}
		}
		catch
		{
		}
		if (flag && Directory.Exists(destinationFileName))
		{
			Logger.Warning("Could not delete recipe execution folder {0} under \"App_Data\" folder", destinationFileName);
		}
		else
		{
			if (!File.Exists(destinationFileName))
			{
				return;
			}
			for (int i = 0; i < 100; i++)
			{
				string extension = ((i == 0) ? "deleted" : string.Format("{0}{1}", "deleted", i));
				string text = Path.ChangeExtension(destinationFileName, extension);
				try
				{
					File.Delete(text);
					File.Move(destinationFileName, text);
					return;
				}
				catch
				{
				}
			}
			try
			{
				File.Delete(destinationFileName);
			}
			catch (Exception ex)
			{
				if (ex.IsFatal())
				{
					throw;
				}
				throw new OrchardCoreException(T("Unable to make room for file \"{0}\" in \"App_Data\" folder", destinationFileName), ex);
			}
		}
	}

	private string CombineToPhysicalPath(params string[] paths)
	{
		return PathValidation.ValidatePath(RootFolder, Path.Combine(RootFolder, Path.Combine(paths)).Replace('/', Path.DirectorySeparatorChar));
	}

	public string Combine(params string[] paths)
	{
		return Path.Combine(paths).Replace(Path.DirectorySeparatorChar, '/');
	}

	public IVolatileToken WhenPathChanges(string path)
	{
		string virtualPath = GetVirtualPath(path);
		return _virtualPathMonitor.WhenPathChanges(virtualPath);
	}

	public string GetVirtualPath(string path)
	{
		return Combine(AppDataPath, path);
	}

	public void CreateFile(string path, string content)
	{
		using Stream stream = CreateFile(path);
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(content);
	}

	public Stream CreateFile(string path)
	{
		string path2 = CombineToPhysicalPath(path);
		string directoryName = Path.GetDirectoryName(path2);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		return File.Create(path2);
	}

	public string ReadFile(string path)
	{
		string path2 = CombineToPhysicalPath(path);
		if (!File.Exists(path2))
		{
			return null;
		}
		return File.ReadAllText(path2);
	}

	public Stream OpenFile(string path)
	{
		return File.OpenRead(CombineToPhysicalPath(path));
	}

	public void StoreFile(string sourceFileName, string destinationPath)
	{
		Logger.Information("Storing file \"{0}\" as \"{1}\" in \"App_Data\" folder", sourceFileName, destinationPath);
		string text = CombineToPhysicalPath(destinationPath);
		MakeDestinationFileNameAvailable(text);
		File.Copy(sourceFileName, text, overwrite: true);
	}

	public void DeleteFile(string path)
	{
		Logger.Information("Deleting file \"{0}\" from \"App_Data\" folder", path);
		MakeDestinationFileNameAvailable(CombineToPhysicalPath(path));
	}

	public DateTime GetFileLastWriteTimeUtc(string path)
	{
		return File.GetLastWriteTimeUtc(CombineToPhysicalPath(path));
	}

	public bool FileExists(string path)
	{
		return File.Exists(CombineToPhysicalPath(path));
	}

	public bool DirectoryExists(string path)
	{
		return Directory.Exists(CombineToPhysicalPath(path));
	}

	public IEnumerable<string> ListFiles(string path)
	{
		string path2 = CombineToPhysicalPath(path);
		if (!Directory.Exists(path2))
		{
			return Enumerable.Empty<string>();
		}
		return Directory.GetFiles(path2).Select(delegate(string file)
		{
			string fileName = Path.GetFileName(file);
			return Combine(path, fileName);
		});
	}

	public IEnumerable<string> ListDirectories(string path)
	{
		string path2 = CombineToPhysicalPath(path);
		if (!Directory.Exists(path2))
		{
			return Enumerable.Empty<string>();
		}
		return Directory.GetDirectories(path2).Select(delegate(string file)
		{
			string fileName = Path.GetFileName(file);
			return Combine(path, fileName);
		});
	}

	public void CreateDirectory(string path)
	{
		Directory.CreateDirectory(CombineToPhysicalPath(path));
	}

	public string MapPath(string path)
	{
		return CombineToPhysicalPath(path);
	}
}
