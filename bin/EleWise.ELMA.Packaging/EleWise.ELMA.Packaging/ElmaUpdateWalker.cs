using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaUpdateWalker : ElmaInstallWalker
{
	private readonly IDependentsResolver _dependentsResolver;

	private IEnumerable<IPackage> _sourceRepositoryPackages;

	public PackageTargets AcceptedTargets { get; set; }

	internal ElmaUpdateWalker(PackagingSettings settings, IPackageRepository localRepository, IPackageRepository sourceRepository, IDependentsResolver dependentsResolver, IPackageConstraintProvider constraintProvider, ILogger logger, bool updateDependencies, bool allowPrereleaseVersions)
		: this(settings, localRepository, sourceRepository, dependentsResolver, constraintProvider, null, logger, updateDependencies, allowPrereleaseVersions)
	{
	}

	public ElmaUpdateWalker(PackagingSettings settings, IPackageRepository localRepository, IPackageRepository sourceRepository, IDependentsResolver dependentsResolver, IPackageConstraintProvider constraintProvider, FrameworkName targetFramework, ILogger logger, bool updateDependencies, bool allowPrereleaseVersions)
		: base(settings, localRepository, sourceRepository, constraintProvider, targetFramework, logger, !updateDependencies, allowPrereleaseVersions)
	{
		_dependentsResolver = dependentsResolver;
		AcceptedTargets = (PackageTargets)3;
	}

	public override IEnumerable<PackageOperation> ResolveOperations(IEnumerable<IPackage> packages)
	{
		ElmaDependentsWalker elmaDependentsWalker = _dependentsResolver as ElmaDependentsWalker;
		if (elmaDependentsWalker != null)
		{
			elmaDependentsWalker._installingPackages = packages;
		}
		try
		{
			return base.ResolveOperations(packages);
		}
		finally
		{
			if (elmaDependentsWalker != null)
			{
				elmaDependentsWalker._installingPackages = null;
			}
		}
	}

	protected override ConflictResult GetConflict(IPackage package)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ConflictResult val = base.GetConflict(package);
		if (val == null)
		{
			IPackage val2 = PackageRepositoryExtensions.FindPackage(base.Repository, ((IPackageName)package).get_Id());
			if (val2 != null)
			{
				val = new ConflictResult(val2, base.Repository, _dependentsResolver);
			}
		}
		return val;
	}

	protected override IEnumerable<string> SearchPackageIds(Expression<Func<IPackage, bool>> expression)
	{
		if (_sourceRepositoryPackages == null)
		{
			_sourceRepositoryPackages = PackageRepositoryExtensions.Search(base.SourceRepository, "", ((PackageWalker)this).get_AllowPrereleaseVersions());
		}
		return from p in _sourceRepositoryPackages.Where(expression.Compile()).ToList()
			where p != null
			select ((IPackageName)p).get_Id();
	}
}
