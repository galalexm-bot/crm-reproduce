using System;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment;
using Orchard.FileSystems.AppData;
using Orchard.Logging;

namespace Orchard.FileSystems.Dependencies;

public class DefaultAssemblyProbingFolder : IAssemblyProbingFolder, IVolatileProvider, ISingletonDependency, IDependency
{
	private const string BasePath = "Dependencies";

	private readonly IAppDataFolder _appDataFolder;

	private readonly IAssemblyLoader _assemblyLoader;

	public ILogger Logger { get; set; }

	public DefaultAssemblyProbingFolder(IAppDataFolder appDataFolder, IAssemblyLoader assemblyLoader)
	{
		_appDataFolder = appDataFolder;
		_assemblyLoader = assemblyLoader;
		Logger = NullLogger.Instance;
	}

	public bool AssemblyExists(string moduleName)
	{
		string path = PrecompiledAssemblyPath(moduleName);
		return _appDataFolder.FileExists(path);
	}

	public DateTime GetAssemblyDateTimeUtc(string moduleName)
	{
		string path = PrecompiledAssemblyPath(moduleName);
		return _appDataFolder.GetFileLastWriteTimeUtc(path);
	}

	public string GetAssemblyVirtualPath(string moduleName)
	{
		string path = PrecompiledAssemblyPath(moduleName);
		if (!_appDataFolder.FileExists(path))
		{
			return null;
		}
		return _appDataFolder.GetVirtualPath(path);
	}

	public Assembly LoadAssembly(string moduleName)
	{
		string path = PrecompiledAssemblyPath(moduleName);
		if (!_appDataFolder.FileExists(path))
		{
			return null;
		}
		return _assemblyLoader.Load(moduleName);
	}

	public void DeleteAssembly(string moduleName)
	{
		string path = PrecompiledAssemblyPath(moduleName);
		if (_appDataFolder.FileExists(path))
		{
			Logger.Information("Deleting assembly for module \"{0}\" from probing directory", moduleName);
			_appDataFolder.DeleteFile(path);
		}
	}

	public void StoreAssembly(string moduleName, string fileName)
	{
		string destinationPath = PrecompiledAssemblyPath(moduleName);
		Logger.Information("Storing assembly file \"{0}\" for module \"{1}\"", fileName, moduleName);
		_appDataFolder.StoreFile(fileName, destinationPath);
	}

	private string PrecompiledAssemblyPath(string moduleName)
	{
		return _appDataFolder.Combine("Dependencies", moduleName + ".dll");
	}
}
