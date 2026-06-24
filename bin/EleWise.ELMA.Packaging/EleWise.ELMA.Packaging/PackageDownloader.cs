using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging;

[Export(typeof(PackageDownloader))]
public class PackageDownloader
{
	private PackagingSettings _settings;

	private PackagingHelper _helper;

	private ILogger _logger;

	private ILogger _nuGetLogger;

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

	public void Download(IEnumerable<PackageInfo> packageInfos, bool loadLastVersion)
	{
		if (packageInfos == null)
		{
			throw new ArgumentNullException("packageInfos");
		}
		Download(packageInfos, loadLastVersion, null, null);
	}

	public void Download(IEnumerable<PackageInfo> packageInfos, bool loadLastVersion, IEnumerable<IElmaComponent> components)
	{
		if (packageInfos == null)
		{
			throw new ArgumentNullException("packageInfos");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		Tuple<IPackageRepository, ElmaStoreComponentRepository> tuple = components.Select((IElmaComponent c) => new Tuple<IPackageRepository, ElmaStoreComponentRepository>((IPackageRepository)(object)c.GetConfigurationPackageRepository(), c.GetConfigurationStoreComponentsRepository())).FirstOrDefault((Tuple<IPackageRepository, ElmaStoreComponentRepository> t) => t.Item1 != null && t.Item2 != null);
		IPackageRepository cfgPackageRepository = tuple?.Item1;
		ElmaStoreComponentRepository cfgStoreComponentsRepository = tuple?.Item2;
		Download(packageInfos, loadLastVersion, cfgPackageRepository, cfgStoreComponentsRepository);
	}

	public void Download(IEnumerable<PackageInfo> packageInfos, bool loadLastVersion, IPackageRepository cfgPackageRepository, ElmaStoreComponentRepository cfgStoreComponentsRepository)
	{
		if (packageInfos == null)
		{
			throw new ArgumentNullException("packageInfos");
		}
		if (cfgPackageRepository != null)
		{
			DoDownload(packageInfos, loadLastVersion, cfgPackageRepository, cfgStoreComponentsRepository);
		}
		if (!string.IsNullOrWhiteSpace(Settings.Repository))
		{
			IPackageRepository sourceRepository = PackageRepositoryFactory.get_Default().CreateRepository(Settings.Repository);
			DoDownload(packageInfos, loadLastVersion, sourceRepository, null);
		}
	}

	private void DoDownload(IEnumerable<PackageInfo> packageInfos, bool loadLastVersion, IPackageRepository sourceRepository, ElmaStoreComponentRepository cfgStoreComponentsRepository)
	{
		if (packageInfos == null)
		{
			throw new ArgumentNullException("packageInfos");
		}
		Logger.Info(SR.T("Проверка и загрузка обновлений для пакетов: {0}.", string.Join(", ", packageInfos.Select((PackageInfo pi) => string.Concat("'", pi, "'")))));
		try
		{
			TransactionalPhysicalFileSystem localRepositoryFileSystem = Helper.LocalRepositoryFileSystem;
			DefaultPackagePathResolver localRepositoryPathResolver = Helper.LocalRepositoryPathResolver;
			LocalRootPackageRepository localRepository = new LocalRootPackageRepository((IPackagePathResolver)(object)localRepositoryPathResolver, (IFileSystem)(object)localRepositoryFileSystem);
			SharedPackageRepository sharedRepository = Helper.SharedRepository;
			ElmaPackageManager elmaPackageManager = new ElmaPackageManager(Settings, sourceRepository, (IPackagePathResolver)(object)localRepositoryPathResolver, (IFileSystem)(object)localRepositoryFileSystem, (IPackageRepository)(object)localRepository, sharedRepository);
			((PackageManager)elmaPackageManager).set_Logger(NuGetLogger);
			elmaPackageManager.CfgStoreComponentsRepository = cfgStoreComponentsRepository;
			elmaPackageManager.LocalStoreComponentsRepository = Helper.LocalComponentsRepository;
			elmaPackageManager.WarningOnDependencyMissing = true;
			elmaPackageManager.SkipDependencyError = true;
			elmaPackageManager.InstallPackages(packageInfos, ignoreDependencies: false, allowPrereleaseVersions: false, loadLastVersion);
		}
		catch (Exception ex)
		{
			if (!(sourceRepository is LocalPackageRepository))
			{
				throw new PackagingException(SR.T("Не удалось загрузить пакеты с удаленного сервера: " + ex.Message), ex);
			}
			throw;
		}
	}
}
