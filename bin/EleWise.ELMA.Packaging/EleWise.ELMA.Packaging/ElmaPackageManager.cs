using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.ProjectSystem;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaPackageManager : PackageManager
{
	private SharedPackageRepository _sharedPackageRepository;

	public PackagingSettings Settings { get; set; }

	public ElmaStoreComponentRepository CfgStoreComponentsRepository { get; set; }

	public ElmaStoreComponentRepository LocalStoreComponentsRepository { get; set; }

	public bool SkipDependencyError { get; set; }

	public bool WarningOnDependencyMissing { get; set; }

	public ElmaPackageManager(PackagingSettings settings, IPackageRepository sourceRepository, IPackagePathResolver pathResolver, IFileSystem fileSystem, IPackageRepository localRepository, SharedPackageRepository sharedPackageRepository)
		: base(sourceRepository, pathResolver, fileSystem, localRepository)
	{
		Settings = settings;
		_sharedPackageRepository = sharedPackageRepository;
	}

	public void InstallPackages(IEnumerable<PackageInfo> packageInfos, bool ignoreDependencies, bool allowPrereleaseVersions, bool updateDependencies)
	{
		if (packageInfos == null || !packageInfos.Any())
		{
			return;
		}
		if (CfgStoreComponentsRepository != null)
		{
			foreach (ElmaStoreComponentFile component in CfgStoreComponentsRepository.GetComponents())
			{
				component.Unpack(overwrite: false);
			}
		}
		List<IPackage> packages = (from p in packageInfos.Select((Func<PackageInfo, IPackage>)delegate(PackageInfo pi)
			{
				try
				{
					return ResolvePackage(pi.Id, pi.Version, allowPrereleaseVersions);
				}
				catch (Exception)
				{
					return null;
				}
			})
			where p != null
			select p).ToList();
		InstallPackages(packages, ignoreDependencies, allowPrereleaseVersions, updateDependencies);
	}

	public void InstallPackages(IEnumerable<IPackage> packages, bool ignoreDependencies, bool allowPrereleaseVersions, bool updateDependencies)
	{
		if (packages != null && packages.Any())
		{
			ElmaInstallWalker resolver = new ElmaInstallWalker(Settings, ((PackageManager)this).get_LocalRepository(), ((PackageManager)this).get_SourceRepository(), ProjectSystemImpl.TargetFrameworkName, ((PackageManager)this).get_Logger(), ignoreDependencies, allowPrereleaseVersions)
			{
				UpdateDependencies = updateDependencies,
				WarningOnDependencyMissing = WarningOnDependencyMissing,
				SkipDependencyError = SkipDependencyError
			};
			Execute(packages, resolver);
		}
	}

	public override void InstallPackage(string packageId, SemanticVersion version, bool ignoreDependencies, bool allowPrereleaseVersions)
	{
		IPackage val = ResolvePackage(packageId, version, allowPrereleaseVersions);
		((PackageManager)this).InstallPackage(val, ignoreDependencies, allowPrereleaseVersions);
	}

	public override void InstallPackage(IPackage package, bool ignoreDependencies, bool allowPrereleaseVersions)
	{
		InstallPackages((IEnumerable<IPackage>)(object)new IPackage[1] { package }, ignoreDependencies, allowPrereleaseVersions, updateDependencies: true);
	}

	private void Execute(IEnumerable<IPackage> packages, IElmaPackageOperationResolver resolver)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<PackageOperation> enumerable = resolver.ResolveOperations(packages);
		if (!enumerable.Any())
		{
			return;
		}
		foreach (PackageOperation item in enumerable)
		{
			if (item.get_Package() != null && (int)item.get_Action() == 0)
			{
				((PackageManager)this).get_Logger().Log((MessageLevel)0, SR.T("Сохранение пакета '{0}' в локальный репозиторий.", item.get_Package()), Array.Empty<object>());
			}
			((PackageManager)this).Execute(item);
		}
		List<IPackage> packages2 = (from o in enumerable
			where (int)o.get_Action() == 0 && o.get_Package() != null
			select o.get_Package()).ToList();
		UnpackStoreComponentPackages(packages2);
	}

	private void Execute(IPackage package, IPackageOperationResolver resolver)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<PackageOperation> enumerable = resolver.ResolveOperations(package);
		if (!enumerable.Any())
		{
			return;
		}
		foreach (PackageOperation item in enumerable)
		{
			if (item.get_Package() != null && (int)item.get_Action() == 0)
			{
				((PackageManager)this).get_Logger().Log((MessageLevel)0, SR.T("Сохранение пакета '{0}' в локальный репозиторий.", item.get_Package()), Array.Empty<object>());
			}
			((PackageManager)this).Execute(item);
		}
		List<IPackage> packages = (from o in enumerable
			where (int)o.get_Action() == 0 && o.get_Package() != null
			select o.get_Package()).ToList();
		UnpackStoreComponentPackages(packages);
	}

	protected override void OnExpandFiles(PackageOperationEventArgs e)
	{
	}

	private void UnpackStoreComponentPackages(IEnumerable<IPackage> packages)
	{
		if (CfgStoreComponentsRepository == null)
		{
			return;
		}
		foreach (ElmaStoreComponentFile item in (from c in CfgStoreComponentsRepository.GetComponents()
			where c.Manifest.Packages.Any((PackageManifest dep) => packages.Any((IPackage p) => ((IPackageName)p).get_Id().Equals(dep.Id) && dep.SemanticVersion != (SemanticVersion)null && ((IPackageName)p).get_Version() != (SemanticVersion)null && dep.SemanticVersion.Equals(((IPackageName)p).get_Version())))
			select c).ToList())
		{
			foreach (PackageManifest package in item.Manifest.Packages)
			{
				_ = package;
				item.UnpackTo(((PackageManager)this).get_FileSystem().get_Root(), overwrite: false);
			}
		}
	}

	private IPackage ResolvePackage(string packageId, SemanticVersion version, bool allowPrereleaseVersions)
	{
		if (string.IsNullOrEmpty(packageId))
		{
			throw new ArgumentException(SR.T("Идентификатор пакета не может быть пустым"));
		}
		IPackage val = null;
		if (version != (SemanticVersion)null)
		{
			val = PackageRepositoryExtensions.FindPackage(((PackageManager)this).get_LocalRepository(), packageId, version, allowPrereleaseVersions, true);
		}
		if (val == null)
		{
			val = PackageRepositoryExtensions.FindPackage(((PackageManager)this).get_SourceRepository(), packageId, version, (IPackageConstraintProvider)(object)NullConstraintProvider.get_Instance(), allowPrereleaseVersions, false);
			if (val != null)
			{
				val = PackageRepositoryExtensions.FindPackage(((PackageManager)this).get_LocalRepository(), ((IPackageName)val).get_Id(), ((IPackageName)val).get_Version(), allowPrereleaseVersions, true) ?? val;
			}
		}
		if (val == null)
		{
			if (version != (SemanticVersion)null)
			{
				throw new InvalidOperationException(SR.T("Не удалось найти версию '{1}' пакета '{0}'", packageId, version));
			}
			throw new InvalidOperationException(SR.T("Не удалось найти пакет '{0}'", packageId));
		}
		return val;
	}
}
