using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaInstallWalker : ElmaPackageWalker, IPackageOperationResolver, IElmaPackageOperationResolver
{
	private class OperationLookup
	{
		private readonly List<PackageOperation> _operations = new List<PackageOperation>();

		private readonly Dictionary<PackageAction, Dictionary<IPackage, PackageOperation>> _operationLookup = new Dictionary<PackageAction, Dictionary<IPackage, PackageOperation>>();

		internal void Clear()
		{
			_operations.Clear();
			_operationLookup.Clear();
		}

		internal IList<PackageOperation> ToList()
		{
			return _operations;
		}

		internal IEnumerable<IPackage> GetPackages(PackageAction action)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<IPackage, PackageOperation> packageLookup = GetPackageLookup(action);
			if (packageLookup != null)
			{
				return packageLookup.Keys;
			}
			return Enumerable.Empty<IPackage>();
		}

		internal void AddOperation(PackageOperation operation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<IPackage, PackageOperation> packageLookup = GetPackageLookup(operation.get_Action(), createIfNotExists: true);
			if (!packageLookup.ContainsKey(operation.get_Package()))
			{
				packageLookup.Add(operation.get_Package(), operation);
				_operations.Add(operation);
			}
		}

		internal void RemoveOperation(IPackage package, PackageAction action)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<IPackage, PackageOperation> packageLookup = GetPackageLookup(action);
			if (packageLookup != null && packageLookup.TryGetValue(package, out var value))
			{
				packageLookup.Remove(package);
				_operations.Remove(value);
			}
		}

		internal bool Contains(IPackage package, PackageAction action)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return GetPackageLookup(action)?.ContainsKey(package) ?? false;
		}

		private Dictionary<IPackage, PackageOperation> GetPackageLookup(PackageAction action, bool createIfNotExists = false)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			if (!_operationLookup.TryGetValue(action, out var value) && createIfNotExists)
			{
				value = new Dictionary<IPackage, PackageOperation>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
				_operationLookup.Add(action, value);
			}
			return value;
		}
	}

	private class DependencyConnection
	{
		public IPackage ParentPackage { get; set; }

		public IPackage ChildPackage { get; set; }

		public override string ToString()
		{
			return ((object)ParentPackage).ToString() + " --> " + ((object)ChildPackage).ToString();
		}
	}

	private readonly bool _ignoreDependencies;

	private readonly bool _allowPrereleaseVersions;

	private readonly OperationLookup _operations;

	private IEnumerable<IPackage> _installingPackages;

	private ElmaUninstallWalker uninstallWalker;

	private readonly HashSet<IPackage> _packagesToKeep = new HashSet<IPackage>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);

	private readonly HashSet<IPackage> packagesToReinstall = new HashSet<IPackage>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);

	private IEnumerable<IPackage> sourceRepositoryPackages;

	public bool UpdateDependencies { get; set; }

	public bool ThrowOnConflicts { get; set; }

	public bool WarningOnDependencyMissing { get; set; }

	public IEnumerable<IPackage> PackagesToReinstall => packagesToReinstall;

	protected ILogger Logger { get; private set; }

	protected IPackageRepository Repository { get; private set; }

	protected override bool IgnoreDependencies => _ignoreDependencies;

	protected override bool AllowPrereleaseVersions => _allowPrereleaseVersions;

	protected IPackageRepository SourceRepository { get; private set; }

	private IPackageConstraintProvider ConstraintProvider { get; set; }

	protected IList<PackageOperation> Operations => _operations.ToList();

	internal ElmaInstallWalker(PackagingSettings settings, IPackageRepository localRepository, IPackageRepository sourceRepository, ILogger logger, bool ignoreDependencies, bool allowPrereleaseVersions)
		: this(settings, localRepository, sourceRepository, null, logger, ignoreDependencies, allowPrereleaseVersions)
	{
	}

	public ElmaInstallWalker(PackagingSettings settings, IPackageRepository localRepository, IPackageRepository sourceRepository, FrameworkName targetFramework, ILogger logger, bool ignoreDependencies, bool allowPrereleaseVersions)
		: this(settings, localRepository, sourceRepository, (IPackageConstraintProvider)(object)NullConstraintProvider.get_Instance(), targetFramework, logger, ignoreDependencies, allowPrereleaseVersions)
	{
	}

	public ElmaInstallWalker(PackagingSettings settings, IPackageRepository localRepository, IPackageRepository sourceRepository, IPackageConstraintProvider constraintProvider, FrameworkName targetFramework, ILogger logger, bool ignoreDependencies, bool allowPrereleaseVersions)
		: base(settings, targetFramework)
	{
		if (sourceRepository == null)
		{
			throw new ArgumentNullException("sourceRepository");
		}
		if (localRepository == null)
		{
			throw new ArgumentNullException("localRepository");
		}
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		Repository = localRepository;
		Logger = logger;
		SourceRepository = sourceRepository;
		_ignoreDependencies = ignoreDependencies;
		ConstraintProvider = constraintProvider;
		_operations = new OperationLookup();
		_allowPrereleaseVersions = allowPrereleaseVersions;
	}

	protected virtual ConflictResult GetConflict(IPackage package)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		IPackage val = PackageRepositoryExtensions.FindPackage((IPackageRepository)(object)((PackageWalker)this).get_Marker(), ((IPackageName)package).get_Id());
		if (val != null)
		{
			return new ConflictResult(val, (IPackageRepository)(object)((PackageWalker)this).get_Marker(), (IDependentsResolver)(object)((PackageWalker)this).get_Marker());
		}
		return null;
	}

	protected override void OnBeforePackageWalk(IPackage package)
	{
		ConflictResult conflict = GetConflict(package);
		if (conflict == null)
		{
			return;
		}
		bool num = PackageEqualityComparer.IdAndVersion.Equals((IPackageName)(object)package, (IPackageName)(object)conflict.get_Package());
		bool flag = base.PackageFrameworkComparer == null || base.PackageFrameworkComparer(((IPackageName)package).get_Id());
		if (!(num && flag))
		{
			if (!((IPackageName)package).get_Version().Equals(((IPackageName)conflict.get_Package()).get_Version()))
			{
				Uninstall(conflict.get_Package(), conflict.get_DependentsResolver(), conflict.get_Repository());
			}
			else if (!flag)
			{
				Reinstall(package);
			}
		}
	}

	private void Reinstall(IPackage package)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		packagesToReinstall.Add(package);
		if (!_operations.Contains(package, (PackageAction)0))
		{
			_operations.AddOperation(new PackageOperation(package, (PackageAction)0));
		}
	}

	private void Uninstall(IPackage package, IDependentsResolver dependentsResolver, IPackageRepository repository)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		_packagesToKeep.Remove(package);
		if (!((PackageWalker)this).get_Marker().Contains(package) && _operations.Contains(package, (PackageAction)1))
		{
			return;
		}
		if (uninstallWalker == null)
		{
			uninstallWalker = new ElmaUninstallWalker(base.Settings, repository, (IDependentsResolver)(object)new CachedDependentsWalker(repository, ((PackageWalker)this).get_TargetFramework()), ((PackageWalker)this).get_TargetFramework(), Logger, removeDependencies: false, forceRemove: false)
			{
				ThrowOnConflicts = false,
				UseElmaMetadata = false
			};
		}
		foreach (PackageOperation item in uninstallWalker.ResolveOperations(package))
		{
			if ((int)item.get_Action() == 0 || !_packagesToKeep.Contains(item.get_Package()))
			{
				_operations.AddOperation(item);
			}
		}
	}

	protected override void OnAfterPackageWalk(IPackage package)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		base.OnAfterPackageWalk(package);
		if (PackageRepositoryExtensions.Exists(Repository, (IPackageName)(object)package) && base.PackagesToRemove.Contains(((IPackageName)package).get_Id()))
		{
			_operations.AddOperation(new PackageOperation(package, (PackageAction)1));
			return;
		}
		if (!PackageRepositoryExtensions.Exists(Repository, (IPackageName)(object)package))
		{
			_operations.AddOperation(new PackageOperation(package, (PackageAction)0));
			return;
		}
		IPackage val = ((_installingPackages != null && !base.PackagesToRemove.Contains(((IPackageName)package).get_Id())) ? _installingPackages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id().Equals(((IPackageName)package).get_Id())) : null);
		if (val == null || ((IPackageName)val).get_Version() <= ((IPackageName)package).get_Version())
		{
			_operations.RemoveOperation(package, (PackageAction)1);
			_packagesToKeep.Add(package);
		}
	}

	protected override IPackage ResolveDependency(PackageDependency dependency)
	{
		Logger.Log((MessageLevel)2, SR.T("Поиск пакета по зависимости '{0}'...", dependency), Array.Empty<object>());
		IPackage val = ((_installingPackages != null) ? _installingPackages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id() == dependency.get_Id()) : null);
		if (val != null && (dependency.get_VersionSpec() == null || VersionExtensions.ToDelegate(dependency.get_VersionSpec())(val)))
		{
			return val;
		}
		IPackage val2 = PackageRepositoryExtensions.ResolveDependency(Repository, dependency, ConstraintProvider, true, false, (DependencyVersion)3);
		if (val2 == null || UpdateDependencies || (dependency.get_VersionSpec() != null && !VersionExtensions.ToDelegate(dependency.get_VersionSpec())(val2)))
		{
			IPackage val3 = PackageRepositoryExtensions.ResolveDependency(SourceRepository, dependency, ConstraintProvider, ((PackageWalker)this).get_AllowPrereleaseVersions(), true, (DependencyVersion)3);
			if (val2 == null)
			{
				if (val3 == null)
				{
					Logger.Log((MessageLevel)2, SR.T("Пакет не найден."), Array.Empty<object>());
				}
				else
				{
					Logger.Log((MessageLevel)2, SR.T("Найден пакет '{0}'.", PackageExtensions.GetFullName((IPackageName)(object)val3)), Array.Empty<object>());
				}
				return val3;
			}
			if (val3 != null && ((IPackageName)val2).get_Version() < ((IPackageName)val3).get_Version())
			{
				Logger.Log((MessageLevel)2, SR.T("Найден пакет '{0}'.", PackageExtensions.GetFullName((IPackageName)(object)val3)), Array.Empty<object>());
				return val3;
			}
		}
		Logger.Log((MessageLevel)2, SR.T("Найден пакет '{0}' в локальном репозитории.", PackageExtensions.GetFullName((IPackageName)(object)val2)), Array.Empty<object>());
		return val2;
	}

	protected override IPackage ResolveInstallingDependency(PackageDependency dependency)
	{
		IPackage val = ((_installingPackages != null && !base.PackagesToRemove.Contains(dependency.get_Id())) ? _installingPackages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id() == dependency.get_Id()) : null);
		if (val != null && (dependency.get_VersionSpec() == null || VersionExtensions.ToDelegate(dependency.get_VersionSpec())(val)))
		{
			return val;
		}
		return null;
	}

	protected override void OnDependencyResolveError(PackageDependency dependency)
	{
		IVersionSpec constraint = ConstraintProvider.GetConstraint(dependency.get_Id());
		string text = string.Empty;
		if (constraint != null)
		{
			text = " " + SR.T("'{0}' имеет дополнительное ограничение {1}, заданное в {2}.", dependency.get_Id(), VersionUtility.PrettyPrint(constraint), ConstraintProvider.get_Source());
		}
		if (WarningOnDependencyMissing)
		{
			Logger.Log((MessageLevel)1, SR.T("Не удалось разрешить зависимость \"{0}\"", dependency) + text, Array.Empty<object>());
			return;
		}
		throw new InvalidOperationException(SR.T("Не удалось разрешить зависимость \"{0}\"", dependency) + text);
	}

	public IEnumerable<PackageOperation> ResolveOperations(IPackage package)
	{
		return ResolveOperations((IEnumerable<IPackage>)(object)new IPackage[1] { package });
	}

	private IEnumerable<IPackage> GetDependents(ConflictResult conflict)
	{
		IEnumerable<IPackage> packages = _operations.GetPackages((PackageAction)1);
		return conflict.get_DependentsResolver().GetDependents(conflict.get_Package()).Except(packages, (IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
	}

	private static InvalidOperationException CreatePackageConflictException(IPackage resolvedPackage, IPackage package, IEnumerable<IPackage> dependents)
	{
		if (dependents.Count() == 1)
		{
			return new InvalidOperationException(SR.T("Обновление '{0}' до '{1}' завершилось ошибкой. Не удалось найти версию пакета '{2}', который совместим с '{1}'.", PackageExtensions.GetFullName((IPackageName)(object)package), PackageExtensions.GetFullName((IPackageName)(object)resolvedPackage), ((IPackageName)dependents.Single()).get_Id()));
		}
		return new InvalidOperationException(SR.T("Обновление '{0}' до '{1}' завершилось ошибкой. Не удалось найти версии пакета '{2}', которые совместимы с '{1}'.", PackageExtensions.GetFullName((IPackageName)(object)package), PackageExtensions.GetFullName((IPackageName)(object)resolvedPackage), string.Join(", ", dependents.Select((IPackage d) => ((IPackageName)d).get_Id()))));
	}

	protected override IEnumerable<string> SearchPackageIds(Expression<Func<IPackage, bool>> expression)
	{
		if (sourceRepositoryPackages == null)
		{
			sourceRepositoryPackages = PackageRepositoryExtensions.Search(SourceRepository, "", ((PackageWalker)this).get_AllowPrereleaseVersions()).ToList();
		}
		return (from p in PackageRepositoryExtensions.Search(Repository, "", true).Where(expression).ToList()
			where p != null
			select ((IPackageName)p).get_Id()).Union(from p in sourceRepositoryPackages.Where(expression.Compile()).ToList()
			where p != null
			select ((IPackageName)p).get_Id()).Distinct().ToList();
	}

	public virtual IEnumerable<PackageOperation> ResolveOperations(IEnumerable<IPackage> packages)
	{
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		_installingPackages = packages;
		try
		{
			Action action = delegate
			{
				_operations.Clear();
				_integrationPackages.Clear();
				((PackageWalker)this).get_Marker().Clear();
				_packagesToKeep.Clear();
				foreach (IPackage item in packages.Where((IPackage p) => !base.PackagesToRemove.Contains(((IPackageName)p).get_Id())))
				{
					Logger.Log((MessageLevel)0, SR.T("Формирование операций для установки/обновления пакета '{0}'", PackageExtensions.GetFullName((IPackageName)(object)item)), Array.Empty<object>());
					((PackageWalker)this).Walk(item);
				}
			};
			Func<List<IPackage>> func = delegate
			{
				List<IPackage> list3 = new List<IPackage>();
				foreach (IPackage package2 in Repository.GetPackages())
				{
					if (!Operations.Any((PackageOperation o) => PackageEqualityComparer.IdAndVersion.Equals((IPackageName)(object)package2, (IPackageName)(object)o.get_Package()) && (int)o.get_Action() == 1))
					{
						list3.Add(package2);
					}
				}
				list3.AddRange(from o in Operations
					where (int)o.get_Action() == 0
					select o.get_Package());
				return list3;
			};
			action();
			List<IPackage> resultPackages = func();
			Logger.Log((MessageLevel)2, SR.T("Набор пакетов для установки после первого прохода:"), Array.Empty<object>());
			foreach (IPackage item2 in resultPackages)
			{
				Logger.Log((MessageLevel)2, $"  '{item2}'", Array.Empty<object>());
			}
			List<string> list = new List<string>();
			IEnumerable<string> enumerable = (from d in resultPackages.SelectMany((IPackage p) => ((IXPackageMetadata)p).get_UninstallDependencies() ?? Enumerable.Empty<PackageUninstallDependency>())
				select d.get_Id()).Distinct();
			Logger.Log((MessageLevel)2, SR.T("Набор устаревших пакетов:"), Array.Empty<object>());
			foreach (string item3 in enumerable)
			{
				Logger.Log((MessageLevel)2, $"  '{item3}'", Array.Empty<object>());
			}
			foreach (string uninstallDepId in enumerable)
			{
				if (!list.Contains(uninstallDepId, StringComparer.OrdinalIgnoreCase) && !base.PackagesToRemove.Contains(uninstallDepId, StringComparer.OrdinalIgnoreCase) && resultPackages.Any((IPackage p) => ((IPackageName)p).get_Id().Equals(uninstallDepId, StringComparison.OrdinalIgnoreCase)))
				{
					list.Add(uninstallDepId);
				}
			}
			IEnumerable<IPackage> source = resultPackages.Where(delegate(IPackage p)
			{
				ConflictResult conflict = GetConflict(p);
				return conflict == null || !GetDependents(conflict).Any();
			});
			IEnumerable<DependencyConnection> dependencyConnections = GetDependencyConnections(resultPackages);
			IEnumerable<IPackage> collection = source.Where((IPackage p) => IsAnyUnsatisfiedDependency(p, resultPackages));
			Stack<IPackage> stack = new Stack<IPackage>(collection);
			HashSet<IPackage> hashSet = new HashSet<IPackage>(collection, (IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
			while (stack.Count > 0)
			{
				IPackage package = stack.Pop();
				foreach (IPackage dependentPackage in from dc in dependencyConnections
					where IsIdenticalPackages(dc.ParentPackage, package)
					select dc into c
					select c.ChildPackage)
				{
					IEnumerable<DependencyConnection> source2 = dependencyConnections.Where((DependencyConnection dc) => IsIdenticalPackages(dc.ChildPackage, dependentPackage) && !IsIdenticalPackages(dc.ParentPackage, package));
					if (hashSet.Any((IPackage p) => IsIdenticalPackages(p, dependentPackage)) || !source2.Any())
					{
						stack.Push(dependentPackage);
						hashSet.Add(dependentPackage);
					}
				}
			}
			if (hashSet.Count > 0)
			{
				Logger.Log((MessageLevel)2, SR.T("Возможно, ненужные пакеты (кандидаты на удаление через nuspecx):"), Array.Empty<object>());
				foreach (IPackage item4 in hashSet)
				{
					Logger.Log((MessageLevel)2, $"  '{item4}'", Array.Empty<object>());
				}
			}
			if (list.Count > 0)
			{
				Logger.Log((MessageLevel)2, SR.T("Новые пакеты для удаления:"), Array.Empty<object>());
				foreach (string item5 in list)
				{
					Logger.Log((MessageLevel)2, $"  '{item5}'", Array.Empty<object>());
				}
				base.PackagesToRemove.AddRange(list);
				Logger.Log((MessageLevel)0, SR.T("Обнаружены дополнительные пакеты, которые следует удалить. Запускаем второй проход для вычисления требуемых операций."), Array.Empty<object>());
				action();
			}
			foreach (string item6 in base.PackagesToRemove)
			{
				foreach (IPackage item7 in PackageRepositoryExtensions.FindPackagesById(Repository, item6))
				{
					_operations.AddOperation(new PackageOperation(item7, (PackageAction)1));
				}
			}
			IList<PackageOperation> currentOperations = _operations.ToList();
			foreach (IPackage item8 in _integrationPackages.ToList())
			{
				ElmaPackageMetadata elmaPackageMetadata = new ElmaPackageMetadata(((IPackageMetadata)item8).get_Tags());
				bool flag = true;
				foreach (string ownerId2 in elmaPackageMetadata.OwnerIds)
				{
					if (!currentOperations.Any((PackageOperation o) => ((IPackageName)o.get_Package()).get_Id().Equals(ownerId2, StringComparison.CurrentCultureIgnoreCase) && (int)o.get_Action() == 0) && !(from p in PackageRepositoryExtensions.FindPackagesById(Repository, ownerId2)
						where !currentOperations.Any((PackageOperation o) => ((IPackageName)o.get_Package()).get_Id().Equals(((IPackageName)p).get_Id(), StringComparison.CurrentCultureIgnoreCase) && ((IPackageName)o.get_Package()).get_Version().Equals(((IPackageName)p).get_Version()) && (int)o.get_Action() == 1)
						select p).Any())
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					Logger.Log((MessageLevel)0, SR.T("Формирование операций для установки/обновления пакета интеграции '{0}'", PackageExtensions.GetFullName((IPackageName)(object)item8)), Array.Empty<object>());
					((PackageWalker)this).Walk(item8);
				}
			}
			IList<PackageOperation> list2 = PackageOperationExtensions.Reduce((IEnumerable<PackageOperation>)Operations);
			if (ThrowOnConflicts)
			{
				Logger.Log((MessageLevel)0, SR.T("Проверка совместимости пакетов..."), Array.Empty<object>());
				resultPackages = func();
				Logger.Log((MessageLevel)2, SR.T("Конечный набор пакетов:"), Array.Empty<object>());
				foreach (IPackage item9 in resultPackages)
				{
					Logger.Log((MessageLevel)2, $"  '{item9}'", Array.Empty<object>());
				}
				if (base.UseElmaMetadata)
				{
					foreach (IPackage item10 in resultPackages.ToList())
					{
						ElmaPackageMetadata elmaPackageMetadata2 = new ElmaPackageMetadata(((IPackageMetadata)item10).get_Tags());
						if (elmaPackageMetadata2.Type != ElmaPackageType.Help)
						{
							continue;
						}
						foreach (string ownerId in elmaPackageMetadata2.OwnerIds)
						{
							VersionSpec val = new VersionSpec();
							val.set_MinVersion(new SemanticVersion(((IPackageName)item10).get_Version().get_Version().Major, ((IPackageName)item10).get_Version().get_Version().Minor, ((IPackageName)item10).get_Version().get_Version().Build, 0));
							val.set_IsMinInclusive(true);
							val.set_MaxVersion(new SemanticVersion(((IPackageName)item10).get_Version().get_Version().Major, ((IPackageName)item10).get_Version().get_Version().Minor, ((IPackageName)item10).get_Version().get_Version().Build + 1, 0));
							val.set_IsMaxInclusive(false);
							VersionSpec val2 = val;
							IPackage val3 = resultPackages.FirstOrDefault((IPackage p) => ((IPackageName)p).get_Id() == ownerId);
							if (val3 != null && !VersionExtensions.Satisfies((IVersionSpec)(object)val2, ((IPackageName)val3).get_Version()))
							{
								list2.Insert(0, new PackageOperation(item10, (PackageAction)1));
								resultPackages.Remove(item10);
								break;
							}
						}
					}
					list2 = PackageOperationExtensions.Reduce((IEnumerable<PackageOperation>)list2);
				}
				CheckPackageConflicts(resultPackages);
				Logger.Log((MessageLevel)2, SR.T("Проверка совместимости пакетов завершена"), Array.Empty<object>());
			}
			return list2;
		}
		finally
		{
			_installingPackages = null;
		}
	}

	private bool IsAnyUnsatisfiedDependency(IPackage package, IEnumerable<IPackage> resultPackages)
	{
		return !GetPackageDependencies(package).All((PackageDependency d) => resultPackages.Any((IPackage p) => IsPackageMatchesDependency(p, d)));
	}

	private IEnumerable<DependencyConnection> GetDependencyConnections(IEnumerable<IPackage> resultPackages)
	{
		foreach (IPackage package in resultPackages)
		{
			IEnumerable<PackageDependency> packageDependencies = GetPackageDependencies(package);
			foreach (PackageDependency dependency in packageDependencies)
			{
				IEnumerable<IPackage> enumerable = resultPackages.Where((IPackage p) => IsPackageMatchesDependency(p, dependency));
				foreach (IPackage item in enumerable)
				{
					yield return new DependencyConnection
					{
						ParentPackage = package,
						ChildPackage = item
					};
				}
			}
		}
	}

	private IEnumerable<PackageDependency> GetPackageDependencies(IPackage package)
	{
		if (((IPackageMetadata)package).get_DependencySets() == null)
		{
			return Enumerable.Empty<PackageDependency>();
		}
		PackageDependencySet val = VersionUtility.GetNearestDependencySet(package, ((PackageWalker)this).get_TargetFramework()) ?? ((IPackageMetadata)package).get_DependencySets().FirstOrDefault((PackageDependencySet ds) => ds.get_TargetFramework() == null);
		if (val == null)
		{
			return Enumerable.Empty<PackageDependency>();
		}
		return val.get_Dependencies();
	}

	private bool IsIdenticalPackages(IPackage left, IPackage right)
	{
		if (((IPackageName)left).get_Id() == ((IPackageName)right).get_Id())
		{
			return ((IPackageName)left).get_Version() == ((IPackageName)right).get_Version();
		}
		return false;
	}

	private bool IsPackageMatchesDependency(IPackage package, PackageDependency dependency)
	{
		if (((IPackageName)package).get_Id() == dependency.get_Id())
		{
			return VersionExtensions.Satisfies(dependency.get_VersionSpec(), ((IPackageName)package).get_Version());
		}
		return false;
	}
}
