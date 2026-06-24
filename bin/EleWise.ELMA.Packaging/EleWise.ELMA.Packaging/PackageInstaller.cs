using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.Components.UpdatingWeb;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Packaging.Components.WebServer;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging;

[Export(typeof(PackageInstaller))]
public class PackageInstaller
{
	private static readonly string[] KeepLocalRepositorySubFolders = new string[2] { "Icons", "AutoDeploy" };

	private PackagingSettings _settings;

	private PackageDownloader _packageDownloader;

	private IEnumerable<IElmaComponent> _components;

	private ILogger _logger;

	private PackagingHelper _helper;

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

	[ImportMany]
	public IEnumerable<IElmaComponent> Components
	{
		get
		{
			return _components.GetPropertyNotNull("Components");
		}
		set
		{
			_components = value;
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

	public void InstallComponents(IEnumerable<IElmaComponent> components, IEnumerable<string> packages)
	{
		List<string> list = (from id in (from c in components
				where !c.IsInstalled()
				select c.RootPackageId).Union(packages ?? new string[0])
			where !string.IsNullOrEmpty(id)
			select id).Distinct().ToList();
		if (list.Count > 0)
		{
			PackageDownloader.Download(list.Select((string id) => new PackageInfo(id)), loadLastVersion: true);
		}
		using IFSTransaction iFSTransaction = CreateTransaction();
		foreach (IElmaComponent component in components)
		{
			if (!component.IsInstalled())
			{
				component.Install(packages);
				continue;
			}
			Logger.Warn(SR.T("Компонент '{0}' ({1}) уже установлен", component.Name, component.Id));
		}
		iFSTransaction.Commit();
	}

	public void UninstallComponents(IEnumerable<IElmaComponent> components)
	{
		foreach (IElmaComponent component in components)
		{
			if (component.IsInstalled() && component.IsStarted())
			{
				component.Stop();
			}
		}
		using IFSTransaction iFSTransaction = CreateTransaction();
		foreach (IElmaComponent component2 in components)
		{
			if (component2.IsInstalled())
			{
				component2.Uninstall();
			}
		}
		iFSTransaction.Commit();
	}

	public void Install(IEnumerable<PackageInfo> packageInfos)
	{
		Install(packageInfos, Components.Where((IElmaComponent c) => c.IsInstalled()));
	}

	public void Install(IEnumerable<PackageInfo> packageInfos, IEnumerable<IElmaComponent> components)
	{
		if (packageInfos == null)
		{
			throw new ArgumentNullException("packageInfos");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		foreach (IElmaComponent component in components)
		{
			component.BeforePrepareUpdate();
		}
		Logger.Info(SR.T("Установка пакетов {0} в компоненты {1}", string.Join(", ", packageInfos.Select((PackageInfo pi) => string.Concat("'", pi, "'"))), string.Join(", ", components.Select((IElmaComponent c) => "'" + c.Name + "'"))));
		foreach (IElmaComponent component2 in components)
		{
			if (!component2.IsInstalled())
			{
				throw new PackagingException(SR.T("Компонент '{0}' не установлен", component2.Name));
			}
		}
		PackageDownloader.Download(packageInfos, loadLastVersion: true, components);
		Dictionary<IElmaComponent, IPreparedOperation> preparedActions = (from p in components.ToDictionary((IElmaComponent c) => c, (IElmaComponent c) => c.PrepareInstallPackages(packageInfos, updateDependencies: false))
			where p.Value != null
			select p).ToDictionary((KeyValuePair<IElmaComponent, IPreparedOperation> p) => p.Key, (KeyValuePair<IElmaComponent, IPreparedOperation> p) => p.Value);
		if (preparedActions.Any())
		{
			SafeInstallPackages(preparedActions.Keys, delegate(IElmaComponent c)
			{
				preparedActions[c].Execute();
			});
		}
	}

	public void Uninstall(IEnumerable<string> packageIds)
	{
		Uninstall(packageIds, Components.Where((IElmaComponent c) => c.IsInstalled()));
	}

	public void Uninstall(IEnumerable<string> packageIds, IEnumerable<IElmaComponent> components)
	{
		if (packageIds == null)
		{
			throw new ArgumentNullException("packageIds");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		foreach (IElmaComponent component in components)
		{
			component.BeforePrepareUpdate();
		}
		Logger.Info(SR.T("Удаление пакетов {0} из компонентов {1}", string.Join(", ", packageIds.Select((string pi) => "'" + pi + "'")), string.Join(", ", components.Select((IElmaComponent c) => "'" + c.Name + "'"))));
		foreach (IElmaComponent component2 in components)
		{
			if (!component2.IsInstalled())
			{
				throw new PackagingException(SR.T("Компонент '{0}' не установлен", component2.Name));
			}
		}
		Dictionary<IElmaComponent, IPreparedOperation> preparedActions = (from p in components.ToDictionary((IElmaComponent c) => c, (IElmaComponent c) => c.PrepareUninstallPackages(packageIds))
			where p.Value != null
			select p).ToDictionary((KeyValuePair<IElmaComponent, IPreparedOperation> p) => p.Key, (KeyValuePair<IElmaComponent, IPreparedOperation> p) => p.Value);
		if (preparedActions.Any())
		{
			SafeInstallPackages(preparedActions.Keys, delegate(IElmaComponent c)
			{
				preparedActions[c].Execute();
			});
		}
	}

	public void Update()
	{
		Update(Components.Where((IElmaComponent c) => c.IsInstalled()));
	}

	public void Update(IEnumerable<IElmaComponent> components)
	{
		Update(components, null, null);
	}

	public void Update(IEnumerable<IElmaComponent> components, IEnumerable<PackageInfo> newPackages, IEnumerable<IElmaComponent> componentsForNewPackages)
	{
		Update(components, newPackages, componentsForNewPackages, doRepositoryClean: false);
	}

	public void Update(IEnumerable<IElmaComponent> components, IEnumerable<PackageInfo> newPackages, IEnumerable<IElmaComponent> componentsForNewPackages, bool doRepositoryClean)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		foreach (IElmaComponent component in components)
		{
			component.BeforePrepareUpdate();
		}
		Logger.Info(SR.T("Обновление пакетов в компонентах: {0}.", string.Join(", ", components.Select((IElmaComponent c) => "'" + c.Name + "'"))));
		List<string> source = components.SelectMany((IElmaComponent c) => from p in c.GetInstalledPackagesInfo()
			select p.Id).Distinct().ToList();
		new List<string>();
		List<PackageInfo> list = source.Select((string id) => new PackageInfo(id)).ToList();
		if (newPackages != null)
		{
			foreach (PackageInfo pi2 in newPackages)
			{
				if (!list.Any((PackageInfo p) => p.Id == pi2.Id))
				{
					list.Add(pi2);
				}
			}
		}
		PackageDownloader.Download(list, loadLastVersion: true, components);
		Dictionary<IElmaComponent, IPreparedOperation> preparedActions = (from p in components.ToDictionary((IElmaComponent c) => c, delegate(IElmaComponent c)
			{
				List<PackageInfo> list2 = (from pi in c.GetInstalledPackagesInfo()
					select new PackageInfo(pi.Id)).ToList();
				if (newPackages != null && (componentsForNewPackages == null || componentsForNewPackages.Contains(c)))
				{
					foreach (PackageInfo pi3 in newPackages)
					{
						if (!list2.Any((PackageInfo p) => p.Id == pi3.Id))
						{
							list2.Add(pi3);
						}
					}
				}
				return c.PrepareInstallPackages(list2, updateDependencies: true);
			})
			where p.Value != null
			select p).ToDictionary((KeyValuePair<IElmaComponent, IPreparedOperation> p) => p.Key, (KeyValuePair<IElmaComponent, IPreparedOperation> p) => p.Value);
		if (preparedActions.Any())
		{
			SafeInstallPackages(preparedActions.Keys, delegate(IElmaComponent c)
			{
				try
				{
					preparedActions[c].Execute();
					Logger.Info(SR.T("Обновление пакетов в компоненте '{0}' завершено.", c.Name));
				}
				catch (Exception innerException)
				{
					throw new PackagingException(SR.T("Не удалось обновить компонент '{0}'", c.Name), innerException);
				}
			});
		}
		if (doRepositoryClean)
		{
			Logger.Info(SR.T("Проверка необходимости удаления старых неиспользуемых пакетов."));
			RemoveOldUnusedPackages();
		}
	}

	public static void RemoveLocalRepositorySubDirs(string localRepository)
	{
		foreach (string item in from path in Directory.GetDirectories(localRepository)
			where !KeepLocalRepositorySubFolders.Contains(Path.GetFileName(path), StringComparer.CurrentCultureIgnoreCase)
			select path)
		{
			EleWise.ELMA.Packaging.Logging.Logger.Log.Info(SR.T("Удаление папки '{0}' из локального репозитория", item));
			try
			{
				Directory.Delete(item, recursive: true);
			}
			catch (Exception exception)
			{
				EleWise.ELMA.Packaging.Logging.Logger.Log.Debug(SR.T("Не удалось удалить папку '{0}'", item), exception);
			}
		}
	}

	public void RemoveOldUnusedPackages()
	{
		List<IPackage> list = Helper.LocalRepository.GetPackages().ToList();
		IEnumerable<ElmaStoreComponentFile> components = Helper.LocalComponentsRepository.GetComponents();
		Dictionary<string, IPackage> packagesByIdVersion = new Dictionary<string, IPackage>();
		list.ForEach(delegate(IPackage package)
		{
			string key = ((IPackageName)package).get_Id().ToString().ToLower() + "|" + ((IPackageName)package).get_Version();
			if (packagesByIdVersion.ContainsKey(key))
			{
				if (_logger != null)
				{
					Logger.Warn(SR.T("Репозиторий содержит более одного экземпляра пакета {0} {1}", ((IPackageName)package).get_Id(), ((IPackageName)package).get_Version()));
				}
			}
			else
			{
				packagesByIdVersion[key] = package;
			}
		});
		IPackage value3;
		Func<string, SemanticVersion, IPackage> func = (string id, SemanticVersion version) => packagesByIdVersion.TryGetValue(id.ToLower() + "|" + version, out value3) ? value3 : null;
		HashSet<IPackage> hashSet = (from deprecatedPackage in (from versions in list.ToHashSet((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion).ToLookup((IPackage package) => ((IPackageName)package).get_Id())
				select versions.Aggregate((IPackage v1, IPackage v2) => (!(((IPackageName)v1).get_Version() > ((IPackageName)v2).get_Version())) ? v2 : v1)).SelectMany((IPackage package) => ((IXPackageMetadata)package).get_UninstallDependencies() ?? Enumerable.Empty<PackageUninstallDependency>())
			select PackageRepositoryExtensions.FindPackage(Helper.LocalRepository, deprecatedPackage.get_Id(), deprecatedPackage.get_VersionSpec(), false, false) into package
			where package != null
			select package).ToHashSet((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
		IEnumerable<string> deprecatedPackageIds = hashSet.Select((IPackage p) => ((IPackageName)p).get_Id());
		foreach (ElmaStoreComponentFile item in components.Where((ElmaStoreComponentFile c) => deprecatedPackageIds.Contains(c.Id)))
		{
			item.Delete();
		}
		foreach (IPackage item2 in hashSet)
		{
			((PackageRepositoryBase)Helper.SharedRepository).RemovePackage(item2);
		}
		Dictionary<string, SemanticVersion> dictionary = new Dictionary<string, SemanticVersion>();
		foreach (IGrouping<string, ElmaStoreComponentFile> item3 in from c in components
			where !deprecatedPackageIds.Contains(c.Id)
			group c by c.Id)
		{
			List<IPackage> list2 = new List<IPackage>();
			IOrderedEnumerable<ElmaStoreComponentFile> orderedEnumerable = from c in item3
				where !deprecatedPackageIds.Contains(c.Id)
				orderby c.Version descending
				select c;
			ElmaStoreComponentFile minStoreComponentVersion = null;
			foreach (ElmaStoreComponentFile item4 in orderedEnumerable)
			{
				foreach (PackageManifest package in item4.Manifest.Packages)
				{
					IPackage val = func(package.Id, package.SemanticVersion);
					if (val != null && Helper.SharedRepository.IsReferenced(package.Id, package.SemanticVersion) && !list2.Contains(val))
					{
						list2.Add(val);
						minStoreComponentVersion = item4;
					}
				}
			}
			if (minStoreComponentVersion == null)
			{
				minStoreComponentVersion = orderedEnumerable.First();
			}
			foreach (ElmaStoreComponentFile item5 in item3.Where((ElmaStoreComponentFile c) => c.Version >= minStoreComponentVersion.Version))
			{
				foreach (PackageManifest package2 in item5.Manifest.Packages)
				{
					IPackage val2 = func(package2.Id, package2.SemanticVersion);
					if (val2 != null && (!dictionary.TryGetValue(((IPackageName)val2).get_Id().ToLower(), out var value) || ((IPackageName)val2).get_Version() < value))
					{
						dictionary[((IPackageName)val2).get_Id().ToLower()] = ((IPackageName)val2).get_Version();
					}
				}
			}
			foreach (ElmaStoreComponentFile item6 in item3.Where((ElmaStoreComponentFile c) => c.Version < minStoreComponentVersion.Version))
			{
				item6.Delete();
			}
		}
		foreach (IPackage item7 in list.Where(delegate(IPackage p)
		{
			ElmaPackageMetadata elmaPackageMetadata = new ElmaPackageMetadata(((IPackageMetadata)p).get_Tags());
			return !deprecatedPackageIds.Intersect(elmaPackageMetadata.OwnerIds).Any() && Helper.SharedRepository.IsReferenced(((IPackageName)p).get_Id(), ((IPackageName)p).get_Version());
		}))
		{
			if (!dictionary.TryGetValue(((IPackageName)item7).get_Id().ToLower(), out var value2) || ((IPackageName)item7).get_Version() < value2)
			{
				dictionary[((IPackageName)item7).get_Id().ToLower()] = ((IPackageName)item7).get_Version();
			}
		}
		foreach (IGrouping<string, IPackage> item8 in from p in list
			group p by ((IPackageName)p).get_Id().ToLower())
		{
			if (!dictionary.TryGetValue(item8.Key, out var minVersion))
			{
				minVersion = item8.Max((IPackage p) => ((IPackageName)p).get_Version());
			}
			foreach (IPackage item9 in item8.Where((IPackage p) => ((IPackageName)p).get_Version() < minVersion))
			{
				((PackageRepositoryBase)Helper.SharedRepository).RemovePackage(item9);
			}
		}
	}

	protected void SafeInstallPackages(IEnumerable<IElmaComponent> components, Action<IElmaComponent> installAction)
	{
		IEnumerable<IElmaComponent> enumerable = components.Where((IElmaComponent c) => c.GetType() == typeof(WebServerComponent) || c.GetType() == typeof(UpdatingWebComponent));
		IEnumerable<IElmaComponent> enumerable2 = components.Except(enumerable);
		List<IElmaComponent> list = new List<IElmaComponent>();
		try
		{
			if (enumerable.Any())
			{
				IElmaComponent elmaComponent = enumerable2.FirstOrDefault((IElmaComponent c) => c.GetType() == typeof(WebComponent));
				if (elmaComponent != null && elmaComponent.IsStarted())
				{
					list.Add(elmaComponent);
					elmaComponent.Pause();
				}
				DoSafeInstallPackages(enumerable, installAction);
			}
			if (enumerable2.Any())
			{
				DoSafeInstallPackages(enumerable2, installAction);
			}
		}
		finally
		{
			foreach (IElmaComponent item in list)
			{
				if (!item.IsStarted())
				{
					item.Start();
				}
			}
		}
	}

	protected void DoSafeInstallPackages(IEnumerable<IElmaComponent> components, Action<IElmaComponent> installAction)
	{
		List<IElmaComponent> startedComponents = components.Where((IElmaComponent c) => c.IsStarted()).ToList();
		foreach (IElmaComponent item in startedComponents)
		{
			if (item.IsStarted())
			{
				item.Pause();
			}
		}
		Action action = delegate
		{
			foreach (IElmaComponent item2 in startedComponents)
			{
				if (!item2.IsStarted())
				{
					item2.Start();
				}
			}
		};
		IFSTransaction iFSTransaction = CreateTransaction();
		try
		{
			foreach (IElmaComponent component in components)
			{
				installAction(component);
			}
			iFSTransaction.Commit();
		}
		catch
		{
			if (iFSTransaction.Rollback())
			{
				try
				{
					action();
				}
				catch (Exception exception)
				{
					Logger.Warn(SR.T("Не удалось перезапустить компоненты"), exception);
				}
			}
			throw;
		}
		action();
	}

	private IFSTransaction CreateTransaction(Action onError = null)
	{
		return FSTransaction.Create(Settings.Root);
	}
}
