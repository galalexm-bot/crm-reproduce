using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaUninstallWalker : ElmaPackageWalker, IPackageOperationResolver, IElmaPackageOperationResolver
{
	private readonly bool _removeDependencies;

	private List<IPackage> _initialPackages = new List<IPackage>();

	public bool CheckConflicts { get; set; }

	protected ILogger Logger { get; private set; }

	protected IPackageRepository Repository { get; private set; }

	protected override bool IgnoreDependencies => !_removeDependencies;

	protected override bool SkipDependencyResolveError => true;

	public Stack<PackageOperation> Operations { get; set; }

	public bool Force { get; private set; }

	public bool ThrowOnConflicts { get; set; }

	protected IDependentsResolver DependentsResolver { get; private set; }

	internal ElmaUninstallWalker(PackagingSettings settings, IPackageRepository repository, IDependentsResolver dependentsResolver, ILogger logger, bool removeDependencies, bool forceRemove)
		: this(settings, repository, dependentsResolver, null, logger, removeDependencies, forceRemove)
	{
	}

	public ElmaUninstallWalker(PackagingSettings settings, IPackageRepository repository, IDependentsResolver dependentsResolver, FrameworkName targetFramework, ILogger logger, bool removeDependencies, bool forceRemove)
		: base(settings, targetFramework)
	{
		if (dependentsResolver == null)
		{
			throw new ArgumentNullException("dependentsResolver");
		}
		if (repository == null)
		{
			throw new ArgumentNullException("repository");
		}
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		Logger = logger;
		Repository = repository;
		DependentsResolver = dependentsResolver;
		Force = forceRemove;
		Operations = new Stack<PackageOperation>();
		_removeDependencies = removeDependencies;
	}

	protected override void OnBeforePackageWalk(IPackage package)
	{
	}

	protected override bool OnAfterResolveDependency(IPackage package, IPackage dependency)
	{
		return true;
	}

	protected override void OnAfterPackageWalk(IPackage package)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Operations.Push(new PackageOperation(package, (PackageAction)1));
		if (!Force)
		{
			return;
		}
		foreach (IPackage item in (IEnumerable<IPackage>)GetDependents(package).ToList())
		{
			((PackageWalker)this).Walk(item);
		}
	}

	protected override IPackage ResolveDependency(PackageDependency dependency)
	{
		return PackageRepositoryExtensions.ResolveDependency(Repository, dependency, true, false);
	}

	protected override IPackage ResolveInstallingDependency(PackageDependency dependency)
	{
		return null;
	}

	protected override void OnDependencyResolveError(PackageDependency dependency)
	{
		Logger.Log((MessageLevel)1, SR.T("Не удалось найти зависимый пакет '{0}'. Он мог быть удален.", dependency), Array.Empty<object>());
	}

	public IEnumerable<PackageOperation> ResolveOperations(IPackage package)
	{
		return ResolveOperations((IEnumerable<IPackage>)(object)new IPackage[1] { package });
	}

	private IEnumerable<IPackage> GetDependents(IPackage package)
	{
		return from p in DependentsResolver.GetDependents(package)
			where !IsConnected(p)
			select p;
	}

	private bool IsConnected(IPackage package)
	{
		if (((PackageWalker)this).get_Marker().Contains(package))
		{
			return true;
		}
		return false;
	}

	protected override IEnumerable<string> SearchPackageIds(Expression<Func<IPackage, bool>> expression)
	{
		return (from p in PackageRepositoryExtensions.Search(Repository, "", true).Where(expression).ToList()
			where p != null
			select ((IPackageName)p).get_Id()).ToList();
	}

	public IEnumerable<PackageOperation> ResolveOperations(IEnumerable<IPackage> packages)
	{
		Operations.Clear();
		_integrationPackages.Clear();
		((PackageWalker)this).get_Marker().Clear();
		_initialPackages.Clear();
		_initialPackages.AddRange(packages);
		foreach (IPackage package2 in packages)
		{
			Logger.Log((MessageLevel)0, SR.T("Формирование операций для удаления пакета '{0}'", PackageExtensions.GetFullName((IPackageName)(object)package2)), Array.Empty<object>());
			((PackageWalker)this).Walk(package2);
		}
		IList<PackageOperation> result = PackageOperationExtensions.Reduce((IEnumerable<PackageOperation>)Operations);
		if (ThrowOnConflicts)
		{
			Logger.Log((MessageLevel)0, SR.T("Проверка совместимости пакетов..."), Array.Empty<object>());
			List<IPackage> list = new List<IPackage>();
			foreach (IPackage package in Repository.GetPackages())
			{
				if (!Operations.Any((PackageOperation o) => PackageEqualityComparer.IdAndVersion.Equals((IPackageName)(object)package, (IPackageName)(object)o.get_Package()) && (int)o.get_Action() == 1))
				{
					list.Add(package);
				}
			}
			list.AddRange(from o in Operations
				where (int)o.get_Action() == 0
				select o.get_Package());
			CheckPackageConflicts(list);
			Logger.Log((MessageLevel)2, SR.T("Проверка совместимости пакетов завершена"), Array.Empty<object>());
		}
		return result;
	}
}
