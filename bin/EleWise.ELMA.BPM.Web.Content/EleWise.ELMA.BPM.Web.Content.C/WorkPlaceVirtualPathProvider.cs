using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.WebCompiler;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(Order = int.MinValue)]
public class WorkPlaceVirtualPathProvider : IVirtualPathProvider, IMapVirtualPathProvider
{
	private struct ModuleWorkPlaceTypeData
	{
		public string ModulePath;

		public string WorkPlaceTypeFolder;
	}

	private class ModuleWorkPlaceTypeFileData
	{
		public string ModulePath;

		public int ModulePathIndex;

		public string WorkPlaceTypeFolder;

		public string WatchPath;

		public string FilePath;
	}

	private const string ConfigFile = "ConfigurationFile";

	public const string ConfigWorkPlaces = "WorkPlaces";

	public const string ConfigWorkPlaceTypes = "WorkPlaceTypes";

	private readonly DirectoryFileWatcher configurationFileWatcher;

	private readonly ApplicationDirectoryFileWatcher applicationFileWatcher;

	private readonly string root;

	internal readonly string workPlacesFolder;

	internal readonly string workPlaceTypesFolder;

	private readonly Dictionary<string, ModuleWorkPlaceTypeData> moduleWorkPlaceTypeData;

	private readonly List<string> modules;

	private readonly List<string> workPlaceTypeFolders;

	private readonly ConcurrentDictionary<string, ModuleWorkPlaceTypeFileData> applicationWorkPlaceTypesFiles = new ConcurrentDictionary<string, ModuleWorkPlaceTypeFileData>(StringComparer.InvariantCultureIgnoreCase);

	private readonly ConcurrentDictionary<string, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>> applicationWorkPlaceTypesAllFiles = new ConcurrentDictionary<string, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>>(StringComparer.InvariantCultureIgnoreCase);

	private static string configPath;

	private const string ConfigWorkPlacesSlash = "/WorkPlaces/";

	private const string ConfigWorkPlaceTypesSlash = "/WorkPlaceTypes/";

