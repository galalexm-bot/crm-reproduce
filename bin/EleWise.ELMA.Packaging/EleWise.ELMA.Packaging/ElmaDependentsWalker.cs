using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaDependentsWalker : ElmaPackageWalker, IDependentsResolver
{
	internal IEnumerable<IPackage> _installingPackages;

	protected override bool RaiseErrorOnCycle => false;

	protected override bool IgnoreWalkInfo => true;

	protected IPackageRepository Repository { get; private set; }

	private IDictionary<IPackage, HashSet<IPackage>> DependentsLookup { get; set; }

	internal ElmaDependentsWalker(PackagingSettings settings, IPackageRepository repository)
		: this(settings, repository, null)
	{
	}

	public ElmaDependentsWalker(PackagingSettings settings, IPackageRepository repository, FrameworkName targetFramework)
		: base(settings, targetFramework)
	{
		if (repository == null)
		{
			throw new ArgumentNullException("repository");
		}
		Repository = repository;
	}

	protected override IPackage ResolveDependency(PackageDependency dependency)
	{
		return PackageRepositoryExtensions.ResolveDependency(Repository, dependency, true, false);
	}

	protected override IPackage ResolveInstallingDependency(PackageDependency dependency)
	{
		IPackage val = ((_installingPackages != null) ? _installingPackages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id() == dependency.get_Id()) : null);
		if (val != null && (dependency.get_VersionSpec() == null || VersionExtensions.ToDelegate(dependency.get_VersionSpec())(val)))
		{
			return val;
		}
		return null;
	}

	protected override bool OnAfterResolveDependency(IPackage package, IPackage dependency)
	{
		if (!DependentsLookup.TryGetValue(dependency, out var value))
		{
			value = new HashSet<IPackage>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
			DependentsLookup[dependency] = value;
		}
		value.Add(package);
		return ((PackageWalker)this).OnAfterResolveDependency(package, dependency);
	}

	public IEnumerable<IPackage> GetDependents(IPackage package)
	{
		if (DependentsLookup == null)
		{
			DependentsLookup = new Dictionary<IPackage, HashSet<IPackage>>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
			foreach (IPackage package2 in Repository.GetPackages())
			{
				((PackageWalker)this).Walk(package2);
			}
		}
		if (DependentsLookup.TryGetValue(package, out var value))
		{
			return value;
		}
		return Enumerable.Empty<IPackage>();
	}

	protected override IEnumerable<string> SearchPackageIds(Expression<Func<IPackage, bool>> expression)
	{
		return (from p in PackageRepositoryExtensions.Search(Repository, "", true).Where(expression).Select((Expression<Func<IPackage, string>>)((IPackage p) => ((IPackageName)p).get_Id()))
				.ToList()
			where p != null
			select p).Distinct().ToList();
	}
}
