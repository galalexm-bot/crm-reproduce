using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using EleWise.ELMA.Packaging.Components;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.ProjectSystem;
using NuGet;

namespace EleWise.ELMA.Packaging;

public class ComponentPackageInstaller
{
	private bool _initialized;

	private PackagingSettings _settings;

	private PackagingHelper _helper;

	private PackageDownloader _packageDownloader;

	private ILogger _logger;

	private ILogger _nuGetLogger;

	private IElmaComponent _component;

	private IPackageRepository _localRepository;

	private IPackageRepository _cfgRepository;

	private TransactionalPhysicalFileSystem _localRepositoryFileSystem;

	private DefaultPackagePathResolver _localRepositoryPathResolver;

	private IProjectSystem _projectSystem;

	private PackageReferenceRepository _repository;

	private SharedPackageRepository _sharedRepository;

	private ElmaProjectManager _projectManager;

	[Import]
	public PackagingSettings Settings
	{
		get
		{
			return _settings.GetPropertyNotNull("Settings");
		}
		set
		{
			_settings = value;
		}
	}

	[Import]
	public PackagingHelper Helper
	{
		get
		{
			return _helper.GetPropertyNotNull("Helper");
		}
		set
		{
			_helper = value;
		}
	}

	[Import]
	public PackageDownloader PackageDownloader
	{
		get
		{
			return _packageDownloader.GetPropertyNotNull("PackageDownloader");
		}
		set
		{
			_packageDownloader = value;
		}
	}

	[Import]
	public ILogger Logger
	{
		get
		{
			return _logger.GetPropertyNotNull("Logger");
		}
		set
		{
			_logger = value;
		}
	}

	[Import]
	public ILogger NuGetLogger
	{
		get
		{
			return _nuGetLogger.GetPropertyNotNull<ILogger>("NuGetLogger");
		}
		set
		{
			_nuGetLogger = value;
		}
	}

	public IPackageRepository LocalRepository => _localRepository;

