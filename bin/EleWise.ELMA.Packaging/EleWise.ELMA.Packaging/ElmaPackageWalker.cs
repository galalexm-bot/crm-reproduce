using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using EleWise.ELMA.Packaging.Exceptions;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal abstract class ElmaPackageWalker : PackageWalker
{
	public delegate bool PackageFrameworkCompareDelegate(string packageId);

	private readonly List<string> packagesToRemove = new List<string>();

	protected readonly List<IPackage> _integrationPackages = new List<IPackage>();

	public List<string> PackagesToRemove => packagesToRemove;

	public IElmaComponent ElmaComponent { get; set; }

	public PackagingSettings Settings { get; set; }

	public bool SkipDependencyError { get; set; }

	public PackageFrameworkCompareDelegate PackageFrameworkComparer { get; set; }

	public bool UseElmaMetadata { get; set; }

	protected override bool RaiseErrorOnCycle => false;

	protected override bool IgnoreWalkInfo => true;

	protected override bool SkipDependencyResolveError => SkipDependencyError;

	protected ElmaPackageWalker(PackagingSettings settings)
	{
		UseElmaMetadata = true;
		Settings = settings;
	}

	protected ElmaPackageWalker(PackagingSettings settings, FrameworkName targetFramework)
		: base(targetFramework)
	{
		UseElmaMetadata = true;
		Settings = settings;
	}

	public void AddVisitedPackage(IPackage p)
	{
		((PackageWalker)this).get_Marker().MarkVisited(p);
	}

	protected override void OnAfterPackageWalk(IPackage package)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		if (UseElmaMetadata)
		{
			ElmaPackageMetadata elmaPackageMetadata = new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags());
			if (Settings != null && !elmaPackageMetadata.IsCompatible(Settings.Edition))
			{
				return;
			}
			if (ElmaComponent != null)
			{
				if (!ElmaComponent.IsCompatible(package))
				{
					return;
				}
				ElmaComponent.CheckCompatible(package);
			}
			ElmaPackageMetadata elmaPackageMetadata2 = new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags());
			if (elmaPackageMetadata2.Type != ElmaPackageType.Help)
			{
				foreach (string item in elmaPackageMetadata2.OwnerIds.Union(new string[1] { ((IPackageName)package).get_Id() }).Distinct())
				{
					string ownerIdTag = ElmaPackageMetadata.FormatMetadataTag("OwnerId", item);
					foreach (string item2 in SearchPackageIds((Expression<Func<IPackage, bool>>)((IPackage p) => ((IPackageMetadata)p).get_Tags() != null && ((IPackageMetadata)p).get_Tags().Contains(ownerIdTag))).Except(PackagesToRemove).ToList())
					{
						VersionSpec val = new VersionSpec();
						val.set_MinVersion(new SemanticVersion(((IPackageName)package).get_Version().get_Version().Major, ((IPackageName)package).get_Version().get_Version().Minor, 0, 0));
						val.set_IsMinInclusive(true);
						val.set_MaxVersion(new SemanticVersion(((IPackageName)package).get_Version().get_Version().Major, ((IPackageName)package).get_Version().get_Version().Minor + 1, 0, 0));
						val.set_IsMaxInclusive(false);
						VersionSpec val2 = val;
						IPackage resolvedDependency = ResolveInstallingDependency(new PackageDependency(item2, (IVersionSpec)(object)val2));
						if (resolvedDependency == null)
						{
							resolvedDependency = ((PackageWalker)this).ResolveDependency(new PackageDependency(item2, (IVersionSpec)new VersionSpec(((IPackageName)package).get_Version())));
						}
						if (resolvedDependency == null)
						{
							resolvedDependency = ((PackageWalker)this).ResolveDependency(new PackageDependency(item2, (IVersionSpec)(object)val2));
							if (resolvedDependency == null)
							{
								continue;
							}
						}
						if (((PackageWalker)this).get_Marker().IsVisited(resolvedDependency))
						{
							continue;
						}
						if (new ElmaPackageMetadata(((IPackageMetadata)resolvedDependency).get_Tags()).Type == ElmaPackageType.Integration)
						{
							IPackage val3 = _integrationPackages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id().Equals(((IPackageName)resolvedDependency).get_Id()));
							if (val3 == null || ((IPackageName)resolvedDependency).get_Version() > ((IPackageName)val3).get_Version())
							{
								if (val3 != null)
								{
									_integrationPackages.Remove(val3);
								}
								_integrationPackages.Add(resolvedDependency);
							}
							continue;
						}
						ElmaPackageMetadata elmaPackageMetadata3 = new ElmaPackageMetadata(((IPackageMetadata)resolvedDependency).get_Tags());
						if (Settings != null && !elmaPackageMetadata3.IsCompatible(Settings.Edition))
						{
							continue;
						}
						if (ElmaComponent != null)
						{
							if (!ElmaComponent.IsCompatible(resolvedDependency))
							{
								continue;
							}
							ElmaComponent.CheckCompatible(package);
						}
						if (!((PackageWalker)this).get_IgnoreWalkInfo())
						{
							((PackageWalker)this).GetPackageInfo(resolvedDependency).set_Parent(package);
						}
						((PackageWalker)this).get_Marker().AddDependent(package, resolvedDependency);
						if (((PackageWalker)this).OnAfterResolveDependency(package, resolvedDependency))
						{
							((PackageWalker)this).Walk(resolvedDependency);
						}
					}
				}
			}
		}
		((PackageWalker)this).OnAfterPackageWalk(package);
	}

	protected abstract IPackage ResolveInstallingDependency(PackageDependency dependency);

	protected abstract IEnumerable<string> SearchPackageIds(Expression<Func<IPackage, bool>> expression);

	protected static IPackage ResolveSafeVersion(IEnumerable<IPackage> packages)
	{
		if (packages == null || !packages.Any())
		{
			return null;
		}
		return (from p in (from p in packages
				group p by new
				{
					((IPackageName)p).get_Version().get_Version().Major,
					((IPackageName)p).get_Version().get_Version().Minor
				} into g
				orderby g.Key.Major, g.Key.Minor
				select g).First()
			orderby ((IPackageName)p).get_Version() descending
			select p).FirstOrDefault();
	}

	protected virtual void CheckPackageConflicts(IEnumerable<IPackage> packages)
	{
		List<PackagesConflictInfo> list = new List<PackagesConflictInfo>();
		foreach (IPackage package in packages)
		{
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			foreach (PackageDependency dependency in PackageExtensions.GetCompatiblePackageDependencies((IPackageMetadata)(object)package, ((PackageWalker)this).get_TargetFramework()))
			{
				IPackage val = packages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id() == dependency.get_Id());
				if (val == null)
				{
					list2.Add(dependency.get_Id());
				}
				else if (dependency.get_VersionSpec() != null && !VersionExtensions.Satisfies(dependency.get_VersionSpec(), ((IPackageName)val).get_Version()))
				{
					list3.Add(SR.T("{0} (требуется версия {1})", PackageExtensions.GetFullName((IPackageName)(object)val), dependency.get_VersionSpec()));
				}
			}
			if (list2.Count > 0)
			{
				list.Add(new PackagesConflictInfo
				{
					Type = PackagesConflictType.Miss,
					Package = PackageExtensions.GetFullName((IPackageName)(object)package),
					ConflictedPackages = list2
				});
			}
			if (list3.Count > 0)
			{
				list.Add(new PackagesConflictInfo
				{
					Type = PackagesConflictType.Conflict,
					Package = PackageExtensions.GetFullName((IPackageName)(object)package),
					ConflictedPackages = list3
				});
			}
		}
		if (list.Count > 0)
		{
			throw new PackagesConflictException(SR.T("Обнаружены ошибки совместимости пакетов."))
			{
				Conflicts = list
			};
		}
	}
}