	private static string ConfigPath
	{
		get
		{
			if (configPath == null)
			{
				string connectionString = ConfigurationManager.ConnectionStrings["ConfigurationFile"].ConnectionString;
				configPath = Path.GetDirectoryName(Path.IsPathRooted(connectionString) ? connectionString : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, connectionString));
			}
			return configPath;
		}
	}

	private static string ConfigWebAppPath => Path.Combine(ConfigPath, "WebApplication");

	public string Prefix => "WorkPlaceDirectory";

	public WorkPlaceVirtualPathProvider(EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher configurationFileWatcher, ApplicationDirectoryFileWatcher applicationFileWatcher)
	{
		this.configurationFileWatcher = configurationFileWatcher;
		this.applicationFileWatcher = applicationFileWatcher;
		workPlacesFolder = Path.Combine(ConfigWebAppPath, "WorkPlaces");
		if (!workPlacesFolder.EndsWith("\\"))
		{
			workPlacesFolder += "\\";
		}
		this.configurationFileWatcher.AddWatchPaths(workPlacesFolder);
		workPlaceTypesFolder = Path.Combine(ConfigWebAppPath, "WorkPlaceTypes");
		if (!workPlaceTypesFolder.EndsWith("\\"))
		{
			workPlaceTypesFolder += "\\";
		}
		this.configurationFileWatcher.AddWatchPaths(workPlaceTypesFolder);
		root = HostingEnvironment.MapPath("~/");
		workPlaceTypeFolders = (from t in ComponentManager.Current.GetExtensionPoints<IWorkPlaceType>()
			where !string.IsNullOrWhiteSpace(t.Folder)
			select t.Folder).ToList();
		modules = new List<string>();
		moduleWorkPlaceTypeData = new Dictionary<string, ModuleWorkPlaceTypeData>();
		applicationWorkPlaceTypesAllFiles = new ConcurrentDictionary<string, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>>(StringComparer.InvariantCultureIgnoreCase);
		applicationWorkPlaceTypesFiles = new ConcurrentDictionary<string, ModuleWorkPlaceTypeFileData>();
	}

	internal void Activated()
	{
		modules.AddRange((from fd in Locator.GetServiceNotNull<IExtensionManager>().AvailableFeatures()
			where DefaultExtensionTypes.IsModule(fd.Extension.ExtensionType)
			select Path.Combine(root, fd.Extension.Location.TrimStart('~', '/').Replace('/', '\\'), fd.Extension.Id)).Distinct(StringComparer.OrdinalIgnoreCase));
		moduleWorkPlaceTypeData.AddRange(modules.SelectMany((string modulePath) => workPlaceTypeFolders.Select((string workPlaceTypeFolder) => new
		{
			path = Path.Combine(modulePath, "WorkPlaceTypes", workPlaceTypeFolder) + "\\",
			modulePath = modulePath,
			workPlaceTypeFolder = workPlaceTypeFolder
		})).ToDictionary(d => d.path, d =>
		{
			ModuleWorkPlaceTypeData result = default(ModuleWorkPlaceTypeData);
			result.ModulePath = d.modulePath;
			result.WorkPlaceTypeFolder = d.workPlaceTypeFolder;
			return result;
		}));
		applicationFileWatcher.AddWatchPaths(moduleWorkPlaceTypeData.Keys.ToArray());
		applicationWorkPlaceTypesAllFiles.AddRange((from data in moduleWorkPlaceTypeData.SelectMany((KeyValuePair<string, ModuleWorkPlaceTypeData> data) => from path in applicationFileWatcher.ExistsFiles(data.Key)
				select new
				{
					RelativePath = DirectoryHelper.GetRelativePath(path, data.Value.ModulePath),
					Data = new ModuleWorkPlaceTypeFileData
					{
						FilePath = path,
						ModulePath = data.Value.ModulePath,
						ModulePathIndex = modules.IndexOf(data.Value.ModulePath),
						WatchPath = data.Key,
						WorkPlaceTypeFolder = data.Value.WorkPlaceTypeFolder
					}
				})
			group data by data.RelativePath).ToDictionary(data => data.Key, data => data.ToConcurrentDictionary(d => d.Data.ModulePathIndex, d => d.Data)));
		applicationWorkPlaceTypesFiles.AddRange(applicationWorkPlaceTypesAllFiles.Where((KeyValuePair<string, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>> data) => data.Value.Any()).ToDictionary((KeyValuePair<string, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>> data) => data.Key, (KeyValuePair<string, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>> data) => data.Value.OrderBy((KeyValuePair<int, ModuleWorkPlaceTypeFileData> d) => d.Key).Last().Value));
		ApplicationDirectoryFileWatcher applicationDirectoryFileWatcher = applicationFileWatcher;
		applicationDirectoryFileWatcher.FileAdded = (EventHandler<FileWatcherEventArgs>)Delegate.Combine(applicationDirectoryFileWatcher.FileAdded, new EventHandler<FileWatcherEventArgs>(ApplicationFileAdded));
		ApplicationDirectoryFileWatcher applicationDirectoryFileWatcher2 = applicationFileWatcher;
		applicationDirectoryFileWatcher2.FileDeleted = (EventHandler<FileWatcherEventArgs>)Delegate.Combine(applicationDirectoryFileWatcher2.FileDeleted, new EventHandler<FileWatcherEventArgs>(ApplicationFileDeleted));
	}

	private void ApplicationFileAdded(object sender, FileWatcherEventArgs fileWatcherEventArgs)
	{
		if (moduleWorkPlaceTypeData.TryGetValue(fileWatcherEventArgs.WatchPath, out var value))
		{
			string relativePath = DirectoryHelper.GetRelativePath(fileWatcherEventArgs.Path, value.ModulePath);
			int modulePathIndex = modules.IndexOf(value.ModulePath);
			ModuleWorkPlaceTypeFileData newData = new ModuleWorkPlaceTypeFileData
			{
				ModulePath = value.ModulePath,
				ModulePathIndex = modulePathIndex,
				WorkPlaceTypeFolder = value.WorkPlaceTypeFolder,
				WatchPath = fileWatcherEventArgs.WatchPath,
				FilePath = fileWatcherEventArgs.Path
			};
			applicationWorkPlaceTypesAllFiles.AddOrUpdate(relativePath, (string s) => new ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>(new KeyValuePair<int, ModuleWorkPlaceTypeFileData>[1]
			{
				new KeyValuePair<int, ModuleWorkPlaceTypeFileData>(modulePathIndex, newData)
			}), delegate(string s, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData> data)
			{
				data.TryAdd(modulePathIndex, newData);
				return data;
			});
			ModuleWorkPlaceTypeFileData lastValue = (from d in applicationWorkPlaceTypesAllFiles[relativePath]
				orderby d.Key
				select d.Value).LastOrDefault();
			applicationWorkPlaceTypesFiles.AddOrUpdate(relativePath, lastValue, (string s, ModuleWorkPlaceTypeFileData data) => (data.ModulePathIndex >= lastValue.ModulePathIndex) ? data : lastValue);
		}
	}

	private void ApplicationFileDeleted(object sender, FileWatcherEventArgs fileWatcherEventArgs)
	{
		if (!moduleWorkPlaceTypeData.TryGetValue(fileWatcherEventArgs.WatchPath, out var value))
		{
			return;
		}
		string relativePath = DirectoryHelper.GetRelativePath(fileWatcherEventArgs.Path, value.ModulePath);
		if (!applicationWorkPlaceTypesFiles.TryGetValue(relativePath, out var _))
		{
			return;
		}
		ModuleWorkPlaceTypeFileData oldData = null;
		int modulePathIndex = modules.IndexOf(value.ModulePath);
		applicationWorkPlaceTypesAllFiles.AddOrUpdate(relativePath, (string s) => new ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData>(), delegate(string s, ConcurrentDictionary<int, ModuleWorkPlaceTypeFileData> data)
		{
			data.TryRemove(modulePathIndex, out oldData);
			return data;
		});
		ModuleWorkPlaceTypeFileData lastValue = (from d in applicationWorkPlaceTypesAllFiles[relativePath]
			orderby d.Key
			select d.Value).LastOrDefault();
		if (lastValue != null)
		{
			applicationWorkPlaceTypesFiles.AddOrUpdate(relativePath, lastValue, (string s, ModuleWorkPlaceTypeFileData data) => (data.ModulePathIndex != modulePathIndex) ? data : lastValue);
		}
		else if (oldData != null)
		{
			((ICollection<KeyValuePair<string, ModuleWorkPlaceTypeFileData>>)applicationWorkPlaceTypesFiles).Remove(new KeyValuePair<string, ModuleWorkPlaceTypeFileData>(relativePath, oldData));
		}
	}

	public bool FileExists(string virtualPath)
	{
		return GetExistsFilePath(virtualPath) != null;
	}

	public VirtualFile GetFile(string virtualPath)
	{
		string existsFilePath = GetExistsFilePath(virtualPath);
		if (existsFilePath == null)
		{
			return null;
		}
		return new MapPathVirtualFile(virtualPath, existsFilePath);
	}

	public string GetFileHash(string virtualPath, IEnumerable virtualPathDependencies)
	{
		return null;
	}

	public string GetExistsFilePath(string virtualPath)
	{
		bool isWorkPlaceType;
		string relativePath;
		string text = MapPath(virtualPath, out isWorkPlaceType, out relativePath);
		if (text == null)
		{
			return null;
		}
		if (!isWorkPlaceType)
		{
			if (!configurationFileWatcher.FileExists(workPlacesFolder, text))
			{
				return null;
			}
			return text;
		}
		if (configurationFileWatcher.FileExists(workPlaceTypesFolder, text))
		{
			return text;
		}
		if (!applicationWorkPlaceTypesFiles.TryGetValue(relativePath, out var value))
		{
			return null;
		}
		return value.FilePath;
	}

	protected string MapPath(string virtualPath, out bool isWorkPlaceType, out string relativePath)
	{
		if (virtualPath == null)
		{
			throw new ArgumentNullException("virtualPath");
		}
		if (virtualPath.StartsWith("~"))
		{
			virtualPath = virtualPath.Substring(1);
		}
		if (virtualPath.StartsWith("/WorkPlaces/"))
		{
			isWorkPlaceType = false;
			relativePath = virtualPath.Substring(1).Replace("/", "\\");
			return Path.Combine(ConfigWebAppPath, relativePath);
		}
		if (virtualPath.StartsWith("/WorkPlaceTypes/"))
		{
			isWorkPlaceType = true;
			relativePath = virtualPath.Substring(1).Replace("/", "\\");
			return Path.Combine(ConfigWebAppPath, relativePath);
		}
		isWorkPlaceType = false;
		relativePath = null;
		return null;
	}
}