	public void Initialize(IElmaComponent component, IEnumerable<IElmaFolder> folders, IElmaProjectSystem projectSystem)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (folders == null)
		{
			throw new ArgumentNullException("folders");
		}
		if (projectSystem == null)
		{
			throw new ArgumentNullException("projectSystem");
		}
		if (string.IsNullOrEmpty(component.ComponentRoot))
		{
			throw new PackagingException(SR.T("Не задана корневая папка компонента \"{0}\"", component.Name));
		}
		_component = component;
		if (!Directory.Exists(component.ComponentRoot))
		{
			FS.CreateDirectory(component.ComponentRoot);
		}
		if (!Directory.Exists(Settings.LocalRepository))
		{
			FS.CreateDirectory(Settings.LocalRepository);
		}
		_localRepositoryFileSystem = Helper.LocalRepositoryFileSystem;
		_localRepositoryPathResolver = Helper.LocalRepositoryPathResolver;
		_localRepository = (IPackageRepository)new LocalPackageRepository((IPackagePathResolver)(object)_localRepositoryPathResolver, (IFileSystem)(object)_localRepositoryFileSystem, true);
		_sharedRepository = Helper.SharedRepository;
		_cfgRepository = (IPackageRepository)(object)_component.GetConfigurationPackageRepository();
		_projectSystem = (IProjectSystem)(object)new ProjectSystemImpl(_component, folders, projectSystem)
		{
			Logger = NuGetLogger
		};
		_repository = new PackageReferenceRepository((IFileSystem)(object)_projectSystem, (string)null, (ISharedPackageRepository)(object)_sharedRepository);
		ElmaProjectManager elmaProjectManager = new ElmaProjectManager(_localRepository, (IPackagePathResolver)(object)_localRepositoryPathResolver, _projectSystem, (IPackageRepository)(object)_repository, Settings, _sharedRepository);
		((ProjectManager)elmaProjectManager).set_Logger(NuGetLogger);
		elmaProjectManager.ElmaComponent = _component;
		elmaProjectManager.LocalStoreComponentsRepository = Helper.LocalComponentsRepository;
		_projectManager = elmaProjectManager;
		_initialized = true;
	}

	public IEnumerable<PackageInfo> GetInstalledPackagesInfo()
	{
		return (from p in _repository.GetPackages().ToList()
			select new PackageInfo(((IPackageName)p).get_Id(), ((IPackageName)p).get_Version())
			{
				Package = p
			}).ToList();
	}

	public IEnumerable<PackageInfo> GetAvailablePackagesInfo()
	{
		return GetPackagesInfo(onlyCompatible: true);
	}

	public IEnumerable<PackageInfo> GetPackagesInfo(bool onlyCompatible)
	{
		List<IPackage> packages = new List<IPackage>();
		Action<IEnumerable<IPackage>> action = delegate(IEnumerable<IPackage> list)
		{
			foreach (IPackage item in list)
			{
				IPackage p2 = item;
				IPackage val = packages.FirstOrDefault((IPackage p1) => ((IPackageName)p1).get_Id() == ((IPackageName)p2).get_Id());
				if (val != null)
				{
					if (((IPackageName)item).get_Version() > ((IPackageName)val).get_Version())
					{
						int index = packages.IndexOf(val);
						packages.RemoveAt(index);
						packages.Insert(index, item);
					}
				}
				else
				{
					packages.Add(item);
				}
			}
		};
		List<IPackage> obj = _localRepository.GetPackages().ToList();
		action(obj);
		if (_cfgRepository != null)
		{
			List<IPackage> obj2 = _cfgRepository.GetPackages().ToList();
			action(obj2);
		}
		if (!string.IsNullOrWhiteSpace(Settings.Repository))
		{
			IQueryable<IPackage> packages2 = PackageRepositoryFactory.get_Default().CreateRepository(Settings.Repository).GetPackages();
			action(packages2);
		}
		return (from p in packages.Where(delegate(IPackage p)
			{
				if (onlyCompatible)
				{
					if (_settings != null && !new ElmaPackageMetadata(((IPackageMetadata)p).get_Tags()).IsCompatible(_settings.Edition))
					{
						return false;
					}
					if (_component != null && !_component.IsCompatible(p))
					{
						return false;
					}
				}
				return true;
			})
			select new PackageInfo(((IPackageName)p).get_Id(), ((IPackageName)p).get_Version())
			{
				Package = p
			}).ToList();
	}

	public IEnumerable<PackageInfo> GetPackagesUpdates()
	{
		IQueryable<IPackage> packages = _repository.GetPackages();
		List<IPackage> list = PackageRepositoryExtensions.GetUpdates(_localRepository, (IEnumerable<IPackageName>)packages, false, false, (IEnumerable<FrameworkName>)null, (IEnumerable<IVersionSpec>)null).ToList();
		if (!string.IsNullOrWhiteSpace(Settings.Repository))
		{
			foreach (IPackage package in PackageRepositoryExtensions.GetUpdates(PackageRepositoryFactory.get_Default().CreateRepository(Settings.Repository), (IEnumerable<IPackageName>)packages, false, false, (IEnumerable<FrameworkName>)null, (IEnumerable<IVersionSpec>)null))
			{
				IPackage val = list.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id().Equals(((IPackageName)package).get_Id()));
				if (val == null || (((IPackageName)package).get_Version() != (SemanticVersion)null && (((IPackageName)val).get_Version() == (SemanticVersion)null || ((IPackageName)package).get_Version() > ((IPackageName)val).get_Version())))
				{
					if (val != null)
					{
						list.Remove(val);
					}
					list.Add(package);
				}
			}
		}
		return list.Select((IPackage p) => new PackageInfo(((IPackageName)p).get_Id(), ((IPackageName)p).get_Version())
		{
			Package = p
		}).ToList();
	}

	public IPreparedOperation PrepareInstall(IEnumerable<PackageInfo> packageInfos, bool updateDependencies)
	{
		try
		{
			Logger.Info(SR.T("Подготовка к установке пакетов в компонент '{0}': {1}...", _component.Name, string.Join(", ", packageInfos)));
			List<PackageInfo> list = new List<PackageInfo>();
			foreach (PackageInfo packageInfo in packageInfos)
			{
				if (!PackageRepositoryExtensions.FindPackagesById(_localRepository, packageInfo.Id).Any((IPackage p) => packageInfo.Version == (SemanticVersion)null || ((IPackageName)p).get_Version().Equals(packageInfo.Version)))
				{
					list.Add(packageInfo);
				}
			}
			if (list.Count > 0)
			{
				PackageDownloader.Download(list, loadLastVersion: false, new IElmaComponent[1] { _component });
			}
			List<IPackage> packages = packageInfos.Select(delegate(PackageInfo info)
			{
				IPackage val = PackageRepositoryExtensions.FindPackage(_localRepository, info.Id, info.Version);
				if (val == null)
				{
					throw new PackagingException(SR.T("Пакет '{0}' не найден в локальном репозитории", info));
				}
				return val;
			}).ToList();
			IPreparedOperation result = _projectManager.PrepareAddPackageReferences(packages, ignoreDependencies: false, allowPrereleaseVersions: false, updateDependencies);
			Logger.Info(SR.T("Подготовка к установке пакетов в компонент '{0}' завершена.", _component.Name));
			return result;
		}
		finally
		{
			PackageInstaller.RemoveLocalRepositorySubDirs(Settings.LocalRepository);
		}
	}

	public IPreparedOperation PrepareUninstall(IEnumerable<string> packageIds, bool removeDependencies = false, bool forceRemove = true)
	{
		try
		{
			List<IPackage> list = (from id in packageIds
				select _repository.FindPackagesById(id).FirstOrDefault() into p
				where p != null
				select p).ToList();
			if (list.Any())
			{
				Logger.Info(SR.T("Подготовка к удалению пакетов из компонента '{0}': {1}...", _component.Name, string.Join(", ", list)));
				IPreparedOperation result = _projectManager.PrepareRemovePackageReferences(list, forceRemove, removeDependencies);
				Logger.Info(SR.T("Подготовка к удалению пакетов из компонента '{0}' завершена.", _component.Name));
				return result;
			}
			Logger.Info(SR.T("Заданные пакеты не установлены в компонент '{0}'.", _component.Name));
			return null;
		}
		finally
		{
			PackageInstaller.RemoveLocalRepositorySubDirs(Settings.LocalRepository);
		}
	}

	protected void CheckInitialized()
	{
		if (!_initialized)
		{
			throw new InvalidOperationException(SR.T("Установщик не инициализирован"));
		}
	}
}
