using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging.Components;

public abstract class ElmaComponent : IElmaComponent
{
	private PackagingSettings _settings;

	private PackagingInitializer _initializer;

	private IElmaProjectSystem _projectSystem;

	private IEnumerable<IElmaFolder> _folders;

	private ILogger _logger;

	private PackagingHelper _helper;

	private ElmaStoreComponentRepository _cfgComponentsRepository;

	private LocalPackageRepository _cfgPackageRepository;

	private string _cfgLastDirectory;

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
	public PackagingInitializer Initializer
	{
		get
		{
			return _initializer.GetPropertyNotNull("Initializer");
		}
		set
		{
			_initializer = value;
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

	public abstract string Id { get; }

	public abstract string Name { get; }

	public string Root => Settings.Root;

	public virtual string ComponentRoot => Path.Combine(Root, RelativeComponentRoot);

	public abstract string RootPackageId { get; }

	protected virtual bool AutoConfigure => true;

	public virtual bool StartAfterInstall => false;

	protected abstract string RelativeComponentRoot { get; }

	protected IElmaProjectSystem ProjectSystem
	{
		get
		{
			if (_projectSystem == null)
			{
				_projectSystem = CreateProjectSystem();
			}
			if (_projectSystem == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось создать проектную систему"));
			}
			return _projectSystem;
		}
	}

	protected IEnumerable<IElmaFolder> Folders
	{
		get
		{
			if (_folders == null)
			{
				_folders = CreateFolders();
			}
			if (_folders == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось создать дескрипторы папок"));
			}
			return _folders;
		}
	}

	public override string ToString()
	{
		return "'" + Name + "' (" + Id + ")";
	}

	public virtual bool IsInstalled()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(ComponentRoot))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(RootPackageId))
		{
			string text = Path.Combine(ComponentRoot, Constants.PackageReferenceFile);
			if (File.Exists(text) && new PackageReferenceFile(text).GetPackageReferences().Any((PackageReference p) => p.get_Id().Equals(RootPackageId)))
			{
				return true;
			}
		}
		return false;
	}

	public virtual void Install(IEnumerable<string> packages)
	{
		if (IsInstalled())
		{
			return;
		}
		try
		{
			FS.CreateDirectory(ComponentRoot);
			if (!string.IsNullOrEmpty(RootPackageId))
			{
				List<string> list = new List<string>(new string[1] { RootPackageId });
				if (packages != null)
				{
					list = list.Union(packages).Distinct().ToList();
				}
				InstallPackages(list.Select((string id) => new PackageInfo(id)).ToArray(), updateDependencies: true);
				if (AutoConfigure)
				{
					Configure(null);
				}
			}
		}
		catch (Exception innerException)
		{
			throw new PackagingException(SR.T("Не удалось установить компонент '{0}'", Name), innerException);
		}
	}

	public virtual void Uninstall()
	{
		if (IsStarted())
		{
			Stop();
		}
		Unconfigure();
		List<string> packageIds = (from p in GetInstalledPackagesInfo()
			select p.Id).ToList();
		UninstallPackages(packageIds);
	}

	public virtual void Configure(ElmaComponentSettings settings)
	{
	}

	public virtual void Unconfigure()
	{
	}

	public virtual bool IsStarted()
	{
		return false;
	}

	public virtual void Start()
	{
	}

	public virtual void Stop()
	{
	}

	public virtual void Pause()
	{
	}

	public virtual IEnumerable<PackageInfo> GetInstalledPackagesInfo()
	{
		return CreateInstaller().GetInstalledPackagesInfo();
	}

	public virtual IEnumerable<PackageInfo> GetAvailablePackagesInfo()
	{
		return CreateInstaller().GetAvailablePackagesInfo();
	}

	public virtual IEnumerable<PackageInfo> GetPackagesInfo()
	{
		return CreateInstaller().GetPackagesInfo(onlyCompatible: false);
	}

	public virtual IEnumerable<PackageInfo> GetPackagesUpdates()
	{
		return CreateInstaller().GetPackagesUpdates();
	}

	public virtual bool IsCompatible(IPackage package)
	{
		if (package == null)
		{
			throw new ArgumentNullException("package");
		}
		ElmaPackageMetadata metadata = new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags());
		return IsCompatible(metadata);
	}

	public virtual bool IsCompatible(ElmaPackageMetadata metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (!metadata.Components.Any() || metadata.Components.Any((string c) => c.Equals(Id, StringComparison.CurrentCultureIgnoreCase)))
		{
			return metadata.IsCompatible(Settings.Edition);
		}
		return false;
	}

	public void CheckCompatible(IPackage package)
	{
		CheckCompatible(package, null);
	}

	public virtual void CheckCompatible(IPackage package, ElmaPackageMetadata metadata)
	{
		if (package == null)
		{
			throw new ArgumentNullException("package");
		}
		if (metadata == null)
		{
			metadata = new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags());
		}
	}

	public virtual IPreparedOperation PrepareInstallPackages(IEnumerable<PackageInfo> packageInfos, bool updateDependencies)
	{
		IPreparedOperation preparedOperation = CreateInstaller().PrepareInstall(packageInfos, updateDependencies);
		if (preparedOperation == null)
		{
			return null;
		}
		return new CompositePreparedOperation(new IPreparedOperation[2]
		{
			preparedOperation,
			new SimplePreparedOperation(ConfigureShortcutsAction)
		});
	}

	public void InstallPackages(IEnumerable<PackageInfo> packageInfos, bool updateDependencies)
	{
		PrepareInstallPackages(packageInfos, updateDependencies)?.Execute();
	}

	public virtual IPreparedOperation PrepareUninstallPackages(IEnumerable<string> packageIds, bool removeDependencies = false, bool forceRemove = true)
	{
		return CreateInstaller().PrepareUninstall(packageIds, removeDependencies, forceRemove);
	}

	public void UninstallPackages(IEnumerable<string> packageIds, bool removeDependencies = false, bool forceRemove = true)
	{
		PrepareUninstallPackages(packageIds, removeDependencies, forceRemove)?.Execute();
	}

	public virtual void BeforePrepareUpdate()
	{
	}

	public virtual void BeforeUpdate()
	{
	}

	public virtual void AfterUpdate(bool success)
	{
	}

	public ElmaStoreComponentRepository GetConfigurationStoreComponentsRepository()
	{
		UpdateCfgRepositories();
		return _cfgComponentsRepository;
	}

	public LocalPackageRepository GetConfigurationPackageRepository()
	{
		UpdateCfgRepositories();
		return _cfgPackageRepository;
	}

	public virtual string GetConfigurationPackagesDirectory()
	{
		return null;
	}

	public virtual void UnpackPackagesFromComponents(IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		UnpackPackagesFromComponents(activationKeys, getMainUnitExpiration, GetConfigurationStoreComponentsRepository(), (IPackageRepository)(object)GetConfigurationPackageRepository(), _cfgLastDirectory);
		UnpackPackagesFromComponents(activationKeys, getMainUnitExpiration, Helper.LocalComponentsRepository, Helper.LocalRepository, Helper.LocalRepository.get_Source());
	}

	protected abstract IElmaProjectSystem CreateProjectSystem();

	protected abstract IEnumerable<IElmaFolder> CreateFolders();

	protected virtual ComponentPackageInstaller CreateInstaller()
	{
		ComponentPackageInstaller componentPackageInstaller = Initializer.ComposeParts(new ComponentPackageInstaller());
		componentPackageInstaller.Initialize(this, Folders, ProjectSystem);
		return componentPackageInstaller;
	}

	protected void DeleteSettingsFile(string settingsFile)
	{
		FS.SafeDeleteFile(settingsFile, deleteEmptyDirs: true, ComponentRoot);
	}

	protected string GetCommonStartMenuDirectory()
	{
		if (string.IsNullOrEmpty(Settings.StartMenuGroup))
		{
			return null;
		}
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
	}

	protected string GetStartMenuDirectory()
	{
		if (string.IsNullOrEmpty(Settings.StartMenuGroup))
		{
			return null;
		}
		return Path.Combine(GetCommonStartMenuDirectory(), Settings.StartMenuGroup);
	}

	protected string GetDesktopDirectory()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
	}

	protected virtual void ConfigureShortcuts()
	{
	}

	protected void ConfigureShortcutsAction()
	{
		EleWise.ELMA.Packaging.Logging.Logger.Log.Info(SR.T("Началась настройка ярлычков к приложению"));
		try
		{
			ConfigureShortcuts();
		}
		catch (Exception exception)
		{
			EleWise.ELMA.Packaging.Logging.Logger.Log.Warn(SR.T("Не удалось настроить ярлычки к приложению"), exception);
		}
	}

	private void UpdateCfgRepositories()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		string configurationPackagesDirectory = GetConfigurationPackagesDirectory();
		if (!(_cfgLastDirectory != configurationPackagesDirectory))
		{
			return;
		}
		if (!string.IsNullOrEmpty(configurationPackagesDirectory) && !Directory.Exists(configurationPackagesDirectory))
		{
			try
			{
				FS.CreateDirectory(configurationPackagesDirectory);
				Directory.CreateDirectory(configurationPackagesDirectory);
			}
			catch (Exception exception)
			{
				Logger.Error("Cannot create configuration components directory", exception);
			}
		}
		_cfgComponentsRepository = ((!string.IsNullOrEmpty(configurationPackagesDirectory) && Directory.Exists(configurationPackagesDirectory)) ? new ElmaStoreComponentRepository(configurationPackagesDirectory) : null);
		_cfgPackageRepository = ((!string.IsNullOrEmpty(configurationPackagesDirectory) && Directory.Exists(configurationPackagesDirectory)) ? new LocalPackageRepository(configurationPackagesDirectory) : ((LocalPackageRepository)null));
		_cfgLastDirectory = configurationPackagesDirectory;
	}

	private static void UnpackPackagesFromComponents(IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration, ElmaStoreComponentRepository componentsRep, IPackageRepository rep, string unpackPath)
	{
		if (componentsRep == null || rep == null || string.IsNullOrEmpty(unpackPath))
		{
			return;
		}
		List<IPackage> packages = rep.GetPackages().ToList();
		foreach (ElmaStoreComponentFile item in from c in componentsRep.GetComponents()
			where c.Manifest != null && c.ComponentFileExists
			select c)
		{
			if (item.Manifest.Packages.Any((PackageManifest pkgManifest) => packages.Any((IPackage p) => !((IPackageName)p).get_Id().Equals(pkgManifest.Id) || (!(pkgManifest.SemanticVersion == (SemanticVersion)null) && !(((IPackageName)p).get_Version() == (SemanticVersion)null) && !((IPackageName)p).get_Version().Equals(pkgManifest.SemanticVersion)))))
			{
				item.UnpackTo(unpackPath, overwrite: false, activationKeys, getMainUnitExpiration);
			}
		}
	}
}
