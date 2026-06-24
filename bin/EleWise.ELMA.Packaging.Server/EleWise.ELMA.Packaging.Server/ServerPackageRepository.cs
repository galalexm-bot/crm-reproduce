using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Threading;
using EleWise.ELMA.Packaging.Server.DataServices;
using NuGet;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

public class ServerPackageRepository : ServerLocalPackageRepository, IServerPackageRepository, IServiceBasedRepository, IPackageRepository
{
	private readonly IDictionary<IPackage, DerivedPackageData> _derivedDataLookup = new Dictionary<IPackage, DerivedPackageData>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);

	private readonly ManualResetEvent _derivedDataComputed = new ManualResetEvent(initialState: false);

	private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

	private const int MaxWaitMs = 120000;

	private static ServerPackageRepository _instance;

	public static ServerPackageRepository Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new ServerPackageRepository();
			}
			return _instance;
		}
		set
		{
			_instance = value;
		}
	}

	public ServerPackageRepository()
		: base(PackageUtility.PackagePhysicalPath)
	{
	}

	public ServerPackageRepository(string path)
		: base(path)
	{
	}

	public ServerPackageRepository(IPackagePathResolver pathResolver, IFileSystem fileSystem)
		: base(pathResolver, fileSystem)
	{
	}

	public IQueryable<Package> GetPackagesWithDerivedData()
	{
		return GetPackages().Select((Expression<Func<IPackage, Package>>)((IPackage package) => GetMetadataPackage(package)));
	}

	public override void AddPackage(IPackage package)
	{
		string packageFileName = base.PathResolver.GetPackageFileName(package);
		using Stream stream = package.GetStream();
		base.FileSystem.AddFile(packageFileName, stream);
	}

	public void RemovePackage(string packageId, SemanticVersion version)
	{
		IPackage val = FindPackage(packageId, version);
		if (val != null)
		{
			((PackageRepositoryBase)this).RemovePackage(val);
		}
	}

	public override void RemovePackage(IPackage package)
	{
		string packageFileName = base.PathResolver.GetPackageFileName(package);
		base.FileSystem.DeleteFile(packageFileName);
		DeleteData(package);
	}

	protected override IPackage OpenPackage(string path)
	{
		IPackage val = base.OpenPackage(path);
		_cacheLock.EnterWriteLock();
		try
		{
			DateTime now = DateTime.Now;
			while (true)
			{
				if (!_derivedDataLookup.TryGetValue(val, out var value))
				{
					_derivedDataLookup[val] = null;
					break;
				}
				if (value != null)
				{
					return val;
				}
				if ((DateTime.Now - now).TotalSeconds > 120000.0)
				{
					_derivedDataLookup[val] = null;
					break;
				}
				_cacheLock.ExitWriteLock();
				_derivedDataComputed.WaitOne(120000);
				_cacheLock.EnterWriteLock();
			}
		}
		finally
		{
			_cacheLock.ExitWriteLock();
		}
		try
		{
			DerivedPackageData packageData = CalculateDerivedData(val, path);
			SetData(val, packageData);
			return val;
		}
		catch
		{
			DeleteData(val);
			throw;
		}
		finally
		{
			_derivedDataComputed.Set();
		}
	}

	private DerivedPackageData GetData(IPackage package)
	{
		_cacheLock.EnterReadLock();
		try
		{
			return _derivedDataLookup[package];
		}
		finally
		{
			_cacheLock.ExitReadLock();
		}
	}

	private void SetData(IPackage package, DerivedPackageData packageData)
	{
		_cacheLock.EnterWriteLock();
		try
		{
			_derivedDataLookup[package] = packageData;
		}
		finally
		{
			_cacheLock.ExitWriteLock();
		}
	}

	private void DeleteData(IPackage package)
	{
		_cacheLock.EnterWriteLock();
		try
		{
			_derivedDataLookup.Remove(package);
		}
		finally
		{
			_cacheLock.ExitWriteLock();
		}
	}

	public Package GetMetadataPackage(IPackage package)
	{
		return new Package(package, GetData(package));
	}

	public IQueryable<IPackage> Search(string searchTerm, IEnumerable<string> targetFrameworks, bool allowPrereleaseVersions)
	{
		return PackageExtensions.FilterByPrerelease((IEnumerable<IPackage>)PackageExtensions.Find<IPackage>(((PackageRepositoryBase)this).GetPackages(), searchTerm), allowPrereleaseVersions).AsQueryable();
	}

	public IEnumerable<IPackage> GetUpdates(IEnumerable<IPackage> packages, bool includePrerelease, bool includeAllVersions, IEnumerable<FrameworkName> targetFramework)
	{
		return PackageRepositoryExtensions.GetUpdatesCore((IPackageRepository)(object)this, (IEnumerable<IPackageName>)packages, includePrerelease, includeAllVersions, targetFramework, (IEnumerable<IVersionSpec>)null);
	}

	private DerivedPackageData CalculateDerivedData(IPackage package, string path)
	{
		string text = Path.Combine(base.FileSystem.get_Root(), path);
		long packageSize = (File.Exists(text) ? new FileInfo(text).Length : 0);
		return new DerivedPackageData
		{
			PackageSize = packageSize,
			LastUpdated = base.FileSystem.GetLastModified(path),
			Created = base.FileSystem.GetCreated(path),
			Path = path,
			FullPath = base.FileSystem.GetFullPath(path)
		};
	}

	public IEnumerable<IPackage> GetUpdates(IEnumerable<IPackageName> packages, bool includePrerelease, bool includeAllVersions, IEnumerable<FrameworkName> targetFrameworks, IEnumerable<IVersionSpec> versionConstraints)
	{
		throw new NotImplementedException();
	}
}
