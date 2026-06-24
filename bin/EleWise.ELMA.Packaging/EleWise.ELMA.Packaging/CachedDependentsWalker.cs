using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class CachedDependentsWalker : PackageWalker, IDependentsResolver
{
	protected override bool RaiseErrorOnCycle => false;

	protected override bool IgnoreWalkInfo => true;

	protected IPackageRepository Repository { get; private set; }

	private IDictionary<IPackage, HashSet<IPackage>> DependentsLookup { get; set; }

	internal CachedDependentsWalker(IPackageRepository repository)
		: this(repository, null)
	{
	}

	public CachedDependentsWalker(IPackageRepository repository, FrameworkName targetFramework)
		: base(targetFramework)
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
}
